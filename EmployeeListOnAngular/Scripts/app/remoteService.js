var employeesService = angular.module('employeesService', ['ngResource']);

employeesService.factory('Employees', ['$resource',
    function($resource){
        return $resource('all.json', {}, {
            query: {method: 'GET', params: { }, isArray: true }
        });
    }]);