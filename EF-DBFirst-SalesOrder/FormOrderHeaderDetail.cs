using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DBFirst_SalesOrder
{
    public partial class FormOrderHeaderDetail : Form
    {
        public FormOrderHeaderDetail(int girilenID)
        {
            InitializeComponent();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertOrderDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrderDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {

        }

        private void FormOrderHeaderDetail_Load(object sender, EventArgs e)
        {
            NorthwindEntitiesConnectionString db = new NorthwindEntitiesConnectionString();
            
        }
    }
}
