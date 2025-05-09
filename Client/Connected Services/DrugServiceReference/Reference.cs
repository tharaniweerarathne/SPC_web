﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.DrugServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DrugServiceReference.DrugDetailsWebServiceSoap")]
    public interface DrugDetailsWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoDrugId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AutoDrugId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoDrugId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AutoDrugIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDrug", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string insertDrug(string DrugID, string Name, string Category, int Quantity, string UnitPrice, string SourceType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertDrug", ReplyAction="*")]
        System.Threading.Tasks.Task<string> insertDrugAsync(string DrugID, string Name, string Category, int Quantity, string UnitPrice, string SourceType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool AddStock(string DrugID, int newStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddStock", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AddStockAsync(string DrugID, int newStock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchStock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchStock(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchStock", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchStockAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoOrderId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AutoOrderId();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AutoOrderId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AutoOrderIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool PlaceOrder(string OrderID, string DrugID, string PharmacyID, int Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PlaceOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PlaceOrderAsync(string OrderID, string DrugID, string PharmacyID, int Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchStockPharmacy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchStockPharmacy(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchStockPharmacy", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchStockPharmacyAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getPharmacyName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getPharmacyNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getPharmacyId(string PharmacyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPharmacyId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getPharmacyIdAsync(string PharmacyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet getDrugName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getDrugId(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getDrugId", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getDrugIdAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOrdersByPharmacy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchOrdersByPharmacy(string PharmacyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOrdersByPharmacy", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchOrdersByPharmacyAsync(string PharmacyName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DrugDetailsWebServiceSoapChannel : Client.DrugServiceReference.DrugDetailsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DrugDetailsWebServiceSoapClient : System.ServiceModel.ClientBase<Client.DrugServiceReference.DrugDetailsWebServiceSoap>, Client.DrugServiceReference.DrugDetailsWebServiceSoap {
        
        public DrugDetailsWebServiceSoapClient() {
        }
        
        public DrugDetailsWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DrugDetailsWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DrugDetailsWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DrugDetailsWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AutoDrugId() {
            return base.Channel.AutoDrugId();
        }
        
        public System.Threading.Tasks.Task<string> AutoDrugIdAsync() {
            return base.Channel.AutoDrugIdAsync();
        }
        
        public string insertDrug(string DrugID, string Name, string Category, int Quantity, string UnitPrice, string SourceType) {
            return base.Channel.insertDrug(DrugID, Name, Category, Quantity, UnitPrice, SourceType);
        }
        
        public System.Threading.Tasks.Task<string> insertDrugAsync(string DrugID, string Name, string Category, int Quantity, string UnitPrice, string SourceType) {
            return base.Channel.insertDrugAsync(DrugID, Name, Category, Quantity, UnitPrice, SourceType);
        }
        
        public bool AddStock(string DrugID, int newStock) {
            return base.Channel.AddStock(DrugID, newStock);
        }
        
        public System.Threading.Tasks.Task<bool> AddStockAsync(string DrugID, int newStock) {
            return base.Channel.AddStockAsync(DrugID, newStock);
        }
        
        public System.Data.DataSet SearchStock(string Name) {
            return base.Channel.SearchStock(Name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchStockAsync(string Name) {
            return base.Channel.SearchStockAsync(Name);
        }
        
        public string AutoOrderId() {
            return base.Channel.AutoOrderId();
        }
        
        public System.Threading.Tasks.Task<string> AutoOrderIdAsync() {
            return base.Channel.AutoOrderIdAsync();
        }
        
        public bool PlaceOrder(string OrderID, string DrugID, string PharmacyID, int Quantity) {
            return base.Channel.PlaceOrder(OrderID, DrugID, PharmacyID, Quantity);
        }
        
        public System.Threading.Tasks.Task<bool> PlaceOrderAsync(string OrderID, string DrugID, string PharmacyID, int Quantity) {
            return base.Channel.PlaceOrderAsync(OrderID, DrugID, PharmacyID, Quantity);
        }
        
        public System.Data.DataSet SearchStockPharmacy(string Name) {
            return base.Channel.SearchStockPharmacy(Name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchStockPharmacyAsync(string Name) {
            return base.Channel.SearchStockPharmacyAsync(Name);
        }
        
        public System.Data.DataSet getPharmacyName() {
            return base.Channel.getPharmacyName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getPharmacyNameAsync() {
            return base.Channel.getPharmacyNameAsync();
        }
        
        public string getPharmacyId(string PharmacyName) {
            return base.Channel.getPharmacyId(PharmacyName);
        }
        
        public System.Threading.Tasks.Task<string> getPharmacyIdAsync(string PharmacyName) {
            return base.Channel.getPharmacyIdAsync(PharmacyName);
        }
        
        public System.Data.DataSet getDrugName() {
            return base.Channel.getDrugName();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getDrugNameAsync() {
            return base.Channel.getDrugNameAsync();
        }
        
        public string getDrugId(string Name) {
            return base.Channel.getDrugId(Name);
        }
        
        public System.Threading.Tasks.Task<string> getDrugIdAsync(string Name) {
            return base.Channel.getDrugIdAsync(Name);
        }
        
        public System.Data.DataSet SearchOrdersByPharmacy(string PharmacyName) {
            return base.Channel.SearchOrdersByPharmacy(PharmacyName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchOrdersByPharmacyAsync(string PharmacyName) {
            return base.Channel.SearchOrdersByPharmacyAsync(PharmacyName);
        }
    }
}
