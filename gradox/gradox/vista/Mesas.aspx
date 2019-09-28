<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Mesas.aspx.cs" Inherits="gradox.vista.Mesas" %>
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
                        <li class="breadcrumb-item active"><a href="#">Mesas</a></li>
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
                            <strong>Mesas</strong>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    
                                            <div class="card">
                            <div class="table-responsive">
                                <asp:GridView ID="GridViewMesas" runat="server" GridLines="None" OnSelectedIndexChanged="GridViewMesas_SelectedIndexChanged" class="display compact"
                                    CssClass=" table table-striped table-bordered text-sm"
                                    CellSpacing="0" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                                     </div>
                                        
                                </div>
                                <div class="col-md-6">
                                    <div class="card card-dark">
                                        <div class="card-header">
                                            <strong>Gestion Mesas</strong>
                                        </div>
                                        <div class="card-body">
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fa fa-home"></i></span>
                                                    </div>
                                                    <input type="text" id="txtdescripcion" runat="server" required="required" class="form-control" placeholder="Descripcion">
                                                </div>
                                                <!-- /.input group -->
                                            </div>
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fa fa-slack"></i></span>
                                                    </div>
                                                    <input type="number" required="required" id="txtnumeropuestos" runat="server" placeholder="Numero de puestos" class="form-control">
                                                </div>
                                            </div>
                                            <button type="submit" runat="server" id="guardar" onserverclick="guardar_ServerClick" class="btn btn-primary"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Guardar</font></font></button>
                                            <button type="submit" runat="server" id="Modificar" onserverclick="Modificar_ServerClick" class="btn btn-primary"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Modificar</font></font></button>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
                        <div class="card-footer">
                        </div>
                    </div>
                </div>
                
            </div>
        </div>
    </form>
    <div class="modal fade" id="productModal" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header modal-header-lg dark bg-dark">
                    <div class="bg-image">
                        <img src="assets/img/photos/modal-add.jpg" alt="">
                    </div>
                    <h4 class="modal-title">Specify your dish</h4>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><i class="ti-close"></i></button>
                </div>
                <div class="modal-product-details">
                    <div class="row align-items-center">
                        <div class="col-9">
                            <h6 class="mb-0">Boscaiola Pasta</h6>
                            <span class="text-muted">Pasta, Cheese, Tomatoes, Olives</span>
                        </div>
                        <div class="col-3 text-lg text-right">$9.00</div>
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
                            <a href="#panelDetailsSize" data-toggle="collapse">Size</a>
                        </h5>
                        <div id="panelDetailsSize" class="collapse show">
                            <div class="panel-details-content">
                                <div class="form-group">
                                    <label class="custom-control custom-radio">
                                        <input name="radio_size" type="radio" class="custom-control-input" checked>
                                        <span class="custom-control-indicator"></span>
                                        <span class="custom-control-description">Small - 100g ($9.99)</span>
                                    </label>
                                </div>
                                <div class="form-group">
                                    <label class="custom-control custom-radio">
                                        <input name="radio_size" type="radio" class="custom-control-input">
                                        <span class="custom-control-indicator"></span>
                                        <span class="custom-control-description">Medium - 200g ($14.99)</span>
                                    </label>
                                </div>
                                <div class="form-group">
                                    <label class="custom-control custom-radio">
                                        <input name="radio_size" type="radio" class="custom-control-input">
                                        <span class="custom-control-indicator"></span>
                                        <span class="custom-control-description">Large - 350g ($21.99)</span>
                                    </label>
                                </div>
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
                            <a href="#panelDetailsAdditions" data-toggle="collapse">Additions</a>
                        </h5>
                        <div id="panelDetailsAdditions" class="collapse">
                            <div class="panel-details-content">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="custom-control custom-checkbox">
                                                <input type="checkbox" class="custom-control-input">
                                                <span class="custom-control-indicator"></span>
                                                <span class="custom-control-description">Tomato ($1.29)</span>
                                            </label>
                                        </div>
                                        <div class="form-group">
                                            <label class="custom-control custom-checkbox">
                                                <input type="checkbox" class="custom-control-input">
                                                <span class="custom-control-indicator"></span>
                                                <span class="custom-control-description">Ham ($1.29)</span>
                                            </label>
                                        </div>
                                        <div class="form-group">
                                            <label class="custom-control custom-checkbox">
                                                <input type="checkbox" class="custom-control-input">
                                                <span class="custom-control-indicator"></span>
                                                <span class="custom-control-description">Chicken ($1.29)</span>
                                            </label>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label class="custom-control custom-checkbox">
                                                <input type="checkbox" class="custom-control-input">
                                                <span class="custom-control-indicator"></span>
                                                <span class="custom-control-description">Cheese($1.29)</span>
                                            </label>
                                        </div>
                                        <div class="form-group">
                                            <label class="custom-control custom-checkbox">
                                                <input type="checkbox" class="custom-control-input">
                                                <span class="custom-control-indicator"></span>
                                                <span class="custom-control-description">Bacon ($1.29)</span>
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Panel Details / Other -->
                    <div class="panel-details">
                        <h5 class="panel-details-title">
                            <label class="custom-control custom-radio">
                                <input name="radio_title_other" type="radio" class="custom-control-input">
                                <span class="custom-control-indicator"></span>
                            </label>
                            <a href="#panelDetailsOther" data-toggle="collapse">Other</a>
                        </h5>
                        <div id="panelDetailsOther" class="collapse">
                            <textarea cols="30" rows="4" class="form-control" placeholder="Put this any other informations..."></textarea>
                        </div>
                    </div>
                </div>
                <button type="button" class="modal-btn btn btn-secondary btn-block btn-lg" data-dismiss="modal"><span>Add to Cart</span></button>
            </div>
        </div>
    </div>
</asp:Content>
