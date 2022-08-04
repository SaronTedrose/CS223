using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS223
{
    internal class Class1
    {
        public static List<Class1> Products = new List<Class1>();
        public int number { get; set; }
        public double price { get; set; }
        public int inventorNum { get; set; }
        public int count { get; set; }
        public string object_name { get; set; }
        public bool isAvailable { get; set; }
        public bool urgent { get; set; }
        public bool notUrgent { get; set; }
        
        public void save()
        {
            MessageBox.Show("Saved successfully");
            Products.Add(this);
        }
        public static List <Class1> getAll()
        {
            return Products;
        }

    }
}
