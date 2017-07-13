<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="CarSpiritsWeb.Sys.Customer.Customer" %>

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
                <td style="padding-left: 2px">
                      <a href="#" onclick="$('#form_edit input').val('');OpenWin();return false;" id="a_add"class="easyui-linkbutton" iconcls="icon-add">添加</a>
                      <a href="#" onclick="DelData(0);return false;" id="a_del" class="easyui-linkbutton" iconcls="icon-cancel">删除</a>
                </td>
                <td style="text-align: right; padding-right: 15px">
                    <input id="ipt_search" menu="#search_menu" />
                    <div id="search_menu" style="width:120px">
                        <div name="customername">
                            姓 名</div>
                        <div name="loginname">
                            登陆名</div>
                        <div name="phonenum">
                            电 话</div>
                        <div name="email">
                            邮 箱</div>
                        <div name="remark">
                            备 注</div>
                    </div>
                </td>
            </tr>
        </table>
       
    </div>
     </form>
    <%--列表 end--%>

    <%--添加 修改 start--%>
    <div id="edit" class="easyui-dialog" title="编辑客户" style="width: 250px; height: 300px;"
        modal="true" closed="true" buttons="#edit-buttons">
        <%--提交给处理程序--%>
        <form id="form_edit" name="form_edit" method="post" url="Customer.aspx">
        <table class="table_edit">
            <tr>
                <td class="tdal">
                    姓名：
                </td>
                <td class="tdar">
                    <input id="ipt_customername"  name="ipt_customername" type="text" class="easyui-validatebox"
                        required="true" />
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    登陆名：
                </td>
                <td class="tdar">
                    <input id="ipt_loginname"  name="ipt_loginname" type="text" class="easyui-validatebox"
                        required="true" />
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    密码：
                </td>
                <td class="tdar">
                    <input id="ipt_loginpwd" name="ipt_loginpwd" type="password" class="easyui-validatebox"
                        required="true" />
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    性别：
                </td>
                <td class="tdar">
            

                        <select id="ipt_sex" class="easyui-combobox" name="ipt_sex" editable="false" required="true"  >
                        <option value="男">男</option>
                        <option value="女">女</option>
                        </select>
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    电话：
                </td>
                <td class="tdar">
                    <input id="ipt_phonenum" name="ipt_phonenum" type="text" class="easyui-validatebox"
                        required="true" />
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    邮箱：
                </td>
                <td class="tdar">
                   <input id="ipt_email" name="ipt_email" type="text" class="easyui-validatebox" validType="email"
                        required="true" />
                </td>
            </tr>
            <tr>
                <td class="tdal">
                    备注：
                </td>
                <td class="tdar">
                    <input id="ipt_remark" name="ipt_remark" type="text" class="easyui-validatebox" />
                </td>
            </tr>
        </table>
        </form>
    </div>
    <div id="edit-buttons">
        <a id="btn_add" href="javascript:;" class="easyui-linkbutton">提交</a> 
        <a href="javascript:;" class="easyui-linkbutton"onclick="$('#edit').dialog('close');return false;">取消</a>
    </div>
    <%--添加 修改 end--%>

    <script type="text/javascript">

        $(function () {
            InitGird();
            InitSearch();
        });
        //初始化表格
        function InitGird() {
            $('#tab_list').datagrid({
                title: '客户列表', //表格标题
                url: location.href, //请求数据的页面 
                sortName: 'JSON_id', //排序字段
                idField: 'JSON_id', //标识字段,主键
                iconCls: 'icon-1617', //标题左边的图标
                width: '80%', //宽度
                height: $(parent.document).find("#mainPanle").height() - 29 > 0 ? $(parent.document).find("#mainPanle").height() - 29 : 500, //高度
                nowrap: false, //是否换行，True 就会把数据显示在一行里
                striped: true, //True 奇偶行使用不同背景色
                collapsible: false, //可折叠
                sortOrder: 'desc', //排序类型
                remoteSort: true, //定义是否从服务器给数据排序
                fitColumns: true,
                frozenColumns: [[//冻结的列，不会随横向滚动轴移动
                ]],
                columns: [[
                    { field: 'cbx', checkbox: true },
                    { title: '客户编号', field: 'JSON_customerid', width: 170},
                    { title: '姓名', field: 'JSON_customername', width: 102},
                    { title: '登陆名', field: 'JSON_loginname', width: 111 },
                    { title: '性别', field: 'JSON_sex', width: 40, align: 'center', sortable: true },
                    { title: '电话', field: 'JSON_phonenum', width: 110, align: 'center' },
                    { title: '邮箱地址', field: 'JSON_email', width: 180, align: 'center' },
                    { title: '备注', field: 'JSON_remark', width: 160, align: 'center', sortable: true },
                    { title: '创建时间', field: 'JSON_createdate', width: 150, align: 'center', sortable: true },
                    {
                        title: '操作', field: 'JSON_id', width: 55, align: 'center', formatter: function (value, rec) {
                            return '<a style="color:red" href="javascript:;" onclick="EditData(' + value + ');$(this).parent().click();return false;">修改</a>';
                        }
                    }
                ]],
                toolbar: "#tab_toolbar",
                queryParams: { "action": "query" },
                pagination: true, //是否开启分页
                pageNumber: 1, //默认索引页
                pageSize: 10, //默认一页数据条数
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

        //打开添加窗口
        function OpenWin() {
            $("#edit").dialog("open");
            $("#edit-buttons a:first").attr("onclick", "Add(0); return false;")
        }
        function GetInputData(id, cmd) {
            var postdata = "{ \"action\":\"" + cmd + "\",";
            $("#" + id + " input[type!='checkbox']").each(function () {
                postdata += "\"" + $(this).attr("name") + "\":\"" + $(this).val() + "\",";
            });
            $("#" + id + " input[type='checkbox']").each(function () {
                postdata += "\"" + $(this).attr("name") + "\":\"" + this.checked + "\",";
            });
            postdata = postdata.substr(0, postdata.length - 1);
            postdata += "}";
            return eval("(" + postdata + ")");
        }
        //提交按钮事件
        function Add(uid) {
            if (!$("#form_edit").form("validate")) {
                return;
            }


            var json = GetInputData('edit', 'submit');

            json.id = uid;
            $.post(location.href, json, function (data) {
                $.messager.alert('提示', data, 'info', function () {
                    if (data.indexOf("成功") > 0) {
                        console.info(data);
                        $("#tab_list").datagrid("reload");
                        $("#edit").dialog("close");
                    }

                });
            });

        }

        //修改链接 事件
        function EditData(uid) {
            $("#edit").dialog("open");
            $("#btn_add").attr("onclick", "Add(" + uid + "); return false;")

            $.post(location.href, { "action": "queryone", "id": uid }, function (data) {
                var dataObj = eval("(" + data + ")"); //转换为json对象    
                console.info(dataObj);
                $("#form_edit").form('load', dataObj);
            });
        }

        //删除按钮事件
        function DelData(id) {
            $.messager.confirm('提示', '确认删除？', function (r) {
                if (r) {
                    var selected = "";
                    if (id <= 0) {
                        $($('#tab_list').datagrid('getSelections')).each(function () {
                            selected += this.JSON_id + ",";
                        });
                        selected = selected.substr(0, selected.length - 1);
                        if (selected == "") {
                            $.messager.alert('提示', '请选择要删除的数据！', 'info');
                            return;
                        }
                    }
                    else {
                        selected = id;
                    }
                    $.post(location.href, { "action": "del", "cbx_select": selected }, function (data) {
                        $.messager.alert('提示', data, 'info', function () { $("#tab_list").datagrid("reload"); });
                    });

                }
            });
        }
    </script>
</body>
</html>
