﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matrimonial_client.ForgotServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ForgotServiceReference.IForgot")]
    public interface IForgot {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForgot/Forgot", ReplyAction="http://tempuri.org/IForgot/ForgotResponse")]
        string Forgot(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IForgot/Forgot", ReplyAction="http://tempuri.org/IForgot/ForgotResponse")]
        System.Threading.Tasks.Task<string> ForgotAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IForgotChannel : Matrimonial_client.ForgotServiceReference.IForgot, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ForgotClient : System.ServiceModel.ClientBase<Matrimonial_client.ForgotServiceReference.IForgot>, Matrimonial_client.ForgotServiceReference.IForgot {
        
        public ForgotClient() {
        }
        
        public ForgotClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ForgotClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ForgotClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ForgotClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Forgot(string email) {
            return base.Channel.Forgot(email);
        }
        
        public System.Threading.Tasks.Task<string> ForgotAsync(string email) {
            return base.Channel.ForgotAsync(email);
        }
    }
}
