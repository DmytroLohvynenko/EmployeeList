var employeesCortrollers = angular.module('employeesControllers', []);

employeesCortrollers.controller('employeeListController', ['$scope', '$http', function($scope, $http){
    $http.get('all.json').success(function(data){
        var employees = [];

        $scope.employees = employees;
    });
}]);