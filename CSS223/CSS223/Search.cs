using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS223
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = Class1.findOne(txtSearch.Text);
            //p returns the list if match is found
            //returns nothing if match is not found
            if (p == null)
            {
                MessageBox.Show("Match is not found");
            }
            else
            {
                MessageBox.Show("Match is found");
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
