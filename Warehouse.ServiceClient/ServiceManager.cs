using System;
using System.Linq.Expressions;
using System.ServiceModel;
using Warehouse.ServiceClient.WarehouseService;

namespace Warehouse.ServiceClient
{
    public class ServiceManager
    {
        #region Variables

        private static volatile ServiceManager _instance;
        private static readonly object _sync = new Object();

        private WarehouseService.ServiceClient _serviceClient;
        private ProductClient _productClient;
        private WarehouseSocetClient _warehouseSocetClient;
        private PackageClient _packageClient;
        private SocetProductsClient _socetProductsClient;
        private OrderClient _orderClient;
        private SupplyClient _supplyClient;

        #endregion

        #region Properties

        public static ServiceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                        {
                            _instance = new ServiceManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public WarehouseService.ServiceClient ServiceClient
        {
            get
            {
                if (_serviceClient == null)
                {
                    CreateServiceClient();
                }

                if (_serviceClient.State == CommunicationState.Faulted)
                {
                    CreateServiceClient();
                }

                return _serviceClient;
            }
        }

        public ProductClient ProductClient
        {
            get
            {
                if (_productClient == null)
                {
                    CreateProductClient();
                }

                if (_productClient.State == CommunicationState.Faulted)
                {
                    CreateProductClient();
                }

                return _productClient;
            }
        }

        public WarehouseSocetClient WarehouseSocetClient
        {
            get
            {
                if (_warehouseSocetClient == null)
                {
                    CreateWarehouseSocetClient();
                }

                if (_warehouseSocetClient.State == CommunicationState.Faulted)
                {
                    CreateWarehouseSocetClient();
                }

                return _warehouseSocetClient;
            }
        }

        public PackageClient PackageClient
        {
            get
            {
                if (_packageClient == null)
                {
                    CreatePackageClient();
                }

                if (_packageClient.State == CommunicationState.Faulted)
                {
                    CreatePackageClient();
                }

                return _packageClient;
            }
        }

        public SocetProductsClient SocetProductsClient
        {
            get
            {
                if (_socetProductsClient == null)
                {
                    CreateSocetProductsClient();
                }

                if (_socetProductsClient.State == CommunicationState.Faulted)
                {
                    CreateSocetProductsClient();
                }

                return _socetProductsClient;
            }
        }

        public OrderClient OrderClient
        {
            get
            {
                if (_orderClient == null)
                {
                    CreateOrderClient();
                }

                if (_orderClient.State == CommunicationState.Faulted)
                {
                    CreateOrderClient();
                }

                return _orderClient;
            }
        }

        public SupplyClient SupplyClient
        {
            get
            {
                if (_supplyClient == null)
                {
                    CreateSupplyClient();
                }

                if (_supplyClient.State == CommunicationState.Faulted)
                {
                    CreateSupplyClient();
                }

                return _supplyClient;
            }
        }

        #endregion

        #region Constructors

        private ServiceManager()
        {
        }

        #endregion

        #region Methods

        public static TResult Call<TSource, TResult>(Expression<Func<TSource, TResult>> selector) where TSource : class
        {
            Func<TSource, TResult> func = selector.Compile();

            try
            {
                return func(GetClient<TSource>());
            }
            catch (Exception ex)
            {
                //TODO: obsługa logowania błedów
                // odtwórz kanał
                Instance.Service_Faulted(GetClient<TSource>(), new EventArgs());

                // ponów próbę
                return func(GetClient<TSource>());
            }
        }

        public static void CallVoid<TSource>(Expression<Action<TSource>> selector) where TSource : class
        {
            Action<TSource> func = selector.Compile();

            try
            {
                func(GetClient<TSource>());
            }
            catch (CommunicationException ex)
            {
                //TODO: obsługa logowania błedów
                // odtwórz kanał
                Instance.Service_Faulted(GetClient<TSource>(), new EventArgs());

                // ponów próbę
                func(GetClient<TSource>());
            }
        }

        private void CreateServiceClient()
        {
            _serviceClient = new WarehouseService.ServiceClient("BasicHttpBinding_IService");
            ((ICommunicationObject) _serviceClient).Faulted += Service_Faulted;
        }

        private void CreateProductClient()
        {
            _productClient = new ProductClient("BasicHttpBinding_IProduct");
            ((ICommunicationObject) _productClient).Faulted += Service_Faulted;
        }

        private void CreateWarehouseSocetClient()
        {
            _warehouseSocetClient = new WarehouseSocetClient("BasicHttpBinding_IWarehouseSocet");
            ((ICommunicationObject) _warehouseSocetClient).Faulted += Service_Faulted;
        }

        private void CreatePackageClient()
        {
            _packageClient = new PackageClient("BasicHttpBinding_IPackage");
            ((ICommunicationObject) _packageClient).Faulted += Service_Faulted;
        }

        private void CreateSocetProductsClient()
        {
            _socetProductsClient = new SocetProductsClient("BasicHttpBinding_ISocetProducts");
            ((ICommunicationObject)_socetProductsClient).Faulted += Service_Faulted;
        }

        private void CreateOrderClient()
        {
            _orderClient = new OrderClient("BasicHttpBinding_IOrder");
            ((ICommunicationObject)_orderClient).Faulted += Service_Faulted;
        }

        private void CreateSupplyClient()
        {
            _supplyClient = new SupplyClient("BasicHttpBinding_ISupply");
            ((ICommunicationObject)_supplyClient).Faulted += Service_Faulted;
        }

        private static TSource GetClient<TSource>() where TSource : class
        {
            if (typeof (TSource) == typeof (WarehouseService.ServiceClient))
                return Instance.ServiceClient as TSource;
            if (typeof (TSource) == typeof (ProductClient))
                return Instance.ProductClient as TSource;
            if (typeof (TSource) == typeof (WarehouseSocetClient))
                return Instance.WarehouseSocetClient as TSource;
            if (typeof (TSource) == typeof (PackageClient))
                return Instance.PackageClient as TSource;
            if (typeof(TSource) == typeof(SocetProductsClient))
                return Instance.SocetProductsClient as TSource;
            if (typeof(TSource) == typeof(OrderClient))
                return Instance.OrderClient as TSource;
            if (typeof(TSource) == typeof(SupplyClient))
                return Instance.SupplyClient as TSource;
            throw new ArgumentException("Invalid generic WCF Client!");
        }

        #endregion

        #region Events

        private void Service_Faulted(object sender, EventArgs e)
        {
        }

        #endregion
    }
}