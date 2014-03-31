using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace SportsStore.Pages
{
    public partial class Testing : System.Web.UI.Page
    {

        string[] animals = new string[] { "Wandile", "Diba", "Jele", "Spider", "Wombat", "Snake", "Emu", "Shark", "Sting-Ray", "Jelly-Fish" };

        protected void Page_Load(object sender, EventArgs e)
        {
            
            var data = from b in animals
                       select animals;



        }


    }
}