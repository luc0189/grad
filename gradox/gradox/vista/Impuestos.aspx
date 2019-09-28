<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Impuestos.aspx.cs" Inherits="gradox.vista.Impuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark"><strong>Plataforma</strong></h1>
                </div>
                <!-- /.col -->
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <li class="breadcrumb-item"><a href="Menuadmon.aspx">Inicio</a></li>
                        <li class="breadcrumb-item">Menus Administracion</li>
                        <li class="breadcrumb-item active"><a href="#">Impuestos</a></li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <form action=" " method="post" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-dark">
                        <div class="card-header">
                            <strong>Impuestos</strong>
                        </div>
                        <div class="card-body">
                            <div class="row">

                                <div class="col-md-4">
                                    <div class="card">
                                        <div class="table-responsive">
                                            <asp:GridView ID="GridViewNovedades" runat="server" GridLines="None" class="display "
                                                CssClass=" table table-hover table-responsive text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                                <Columns>
                                                    <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                                    <asp:CommandField ShowDeleteButton="True" ButtonType="Image" SelectImageUrl="../dist/img/delete2.png" />
                                                   
                                                </Columns>
                                            </asp:GridView>
                                        </div>
                                    </div>


                                </div>
                                <div class="col-md-8">

                                    <div class="card">
                                        <div class="card-header">
                                            <strong>Gestion</strong>
                                            <div class="card-tools">
                                                <input type="checkbox" id="inputcheck_estado"  runat="server" placeholder="Impuesto Activo" class="icheckbox_minimal" />
                                                <label>Activo </label>
                                            </div>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <div class="input-group <%--input-group-sm mb-3--%>">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fa fa-id-card-o"></i></span>
                                                    </div>
                                                    <input type="text" id="txtnombreP" required="required" runat="server" aria-label="Small" placeholder="Nombre del Impuesto" class="form-control" />
                                                </div>
                                            </div>
                                            <%--nombre--%>
                                            <div class="form-group">
                                                <div class="input-group ">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fa fa-id-card-o"></i></span>
                                                    </div>
                                                    <input type="number" id="txtvalor" runat="server" required="required" placeholder="Valor" class="form-control" />
                                                </div>
                                            </div>
                                            <%--Valor--%>
                                            
                                        </div>
                                        <div class="card-footer">
                                            <asp:Button ID="btnguadar" runat="server" Text="Guardar" OnClick="creaImpuesto" class="btn btn-outline-primary btn-lg"/>
                                            
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </form>
</asp:Content>
