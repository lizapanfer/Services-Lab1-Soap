﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService.DataReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataReference.IDataManager")]
    public interface IDataManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataManager/Save", ReplyAction="http://tempuri.org/IDataManager/SaveResponse")]
        string Save(string mark, int age, int price, int motor_value, int custom_price, int full_price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataManager/Save", ReplyAction="http://tempuri.org/IDataManager/SaveResponse")]
        System.Threading.Tasks.Task<string> SaveAsync(string mark, int age, int price, int motor_value, int custom_price, int full_price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataManager/PrintOutput", ReplyAction="http://tempuri.org/IDataManager/PrintOutputResponse")]
        string PrintOutput(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataManager/PrintOutput", ReplyAction="http://tempuri.org/IDataManager/PrintOutputResponse")]
        System.Threading.Tasks.Task<string> PrintOutputAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataManagerChannel : CarService.DataReference.IDataManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataManagerClient : System.ServiceModel.ClientBase<CarService.DataReference.IDataManager>, CarService.DataReference.IDataManager {
        
        public DataManagerClient() {
        }
        
        public DataManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Save(string mark, int age, int price, int motor_value, int custom_price, int full_price) {
            return base.Channel.Save(mark, age, price, motor_value, custom_price, full_price);
        }
        
        public System.Threading.Tasks.Task<string> SaveAsync(string mark, int age, int price, int motor_value, int custom_price, int full_price) {
            return base.Channel.SaveAsync(mark, age, price, motor_value, custom_price, full_price);
        }
        
        public string PrintOutput(string id) {
            return base.Channel.PrintOutput(id);
        }
        
        public System.Threading.Tasks.Task<string> PrintOutputAsync(string id) {
            return base.Channel.PrintOutputAsync(id);
        }
    }
}
