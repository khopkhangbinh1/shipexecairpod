﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace EDIPPS.com.luxshare_ict.dcs {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ILdapAd", Namespace="http://tempuri.org/")]
    public partial class LdapAd : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUserLoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LdapAd() {
            this.Url = global::EDIPPS.Properties.Settings.Default.EDIPPS_com_luxshare_ict_dcs_LdapAd;
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
        public event AddCompletedEventHandler AddCompleted;
        
        /// <remarks/>
        public event CheckUserLoginCompletedEventHandler CheckUserLoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILdapAd/Add", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public FlagTips Add([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] LdapAdModel model) {
            object[] results = this.Invoke("Add", new object[] {
                        model});
            return ((FlagTips)(results[0]));
        }
        
        /// <remarks/>
        public void AddAsync(LdapAdModel model) {
            this.AddAsync(model, null);
        }
        
        /// <remarks/>
        public void AddAsync(LdapAdModel model, object userState) {
            if ((this.AddOperationCompleted == null)) {
                this.AddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOperationCompleted);
            }
            this.InvokeAsync("Add", new object[] {
                        model}, this.AddOperationCompleted, userState);
        }
        
        private void OnAddOperationCompleted(object arg) {
            if ((this.AddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCompleted(this, new AddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILdapAd/CheckUserLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CheckUserModel CheckUserLogin([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string empCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pwd) {
            object[] results = this.Invoke("CheckUserLogin", new object[] {
                        empCode,
                        pwd});
            return ((CheckUserModel)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUserLoginAsync(string empCode, string pwd) {
            this.CheckUserLoginAsync(empCode, pwd, null);
        }
        
        /// <remarks/>
        public void CheckUserLoginAsync(string empCode, string pwd, object userState) {
            if ((this.CheckUserLoginOperationCompleted == null)) {
                this.CheckUserLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUserLoginOperationCompleted);
            }
            this.InvokeAsync("CheckUserLogin", new object[] {
                        empCode,
                        pwd}, this.CheckUserLoginOperationCompleted, userState);
        }
        
        private void OnCheckUserLoginOperationCompleted(object arg) {
            if ((this.CheckUserLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUserLoginCompleted(this, new CheckUserLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Luxshare.DCS.WebApp.WCF")]
    public partial class LdapAdModel {
        
        private string accountField;
        
        private LdapAdAccountTypeEnum accountTypeField;
        
        private bool accountTypeFieldSpecified;
        
        private string codeField;
        
        private string pwdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }
        
        /// <remarks/>
        public LdapAdAccountTypeEnum AccountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTypeSpecified {
            get {
                return this.accountTypeFieldSpecified;
            }
            set {
                this.accountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Pwd {
            get {
                return this.pwdField;
            }
            set {
                this.pwdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Luxshare.DCS.Common")]
    public enum LdapAdAccountTypeEnum {
        
        /// <remarks/>
        Ad,
        
        /// <remarks/>
        Ldap,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Luxshare.DCS.Data")]
    public partial class CheckUserModel {
        
        private string errMsgField;
        
        private bool isSuccessField;
        
        private bool isSuccessFieldSpecified;
        
        private System.Nullable<LoginTypeEnum> loginTypeField;
        
        private bool loginTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ErrMsg {
            get {
                return this.errMsgField;
            }
            set {
                this.errMsgField = value;
            }
        }
        
        /// <remarks/>
        public bool IsSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                this.isSuccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSuccessSpecified {
            get {
                return this.isSuccessFieldSpecified;
            }
            set {
                this.isSuccessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<LoginTypeEnum> LoginType {
            get {
                return this.loginTypeField;
            }
            set {
                this.loginTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LoginTypeSpecified {
            get {
                return this.loginTypeFieldSpecified;
            }
            set {
                this.loginTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Luxshare.DCS.Data")]
    public enum LoginTypeEnum {
        
        /// <remarks/>
        AD,
        
        /// <remarks/>
        LDAP,
        
        /// <remarks/>
        DCS,
        
        /// <remarks/>
        IsMasterKey,
        
        /// <remarks/>
        Common,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Luxshare.DCS.WebApp.Models")]
    public partial class FlagTips {
        
        private string errMsgField;
        
        private bool isSuccessField;
        
        private bool isSuccessFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ErrMsg {
            get {
                return this.errMsgField;
            }
            set {
                this.errMsgField = value;
            }
        }
        
        /// <remarks/>
        public bool IsSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                this.isSuccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSuccessSpecified {
            get {
                return this.isSuccessFieldSpecified;
            }
            set {
                this.isSuccessFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void AddCompletedEventHandler(object sender, AddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FlagTips Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FlagTips)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void CheckUserLoginCompletedEventHandler(object sender, CheckUserLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUserLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUserLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CheckUserModel Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CheckUserModel)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591