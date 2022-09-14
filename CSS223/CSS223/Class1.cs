using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public int price { get; set; }
        public int inventorNum { get; set; }
        public int count { get; set; }
        public string object_name { get; set; }
        public bool isAvailable { get; set; }
        public bool urgent { get; set; }
        public bool notUrgent { get; set; }
        
        public void save()
        {
            String path = @"Server= DESKTOP-7K9R4KU\SQLEXPRESS; Database = csharpdb; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(path);
            string query = "Insert into dbtable values('" + this.number + "','" + this.price + "','" + this.inventorNum + "','" + this.count + "','" + this.object_name + "');"; 
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            };
            conn.Close();
            MessageBox.Show("Saved successfully");
            Products.Add(this);
        }
        public static List <Class1> getAll()
        {
            List<Class1> list = new List<Class1>();
            String path = @"Server= DESKTOP-7K9R4KU\SQLEXPRESS; Database = csharpdb; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(path);
            string query = "Select * from dbtable;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Class1 item = new Class1();
                    item.number = (int)dr["num"];
                    item.price = (int)dr["price"];
                    item.inventorNum = (int)dr["invnum"];
                    item.count = (int)dr["ct"];
                    item.object_name = (string)dr["objnume"];
                    Products.Add(item);
                }
            }catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            };
            conn.Close();
            return Products;
        }
        public static Class1 findOne(string name)
        {
            String path = @"Server= DESKTOP-7K9R4KU\SQLEXPRESS ; Database = csharpdb; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(path);
            string query = "Select * from dbtable;";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Class1 item = new Class1();
                    item.number = (int)dr["num"];
                    item.price = (int)dr["price"];
                    item.inventorNum = (int)dr["invnum"];
                    item.count = (int)dr["ct"];
                    item.object_name = (string)dr["objnum"];
                    Products.Add(item);
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            };
            conn.Close();
            return Products.Find(a=> a.object_name == name);
        }
    }
}
