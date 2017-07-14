var app = angular.module("ContactApp", ["ngRoute"]);

app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "app/templates/contactEdit.html",
                controller: "ContactEditController"
            })
            .when("/contacts", {
                templateUrl: "app/templates/contactList.html",
                controller: "ContactListController"
            })
            .when("/contacts/:id", {
                templateUrl: "app/templates/contactEdit.html",
                controller:"ContactEditController"
            })
            .when("/messages", {
                templateUrl: "app/templates/messageList.html",
                controller: "MessageListController"
            })
            .when("/messages/:id", {
                templateUrl: "app/templates/messageEdit.html",
                controller: "MessageEditController"
            })
            .when("/blue", {
                templateUrl: "blue.html"
            });

        //$rootScope.url = "http://localhost:50079/";
        $locationProvider.html5Mode(false);
    });