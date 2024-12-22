app.controller("BlogWebController", function ($scope, BlogWebService) {

    $scope.loadPostFunc = function () {
        var getData = BlogWebService.loadPostFunc();
        getData.then(function (ReturnedData) {
            $scope.postsData = ReturnedData.data;
            $(document).ready(function () {
                $('#myTable').DataTable();
            });
        });
    }

    $scope.fetchFunc = function () {
        var getCredentials = sessionStorage.getItem("credentials");
        if (getCredentials) {
            userInformation = JSON.parse(getCredentials);
        }
    };

    $scope.loadChartFunc2 = function () {
        var getData = BlogWebService.loadChartServiceFunc();

        getData.then(function (ReturnedData) {
            var sampleData = ReturnedData.data;
        })
    };

    /*$scope.loadChartFunc = function () {
        $scope.labels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
        $scope.series = ['Series A', 'Series B'];

        $scope.data = [
            [65, 59, 80, 81, 56, 55, 40],
            [28, 48, 40, 19, 86, 27, 90]
        ];
    }*/

});