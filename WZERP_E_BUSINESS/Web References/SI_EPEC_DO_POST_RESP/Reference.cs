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

namespace WZERP_E_BUSINESS.SI_EPEC_DO_POST_RESP {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SI_EPEC_DO_POST_RESP_A_OUTBinding", Namespace="urn:sinopec:ecc:wzerp:epec:integration")]
    public partial class SI_EPEC_DO_POST_RESP_A_OUTService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SI_EPEC_DO_POST_RESP_A_OUTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SI_EPEC_DO_POST_RESP_A_OUTService() {
            this.Url = global::WZERP_E_BUSINESS.Properties.Settings.Default.WZERP_E_BUSINESS_SI_EPEC_DO_POST_RESP1_SI_EPEC_DO_POST_RESP_A_OUTService;
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
        public event SI_EPEC_DO_POST_RESP_A_OUTCompletedEventHandler SI_EPEC_DO_POST_RESP_A_OUTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        public void SI_EPEC_DO_POST_RESP_A_OUT([System.Xml.Serialization.XmlElementAttribute(Namespace="urn:sinopec:ecc:wzerp:epec:integration")] DT_EPEC_DO_POST_RESP MT_EPEC_DO_POST_RESP) {
            this.Invoke("SI_EPEC_DO_POST_RESP_A_OUT", new object[] {
                        MT_EPEC_DO_POST_RESP});
        }
        
        /// <remarks/>
        public void SI_EPEC_DO_POST_RESP_A_OUTAsync(DT_EPEC_DO_POST_RESP MT_EPEC_DO_POST_RESP) {
            this.SI_EPEC_DO_POST_RESP_A_OUTAsync(MT_EPEC_DO_POST_RESP, null);
        }
        
        /// <remarks/>
        public void SI_EPEC_DO_POST_RESP_A_OUTAsync(DT_EPEC_DO_POST_RESP MT_EPEC_DO_POST_RESP, object userState) {
            if ((this.SI_EPEC_DO_POST_RESP_A_OUTOperationCompleted == null)) {
                this.SI_EPEC_DO_POST_RESP_A_OUTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSI_EPEC_DO_POST_RESP_A_OUTOperationCompleted);
            }
            this.InvokeAsync("SI_EPEC_DO_POST_RESP_A_OUT", new object[] {
                        MT_EPEC_DO_POST_RESP}, this.SI_EPEC_DO_POST_RESP_A_OUTOperationCompleted, userState);
        }
        
        private void OnSI_EPEC_DO_POST_RESP_A_OUTOperationCompleted(object arg) {
            if ((this.SI_EPEC_DO_POST_RESP_A_OUTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SI_EPEC_DO_POST_RESP_A_OUTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sinopec:ecc:wzerp:epec:integration")]
    public partial class DT_EPEC_DO_POST_RESP {
        
        private DT_EPEC_DO_POST_RESPIS_MSG_HEAD iS_MSG_HEADField;
        
        private DT_EPEC_DO_POST_RESPIS_RESP_HEAD iS_RESP_HEADField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EPEC_DO_POST_RESPIS_MSG_HEAD IS_MSG_HEAD {
            get {
                return this.iS_MSG_HEADField;
            }
            set {
                this.iS_MSG_HEADField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DT_EPEC_DO_POST_RESPIS_RESP_HEAD IS_RESP_HEAD {
            get {
                return this.iS_RESP_HEADField;
            }
            set {
                this.iS_RESP_HEADField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ecc:wzerp:epec:integration")]
    public partial class DT_EPEC_DO_POST_RESPIS_MSG_HEAD {
        
        private string mANDTField;
        
        private string gUIDField;
        
        private string pROXY_IDField;
        
        private string sYSTEM_IDField;
        
        private string oPERATORField;
        
        private string sPRASField;
        
        private string iNTERFACE_IDField;
        
        private string sENDERField;
        
        private string rECIVERField;
        
        private string sENDTIMEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MANDT {
            get {
                return this.mANDTField;
            }
            set {
                this.mANDTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GUID {
            get {
                return this.gUIDField;
            }
            set {
                this.gUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PROXY_ID {
            get {
                return this.pROXY_IDField;
            }
            set {
                this.pROXY_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SYSTEM_ID {
            get {
                return this.sYSTEM_IDField;
            }
            set {
                this.sYSTEM_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OPERATOR {
            get {
                return this.oPERATORField;
            }
            set {
                this.oPERATORField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SPRAS {
            get {
                return this.sPRASField;
            }
            set {
                this.sPRASField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INTERFACE_ID {
            get {
                return this.iNTERFACE_IDField;
            }
            set {
                this.iNTERFACE_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SENDER {
            get {
                return this.sENDERField;
            }
            set {
                this.sENDERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RECIVER {
            get {
                return this.rECIVERField;
            }
            set {
                this.rECIVERField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34209")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sinopec:ecc:wzerp:epec:integration")]
    public partial class DT_EPEC_DO_POST_RESPIS_RESP_HEAD {
        
        private string zZXXHField;
        
        private string lOGSYSField;
        
        private string zZEPECLNField;
        
        private string zZEPECSNField;
        
        private string zZEPECIDField;
        
        private string mSGIDField;
        
        private string zCGBZField;
        
        private string zLOGField;
        
        private string eBELNField;
        
        private string zZHTBHField;
        
        private string zZDZCGHTHField;
        
        private string mBLNRField;
        
        private string zZYL1Field;
        
        private string zZYL2Field;
        
        private string zZYL3Field;
        
        private string zZYL4Field;
        
        private string zZYL5Field;
        
        private string zZYL6Field;
        
        private string zZYL7Field;
        
        private string zZYL8Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZXXH {
            get {
                return this.zZXXHField;
            }
            set {
                this.zZXXHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LOGSYS {
            get {
                return this.lOGSYSField;
            }
            set {
                this.lOGSYSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZEPECLN {
            get {
                return this.zZEPECLNField;
            }
            set {
                this.zZEPECLNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZEPECSN {
            get {
                return this.zZEPECSNField;
            }
            set {
                this.zZEPECSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZEPECID {
            get {
                return this.zZEPECIDField;
            }
            set {
                this.zZEPECIDField = value;
            }
        }
        
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
        public string ZCGBZ {
            get {
                return this.zCGBZField;
            }
            set {
                this.zCGBZField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZLOG {
            get {
                return this.zLOGField;
            }
            set {
                this.zLOGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EBELN {
            get {
                return this.eBELNField;
            }
            set {
                this.eBELNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZHTBH {
            get {
                return this.zZHTBHField;
            }
            set {
                this.zZHTBHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZDZCGHTH {
            get {
                return this.zZDZCGHTHField;
            }
            set {
                this.zZDZCGHTHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MBLNR {
            get {
                return this.mBLNRField;
            }
            set {
                this.mBLNRField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL1 {
            get {
                return this.zZYL1Field;
            }
            set {
                this.zZYL1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL2 {
            get {
                return this.zZYL2Field;
            }
            set {
                this.zZYL2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL3 {
            get {
                return this.zZYL3Field;
            }
            set {
                this.zZYL3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL4 {
            get {
                return this.zZYL4Field;
            }
            set {
                this.zZYL4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL5 {
            get {
                return this.zZYL5Field;
            }
            set {
                this.zZYL5Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL6 {
            get {
                return this.zZYL6Field;
            }
            set {
                this.zZYL6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL7 {
            get {
                return this.zZYL7Field;
            }
            set {
                this.zZYL7Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZZYL8 {
            get {
                return this.zZYL8Field;
            }
            set {
                this.zZYL8Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SI_EPEC_DO_POST_RESP_A_OUTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591