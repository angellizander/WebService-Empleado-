﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.WSEmpleados {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleador", Namespace="http://schemas.datacontract.org/2004/07/WCFEmpleados")]
    [System.SerializableAttribute()]
    public partial class Empleador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Apellido2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConominaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescuentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SueldonetoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SueldosecundarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipodocumentoField;
        
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
        public string Apellido1 {
            get {
                return this.Apellido1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido1Field, value) != true)) {
                    this.Apellido1Field = value;
                    this.RaisePropertyChanged("Apellido1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido2 {
            get {
                return this.Apellido2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Apellido2Field, value) != true)) {
                    this.Apellido2Field = value;
                    this.RaisePropertyChanged("Apellido2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Conomina {
            get {
                return this.ConominaField;
            }
            set {
                if ((object.ReferenceEquals(this.ConominaField, value) != true)) {
                    this.ConominaField = value;
                    this.RaisePropertyChanged("Conomina");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descuento {
            get {
                return this.DescuentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescuentoField, value) != true)) {
                    this.DescuentoField = value;
                    this.RaisePropertyChanged("Descuento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Documento {
            get {
                return this.DocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentoField, value) != true)) {
                    this.DocumentoField = value;
                    this.RaisePropertyChanged("Documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fnacimiento {
            get {
                return this.FnacimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.FnacimientoField, value) != true)) {
                    this.FnacimientoField = value;
                    this.RaisePropertyChanged("Fnacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sueldoneto {
            get {
                return this.SueldonetoField;
            }
            set {
                if ((object.ReferenceEquals(this.SueldonetoField, value) != true)) {
                    this.SueldonetoField = value;
                    this.RaisePropertyChanged("Sueldoneto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sueldosecundario {
            get {
                return this.SueldosecundarioField;
            }
            set {
                if ((object.ReferenceEquals(this.SueldosecundarioField, value) != true)) {
                    this.SueldosecundarioField = value;
                    this.RaisePropertyChanged("Sueldosecundario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipodocumento {
            get {
                return this.TipodocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipodocumentoField, value) != true)) {
                    this.TipodocumentoField = value;
                    this.RaisePropertyChanged("Tipodocumento");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSEmpleados.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListEmpleador", ReplyAction="http://tempuri.org/IService1/getListEmpleadorResponse")]
        WindowsFormsApp1.WSEmpleados.Empleador[] getListEmpleador();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListEmpleador", ReplyAction="http://tempuri.org/IService1/getListEmpleadorResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.WSEmpleados.Empleador[]> getListEmpleadorAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApp1.WSEmpleados.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApp1.WSEmpleados.IService1>, WindowsFormsApp1.WSEmpleados.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApp1.WSEmpleados.Empleador[] getListEmpleador() {
            return base.Channel.getListEmpleador();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.WSEmpleados.Empleador[]> getListEmpleadorAsync() {
            return base.Channel.getListEmpleadorAsync();
        }
    }
}
