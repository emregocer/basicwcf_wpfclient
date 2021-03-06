﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTest3.Client.PostService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseContract", Namespace="http://schemas.datacontract.org/2004/07/WcfTest3.Core.WcfContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfTest3.Client.PostService.CategoryContract))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfTest3.Client.PostService.CommentContract))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WcfTest3.Client.PostService.PostContract))]
    public partial class BaseContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryContract", Namespace="http://schemas.datacontract.org/2004/07/WcfTest3.Core.WcfContracts")]
    [System.SerializableAttribute()]
    public partial class CategoryContract : WcfTest3.Client.PostService.BaseContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfTest3.Client.PostService.PostContract[] PostsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfTest3.Client.PostService.PostContract[] Posts {
            get {
                return this.PostsField;
            }
            set {
                if ((object.ReferenceEquals(this.PostsField, value) != true)) {
                    this.PostsField = value;
                    this.RaisePropertyChanged("Posts");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommentContract", Namespace="http://schemas.datacontract.org/2004/07/WcfTest3.Core.WcfContracts")]
    [System.SerializableAttribute()]
    public partial class CommentContract : WcfTest3.Client.PostService.BaseContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfTest3.Client.PostService.PostContract PostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SentAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SentByField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public WcfTest3.Client.PostService.PostContract Post {
            get {
                return this.PostField;
            }
            set {
                if ((object.ReferenceEquals(this.PostField, value) != true)) {
                    this.PostField = value;
                    this.RaisePropertyChanged("Post");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime SentAt {
            get {
                return this.SentAtField;
            }
            set {
                if ((this.SentAtField.Equals(value) != true)) {
                    this.SentAtField = value;
                    this.RaisePropertyChanged("SentAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SentBy {
            get {
                return this.SentByField;
            }
            set {
                if ((object.ReferenceEquals(this.SentByField, value) != true)) {
                    this.SentByField = value;
                    this.RaisePropertyChanged("SentBy");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PostContract", Namespace="http://schemas.datacontract.org/2004/07/WcfTest3.Core.WcfContracts")]
    [System.SerializableAttribute()]
    public partial class PostContract : WcfTest3.Client.PostService.BaseContract {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfTest3.Client.PostService.CategoryContract CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfTest3.Client.PostService.CommentContract[] CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime SentAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SentByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfTest3.Client.PostService.CategoryContract Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfTest3.Client.PostService.CommentContract[] Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public System.DateTime SentAt {
            get {
                return this.SentAtField;
            }
            set {
                if ((this.SentAtField.Equals(value) != true)) {
                    this.SentAtField = value;
                    this.RaisePropertyChanged("SentAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SentBy {
            get {
                return this.SentByField;
            }
            set {
                if ((object.ReferenceEquals(this.SentByField, value) != true)) {
                    this.SentByField = value;
                    this.RaisePropertyChanged("SentBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PostService.IPostService")]
    public interface IPostService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Get", ReplyAction="http://tempuri.org/IPostService/GetResponse")]
        WcfTest3.Client.PostService.PostContract Get(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Get", ReplyAction="http://tempuri.org/IPostService/GetResponse")]
        System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> GetAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetAll", ReplyAction="http://tempuri.org/IPostService/GetAllResponse")]
        WcfTest3.Client.PostService.PostContract[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/GetAll", ReplyAction="http://tempuri.org/IPostService/GetAllResponse")]
        System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Create", ReplyAction="http://tempuri.org/IPostService/CreateResponse")]
        WcfTest3.Client.PostService.PostContract Create(WcfTest3.Client.PostService.PostContract post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Create", ReplyAction="http://tempuri.org/IPostService/CreateResponse")]
        System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> CreateAsync(WcfTest3.Client.PostService.PostContract post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Update", ReplyAction="http://tempuri.org/IPostService/UpdateResponse")]
        WcfTest3.Client.PostService.PostContract Update(WcfTest3.Client.PostService.PostContract post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Update", ReplyAction="http://tempuri.org/IPostService/UpdateResponse")]
        System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> UpdateAsync(WcfTest3.Client.PostService.PostContract post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Delete", ReplyAction="http://tempuri.org/IPostService/DeleteResponse")]
        void Delete(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPostService/Delete", ReplyAction="http://tempuri.org/IPostService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPostServiceChannel : WcfTest3.Client.PostService.IPostService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostServiceClient : System.ServiceModel.ClientBase<WcfTest3.Client.PostService.IPostService>, WcfTest3.Client.PostService.IPostService {
        
        public PostServiceClient() {
        }
        
        public PostServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfTest3.Client.PostService.PostContract Get(int Id) {
            return base.Channel.Get(Id);
        }
        
        public System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> GetAsync(int Id) {
            return base.Channel.GetAsync(Id);
        }
        
        public WcfTest3.Client.PostService.PostContract[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WcfTest3.Client.PostService.PostContract Create(WcfTest3.Client.PostService.PostContract post) {
            return base.Channel.Create(post);
        }
        
        public System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> CreateAsync(WcfTest3.Client.PostService.PostContract post) {
            return base.Channel.CreateAsync(post);
        }
        
        public WcfTest3.Client.PostService.PostContract Update(WcfTest3.Client.PostService.PostContract post) {
            return base.Channel.Update(post);
        }
        
        public System.Threading.Tasks.Task<WcfTest3.Client.PostService.PostContract> UpdateAsync(WcfTest3.Client.PostService.PostContract post) {
            return base.Channel.UpdateAsync(post);
        }
        
        public void Delete(int Id) {
            base.Channel.Delete(Id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int Id) {
            return base.Channel.DeleteAsync(Id);
        }
    }
}
