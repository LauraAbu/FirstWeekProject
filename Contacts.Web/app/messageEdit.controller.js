app.controller("MessageEditController", function ($scope, $http, $routeParams, $location) {
    $scope.message = {

    };
    var baseURI = "http://localhost:50079";

    $scope.init = function () {

        if ($routeParams.id === undefined) {
            $routeParams.id = 0;
        }
        $http.get(baseURI + "/api/messages/" + $routeParams.id).then(function (response) {
            $scope.message = response.data;

        });
    };
    $scope.onSave = function () {

        if ($scope.message.id > 0) {
            $http.put(baseURI + "/api/messges/" + $scope.message.Id, $scope.message).then(function (response) {
              
                $location.path("/messages");
            });
        }
        else {
            $http.post(baseURI + "/api/messages/", $scope.message).then(function (response) {
              
                $location.path("/messages");
            });
        }
    };
});


                