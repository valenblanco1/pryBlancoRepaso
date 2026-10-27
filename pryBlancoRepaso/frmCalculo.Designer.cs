namespace pryBlancoRepaso
{
    partial class frmCalculo
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
            lblmonto = new Label();
            lbliva = new Label();
            txtmonto = new TextBox();
            cmbIva = new ComboBox();
            btncalculo = new Button();
            SuspendLayout();
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Location = new Point(12, 46);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(43, 15);
            lblmonto.TabIndex = 0;
            lblmonto.Text = "Monto";
            // 
            // lbliva
            // 
            lbliva.AutoSize = true;
            lbliva.Location = new Point(12, 84);
            lbliva.Name = "lbliva";
            lbliva.Size = new Size(24, 15);
            lbliva.TabIndex = 1;
            lbliva.Text = "IVA";
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(69, 43);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(100, 23);
            txtmonto.TabIndex = 2;
            // 
            // cmbIva
            // 
            cmbIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIva.FormattingEnabled = true;
            cmbIva.Items.AddRange(new object[] { "10%", "21%" });
            cmbIva.Location = new Point(69, 81);
            cmbIva.Name = "cmbIva";
            cmbIva.Size = new Size(102, 23);
            cmbIva.TabIndex = 3;
            // 
            // btncalculo
            // 
            btncalculo.Location = new Point(149, 125);
            btncalculo.Name = "btncalculo";
            btncalculo.Size = new Size(95, 33);
            btncalculo.TabIndex = 4;
            btncalculo.Text = "Calculo";
            btncalculo.UseVisualStyleBackColor = true;
            btncalculo.Click += btncalculo_Click;
            // 
            // frmCalculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 235);
            Controls.Add(btncalculo);
            Controls.Add(cmbIva);
            Controls.Add(txtmonto);
            Controls.Add(lbliva);
            Controls.Add(lblmonto);
            Name = "frmCalculo";
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmonto;
        private Label lbliva;
        private TextBox txtmonto;
        private ComboBox cmbIva;
        private Button btncalculo;
    }
}