namespace pryBlancoRepaso
{
    partial class frmArray
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
            cboGrupo = new ComboBox();
            lblGrupo = new Label();
            lstResultado = new ListBox();
            label1 = new Label();
            cboGrabar = new ComboBox();
            lblDato = new Label();
            btnCargarnuevo = new Button();
            txtGrabar = new TextBox();
            btnGrabar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // cboGrupo
            // 
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(108, 28);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(121, 23);
            cboGrupo.TabIndex = 0;
            cboGrupo.SelectedIndexChanged += cmoGrupo_SelectedIndexChanged;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(31, 31);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 1;
            lblGrupo.Text = "Grupo";
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(12, 73);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(217, 94);
            lstResultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 228);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Grupo";
            // 
            // cboGrabar
            // 
            cboGrabar.FormattingEnabled = true;
            cboGrabar.Location = new Point(80, 225);
            cboGrabar.Name = "cboGrabar";
            cboGrabar.Size = new Size(121, 23);
            cboGrabar.TabIndex = 4;
            cboGrabar.SelectedIndexChanged += cboGrabar_SelectedIndexChanged;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(12, 272);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 5;
            lblDato.Text = "Dato";
            // 
            // btnCargarnuevo
            // 
            btnCargarnuevo.Location = new Point(12, 173);
            btnCargarnuevo.Name = "btnCargarnuevo";
            btnCargarnuevo.Size = new Size(217, 23);
            btnCargarnuevo.TabIndex = 6;
            btnCargarnuevo.Text = "Sobreescribir Array";
            btnCargarnuevo.UseVisualStyleBackColor = true;
            btnCargarnuevo.Click += button1_Click;
            // 
            // txtGrabar
            // 
            txtGrabar.Location = new Point(80, 269);
            txtGrabar.Name = "txtGrabar";
            txtGrabar.Size = new Size(121, 23);
            txtGrabar.TabIndex = 7;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(158, 306);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(83, 28);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(14, 306);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(16, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "la";
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 346);
            Controls.Add(lblMensaje);
            Controls.Add(btnGrabar);
            Controls.Add(txtGrabar);
            Controls.Add(btnCargarnuevo);
            Controls.Add(lblDato);
            Controls.Add(cboGrabar);
            Controls.Add(label1);
            Controls.Add(lstResultado);
            Controls.Add(lblGrupo);
            Controls.Add(cboGrupo);
            Name = "frmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codigo";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGrupo;
        private Label lblGrupo;
        private ListBox lstResultado;
        private Label label1;
        private ComboBox cboGrabar;
        private Label lblDato;
        private Button btnCargarnuevo;
        private TextBox txtGrabar;
        private Button btnGrabar;
        private Label lblMensaje;
    }
}