app.controller("ContactListController", function ($scope, $http, $location) {
    $scope.contacts = [];

    $http.get("/api/contacts").then(function (response) {
        $scope.contacts = response.data;
    });
    
    $scope.onDelete = function (data, index) {


        $http.delete("/api/contacts/" + data.Id).then(function (response) {
            $scope.contacts.splice(index, 1);


        });

    };
       
});