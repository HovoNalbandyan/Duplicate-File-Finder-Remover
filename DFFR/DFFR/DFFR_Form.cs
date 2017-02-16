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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> myelements = new List<string>();

            string name;
            string path;
            path = textBox1.Text;
            name = textBox2.Text;
            if (path == null)
            {
                MessageBox.Show("Input Path");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            {
                FileInfo[] arr = di.GetFiles();
                foreach (FileInfo file in arr)
                {
                    if (file.Name == name)
                    {
                        myelements.Add(name);
                    }
                }
            }
            else
            {
                MessageBox.Show("input Right path   ");
                textBox1.Text = "";
            }
               

        }
    }
}
