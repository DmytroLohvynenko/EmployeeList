var employeesControllers = angular.module('employeesControllers', []);

employeesControllers.controller('employeeListController', ['$scope', '$route', 'Employees', 'Employee', 'Constants', function($scope, $route, Employees, Employee, Constants){
    var employees = [];    
    Employees.query(function(employeeList){
        angular.forEach(employeeList, function(empl){
            empl.jobTitleDescription = Constants.JobType[empl.jobTitle].name;
            employees.push(empl);
        });

        $scope.employees = employees;
    });

    $scope.removeEmployee = function(employeeId){
        if(confirm('You going to delete employee. Continue?')){
            Employee.remove({id:employeeId}).$promise.then(function(result){
                $route.reload();
            });
        };
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