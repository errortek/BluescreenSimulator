﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluescreenSimulator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Windows7BluescreenResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Windows7BluescreenResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BluescreenSimulator.Properties.Windows7BluescreenResources", typeof(Windows7BluescreenResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Physical memory dump complete.
        ///Contact your system administator or technical support group for further assistance..
        /// </summary>
        public static string DumpComplete {
            get {
                return ResourceManager.GetString("DumpComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dumping physical memory to disk: @p.
        /// </summary>
        public static string DumpProgress {
            get {
                return ResourceManager.GetString("DumpProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collecting data for crash dump...
        ///Initializing disk for crash dump...
        ///Beginning dump of physical memory..
        /// </summary>
        public static string DumpStart {
            get {
                return ResourceManager.GetString("DumpStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IRQL_NOT_LESS_OR_EQUAL.
        /// </summary>
        public static string ErrorCode {
            get {
                return ResourceManager.GetString("ErrorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A problem has been detected and windows has been shutdown to prevent damage to your computer..
        /// </summary>
        public static string Header {
            get {
                return ResourceManager.GetString("Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check to make sure any hardware or software is properly installed.
        ///If this is a new installation. ask your hardware or software manufacturer for any windows updates you might need.
        ///
        ///If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing. If you need to use Safe Mode to remove or disable components, restart your computer, press F8 to select Advanced Startup Options, and then select Safe Mode..
        /// </summary>
        public static string Steps {
            get {
                return ResourceManager.GetString("Steps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this is the first time you&apos;ve seen this error screen, restart your computer. if this screen appears again. follow these steps:.
        /// </summary>
        public static string StepsHeader {
            get {
                return ResourceManager.GetString("StepsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** STOP: 0x000000FE (0x00000008, 0x000000006, 0x00000009, 0x847075cc).
        /// </summary>
        public static string StopCode {
            get {
                return ResourceManager.GetString("StopCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Technical information:.
        /// </summary>
        public static string TechnicalInfoHeader {
            get {
                return ResourceManager.GetString("TechnicalInfoHeader", resourceCulture);
            }
        }
    }
}