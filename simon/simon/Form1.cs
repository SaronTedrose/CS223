namespace simon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Form active = this.ActiveMdiChild;

            if(ActiveMdichild != null)
            {
                ActiveMdichild.close();
            }

          //  productToolStripMenuItem from = new productToolStripMenuItem();
            Form.Form1= this;
            Form.show();
        }
    }
}