app.controller("LoginController", function ($scope, $http, $window, $location ) {
   // $scope.providers = [];
    var baseURI = "http://localhost:50079";

    $scope.searchPattern = "";

    //$http.get(baseURI + "/ExternalLogins?returnUrl=%2Fcontacts").then(function (response) {
    //    $scope.providers = response.data;
    //});
    
    $scope.login = function () {


        $window.location.href = baseURI + "/api/login";

    };
       
});