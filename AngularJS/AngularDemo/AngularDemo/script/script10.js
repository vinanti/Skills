/// <reference path="angular.js" />
var app = angular.module("myModule", []);

app.controller('formController', function ($scope) {
    $scope.reset = function () {
        $scope.firstName = "";
        $scope.lastName = "";
        $scope.email = "";
    }
});