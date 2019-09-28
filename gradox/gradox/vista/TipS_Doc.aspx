<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="TipS_Doc.aspx.cs" Inherits="gradox.vista.TipS_Doc" %>
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
                        <li class="breadcrumb-item">Administracion</li>
                        <li class="breadcrumb-item">Documentos</li>
                        <li class="breadcrumb-item active"><a href="#">Tipos de Documentos</a></li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <form action=" " runat="server" method="post">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-dark">
                        <div class="card-header">
                            <strong>Tipos de Documentos</strong>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="card">
                                        <div class="card-header">
                                            <div class="input-group mb-2">
                                                <input type="text" id="txtbuscador" runat="server" class="form-control">
                                                <span class="input-group-append">
                                                    <asp:linkbutton id="btnbuscarp" runat="server" OnClick="BuscaTipodoc" text="Volver" class="btn btn-info btn-flat">
                                                             <span aria-hidden="true"  class="fa fa-search"></span>
                                                                            </asp:linkbutton>
                                                </span>
                                            </div>
                                        </div>
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                                        <asp:GridView ID="GridViewbuscador" runat="server"  OnSelectedIndexChanged="GridViewbuscador_SelectedIndexChanged" GridLines="None" class="display compact"
                                                                            CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                                            <Columns>
                                                                                <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                                                            </Columns>

                                                                        </asp:GridView>
                                                                    </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="card">
                                        <div class="card-header">
                                            <strong>Gestion de documentos</strong>
                                            <div class="card-tools">
                                                <b>
                                                    <label id="txtid" runat="server"></label>
                                                </b>
                                            </div>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <select required="required" runat="server" id="selecttipodoc" class="js-example-basic-single form-control" style="width: 100%">
                                                      
                                                    </select>
                                                </div>
                                                <!-- /.input group -->
                                            </div>
                                            <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Codigo</span>
                                                                            </div>
                                                                            <input type="text" required="required" placeholder="Codigo" id="txtcodigodocu" runat="server" class="form-control" />
                                                                        </div>

                                                                    </div>
                                            <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Nombre</span>
                                                                            </div>
                                                                            <input type="text" required="required" placeholder="Nombre" id="txtNombreDocu" runat="server" class="form-control" />
                                                                        </div>

                                                                    </div>
                                            <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Consecutivo</span>
                                                                            </div>
                                                                            <input type="Number" required="required" placeholder="Consecutivo" id="txtconsecutivo" runat="server" class="form-control" />
                                                                        </div>

                                                                    </div>
                                        </div>
                                        <div class="card-footer">
                                             <div class="btn-group">
                                                                        <asp:LinkButton ID="btnguardar" OnClick="creatipodoc" runat="server"  Text="Volver" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-save"></i>Guardar
                                                                        </asp:LinkButton>
                                                 <asp:LinkButton ID="btnupdate" runat="server" OnClick="updatetipodoc" Text="Volver" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-pencil"></i>Actualizar
                                                                        </asp:LinkButton>
                                                 <asp:LinkButton ID="btnelimina" runat="server" OnClick="btnelimina_Click" Text="Volver" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-trash-o"></i>Elimina
                                                                        </asp:LinkButton>
                                                                    </div>
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
