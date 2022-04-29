using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri_Masini
{
    public partial class Interfata : Form
    {
        public Interfata()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Utilizator: {0} \n Parola: {1}", txtUtilizator.Text, txtParola.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
