var mainApp = angular.module('mainApp', ['employeesControllers', 'employeesService']);

mainApp.constant('Constants', {
    JobType: {
        0: 'CEO',
        1: 'Business Analyst',
        2: 'Developer',
        3: 'QA'
    }    
});