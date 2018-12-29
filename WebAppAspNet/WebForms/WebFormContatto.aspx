<%@ Page Title="Scheda contatto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormContatto.aspx.cs" Async="true"
    Inherits="WebAppAspNet.WebFormContatto" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script type="text/javascript">
        $(document).ready(function () {


            // executes when HTML-Document is loaded and DOM is ready
            // alert("document is ready");


            //  Explanation:
            //  jQuery has provided its different wild card operators which we can use to search ASP.Net Server Controls whose ClientID changes when Master Pages are used. Also it will help users find ASP.Net Server controls from external JS files.
            //  [id$=Button1] – (Ends With) Will match the suffix i.e. the ID must end with the search string
            //  [id^=Button1] – (Starts With) Will match the prefix i.e. the ID must start with the search string
            //  [id *= Button1]– (Contains) Will search for the match search string in the whole ID

            var button = $("[id$=Button1]");
            var textbox = $("[id$=lbValore]");
            textbox.css("font-size", "30px");

            console.log(button.attr("id"));
            console.log(textbox.attr("id"));


        });
    </script>
    <div>
        <h1>Scheda contatto</h1>
        <p class="lead">Io sono ....</p>

    </div>

    <ul class="nav nav-tabs">
        <li class="nav-item">
            <a class="nav-link active" href="#">Active</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="#">Link 1</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="#">Link 2</a>
        </li>
        <li class="nav-item">
            <a class="nav-link disabled" href="#">Disabled</a>
        </li>
    </ul>

    <p>
        <a class="btn btn-primary" data-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample">Link with href
        </a>
        <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
            Button with data-target
        </button>
    </p>
    <div class="collapse" id="collapseExample">
        <div class="card card-body" style="background-color: lightblue;">
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 
            Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
            <br />

        </div>
        <asp:Label runat="server" ID="lbValore"
            Text="<%$ AppSettings:MioValore %>" />
    </div>

    <div class="row align-items-start" style="border-width: 1px;">
        <div class="row">
            <div class="col">
                <asp:Label runat="server" AssociatedControlID="cbCountry">Paese</asp:Label>
            </div>
            <div class="col">
                <asp:DropDownList ID="cbCountry" runat="server"
                    DataTextFormatString="- {0}"
                    AppendDataBoundItems="true">
                    <asp:ListItem Value=""> - seleziona -       </asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:Label runat="server" AssociatedControlID="txContactName">Ragione sociale</asp:Label>
            </div>
            <div class="col">
                <asp:TextBox ID="txContactName" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <div class="col" style="padding-top: 10px; padding-bottom: 10px;">
                    <asp:Button ID="Button2" runat="server" Text="Applica su Grid" OnClick="Button2_Click" />
                </div>

            </div>
        </div>

        <div class="row">
            <div class="col">
                <asp:GridView ID="GridView1" TabIndex="12000" runat="server" CellPadding="4" Width="335px"
                    ItemType="Model1.Customer" AllowPaging="true" ForeColor="#333333"
                    GridLines="Both" OnPageIndexChanging="Grid1View_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" OnRowCommand="GridView1_RowCommand" Caption="ELENCO">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerSettings Position="TopAndBottom" />
                    <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                </asp:GridView>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <br />
                <asp:DetailsView ID="DetailsView1" runat="server"
                    SelectMethod="GetCustomers" DataKeyNames="CustomerID"
                    AutoGenerateRows="False" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="332px" Caption="DETTAGLIO">
                    <AlternatingRowStyle BackColor="White" />
                    <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
                    <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
                    <Fields>
                        <asp:BoundField DataField="CustomerID"
                            HeaderText="ID" ReadOnly="True" SortExpression="CustomerID" />
                        <asp:BoundField DataField="CompanyName"
                            HeaderText="Società" SortExpression="CompanyName" />
                        <asp:BoundField DataField="ContactName"
                            HeaderText="Nome" SortExpression="ContactName" />
                        <asp:BoundField DataField="Phone"
                            HeaderText="Telefono" SortExpression="Phone" />
                        <asp:CommandField CancelText="Annulla" DeleteText="Elimina"
                            EditText="Modifica" UpdateText="Aggiorna"
                            ShowEditButton="True" ShowDeleteButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                </asp:DetailsView>
            </div>
        </div>

      <%--  <div class="row">
            <div class="col">
                <br />
                <asp:FormView ID="FormView1" runat="server"
                    SelectMethod="GetCustomers" DataKeyNames="CustomerID"
                    AutoGenerateRows="False" AllowPaging="True" CellPadding="4" ForeColor="#333333" Width="332px" Caption="FORM ">

                    <EditRowStyle BackColor="#7C6F57" />

                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />


                    <EditItemTemplate>
                    </EditItemTemplate>
                    <FooterTemplate></FooterTemplate>
                    <HeaderTemplate></HeaderTemplate>
                    <InsertItemTemplate></InsertItemTemplate>
                    <ItemTemplate>

                            <asp:TextBox Text='<%# BindItem.CompanyName %>'
                                ID="CompanyName" runat="server" />
                            <asp:TextBox Text='<%# BindItem.Country %>'
                                ID="Country" runat="server" />
                            <asp:TextBox Text='<%# Binditem.City %>'
                                ID="City" runat="server" />
                            <asp:TextBox Text='<%# BindItem.Country %>'
                                ID="TextBox1" runat="server" />
                            <asp:LinkButton ID="UpdateButton" runat="server"
                                CommandName="Update" Text="Aggiorna" />
                            <asp:LinkButton ID="CancelButton" runat="server"
                                CommandName="Cancel" Text="Annulla" />

                    </ItemTemplate>

                </asp:FormView>
            </div>
        </div>--%>

    </div>
    <br />

    <br />
    <asp:PlaceHolder ID="Inputs" runat="server">
        <div class="row align-items-start" style="border-width: 1px;">
            <div class="col-sm-2">Nome:</div>
            <div class="col-sm-10">
                <asp:TextBox ID="FirstName" Style="margin-bottom: 10px;" runat="server" />
            </div>
            <div class="col-sm-2">Cognome:</div>
            <div class="col-sm-10">
                <asp:TextBox ID="SecondName" Style="margin-bottom: 10px;" runat="server" />
            </div>

            <div class="col">
                <div class="col-sm">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Nome e Cognome" />
                </div>

            </div>
            <div class="col">
                <div class="col-sm">
                    <asp:DropDownList ID="DropDownList1" Style="margin-top: 10px;" runat="server" />
                </div>

                <div class="col-sm">
                    <asp:DropDownList ID="DropDownList2"
                        DataTextField="CompanyName"
                        DataTextFormatString="- {0}"
                        DataValueField="CustomerID"
                        AppendDataBoundItems="true" runat="server" ItemType="MyModel.Customer">
                        <asp:ListItem Value="server"> - seleziona -
                        </asp:ListItem>
                    </asp:DropDownList>

                </div>
            </div>
        </div>
    </asp:PlaceHolder>

    <asp:PlaceHolder ID="Results" runat="server" Visible="false">
        <div class="row">
            Hai detto di chiamarti:
            <asp:Label ID="ResultsName" runat="server" />
        </div>
    </asp:PlaceHolder>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>







    </div>







</asp:Content>

