namespace GerenciadorDeOVNI
{
    partial class Gerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciador));
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAdicionarTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetonarPlaneta = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblPlaneta);
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 1);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(222, 242);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(19, 110);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(72, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta atual:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(41, 203);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(141, 33);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(41, 153);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(141, 33);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(19, 88);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(19, 63);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(19, 39);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAdicionarTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(12, 249);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(222, 134);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(41, 77);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(141, 34);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAdicionarTripulantes
            // 
            this.btnAdicionarTripulantes.Location = new System.Drawing.Point(41, 28);
            this.btnAdicionarTripulantes.Name = "btnAdicionarTripulantes";
            this.btnAdicionarTripulantes.Size = new System.Drawing.Size(141, 34);
            this.btnAdicionarTripulantes.TabIndex = 0;
            this.btnAdicionarTripulantes.Text = "Adicionar";
            this.btnAdicionarTripulantes.UseVisualStyleBackColor = true;
            this.btnAdicionarTripulantes.Click += new System.EventHandler(this.btnAdicionarTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(260, 1);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(222, 134);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(41, 77);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(141, 34);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(41, 28);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(141, 34);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "Adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            this.btnAdicionarAbduzidos.Click += new System.EventHandler(this.btnAdicionarAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetonarPlaneta);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(260, 154);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(222, 229);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetonarPlaneta
            // 
            this.btnRetonarPlaneta.Location = new System.Drawing.Point(26, 133);
            this.btnRetonarPlaneta.Name = "btnRetonarPlaneta";
            this.btnRetonarPlaneta.Size = new System.Drawing.Size(177, 46);
            this.btnRetonarPlaneta.TabIndex = 2;
            this.btnRetonarPlaneta.Text = "Retornar";
            this.btnRetonarPlaneta.UseVisualStyleBackColor = true;
            this.btnRetonarPlaneta.Click += new System.EventHandler(this.btnRetonarPlaneta_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(26, 61);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(177, 46);
            this.btnMudarPlaneta.TabIndex = 1;
            this.btnMudarPlaneta.Text = "Mudar de Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(6, 22);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(210, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOVNI.Properties.Resources.ufo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(525, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pibTerra
            // 
            this.pibTerra.Location = new System.Drawing.Point(525, 267);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(224, 132);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 5;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAdicionarTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnRetonarPlaneta;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}