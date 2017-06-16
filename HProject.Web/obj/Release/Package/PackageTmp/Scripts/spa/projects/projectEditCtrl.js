(function (app) {
    'use strict';

    app.controller('projectEditCtrl', projectEditCtrl);

    projectEditCtrl.$inject = ['$scope', '$modalInstance', '$timeout', 'apiService', 'notificationService'];

    function projectEditCtrl($scope, $modalInstance, $timeout, apiService, notificationService) {

        $scope.cancelEdit = cancelEdit;
        $scope.updateProject = updateProject;

        $scope.openDatePicker = openDatePicker;
        $scope.dateOptions = {
            formatYear: 'yy',
            startingDay: 1
        };
        $scope.datepicker = {};

        function updateProject() {
            console.log($scope.EditedProject);
            apiService.post('/api/projects/update/', $scope.EditedProject,
            updateProjectCompleted,
            updateProjectLoadFailed);
        }

        function updateProjectCompleted(response) {
            notificationService.displaySuccess($scope.EditedProject.ProjectName + ' has been updated');
            $scope.EditedProject = {};
            $modalInstance.dismiss();
        }

        function updateProjectLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        function cancelEdit() {
            $scope.isEnabled = false;
            $modalInstance.dismiss();
        }

        function openDatePicker($event, opened) {
            $event.preventDefault();
            $event.stopPropagation();
            $timeout(function () {
                //$scope.datepicker.opened = true;
                $scope[opened] = true;
            });

            $timeout(function () {
                $('ul[datepicker-popup-wrap]').css('z-index', '10000');
            }, 100);


        };

       

    }

})(angular.module('HitachiPMS'));