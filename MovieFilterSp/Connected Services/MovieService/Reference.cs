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
    [System.Runtime.Serialization.DataContractAttribute(Name="actor", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class actor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string act_fnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string act_fullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int act_genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int act_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string act_lnameField;
        
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
        public string act_fname {
            get {
                return this.act_fnameField;
            }
            set {
                if ((object.ReferenceEquals(this.act_fnameField, value) != true)) {
                    this.act_fnameField = value;
                    this.RaisePropertyChanged("act_fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string act_fullname {
            get {
                return this.act_fullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.act_fullnameField, value) != true)) {
                    this.act_fullnameField = value;
                    this.RaisePropertyChanged("act_fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int act_gender {
            get {
                return this.act_genderField;
            }
            set {
                if ((this.act_genderField.Equals(value) != true)) {
                    this.act_genderField = value;
                    this.RaisePropertyChanged("act_gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int act_id {
            get {
                return this.act_idField;
            }
            set {
                if ((this.act_idField.Equals(value) != true)) {
                    this.act_idField = value;
                    this.RaisePropertyChanged("act_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string act_lname {
            get {
                return this.act_lnameField;
            }
            set {
                if ((object.ReferenceEquals(this.act_lnameField, value) != true)) {
                    this.act_lnameField = value;
                    this.RaisePropertyChanged("act_lname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="director", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class director : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dir_fnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dir_fullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int dir_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dir_lnameField;
        
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
        public string dir_fname {
            get {
                return this.dir_fnameField;
            }
            set {
                if ((object.ReferenceEquals(this.dir_fnameField, value) != true)) {
                    this.dir_fnameField = value;
                    this.RaisePropertyChanged("dir_fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dir_fullname {
            get {
                return this.dir_fullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.dir_fullnameField, value) != true)) {
                    this.dir_fullnameField = value;
                    this.RaisePropertyChanged("dir_fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int dir_id {
            get {
                return this.dir_idField;
            }
            set {
                if ((this.dir_idField.Equals(value) != true)) {
                    this.dir_idField = value;
                    this.RaisePropertyChanged("dir_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dir_lname {
            get {
                return this.dir_lnameField;
            }
            set {
                if ((object.ReferenceEquals(this.dir_lnameField, value) != true)) {
                    this.dir_lnameField = value;
                    this.RaisePropertyChanged("dir_lname");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllActors", ReplyAction="http://tempuri.org/IService/GetAllActorsResponse")]
        System.Collections.Generic.List<MovieFilterSp.MovieService.actor> GetAllActors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllActors", ReplyAction="http://tempuri.org/IService/GetAllActorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.actor>> GetAllActorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActorById", ReplyAction="http://tempuri.org/IService/GetActorByIdResponse")]
        MovieFilterSp.MovieService.actor GetActorById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActorById", ReplyAction="http://tempuri.org/IService/GetActorByIdResponse")]
        System.Threading.Tasks.Task<MovieFilterSp.MovieService.actor> GetActorByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertActor", ReplyAction="http://tempuri.org/IService/InsertActorResponse")]
        string InsertActor(MovieFilterSp.MovieService.actor obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertActor", ReplyAction="http://tempuri.org/IService/InsertActorResponse")]
        System.Threading.Tasks.Task<string> InsertActorAsync(MovieFilterSp.MovieService.actor obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateActor", ReplyAction="http://tempuri.org/IService/UpdateActorResponse")]
        string UpdateActor(MovieFilterSp.MovieService.actor obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateActor", ReplyAction="http://tempuri.org/IService/UpdateActorResponse")]
        System.Threading.Tasks.Task<string> UpdateActorAsync(MovieFilterSp.MovieService.actor obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllDirectors", ReplyAction="http://tempuri.org/IService/GetAllDirectorsResponse")]
        System.Collections.Generic.List<MovieFilterSp.MovieService.director> GetAllDirectors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllDirectors", ReplyAction="http://tempuri.org/IService/GetAllDirectorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.director>> GetAllDirectorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDirectorById", ReplyAction="http://tempuri.org/IService/GetDirectorByIdResponse")]
        MovieFilterSp.MovieService.director GetDirectorById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDirectorById", ReplyAction="http://tempuri.org/IService/GetDirectorByIdResponse")]
        System.Threading.Tasks.Task<MovieFilterSp.MovieService.director> GetDirectorByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertDirector", ReplyAction="http://tempuri.org/IService/InsertDirectorResponse")]
        string InsertDirector(MovieFilterSp.MovieService.director obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertDirector", ReplyAction="http://tempuri.org/IService/InsertDirectorResponse")]
        System.Threading.Tasks.Task<string> InsertDirectorAsync(MovieFilterSp.MovieService.director obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateDirector", ReplyAction="http://tempuri.org/IService/UpdateDirectorResponse")]
        string UpdateDirector(MovieFilterSp.MovieService.director obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateDirector", ReplyAction="http://tempuri.org/IService/UpdateDirectorResponse")]
        System.Threading.Tasks.Task<string> UpdateDirectorAsync(MovieFilterSp.MovieService.director obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllMovies", ReplyAction="http://tempuri.org/IService/GetAllMoviesResponse")]
        System.Collections.Generic.List<MovieFilterSp.MovieService.movie> GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllMovies", ReplyAction="http://tempuri.org/IService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.movie>> GetAllMoviesAsync();
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
        
        public System.Collections.Generic.List<MovieFilterSp.MovieService.actor> GetAllActors() {
            return base.Channel.GetAllActors();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.actor>> GetAllActorsAsync() {
            return base.Channel.GetAllActorsAsync();
        }
        
        public MovieFilterSp.MovieService.actor GetActorById(int id) {
            return base.Channel.GetActorById(id);
        }
        
        public System.Threading.Tasks.Task<MovieFilterSp.MovieService.actor> GetActorByIdAsync(int id) {
            return base.Channel.GetActorByIdAsync(id);
        }
        
        public string InsertActor(MovieFilterSp.MovieService.actor obj) {
            return base.Channel.InsertActor(obj);
        }
        
        public System.Threading.Tasks.Task<string> InsertActorAsync(MovieFilterSp.MovieService.actor obj) {
            return base.Channel.InsertActorAsync(obj);
        }
        
        public string UpdateActor(MovieFilterSp.MovieService.actor obj) {
            return base.Channel.UpdateActor(obj);
        }
        
        public System.Threading.Tasks.Task<string> UpdateActorAsync(MovieFilterSp.MovieService.actor obj) {
            return base.Channel.UpdateActorAsync(obj);
        }
        
        public System.Collections.Generic.List<MovieFilterSp.MovieService.director> GetAllDirectors() {
            return base.Channel.GetAllDirectors();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.director>> GetAllDirectorsAsync() {
            return base.Channel.GetAllDirectorsAsync();
        }
        
        public MovieFilterSp.MovieService.director GetDirectorById(int id) {
            return base.Channel.GetDirectorById(id);
        }
        
        public System.Threading.Tasks.Task<MovieFilterSp.MovieService.director> GetDirectorByIdAsync(int id) {
            return base.Channel.GetDirectorByIdAsync(id);
        }
        
        public string InsertDirector(MovieFilterSp.MovieService.director obj) {
            return base.Channel.InsertDirector(obj);
        }
        
        public System.Threading.Tasks.Task<string> InsertDirectorAsync(MovieFilterSp.MovieService.director obj) {
            return base.Channel.InsertDirectorAsync(obj);
        }
        
        public string UpdateDirector(MovieFilterSp.MovieService.director obj) {
            return base.Channel.UpdateDirector(obj);
        }
        
        public System.Threading.Tasks.Task<string> UpdateDirectorAsync(MovieFilterSp.MovieService.director obj) {
            return base.Channel.UpdateDirectorAsync(obj);
        }
        
        public System.Collections.Generic.List<MovieFilterSp.MovieService.movie> GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MovieFilterSp.MovieService.movie>> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
    }
}
