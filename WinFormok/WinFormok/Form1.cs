using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormok
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
            labelUzenet2.Text = "_default";
            textBoxInput.Text = "ide kell írni";
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUdv_Click(object sender, EventArgs e)
        {
            labelUzenet2.Text = textBoxInput.Text;
        }
    }
}
