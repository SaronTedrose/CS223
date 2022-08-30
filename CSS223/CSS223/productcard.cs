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
    public partial class product_card : UserControl
    {

        private string _MyObjName;

        public string MyObjName
        {
            get { return _MyObjName; }
            set { _MyObjName = value; label1.Text = value; }
        }
        private double _MyPrice;

        public double MyPrice
        {
            get { return _MyPrice; }
            set { _MyPrice = value; label2.Text = value.ToString(); }
        }

       
        public product_card()
        {
            InitializeComponent();
        }

        private void product_card_Load(object sender, EventArgs e)
        {

        }
    }
}
