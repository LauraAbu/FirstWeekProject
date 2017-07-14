app.controller("MessageListController", function ($scope, $http, $location) {
    $scope.messages = [];
    var baseURI = "http://localhost:50079";

    $scope.searchPattern = "";

    $http.get(baseURI + "/api/messages").then(function (response) {
        $scope.messages = response.data;
    });
    
    $scope.onDelete = function (data, index) {


        $http.delete(baseURI + "/api/messages/" + data.Id).then(function (response) {
            $scope.messages.splice(index, 1);


        });

    };
       
});