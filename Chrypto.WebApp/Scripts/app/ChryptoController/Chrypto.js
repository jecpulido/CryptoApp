app.controller("ChryptoController", function ($scope, $http, $interval) {


    $scope.enable = true;
    $scope.symbol = "";
    $scope.id = 0;
    $scope.amount = 1;
    $scope.strSymbols = "";

    CurrencyExhange = function (amount) {       
        $scope.loading = true;
        $scope.exchanges = null;
        $http.get("/Chrypto/GetExchangeCurrency?amount=" + amount + "&id=" + $scope.id + "&symbols=" + $scope.strSymbols).then(function (d) {
            $scope.exchanges = d.data;
            $scope.loading = false;
            //console.log(d.data);
        }, function (error) {
            alert('Failed');
            $scope.loading = false;
        });
    };


    $scope.selectCurrency = function (obj) {
        $scope.enable = false;
        $scope.symbol = "Cryptomoneda: " + obj.Symbol;
        //console.log(obj);
        $scope.id = obj.Id;
        CurrencyExhange($scope.amount);
    };

    $scope.updateCurrency = function (amount) {
        //console.log(amount);
        $scope.enable = false;
        $scope.amount = amount;
        CurrencyExhange($scope.amount);
    };


    //Metodo obtiene informacion de las cryptomonedas
    getDataCrypto = function () {
        $http.get("/Chrypto/Get_data").then(function (d) {
            //console.log(d.data);
            $scope.strSymbols = "";
            $scope.record = d.data;
            angular.forEach($scope.record, function (currency) {
                $scope.strSymbols += currency.Symbol +" ";
            });
        }, function (error) {
            alert('Failed');
        });
    }

    getDataCrypto();
   
    //Actualiza la tabla cada 10 segundos
    UpdateTable = function () {
        $interval(function () {
            getDataCrypto();
        }, 10000);
    };

    UpdateTable();

});

