namespace pryBlancoRepaso
{
    partial class frmPrincipal
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
            lblCodigo = new Label();
            txtcodigo = new TextBox();
            btnregistrar = new Button();
            lblnombre = new Label();
            txtnombre = new TextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(24, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(76, 31);
            txtcodigo.MaxLength = 5;
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(45, 23);
            txtcodigo.TabIndex = 2;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(189, 101);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(75, 23);
            btnregistrar.TabIndex = 3;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            btnregistrar.MouseClick += btnregistrar_MouseClick;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(24, 66);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 4;
            lblnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(76, 63);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 203);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(btnregistrar);
            Controls.Add(txtcodigo);
            Controls.Add(lblCodigo);
            Name = "frmPrincipal";
            Text = "Carga de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnregistrar_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtcodigo;
        private Button btnregistrar;
        private Label lblnombre;
        private TextBox txtnombre;
    }
}