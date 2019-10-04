using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit
{
    public partial class formFokszamitas : Form
    {
        List<string> helyisegek = new List<string>() { "Gyula", "Orosháza", "Tompa" };

        public formFokszamitas()
        {
            InitializeComponent();
            radioButtonFahrenheit.Checked = true;
            labelFokjel.Text = "F";
            comboBoxLista.Items.Clear();
            comboBoxLista.Items.AddRange(helyisegek.ToArray());
        }

        private void radioButtonFahrenheit_Click(object sender, EventArgs e)
        {
            labelFokjel.Text = "F";
        }

        private void radioButtonCelsius_CheckedChanged(object sender, EventArgs e)
        {
            labelFokjel.Text = "C";
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try { 
            if (radioButtonFahrenheit.Checked)
            {
                
                var fok = (Convert.ToDouble(textBoxFok.Text) - 32) / 1.8000;
                Debug.WriteLine(fok);
                labelEredmeny.Text = Convert.ToString(fok)+ " Celsius fok";
            }
            if (radioButtonCelsius.Checked)
            {
                var fok = (Convert.ToInt32(textBoxFok.Text) * 1.8000) + 32;
                Debug.WriteLine(fok);
                labelEredmeny.Text = Convert.ToString(fok) + " Fahrenheit fok";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
