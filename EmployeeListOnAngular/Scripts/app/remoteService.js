var employeesService = angular.module('employeesService', ['ngResource']);

employeesService.factory('Employees', ['$resource',
    function($resource){
        return $resource('/Api/Employees', {}, {
            query: {method: 'GET', params: { }, isArray: true },
            save: {method: 'POST'}
        });
    }]);