(function () {
    'use strict';

    angular
        .module('app')
        .service('TodoService', TodoService);

    TodoService.$inject = ['$http'];

    function TodoService($http) {
        this.getTodos = getTodos;
        this.addTodo = addTodo;

        function getTodos() {
             return $http({
                method: 'GET',
                url: '/api/todo'
            });
        }
        function addTodo(todo) {
             return $http({
                method: 'POST',
                url: '/api/todo',
                data: todo
            });
        }
    }
})();