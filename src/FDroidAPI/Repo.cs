﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace FDroidAPI
{
    using System.Xml.Serialization;
    using System.Collections.Generic;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("fdroid", IsNullable = false)]
    public partial class Repo
    {

        [XmlElement("repo",  Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public fdroidRepo repo { get; set; }

        [XmlElement("application", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HashSet<fdroidApplication> applications { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlType(AnonymousType = true)]
    public partial class fdroidApplication
    {

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string id { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string added { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lastupdated { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string summary { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string icon { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string desc { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string license { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string categories { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string category { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string web { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string source { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tracker { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string changelog { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string marketversion { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string marketvercode { get; set; }

        /// <remarks/>
        [XmlElement("package", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HashSet<fdroidApplicationPackage> package { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlType(AnonymousType = true)]
    public partial class fdroidApplicationPackage
    {

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string version { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string versioncode { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apkname { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sig { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string size { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sdkver { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string added { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string permissions { get; set; }

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nativecode { get; set; }

        /// <remarks/>
        [XmlElement("hash", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public fdroidApplicationPackageHash[] hash { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlType(AnonymousType = true)]
    public partial class fdroidApplicationPackageHash
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlType(AnonymousType = true)]
    public partial class fdroidRepo
    {

        /// <remarks/>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string icon { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pubkey { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timestamp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }
    }
}
