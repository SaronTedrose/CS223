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
    public partial class DetailsPage : Form
    {
        public DetailsPage(int n, int i, int c)
        {
            InitializeComponent();
            label1.Text = "The number is" + n.ToString();
            label2.Text = "The inventory number is" + i.ToString();
            label3.Text = "The count is" + c.ToString();
        }
    }
}
