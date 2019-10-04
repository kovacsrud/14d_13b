namespace Fahrenheit
{
    partial class formFokszamitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFokjel = new System.Windows.Forms.Label();
            this.textBoxFok = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.comboBoxLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(625, 208);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(120, 17);
            this.radioButtonCelsius.TabIndex = 0;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius Fahrenheitre";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            this.radioButtonCelsius.CheckedChanged += new System.EventHandler(this.radioButtonCelsius_CheckedChanged);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(625, 185);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(120, 17);
            this.radioButtonFahrenheit.TabIndex = 1;
            this.radioButtonFahrenheit.TabStop = true;
            this.radioButtonFahrenheit.Text = "Fahrenheit Celsiusra";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            this.radioButtonFahrenheit.Click += new System.EventHandler(this.radioButtonFahrenheit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hőfok";
            // 
            // labelFokjel
            // 
            this.labelFokjel.AutoSize = true;
            this.labelFokjel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFokjel.Location = new System.Drawing.Point(139, 51);
            this.labelFokjel.Name = "labelFokjel";
            this.labelFokjel.Size = new System.Drawing.Size(0, 26);
            this.labelFokjel.TabIndex = 3;
            // 
            // textBoxFok
            // 
            this.textBoxFok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFok.Location = new System.Drawing.Point(263, 51);
            this.textBoxFok.Name = "textBoxFok";
            this.textBoxFok.Size = new System.Drawing.Size(312, 32);
            this.textBoxFok.TabIndex = 4;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzamol.Location = new System.Drawing.Point(500, 197);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(94, 28);
            this.buttonSzamol.TabIndex = 5;
            this.buttonSzamol.Text = "Számolás";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEredmeny.Location = new System.Drawing.Point(257, 118);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(0, 31);
            this.labelEredmeny.TabIndex = 6;
            // 
            // comboBoxLista
            // 
            this.comboBoxLista.FormattingEnabled = true;
            this.comboBoxLista.Items.AddRange(new object[] {
            "egy",
            "kettő",
            "három"});
            this.comboBoxLista.Location = new System.Drawing.Point(49, 118);
            this.comboBoxLista.Name = "comboBoxLista";
            this.comboBoxLista.Size = new System.Drawing.Size(157, 21);
            this.comboBoxLista.TabIndex = 7;
            // 
            // formFokszamitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 261);
            this.Controls.Add(this.comboBoxLista);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.textBoxFok);
            this.Controls.Add(this.labelFokjel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFahrenheit);
            this.Controls.Add(this.radioButtonCelsius);
            this.Name = "formFokszamitas";
            this.Text = "Hőfok átszámítás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFokjel;
        private System.Windows.Forms.TextBox textBoxFok;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.ComboBox comboBoxLista;
    }
}

