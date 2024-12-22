app.service("BlogWebService", function ($http) {
    this.loadPostFunc = function () {
        return $http.get("/Home/LoadPosts");
    }

    this.loadChartServiceFunc = function () {
        return $http.get("/Home/LoadPieChartData")
    }
});