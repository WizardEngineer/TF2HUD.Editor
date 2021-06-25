﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HUDEditor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HUDEditor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to https://www.editor.criticalflaw.ca/.
        /// </summary>
        internal static string app_docs {
            get {
                return ResourceManager.GetString("app_docs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://raw.githubusercontent.com/CriticalFlaw/TF2HUD.Editor/master/src/TF2HUD.Editor/JSON/{0}.
        /// </summary>
        internal static string app_json_file {
            get {
                return ResourceManager.GetString("app_json_file", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.github.com/repositories/331154113/contents/src/TF2HUD.Editor/JSON.
        /// </summary>
        internal static string app_json_list {
            get {
                return ResourceManager.GetString("app_json_list", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/CriticalFlaw/TF2HUD.Editor/issues.
        /// </summary>
        internal static string app_tracker {
            get {
                return ResourceManager.GetString("app_tracker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://raw.githubusercontent.com/CriticalFlaw/TF2HUD.Editor/master/Update.xml.
        /// </summary>
        internal static string app_update {
            get {
                return ResourceManager.GetString("app_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select your tf/custom directory. If a valid directory is not provided, the options to use the editor will not be available..
        /// </summary>
        internal static string ask_folder_browser {
            get {
                return ResourceManager.GetString("ask_folder_browser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to reset all customization options back to default?.
        /// </summary>
        internal static string ask_reset_options {
            get {
                return ResourceManager.GetString("ask_reset_options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The tf/custom directory must be set to use the editor..
        /// </summary>
        internal static string error_app_directory {
            get {
                return ResourceManager.GetString("error_app_directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while installing {0}..
        /// </summary>
        internal static string error_app_install {
            get {
                return ResourceManager.GetString("error_app_install", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while uninstalling {0}..
        /// </summary>
        internal static string error_app_uninstall {
            get {
                return ResourceManager.GetString("error_app_uninstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while toggling transparent viewmodels..
        /// </summary>
        internal static string error_transparent_vm {
            get {
                return ResourceManager.GetString("error_transparent_vm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An existing {0} folder has been found. To avoid conflicts, a backup has been created..
        /// </summary>
        internal static string info_create_backup {
            get {
                return ResourceManager.GetString("info_create_backup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Following changes require the game to be restarted:.
        /// </summary>
        internal static string info_game_restart {
            get {
                return ResourceManager.GetString("info_game_restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to continue because Team Fortress 2 is still running. Please close it and then try again..
        /// </summary>
        internal static string info_game_running {
            get {
                return ResourceManager.GetString("info_game_running", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has been successfully installed..
        /// </summary>
        internal static string info_install_complete {
            get {
                return ResourceManager.GetString("info_install_complete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new tf/custom directory has been set..
        /// </summary>
        internal static string info_path_correct {
            get {
                return ResourceManager.GetString("info_path_correct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You either selected the same directory or your selection did not end with tf/custom. Please try again..
        /// </summary>
        internal static string info_path_incorrect {
            get {
                return ResourceManager.GetString("info_path_incorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No new schema updates. Please check back later..
        /// </summary>
        internal static string info_schema_nothing {
            get {
                return ResourceManager.GetString("info_schema_nothing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s a new schema update available. Would you like to restart now to apply the new changes?.
        /// </summary>
        internal static string info_schema_update {
            get {
                return ResourceManager.GetString("info_schema_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has been successfully uninstalled..
        /// </summary>
        internal static string info_uninstall_complete {
            get {
                return ResourceManager.GetString("info_uninstall_complete", resourceCulture);
            }
        }
    }
}
