﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.ServiceReference1.Room))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.ServiceReference1.Question))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.ServiceReference1.User[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object callbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string iconField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int inRoomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool redyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int scoreField;
        
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
        public object callback {
            get {
                return this.callbackField;
            }
            set {
                if ((object.ReferenceEquals(this.callbackField, value) != true)) {
                    this.callbackField = value;
                    this.RaisePropertyChanged("callback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string icon {
            get {
                return this.iconField;
            }
            set {
                if ((object.ReferenceEquals(this.iconField, value) != true)) {
                    this.iconField = value;
                    this.RaisePropertyChanged("icon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int inRoom {
            get {
                return this.inRoomField;
            }
            set {
                if ((this.inRoomField.Equals(value) != true)) {
                    this.inRoomField = value;
                    this.RaisePropertyChanged("inRoom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool redy {
            get {
                return this.redyField;
            }
            set {
                if ((this.redyField.Equals(value) != true)) {
                    this.redyField = value;
                    this.RaisePropertyChanged("redy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int score {
            get {
                return this.scoreField;
            }
            set {
                if ((this.scoreField.Equals(value) != true)) {
                    this.scoreField = value;
                    this.RaisePropertyChanged("score");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.Question questionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime thisTurnBeginTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime thisTurnEndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference1.User[] usersField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.Question question {
            get {
                return this.questionField;
            }
            set {
                if ((object.ReferenceEquals(this.questionField, value) != true)) {
                    this.questionField = value;
                    this.RaisePropertyChanged("question");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime thisTurnBeginTime {
            get {
                return this.thisTurnBeginTimeField;
            }
            set {
                if ((this.thisTurnBeginTimeField.Equals(value) != true)) {
                    this.thisTurnBeginTimeField = value;
                    this.RaisePropertyChanged("thisTurnBeginTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime thisTurnEndTime {
            get {
                return this.thisTurnEndTimeField;
            }
            set {
                if ((this.thisTurnEndTimeField.Equals(value) != true)) {
                    this.thisTurnEndTimeField = value;
                    this.RaisePropertyChanged("thisTurnEndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServiceReference1.User[] users {
            get {
                return this.usersField;
            }
            set {
                if ((object.ReferenceEquals(this.usersField, value) != true)) {
                    this.usersField = value;
                    this.RaisePropertyChanged("users");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string answerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] tipsField;
        
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
        public string answer {
            get {
                return this.answerField;
            }
            set {
                if ((object.ReferenceEquals(this.answerField, value) != true)) {
                    this.answerField = value;
                    this.RaisePropertyChanged("answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int level {
            get {
                return this.levelField;
            }
            set {
                if ((this.levelField.Equals(value) != true)) {
                    this.levelField = value;
                    this.RaisePropertyChanged("level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] tips {
            get {
                return this.tipsField;
            }
            set {
                if ((object.ReferenceEquals(this.tipsField, value) != true)) {
                    this.tipsField = value;
                    this.RaisePropertyChanged("tips");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="GuessServer", ConfigurationName="ServiceReference1.IGuessService", CallbackContract=typeof(Client.ServiceReference1.IGuessServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IGuessService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/Login")]
        void Login(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/Login")]
        System.Threading.Tasks.Task LoginAsync(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/EnterHall")]
        void EnterHall(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/EnterHall")]
        System.Threading.Tasks.Task EnterHallAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/EnterRoom")]
        void EnterRoom(string user, int roomNumber);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/EnterRoom")]
        System.Threading.Tasks.Task EnterRoomAsync(string user, int roomNumber);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/StartGame")]
        void StartGame(string user, int room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/StartGame")]
        System.Threading.Tasks.Task StartGameAsync(string user, int room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/SendInk")]
        void SendInk(int room, string ink);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/SendInk")]
        System.Threading.Tasks.Task SendInkAsync(int room, string ink);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/SendMessage")]
        void SendMessage(int room, string user, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(int room, string user, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/Logout")]
        void Logout(string user, int room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/Logout")]
        System.Threading.Tasks.Task LogoutAsync(string user, int room);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuessServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowLogin")]
        void ShowLogin(int loginCode, Client.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowHall")]
        void ShowHall(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowRoom")]
        void ShowRoom(Client.ServiceReference1.Room room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowStart")]
        void ShowStart(Client.ServiceReference1.Room room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowInk")]
        void ShowInk(string ink);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowMessage")]
        void ShowMessage(string who, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowWin")]
        void ShowWin(Client.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowNewTurn")]
        void ShowNewTurn(Client.ServiceReference1.Room room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="GuessServer/IGuessService/ShowLogout")]
        void ShowLogout(Client.ServiceReference1.Room room);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuessServiceChannel : Client.ServiceReference1.IGuessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuessServiceClient : System.ServiceModel.DuplexClientBase<Client.ServiceReference1.IGuessService>, Client.ServiceReference1.IGuessService {
        
        public GuessServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GuessServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GuessServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GuessServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GuessServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Login(string user, string password) {
            base.Channel.Login(user, password);
        }
        
        public System.Threading.Tasks.Task LoginAsync(string user, string password) {
            return base.Channel.LoginAsync(user, password);
        }
        
        public void EnterHall(string user) {
            base.Channel.EnterHall(user);
        }
        
        public System.Threading.Tasks.Task EnterHallAsync(string user) {
            return base.Channel.EnterHallAsync(user);
        }
        
        public void EnterRoom(string user, int roomNumber) {
            base.Channel.EnterRoom(user, roomNumber);
        }
        
        public System.Threading.Tasks.Task EnterRoomAsync(string user, int roomNumber) {
            return base.Channel.EnterRoomAsync(user, roomNumber);
        }
        
        public void StartGame(string user, int room) {
            base.Channel.StartGame(user, room);
        }
        
        public System.Threading.Tasks.Task StartGameAsync(string user, int room) {
            return base.Channel.StartGameAsync(user, room);
        }
        
        public void SendInk(int room, string ink) {
            base.Channel.SendInk(room, ink);
        }
        
        public System.Threading.Tasks.Task SendInkAsync(int room, string ink) {
            return base.Channel.SendInkAsync(room, ink);
        }
        
        public void SendMessage(int room, string user, string message) {
            base.Channel.SendMessage(room, user, message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(int room, string user, string message) {
            return base.Channel.SendMessageAsync(room, user, message);
        }
        
        public void Logout(string user, int room) {
            base.Channel.Logout(user, room);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string user, int room) {
            return base.Channel.LogoutAsync(user, room);
        }
    }
}
