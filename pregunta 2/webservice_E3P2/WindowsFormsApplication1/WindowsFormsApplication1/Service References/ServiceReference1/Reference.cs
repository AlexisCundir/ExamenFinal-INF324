﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int suma(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        System.Threading.Tasks.Task<int> sumaAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarAlumnos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mostrarAlumnos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mostrarAlumnos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mostrarAlumnosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/adicionarAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void adicionarAlumno(string ci, string nombre, string paterno, string materno, string nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/adicionarAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task adicionarAlumnoAsync(string ci, string nombre, string paterno, string materno, string nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void updateAlumno(string ci, string nombre, string paterno, string materno, string nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task updateAlumnoAsync(string ci, string nombre, string paterno, string materno, string nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarAlumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void eliminarAlumno(string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarAlumno", ReplyAction="*")]
        System.Threading.Tasks.Task eliminarAlumnoAsync(string ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowsFormsApplication1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.WebServiceSoap>, WindowsFormsApplication1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public int suma(int a, int b) {
            return base.Channel.suma(a, b);
        }
        
        public System.Threading.Tasks.Task<int> sumaAsync(int a, int b) {
            return base.Channel.sumaAsync(a, b);
        }
        
        public System.Data.DataSet mostrarAlumnos() {
            return base.Channel.mostrarAlumnos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mostrarAlumnosAsync() {
            return base.Channel.mostrarAlumnosAsync();
        }
        
        public void adicionarAlumno(string ci, string nombre, string paterno, string materno, string nota) {
            base.Channel.adicionarAlumno(ci, nombre, paterno, materno, nota);
        }
        
        public System.Threading.Tasks.Task adicionarAlumnoAsync(string ci, string nombre, string paterno, string materno, string nota) {
            return base.Channel.adicionarAlumnoAsync(ci, nombre, paterno, materno, nota);
        }
        
        public void updateAlumno(string ci, string nombre, string paterno, string materno, string nota) {
            base.Channel.updateAlumno(ci, nombre, paterno, materno, nota);
        }
        
        public System.Threading.Tasks.Task updateAlumnoAsync(string ci, string nombre, string paterno, string materno, string nota) {
            return base.Channel.updateAlumnoAsync(ci, nombre, paterno, materno, nota);
        }
        
        public void eliminarAlumno(string ci) {
            base.Channel.eliminarAlumno(ci);
        }
        
        public System.Threading.Tasks.Task eliminarAlumnoAsync(string ci) {
            return base.Channel.eliminarAlumnoAsync(ci);
        }
    }
}
