﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderInfo.aspx.cs" Inherits="CarSpiritsWeb.Sys.Order.OrderInfo" %>

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
        <!--添加、删除按钮、查询按钮 -->
        <div id="tab_toolbar" style="padding: 0 2px;">
            <table cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                    <td style="text-align: left; padding-right: 15px">
                        <input id="ipt_search" menu="#search_menu" />
                        <div id="search_menu" style="width: 120px">
                            <div name="订单号">
                                订单号
                            </div>
                            <div name="用户名">
                                用户名
                            </div>
                            <div name="用户姓名">
                                用户姓名
                            </div>
                            <div name="车牌号">
                                车牌号
                            </div>
                        </div>
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <%--列表 end--%>
    <script type="text/javascript">

        $(function () {
            InitGird();
            InitSearch();
        });
        //初始化表格
        function InitGird() {
            $('#tab_list').datagrid({
                title: '订单列表', //表格标题
                url: location.href, //请求数据的页面 
                sortName: 'JSON_订单号', //排序字段
                idField: 'JSON_订单号', //标识字段,主键
                iconCls: 'icon-1101899', //标题左边的图标
                width: '80%', //宽度
                height: $(parent.document).find("#mainPanle").height() - 28 > 0 ? $(parent.document).find("#mainPanle").height() - 29 : 500, //高度
                nowrap: false, //是否换行，True 就会把数据显示在一行里
                striped: true, //True 奇偶行使用不同背景色
                collapsible: false, //可折叠
                sortOrder: 'desc', //排序类型
                remoteSort: true, //定义是否从服务器给数据排序
                fitColumns: true,//自适应屏幕（冻结的列无法使用）
                frozenColumns: [[//冻结的列，不会随横向滚动轴移动
                ]],
                columns: [[
                    { title: '订单号', field: 'JSON_订单号', width: 100, sortable: true },
                    { title: '用户名', field: 'JSON_用户名', width: 100, sortable: true },
                    { title: '用户姓名', field: 'JSON_用户姓名', width: 100, sortable: true },
                    { title: '手机号', field: 'JSON_手机号', width: 100, sortable: true, align: 'center' },
                    { title: '车牌号', field: 'JSON_车牌号', width: 100, align: 'center' },
                    { title: '加油站', field: 'JSON_加油站', width: 100, align: 'center' },
                    { title: '油号', field: 'JSON_油号', width: 50, align: 'center' },
                    { title: '金额', field: 'JSON_金额', width: 80, align: 'center' },
                    { title: '下单时间', field: 'JSON_下单时间', width: 150, align: 'center' }
                ]],
                toolbar: "#tab_toolbar",
                queryParams: { "action": "query" },
                pagination: true, //是否开启分页
                pageList: [15, 20, 30, 40, 50],
                pageNumber: 1, //默认索引页
                pageSize: 15, //默认一页数据条数
                rownumbers: true //行号
            });

        }
        //初始化搜索框
        function InitSearch() {
            $("#ipt_search").searchbox({
                width: 300,
                iconCls: 'icon-save',
                searcher: function (val, name) {
                    $('#tab_list').datagrid('options').queryParams.search_type = name;
                    $('#tab_list').datagrid('options').queryParams.search_value = val;
                    $('#tab_list').datagrid('reload');
                },
                prompt: '请输入要查询的账号'
            });
        }
    </script>
</body>
</html>
