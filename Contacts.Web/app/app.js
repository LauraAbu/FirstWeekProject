var app = angular.module("ContactApp", ["ngRoute"]);

app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "app/templates/edit.html",
                controller: "ContactEditController"
            })
            .when("/contacts", {
                templateUrl: "app/templates/list.html",
                controller: "ContactListController"
            })
            .when("/contacts/:id", {
                templateUrl: "app/templates/edit.html",
                controller:"ContactEditController"
            })
            .when("/blue", {
                templateUrl: "blue.html"
            });

        //$rootScope.url = "http://localhost:50079/";
        $locationProvider.html5Mode(true);
    });