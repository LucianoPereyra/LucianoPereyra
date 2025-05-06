namespace LucianoPereyra.Windows
{
    partial class FrmPiramides
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            btnOk = new Button();
            BtnCancelar = new Button();
            txtLadoBase = new TextBox();
            txtAlturaBase = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            lstPiramides = new ListBox();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado de la base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Altura de la base:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(46, 105);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 53);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(140, 105);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 53);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // txtLadoBase
            // 
            txtLadoBase.Location = new Point(100, 6);
            txtLadoBase.Name = "txtLadoBase";
            txtLadoBase.Size = new Size(100, 23);
            txtLadoBase.TabIndex = 4;
            // 
            // txtAlturaBase
            // 
            txtAlturaBase.Location = new Point(103, 45);
            txtAlturaBase.Name = "txtAlturaBase";
            txtAlturaBase.Size = new Size(100, 23);
            txtAlturaBase.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lstPiramides
            // 
            lstPiramides.FormattingEnabled = true;
            lstPiramides.ItemHeight = 15;
            lstPiramides.Location = new Point(46, 193);
            lstPiramides.Name = "lstPiramides";
            lstPiramides.Size = new Size(217, 94);
            lstPiramides.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(3, 304);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(138, 15);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad de Piramides: 0";
            // 
            // FrmPiramides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 328);
            Controls.Add(lblCantidad);
            Controls.Add(lstPiramides);
            Controls.Add(txtAlturaBase);
            Controls.Add(txtLadoBase);
            Controls.Add(BtnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPiramides";
            Text = "Formulario de Piramide Cuadrada";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnOk;
        private Button BtnCancelar;
        private TextBox txtLadoBase;
        private TextBox txtAlturaBase;
        private ErrorProvider errorProvider1;
        private ListBox lstPiramides;
        private Label lblCantidad;
    }
}
