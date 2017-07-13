<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarSpiritsWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="jQueryEasyUi/login/google_jquery-ui.min.js"type="text/javascript"></script>
    <script src="jQueryEasyUi/login/google_jquery.min.js"type="text/javascript"></script>
    <script src="jQueryEasyUi/login/JQuery.cookie.js"type="text/javascript"></script>
    <link href="jQueryEasyUi/login/jquery.ui.all.css"type="text/css" rel="stylesheet" />
    <link href="jQueryEasyUi/login/style.css" type="text/css"rel="stylesheet" />
    <link href="jQueryEasyUi/login/style_log.css"type="text/css" rel="stylesheet" />
    <style type="text/css">
        .login{background:url(jQueryEasyUi/login/login_bgx.gif)}
    </style>
    <script type="text/javascript"> 
        $(function (){
        ////忘记密码
        $("#iforget").click(function () {
            $("#login_model").hide();
            $("#forget_model").show();
        });
        //返回
        $("#denglou").click(function () {
            $("#username").val("");
            $("#userpwd").val("");
            $("#login_model").show();
            $("#forget_model").hide();
        });
        })
    </script>
</head>
<body class="login" mycollectionplug="bind">
    <form action="Login.aspx" method="post">
        <div class="login_m">
            <div class="login_logo">
                <img src="jQueryEasyUi/login/logo.png" style="width: auto; height: auto">
            </div>
            <div class="login_boder">
                <div class="login_padding" id="login_model">
                    <h2>用户名：</h2>
                    <label>
                        <input type="text" id="username" name="username"  class="txt_input txt_input2" onfocus="if (value ==&#39;Login name&#39;){value =&#39;&#39;}" onblur="if (value ==&#39;&#39;){value=&#39;Login name&#39;}" value="Login name">
                    </label>
                    <h2>密 码：</h2>
                    <label>
                        <input type="password" id="userpwd" name="userpwd"  class="txt_input" onfocus="if (value ==&#39;********&#39;){value =&#39;&#39;}" onblur="if (value ==&#39;&#39;){value=&#39;********&#39;}" value="********">
                    </label>

                    <p class="forgot"><a id="iforget" href="javascript:void(0);">忘记密码？</a></p>

                    <div class="rem_sub">
                        <div class="rem_sub_l">
                            <input type="checkbox" name="checkbox" id="save_me">
                            <label for="checkbox">记住我</label>
                        </div>
                        <label>
                            <input type="submit" id="button" name="button" class="sub_button" value="SIGN-IN" style="opacity: 0.7;">
                        </label>
                    </div>
                </div>
                <div id="forget_model" class="login_padding" style="display: none">
                    <br>
                    <h1>忘记密码：</h1>
                    <br>
                    <div class="forget_model_h2">找回密码暂不可用，请联系管理员找回密码！<br>
                        <br>
                        管理员联系方式：<br>
                        Tel：15996661662<br>
                        QQ：316475663</div>
                    <br>
                    <div class="rem_sub">
                        <div class="rem_sub_l"></div>
                        <label>
                            <input type="submit" class="sub_button" name="button" id="denglou" value="Return" style="opacity: 0.7;">
                        </label>
                    </div>
                </div>
                <!--login_padding  Sign up end-->
            </div>
            <!--login_boder end-->
        </div>
    </form>
    <!--login_m end-->
    <br>
    <br>
    <p align="center"><a href="http://www.ntu.edu.cn/" target="_blank" title="南通大学">Nantong University</a> ironboys.</p>
    <p align="center">Copyright © 2016.All rights reserved.   
</body>
</html>
