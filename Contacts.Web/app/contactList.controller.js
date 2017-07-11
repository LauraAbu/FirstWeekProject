app.controller("ContactListController", function ($scope, $http, $location) {
    $scope.contacts = [];
    var baseURI = "http://localhost:50079";

    $http.get(baseURI + "/api/contacts").then(function (response) {
        $scope.contacts = response.data;
    });
    
    $scope.onDelete = function (data, index) {


        $http.delete(baseURI + "/api/contacts/" + data.Id).then(function (response) {
            $scope.contacts.splice(index, 1);


        });

    };
       
});