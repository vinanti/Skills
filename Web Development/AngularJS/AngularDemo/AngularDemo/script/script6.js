/// <reference path="angular.js" />

var app = angular.module("myModule", []);

app.controller("dataController", function ($scope) {
    var listEmployees = [
        { firstName: "Vinanti", lastName: "Thakur", gender: "F", salary: 20000 },
        { firstName: "Mihika", lastName: "T", gender: "F", salary: 20000 },
        { firstName: "Yogesh", lastName: "T", gender: "M", salary: 15000 },
        { firstName: "Rakesh", lastName: "K", gender: "M", salary: 60000 },
        { firstName: "Sinja", lastName: "Mishara", gender: "F", salary: 45000 },
        { firstName: "Ram", lastName: "Yadav", gender: "M", salary: 5000 }
    ];
    $scope.employees = listEmployees;
});