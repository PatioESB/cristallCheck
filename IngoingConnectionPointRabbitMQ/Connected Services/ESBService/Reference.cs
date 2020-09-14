﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IngoingConnectionPointRabbitMQ.ESBService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://esb.axelot.ru")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClassIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool NeedAcknowledgmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IngoingConnectionPointRabbitMQ.ESBService.MessageProperty[] PropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IngoingConnectionPointRabbitMQ.ESBService.Receivers ReceiversField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReplyToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ClassId {
            get {
                return this.ClassIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassIdField, value) != true)) {
                    this.ClassIdField = value;
                    this.RaisePropertyChanged("ClassId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NeedAcknowledgment {
            get {
                return this.NeedAcknowledgmentField;
            }
            set {
                if ((this.NeedAcknowledgmentField.Equals(value) != true)) {
                    this.NeedAcknowledgmentField = value;
                    this.RaisePropertyChanged("NeedAcknowledgment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public IngoingConnectionPointRabbitMQ.ESBService.MessageProperty[] Properties {
            get {
                return this.PropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertiesField, value) != true)) {
                    this.PropertiesField = value;
                    this.RaisePropertyChanged("Properties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public IngoingConnectionPointRabbitMQ.ESBService.Receivers Receivers {
            get {
                return this.ReceiversField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiversField, value) != true)) {
                    this.ReceiversField = value;
                    this.RaisePropertyChanged("Receivers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ReplyTo {
            get {
                return this.ReplyToField;
            }
            set {
                if ((object.ReferenceEquals(this.ReplyToField, value) != true)) {
                    this.ReplyToField = value;
                    this.RaisePropertyChanged("ReplyTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageProperty", Namespace="http://esb.axelot.ru")]
    [System.SerializableAttribute()]
    public partial class MessageProperty : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string NameField;
        
        private IngoingConnectionPointRabbitMQ.ESBService.Variant ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public IngoingConnectionPointRabbitMQ.ESBService.Variant Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Receivers", Namespace="http://esb.axelot.ru", ItemName="Receiver")]
    [System.SerializableAttribute()]
    public class Receivers : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Variant", Namespace="http://esb.axelot.ru")]
    [System.SerializableAttribute()]
    public partial class Variant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool[] BooleanValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ByteValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] DoubleValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float[] FloatValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] IntegerValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] LongIntegerValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] StringValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IngoingConnectionPointRabbitMQ.ESBService.VariantType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private uint[] UnsignedIntegerValuesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public bool[] BooleanValues {
            get {
                return this.BooleanValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.BooleanValuesField, value) != true)) {
                    this.BooleanValuesField = value;
                    this.RaisePropertyChanged("BooleanValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] ByteValues {
            get {
                return this.ByteValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ByteValuesField, value) != true)) {
                    this.ByteValuesField = value;
                    this.RaisePropertyChanged("ByteValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public double[] DoubleValues {
            get {
                return this.DoubleValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.DoubleValuesField, value) != true)) {
                    this.DoubleValuesField = value;
                    this.RaisePropertyChanged("DoubleValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public float[] FloatValues {
            get {
                return this.FloatValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.FloatValuesField, value) != true)) {
                    this.FloatValuesField = value;
                    this.RaisePropertyChanged("FloatValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] IntegerValues {
            get {
                return this.IntegerValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.IntegerValuesField, value) != true)) {
                    this.IntegerValuesField = value;
                    this.RaisePropertyChanged("IntegerValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public long[] LongIntegerValues {
            get {
                return this.LongIntegerValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.LongIntegerValuesField, value) != true)) {
                    this.LongIntegerValuesField = value;
                    this.RaisePropertyChanged("LongIntegerValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string[] StringValues {
            get {
                return this.StringValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValuesField, value) != true)) {
                    this.StringValuesField = value;
                    this.RaisePropertyChanged("StringValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IngoingConnectionPointRabbitMQ.ESBService.VariantType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public uint[] UnsignedIntegerValues {
            get {
                return this.UnsignedIntegerValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.UnsignedIntegerValuesField, value) != true)) {
                    this.UnsignedIntegerValuesField = value;
                    this.RaisePropertyChanged("UnsignedIntegerValues");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VariantType", Namespace="http://esb.axelot.ru")]
    public enum VariantType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        String = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Byte = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Integer = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnsignedInteger = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Float = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Double = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Boolean = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        StringArray = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ByteArray = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IntegerArray = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnsignedIntegerArray = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FloatArray = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DoubleArray = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BooleanArray = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Null = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Auto = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LongInteger = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LongIntegerArray = 17,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://esb.axelot.ru", ConfigurationName="ESBService.service")]
    public interface service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/SendMessage", ReplyAction="http://esb.axelot.ru/service/SendMessageResponse")]
        bool SendMessage(IngoingConnectionPointRabbitMQ.ESBService.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/SendMessage", ReplyAction="http://esb.axelot.ru/service/SendMessageResponse")]
        System.Threading.Tasks.Task<bool> SendMessageAsync(IngoingConnectionPointRabbitMQ.ESBService.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/SendMessageBatch", ReplyAction="http://esb.axelot.ru/service/SendMessageBatchResponse")]
        int SendMessageBatch(IngoingConnectionPointRabbitMQ.ESBService.Message[] messages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/SendMessageBatch", ReplyAction="http://esb.axelot.ru/service/SendMessageBatchResponse")]
        System.Threading.Tasks.Task<int> SendMessageBatchAsync(IngoingConnectionPointRabbitMQ.ESBService.Message[] messages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/ExecuteRequest", ReplyAction="http://esb.axelot.ru/service/ExecuteRequestResponse")]
        IngoingConnectionPointRabbitMQ.ESBService.Message ExecuteRequest(IngoingConnectionPointRabbitMQ.ESBService.Message requestMessage, int timeoutSec);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://esb.axelot.ru/service/ExecuteRequest", ReplyAction="http://esb.axelot.ru/service/ExecuteRequestResponse")]
        System.Threading.Tasks.Task<IngoingConnectionPointRabbitMQ.ESBService.Message> ExecuteRequestAsync(IngoingConnectionPointRabbitMQ.ESBService.Message requestMessage, int timeoutSec);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface serviceChannel : IngoingConnectionPointRabbitMQ.ESBService.service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class serviceClient : System.ServiceModel.ClientBase<IngoingConnectionPointRabbitMQ.ESBService.service>, IngoingConnectionPointRabbitMQ.ESBService.service {
        
        public serviceClient() {
        }
        
        public serviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public serviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendMessage(IngoingConnectionPointRabbitMQ.ESBService.Message message) {
            return base.Channel.SendMessage(message);
        }
        
        public System.Threading.Tasks.Task<bool> SendMessageAsync(IngoingConnectionPointRabbitMQ.ESBService.Message message) {
            return base.Channel.SendMessageAsync(message);
        }
        
        public int SendMessageBatch(IngoingConnectionPointRabbitMQ.ESBService.Message[] messages) {
            return base.Channel.SendMessageBatch(messages);
        }
        
        public System.Threading.Tasks.Task<int> SendMessageBatchAsync(IngoingConnectionPointRabbitMQ.ESBService.Message[] messages) {
            return base.Channel.SendMessageBatchAsync(messages);
        }
        
        public IngoingConnectionPointRabbitMQ.ESBService.Message ExecuteRequest(IngoingConnectionPointRabbitMQ.ESBService.Message requestMessage, int timeoutSec) {
            return base.Channel.ExecuteRequest(requestMessage, timeoutSec);
        }
        
        public System.Threading.Tasks.Task<IngoingConnectionPointRabbitMQ.ESBService.Message> ExecuteRequestAsync(IngoingConnectionPointRabbitMQ.ESBService.Message requestMessage, int timeoutSec) {
            return base.Channel.ExecuteRequestAsync(requestMessage, timeoutSec);
        }
    }
}