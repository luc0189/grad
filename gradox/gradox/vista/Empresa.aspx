<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="gradox.vista.Empresa" %>
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
                        <li class="breadcrumb-item active"><a href="#">Parametros de Empresa</a></li>
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
                            <h3 class="card-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Datos de Empresa</font></font></h3>
                        <div class="card-tools">
                            <b>
                                # <label id="txtid" runat="server"></label>
                            </b>
                        </div>
                        </div>
                        
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Datos Principales:</font></font></label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-id-card-o"></i></span>
                                            </div>
                                            <input type="text" required="required" id="txtnit" runat="server" placeholder="Nit o CC" class="form-control">
                                        </div>
                                        <!-- /.input groupsele -->
                                    </div>
                                    <!-- /.form group -->

                                    <!-- Date mm/dd/yyyy -->
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-home"></i></span>
                                            </div>
                                            <input type="text" id="txtnombre" required="required" runat="server" class="form-control" placeholder="Nombre">
                                        </div>
                                        <!-- /.input group -->
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-home"></i></span>
                                            </div>
                                            <select id="selectRegimen" runat="server" required="required" class="form-control">
                                                <option value="SIMPLIFICADO">SIMPLIFICADO</option>
                                                <option value="COMUN">COMUN</option>
                                            </select>
                                        </div>
                                        <!-- /.input group -->
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Otros Datos: </font></font></label>

                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-street-view"></i></span>
                                            </div>
                                            <input type="text" id="txtdireccion" required="required" runat="server" class="form-control" placeholder="Direccion">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-phone"></i></span>
                                            </div>
                                            <input type="text" required="required" class="form-control" id="txttelefono" runat="server" placeholder="Telefono">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-envelope"></i></span>
                                            </div>
                                            <input type="email" class="form-control" id="txtemail" runat="server" required="required" placeholder="Email">
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-header">
                                            <strong>Eslogan</strong>
                                        </div>
                                        <div class="card-body">
                                            <textarea class="form-control" id="txteslogan" runat="server" rows="3" placeholder="Eslogan ..."></textarea>
                                        </div>

                                    </div>
                                    <%-- <div class="card">
                        <a href="#productModal" data-toggle="modal" class="btn btn-outline-primary btn-lg">Otra Ventana</a>
                    </div>--%>

                                    <!-- /.card -->
                                </div>
                            </div>

                        </div>
                        <!-- /.form group -->

                        <!-- phone mask -->
                        <%--<div class="form-group">
                  <label><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Email:</font></font></label>

                  
                  <!-- /.input group -->
                </div>--%>
                        <!-- /.form group -->

                        <%-- <!-- IP mask -->
                <div class="form-group">
                  <label><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Máscara de IP:</font></font></label>

                  <div class="input-group">
                    <div class="input-group-prepend">
                      <span class="input-group-text"><i class="fa fa-laptop"></i></span>
                    </div>
                    <input type="text" class="form-control" data-inputmask="'alias': 'ip'" data-mask="">
                  </div>
                  <!-- /.input group -->
                </div>--%>
                        <!-- /.form group -->
                        <div class="card-footer">
                            <div class="btn-group">
                            <button type="submit" runat="server" id="guardar" onserverclick="guardar_ServerClick" class="btn btn-outline-primary btn-lg"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Guardar</font></font></button>
                            <asp:LinkButton ID="btnUpdate"  runat="server" OnClick="btnUpdate_Click" Text="Modifica" class="btn btn-outline-primary btn-lg">
                                                                    <i aria-hidden="true"  class="fa fa-pencil"></i>
                                         </asp:LinkButton>
                                </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>


                <!-- /.card -->


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
