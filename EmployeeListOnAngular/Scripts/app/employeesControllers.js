var employeesCortrollers = angular.module('employeesControllers', []);

employeesCortrollers.controller('employeeListController', ['$scope', 'Employees', function($scope, Employees){
    var employees = [];
    Employees.query(function(employeeList){
        angular.forEach(employeeList, function(empl){
            empl.employmentDate = empl.employmentDate.slice(0,10); 
            employees.push(empl);
        });

        $scope.employees = employees;
    });
}]);