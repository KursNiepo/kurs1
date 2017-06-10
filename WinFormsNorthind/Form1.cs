using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNorthind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWNDDataSet.Orders);
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nORTHWNDDataSet.Customers);




        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Details okienko2 = new Details();
            okienko2.ShowDialog();
        }
    }
}
