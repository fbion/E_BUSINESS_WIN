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

namespace WZERP_E_BUSINESS.SI_EC5_WZERP_PR_REQ {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_EC5_WZERP_PR_REQ_A_OUTBinding", Namespace="urn:sinopec:ec5:wzerp:purchase:control:integration")]
    public partial class SI_EC5_WZERP_PR_REQ_A_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_EC5_WZERP_PR_REQ_A_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_EC5_WZERP_PR_REQ_SI_EC5_WZERP_PR_REQ_A_OUTService;
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
        public event SI_EC5_WZERP_PR_REQ_A_OUTCompletedEventHandler SI_EC5_WZERP_PR_REQ_A_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void SI_EC5_WZERP_PR_REQ_A_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:wzerp:ec5:purchase:control:integration")] DT_EC5_WZERP_PR_REQUEST SAPPURCHASEREQUESTS) {
            this.Invoke("SI_EC5_WZERP_PR_REQ_A_OUT", new object[] {
                        SAPPURCHASEREQUESTS});
        }
        
        /// <remarks/>
        public void SI_EC5_WZERP_PR_REQ_A_OUTAsync(DT_EC5_WZERP_PR_REQUEST SAPPURCHASEREQUESTS) {
            this.SI_EC5_WZERP_PR_REQ_A_OUTAsync(SAPPURCHASEREQUESTS, null);
        }
        
        /// <remarks/>
        public void SI_EC5_WZERP_PR_REQ_A_OUTAsync(DT_EC5_WZERP_PR_REQUEST SAPPURCHASEREQUESTS, object userState) {
            if ((this.SI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted == null)) {
                this.SI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_EC5_WZERP_PR_REQ_A_OUT", new object[] {
                        SAPPURCHASEREQUESTS}, this.SI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted, userState);
        }
        
        private void OnSI_EC5_WZERP_PR_REQ_A_OUTOperationCompleted(object arg) {
            if ((this.SI_EC5_WZERP_PR_REQ_A_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_EC5_WZERP_PR_REQ_A_OUTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:wzerp:ec5:purchase:control:integration")]
    public partial class DT_EC5_WZERP_PR_REQUEST {
        
        private string mSGIDField;
        
        private string sTRSYSNUMBERField;
        
        private string bUSINESSTYPEField;
        
        private DT_EC5_WZERP_PR_REQUESTPURCHASEREQUEST[] pURCHASEREQUESTField;
        
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
        public string STRSYSNUMBER {
            get {
                return this.sTRSYSNUMBERField;
            }
            set {
                this.sTRSYSNUMBERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BUSINESSTYPE {
            get {
                return this.bUSINESSTYPEField;
            }
            set {
                this.bUSINESSTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PURCHASEREQUEST", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EC5_WZERP_PR_REQUESTPURCHASEREQUEST[] PURCHASEREQUEST {
            get {
                return this.pURCHASEREQUESTField;
            }
            set {
                this.pURCHASEREQUESTField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:wzerp:ec5:purchase:control:integration")]
    public partial class DT_EC5_WZERP_PR_REQUESTPURCHASEREQUEST {
        
        private string sTRORDERCODEField;
        
        private string sTRPLANNOField;
        
        private string sTRCORPNAMEField;
        
        private string sTRPROJECTNOField;
        
        private string sTRPRODCODEField;
        
        private string sTRPRODNAMEField;
        
        private string iNTQTYField;
        
        private string sTRUNITField;
        
        private string sTRSTANDARDField;
        
        private string iNTBUDGETARYField;
        
        private string dACONTIMEField;
        
        private string sTRCONADDRField;
        
        private string sTRMEMNAMEField;
        
        private string sTRMATERTYPEField;
        
        private string sTRUSERIDField;
        
        private string dASUBTIMEField;
        
        private string sTRURLField;
        
        private string sTRPROJECTNMField;
        
        private string sTREQUIPNMField;
        
        private string sTRLOCATIONField;
        
        private string sTRDRAWField;
        
        private string sTRPIECEField;
        
        private string sTRSTANDALONEField;
        
        private string sTRAPPLYField;
        
        private string sTRHEATField;
        
        private string sTRRECEIVERField;
        
        private string nMATKLField;
        
        private string sTRMARKField;
        
        private string zBDBZField;
        
        private string dAPLANTIMEField;
        
        private string sTRSYSNUMBERField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRORDERCODE {
            get {
                return this.sTRORDERCODEField;
            }
            set {
                this.sTRORDERCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPLANNO {
            get {
                return this.sTRPLANNOField;
            }
            set {
                this.sTRPLANNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRCORPNAME {
            get {
                return this.sTRCORPNAMEField;
            }
            set {
                this.sTRCORPNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPROJECTNO {
            get {
                return this.sTRPROJECTNOField;
            }
            set {
                this.sTRPROJECTNOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPRODCODE {
            get {
                return this.sTRPRODCODEField;
            }
            set {
                this.sTRPRODCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPRODNAME {
            get {
                return this.sTRPRODNAMEField;
            }
            set {
                this.sTRPRODNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTQTY {
            get {
                return this.iNTQTYField;
            }
            set {
                this.iNTQTYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRUNIT {
            get {
                return this.sTRUNITField;
            }
            set {
                this.sTRUNITField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRSTANDARD {
            get {
                return this.sTRSTANDARDField;
            }
            set {
                this.sTRSTANDARDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTBUDGETARY {
            get {
                return this.iNTBUDGETARYField;
            }
            set {
                this.iNTBUDGETARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DACONTIME {
            get {
                return this.dACONTIMEField;
            }
            set {
                this.dACONTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRCONADDR {
            get {
                return this.sTRCONADDRField;
            }
            set {
                this.sTRCONADDRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRMEMNAME {
            get {
                return this.sTRMEMNAMEField;
            }
            set {
                this.sTRMEMNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRMATERTYPE {
            get {
                return this.sTRMATERTYPEField;
            }
            set {
                this.sTRMATERTYPEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRUSERID {
            get {
                return this.sTRUSERIDField;
            }
            set {
                this.sTRUSERIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DASUBTIME {
            get {
                return this.dASUBTIMEField;
            }
            set {
                this.dASUBTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRURL {
            get {
                return this.sTRURLField;
            }
            set {
                this.sTRURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPROJECTNM {
            get {
                return this.sTRPROJECTNMField;
            }
            set {
                this.sTRPROJECTNMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STREQUIPNM {
            get {
                return this.sTREQUIPNMField;
            }
            set {
                this.sTREQUIPNMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRLOCATION {
            get {
                return this.sTRLOCATIONField;
            }
            set {
                this.sTRLOCATIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRDRAW {
            get {
                return this.sTRDRAWField;
            }
            set {
                this.sTRDRAWField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRPIECE {
            get {
                return this.sTRPIECEField;
            }
            set {
                this.sTRPIECEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRSTANDALONE {
            get {
                return this.sTRSTANDALONEField;
            }
            set {
                this.sTRSTANDALONEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRAPPLY {
            get {
                return this.sTRAPPLYField;
            }
            set {
                this.sTRAPPLYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRHEAT {
            get {
                return this.sTRHEATField;
            }
            set {
                this.sTRHEATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRRECEIVER {
            get {
                return this.sTRRECEIVERField;
            }
            set {
                this.sTRRECEIVERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NMATKL {
            get {
                return this.nMATKLField;
            }
            set {
                this.nMATKLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRMARK {
            get {
                return this.sTRMARKField;
            }
            set {
                this.sTRMARKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZBDBZ {
            get {
                return this.zBDBZField;
            }
            set {
                this.zBDBZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DAPLANTIME {
            get {
                return this.dAPLANTIMEField;
            }
            set {
                this.dAPLANTIMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string STRSYSNUMBER {
            get {
                return this.sTRSYSNUMBERField;
            }
            set {
                this.sTRSYSNUMBERField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SI_EC5_WZERP_PR_REQ_A_OUTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591