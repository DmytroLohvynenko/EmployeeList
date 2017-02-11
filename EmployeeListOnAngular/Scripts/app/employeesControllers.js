var employeesCortrollers = angular.module('employeesControllers', []);

employeesCortrollers.controller('employeeListController', ['$scope', 'Employees', 'Constants', function($scope, Employees, Constants){
    var employees = [];
    
    Employees.query(function(employeeList){
        angular.forEach(employeeList, function(empl){
            empl.jobTitleDescription = Constants.JobType[empl.jobTitle];
            employees.push(empl);
        });

        $scope.employees = employees;
    });
}]);