using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            XPoint.Text = "Enter X value";
            XPoint.ForeColor = Color.Gray;
            YPoint.Text = "Enter Y value";
            YPoint.ForeColor = Color.Gray;
        }


        //Кнопка для виходу
        private void ExitBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBut_MouseEnter(object sender, EventArgs e)
        {
            ExitBut.ForeColor = Color.FromArgb(191, 188, 165);
        }

        private void ExitBut_MouseLeave(object sender, EventArgs e)
        {
            ExitBut.ForeColor = Color.FromArgb(255, 251, 220);
        }


        //Координати Х та У
        private void XPoint_MouseEnter(object sender, EventArgs e)
        {
            if(XPoint.Text == "Enter X value")
            {
                XPoint.Text = "";
                XPoint.ForeColor = Color.FromArgb(32, 31, 27);
            }
        }
        private void XPoint_MouseLeave(object sender, EventArgs e)
        {
            if (XPoint.Text == "")
            {
                XPoint.Text = "Enter X value";
                XPoint.ForeColor = Color.Gray;
            }            
        }

        private void YPoint_MouseEnter(object sender, EventArgs e)
        {
            if(YPoint.Text == "Enter Y value")
            {
                YPoint.Text = "";
                YPoint.ForeColor = Color.FromArgb(32, 31, 27);
            }
        }

        private void YPoint_MouseLeave(object sender, EventArgs e)
        {
            if (YPoint.Text == "")
            {
                YPoint.Text = "Enter Y value";
                YPoint.ForeColor = Color.Gray;
            }
        }


        //Перевірка введених координат та переміщення точки
        private void StartBut_Click(object sender, EventArgs e)
        {
            int numberx;
            int numbery;
            if (XPoint.Text == "Enter X value" || !(int.TryParse(XPoint.Text, out numberx)) || numberx < -150 || numberx > 150 || YPoint.Text == "Enter Y value" || !(int.TryParse(YPoint.Text, out numbery)) || numbery < -150 || numbery > 150)
            {   if (XPoint.Text == "Enter X value") MessageBox.Show("Помилка: Ви нічого не ввели в значення координати Х");
                else if (!(int.TryParse(XPoint.Text, out numberx))) MessageBox.Show("Помилка: Ви ввели не число для значення Х");
                else if (numberx < -150 || numberx > 150) MessageBox.Show("Помилка: Координата Х більше 150 або менша -150");
                if (YPoint.Text == "Enter Y value") MessageBox.Show("Помилка: Ви нічого не ввели в значення координати Y");
                else if (!(int.TryParse(YPoint.Text, out numbery))) MessageBox.Show("Помилка: Ви ввели не число для значення Y");
                else if (numbery < -150 || numbery > 150) MessageBox.Show("Помилка: Координата Y більше 150 або менша -150"); 
            }else
            {
                Point.Location = new Point(588 + numberx, 223 - numbery);
                if(numberx >0 && numberx <151 && numbery >0 && numbery<151)
                    MessageBox.Show($"X: {numberx}, Y: {numbery}, \nКоордината розташована у першій чверті");
                else if (numberx < 0 && numberx > -151 && numbery > 0 && numbery < 151)
                    MessageBox.Show($"X: {numberx}, Y: {numbery}, \nКоордината розташована у другій чверті");
                else if (numberx < 0 && numberx > -151 && numbery < 0 && numbery > -151)
                    MessageBox.Show($"X: {numberx}, Y: {numbery}, \nКоордината розташована у третій чверті");
                else if (numberx > 0 && numberx < 151 && numbery < 0 && numbery > -151)
                    MessageBox.Show($"X: {numberx}, Y: {numbery}, \nКоордината розташована у четвертій чверті");
            }
            
        }
    }
}
