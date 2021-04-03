using System;
using System.Drawing;
using System.Windows.Forms;

namespace Automated_Teller_Machine
{
    public partial class FormSelectLanguage : Form
    {
        public FormSelectLanguage()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void fa_Click(object sender, EventArgs e)
        {
            //false value when user select farsi
            Program.lang = false;
            FormCardCheck f2 = new FormCardCheck();
            Hide();
            f2.ShowDialog();
            Close();
        }

        private void en_Click(object sender, EventArgs e)
        {
            //true value when user select english
            Program.lang = true;
            FormCardCheck f2 = new FormCardCheck();
            Hide();
            f2.ShowDialog();
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
