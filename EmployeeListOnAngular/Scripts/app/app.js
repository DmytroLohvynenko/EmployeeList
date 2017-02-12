var mainApp = angular.module( 'mainApp',['ngRoute','employeesControllers','employeesService'] );

mainApp.constant( 'Constants',{
    JobType: [
        { id: 0, name: 'CEO' },
        { id: 1, name: 'Business Analyst' },
        { id: 2, name: 'Developer' },
        { id: 3, name: 'QA' }
    ]
} );

mainApp.config( [
    '$routeProvider','$locationProvider',
    function( $routeProvider,$locationProvider ) {
        $routeProvider.
            when( '/employees',{
                title: 'List',
                templateUrl: 'scripts/app/views/list.html',
                controller: 'employeeListController'
            } ).
            when( '/employees/create',{
                title: 'Add an employee',
                templateUrl: 'scripts/app/views/create.html',
                controller: 'employeeCreateController'
            } ).
            otherwise( {
                redirectTo: '/employees'
            } );

        $locationProvider.hashPrefix( '' );
    }
] );

mainApp.run( ['$rootScope',function( $rootScope ) {
    $rootScope.$on( '$routeChangeSuccess',function( event,current,previous ) {
        $rootScope.title = current.$$route.title;
    } );
}] );