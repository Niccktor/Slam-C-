using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("bonjour", "test", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
