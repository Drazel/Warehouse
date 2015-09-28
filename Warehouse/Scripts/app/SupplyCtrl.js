var Supply = angular.module('SupplyApp', []);

Supply.controller('SupplyCtrl', function ($scope, OrderService) {

    $scope.SupplyNumber = '';
    $scope.Supply;
    $scope.Succes = false;

    $scope.Ean = '';
    $scope.Count = '';

    $scope.SuccesSocet = false;

    $scope.GerSupply = function () {
        OrderService.getSupply($scope.SupplyNumber)
            .success(function(supply) {
                $scope.Supply = supply;
                $scope.Succes = supply.Succes;
            })
            .error(function(error) {
                $scope.productErrorMessage = error;
                $scope.Succes = false;
            });
    }

});

Supply.directive('myEnter', function () {
    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            if (event.which === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.myEnter);
                });

                event.preventDefault();
            }
        });
    };
});


Supply.service("OrderService", function ($http) {

    this.getSupply = function (supplyNumber) {
        return $http.get('/Supply/GetSupplyAjax?supplyNumber=' + supplyNumber);
    };
});
