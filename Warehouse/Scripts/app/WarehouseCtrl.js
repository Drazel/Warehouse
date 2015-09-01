var Warehouse = angular.module('WarehouseApp', []);


Warehouse.controller('WarehouseCtrl', function ($scope, ProductService, SocetService) {
    $scope.productErrorMessage = '';
    $scope.socetErrorMessage = '';
    $scope.productToSocetErrorMessage = '';

    $scope.Ean = '';
    $scope.Barcode = '';

    $scope.productId = '';
    $scope.productName = '';
    $scope.productWeight = '';
    $scope.productVolume = '';

    $scope.socetId = '';
    $scope.socetRow = '';
    $scope.socetShelf = '';
    $scope.socetNumber = '';
    $scope.freeWeight = '';
    $scope.freeVolume = '';

    $scope.count = 0;

    $scope.getProduct = function () {
        ProductService.getProduct($scope.Ean)
            .success(function (product) {
                console.log('prod1');
                setProduct(product);
                console.log('prod2');
            })
            .error(function(error) {
                $scope.productErrorMessage = error;
        
            });
    }

    $scope.getSocet = function () {
        SocetService.getSocet($scope.Barcode)
            .success(function (socet) {
                setSocet(socet);
            })
            .error(function (error) {
                $scope.socetErrorMessage = error;
            });
    }

    $scope.setProductToSocet = function() {
        ProductService.setProductToSocet($scope.productId, $scope.socetId, $scope.count)
            .success(function (result) {
                if (result.Succes) {
                    $scope.getSocet();
                    $scope.productId = '';
                    $scope.productName = '';
                    $scope.productWeight = '';
                    $scope.productVolume = '';
                } else {
                    $scope.productToSocetErrorMessage = result.Message;
                }
            })
            .error(function (error) {
                $scope.productToSocetErrorMessage = error;
            });
    }

    $scope.clearSocetAndProduct = function () {
        $scope.productErrorMessage = '';
        $scope.socetErrorMessage = '';
        $scope.productToSocetErrorMessage = '';
        $scope.Ean = '';
        $scope.Barcode = '';
        $scope.productId = '';
        $scope.productName = '';
        $scope.productWeight = '';
        $scope.productVolume = '';
        $scope.socetId = '';
        $scope.socetRow = '';
        $scope.socetShelf = '';
        $scope.socetNumber = '';
        $scope.freeWeight = '';
        $scope.freeVolume = '';
        $scope.count = 0;
    }

    function setProduct(product) {
        if (product.Succes) {
            $scope.productErrorMessage = '';
            $scope.productId = product.Id;
            $scope.productName = product.Name;
            $scope.productWeight = product.Weight;
            $scope.productVolume = product.Volume;
        } else {
            $scope.productErrorMessage = product.Message;
            $scope.productId = '';
            $scope.productName = '';
            $scope.productWeight = '';
            $scope.productVolume = '';
        }
    }

    function setSocet(socet) {
        if (socet.Succes) {
            $scope.socetErrorMessage = '';
            $scope.socetId = socet.Id;
            $scope.socetRow = socet.RowBookstand;
            $scope.socetShelf = socet.ShelfBookstand;
            $scope.socetNumber = socet.SocetNumber;
            $scope.freeWeight = socet.FreeWeight;
            $scope.freeVolume = socet.FreeVolume;
        } else {
            $scope.socetErrorMessage = socet.Message;
            $scope.socetId = '';
            $scope.socetRow = '';
            $scope.socetShelf = '';
            $scope.socetNumber = '';
            $scope.freeWeight = '';
            $scope.freeVolume = '';
        }
    }


});

Warehouse.service("ProductService", function ($http) {

    this.getProduct = function (ean) {
        return $http.get('/SocetProduct/GetProductByEanAjax?ean=' + ean);
    };

    this.setProductToSocet = function (productId, socetId, count) {
        return $http.get('/SocetProduct/SetProductToSocet?productId=' + productId + '&socetId=' + socetId + '&count=' + count);
    };
});

Warehouse.service("SocetService", function ($http) {

    this.getSocet = function (barcode) {
        return $http.get('/SocetProduct/GetSocetByBarcodeAjax?barcode=' + barcode);
    };
});