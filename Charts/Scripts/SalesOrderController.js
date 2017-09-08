
var mensajeConclusion = "El mes de {0} cuenta con la mayor cantidad de ventas correspondientes a {1}" +
    ", por el contrario, el mes {2} presenta la menor cantidad de ventas correspondientes a {3}.";

if (!String.prototype.format) {
    String.prototype.format = function () {
        var args = arguments;
        return this.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined'
                ? args[number]
                : match
                ;
        });
    };
}

function mostrar() {
    var e = document.getElementById("selectAnio");
    var filtroAnio = e.options[e.selectedIndex].value;
    if (filtroAnio != 0) {
        $.getJSON("Api/SalesOrder/getTotalVentas?year=" + filtroAnio,
            function (data) {
                if (data.meses != null) {
                    var color = Chart.helpers.color;
                    var barChartData = {
                        labels: data.meses,
                        datasets: [{
                            label: 'Total de ventas',
                            backgroundColor: color(window.chartColors.green).alpha(0.5).rgbString(),
                            borderColor: window.chartColors.green,
                            borderWidth: 1,
                            data: data.totalVentas
                        }]
                    };

                    var ctx = document.getElementById("canvasBarras").getContext("2d");

                    var dvCanvas = document.getElementById("dvCanvas");
                    dvCanvas.classList.remove("oculto");

                    lblConcluir.textContent = mensajeConclusion.format(data.MaximoMes, data.MaximoVentas, data.MinimoMes, data.MinimoVentas);

                    if (window.myBar != undefined)
                        window.myBar.destroy();

                    window.myBar = new Chart(ctx, {
                        type: 'bar',
                        data: barChartData,
                        options: {
                            responsive: true,
                            legend: {
                                position: 'top',
                            },
                            title: {
                                display: true,
                                text: ''
                            }
                        }
                    });
                }
                else {
                    alert("No se encontraron datos para el año seleccionado")
                }
            });
    }
    else {
        alert("Seleccione un año");
    }
}