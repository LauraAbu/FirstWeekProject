app.controller("MessageListController", function ($scope, $http, $location) {
    $scope.message = [];
    var baseURI = "http://localhost:50079";

    $scope.searchPattern = "";

    $http.get(baseURI + "/api/messages").then(function (response) {
        $scope.message = response.data;
    });
    
    $scope.onDelete = function (data, index) {


        $http.delete(baseURI + "/api/messages/" + data.Id).then(function (response) {
            $scope.message.splice(index, 1);


        });

    };
       
});