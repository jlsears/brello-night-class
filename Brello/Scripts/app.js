var app = angular.module('Brello', []);

app.controller("BoardController", ["$scope", "$http", function ($scope, $http) {
    $scope.test = "Hello World!";

    $scope.hello = function () {
        //$scope.test = "Hello, is it me you're looking for?";
        // GET: api/BoardApi/
        // How make ajax call using angular?
        $http.get("api/BoardApi")
            .success(function (data) {
                $scope.test = data;
        })
        .error(function () { alert(error.message);})
    }
}]);