(function (app) {
    'use strict';

    app.controller('projectsRegCtrl', projectsRegCtrl);

    projectsRegCtrl.$inject = ['$scope', '$location', '$rootScope', 'apiService'];

    function projectsRegCtrl($scope, $location, $rootScope, apiService) {

        $scope.newProject = {};

        $scope.Register = Register;

        $scope.openDatePicker = openDatePicker;
        $scope.dateOptions = {
            formatYear: 'yy',
            startingDay: 1
        };
        $scope.datepicker = {};

        $scope.submission = {
            successMessages: ['Successfull submission will appear here.'],
            errorMessages: ['Submission errors will appear here.']
        };

        function Register() {
            apiService.post('/api/projects/register', $scope.newProject,
           registerProjectSucceded,
           registerProjectFailed);
        }

        function registerProjectSucceded(response) {
            $scope.submission.errorMessages = ['Submission errors will appear here.'];
            console.log(response);
            var projectRegistered = response.data;
            $scope.submission.successMessages = [];
            $scope.submission.successMessages.push($scope.newProject.ProjectName + ' has been successfully created');
            $scope.newProject = {};
            //Edited Code
            $location.path('/projects');
        }

        function registerProjectFailed(response) {
            console.log(response);
            if (response.status == '400')
                $scope.submission.errorMessages = response.data;
            else
                $scope.submission.errorMessages = response.statusText;
        }

        function openDatePicker($event, opened) {
            $event.preventDefault();
            $event.stopPropagation();

            $scope[opened] = true;
        };
    }

})(angular.module('HitachiPMS'));