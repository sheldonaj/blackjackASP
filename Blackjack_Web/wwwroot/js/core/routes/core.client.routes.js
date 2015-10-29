'use strict';

// Setting up route
angular.module('core').config(['$stateProvider', '$urlRouterProvider',
  function ($stateProvider, $urlRouterProvider) {

    // Not using the boilerplate 'home' state.  Just redirect to the newgame state as the default starting index.
  	//$urlRouterProvider.when('/', '/newgame');
      $urlRouterProvider.when('/', '/games/5614119ca3a35b704df4a447');
    // Redirect to 404 when route not found
    $urlRouterProvider.otherwise('not-found');

    // Home state routing
    $stateProvider
      .state('home', {
        url: '/',
        templateUrl: 'templates/core/404.html',
        redirectTo: 'game'
      })
      .state('not-found', {
        url: '/not-found',
        templateUrl: 'templates/core/404.html'
      });
  }
]);
