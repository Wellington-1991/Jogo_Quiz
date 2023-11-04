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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrimeiraResposta = new System.Windows.Forms.CheckBox();
            this.lblTerceiraResposta = new System.Windows.Forms.Label();
            this.lblSegundaResposta = new System.Windows.Forms.Label();
            this.cbSegundaResposta = new System.Windows.Forms.CheckBox();
            this.lblPrimeiraResposta = new System.Windows.Forms.Label();
            this.cbTerceiraResposta = new System.Windows.Forms.CheckBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCadastrarPerguntas = new System.Windows.Forms.Button();
            this.BtnJogador = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnResponder);
            this.groupBox1.Controls.Add(this.txtPergunta);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.btnCadastrarPerguntas);
            this.groupBox1.Controls.Add(this.BtnJogador);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 323);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrimeiraResposta);
            this.groupBox2.Controls.Add(this.lblTerceiraResposta);
            this.groupBox2.Controls.Add(this.lblSegundaResposta);
            this.groupBox2.Controls.Add(this.cbSegundaResposta);
            this.groupBox2.Controls.Add(this.lblPrimeiraResposta);
            this.groupBox2.Controls.Add(this.cbTerceiraResposta);
            this.groupBox2.Location = new System.Drawing.Point(93, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 106);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESPOSTAS";
            // 
            // cbPrimeiraResposta
            // 
            this.cbPrimeiraResposta.AutoSize = true;
            this.cbPrimeiraResposta.Location = new System.Drawing.Point(25, 33);
            this.cbPrimeiraResposta.Name = "cbPrimeiraResposta";
            this.cbPrimeiraResposta.Size = new System.Drawing.Size(73, 19);
            this.cbPrimeiraResposta.TabIndex = 19;
            this.cbPrimeiraResposta.Text = "Resposta";
            this.cbPrimeiraResposta.UseVisualStyleBackColor = true;
            // 
            // lblTerceiraResposta
            // 
            this.lblTerceiraResposta.AutoSize = true;
            this.lblTerceiraResposta.Location = new System.Drawing.Point(104, 81);
            this.lblTerceiraResposta.Name = "lblTerceiraResposta";
            this.lblTerceiraResposta.Size = new System.Drawing.Size(54, 15);
            this.lblTerceiraResposta.TabIndex = 24;
            this.lblTerceiraResposta.Text = "Resposta";
            this.lblTerceiraResposta.Visible = false;
            // 
            // lblSegundaResposta
            // 
            this.lblSegundaResposta.AutoSize = true;
            this.lblSegundaResposta.Location = new System.Drawing.Point(104, 56);
            this.lblSegundaResposta.Name = "lblSegundaResposta";
            this.lblSegundaResposta.Size = new System.Drawing.Size(54, 15);
            this.lblSegundaResposta.TabIndex = 23;
            this.lblSegundaResposta.Text = "Resposta";
            this.lblSegundaResposta.Visible = false;
            // 
            // cbSegundaResposta
            // 
            this.cbSegundaResposta.AutoSize = true;
            this.cbSegundaResposta.Location = new System.Drawing.Point(25, 56);
            this.cbSegundaResposta.Name = "cbSegundaResposta";
            this.cbSegundaResposta.Size = new System.Drawing.Size(73, 19);
            this.cbSegundaResposta.TabIndex = 20;
            this.cbSegundaResposta.Text = "Resposta";
            this.cbSegundaResposta.UseVisualStyleBackColor = true;
            // 
            // lblPrimeiraResposta
            // 
            this.lblPrimeiraResposta.AutoSize = true;
            this.lblPrimeiraResposta.Location = new System.Drawing.Point(104, 33);
            this.lblPrimeiraResposta.Name = "lblPrimeiraResposta";
            this.lblPrimeiraResposta.Size = new System.Drawing.Size(54, 15);
            this.lblPrimeiraResposta.TabIndex = 22;
            this.lblPrimeiraResposta.Text = "Resposta";
            this.lblPrimeiraResposta.Visible = false;
            // 
            // cbTerceiraResposta
            // 
            this.cbTerceiraResposta.AutoSize = true;
            this.cbTerceiraResposta.Location = new System.Drawing.Point(25, 81);
            this.cbTerceiraResposta.Name = "cbTerceiraResposta";
            this.cbTerceiraResposta.Size = new System.Drawing.Size(73, 19);
            this.cbTerceiraResposta.TabIndex = 21;
            this.cbTerceiraResposta.Text = "Resposta";
            this.cbTerceiraResposta.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(197, 256);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(83, 23);
            this.btnResponder.TabIndex = 12;
            this.btnResponder.Text = "RESPONDER";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(6, 22);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(354, 93);
            this.txtPergunta.TabIndex = 14;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(93, 256);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // btnCadastrarPerguntas
            // 
            this.btnCadastrarPerguntas.Location = new System.Drawing.Point(177, 285);
            this.btnCadastrarPerguntas.Name = "btnCadastrarPerguntas";
            this.btnCadastrarPerguntas.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarPerguntas.TabIndex = 0;
            this.btnCadastrarPerguntas.Text = "CadastrarPerguntas";
            this.btnCadastrarPerguntas.UseVisualStyleBackColor = true;
            // 
            // BtnJogador
            // 
            this.BtnJogador.Location = new System.Drawing.Point(39, 285);
            this.BtnJogador.Name = "BtnJogador";
            this.BtnJogador.Size = new System.Drawing.Size(132, 23);
            this.BtnJogador.TabIndex = 11;
            this.BtnJogador.Text = "CriarJogador";
            this.BtnJogador.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 324);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPrincipal";
            this.Text = "Jogo_Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private ContextMenuStrip contextMenuStrip1;
		private GroupBox groupBox1;
		private Button button3;
		private Button btnIniciar;
		private Button btnCadastrarPerguntas;
		private Button BtnJogador;
		private TextBox txtPergunta;
		private CheckBox cbTerceiraResposta;
		private CheckBox cbSegundaResposta;
		private CheckBox cbPrimeiraResposta;
		private Label lblTerceiraResposta;
		private Label lblSegundaResposta;
		private Label lblPrimeiraResposta;
		private GroupBox groupBox2;
		private Button btnResponder;
	}
}