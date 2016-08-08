//home-index.js

//deviation from pluralsight tutorial. use references here for initial creation of module and controller:
//http://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2015/05/13/how-to-use-angularjs-in-asp-net-mvc-and-entity-framework-4.aspx
//http://stackoverflow.com/questions/19408011/angularjs-error-argument-firstctrl-is-not-a-function-got-undefined


homeIndexModule = angular
    .module('HomeIndexModule', [])
    .controller('homeIndexController', function ($scope, $http) {
        $scope.dataCount = 0;
        $scope.data = [];
        $scope.isBusy = true;

        $http.get("/api/v1/topics?includeReplies=true")
        .then(function (result) {
            //Successful
            angular.copy(result.data, $scope.data); //for collections
        },
        function () {
            //Error
            alert("could not load topics");
        })
        .then(function () {
            $scope.isBusy = false;
        });
    });
