(function (app) {
    'use strict';

    app.controller('projectsCtrl', projectsCtrl);

    projectsCtrl.$inject = ['$scope', '$modal', 'apiService', 'notificationService'];

    function projectsCtrl($scope, $modal, apiService, notificationService) {

        $scope.pageClass = 'page-customers';
        $scope.loadingProjects = true;
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.Projects = [];

        $scope.search = search;
        $scope.clearSearch = clearSearch;

        $scope.search = search;
        $scope.clearSearch = clearSearch;
        $scope.openEditDialog = openEditDialog;

        function search(page) {
            page = page || 0;

            $scope.loadingProjects = true;

            var config = {
                params: {
                    page: page,
                    pageSize: 4,
                    filter: $scope.filterProjects
                }
            };

            apiService.get('/api/projects/search/', config,
            projectsLoadCompleted,
            projectsLoadFailed);
        }

        function openEditDialog(project) {
            $scope.EditedProject = project;
            $modal.open({
                templateUrl: 'scripts/spa/projects/editProjectModal.html',
                controller: 'projectEditCtrl',
                scope: $scope
            }).result.then(function ($scope) {
                clearSearch();
            }, function () {
            });
        }

        function projectsLoadCompleted(result) {
            $scope.Projects = result.data.Items;

            $scope.page = result.data.Page;
            $scope.pagesCount = result.data.TotalPages;
            $scope.totalCount = result.data.TotalCount;
            $scope.loadingProjects = false;

            if ($scope.filterProjects && $scope.filterProjects.length) {
                notificationService.displayInfo(result.data.Items.length + ' projects found');
            }

        }

        function projectsLoadFailed(response) {
            notificationService.displayError(response.data);
        }

        function clearSearch() {
            $scope.filterProjects = '';
            search();
        }

        $scope.search();
    }

})(angular.module('HitachiPMS'));