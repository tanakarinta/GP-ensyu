using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubSystem
{
    public partial class Main_menu : Form
    {
        Sub_menu sub = new Sub_menu();
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub.Show();
        }
    }
}
