<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="Empats.Attendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 155px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
    <div>
        <table>
             <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Attendance ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbx_attendanceId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Employee ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbx_empId" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbx_date" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Arrive"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbx_arrive" runat="server" TextMode="Time"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Leave"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tbx_leave" runat="server" TextMode="Time"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"> <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></asp:Button></td>
        </tr>
            <tr>
                <td>

                    <asp:Button ID="btn_edit" runat="server" Height="24px" OnClick="btn_edit_Click" Text="Edit" Width="48px" />
                    <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" />

                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    <br />
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
