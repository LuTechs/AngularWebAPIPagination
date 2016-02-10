var services = angular.module("services.rest", []);

services.factory("productFactory", [
    "$http", function($http) {

        var urlBase = "/API/Products";
        var functionFactory = {};

        functionFactory.getProductsByPage = function(pagesize, page) {
            return $http.get(urlBase + "/ProductByPage?pageSize=" + pagesize + "&page=" + page);
        };
        return functionFactory;
    }
]);