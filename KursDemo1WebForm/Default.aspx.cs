using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KursDemo1WebForm.Models;

namespace KursDemo1WebForm
{
    public partial class Default : System.Web.UI.Page {
        private List<Person> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonRepo repo = new PersonRepo();
            lista = repo.GetAll();
        }

        protected void Button1_Click(object sender, EventArgs e) {
            lbWynik.Text = "Witaj " + tbImie.Text;
        }
    }
}