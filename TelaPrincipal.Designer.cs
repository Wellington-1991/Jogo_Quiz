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
			this.contextMenuStrip1 = new ContextMenuStrip(this.components);
			this.groupBox1 = new GroupBox();
			this.lblTerceiraResposta = new Label();
			this.lblSegundaResposta = new Label();
			this.lblPrimeiraResposta = new Label();
			this.cbTerceiraResposta = new CheckBox();
			this.cbSegundaResposta = new CheckBox();
			this.cbPrimeiraResposta = new CheckBox();
			this.button3 = new Button();
			this.txtPergunta = new TextBox();
			this.button4 = new Button();
			this.btnCadastrarPerguntas = new Button();
			this.BtnJogador = new Button();
			this.groupBox2 = new GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new Size(61, 4);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.txtPergunta);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.btnCadastrarPerguntas);
			this.groupBox1.Controls.Add(this.BtnJogador);
			this.groupBox1.Location = new Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(366, 323);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quiz";
			// 
			// lblTerceiraResposta
			// 
			this.lblTerceiraResposta.AutoSize = true;
			this.lblTerceiraResposta.Location = new Point(104, 81);
			this.lblTerceiraResposta.Name = "lblTerceiraResposta";
			this.lblTerceiraResposta.Size = new Size(54, 15);
			this.lblTerceiraResposta.TabIndex = 24;
			this.lblTerceiraResposta.Text = "Resposta";
			this.lblTerceiraResposta.Visible = false;
			// 
			// lblSegundaResposta
			// 
			this.lblSegundaResposta.AutoSize = true;
			this.lblSegundaResposta.Location = new Point(104, 56);
			this.lblSegundaResposta.Name = "lblSegundaResposta";
			this.lblSegundaResposta.Size = new Size(54, 15);
			this.lblSegundaResposta.TabIndex = 23;
			this.lblSegundaResposta.Text = "Resposta";
			this.lblSegundaResposta.Visible = false;
			// 
			// lblPrimeiraResposta
			// 
			this.lblPrimeiraResposta.AutoSize = true;
			this.lblPrimeiraResposta.Location = new Point(104, 33);
			this.lblPrimeiraResposta.Name = "lblPrimeiraResposta";
			this.lblPrimeiraResposta.Size = new Size(54, 15);
			this.lblPrimeiraResposta.TabIndex = 22;
			this.lblPrimeiraResposta.Text = "Resposta";
			this.lblPrimeiraResposta.Visible = false;
			// 
			// cbTerceiraResposta
			// 
			this.cbTerceiraResposta.AutoSize = true;
			this.cbTerceiraResposta.Location = new Point(25, 81);
			this.cbTerceiraResposta.Name = "cbTerceiraResposta";
			this.cbTerceiraResposta.Size = new Size(73, 19);
			this.cbTerceiraResposta.TabIndex = 21;
			this.cbTerceiraResposta.Text = "Resposta";
			this.cbTerceiraResposta.UseVisualStyleBackColor = true;
			this.cbTerceiraResposta.Click += this.ValidarResposta;
			// 
			// cbSegundaResposta
			// 
			this.cbSegundaResposta.AutoSize = true;
			this.cbSegundaResposta.Location = new Point(25, 56);
			this.cbSegundaResposta.Name = "cbSegundaResposta";
			this.cbSegundaResposta.Size = new Size(73, 19);
			this.cbSegundaResposta.TabIndex = 20;
			this.cbSegundaResposta.Text = "Resposta";
			this.cbSegundaResposta.UseVisualStyleBackColor = true;
			this.cbSegundaResposta.Click += this.ValidarResposta;
			// 
			// cbPrimeiraResposta
			// 
			this.cbPrimeiraResposta.AutoSize = true;
			this.cbPrimeiraResposta.Location = new Point(25, 33);
			this.cbPrimeiraResposta.Name = "cbPrimeiraResposta";
			this.cbPrimeiraResposta.Size = new Size(73, 19);
			this.cbPrimeiraResposta.TabIndex = 19;
			this.cbPrimeiraResposta.Text = "Resposta";
			this.cbPrimeiraResposta.UseVisualStyleBackColor = true;
			this.cbPrimeiraResposta.Click += this.ValidarResposta;
			// 
			// button3
			// 
			this.button3.Location = new Point(61, 256);
			this.button3.Name = "button3";
			this.button3.Size = new Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// txtPergunta
			// 
			this.txtPergunta.Location = new Point(83, 40);
			this.txtPergunta.Multiline = true;
			this.txtPergunta.Name = "txtPergunta";
			this.txtPergunta.Size = new Size(194, 75);
			this.txtPergunta.TabIndex = 14;
			// 
			// button4
			// 
			this.button4.Location = new Point(202, 256);
			this.button4.Name = "button4";
			this.button4.Size = new Size(75, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnCadastrarPerguntas
			// 
			this.btnCadastrarPerguntas.Location = new Point(177, 285);
			this.btnCadastrarPerguntas.Name = "btnCadastrarPerguntas";
			this.btnCadastrarPerguntas.Size = new Size(132, 23);
			this.btnCadastrarPerguntas.TabIndex = 0;
			this.btnCadastrarPerguntas.Text = "CadastrarPerguntas";
			this.btnCadastrarPerguntas.UseVisualStyleBackColor = true;
			// 
			// BtnJogador
			// 
			this.BtnJogador.Location = new Point(39, 285);
			this.BtnJogador.Name = "BtnJogador";
			this.BtnJogador.Size = new Size(132, 23);
			this.BtnJogador.TabIndex = 11;
			this.BtnJogador.Text = "CriarJogador";
			this.BtnJogador.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbPrimeiraResposta);
			this.groupBox2.Controls.Add(this.lblTerceiraResposta);
			this.groupBox2.Controls.Add(this.lblSegundaResposta);
			this.groupBox2.Controls.Add(this.cbSegundaResposta);
			this.groupBox2.Controls.Add(this.lblPrimeiraResposta);
			this.groupBox2.Controls.Add(this.cbTerceiraResposta);
			this.groupBox2.Location = new Point(93, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new Size(173, 106);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "RESPOSTAS";
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(366, 324);
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
		private Button button4;
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
	}
}