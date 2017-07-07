var app = angular.module("ContactApp", []);

app.controller("ContactListController", function($http){
    var self = this;
    $http.get("/api/contacts").then(function (response) {
        self.contacts = response.data;

    });
});
