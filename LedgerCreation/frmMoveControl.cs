using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedgerCreation
{
    public partial class frmMoveControl : Form
    {
        public frmMoveControl()
        {
            InitializeComponent();
        }

        private void frmMoveControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X == textBox1.Location.X - 1 && (e.Y >= textBox1.Location.Y - 1 && e.Y <= textBox1.Location.Y + textBox1.Height + 1))
            {
                textBox1.SetBounds(textBox1.Location.X + 5, textBox1.Location.Y, 75, 23);
            }
            if (e.X == textBox1.Location.X + textBox1.Width + 1 && (e.Y >= textBox1.Location.Y - 1 && e.Y <= textBox1.Location.Y + textBox1.Height + 1))
            {
                textBox1.SetBounds(textBox1.Location.X - 5, textBox1.Location.Y, 75, 23);
            }
            if (e.Y == textBox1.Location.Y - 1 && (e.X >= textBox1.Location.X - 1 && e.X <= textBox1.Location.X + textBox1.Width + 1))
            {
                textBox1.SetBounds(textBox1.Location.X, textBox1.Location.Y + 5, 75, 23);
            }
            if (e.Y == textBox1.Location.Y + textBox1.Height + 1 && (e.X >= textBox1.Location.X - 1 && e.X <= textBox1.Location.X + textBox1.Width + 1))
            {
                textBox1.SetBounds(textBox1.Location.X, textBox1.Location.Y - 5, 75, 23);
            }
            if (textBox1.Location.X >= this.Width - textBox1.Width - 1)
            {
                textBox1.SetBounds(1, textBox1.Location.Y, 75, 23);
            }
            if (textBox1.Location.X <= 1)
            {
                textBox1.SetBounds(textBox1.Location.X + textBox1.Width + 1, textBox1.Location.Y, 75, 23);
            }

        }

        private void frmMoveControl_Load(object sender, EventArgs e)
        {

        }
    }
}
