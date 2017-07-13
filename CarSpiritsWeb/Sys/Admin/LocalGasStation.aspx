<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocalGasStation.aspx.cs" Inherits="CarSpiritsWeb.Sys.Admin.LocalGasStation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<script src="../../jQueryEasyUi/jquery.min.js" type="text/javascript"></script>
    <script src="../../jQueryEasyUi/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="../../jQueryEasyUi/locale/easyui-lang-zh_CN.js"type="text/javascript"></script>
    <link href="../../jQueryEasyUi/Styles/bootstrap/easyui.css" type="text/css" rel="stylesheet" />
    <link href="../../jQueryEasyUi/Styles/demo.css" type="text/css"rel="stylesheet" />
    <link href="../../jQueryEasyUi/Styles/icon.css" type="text/css" rel="stylesheet" />
<style type="text/css">
body{
    padding:0;
}
</style>
</head>
<body>
    <%--列表 start--%>
    <form id="form_list" name="form_list" method="post">
     <!--数据绑定到DBGrid -->
    <table id="tab_list">
    </table>
        <div id="tab_toolbar" style="padding: 0 2px;">
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td style="padding-left: 2px">
                      <a style="color:red;font-weight:bold" href="javascript:;" onclick="EditData(' + value + ');$(this).parent().click();return false;"class="easyui-linkbutton" iconcls="icon-tip">查询周边加油站(稍有延迟，请等待）</a>
                </td>
            </tr>
        </table>
    </div>

    <script type="text/javascript">

        $(function () {
            InitGird();
            InitSearch();
        });
        //初始化表格
        function InitGird() {
            $('#tab_list').datagrid({
                title: '↓↓↓↓↓请按下方按钮查询加油站↓↓↓↓↓',
                url: location.href, //请求数据的页面 
                height: $(parent.document).find("#mainPanle").height() - 28 > 0 ? $(parent.document).find("#mainPanle").height() - 28 : 500,
                toolbar: "#tab_toolbar",
                queryParams: { "action": "query" },
            });

        }
        //修改链接 事件
        function EditData(uid) {
            $.post(location.href, { "action": "queryone", "id": uid }, function (data) {
                var dataObj = eval("(" + data + ")"); //转换为json对象    
                console.info(dataObj);

                var jsonarray = dataObj.result.data;
                for (var i = 0; i < jsonarray.length; i++) {
                    var jsonobj = jsonarray[i];

                    document.write("<p style='font-weight:bold;color:red'>加油站：</p>" + jsonarray[i]["name"]);
                    document.write("<p style='font-weight:bold;color:green'>地区：</p>" + jsonarray[i]["areaname"]);
                    document.write("<p style='font-weight:bold;color:blue'>地址：</p>" + jsonarray[i]["address"]);
                    document.write("<p style='font-weight:bold;color:purple'>距离：</p>" + jsonarray[i]["distance"] + "米");
                    document.write("<p style='font-weight:bold;color:block'>---------------------------★☆★☆★☆---------------------------</p>");
                   
                    //for (var x in jsonobj) {
                    //    document.write(x + "=" + jsonobj[x]);
                    //}
                }
                //document.write("(" + data + ")");
                alert("查询成功！！");
            });
        }
    </script>
</body>
</html>
