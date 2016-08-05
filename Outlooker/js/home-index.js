//home-index.js

//deviation from pluralsight tutorial. use references here for initial creation of module and controller:
//http://www.infragistics.com/community/blogs/dhananjay_kumar/archive/2015/05/13/how-to-use-angularjs-in-asp-net-mvc-and-entity-framework-4.aspx
//http://stackoverflow.com/questions/19408011/angularjs-error-argument-firstctrl-is-not-a-function-got-undefined


homeIndexModule = angular
    .module('HomeIndexModule', [])
    .controller('homeIndexController', function ($scope) {
        $scope.name = "Shawn Wildermuth";
        $scope.data = [
            {
                title: "This is a message",
                body: "I am right about this.",
                created: "4/24/2013"
            },
            {
                title: "This is a second message",
                body: "I am right about this.",
                created: "4/24/2013"
            },
            {
                title: "This is a third message",
                body: "I am right about this.",
                created: "4/24/2013"
            },
        ];
    });
