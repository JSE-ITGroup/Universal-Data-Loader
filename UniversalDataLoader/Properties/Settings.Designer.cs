﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversalDataLoader.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=\"{0}\";Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=\"Excel 8.0" +
            ";HDR=YES\";")]
        public string OleExcelConnectionTemplate {
            get {
                return ((string)(this["OleExcelConnectionTemplate"]));
            }
            set {
                this["OleExcelConnectionTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MaxFileHolder {
            get {
                return ((int)(this["MaxFileHolder"]));
            }
            set {
                this["MaxFileHolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DBConnectionString.txt")]
        public string ConnectionFile {
            get {
                return ((string)(this["ConnectionFile"]));
            }
            set {
                this["ConnectionFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("select name from Sys.objects where Type=\'U\' order by name")]
        public string DatabaseTableListQuery {
            get {
                return ((string)(this["DatabaseTableListQuery"]));
            }
            set {
                this["DatabaseTableListQuery"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int BatchSizePercentPerDataset {
            get {
                return ((int)(this["BatchSizePercentPerDataset"]));
            }
            set {
                this["BatchSizePercentPerDataset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"{0}\";Extended Properties = \"text;HD" +
            "R=Yes;FMT=Delimited({1})\";")]
        public string OleFlatFileConnectionTemplate {
            get {
                return ((string)(this["OleFlatFileConnectionTemplate"]));
            }
            set {
                this["OleFlatFileConnectionTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"{0}\";Extended Properties=\"Excel 12" +
            ".0 Xml;HDR=YES\";")]
        public string OleExcelXmlFileConnectionTemplate {
            get {
                return ((string)(this["OleExcelXmlFileConnectionTemplate"]));
            }
            set {
                this["OleExcelXmlFileConnectionTemplate"] = value;
            }
        }
    }
}