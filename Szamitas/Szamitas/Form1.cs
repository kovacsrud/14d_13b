using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamitas
{
    public partial class formSzamolo : Form
    {
        public formSzamolo()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                var d = (Convert.ToInt32(textBoxA.Text) + Convert.ToInt32(textBoxB.Text)) / Convert.ToInt32(textBoxC.Text);
                labelEredmeny.Text = Convert.ToString(d);
                
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("0-val való osztás hiba!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("A mezőkbe számot kell megadni!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Általános hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
