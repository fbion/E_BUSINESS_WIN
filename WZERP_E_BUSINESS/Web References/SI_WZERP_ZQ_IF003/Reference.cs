﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.34209 版自动生成。
// 
#pragma warning disable 1591

namespace WZERP_E_BUSINESS.SI_WZERP_ZQ_IF003 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_WZERP_ZQ_IF003_A_OUTBinding", Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class SI_WZERP_ZQ_IF003_A_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_WZERP_ZQ_IF003_A_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_WZERP_ZQ_IF003_A_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_WZERP_ZQ_IF003_SI_WZERP_ZQ_IF003_A_OUTService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SI_WZERP_ZQ_IF003_A_OUTCompletedEventHandler SI_WZERP_ZQ_IF003_A_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void SI_WZERP_ZQ_IF003_A_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:ec5:zq:agreement")] DT_EC5_ZQ_IF003_REQ MT_EC5_ZQ_IF003_REQ) {
            this.Invoke("SI_WZERP_ZQ_IF003_A_OUT", new object[] {
                        MT_EC5_ZQ_IF003_REQ});
        }
        
        /// <remarks/>
        public void SI_WZERP_ZQ_IF003_A_OUTAsync(DT_EC5_ZQ_IF003_REQ MT_EC5_ZQ_IF003_REQ) {
            this.SI_WZERP_ZQ_IF003_A_OUTAsync(MT_EC5_ZQ_IF003_REQ, null);
        }
        
        /// <remarks/>
        public void SI_WZERP_ZQ_IF003_A_OUTAsync(DT_EC5_ZQ_IF003_REQ MT_EC5_ZQ_IF003_REQ, object userState) {
            if ((this.SI_WZERP_ZQ_IF003_A_OUTOperationCompleted == null)) {
                this.SI_WZERP_ZQ_IF003_A_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_WZERP_ZQ_IF003_A_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_WZERP_ZQ_IF003_A_OUT", new object[] {
                        MT_EC5_ZQ_IF003_REQ}, this.SI_WZERP_ZQ_IF003_A_OUTOperationCompleted, userState);
        }
        
        private void OnSI_WZERP_ZQ_IF003_A_OUTOperationCompleted(object arg) {
            if ((this.SI_WZERP_ZQ_IF003_A_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_WZERP_ZQ_IF003_A_OUTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class DT_EC5_ZQ_IF003_REQ {
        
        private DT_EC5_ZQ_IF003_REQAGREEMENTCLOSE aGREEMENTCLOSEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_ZQ_IF003_REQAGREEMENTCLOSE AGREEMENTCLOSE {
            get {
                return this.aGREEMENTCLOSEField;
            }
            set {
                this.aGREEMENTCLOSEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class DT_EC5_ZQ_IF003_REQAGREEMENTCLOSE {
        
        private string mSGIDField;
        
        private string sTRNField;
        
        private string sENDTIMEField;
        
        private string aGRSTATUSField;
        
        private string oPERATEUSERField;
        
        private string oPERATEDATEField;
        
        private string aGRCODEField;
        
        private string sAPAGRCODEField;
        
        private string mODIFYCODEField;
        
        private string oPERATETYPEField;
        
        private string yL1Field;
        
        private string yL2Field;
        
        private string yL3Field;
        
        private string yL4Field;
        
        private string yL5Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MSGID {
            get {
                return this.mSGIDField;
            }
            set {
                this.mSGIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRN {
            get {
                return this.sTRNField;
            }
            set {
                this.sTRNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SENDTIME {
            get {
                return this.sENDTIMEField;
            }
            set {
                this.sENDTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AGRSTATUS {
            get {
                return this.aGRSTATUSField;
            }
            set {
                this.aGRSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPERATEUSER {
            get {
                return this.oPERATEUSERField;
            }
            set {
                this.oPERATEUSERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPERATEDATE {
            get {
                return this.oPERATEDATEField;
            }
            set {
                this.oPERATEDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AGRCODE {
            get {
                return this.aGRCODEField;
            }
            set {
                this.aGRCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SAPAGRCODE {
            get {
                return this.sAPAGRCODEField;
            }
            set {
                this.sAPAGRCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MODIFYCODE {
            get {
                return this.mODIFYCODEField;
            }
            set {
                this.mODIFYCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPERATETYPE {
            get {
                return this.oPERATETYPEField;
            }
            set {
                this.oPERATETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YL1 {
            get {
                return this.yL1Field;
            }
            set {
                this.yL1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YL2 {
            get {
                return this.yL2Field;
            }
            set {
                this.yL2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YL3 {
            get {
                return this.yL3Field;
            }
            set {
                this.yL3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YL4 {
            get {
                return this.yL4Field;
            }
            set {
                this.yL4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string YL5 {
            get {
                return this.yL5Field;
            }
            set {
                this.yL5Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SI_WZERP_ZQ_IF003_A_OUTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591