﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieFilterSp.MovieService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="movie", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_dt_relField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int mov_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_langField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_rel_countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mov_yearField;
        
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
        public string mov_dt_rel {
            get {
                return this.mov_dt_relField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_dt_relField, value) != true)) {
                    this.mov_dt_relField = value;
                    this.RaisePropertyChanged("mov_dt_rel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int mov_id {
            get {
                return this.mov_idField;
            }
            set {
                if ((this.mov_idField.Equals(value) != true)) {
                    this.mov_idField = value;
                    this.RaisePropertyChanged("mov_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mov_lang {
            get {
                return this.mov_langField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_langField, value) != true)) {
                    this.mov_langField = value;
                    this.RaisePropertyChanged("mov_lang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mov_rel_country {
            get {
                return this.mov_rel_countryField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_rel_countryField, value) != true)) {
                    this.mov_rel_countryField = value;
                    this.RaisePropertyChanged("mov_rel_country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mov_time {
            get {
                return this.mov_timeField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_timeField, value) != true)) {
                    this.mov_timeField = value;
                    this.RaisePropertyChanged("mov_time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mov_title {
            get {
                return this.mov_titleField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_titleField, value) != true)) {
                    this.mov_titleField = value;
                    this.RaisePropertyChanged("mov_title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mov_year {
            get {
                return this.mov_yearField;
            }
            set {
                if ((object.ReferenceEquals(this.mov_yearField, value) != true)) {
                    this.mov_yearField = value;
                    this.RaisePropertyChanged("mov_year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAlMovies", ReplyAction="http://tempuri.org/IService/GetAlMoviesResponse")]
        MovieFilterSp.MovieService.movie[] GetAlMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAlMovies", ReplyAction="http://tempuri.org/IService/GetAlMoviesResponse")]
        System.Threading.Tasks.Task<MovieFilterSp.MovieService.movie[]> GetAlMoviesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MovieFilterSp.MovieService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MovieFilterSp.MovieService.IService>, MovieFilterSp.MovieService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MovieFilterSp.MovieService.movie[] GetAlMovies() {
            return base.Channel.GetAlMovies();
        }
        
        public System.Threading.Tasks.Task<MovieFilterSp.MovieService.movie[]> GetAlMoviesAsync() {
            return base.Channel.GetAlMoviesAsync();
        }
    }
}
