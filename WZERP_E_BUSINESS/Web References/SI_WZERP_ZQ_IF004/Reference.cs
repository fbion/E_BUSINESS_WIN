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

namespace WZERP_E_BUSINESS.SI_WZERP_ZQ_IF004 {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_WZERP_ZQ_IF004_A_OUTBinding", Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class SI_WZERP_ZQ_IF004_A_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_WZERP_ZQ_IF004_A_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_WZERP_ZQ_IF004_A_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_WZERP_ZQ_IF004_SI_WZERP_ZQ_IF004_A_OUTService;
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
        public event SI_WZERP_ZQ_IF004_A_OUTCompletedEventHandler SI_WZERP_ZQ_IF004_A_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void SI_WZERP_ZQ_IF004_A_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:ec5:zq:agreement")] DT_EC5_ZQ_IF004_REQ MT_EC5_ZQ_IF004_REQ) {
            this.Invoke("SI_WZERP_ZQ_IF004_A_OUT", new object[] {
                        MT_EC5_ZQ_IF004_REQ});
        }
        
        /// <remarks/>
        public void SI_WZERP_ZQ_IF004_A_OUTAsync(DT_EC5_ZQ_IF004_REQ MT_EC5_ZQ_IF004_REQ) {
            this.SI_WZERP_ZQ_IF004_A_OUTAsync(MT_EC5_ZQ_IF004_REQ, null);
        }
        
        /// <remarks/>
        public void SI_WZERP_ZQ_IF004_A_OUTAsync(DT_EC5_ZQ_IF004_REQ MT_EC5_ZQ_IF004_REQ, object userState) {
            if ((this.SI_WZERP_ZQ_IF004_A_OUTOperationCompleted == null)) {
                this.SI_WZERP_ZQ_IF004_A_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_WZERP_ZQ_IF004_A_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_WZERP_ZQ_IF004_A_OUT", new object[] {
                        MT_EC5_ZQ_IF004_REQ}, this.SI_WZERP_ZQ_IF004_A_OUTOperationCompleted, userState);
        }
        
        private void OnSI_WZERP_ZQ_IF004_A_OUTOperationCompleted(object arg) {
            if ((this.SI_WZERP_ZQ_IF004_A_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_WZERP_ZQ_IF004_A_OUTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class DT_EC5_ZQ_IF004_REQ {
        
        private DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG aGREEMENTWZERPCHGField;
        
        private DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] aGREEMENTWZERPCHGFILEField;
        
        private DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] aGREEMENTWZERPCHGPRODUCTSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG AGREEMENTWZERPCHG {
            get {
                return this.aGREEMENTWZERPCHGField;
            }
            set {
                this.aGREEMENTWZERPCHGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AGREEMENTWZERPCHGFILE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE[] AGREEMENTWZERPCHGFILE {
            get {
                return this.aGREEMENTWZERPCHGFILEField;
            }
            set {
                this.aGREEMENTWZERPCHGFILEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AGREEMENTWZERPCHGPRODUCTS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS[] AGREEMENTWZERPCHGPRODUCTS {
            get {
                return this.aGREEMENTWZERPCHGPRODUCTSField;
            }
            set {
                this.aGREEMENTWZERPCHGPRODUCTSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHG {
        
        private string mSGIDField;
        
        private string sTRNField;
        
        private string sENDTIMEField;
        
        private string sTARTDATEField;
        
        private string eNDDATEField;
        
        private string tARGETVALUEField;
        
        private string sTOCKTYPEField;
        
        private string aTTRTYPEField;
        
        private string aGRCODEField;
        
        private string oPERATETYPEField;
        
        private string sAPAGRCODEField;
        
        private string mODIFYCODEField;
        
        private string xGYYField;
        
        private string bGNRField;
        
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
        public string STARTDATE {
            get {
                return this.sTARTDATEField;
            }
            set {
                this.sTARTDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ENDDATE {
            get {
                return this.eNDDATEField;
            }
            set {
                this.eNDDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TARGETVALUE {
            get {
                return this.tARGETVALUEField;
            }
            set {
                this.tARGETVALUEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STOCKTYPE {
            get {
                return this.sTOCKTYPEField;
            }
            set {
                this.sTOCKTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ATTRTYPE {
            get {
                return this.aTTRTYPEField;
            }
            set {
                this.aTTRTYPEField = value;
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
        public string XGYY {
            get {
                return this.xGYYField;
            }
            set {
                this.xGYYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BGNR {
            get {
                return this.bGNRField;
            }
            set {
                this.bGNRField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGFILE {
        
        private string aGRCODEField;
        
        private string iTEMNOField;
        
        private string fILECODEField;
        
        private string fILENAMEField;
        
        private string fILETYPEField;
        
        private string fILEURLField;
        
        private string yL1Field;
        
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
        public string ITEMNO {
            get {
                return this.iTEMNOField;
            }
            set {
                this.iTEMNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FILECODE {
            get {
                return this.fILECODEField;
            }
            set {
                this.fILECODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FILENAME {
            get {
                return this.fILENAMEField;
            }
            set {
                this.fILENAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FILETYPE {
            get {
                return this.fILETYPEField;
            }
            set {
                this.fILETYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FILEURL {
            get {
                return this.fILEURLField;
            }
            set {
                this.fILEURLField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ec5:zq:agreement")]
    public partial class DT_EC5_ZQ_IF004_REQAGREEMENTWZERPCHGPRODUCTS {
        
        private string aGRCODEField;
        
        private string iTEMNOField;
        
        private string pRODNAMEField;
        
        private string pRODCLASSField;
        
        private string qUANTITYField;
        
        private string uNITField;
        
        private string pRICEField;
        
        private string tAXCODEField;
        
        private string yL1Field;
        
        private string yL2Field;
        
        private string yL3Field;
        
        private string yL4Field;
        
        private string yL5Field;
        
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
        public string ITEMNO {
            get {
                return this.iTEMNOField;
            }
            set {
                this.iTEMNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PRODNAME {
            get {
                return this.pRODNAMEField;
            }
            set {
                this.pRODNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PRODCLASS {
            get {
                return this.pRODCLASSField;
            }
            set {
                this.pRODCLASSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string QUANTITY {
            get {
                return this.qUANTITYField;
            }
            set {
                this.qUANTITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UNIT {
            get {
                return this.uNITField;
            }
            set {
                this.uNITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PRICE {
            get {
                return this.pRICEField;
            }
            set {
                this.pRICEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TAXCODE {
            get {
                return this.tAXCODEField;
            }
            set {
                this.tAXCODEField = value;
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
    public delegate void SI_WZERP_ZQ_IF004_A_OUTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591