﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo.Client.PingService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="urn:www-infosupport-com:wcfdemo:v1:datacontracts")]
    [System.SerializableAttribute()]
    public partial class Data : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ZIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IgnoredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> AmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ZId {
            get {
                return this.ZIdField;
            }
            set {
                if ((this.ZIdField.Equals(value) != true)) {
                    this.ZIdField = value;
                    this.RaisePropertyChanged("ZId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Ignored {
            get {
                return this.IgnoredField;
            }
            set {
                if ((object.ReferenceEquals(this.IgnoredField, value) != true)) {
                    this.IgnoredField = value;
                    this.RaisePropertyChanged("Ignored");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<decimal> Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dataz", Namespace="urn:www-infosupport-com:wcfdemo:v1:datacontracts")]
    [System.SerializableAttribute()]
    public partial class Dataz : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] IdsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Ids {
            get {
                return this.IdsField;
            }
            set {
                if ((object.ReferenceEquals(this.IdsField, value) != true)) {
                    this.IdsField = value;
                    this.RaisePropertyChanged("Ids");
                }
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
    [System.ServiceModel.ServiceContractAttribute(Name="ping-service", Namespace="urn:www-infosupport-com:wcfdemo:v1", ConfigurationName="PingService.pingservice")]
    public interface pingservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/ping", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/pingResponse")]
        void ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/ping", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/pingResponse")]
        System.Threading.Tasks.Task pingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/Hello", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/HelloResponse")]
        string Hello(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/Hello", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/GiveMeAllTheDataz", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/GiveMeAllTheDatazResponse")]
        WcfDemo.Client.PingService.Dataz GiveMeAllTheDataz(WcfDemo.Client.PingService.Data data);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:www-infosupport-com:wcfdemo:v1/ping-service/GiveMeAllTheDataz", ReplyAction="urn:www-infosupport-com:wcfdemo:v1/ping-service/GiveMeAllTheDatazResponse")]
        System.Threading.Tasks.Task<WcfDemo.Client.PingService.Dataz> GiveMeAllTheDatazAsync(WcfDemo.Client.PingService.Data data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface pingserviceChannel : WcfDemo.Client.PingService.pingservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class pingserviceClient : System.ServiceModel.ClientBase<WcfDemo.Client.PingService.pingservice>, WcfDemo.Client.PingService.pingservice {
        
        public pingserviceClient() {
        }
        
        public pingserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public pingserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public pingserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public pingserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ping() {
            base.Channel.ping();
        }
        
        public System.Threading.Tasks.Task pingAsync() {
            return base.Channel.pingAsync();
        }
        
        public string Hello(string input) {
            return base.Channel.Hello(input);
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync(string input) {
            return base.Channel.HelloAsync(input);
        }
        
        public WcfDemo.Client.PingService.Dataz GiveMeAllTheDataz(WcfDemo.Client.PingService.Data data) {
            return base.Channel.GiveMeAllTheDataz(data);
        }
        
        public System.Threading.Tasks.Task<WcfDemo.Client.PingService.Dataz> GiveMeAllTheDatazAsync(WcfDemo.Client.PingService.Data data) {
            return base.Channel.GiveMeAllTheDatazAsync(data);
        }
    }
}
