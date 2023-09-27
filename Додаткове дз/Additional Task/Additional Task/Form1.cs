using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additional_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.FromArgb(68, 113, 114);
            Exit.BackColor = Color.FromArgb(135, 227, 228);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.FromArgb(34, 57, 57);
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Exit.BackColor = Color.FromArgb(101, 170, 171);
            Exit.ForeColor = Color.FromArgb(34, 57, 57);
        }

        private void NoBut_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(0, 260);
            int newY = random.Next(122, 506);
            NoBut.Location = new Point(newX, newY);
        }

        private void YesBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Звичайно, як може не подобатись аж 1980 грн на місяць за виконання мільйон дз на день))))))))");
        }
    }    
}
