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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach (var item in Class1.getAll())
            {
                product_card pc = new product_card();
                pc.MyObjName = item.object_name;
                pc.MyPrice = item.price;
                flp.Controls.Add(pc);
            }
        }

    }
}
