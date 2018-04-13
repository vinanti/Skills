/// <reference path="angular.js" />

var app = angular.module("myModule", []);

app.controller("firstController", function ($scope) {
    $scope.message = "AngularJS Tutorial";
});