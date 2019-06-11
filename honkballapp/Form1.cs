using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace honkballapp
{
    public partial class Form1 : Form
    {
        Competitie MLB = new Competitie("MLB", 2019, "MLB");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            listBox1.DataSource = MLB.teams;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox2.DataSource = MLB.teams[index].spelers;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
