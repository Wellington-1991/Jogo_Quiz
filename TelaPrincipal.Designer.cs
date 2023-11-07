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
			this.cbRespostas = new CheckedListBox();
			this.lblTerceiraResposta = new Label();
			this.lblSegundaResposta = new Label();
			this.btnResponder = new Button();
			this.lblPrimeiraResposta = new Label();
			this.txtPergunta = new TextBox();
			this.btnIniciar = new Button();
			this.btnCadastrarPerguntas = new Button();
			this.btnProximo = new Button();
			this.groupBox1.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.cbRespostas);
			this.groupBox1.Controls.Add(this.lblTerceiraResposta);
			this.groupBox1.Controls.Add(this.lblSegundaResposta);
			this.groupBox1.Controls.Add(this.btnResponder);
			this.groupBox1.Controls.Add(this.lblPrimeiraResposta);
			this.groupBox1.Controls.Add(this.txtPergunta);
			this.groupBox1.Controls.Add(this.btnIniciar);
			this.groupBox1.Controls.Add(this.btnCadastrarPerguntas);
			this.groupBox1.Controls.Add(this.btnProximo);
			this.groupBox1.Location = new Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(366, 323);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quiz";
			// 
			// cbRespostas
			// 
			this.cbRespostas.FormattingEnabled = true;
			this.cbRespostas.Items.AddRange(new object[] { "Resposta", "Resposta", "Resposta" });
			this.cbRespostas.Location = new Point(93, 130);
			this.cbRespostas.Name = "cbRespostas";
			this.cbRespostas.Size = new Size(75, 58);
			this.cbRespostas.TabIndex = 12;
			this.cbRespostas.Click += this.checkedListBox1_SelectedIndexChanged;
			this.cbRespostas.SelectedIndexChanged += this.checkedListBox1_SelectedIndexChanged;
			// 
			// lblTerceiraResposta
			// 
			this.lblTerceiraResposta.AutoSize = true;
			this.lblTerceiraResposta.Location = new Point(174, 170);
			this.lblTerceiraResposta.Name = "lblTerceiraResposta";
			this.lblTerceiraResposta.Size = new Size(54, 15);
			this.lblTerceiraResposta.TabIndex = 24;
			this.lblTerceiraResposta.Text = "Resposta";
			this.lblTerceiraResposta.Visible = false;
			// 
			// lblSegundaResposta
			// 
			this.lblSegundaResposta.AutoSize = true;
			this.lblSegundaResposta.Location = new Point(174, 152);
			this.lblSegundaResposta.Name = "lblSegundaResposta";
			this.lblSegundaResposta.Size = new Size(54, 15);
			this.lblSegundaResposta.TabIndex = 23;
			this.lblSegundaResposta.Text = "Resposta";
			this.lblSegundaResposta.Visible = false;
			// 
			// btnResponder
			// 
			this.btnResponder.Location = new Point(197, 256);
			this.btnResponder.Name = "btnResponder";
			this.btnResponder.Size = new Size(83, 23);
			this.btnResponder.TabIndex = 12;
			this.btnResponder.Text = "RESPONDER";
			this.btnResponder.UseVisualStyleBackColor = true;
			this.btnResponder.Click += this.btnResponder_Click;
			// 
			// lblPrimeiraResposta
			// 
			this.lblPrimeiraResposta.AutoSize = true;
			this.lblPrimeiraResposta.Location = new Point(174, 133);
			this.lblPrimeiraResposta.Name = "lblPrimeiraResposta";
			this.lblPrimeiraResposta.Size = new Size(54, 15);
			this.lblPrimeiraResposta.TabIndex = 22;
			this.lblPrimeiraResposta.Text = "Resposta";
			this.lblPrimeiraResposta.Visible = false;
			// 
			// txtPergunta
			// 
			this.txtPergunta.Location = new Point(6, 22);
			this.txtPergunta.Multiline = true;
			this.txtPergunta.Name = "txtPergunta";
			this.txtPergunta.Size = new Size(354, 93);
			this.txtPergunta.TabIndex = 14;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new Point(93, 256);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new Size(75, 23);
			this.btnIniciar.TabIndex = 13;
			this.btnIniciar.Text = "INICIAR";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += this.btnIniciar_Click;
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
			// btnProximo
			// 
			this.btnProximo.Location = new Point(93, 285);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new Size(78, 23);
			this.btnProximo.TabIndex = 11;
			this.btnProximo.Text = "PRÓXIMO";
			this.btnProximo.UseVisualStyleBackColor = true;
			this.btnProximo.Click += this.btnProximo_Click;
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
			this.ResumeLayout(false);
		}

		#endregion
		private ContextMenuStrip contextMenuStrip1;
		private GroupBox groupBox1;
		private Button button3;
		private Button btnIniciar;
		private Button btnCadastrarPerguntas;
		private Button btnProximo;
		private TextBox txtPergunta;
		private Button btnResponder;
		private CheckedListBox cbRespostas;
		private Label lblTerceiraResposta;
		private Label lblSegundaResposta;
		private Label lblPrimeiraResposta;
	}
}