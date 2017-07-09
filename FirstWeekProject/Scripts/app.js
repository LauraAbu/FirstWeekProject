var app = angular.module("ContactApp", ["ngRoute"]);

app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "Static/ContactEdit.html",
                controller: "ContactEditController"
            })
            .when("/contacts", {
                templateUrl: "Static/ContactList.html",
                controller: "ContactListController"
            })
            .when("/contacts/:id", {
                templateUrl: "Static/ContactEdit.html",
                controller:"ContactEditController"
            })
            .when("/blue", {
                templateUrl: "blue.html"
        });
        $locationProvider.html5Mode(true);
    });

