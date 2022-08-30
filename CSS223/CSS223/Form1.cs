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
            dgv.DataSource = null;
            dgv.DataSource = Class1.getAll();
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
            errPro.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errPro.SetError(txt_number, "Number is required");
            }
            else if (string.IsNullOrEmpty(txt_inv.Text))
            {
                errPro.SetError(txt_inv, "Inventory number is required");
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                errPro.SetError(txt_price, "Price is required");
            }
            else if (string.IsNullOrEmpty(txt_count.Text))
            {
                errPro.SetError(txt_count, "Count is required");
            }
            else if (string.IsNullOrEmpty(txt_obj.Text))
            {
                errPro.SetError(txt_obj, "Object name is required");
            }
            else if (!r.IsMatch(txt_obj.Text))
            {
                errPro.SetError(txt_obj, "Object name should not have numbers");
            }
           
            else

            {
                try
                {
                    Class1 cl = new Class1
                    {
                        count = int.Parse(txt_count.Text),
                        price = int.Parse(txt_price.Text),
                        number = int.Parse(txt_number.Text),
                        object_name = txt_obj.Text,
                        inventorNum = int.Parse(txt_number.Text),
                        isAvailable= chkAvailability.Checked,
                        urgent = rbu.Checked,
                        notUrgent= rbnu.Checked
                        
                    };
                    cl.save();


                    foreach (var item in chklst.CheckedItems)
                    {
                        MessageBox.Show(item.ToString());

                    }


                    dgv.DataSource = null;
                    dgv.DataSource = Class1.getAll();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Type Mismatch");
                };
                txt_number.Text = "";
                txt_count.Text = "";
                txt_inv.Text = "";
                txt_price.Text = "";
                txt_obj.Text = "";
               chkAvailability.Checked = false;
                rbu.Checked = false;
                rbnu.Checked = false;
            }
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
            MessageBox.Show("Exit the form");
            System.Environment.Exit(0);
        }

        private void chklst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
