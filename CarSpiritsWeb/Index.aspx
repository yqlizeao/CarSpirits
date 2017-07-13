<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarSpiritsWeb.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>车载精灵后台管理</title>
    <script src="jQueryEasyUi/jquery-1.8.0.min.js"type="text/javascript"></script>
    <script src="jQueryEasyUi/jquery.easyui.min.js"type="text/javascript"></script>
    <script src="jQueryEasyUi/locale/easyui-lang-zh_CN.js"type="text/javascript"></script>
    <link href="jQueryEasyUi/Styles/icon.css" rel="stylesheet" />
    <link href="jQueryEasyUi/Styles/IconExtension.css" rel="stylesheet" />
    <link href="jQueryEasyUi/Styles/bootstrap/easyui.css" type="text/css"rel="stylesheet" />
<style type="text/css">
body {
	font: 12px/20px "微软雅黑", "宋体", Arial, sans-serif, Verdana, Tahoma;
	padding: 0;
	margin: 0;
}
.layout-split-proxy-h{
	position:absolute;
	width:2px;
	background:#888;
	font-size:1px;
	cursor:e-resize;
	display:none;
	z-index:5;
}

.layout-split-north{
	border-bottom:5px solid #efefef;
}
.layout-split-south{
	border-top:5px solid #efefef;
}
.layout-split-east{
	border-left:0px solid #efefef;
}
.layout-split-west{
	border-right:0px solid #efefef;
}
a:link {
 color:#758a99;
 text-decoration: none;
}
a:visited {
  color:#758a99;
 text-decoration: none;
}
a:hover {
    color:#000000;
 text-decoration:none;
}
a:active {
 text-decoration: none;
}
.cs-north {
	height:60px;
}
.cs-north-bg {
	width: 100%;
	height: 88%;
	background: url(jQueryEasyUi/Styles/bootstrap/images/header_bg.png) repeat-x;
}
.cs-north-logo {
	height: 1px;
	margin: 0px 0px 0px 5px;
	display: inline-block;
	color:#000000;font-size:22px;font-weight:bold;text-decoration:none
    }
.cs-west {
	width:130px;padding:0px;
}
.cs-navi-tab {
	padding: 5px;
}
.cs-tab-menu {
	width:120px;
}
.cs-home-remark {
	padding: 10px;
}
.wrapper {
    float: right;
    height: 30px;
    margin-left: 10px;
}
</style>
<script type="text/javascript">
    function addTab(title, url) {
        if ($('#tabs').tabs('exists', title)) {
            $('#tabs').tabs('select', title); //选中并刷新
            var currTab = $('#tabs').tabs('getSelected');
            var url = $(currTab.panel('options').content).attr('src');
            if (url != undefined && currTab.panel('options').title != 'Home') {
                $('#tabs').tabs('update', {
                    tab: currTab,
                    options: {
                        content: createFrame(url)
                    }
                })
            }
        } else {
            var content = createFrame(url);
            $('#tabs').tabs('add', {
                title: title,
                content: content,
                closable: true
            });
        }
        tabClose();
    }
    function createFrame(url) {
        var s = '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>';
        return s;
    }

    function tabClose() {
        /*双击关闭TAB选项卡*/
        $(".tabs-inner").dblclick(function () {
            var subtitle = $(this).children(".tabs-closable").text();
            $('#tabs').tabs('close', subtitle);
        })
        /*为选项卡绑定右键*/
        $(".tabs-inner").bind('contextmenu', function (e) {
            $('#mm').menu('show', {
                left: e.pageX,
                top: e.pageY
            });

            var subtitle = $(this).children(".tabs-closable").text();

            $('#mm').data("currtab", subtitle);
            $('#tabs').tabs('select', subtitle);
            return false;
        });
    }
    //绑定右键菜单事件
    function tabCloseEven() {
        //刷新
        $('#mm-tabupdate').click(function () {
            var currTab = $('#tabs').tabs('getSelected');
            var url = $(currTab.panel('options').content).attr('src');
            if (url != undefined && currTab.panel('options').title != 'Home') {
                $('#tabs').tabs('update', {
                    tab: currTab,
                    options: {
                        content: createFrame(url)
                    }
                })
            }
        })
        //关闭当前
        $('#mm-tabclose').click(function () {
            var currtab_title = $('#mm').data("currtab");
            $('#tabs').tabs('close', currtab_title);
        })
        //全部关闭
        $('#mm-tabcloseall').click(function () {
            $('.tabs-inner span').each(function (i, n) {
                var t = $(n).text();
                if (t != 'Home') {
                    $('#tabs').tabs('close', t);
                }
            });
        });
        //关闭除当前之外的TAB
        $('#mm-tabcloseother').click(function () {
            var prevall = $('.tabs-selected').prevAll();
            var nextall = $('.tabs-selected').nextAll();
            if (prevall.length > 0) {
                prevall.each(function (i, n) {
                    var t = $('a:eq(0) span', $(n)).text();
                    if (t != 'Home') {
                        $('#tabs').tabs('close', t);
                    }
                });
            }
            if (nextall.length > 0) {
                nextall.each(function (i, n) {
                    var t = $('a:eq(0) span', $(n)).text();
                    if (t != 'Home') {
                        $('#tabs').tabs('close', t);
                    }
                });
            }
            return false;
        });

        //退出
        $("#mm-exit").click(function () {
            $('#mm').menu('hide');
        })
    }

    $(function () {
        tabCloseEven();

        $('.cs-navi-tab').click(function () {
            var $this = $(this);
            var href = $this.attr('src');
            var title = $this.text();
            addTab(title, href);
        });
    });


    function setCookie(name, value) {//两个参数，一个是cookie的名子，一个是值
        var Days = 30; //此 cookie 将被保存 30 天
        var exp = new Date();    //new Date("December 31, 9998");
        exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
        document.cookie = name + "=" + escape(value) + ";expires=" + exp.toGMTString();
    }

    function getCookie(name) {//取cookies函数        
        var arr = document.cookie.match(new RegExp("(^| )" + name + "=([^;]*)(;|$)"));
        if (arr != null) return unescape(arr[2]); return null;
    }
</script>
</head>
<body class="easyui-layout" style="background:url(jQueryEasyUi/login/login_bgx.gif)">
    <%--上方标题Logo--%>
	<div region="north" border="true" class="cs-north" style="background:url(jQueryEasyUi/login/login_bgx.gif)">
		<div class="cs-north-bg"style="text-align:center;">
		    <img src="jQueryEasyUi/login/cslogo.png" style="width: 62px; height: 30px; margin-top: 17px;"><img src="jQueryEasyUi/login/uplogo.png" style="width: 150px; height: 34px;">
		</div>
	</div>
    <%--左侧菜单栏--%>
	<div region="west" border="true" split="true" title="导航" class="cs-west" iconcls="icon-1104112">
		<div class="easyui-accordion" fit="true" border="false">
				<div title="管理员"iconcls="icon-1187377"style="background:url(jQueryEasyUi/login/login_bgx.gif)">
					<p><a href="javascript:void(0);" src="Sys/Admin/Admin.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1200704.png" style="vertical-align:middle;padding-right:2px;"/>管理员列表</a></p>
                    <p><a href="javascript:void(0);" src="Sys/Admin/LocalGasStation.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1155959.png" style="vertical-align:middle;padding-right:4px;"/>周边加油站</a></p>
                    <p><a href="javascript:void(0);" src="Sys/Admin/LocalMap.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1185657.png" style="vertical-align:middle;padding-right:4px;"/>实时地图</a></p>
					<p><a href="javascript:void(0);" onclick="addTab('大赛官网','http://www.cnsoftbei.com/')"style="padding: 5px;"><img src="jQueryEasyUi/Styles/icons/1142006.png" style="vertical-align:middle;padding-right:2px;"/>大赛官网</a></p>
				</div>
				<div title="客户" iconcls="icon-1191636"data-options="selected:true"style="background:url(jQueryEasyUi/login/login_bgx.gif)">
                    <p><a href="javascript:void(0);" src="Sys/Customer/Customer.aspx" class="cs-navi-tab" > <img src="jQueryEasyUi/Styles/icons/1617.png" style="vertical-align:middle;padding-right:2px;"/>客户列表</a><p>
					<p><a href="javascript:void(0);" src="Sys/Customer/CustomerCar.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1167224.png" style="padding-right:2px;"/>客户车辆列表</a></p>
                    <p><a href="javascript:void(0);" src="Sys/Customer/CustomerCarInfo.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1167226.png" style="padding-right:2px;"/>客户车辆信息</a></p>
                    <p><a href="javascript:void(0);" src="Sys/Customer/UpdateCarInfo.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1186199.png" style="vertical-align:middle;padding-right:1px;"/>更新车辆信息</a></p>
				</div>
				<div title="订单" iconcls="icon-515969"style="background:url(jQueryEasyUi/login/login_bgx.gif)">
					<p><a href="javascript:void(0);" src="Sys/Order/OrderInfo.aspx"  class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1101899.png" style="vertical-align:middle;padding-right:3px;"/>订单列表</a></p>
					<p><a href="javascript:void(0);" src="Sys/Order/UpdateOrderInfo.aspx" class="cs-navi-tab"><img src="jQueryEasyUi/Styles/icons/1146183.png" style="vertical-align:middle;padding-right:3px;"/>订单管理</a></p>
				</div>
		</div>
	</div>
    <%--中间首页信息--%>
	<div id="mainPanle" region="center" border="true" border="false" >
		 <div id="tabs" class="easyui-tabs"  fit="true" border="false" >
                <div title="主页">
				<div class="cs-home-remark" style="background:url(jQueryEasyUi/login/login_bgx.gif)">
					<h1>车载精灵后台管理</h1> <br>
					制作：ironboys <br>
					校园主页：<a href="javascript:void(0);" onclick="addTab('校园主页','http://www.ntu.edu.cn/')">www.ntu.edu.cn</a><br>
                    推荐分辨率：1366*768
                    <div class="easyui-calendar" style="width:350%;height:332px;"></div>
				</div>
				</div>
        </div>
	</div>
    <%--下方版权信息--%>
	<div region="south" border="false" id="south"style="background:url(jQueryEasyUi/login/login_bgx.gif)"><center>Copyright © 2016.<a href="http://www.ntu.edu.cn/" target="_blank" title="南通大学">Nantong University</a>.ironboys.All rights reserved.</center></div>
	
    <%--右键按钮事件--%>
	<div id="mm" class="easyui-menu cs-tab-menu"style="background:url(jQueryEasyUi/login/login_bgx.gif)">
		<div id="mm-tabupdate">刷新</div>
		<div class="menu-sep"></div>
		<div id="mm-tabclose">关闭</div>
		<div id="mm-tabcloseother">关闭其他</div>
		<div id="mm-tabcloseall">关闭全部</div>
	</div>
</body>
</html>
