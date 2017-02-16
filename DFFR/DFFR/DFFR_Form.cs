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
            //DataTable Output= new DataTable();
            //Output.Columns.Add("Path ", typeof (string));
            //Output.Columns.Add("Name ", typeof(string));
            //Output.Columns.Add("Type ", typeof(string));
           

           List<string> myelements = new List<string>();
            string name;
            string path;
            int count = 0;
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
                        
                    }
                    count += 1;
                    
                }
            }

            MessageBox.Show(count.ToString());

           
          
           

            //---------------------------------------------------------

        }

        
    }
}
