angular.module('todoApp', [])


    .controller('MyController', ['$scope', function($scope) {
        $scope.username = 'World';

        $scope.sayHello = function() {
            $scope.greeting = 'Hello ' + $scope.username + '!';
        };
    }])
    .controller('TodoListController', ['$scope', function($scope) {
  //.controller('TodoListController', function () {

      var todoList = this;


      $.get("/Jugadores/FindAllJugadores/", function (data) {
          alert(JSON.stringify(data));
          todoList.todos = (JSON.stringify(data));
      });

      /*
      todoList.todos = [
        { text: 'learn angular', done: true },
        { text: 'build an angular app', done: false }];*/

      todoList.addTodo = function () {
          todoList.todos.push({ text: todoList.todoText, done: false });
          todoList.todoText = '';
      };

      todoList.remaining = function () {
          var count = 0;
          angular.forEach(todoList.todos, function (todo) {
              count += todo.done ? 0 : 1;
          });
          return count;
      };

      todoList.archive = function () {
          var oldTodos = todoList.todos;
          todoList.todos = [];
          angular.forEach(oldTodos, function (todo) {
              if (!todo.done) todoList.todos.push(todo);
          });
      };
  }]);