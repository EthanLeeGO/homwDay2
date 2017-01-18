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

      
       

        protected void Button1_Click(object sender, EventArgs e)
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

           


            // books.GroupBy(x => x.book).Count() / books.Sum(x => x.quantity)
            Double total = 0;
            int package = 1;
            while (books.Any(x => x.quantity >= package))
            {
                var pack= books.Where(x => x.quantity >= package);

                double discount = 1;

                if (pack.Count() == 2)
                {
                    discount = 0.95;
                }
                if (pack.Count() == 3)
                {
                    discount = 0.9;
                }
                if (pack.Count() == 4)
                {
                    discount = 0.8;
                }
                if (pack.Count() == 5)
                {
                    discount = 0.75;
                }

                total +=pack.Sum(x=>x.book.price)  * discount;
                package++;
            }



           


            //var total=books.Sum(x=>x.quantity)*discount*100;


            txtTotal.Text = total.ToString();
        }
    }
}