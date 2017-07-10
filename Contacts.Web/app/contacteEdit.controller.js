app.controller("ContactEditController", function ($scope, $http, $routeParams, $location) {
    $scope.contact = {

    };

    $scope.init = function () {

        if ($routeParams.id === undefined) {
            $routeParams.id = 0;
        }
        $http.get("/api/contacts/" + $routeParams.id).then(function (response) {
            $scope.contact = response.data;

        });
    };
    $scope.onSave = function () {

        if ($scope.contact.Id > 0) {
            $http.put("/api/contacts/" + $scope.contact.Id, $scope.contact).then(function (response) {
               // $scope.contact = response.data;
                $location.path("/contacts");
            });
        }
        else {
            $http.post("/api/contacts/", $scope.contact).then(function (response) {
               // $scope.contact = response.data;
                $location.path("/contacts");
            });
        }
    };
});


                