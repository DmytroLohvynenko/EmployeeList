var mainApp = angular.module('mainApp', ['ngRoute', 'employeesControllers', 'employeesService']);

mainApp.constant('Constants', {
    JobType: {
        0: 'CEO',
        1: 'Business Analyst',
        2: 'Developer',
        3: 'QA'
    }    
});

mainApp.config([
    '$routeProvider',
    function($routeProvider){
        $routeProvider.
            when('/employees', {
                title: 'List',
                templateUrl: 'views/list.html',
                controller: 'employeeListController'
            }).
            when('/employees/create', {
                title: 'Add an employee',
                templateUrl: 'views/create.html',
                controller: 'employeeCreateController'
            }).
            otherwise({
                redirectTo: '/employees'
            });
    }
]);