using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Security;
using WebAppAspNet.Models;

namespace WebAppAspNet
{
    public partial class Clienti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {


                using (var ctx = new NorthwindEntities())
                {

                    //var customers1 = from c in ctx.Customers
                    //                 where c.Country == "Italy"
                    //                 select c;

                    // DropDownList3.DataSource = ctx.Customers.Local.ToBindingList();

                    //var customer2 = ctx.Customers.Where(c => c.Country == "Italy");
                    //DropDownList3.DataSource = customer2.ToList();
                    //DropDownList3.DataTextField = "ContactName";
                    //DropDownList3.DataValueField = "CustomerID";
                    //DropDownList3.DataBind();


                    cbCountry.DataSource = ctx.Customers
                        .Select(c => new { c.Country })
                        .Distinct()
                        .OrderBy(p => p.Country).ToList(); ;
                    cbCountry.DataTextField = "Country";
                    cbCountry.DataValueField = "Country";
                    cbCountry.DataBind();
                }


            }
            else
            {

            }

            //string[] list = new string[] { "Elemento 1", "Elemento 2", "Elemento 3" };
            //DropDownList1.DataSource = list;
            //DropDownList1.DataBind();

            //DropDownList2.DataSource = SqlDataSource1;
            //DropDownList2.DataBind();
        }

        public IQueryable<Customers> GetCustomers()
        {
            var customers = new NorthwindEntities().Customers;
            return customers;
        }

       

        void FillGrid(int blocco)
        {
            var ctx = new NorthwindEntities();

            // Call the Load method to get the data for the given DbSet
            // from the database.
            // The data is materialized as entities. The entities are managed by
            // the DbContext instance.
            ctx.Customers.Load();

            //var customers1 = from c in ctx.Customers
            //                 where c.Country == "Italy"
            //                 select c;


            //DropDownList3.DataSource = customer2.ToList();
            //DropDownList3.DataTextField = "ContactName";
            //DropDownList3.DataValueField = "CustomerID";
            //DropDownList3.DataBind();


            // Bind the categoryBindingSource.DataSource to
            // all the Unchanged, Modified and Added Category objects that
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.

            //    GridView1.DataSource = ctx.Customers.Local.ToBindingList();

            var customer2 = ctx.Customers
                    .Where(c => (this.cbCountry.SelectedValue != "" ? (c.Country == this.cbCountry.SelectedValue) : true))
                    .Where(c => (!this.txContactName.Text.Equals("") ? (c.ContactName.Contains(this.txContactName.Text.Trim())) : true));
            //var myCount = customer2.Count();
            //var customer3 = customer2.Take(10);

            gvCustomer.DataSource = customer2.ToList();
            

            blocco += 1;
            gvCustomer.Caption = "Pagina " + blocco + " Totale: " + customer2.ToList().Count();
            gvCustomer.CaptionAlign = TableCaptionAlign.Top;
            //Filling & Binding the gridview.  
            gvCustomer.DataBind();
            //Very simple and straight forward code.  
        }
    
     
        protected void btCustomerFilter_Click(object sender, EventArgs e)
        {
            FillGrid(0);
        }

        protected void gvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FillGrid(e.NewPageIndex);
            gvCustomer.PageIndex = e.NewPageIndex;
            gvCustomer.DataBind();
        }

       
        protected void gvCustomer_Sorting(object sender, GridViewSortEventArgs e)
        {
            gvCustomer.DataBind();
        }
    }
}