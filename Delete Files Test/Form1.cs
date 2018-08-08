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

namespace Delete_Files_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String path = textBox1.Text;

            if (!Directory.Exists(path)) {
                MessageBox.Show("Directory doesn't exist.");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(path);

            //MessageBox.Show((di.GetFiles().Length).ToString());

            foreach (FileInfo file in di.GetFiles()) {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories()) {
                dir.Delete(true);
            }
        }
    }
}
