namespace WinFormok
{
    partial class formStart
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
            this.labelUzenet2 = new System.Windows.Forms.Label();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.buttonUdv = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUzenet2
            // 
            this.labelUzenet2.AutoSize = true;
            this.labelUzenet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUzenet2.Location = new System.Drawing.Point(219, 9);
            this.labelUzenet2.Name = "labelUzenet2";
            this.labelUzenet2.Size = new System.Drawing.Size(0, 76);
            this.labelUzenet2.TabIndex = 0;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKilepes.Location = new System.Drawing.Point(570, 214);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(96, 35);
            this.buttonKilepes.TabIndex = 1;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // buttonUdv
            // 
            this.buttonUdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUdv.Location = new System.Drawing.Point(12, 214);
            this.buttonUdv.Name = "buttonUdv";
            this.buttonUdv.Size = new System.Drawing.Size(128, 35);
            this.buttonUdv.TabIndex = 2;
            this.buttonUdv.Text = "Üdvözlés";
            this.buttonUdv.UseVisualStyleBackColor = true;
            this.buttonUdv.Click += new System.EventHandler(this.buttonUdv_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxInput.Location = new System.Drawing.Point(148, 125);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(331, 26);
            this.textBoxInput.TabIndex = 3;
            // 
            // formStart
            // 
            this.ClientSize = new System.Drawing.Size(678, 261);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonUdv);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.labelUzenet2);
            this.Name = "formStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label labelUzenet2;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.Button buttonUdv;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}

