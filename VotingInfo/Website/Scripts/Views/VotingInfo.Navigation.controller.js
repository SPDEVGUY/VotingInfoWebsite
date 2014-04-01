function VotingInfoNavigationController($scope, $window) {

    //init
    $scope.Title = "VotingInfo.ca";

    $scope.Items = [
        { Text: 'Home', Url: '#/', Icon: 'home', Css:"active", AuthOnly:false },
        { Text: 'Find Information', Url: '#/info', Icon: 'info-sign', Css: "", AuthOnly: false },
    ];

    $scope.IsAuthenticated = function () {
        if ($window.dal.auth === undefined) return false;
        return $window.dal.auth.IsAuthenticated;
    };
}