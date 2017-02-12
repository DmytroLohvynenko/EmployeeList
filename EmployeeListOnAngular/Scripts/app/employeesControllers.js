var employeesControllers = angular.module('employeesControllers', []);

employeesControllers.controller('employeeListController', ['$scope', 'Employees', 'Constants', function($scope, Employees, Constants){
    var employees = [];
    
    Employees.query(function(employeeList){
        angular.forEach(employeeList, function(empl){
            empl.jobTitleDescription = Constants.JobType[empl.jobTitle];
            employees.push(empl);
        });

        $scope.employees = employees;
    });
}]);

employeesControllers.controller('employeeCreateController', ['$scope','Constants', function($scope, Constants){
    $scope.jobTypes = Constants.JobType;

}]);