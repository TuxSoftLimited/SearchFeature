<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SearchFeature</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <br />
        <div class="row">
            <div class="col-lg-5 col-md-5 col-sm-6 col-xs-12 col-lg-push-7 col-md-push-7 col-sm-push-6">
                <form class="form-group form-horizontal" id="Form" runat="server">
                    <div class="input-group">
                        <asp:label class="control-label form-horizontal input-group-addon" runat="server">Search:</asp:label>
                        <asp:textBox class="form-control form-horizontal" runat="server" id="SearchTextBox" />
                    </div>
                </form>
            </div>
        </div>
        <br />
        <div class="row" id="DisplayItems" runat="server">
            <!-- This is where your search results turn up.  Don't add anything here. -->
        </div>
        <hr />
    </div>
</body>
<script src="Scripts/jquery-3.1.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
</html>
