using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Int32 valor()
        {
            var i = 1 + 1;
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.Configuration.ConfigurationManager.AppSettings["Nome"].ToString();
        }
    }
}
