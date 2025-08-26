namespace GerenciadorDeOVNI
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.txbAbduzidos = new System.Windows.Forms.TextBox();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(137, 72);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(116, 13);
            this.lblTripulantes.TabIndex = 0;
            this.lblTripulantes.Text = "Máximo de Tripulantes:";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(271, 65);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(100, 20);
            this.txbTripulantes.TabIndex = 2;
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(271, 89);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(100, 20);
            this.txbAbduzidos.TabIndex = 4;
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(137, 96);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(113, 13);
            this.lblAbduzidos.TabIndex = 3;
            this.lblAbduzidos.Text = "Máximo de Abduzidos:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(137, 122);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(97, 13);
            this.lblOrigem.TabIndex = 5;
            this.lblOrigem.Text = "Planeta de Origem:";
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Location = new System.Drawing.Point(271, 119);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(100, 21);
            this.cmbOrigem.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(140, 162);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(240, 39);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alienados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GerenciadorDeOVNI.Properties.Resources.ufo__2_;
            this.pictureBox1.Image = global::GerenciadorDeOVNI.Properties.Resources.ufo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(64, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbOrigem);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblTripulantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.TextBox txbAbduzidos;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}