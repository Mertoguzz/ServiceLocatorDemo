using Core;
using System;
using System.Windows.Forms;

namespace WebDemo
{
    public partial class frmDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var result = ServiceLocator.ServiceLocator.Create<IProductService>().GetProductName(5);
            var result = ServiceLocator.ServiceLocator.Create<IProductService, Product>().GetProductName(5);
            MessageBox.Show(result);
        }
    }
}