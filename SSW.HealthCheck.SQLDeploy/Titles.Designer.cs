﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSW.HealthCheck.SQLDeploy {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Titles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Titles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SSW.HealthCheck.SQLDeploy.Titles", typeof(Titles).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} database check failed: {1}.
        /// </summary>
        internal static string DbCheckFailed {
            get {
                return ResourceManager.GetString("DbCheckFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} database is up to date..
        /// </summary>
        internal static string DbIsUpToDate {
            get {
                return ResourceManager.GetString("DbIsUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following databases are not up to date: {0}..
        /// </summary>
        internal static string DbsNotUpToDate {
            get {
                return ResourceManager.GetString("DbsNotUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to schema is up to date, but it was manually changed by user..
        /// </summary>
        internal static string SchemaChanged {
            get {
                return ResourceManager.GetString("SchemaChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to schema is not up to date..
        /// </summary>
        internal static string SchemaNotUpToDate {
            get {
                return ResourceManager.GetString("SchemaNotUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performs a test to make sure your databases are up to date and haven&apos;t been changed from outside..
        /// </summary>
        internal static string TestDescription {
            get {
                return ResourceManager.GetString("TestDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQL Deploy Test.
        /// </summary>
        internal static string TestTitle {
            get {
                return ResourceManager.GetString("TestTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update.
        /// </summary>
        internal static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
    }
}
