var employeesControllers = angular.module('employeesControllers', []);

employeesControllers.controller('employeeListController', ['$scope', 'Employees', 'Constants', function($scope, Employees, Constants){
    var employees = [];
    
    Employees.query(function(employeeList){
        angular.forEach(employeeList, function(empl){
            empl.jobTitleDescription = Constants.JobType[empl.jobTitle].name;
            employees.push(empl);
        });

        $scope.employees = employees;
    });
}]);

employeesControllers.controller('employeeCreateController', ['$scope', 'Employees', 'Constants', function($scope, Employees, Constants){
    $scope.jobTypes = Constants.JobType;
    $scope.newEmployee = {};
    $scope.newEmployee.employeeId = 0;

    $scope.saveEmployee = function(){
        var employees = new Employees($scope.newEmployee);
        employees.$save();
    };
}]);