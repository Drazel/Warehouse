﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse.ServiceClient.WarehouseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectId", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    [System.SerializableAttribute()]
    public partial struct ObjectId : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int _incrementField;
        
        private int _machineField;
        
        private short _pidField;
        
        private int _timestampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _increment {
            get {
                return this._incrementField;
            }
            set {
                if ((this._incrementField.Equals(value) != true)) {
                    this._incrementField = value;
                    this.RaisePropertyChanged("_increment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _machine {
            get {
                return this._machineField;
            }
            set {
                if ((this._machineField.Equals(value) != true)) {
                    this._machineField = value;
                    this.RaisePropertyChanged("_machine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short _pid {
            get {
                return this._pidField;
            }
            set {
                if ((this._pidField.Equals(value) != true)) {
                    this._pidField = value;
                    this.RaisePropertyChanged("_pid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _timestamp {
            get {
                return this._timestampField;
            }
            set {
                if ((this._timestampField.Equals(value) != true)) {
                    this._timestampField = value;
                    this.RaisePropertyChanged("_timestamp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        int Ping(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        System.Threading.Tasks.Task<int> PingAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Warehouse.ServiceClient.WarehouseService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IService>, Warehouse.ServiceClient.WarehouseService.IService {
        
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
        
        public int Ping(System.DateTime date) {
            return base.Channel.Ping(date);
        }
        
        public System.Threading.Tasks.Task<int> PingAsync(System.DateTime date) {
            return base.Channel.PingAsync(date);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/AddProduct", ReplyAction="http://tempuri.org/IProduct/AddProductResponse")]
        Warehouse.Data.Result.BoolResult AddProduct(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/AddProduct", ReplyAction="http://tempuri.org/IProduct/AddProductResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductAsync(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/UpdateProduct", ReplyAction="http://tempuri.org/IProduct/UpdateProductResponse")]
        Warehouse.Data.Result.BoolResult UpdateProduct(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/UpdateProduct", ReplyAction="http://tempuri.org/IProduct/UpdateProductResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdateProductAsync(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProducts", ReplyAction="http://tempuri.org/IProduct/GetProductsResponse")]
        Warehouse.Data.Dto.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProducts", ReplyAction="http://tempuri.org/IProduct/GetProductsResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        Warehouse.Data.Dto.Product GetProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductAsync(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProductByEan", ReplyAction="http://tempuri.org/IProduct/GetProductByEanResponse")]
        Warehouse.Data.Dto.Product GetProductByEan(string ean);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProductByEan", ReplyAction="http://tempuri.org/IProduct/GetProductByEanResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductByEanAsync(string ean);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : Warehouse.ServiceClient.WarehouseService.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IProduct>, Warehouse.ServiceClient.WarehouseService.IProduct {
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Warehouse.Data.Result.BoolResult AddProduct(Warehouse.Data.Dto.Product product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductAsync(Warehouse.Data.Dto.Product product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public Warehouse.Data.Result.BoolResult UpdateProduct(Warehouse.Data.Dto.Product product) {
            return base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdateProductAsync(Warehouse.Data.Dto.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
        
        public Warehouse.Data.Dto.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public Warehouse.Data.Dto.Product GetProduct(string productId) {
            return base.Channel.GetProduct(productId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductAsync(string productId) {
            return base.Channel.GetProductAsync(productId);
        }
        
        public Warehouse.Data.Dto.Product GetProductByEan(string ean) {
            return base.Channel.GetProductByEan(ean);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductByEanAsync(string ean) {
            return base.Channel.GetProductByEanAsync(ean);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IWarehouseSocet")]
    public interface IWarehouseSocet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/AddWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/AddWarehouseSocetResponse")]
        Warehouse.Data.Result.BoolResult AddWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/AddWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/AddWarehouseSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocetResponse")]
        Warehouse.Data.Result.BoolResult UpdateWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdateWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocets", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetsResponse")]
        Warehouse.Data.Dto.WarehouseSocet[] GetWarehouseSocets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocets", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetsResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet[]> GetWarehouseSocetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetResponse")]
        Warehouse.Data.Dto.WarehouseSocet GetWarehouseSocet(string socetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetWarehouseSocetAsync(string socetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetSocetByBarcode", ReplyAction="http://tempuri.org/IWarehouseSocet/GetSocetByBarcodeResponse")]
        Warehouse.Data.Dto.WarehouseSocet GetSocetByBarcode(string barcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetSocetByBarcode", ReplyAction="http://tempuri.org/IWarehouseSocet/GetSocetByBarcodeResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetSocetByBarcodeAsync(string barcode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarehouseSocetChannel : Warehouse.ServiceClient.WarehouseService.IWarehouseSocet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseSocetClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IWarehouseSocet>, Warehouse.ServiceClient.WarehouseService.IWarehouseSocet {
        
        public WarehouseSocetClient() {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseSocetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Warehouse.Data.Result.BoolResult AddWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddWarehouseSocet(socet);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddWarehouseSocetAsync(socet);
        }
        
        public Warehouse.Data.Result.BoolResult UpdateWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.UpdateWarehouseSocet(socet);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdateWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.UpdateWarehouseSocetAsync(socet);
        }
        
        public Warehouse.Data.Dto.WarehouseSocet[] GetWarehouseSocets() {
            return base.Channel.GetWarehouseSocets();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet[]> GetWarehouseSocetsAsync() {
            return base.Channel.GetWarehouseSocetsAsync();
        }
        
        public Warehouse.Data.Dto.WarehouseSocet GetWarehouseSocet(string socetId) {
            return base.Channel.GetWarehouseSocet(socetId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetWarehouseSocetAsync(string socetId) {
            return base.Channel.GetWarehouseSocetAsync(socetId);
        }
        
        public Warehouse.Data.Dto.WarehouseSocet GetSocetByBarcode(string barcode) {
            return base.Channel.GetSocetByBarcode(barcode);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetSocetByBarcodeAsync(string barcode) {
            return base.Channel.GetSocetByBarcodeAsync(barcode);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IPackage")]
    public interface IPackage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/AddPackage", ReplyAction="http://tempuri.org/IPackage/AddPackageResponse")]
        Warehouse.Data.Result.BoolResult AddPackage(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/AddPackage", ReplyAction="http://tempuri.org/IPackage/AddPackageResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddPackageAsync(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/UpdatePackage", ReplyAction="http://tempuri.org/IPackage/UpdatePackageResponse")]
        Warehouse.Data.Result.BoolResult UpdatePackage(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/UpdatePackage", ReplyAction="http://tempuri.org/IPackage/UpdatePackageResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdatePackageAsync(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackages", ReplyAction="http://tempuri.org/IPackage/GetPackagesResponse")]
        Warehouse.Data.Dto.Package[] GetPackages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackages", ReplyAction="http://tempuri.org/IPackage/GetPackagesResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Package[]> GetPackagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackage", ReplyAction="http://tempuri.org/IPackage/GetPackageResponse")]
        Warehouse.Data.Dto.Package GetPackage(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackage", ReplyAction="http://tempuri.org/IPackage/GetPackageResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Package> GetPackageAsync(string productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPackageChannel : Warehouse.ServiceClient.WarehouseService.IPackage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PackageClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IPackage>, Warehouse.ServiceClient.WarehouseService.IPackage {
        
        public PackageClient() {
        }
        
        public PackageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PackageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Warehouse.Data.Result.BoolResult AddPackage(Warehouse.Data.Dto.Package product) {
            return base.Channel.AddPackage(product);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddPackageAsync(Warehouse.Data.Dto.Package product) {
            return base.Channel.AddPackageAsync(product);
        }
        
        public Warehouse.Data.Result.BoolResult UpdatePackage(Warehouse.Data.Dto.Package product) {
            return base.Channel.UpdatePackage(product);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> UpdatePackageAsync(Warehouse.Data.Dto.Package product) {
            return base.Channel.UpdatePackageAsync(product);
        }
        
        public Warehouse.Data.Dto.Package[] GetPackages() {
            return base.Channel.GetPackages();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Package[]> GetPackagesAsync() {
            return base.Channel.GetPackagesAsync();
        }
        
        public Warehouse.Data.Dto.Package GetPackage(string productId) {
            return base.Channel.GetPackage(productId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Package> GetPackageAsync(string productId) {
            return base.Channel.GetPackageAsync(productId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.ISocetProducts")]
    public interface ISocetProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddProductToSocet", ReplyAction="http://tempuri.org/ISocetProducts/AddProductToSocetResponse")]
        Warehouse.Data.Result.BoolResult AddProductToSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddProductToSocet", ReplyAction="http://tempuri.org/ISocetProducts/AddProductToSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductToSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddProductIdToSocetId", ReplyAction="http://tempuri.org/ISocetProducts/AddProductIdToSocetIdResponse")]
        Warehouse.Data.Result.BoolResult AddProductIdToSocetId(string productId, string socetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddProductIdToSocetId", ReplyAction="http://tempuri.org/ISocetProducts/AddProductIdToSocetIdResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductIdToSocetIdAsync(string productId, string socetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddManyProductToSocet", ReplyAction="http://tempuri.org/ISocetProducts/AddManyProductToSocetResponse")]
        Warehouse.Data.Result.BoolResult AddManyProductToSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddManyProductToSocet", ReplyAction="http://tempuri.org/ISocetProducts/AddManyProductToSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddManyProductToSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddManyProductIdToSocetId", ReplyAction="http://tempuri.org/ISocetProducts/AddManyProductIdToSocetIdResponse")]
        Warehouse.Data.Result.BoolResult AddManyProductIdToSocetId(string productId, string socetId, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/AddManyProductIdToSocetId", ReplyAction="http://tempuri.org/ISocetProducts/AddManyProductIdToSocetIdResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddManyProductIdToSocetIdAsync(string productId, string socetId, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/GetProductFromSocet", ReplyAction="http://tempuri.org/ISocetProducts/GetProductFromSocetResponse")]
        Warehouse.Data.Result.BoolResult GetProductFromSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/GetProductFromSocet", ReplyAction="http://tempuri.org/ISocetProducts/GetProductFromSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> GetProductFromSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/GetManyProductFromSocet", ReplyAction="http://tempuri.org/ISocetProducts/GetManyProductFromSocetResponse")]
        Warehouse.Data.Result.BoolResult GetManyProductFromSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISocetProducts/GetManyProductFromSocet", ReplyAction="http://tempuri.org/ISocetProducts/GetManyProductFromSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> GetManyProductFromSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISocetProductsChannel : Warehouse.ServiceClient.WarehouseService.ISocetProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SocetProductsClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.ISocetProducts>, Warehouse.ServiceClient.WarehouseService.ISocetProducts {
        
        public SocetProductsClient() {
        }
        
        public SocetProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SocetProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocetProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SocetProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Warehouse.Data.Result.BoolResult AddProductToSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddProductToSocet(product, socet);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductToSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddProductToSocetAsync(product, socet);
        }
        
        public Warehouse.Data.Result.BoolResult AddProductIdToSocetId(string productId, string socetId) {
            return base.Channel.AddProductIdToSocetId(productId, socetId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddProductIdToSocetIdAsync(string productId, string socetId) {
            return base.Channel.AddProductIdToSocetIdAsync(productId, socetId);
        }
        
        public Warehouse.Data.Result.BoolResult AddManyProductToSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count) {
            return base.Channel.AddManyProductToSocet(product, socet, count);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddManyProductToSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count) {
            return base.Channel.AddManyProductToSocetAsync(product, socet, count);
        }
        
        public Warehouse.Data.Result.BoolResult AddManyProductIdToSocetId(string productId, string socetId, int count) {
            return base.Channel.AddManyProductIdToSocetId(productId, socetId, count);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> AddManyProductIdToSocetIdAsync(string productId, string socetId, int count) {
            return base.Channel.AddManyProductIdToSocetIdAsync(productId, socetId, count);
        }
        
        public Warehouse.Data.Result.BoolResult GetProductFromSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.GetProductFromSocet(product, socet);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> GetProductFromSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.GetProductFromSocetAsync(product, socet);
        }
        
        public Warehouse.Data.Result.BoolResult GetManyProductFromSocet(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count) {
            return base.Channel.GetManyProductFromSocet(product, socet, count);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Result.BoolResult> GetManyProductFromSocetAsync(Warehouse.Data.Dto.Product product, Warehouse.Data.Dto.WarehouseSocet socet, int count) {
            return base.Channel.GetManyProductFromSocetAsync(product, socet, count);
        }
    }
}
