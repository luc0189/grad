<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="gradox.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <link rel="stylesheet" href="vista/assets/plugins/bootstrap/dist/css/bootstrap.min.css" />
    <link href="dist/css/AdminLTE.css" rel="stylesheet" />
    <link href="vista/plugins/select2/select2.css" rel="stylesheet" />
    <%-- <style type="text/css">
       .img1{
           
           filter: blur(5px);
           position: absolute;
             left: 0px;
  top:-10px;
    width:100%;
  height:100%;
  z-index: -100;

       }
       </style>--%>
</head>
<body style="background-color: rgba(24,13,49,.83);">


    <div class="login-box">
        <div class="login-logo">
            <img src="vista/img/logo-alt.3c0f532.png" style="max-width: 60%;" />
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">Inicio Session</p>

            <form runat="server" method="post">
                <div class="form-group has-feedback">
                    <input type="text" id="txtususario" runat="server" class="form-control" placeholder="Usuario" />
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <input type="password" id="txtcontraseña" runat="server" class="form-control" placeholder="Password" />
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <select id="selectbd" runat="server" class=" form-control" placeholder="Password">
                        <option value="SISPE">Rio Gourmet</option>

                    </select>

                </div>
                <div class="row active">
                     <div class="card-footer col-md-12">
                        <asp:Button ID="Entrar" class="btn btn-success btn-block btn-flat" runat="server" Text="Entrar" OnClick="Entrar_Click" />
                         <a href="register.html" class="text-center">Restablecer Contraseña</a>
            <p id="txtAlerta" runat="server" class="alert-danger"></p>
                    </div>
                    <!-- /.col -->
                </div>
            </form>

            <!-- /.social-auth-links -->

           
            
        </div>
        <!-- /.login-box-body -->
        
    </div>


    <script src="vista/assets/plugins/jquery/dist/jquery.min.js"></script>
    <script src="vista/assets/plugins/tether/dist/js/tether.min.js"></script>
    <script src="vista/assets/plugins/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="vista/assets/plugins/slick-carousel/slick/slick.min.js"></script>
    <script src="vista/assets/plugins/jquery.appear/jquery.appear.js"></script>
    <script src="vista/assets/plugins/jquery.scrollto/jquery.scrollTo.min.js"></script>
    <script src="vista/assets/plugins/jquery.localscroll/jquery.localScroll.min.js"></script>
    <script src="vista/assets/plugins/jquery-validation/dist/jquery.validate.min.js"></script>
    <script src="vista/assets/plugins/jquery.mb.ytplayer/dist/jquery.mb.YTPlayer.min.js"></script>
    <script src="vista/assets/plugins/twitter-fetcher/js/twitterFetcher_min.js"></script>
    <script src="vista/assets/plugins/skrollr/dist/skrollr.min.js"></script>
    <script src="vista/assets/plugins/animsition/dist/js/animsition.min.js"></script>
    <script src="vista/plugins/select2/select2.js"></script>
     <script>
        $(document).ready(function () {
            $("#selectbd").select2();
        })
    </script>
</body>
</html>
