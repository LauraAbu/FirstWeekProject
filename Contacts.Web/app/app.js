var app = angular.module("ContactApp", ["ngRoute"]);

app.config(function ($routeProvider, $locationProvider, $httpProvider) {


    $httpProvider.defaults.withCredentials = true; //siunciant uzklausa i API pridedamas autetifikacijos cookies

        $routeProvider
            .when("/", {
                templateUrl: "app/templates/contactList.html",
                controller: "ContactListController"
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
            .when("/login", {
                templateUrl: "app/templates/login.html",
                controller: "LoginController"
            });

        //$rootScope.url = "http://localhost:50079/";
        $locationProvider.html5Mode(false);
})
.service('authInterceptor', function ($q) { //custom interceptorius
        var service = this;

        service.responseError = function (response) {
            if (response.status == 401) { //jeigu is api gauname 401 (unauthorised) errora 
                window.location = "/#!/login"; //redirectiname useri i login langa
            }
            return $q.reject(response);
        };
    })
    .config(['$httpProvider', function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor'); //interceptorius
    }]);

