<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Charts.aspx.cs" Inherits="Charts.Charts" %>
<asp:Content ID="ChartsHead" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="ChartsMain" ContentPlaceHolderID="MainContent" runat="server">
    <div class="bs-docs-section MainContent">
        <div class="row">
            <div class="col-lg-12">
                <div class="page-header">
                    <h1 id="typography">Graficos</h1>
                </div>
            </div>

            <div class="col-lg-12">
                <h2>Total de ventas</h2>
                <p>Total de ventas mensuales efectuadas en un año determinado.</p>

                <div class="filtroVentas">
                    <select class="form-control selectAnio" id="selectAnio">
                        <option value="0">- Seleccione año - </option>
                        <option value="2011">2011</option>
                        <option value="2012">2012</option>
                        <option value="2013">2013</option>
                        <option value="2014">2014</option>
                        <option value="2015">2015</option>
                    </select>
                    <button id="btnMostrarTotalVentas" class="btn btn-primary btnMostrar"
                        onclick="mostrar(); return false;">
                        Mostrar</button>
                </div>
                <div id="dvCanvas" class="oculto">
                    <canvas id="canvasBarras" class="canvasTotalVentas"></canvas>
                    <h2>Conclusión</h2>
                    <p>
                        <label id="lblConcluir" class="texto"></label>
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
