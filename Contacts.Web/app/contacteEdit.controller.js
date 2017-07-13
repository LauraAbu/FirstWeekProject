app.controller("ContactEditController", function ($scope, $http, $routeParams, $location) {
    $scope.contact = {

    };
    var baseURI = "http://localhost:50079";


        if ($routeParams.id === undefined) {
            $routeParams.id = 0;
        }
        $http.get(baseURI + "/api/contacts/" + $routeParams.id).then(function (response) {
            $scope.contact = response.data;

        });
    $scope.onSave = function () {

        if ($scope.contact.Id > 0) {
            $http.put(baseURI +"/api/contacts/" + $scope.contact.Id, $scope.contact).then(function (response) {
               // $scope.contact = response.data;
                $location.path("/contacts");
            });
        }
        else {
            $http.post(baseURI +"/api/contacts/", $scope.contact).then(function (response) {
               // $scope.contact = response.data;
                $location.path("/contacts");
            });
        }
    };
});


                