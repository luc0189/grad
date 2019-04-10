<%@ Page Title="" Language="C#" MasterPageFile="~/vista/vista.Master" AutoEventWireup="true" CodeBehind="Appmesas.aspx.cs" Inherits="gradox.vista.Appmesas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form action=" " method="post" runat="server">
    <div class="container-fluid">

        <div class="col-md-12">
            <div class="card card-dark">
                <div class="card-header">
                    <strong>Mesas</strong>
                   
                </div>
                <div class="card-body">
                    <asp:HiddenField ID="hdfUrlProduct" runat="server"  />
                     <div class="row">
                          <asp:Repeater ID="RepeateMesas" runat="server">
                          <ItemTemplate>

                    <div class="col-xs-10 col-sm-4 col-md-3 ">
                        <div class="img-thumbnail">
                            <div class="card-body">
                                <div class="card">
                                    <div class="card-header">
                                       <%#Eval("ID") %>                                  
                                <div class="card-tools">
                                    <input type="text" name="namestado"  value=" <%#Eval("ESTADO") %>" disabled="disabled"/>  
                                    </div>
                                
                                    </div>
                                    
                                    <div class="card-body">
                                        <div class="btn-group">
                                              <asp:LinkButton ID="LinkButton2" runat="server" Text=<%# String.Format("{0}-{1}", Eval("ID "), Eval(" DESCRIPCION"))%> OnClick="ir" class="btn btn-app btn-outline-primary form-control">
                                                                   
                                                        </asp:LinkButton>
                                      </div>
                                    </div>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                            </ItemTemplate>
                    </asp:Repeater>
                </div>

                   
                    
                </div>
            </div>
        </div>

    </div>
        </form>
    <script type="text/javascript">
      function Navigate()
      {
          var txt;
  var r = confirm("Press a button!\nEither OK or Cancel.\nThe button you pressed will be displayed in the result window.");
          if (r == true) {
            <%-- <%-- <%Session["controlID"] = "2";%>
              window.open("WebForm1.aspx");--%>
          <%--  var IDSes= "10200";
    
            <%=Session["IDSes"] %>;
              window.open("WebForm1.aspx");
             
          --%>
              
              txt = document.getElementById;
              <%Session["pid"] = "1";%>
          } else {
             window.location("WebForm1.aspx");
             }
        //return confirm("Confirme el postback");
          //javascript: window.open("WebForm1.aspx");
      }    
      
    </script>
</asp:Content>
