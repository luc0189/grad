<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="gradox.vista.Personas" %>
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
                        <li class="breadcrumb-item active"><a href="#">Crear Personas</a></li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <div class="container-fluid">
        <form id="form1" runat="server">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-dark">
                        <div class="card-header">
                            <strong>Gestion de Personas</strong>
                            <div class="card-tools">
                                <b># 
                                    <label id="txtid" runat="server"></label>
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
                                            <input type="number" id="txtcc" runat="server" required="required" placeholder="Numero Documento" class="form-control">
                                        </div>
                                        <%--numero de documento--%>
                                    </div>
                                    <div class="form-group form-control">
                                        <div class="input-group" id="group">
                                            <select id="selectTipodoc" runat="server" class="js-example-basic form-control" required="required">
                                                <option value="CEDULA DE CIUDADANIA">CEDULA DE CIUDADANIA </option>
                                            </select>
                                            <%--  <div class="input-group-btn">
                                         <asp:LinkButton ID="btnmas"  runat="server"  Text="Modifica" class="btn btn-outline-primary btn-sm ">
                                                                    <i aria-hidden="true"  class="fa fa-pencil"></i>
                                         </asp:LinkButton>
                                    </div>--%>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-home"></i></span>
                                            </div>
                                            <input type="text" id="txtnombres" runat="server" class="form-control" placeholder="Nombres" required="required">
                                        </div>
                                        <!-- /.input group -->
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-home"></i></span>
                                            </div>
                                            <input type="text" id="txtapellidos" runat="server" class="form-control" placeholder="Apellidos" required="required">
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
                                            <input type="text" id="txtdireccion" runat="server" class="form-control" placeholder="Direccion" required="required">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-phone"></i></span>
                                            </div>
                                            <input type="text" id="txttelefono" runat="server" class="form-control" placeholder="Telefono" required="required">
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fa fa-envelope"></i></span>
                                            </div>
                                            <input type="email" id="txtemail" runat="server" class="form-control" placeholder="Email" required="required">
                                        </div>
                                    </div>
                                    <div class="form-group form-control">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <label><strong>Fecha Nacimiento</strong></label>
                                                <span class="input-group-text"><i class="fa fa-calendar"></i></span>
                                            </div>
                                            <input type="date" id="txtfnacimiento" runat="server" name="name" value="" required="required" />
                                        </div>
                                        <!-- /.input group -->
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <div class="input-group">
                                <div class="input-group-prepend"">
                                     <button type="submit" id="btnguardar" runat="server" onserverclick="btnguardar_ServerClick" class="btn btn-app btn-outline-primary"><i aria-hidden="true" class="fa fa-save"></i>Guardar</button>
                                <asp:LinkButton ID="btneditar_Click" runat="server" Text="Modifica" class="btn btn-app btn-outline-primary" OnClick="btnModificar_Click" >
                                           <i aria-hidden="true"  class="fa fa-pencil"></i>Actualizar
                                   </asp:LinkButton>
                                <asp:LinkButton ID="btnborra" runat="server" Text="Borra" class="btn btn-app btn-outline-primary" OnClick="btnborra_Click">
                                        <i aria-hidden="true"  class="fa fa-trash"></i>Eliminar
                                </asp:LinkButton>
                                </div>
                               
                            </div>

                        </div>
                    </div>

                </div>
                <div class="card">
                    <div class="card-header">
                        <strong>Buscador</strong>
                        <div class="card-tools">
                            <button type="button" class="btn btn-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                            <button type="button" class="btn btn-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
                        </div>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            
                            <asp:GridView ID="GridViewNovedades" runat="server" GridLines="None" class="display "
                                OnSelectedIndexChanged="GridViewNovedades_SelectedIndexChanged"
                                CssClass=" gvuser table table-hover table-responsive text-sm" EmptyDataText="No se encontraron Registros con los parametros indicados.">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" ButtonType="Image" SelectImageUrl="../dist/img/ok.png" />
                                   
                                </Columns>
                            </asp:GridView>
                        </div>

                    </div>
                    <div class="card-footer">
                    </div>
                </div>
            </div>

        </form>
    </div>
    <script>
        $('#selectTipodoc').select2({
            dropdownParent: $('#group')
        });
    </script>
</asp:Content>
