<%@ Page Title="" Language="C#" MasterPageFile="~/vista/menu.Master" AutoEventWireup="true" CodeBehind="appmovil.aspx.cs" Inherits="gradox.vista.appmovil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-content">
        <div class="container">
            <div class="row no-gutters">
                <div class="col-md-10 push-md-1" role="tablist">
                    <!-- Menu Category / Entradas -->
                    <div id="Entradas" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuBurgersContent" data-toggle="collapse" aria-expanded="true">
                            <div class="bg-image">
                                <img src="assets/img/photos/Entradas.jpeg" alt="" />
                            </div>
                            <h2 class="title">Entradas</h2>
                        </div>
                        <div id="menuBurgersContent" class="menu-category-content collapse show">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewentradas" runat="server" GridLines="None" class="display compact"  OnSelectedIndexChanged="insertainfopedido"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <%-- <!-- Menu Item -->
                                <div class="menu-item menu-list-item">
                                    <div class="row align-items-center">
                                        <div class="col-sm-6 mb-2 mb-sm-0">
                                            <h6 class="mb-0">Beef Burger</h6>
                                            <span class="text-muted text-sm">Beef, cheese, potato, onion, fries</span>
                                        </div>
                                        <div class="col-sm-6 text-sm-right">
                                            <span class="text-md mr-4"><span class="text-muted">from</span> $9.00</span>
                                            <button class="btn btn-outline-secondary btn-sm" data-target="#productModal" data-toggle="modal"><span>Add to cart</span></button>
                                        </div>
                                    </div>
                                </div>
                                <!-- Menu Item -->
                                <div class="menu-item menu-list-item">
                                    <div class="row align-items-center">
                                        <div class="col-sm-6 mb-2 mb-sm-0">
                                            <h6 class="mb-0">Broccoli</h6>
                                            <span class="text-muted text-sm">Chicken, cheese, potato, onion, fries</span>
                                        </div>
                                        <div class="col-sm-6 text-sm-right">
                                            <span class="text-md mr-4"><span class="text-muted">from</span> $11.00</span>
                                            <button class="btn btn-outline-secondary btn-sm" data-target="#productModal" data-toggle="modal"><span>Add to cart</span></button>
                                        </div>
                                    </div>
                                </div>
                                <!-- Menu Item -->
                                <div class="menu-item menu-list-item">
                                    <div class="row align-items-center">
                                        <div class="col-sm-6 mb-2 mb-sm-0">
                                            <h6 class="mb-0">Chicken Burger</h6>
                                            <span class="text-muted text-sm">Chicken, cheese, potato, onion, fries</span>
                                        </div>
                                        <div class="col-sm-6 text-sm-right">
                                            <span class="text-md mr-4"><span class="text-muted">from</span> $11.00</span>
                                            <button class="btn btn-outline-secondary btn-sm" data-target="#productModal" data-toggle="modal"><span>Add to cart</span></button>
                                        </div>
                                    </div>
                                </div>
                                <!-- Menu Item -->
                                <div class="menu-item menu-list-item">
                                    <div class="row align-items-center">
                                        <div class="col-sm-6 mb-2 mb-sm-0">
                                            <h6 class="mb-0">Creste di Galli</h6>
                                            <span class="text-muted text-sm">Pasta, cheese, potato, onion, fries</span>
                                        </div>
                                        <div class="col-sm-6 text-sm-right">
                                            <span class="text-md mr-4"><span class="text-muted">from</span> $9.00</span>
                                            <button class="btn btn-outline-secondary btn-sm" data-target="#productModal" data-toggle="modal"><span>Add to cart</span></button>
                                        </div>
                                    </div>
                                </div>--%>
                        </div>
                    </div>
                    <!-- Menu Category / RES -->
                    <div id="Res" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuBurgersContent2" data-toggle="collapse" aria-expanded="true">
                            <div class="bg-image">
                                <img src="assets/img/photos/RES.jpg" />
                            </div>
                            <h2 class="title">Res</h2>
                        </div>
                        <div id="menuBurgersContent2" class="menu-category-content collapse ">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewRes" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertacarne"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / cerdo -->
                    <div id="Cerdo" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuBurgersContent3" data-toggle="collapse" aria-expanded="true">
                            <div class="bg-image">
                                <img src="assets/img/photos/CERDO.jpg" />
                            </div>
                            <h2 class="title">Cerdo</h2>
                        </div>
                        <div id="menuBurgersContent3" class="menu-category-content collapse ">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewCerdo" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertacerdo"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / Pasta -->
                    <div id="pastas" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuPastaContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-pasta.jpg" alt=""></div>
                            <h2 class="title">Pastas</h2>
                        </div>
                        <div id="menuPastaContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewPastas" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertapastas"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / cremas -->
                    <div id="Cremas" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuPizzaContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-pizza.jpg" alt=""></div>
                            <h2 class="title">Cremas</h2>
                        </div>
                        <div id="menuPizzaContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewCremas" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertacremas"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / pescados -->
                    <div id="pescado" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuSushiContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-sushi.jpg" alt=""></div>
                            <h2 class="title">Pescados</h2>
                        </div>
                        <div id="menuSushiContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewPescados" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertapescados"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / mariscos -->
                    <div id="mariscos" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuSushiContent2" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/MARISCOS.jpg" alt="Mariscos" />
                            </div>
                            <h2 class="title">Mariscos</h2>
                        </div>
                        <div id="menuSushiContent2" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewMariscos" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertamariscos"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / postres y ensaladas -->
                    <div id="Postres" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuDessertsContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-desserts.jpg" alt=""></div>
                            <h2 class="title">Postres y Ensaladas</h2>
                        </div>
                        <div id="menuDessertsContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewPostres" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertapostres"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                    <!-- Menu Category / pollo -->
                    <div id="pollo" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menupolloContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-pasta.jpg" alt=""></div>
                            <h2 class="title">Pollo</h2>
                        </div>
                        <div id="menupolloContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewPollo" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertapollo"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- Menu Category / bebidas -->
                    <div id="bebidascon" class="menu-category">
                        <div class="menu-category-title collapse-toggle" role="tab" data-target="#menuDrinksContent" data-toggle="collapse" aria-expanded="false">
                            <div class="bg-image">
                                <img src="assets/img/photos/menu-title-drinks.jpg" alt=""></div>
                            <h2 class="title">Bebidas</h2>
                        </div>
                        <div id="menuDrinksContent" class="menu-category-content collapse">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView ID="GridViewBebidas" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="insertabebidas"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Añadir al Pedido" />
                                                    </Columns>

                                                </asp:GridView>
                                            </div>
                                            <div class="card-footer">
                                                <a href="#Entradas" id="back-to-top" class="visible"><i class="ti ti-angle-up"></i></a>
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
     <div id="panel-cart">
        <div class="panel-cart-container">
            <div class="panel-cart-title">
                <h5 class="title">Su Pedido</h5>
                <button class="close" data-toggle="panel-cart"><i class="ti ti-close"></i></button>
            </div>
            <div class="panel-cart-content">
                <div class="table-responsive">
                    <asp:GridView ID="GridVieworden" runat="server" GridLines="None" class="display compact" OnSelectedIndexChanged="borraitems"
                                                    CssClass="gvuser3 table table-striped table-bordered text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados." PageSize="3">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-outline-secondary btn-sm" ButtonType="Button" SelectText="Borrar"  />
                                                    </Columns>

                                                </asp:GridView>
                </div>
                <div class="cart-summary">
                    <label runat="server" id="txtitems"></label> Items
                    <div class="row">
                        <div class="col-7 text-right text-muted">Subtotal:</div>
                        <div class="col-5"><strong>
                            <input type="text" name="name" value="" runat="server"  id="txtsubtotal"/></strong></div>
                    </div>
                    <div class="row">
                        <div class="col-7 text-right text-muted">Iva:</div>
                        <div class="col-5"><strong>
                            <input type="text" name="name" value="" runat="server" id="txtiva" /></strong></div>
                    </div>
                    <hr class="hr-sm">
                    <div class="row text-lg">
                        <div class="col-7 text-right text-muted">Total:</div>
                        <div class="col-5"><strong>
                            <input type="text" name="name" value="" runat="server" id="txttotal" /></strong></div>
                    </div>
                </div>
            </div>
        </div>
        <a href="checkout.html" class="panel-cart-action btn btn-secondary btn-block btn-lg"><span>Go to checkout</span></a>
    </div>

   

    <!-- Body Overlay -->
    <div id="body-overlay"></div>
    <!-- Modal / Product -->
    <div class="modal fade" id="productModal" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header modal-header-lg dark bg-dark">
                    <div class="bg-image">
                        <img src="assets/img/photos/modal-add.jpg" alt=""></div>
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
