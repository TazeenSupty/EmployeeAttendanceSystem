<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Empats.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
     <div>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
    <div>
        <table>
            <tr>
                <td>

                    <asp:Label ID="Label5" runat="server" Text="Employee ID"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empId" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>

                    <asp:Label ID="Label6" runat="server" Text="Employee Username"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empUsername" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>

                    <asp:Label ID="Label7" runat="server" Text="Employee Password"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empPassword" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>

                    <asp:Label ID="lblTitle" runat="server" Text="Employee Name"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empName" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Employee Designation"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empDesignation" runat="server"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>

                    <asp:Label ID="Label1" runat="server" Text="Employee Email"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empEmail" runat="server"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>

                    <asp:Label ID="Label2" runat="server" Text="Employee Address"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empAddress" runat="server"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>

                    <asp:Label ID="Label4" runat="server" Text="Employee Age"></asp:Label>

                </td>
                <td>

                    <asp:TextBox ID="tbx_empAge" runat="server"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>
                    <br />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></asp:Button>
                    <asp:Button ID="btn_edit" runat="server" Height="24px" OnClick="btn_edit_Click" Text="Edit" Width="48px" />
                    <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" />
                </td>
            </tr>
        </table>
    </div>

    
    <div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>                
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
