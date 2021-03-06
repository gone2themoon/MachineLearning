﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oven_AI.ChangeProductionServiceWSService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="mepapi:com:sap:me:production")]
    public partial class ResolvedBusinessException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string faultInfoField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string faultInfo {
            get {
                return this.faultInfoField;
            }
            set {
                this.faultInfoField = value;
                this.RaisePropertyChanged("faultInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sap.com/me/production")]
    public partial class SfcProductionContext : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sfcRefField;
        
        private string operationRefField;
        
        private string bomRefField;
        
        private string itemRefField;
        
        private string routerRefField;
        
        private string shopOrderRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string sfcRef {
            get {
                return this.sfcRefField;
            }
            set {
                this.sfcRefField = value;
                this.RaisePropertyChanged("sfcRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string operationRef {
            get {
                return this.operationRefField;
            }
            set {
                this.operationRefField = value;
                this.RaisePropertyChanged("operationRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string bomRef {
            get {
                return this.bomRefField;
            }
            set {
                this.bomRefField = value;
                this.RaisePropertyChanged("bomRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string itemRef {
            get {
                return this.itemRefField;
            }
            set {
                this.itemRefField = value;
                this.RaisePropertyChanged("itemRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string routerRef {
            get {
                return this.routerRefField;
            }
            set {
                this.routerRefField = value;
                this.RaisePropertyChanged("routerRef");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string shopOrderRef {
            get {
                return this.shopOrderRefField;
            }
            set {
                this.shopOrderRefField = value;
                this.RaisePropertyChanged("shopOrderRef");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="mepapi:com:sap:me:production")]
    public partial class changeProductionResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SfcProductionContext[] responseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("sfcProductionContextList", Namespace="http://www.sap.com/me/production", IsNullable=false)]
        public SfcProductionContext[] Response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
                this.RaisePropertyChanged("Response");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sap.com/me/production")]
    public partial class ChangeProductionContext : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string newBomField;
        
        private string newBomRevisionField;
        
        private string newItemField;
        
        private string newItemRevisionField;
        
        private string newRouterField;
        
        private string newRouterRevisionField;
        
        private string newShopOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string newBom {
            get {
                return this.newBomField;
            }
            set {
                this.newBomField = value;
                this.RaisePropertyChanged("newBom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string newBomRevision {
            get {
                return this.newBomRevisionField;
            }
            set {
                this.newBomRevisionField = value;
                this.RaisePropertyChanged("newBomRevision");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string newItem {
            get {
                return this.newItemField;
            }
            set {
                this.newItemField = value;
                this.RaisePropertyChanged("newItem");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string newItemRevision {
            get {
                return this.newItemRevisionField;
            }
            set {
                this.newItemRevisionField = value;
                this.RaisePropertyChanged("newItemRevision");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string newRouter {
            get {
                return this.newRouterField;
            }
            set {
                this.newRouterField = value;
                this.RaisePropertyChanged("newRouter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string newRouterRevision {
            get {
                return this.newRouterRevisionField;
            }
            set {
                this.newRouterRevisionField = value;
                this.RaisePropertyChanged("newRouterRevision");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string newShopOrder {
            get {
                return this.newShopOrderField;
            }
            set {
                this.newShopOrderField = value;
                this.RaisePropertyChanged("newShopOrder");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sap.com/me/production")]
    public partial class ChangeProductionRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ChangeProductionContext changeProductionContextTypeField;
        
        private OperationPlacementTypeEnum operationPlacementTypeField;
        
        private bool operationPlacementTypeFieldSpecified;
        
        private string designatedOperationField;
        
        private string designatedStepIdField;
        
        private string[] sfcListField;
        
        private bool ecoRequiredField;
        
        private bool ecoRequiredFieldSpecified;
        
        private string ecoField;
        
        private bool commentsRequiredField;
        
        private bool commentsRequiredFieldSpecified;
        
        private string commentsField;
        
        private bool allowDoneSfcsField;
        
        private bool allowDoneSfcsFieldSpecified;
        
        private bool allowPackedSfcsField;
        
        private bool allowPackedSfcsFieldSpecified;
        
        private bool allowReworkSfcRouterChangeField;
        
        private bool allowReworkSfcRouterChangeFieldSpecified;
        
        private bool adjustBuildOrderQuantityField;
        
        private bool adjustBuildOrderQuantityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ChangeProductionContext changeProductionContextType {
            get {
                return this.changeProductionContextTypeField;
            }
            set {
                this.changeProductionContextTypeField = value;
                this.RaisePropertyChanged("changeProductionContextType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public OperationPlacementTypeEnum operationPlacementType {
            get {
                return this.operationPlacementTypeField;
            }
            set {
                this.operationPlacementTypeField = value;
                this.RaisePropertyChanged("operationPlacementType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationPlacementTypeSpecified {
            get {
                return this.operationPlacementTypeFieldSpecified;
            }
            set {
                this.operationPlacementTypeFieldSpecified = value;
                this.RaisePropertyChanged("operationPlacementTypeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string designatedOperation {
            get {
                return this.designatedOperationField;
            }
            set {
                this.designatedOperationField = value;
                this.RaisePropertyChanged("designatedOperation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string designatedStepId {
            get {
                return this.designatedStepIdField;
            }
            set {
                this.designatedStepIdField = value;
                this.RaisePropertyChanged("designatedStepId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sfcList", Order=4)]
        public string[] sfcList {
            get {
                return this.sfcListField;
            }
            set {
                this.sfcListField = value;
                this.RaisePropertyChanged("sfcList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool ecoRequired {
            get {
                return this.ecoRequiredField;
            }
            set {
                this.ecoRequiredField = value;
                this.RaisePropertyChanged("ecoRequired");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ecoRequiredSpecified {
            get {
                return this.ecoRequiredFieldSpecified;
            }
            set {
                this.ecoRequiredFieldSpecified = value;
                this.RaisePropertyChanged("ecoRequiredSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string eco {
            get {
                return this.ecoField;
            }
            set {
                this.ecoField = value;
                this.RaisePropertyChanged("eco");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool commentsRequired {
            get {
                return this.commentsRequiredField;
            }
            set {
                this.commentsRequiredField = value;
                this.RaisePropertyChanged("commentsRequired");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool commentsRequiredSpecified {
            get {
                return this.commentsRequiredFieldSpecified;
            }
            set {
                this.commentsRequiredFieldSpecified = value;
                this.RaisePropertyChanged("commentsRequiredSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
                this.RaisePropertyChanged("comments");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool allowDoneSfcs {
            get {
                return this.allowDoneSfcsField;
            }
            set {
                this.allowDoneSfcsField = value;
                this.RaisePropertyChanged("allowDoneSfcs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowDoneSfcsSpecified {
            get {
                return this.allowDoneSfcsFieldSpecified;
            }
            set {
                this.allowDoneSfcsFieldSpecified = value;
                this.RaisePropertyChanged("allowDoneSfcsSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool allowPackedSfcs {
            get {
                return this.allowPackedSfcsField;
            }
            set {
                this.allowPackedSfcsField = value;
                this.RaisePropertyChanged("allowPackedSfcs");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowPackedSfcsSpecified {
            get {
                return this.allowPackedSfcsFieldSpecified;
            }
            set {
                this.allowPackedSfcsFieldSpecified = value;
                this.RaisePropertyChanged("allowPackedSfcsSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool allowReworkSfcRouterChange {
            get {
                return this.allowReworkSfcRouterChangeField;
            }
            set {
                this.allowReworkSfcRouterChangeField = value;
                this.RaisePropertyChanged("allowReworkSfcRouterChange");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowReworkSfcRouterChangeSpecified {
            get {
                return this.allowReworkSfcRouterChangeFieldSpecified;
            }
            set {
                this.allowReworkSfcRouterChangeFieldSpecified = value;
                this.RaisePropertyChanged("allowReworkSfcRouterChangeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool adjustBuildOrderQuantity {
            get {
                return this.adjustBuildOrderQuantityField;
            }
            set {
                this.adjustBuildOrderQuantityField = value;
                this.RaisePropertyChanged("adjustBuildOrderQuantity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adjustBuildOrderQuantitySpecified {
            get {
                return this.adjustBuildOrderQuantityFieldSpecified;
            }
            set {
                this.adjustBuildOrderQuantityFieldSpecified = value;
                this.RaisePropertyChanged("adjustBuildOrderQuantitySpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sap.com/me/production")]
    public enum OperationPlacementTypeEnum {
        
        /// <remarks/>
        SPECIFIED_OPERATION,
        
        /// <remarks/>
        FIRST_OPERATION,
        
        /// <remarks/>
        UNCOMPLETE_OPERATION,
        
        /// <remarks/>
        CURRENT_OPERATION,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="mepapi:com:sap:me:production")]
    public partial class changeProduction : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string siteField;
        
        private ChangeProductionRequest requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Site {
            get {
                return this.siteField;
            }
            set {
                this.siteField = value;
                this.RaisePropertyChanged("Site");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ChangeProductionRequest Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
                this.RaisePropertyChanged("Request");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="mepapi:com:sap:me:production", ConfigurationName="ChangeProductionServiceWSService.ChangeProductionServiceWS")]
    public interface ChangeProductionServiceWS {
        
        // CODEGEN: Generating message contract since the operation changeProduction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Oven_AI.ChangeProductionServiceWSService.ResolvedBusinessException), Action="", Name="ResolvedBusinessException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Oven_AI.ChangeProductionServiceWSService.changeProductionResponse1 changeProduction(Oven_AI.ChangeProductionServiceWSService.changeProductionRequest1 request);
        
        // CODEGEN: Generating message contract since the operation validateChangeProduction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Oven_AI.ChangeProductionServiceWSService.ResolvedBusinessException), Action="", Name="ResolvedBusinessException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse1 validateChangeProduction(Oven_AI.ChangeProductionServiceWSService.validateChangeProductionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class changeProductionRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="mepapi:com:sap:me:production", Order=0)]
        public Oven_AI.ChangeProductionServiceWSService.changeProduction changeProduction;
        
        public changeProductionRequest1() {
        }
        
        public changeProductionRequest1(Oven_AI.ChangeProductionServiceWSService.changeProduction changeProduction) {
            this.changeProduction = changeProduction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class changeProductionResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="mepapi:com:sap:me:production", Order=0)]
        public Oven_AI.ChangeProductionServiceWSService.changeProductionResponse changeProductionResponse;
        
        public changeProductionResponse1() {
        }
        
        public changeProductionResponse1(Oven_AI.ChangeProductionServiceWSService.changeProductionResponse changeProductionResponse) {
            this.changeProductionResponse = changeProductionResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="mepapi:com:sap:me:production")]
    public partial class validateChangeProduction : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string siteField;
        
        private ChangeProductionRequest requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Site {
            get {
                return this.siteField;
            }
            set {
                this.siteField = value;
                this.RaisePropertyChanged("Site");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ChangeProductionRequest Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
                this.RaisePropertyChanged("Request");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="mepapi:com:sap:me:production")]
    public partial class validateChangeProductionResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateChangeProductionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="mepapi:com:sap:me:production", Order=0)]
        public Oven_AI.ChangeProductionServiceWSService.validateChangeProduction validateChangeProduction;
        
        public validateChangeProductionRequest() {
        }
        
        public validateChangeProductionRequest(Oven_AI.ChangeProductionServiceWSService.validateChangeProduction validateChangeProduction) {
            this.validateChangeProduction = validateChangeProduction;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateChangeProductionResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="mepapi:com:sap:me:production", Order=0)]
        public Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse validateChangeProductionResponse;
        
        public validateChangeProductionResponse1() {
        }
        
        public validateChangeProductionResponse1(Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse validateChangeProductionResponse) {
            this.validateChangeProductionResponse = validateChangeProductionResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChangeProductionServiceWSChannel : Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChangeProductionServiceWSClient : System.ServiceModel.ClientBase<Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS>, Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS {
        
        public ChangeProductionServiceWSClient() {
        }
        
        public ChangeProductionServiceWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChangeProductionServiceWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChangeProductionServiceWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChangeProductionServiceWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Oven_AI.ChangeProductionServiceWSService.changeProductionResponse1 Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS.changeProduction(Oven_AI.ChangeProductionServiceWSService.changeProductionRequest1 request) {
            return base.Channel.changeProduction(request);
        }
        
        public Oven_AI.ChangeProductionServiceWSService.changeProductionResponse changeProduction(Oven_AI.ChangeProductionServiceWSService.changeProduction changeProduction1) {
            Oven_AI.ChangeProductionServiceWSService.changeProductionRequest1 inValue = new Oven_AI.ChangeProductionServiceWSService.changeProductionRequest1();
            inValue.changeProduction = changeProduction1;
            Oven_AI.ChangeProductionServiceWSService.changeProductionResponse1 retVal = ((Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS)(this)).changeProduction(inValue);
            return retVal.changeProductionResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse1 Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS.validateChangeProduction(Oven_AI.ChangeProductionServiceWSService.validateChangeProductionRequest request) {
            return base.Channel.validateChangeProduction(request);
        }
        
        public Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse validateChangeProduction(Oven_AI.ChangeProductionServiceWSService.validateChangeProduction validateChangeProduction1) {
            Oven_AI.ChangeProductionServiceWSService.validateChangeProductionRequest inValue = new Oven_AI.ChangeProductionServiceWSService.validateChangeProductionRequest();
            inValue.validateChangeProduction = validateChangeProduction1;
            Oven_AI.ChangeProductionServiceWSService.validateChangeProductionResponse1 retVal = ((Oven_AI.ChangeProductionServiceWSService.ChangeProductionServiceWS)(this)).validateChangeProduction(inValue);
            return retVal.validateChangeProductionResponse;
        }
    }
}
