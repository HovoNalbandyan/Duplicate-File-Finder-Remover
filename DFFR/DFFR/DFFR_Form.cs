using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace DFFR
{

   
    public partial class DFFR_Form : Form
    {

        //static DataTable GetTable()
        //{
        //    // Here we create a DataTable with four columns.
        //    DataTable table = new DataTable();        

        //    // Here we add five DataRows.
        //    table.Rows.Add(25, "Indocin", "David", DateTime.Now);
        //    table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
        //    table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
        //    table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
        //    table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
        //    DataTable Output = new DataTable();
        //    Output.Columns.Add("Path ", typeof(string));
        //    Output.Columns.Add("Name1 ", typeof(string));
        //    Output.Columns.Add("Type ", typeof(string));
        //    return table;
        //}
        public DFFR_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> myelements = new List<string>();
            string name;                    //Name of value
            string path;                   //Path for searching
            int count = 0;                //Count of duplicate member
            path = textBox1.Text;
            name = textBox2.Text;
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] arr = di.GetFiles();
            if (path == null)
            {
                MessageBox.Show("Input Path");
                textBox1.Text = "";
            }
            else
            if (name == null)
            {
                MessageBox.Show("Input Name");
                textBox2.Text = "";
            }

            if (di.Exists)
            {
                foreach (FileInfo file in arr)
                {
                    if (name == file.Name)
                    {
                        myelements.Add(Name);
                        count += 1;
                    }
                    
                }
                MessageBox.Show(count.ToString());
            }
            else
                MessageBox.Show(count.ToString());
            //foreach (DataRow row in GetTable().Rows)
            //{
            //    // Get first field by column index.
            //    int weight = row.Field<int>(0);

            //    // Get second field by column name.
            //    string name1 = row.Field<string>("Name");

            //    // Get third field by column index.
            //    string code = row.Field<string>(2);

            //    // Get fourth field by column name.
            //    DateTime date = row.Field<DateTime>("Date");

            //    // Display the fields.
            //    Console.WriteLine("{0} {1} {2} {3}", weight, name1, code, date);
            //}



            //---------------------------------------------------------

        }


    }
}
