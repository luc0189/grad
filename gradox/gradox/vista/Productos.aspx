<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="gradox.vista.Productos" %>
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
                        <li class="breadcrumb-item">Parametros de servicio</li>
                        <li class="breadcrumb-item active"><a href="#">Gestion de productos</a></li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-dark">
                        <div class="card-header">
                            <strong>Gestion de Productos</strong>
                        </div>
                        <div class="card-body">
                            <div class="row">

                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-header d-flex p-0">
                                            <h3 class="card-title p-3"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Productos</font></font></h3>
                                            <ul class="nav nav-pills ml-auto p-2">
                                                <li class="nav-item"><a class="nav-link active show" href="#tab_1" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Datos Principales</font></font></a></li>
                                                <li class="nav-item"><a class="nav-link" href="#tab_2" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Presentacion</font></font></a></li>
                                                <li class="nav-item"><a class="nav-link" href="#tab_3" data-toggle="tab"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Compras</font></font></a></li>
                                            </ul>
                                        </div>
                                        <!-- /.card-header -->
                                        <div class="card-body">

                                            <div class="tab-content">

                                                <div class="tab-pane active show" id="tab_1">

                                                    <div class="row">

                                                        <div class="col-md-6">
                                                            <div class="card">
                                                                <div class="card-header">
                                                                    <div class="input-group mb-3">
                                                                        <input type="text" id="txtbuscador" runat="server" class="form-control">
                                                                        <span class="input-group-append">
                                                                            <asp:LinkButton ID="btnbuscar" runat="server" OnClick="Buscaproducto" Text="Volver" class="btn btn-info btn-flat">
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

                                                        </div>
                                                        <div class="col-md-6">
                                                            <div class="card">
                                                                <div class="card-header">
                                                                    <strong>Nuevo Producto</strong>
                                                                    <div class="card-tools">
                                                                        <label runat="server" id="TxtIdproducto"></label>
                                                                    </div>
                                                                </div>
                                                                <div class="card-body">
                                                                    <div class="form-group">

                                                                        <div class="input-group">
                                                                            <div class="input-group-prepend">
                                                                                <span class="input-group-text">Nombre</span>
                                                                            </div>
                                                                            <input type="text" required="required" placeholder="Nombre" id="txtnombreproducto" runat="server" class="form-control" />
                                                                        </div>

                                                                    </div>
                                                                    <div class="form-group">
                                                                        <div class="input-group form-control ">
                                                                            <label for="selectCategoria">
                                                                                Categoria:  
                                                                            </label>
                                                                            <select required="required" runat="server" id="selectCategoria" class="js-example-basic-single form-control" style="width: 100%">
                                                                            </select>
                                                                        </div>
                                                                        <!-- /.input group -->
                                                                    </div>
                                                                    <div class="form-group ">
                                                                        <div class="input-group form-control ">
                                                                            <label for="selectImpuesto">
                                                                                Categoria:  
                                                                            </label>
                                                                            <select required="required" runat="server" id="selectImpuesto" style="width: 100%;">
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="card-footer">
                                                                    <div class="btn-group">
                                                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="creaProducto" Text="Volver" class="btn btn-app">
                                                                    <i aria-hidden="true"  class="fa fa-save"></i>Guardar
                                                                        </asp:LinkButton>

                                                                    </div>
                                                                </div>
                                                            </div>




                                                        </div>

                                                    </div>


                                                </div>
                                                <!-- /.tab-pane -->
                                                <div class="tab-pane" id="tab_2">
                                                    <div class="row">
                                                        <div class="col-md-8">
                                                            <div class="card">
                                                                <div class="card-body">
                                                                    <div class="table-responsive">
                                                                        <asp:GridView ID="GridViewPresentaciones" runat="server" GridLines="None" class="display compact"
                                                                            CssClass="gvuser table table-striped table-bordered text-sm"
                                                                            CellSpacing="0" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                                                        </asp:GridView>
                                                                    </div>
                                                                </div>


                                                            </div>
                                                        </div>
                                                        <div class="col-md-4">
                                                            <div class="card">
                                                                <div class="card-header">
                                                                    <strong>Gestion</strong>
                                                                </div>
                                                                <div class="card-body">
                                                                    <a href="#productModal" data-toggle="modal" class="btn btn-outline-primary btn-lg" tabindex="-1"><span><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Añadir Presentacion</font></font></span></a>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>

                                                </div>
                                                <!-- /.tab-pane -->
                                                <div class="tab-pane" id="tab_3">
                                                    <div class="row">
                                                        <div class="col-md-12">
                                                            <div class="card">
                                                                <div class="card-header">
                                                                    <strong>Ultimas Compras</strong>
                                                                </div>
                                                                <div class="table-responsive">
                                                                    <asp:GridView ID="GridViewcompras" runat="server" GridLines="None" class="display "
                                                                        CssClass=" gvuser table table-hover table-responsive text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                                                    </asp:GridView>
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

                        </div>

                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="card">
                    <div class="card-header">
                        <strong>Listar Todos</strong>
                        <div class="card-tools">
                            <asp:LinkButton ID="btnlistatodos" runat="server" OnClick="listaproductos" Text="Volver" class="btn btn-outline-primary ">
                                                                    <i aria-hidden="true"  class="fa fa-search"></i> Listar
                            </asp:LinkButton>
                        </div>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            <asp:GridView ID="GridViewexportar" runat="server" GridLines="None" class="display compact"
                                CssClass="gvuser table table-striped table-bordered text-sm"
                                CellSpacing="0" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                            </asp:GridView>
                        </div>
                    </div>

                </div>
            </div>


        </div>

        <div class="modal fade" id="productModal" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header modal-header-lg dark bg-dark">
                        <div class="bg-image">
                            <img src="assets/img/photos/modal-add.jpg" alt="">
                        </div>
                        <h4 class="modal-title">Nueva Presentacion</h4>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><i class="ti-close"></i></button>
                    </div>
                    <div class="modal-product-details">
                        <div class="row align-items-center">
                            <div class="col-9">

                                <div class="form-group">
                                    <div class="input-group <%--input-group-sm mb-3--%>">
                                        <div class="input-group-prepend">
                                            <span class="input-group-text"><i class="fa fa-id-card-o"></i></span>
                                        </div>
                                        <input type="text" id="txtnombreP" runat="server" aria-label="Small" placeholder="Nombre de la Presentacion" class="form-control" />
                                    </div>
                                </div>
                                <%--nombre--%>
                            </div>
                            <div class="col-3 text-lg text-right"></div>
                        </div>
                    </div>
                    <div class="modal-body panel-details-container">
                        <!-- Panel Details / Size -->
                        <div class="panel-details">
                            <h5 class="panel-details-title">
                                <label class="custom-control custom-radio">
                                    <input name="radio_title_size" type="radio" class="custom-control-input">
                                    <span class="custom-control-indicator"></span>
                                </label>
                                <a href="#panelDetailsSize" data-toggle="collapse">Descripcion General</a>
                            </h5>
                            <div id="panelDetailsSize" class="collapse show">
                                <div class="panel-details-content">

                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Descripcion</span>
                                            </div>
                                            <input type="text" id="txtdescripcionp" runat="server" placeholder="Descripcion" class="form-control" />
                                        </div>
                                    </div>
                                    <%--descripcion--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Ubicacion</span>
                                            </div>
                                            <input type="text" id="txtubicacion" runat="server" placeholder="Ubicacion" class="form-control" />
                                        </div>
                                    </div>
                                    <%--ubicacion--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Complejidad</span>
                                            </div>
                                            <select runat="server" id="selectcomplejidad" class="select2-container ">
                                                <option value="0">0</option>
                                                <option value="1">1</option>
                                                <option value="2">2</option>
                                                <option value="3">3</option>
                                                <option value="4">4</option>
                                                <option value="5">5</option>

                                            </select>


                                        </div>
                                    </div>
                                    <%--complejidad--%>
                                </div>
                            </div>
                        </div>
                        <!-- Panel Details / Additions -->
                        <div class="panel-details">
                            <h5 class="panel-details-title">
                                <label class="custom-control custom-radio">
                                    <input name="radio_title_additions" type="radio" class="custom-control-input">
                                    <span class="custom-control-indicator"></span>
                                </label>
                                <a href="#panelDetailsAdditions" data-toggle="collapse">Detalles</a>
                            </h5>
                            <div id="panelDetailsAdditions" class="collapse">
                                <div class="panel-details-content">


                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Precio</span>
                                            </div>
                                            <input type="number" id="txtprecio" runat="server" placeholder="Precio" class="form-control" />
                                        </div>
                                    </div>
                                    <%--precio--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Cantidad</span>
                                            </div>
                                            <input type="number" id="txtcant" runat="server" placeholder="Cantidad" class="form-control" />
                                        </div>
                                    </div>
                                    <%--cantidad--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Unidad de Medida</span>
                                            </div>
                                            <select runat="server" id="selectUnidadM" />
                                        </div>
                                    </div>
                                    <%--unidad de medida--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Marca</span>
                                            </div>
                                            <select runat="server" id="selectMarca" />
                                        </div>
                                    </div>
                                    <%--Marca--%>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text">Estado</span>
                                            </div>
                                            <select runat="server" id="Selectestado">
                                                <option value="1">Activo</option>
                                                <option value="2">Inactivo</option>
                                            </select>
                                        </div>
                                    </div>
                                    <%--Estado--%>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Panel Details / Other -->
                    <asp:LinkButton ID="btnguardapres" runat="server" OnClick="creaPresentacionProducto" Text="Volver" class="btn btn btn-secondary btn-block btn-lg">
                                    <span aria-hidden="true"  class="fa fa-arrow-left">Guardar Presentacion</span>
                    </asp:LinkButton>

                </div>
                <%-- <input type="submit" onserverclick="creaPresentacionProducto" runat="server" id="guardapresentacion" class="btn btn btn-secondary btn-block btn-lg" name="name" value="" />--%>
            </div>
        </div>
    </form>


</asp:Content>
