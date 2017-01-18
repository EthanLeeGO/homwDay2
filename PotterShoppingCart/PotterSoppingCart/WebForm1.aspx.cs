using booklib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static booklib.Order;

namespace PotterSoppingCart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        private List<Order> getBooks()
        {
            List<Order> books = new List<Order>();

            //Order bookorder = new Order();
            if (!string.IsNullOrEmpty(txtPotter1.Text))
            {
                books.Add(new Order() { book = new Potter1(), quantity = int.Parse(txtPotter1.Text) });
            }
            if (!string.IsNullOrEmpty(txtPotter2.Text))
            {
                books.Add(new Order() { book = new Potter2(), quantity = int.Parse(txtPotter2.Text) });
            }
            if (!string.IsNullOrEmpty(txtPotter3.Text))
            {
                books.Add(new Order() { book = new Potter3(), quantity = int.Parse(txtPotter3.Text) });
            }
            if (!string.IsNullOrEmpty(txtPotter4.Text))
            {
                books.Add(new Order() { book = new Potter4(), quantity = int.Parse(txtPotter4.Text) });
            }
            if (!string.IsNullOrEmpty(txtPotter5.Text))
            {
                books.Add(new Order() { book = new Potter5(), quantity = int.Parse(txtPotter5.Text) });
            }
            return books;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            var books = getBooks();


            txtTotal.Text = calculate.CalBooks(books).ToString();
           
        }

      
    }
}