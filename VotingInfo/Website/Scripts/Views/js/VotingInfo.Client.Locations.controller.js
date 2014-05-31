function VotingInfoClientLocationsController($window, $scope, $location, $jQuery) {
    //Inherit ViewModel
    $scope.vm = new VotingInfoClientLocationsViewModel($jQuery, $window.dal);

    $scope.ErrorMessage = null;

    //Events
    $scope.$done = function () { if (!$scope.$$phase) $scope.$apply(); };
    $scope.vm.OnSelectAllFail = function() {
        $scope.ErrorMessage = "Failed to select all.";
        $scope.$done();
    };
    $scope.vm.OnSelectAllSuccess = $scope.$done;

    //Fns

    //Initialize
    $scope.vm.SelectAll();
}