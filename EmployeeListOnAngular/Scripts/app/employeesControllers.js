var employeesCortrollers = angular.module('employeesControllers', []);

employeesCortrollers.controller('employeeListController', ['$scope', 'Employees', function($scope, Employees){
    Employees.query(function(data){
        var employees = [];

        $scope.employees = employees;
    });
}]);