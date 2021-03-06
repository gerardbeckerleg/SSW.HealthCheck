﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SSW.HealthCheck.Infrastructure
{
    using System.Linq;
    using System.Web;

    public class HealthCheckService
    {
        public static readonly HealthCheckService Default = new HealthCheckService();

        private ConcurrentDictionary<string, ITest> tests = new ConcurrentDictionary<string, ITest>();
        private ConcurrentDictionary<string, TestMonitor> monitors = new ConcurrentDictionary<string, TestMonitor>();

        public event EventHandler TestStarted;
        public event EventHandler TestCompleted;
        public event EventHandler<TestEvent> TestEventReceived;
        public event EventHandler<TestProgress> TestProgressChanged;

        private HttpContext httpContext = null;

        public HttpContext HttpContext
        {
            get
            {
                return httpContext;
            }

            set
            {
                foreach (var monitor in this.monitors)
                {
                    this.monitors[monitor.Key].HttpContext = value;
                }

                this.httpContext = value;
            }
        }

        public HealthCheckService()
        {
            
        }

        protected void OnTestStarted(object sender, EventArgs e)
        {
            if (TestStarted != null)
            {
                TestStarted(sender, e);
            }
        }

        protected void OnTestCompleted(object sender, EventArgs e)
        {
            if (TestCompleted != null)
            {
                TestCompleted(sender, e);
            }
        }

        protected void OnTestEventReceived(object sender, TestEvent e)
        {
            if (TestEventReceived != null)
            {
                TestEventReceived(sender, e);
            }
        }

        protected void OnProgressChanged(object sender, TestProgress p)
        {
            if (TestProgressChanged != null)
            {
                TestProgressChanged(sender, p);
            }
        }

        public TestMonitor Add(ITest test)
        {
            var key = test.GetType().FullName;
            var keyFormat = key + ".{0}";
            var i = 1;
            while (!tests.TryAdd(key, test))
            {
                key = string.Format(keyFormat, i);
                i++;
            }
            var monitor = monitors.GetOrAdd(key, (k) =>
            {
                var m = new TestMonitor(this, k, test) { HttpContext = this.HttpContext };
                m.Started += OnTestStarted;
                m.Completed += OnTestCompleted;
                m.EventReceived += OnTestEventReceived;
                m.ProgressChanged += OnProgressChanged;
                return m;
            });
            return monitor;
        }

        public bool OrderByName { get; set; }

        public IEnumerable<TestMonitor> GetAll()
        {   
            return this.monitors.Values.OrderBy(t => t.Order).ThenBy(t => t.Name);
        }

        public TestMonitor GetByKey(string key)
        {
            TestMonitor monitor;
            if (monitors.TryGetValue(key, out monitor))
            {
                return monitor;
            }
            else
            {
                throw new ArgumentException(string.Format("TestMonitor with key {0} cannot be found.", key));
            }
        }
    }

}
