<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jqxTreeGrid.aspx.cs" Inherits="jqxTreeGridDemo.jqxTreeGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jqxTreeGrid Demo</title>
    <link href="jqwidgets/styles/jqx.base.css" rel="stylesheet" />
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="jqwidgets/jqxcore.js"></script>
    <script src="jqwidgets/jqxdata.js"></script>
    <script src="jqwidgets/jqxbuttons.js"></script>
    <script src="jqwidgets/jqxscrollbar.js"></script>
    <script src="jqwidgets/jqxdatatable.js"></script>
    <script src="jqwidgets/jqxtreegrid.js"></script>
    
    <script>
        $(document).ready(function() {
            function onSuccess(data) {
                var users = data.d;
                var source =
                {
                    dataType: "json",
                    dataFields: [
                        { name: 'UserType', type: 'string' },
                        { name: 'Name', type: 'string' },
                        { name: 'Phone', type: 'string' },
                        { name: 'CurrentBalance', type: 'number' },
                        { name: 'UserCode', type: 'string' },
                        { name: 'ParentCode', type: 'string' }
                    ],
                    hierarchy:
                    {
                        keyDataField: { name: 'UserCode' },
                        parentDataField: { name: 'ParentCode' }
                    },
                    id: 'UserCode',
                    localData: users
                };
                var dataAdapter = new $.jqx.dataAdapter(source);

                $("#treeGrid").jqxTreeGrid(
                {
                    width: 700,
                    height: 390,
                    source: dataAdapter,
                    ready: function () {
                        $("#treeGrid").jqxTreeGrid('expandRow', '2');
                    },
                    columns: [
                      { text: 'User Type', dataField: 'UserType', width: 150 },
                      { text: 'Name', dataField: 'Name', width: 150 },
                      { text: 'Phone', dataField: 'Phone', width: 200 },
                      { text: 'Current Balance', dataField: 'CurrentBalance', width: 200, cellsalign: 'right', cellsFormat: "c2" }
                    ]
                });
            }

            $.ajax({
                type: "GET",
                url: "jqxTreeGrid.aspx/GetData",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: onSuccess,
                failure: function(response) {
                    alert(response.d);
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div id="treeGrid"></div>
    </div>
    </form>
</body>
</html>
