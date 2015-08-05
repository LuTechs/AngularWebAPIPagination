var listModule = angular.module('ListProduct', ['ui.bootstrap', 'services.rest']);

listModule.controller('ListProductCtrl', [
    '$scope', 'productFactory', function ($scope, productFactory) {

        $scope.products = [];
        $scope.pagingOptions = { pageSize: 18, currentPage: 1 };
        $scope.totalItems = 0;
        $scope.numPages = 0;

        productFactory.getProductsByPage($scope.pagingOptions.pageSize, $scope.pagingOptions.currentPage)
            .success(function (data) {
                $scope.products = data.products;
                $scope.totalItems = data.totalItems;

            })
            .error(function (err) {
                console.log(err);
            });

        $scope.pageChanged = function () {

            productFactory.getProductsByPage($scope.pagingOptions.pageSize, $scope.pagingOptions.currentPage)
            .success(function (data) {
              $scope.products = data.products;
              $scope.totalItems = data.totalItems;
                })
          .error(function (err) {
              console.log(err);
          });
        };
    }
]);