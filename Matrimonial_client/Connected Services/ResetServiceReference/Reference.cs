﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matrimonial_client.ResetServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ResetServiceReference.IReset")]
    public interface IReset {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReset/Reset", ReplyAction="http://tempuri.org/IReset/ResetResponse")]
        bool Reset(string token, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReset/Reset", ReplyAction="http://tempuri.org/IReset/ResetResponse")]
        System.Threading.Tasks.Task<bool> ResetAsync(string token, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResetChannel : Matrimonial_client.ResetServiceReference.IReset, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResetClient : System.ServiceModel.ClientBase<Matrimonial_client.ResetServiceReference.IReset>, Matrimonial_client.ResetServiceReference.IReset {
        
        public ResetClient() {
        }
        
        public ResetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Reset(string token, string pass) {
            return base.Channel.Reset(token, pass);
        }
        
        public System.Threading.Tasks.Task<bool> ResetAsync(string token, string pass) {
            return base.Channel.ResetAsync(token, pass);
        }
    }
}
