//var myApp = angular.module('myApp', ['ui.router'], ['ngRoute']);
////myApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

////    $stateProvider
////        .state('login', {
////            url: '/',
////            templateUrl: '/ngApp/views/login.html',
////            controller: LoginController,
////            controllerAs: 'controller'
////        })
////    $locationProvider.html5Mode(true);
////});

//myApp.config(function($routeProvider) {

//    $routeProvider.when('/order',
//        {
//            templateUrl: 'views/Order/movie.cshtml'
//            //controller: 'OrderController' // Angular Controller
//        });


//});
var myApp = angular.module("myApp", ['ngRoute']);


myApp.controller("myController", function($scope, $http) {
    $scope.myvalue = "this is controller";
    //$scope.getDepartment = function() {
    //    alert("hi");
    $http.get('api/Movies1').then(function (res) { $scope.department = res.data }
        

    );
    console.log(this.department);

    //  }

});


