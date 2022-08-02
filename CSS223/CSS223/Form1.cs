using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSS223;

namespace CSS223
{
    public partial class Form1 : Form
    {
        private object txtNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumbr_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1
            {
                count = int.Parse(txt_count.Text),
                price = int.Parse(txt_price.Text),
                number = int.Parse(txt_number.Text),
                object_name = txt_obj.Text,
                inventorNum = int.Parse(txt_number.Text)
            };
            cl.save();
            dgv.DataSource = null;
            dgv.DataSource = Class1.getAll();
            


        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObjectName_Click(object sender, EventArgs e)
        {

        }

        private void txt_obj_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
