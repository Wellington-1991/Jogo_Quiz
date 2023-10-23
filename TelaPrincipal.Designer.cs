namespace Jogo_Quiz
{
	partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdvGridPrincipal = new System.Windows.Forms.DataGridView();
            this.lblCampoJogador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCadastrarPerguntas = new System.Windows.Forms.Button();
            this.BtnJogador = new System.Windows.Forms.Button();
            this.txtGeral = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGridPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gdvGridPrincipal);
            this.groupBox1.Controls.Add(this.lblCampoJogador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 373);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gdvGridPrincipal
            // 
            this.gdvGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvGridPrincipal.Location = new System.Drawing.Point(200, 85);
            this.gdvGridPrincipal.Name = "gdvGridPrincipal";
            this.gdvGridPrincipal.RowTemplate.Height = 25;
            this.gdvGridPrincipal.Size = new System.Drawing.Size(344, 253);
            this.gdvGridPrincipal.TabIndex = 12;
            this.gdvGridPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvGridPrincipal_CellContentClick);
            // 
            // lblCampoJogador
            // 
            this.lblCampoJogador.AutoSize = true;
            this.lblCampoJogador.Location = new System.Drawing.Point(313, 22);
            this.lblCampoJogador.Name = "lblCampoJogador";
            this.lblCampoJogador.Size = new System.Drawing.Size(127, 15);
            this.lblCampoJogador.TabIndex = 16;
            this.lblCampoJogador.Text = "------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "JOGADOR :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtGeral);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnCadastrarPerguntas);
            this.panel1.Controls.Add(this.BtnJogador);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 338);
            this.panel1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPerguntas
            // 
            this.btnCadastrarPerguntas.Location = new System.Drawing.Point(12, 63);
            this.btnCadastrarPerguntas.Name = "btnCadastrarPerguntas";
            this.btnCadastrarPerguntas.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarPerguntas.TabIndex = 0;
            this.btnCadastrarPerguntas.Text = "CadastrarPerguntas";
            this.btnCadastrarPerguntas.UseVisualStyleBackColor = true;
            this.btnCadastrarPerguntas.Click += new System.EventHandler(this.btnCadastrarPerguntas_Click);
            // 
            // BtnJogador
            // 
            this.BtnJogador.Location = new System.Drawing.Point(12, 15);
            this.BtnJogador.Name = "BtnJogador";
            this.BtnJogador.Size = new System.Drawing.Size(132, 23);
            this.BtnJogador.TabIndex = 11;
            this.BtnJogador.Text = "CriarJogador";
            this.BtnJogador.UseVisualStyleBackColor = true;
            this.BtnJogador.Click += new System.EventHandler(this.BtnJogador_Click);
            // 
            // txtGeral
            // 
            this.txtGeral.Location = new System.Drawing.Point(11, 198);
            this.txtGeral.Name = "txtGeral";
            this.txtGeral.Size = new System.Drawing.Size(123, 23);
            this.txtGeral.TabIndex = 14;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPrincipal";
            this.Text = "Jogo_Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGridPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button btnCadastrarPerguntas;
        private Button BtnJogador;
        private Label lblCampoJogador;
        private Label label1;
        private DataGridView gdvGridPrincipal;
        private TextBox txtGeral;
    }
}