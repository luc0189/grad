<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="gradox.vista.Roles" %>
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
                        <li class="breadcrumb-item active"><a href="#">Gestion de Ingreso</a></li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <div class="container-fluid">
        <form runat="server">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-dark">
                         <label runat="server" id="Txtid" visible="false"></label>
                        <div class="card-header d-flex p-0">
                            <h3 class="card-title p-3"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Gestion de Ingreso</font></font></h3>
                            <ul class="nav nav-pills ml-auto p-2">
                                <li class="nav-item"><a class="nav-link active show" href="#tab_1" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Usuario</font></font></a></li>
                                <li class="nav-item"><a class="nav-link" href="#tab_2" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Roles</font></font></a></li>
                                <li class="nav-item"><a class="nav-link" href="#tab_3" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Parametros</font></font></a></li>
                                
                            </ul>
                        </div>
                        <div class="card-body">
                            <div class="tab-content">
                                <div class="tab-pane active show" id="tab_1">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-header">
                                                    <div class="input-group mb-2">
                                                        <input type="text" id="Text2" runat="server" class="form-control">
                                                        <span class="input-group-append">
                                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnbuscarp_Click" Text="Volver" class="btn btn-info btn-flat">
                                                             <span aria-hidden="true"  class="fa fa-search"></span>
                                                            </asp:LinkButton>
                                                        </span>
                                                    </div>
                                                </div>
                                                <div class="card-body">
                                                    <div class="table-responsive">
                                                        <asp:GridView ID="GridViewusuarios" runat="server" OnSelectedIndexChanged="GridViewbuscador_SelectedIndexChanged" GridLines="None" class="display compact"
                                                            CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                            <Columns>
                                                                <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                                            </Columns>

                                                        </asp:GridView>
                                                    </div>
                                                </div>
                                            </div>
                                            <%--aqui esta el buscador--%>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-header d-flex p-4">
                                                    <strong>Nuevo Usuario</strong>
                                                    <div class="card-tools">
                                                       <div class="form-group-lg">
                                                             <div class="radio">
                                                                <div class="input-group">
                                                                    <label>
                                                                    <input type="radio" name="optionsRadios" id="options1" value="1" checked=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                                                          activo
                                                                        </font></font></label>
                                                                </div>
                                                                
                                                            </div>
                                                            <div class="radio">
                                                                <label>
                                                                    <input type="radio" name="optionsRadios" id="options2" value="0"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                      Inactivo
                    </font></font></label>
                                                            </div>
                                                        </div>
                                                        
                                                    </div>
                                                </div>
                                                <div class="card-body">
                                                    <div class="form-group">

                                                                        <div class="input-group">
                                                                            <label for="selectpersona">
                                                                                Personas sin Usuario:  
                                                                            </label>
                                                                            <select required="required" runat="server" id="selectpersona" class="js-example-basic-single form-control" style="width: 100%">
                                                                            </select>

                                                                    </div>
                                                    
                                                   
                                                </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text"><i class="fa fa-user"></i></span>
                                                            </div>
                                                            <input type="text" required="required" id="Text3" runat="server" class="form-control" placeholder="Nombre Usuario">
                                                        </div>
                                                        <!-- /.input group -->
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text"><i class="fa fa-lock"></i></span>
                                                            </div>
                                                            <input type="password" required="required" id="Text4" runat="server" class="form-control" placeholder="Contraseña">
                                                        </div>
                                                        <!-- /.input group -->
                                                    </div>
                                                    
                                                </div>
                                                <div class="card-footer">
                                                    <div class="btn-group">
                                                        <%--btn btn-outline-primary btn-lg--%>
                                                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="btnGuarda_Click" Text="guarda" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-save"></i>Guardar
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="btnUpdate_Click" Text="Modifica" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-pencil"></i>Actualizar
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="btnElimina_Click" Text="Borra" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-trash-o"></i>Eliminar
                                                        </asp:LinkButton>

                                                    </div>
                                                </div>
                                            </div>




                                        </div>

                                    </div>


                                </div>
                                <div class="tab-pane " id="tab_2">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-header">
                                                    <div class="input-group mb-2">
                                                        <input type="text" id="txtbuscador" runat="server" class="form-control">
                                                        <span class="input-group-append">
                                                            <asp:LinkButton ID="btnbuscarp" runat="server" OnClick="btnbuscarp_Click" Text="Volver" class="btn btn-info btn-flat">
                                                             <span aria-hidden="true"  class="fa fa-search"></span>
                                                            </asp:LinkButton>
                                                        </span>
                                                    </div>
                                                </div>
                                                <div class="card-body">
                                                    <div class="table-responsive">
                                                        <asp:GridView ID="GridViewbuscador" runat="server" OnSelectedIndexChanged="GridViewbuscador_SelectedIndexChanged" GridLines="None" class="display compact"
                                                            CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                            <Columns>
                                                                <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                                            </Columns>

                                                        </asp:GridView>
                                                    </div>
                                                </div>
                                            </div>
                                            <%--aqui esta el buscador--%>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-header">
                                                    <strong>Nuevo Rol</strong>
                                                    <div class="card-tools">
                                                        <label runat="server" id="TxtIdproducto"></label>
                                                    </div>
                                                </div>
                                                <div class="card-body">
                                                    <div class="form-group">
                                                        <div class="input-group">
                                                            <div class="input-group-prepend">
                                                                <span class="input-group-text"><i class="fa fa-user"></i></span>
                                                            </div>
                                                            <input type="text" required="required" id="txtnombre" runat="server" class="form-control" placeholder="Nombre del Rol">
                                                        </div>
                                                        <!-- /.input group -->
                                                    </div>
                                                </div>
                                                <div class="card-footer">
                                                    <div class="btn-group">
                                                        <%--btn btn-outline-primary btn-lg--%>
                                                        <asp:LinkButton ID="btnGuarda" runat="server" OnClick="btnGuarda_Click" Text="guarda" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-save"></i>Guardar
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Modifica" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-pencil"></i>Actualizar
                                                        </asp:LinkButton>
                                                        <asp:LinkButton ID="btnElimina" runat="server" OnClick="btnElimina_Click" Text="Borra" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-trash-o"></i>Eliminar
                                                        </asp:LinkButton>

                                                    </div>
                                                </div>
                                            </div>




                                        </div>

                                    </div>


                                </div>
                                <!-- /.tab-pane -->
                                <div class="tab-pane" id="tab_3">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-body">
                                                    <div class="table-responsive">
                                                        <asp:GridView ID="GridViewparametros" runat="server" GridLines="None" class="display compact"
                                                            CssClass="gvuser table table-striped table-bordered text-sm"
                                                            CellSpacing="0" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                                        </asp:GridView>
                                                    </div>
                                                </div>


                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="card">
                                                <div class="card-header d-flex p-4">
                                                    <strong>Gestion</strong>
                                                    <div class="card-tools">
                                                        <div class="form-group-lg">
                                                             <div class="radio">
                                                                <div class="input-group">
                                                                    <label>
                                                                    <input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                                                          activo
                                                                        </font></font></label>
                                                                </div>
                                                                
                                                            </div>
                                                            <div class="radio">
                                                                <label>
                                                                    <input type="radio" name="optionsRadios" id="optionsRadios2" value="option2"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                      Inactivo
                    </font></font></label>
                                                            </div>
                                                        </div>
                                                           
                                                        
                                                    </div>
                                                </div>
                                                <div class="card-body">
                                                    <div class="row">
                                                        <div class="col-xs-6">
                                                        <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Desde</span>
                                                                            </div>
                                                                            <input type="date" required="required" placeholder="Nombre" id="txtnombreproducto" runat="server"  />
                                                                        </div>

                                                                    </div>
                                                    </div>
                                                    <div class="col-xs-6">
                                                        <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Hasta</span>
                                                                            </div>
                                                                            <input type="date" required="required" placeholder="Nombre" id="Text1" runat="server"  />
                                                                        </div>

                                                                    </div>
                                                    </div>
                                                    </div>
                                                    <div class="form-group">

                                                                        <div class="input-group">
                                                                            <label for="selectUsuario">
                                                                                Usuario:  
                                                                            </label>
                                                                            <select required="required" runat="server" id="selectUsuario" class="js-example-basic-single form-control" style="width: 100%">
                                                                            </select>

                                                                    </div>
                                                    
                                                   
                                                </div>
                                                    <div class="form-group">

                                                                        <div class="input-group">
                                                                            <label for="selectRol">
                                                                                Rol:  
                                                                            </label>
                                                                            <select required="required" runat="server" id="selectRol" class="js-example-basic-single form-control" style="width: 100%">
                                                                            </select>

                                                                    </div>
                                                    
                                                   
                                                </div>
                                                </div>
                                                <div class=" card-footer">
                                                    <div class="btn-group">
                                                                        <asp:LinkButton ID="btnaplica" runat="server"  Text="Volver" class="btn btn-app btn-outline-primary">
                                                                    <i aria-hidden="true"  class="fa fa-check-square-o"></i>Aplicar Cambios
                                                                        </asp:LinkButton>

                                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <!-- /.tab-pane -->
                                

                            </div>




                        </div>

                    </div>

                </div>
            </div>

        </form>
    </div>
</asp:Content>
