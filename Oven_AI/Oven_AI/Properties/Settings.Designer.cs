﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oven_AI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\GEM\\local\\pcb")]
        public string SourceFolderPath {
            get {
                return ((string)(this["SourceFolderPath"]));
            }
            set {
                this["SourceFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\GEM\\machine_learning\\training")]
        public string DestinationFolderPath {
            get {
                return ((string)(this["DestinationFolderPath"]));
            }
            set {
                this["DestinationFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\GEM\\machine_learning\\processed")]
        public string ArchiveFolderPath {
            get {
                return ((string)(this["ArchiveFolderPath"]));
            }
            set {
                this["ArchiveFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int Interval {
            get {
                return ((int)(this["Interval"]));
            }
            set {
                this["Interval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\ian-h\\AppData\\Local\\Programs\\Python\\Python36-32\\Python.exe")]
        public string PythonPath {
            get {
                return ((string)(this["PythonPath"]));
            }
            set {
                this["PythonPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Kostal\\Machine_Learning_Processing\\Linear_Regression_with_REHM.py")]
        public string PythonScript {
            get {
                return ((string)(this["PythonScript"]));
            }
            set {
                this["PythonScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("210")]
        public float Zone1SetTemp {
            get {
                return ((float)(this["Zone1SetTemp"]));
            }
            set {
                this["Zone1SetTemp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("240")]
        public float Zone2SetTemp {
            get {
                return ((float)(this["Zone2SetTemp"]));
            }
            set {
                this["Zone2SetTemp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("275")]
        public float Zone3SetTemp {
            get {
                return ((float)(this["Zone3SetTemp"]));
            }
            set {
                this["Zone3SetTemp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("i.horgan@kostal.com")]
        public string senderEmail {
            get {
                return ((string)(this["senderEmail"]));
            }
            set {
                this["senderEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("i.horgan@kostal.com;a.baliyan@kostal.com")]
        public string receiverEmail {
            get {
                return ((string)(this["receiverEmail"]));
            }
            set {
                this["receiverEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Error Detected at RehmOven")]
        public string emailSubject {
            get {
                return ((string)(this["emailSubject"]));
            }
            set {
                this["emailSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.20.2.153")]
        public string emailClient {
            get {
                return ((string)(this["emailClient"]));
            }
            set {
                this["emailClient"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HtTopP1")]
        public string zone1 {
            get {
                return ((string)(this["zone1"]));
            }
            set {
                this["zone1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HtTopP2")]
        public string zone2 {
            get {
                return ((string)(this["zone2"]));
            }
            set {
                this["zone2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HtTopP3")]
        public string zone3 {
            get {
                return ((string)(this["zone3"]));
            }
            set {
                this["zone3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("REWORK")]
        public string mesRoute {
            get {
                return ((string)(this["mesRoute"]));
            }
            set {
                this["mesRoute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("REWORK")]
        public string mesOperation {
            get {
                return ((string)(this["mesOperation"]));
            }
            set {
                this["mesOperation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int iTolerance {
            get {
                return ((int)(this["iTolerance"]));
            }
            set {
                this["iTolerance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20180811")]
        public string mesResource {
            get {
                return ((string)(this["mesResource"]));
            }
            set {
                this["mesResource"] = value;
            }
        }
    }
}
