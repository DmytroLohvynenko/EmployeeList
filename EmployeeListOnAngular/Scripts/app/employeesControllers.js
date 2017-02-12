var employeesControllers = angular.module('employeesControllers', []);

employeesControllers.controller('employeeListController', ['$scope', 'Employees', 'Employee', 'Constants', function($scope, Employees, Employee, Constants){
    
    var queryEmployees = function(){
        var employees = [];    
        Employees.query(function(employeeList){
            angular.forEach(employeeList, function(empl){
                empl.jobTitleDescription = Constants.JobType[empl.jobTitle].name;
                employees.push(empl);
            });

            $scope.employees = employees;
        });
    };

    queryEmployees();    

    $scope.removeEmployee = function(employeeId){
        Employee.remove({id:employeeId});
        queryEmployees();
    };
}]);

employeesControllers.controller('employeeCreateController', ['$scope', '$route', 'Employees', 'Constants', function($scope, $route, Employees, Constants){
    $scope.jobTypes = Constants.JobType;
    $scope.newEmployee = {};
    $scope.newEmployee.employeeId = 0;

    $scope.saveEmployee = function(){
        var employees = new Employees($scope.newEmployee);
        employees.$save();
        $route.reload();
    };
}]);