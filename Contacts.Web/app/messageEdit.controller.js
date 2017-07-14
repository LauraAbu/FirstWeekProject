app.controller("MessageEditController", function ($scope, $http, $routeParams, $location) {
    $scope.message = {

    };
    $scope.contacts = [];

    var baseURI = "http://localhost:50079";

    $scope.init = function () {

        $http.get(baseURI + "/api/contacts").then(function (response) {

            $scope.contacts = response.data;
        });
    }

    $scope.onSave = function ()
    {

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


                