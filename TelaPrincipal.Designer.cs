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
			this.lbRespostas = new ListBox();
			this.btnResponder = new Button();
			this.lblMostrarResposta = new Label();
			this.txtPergunta = new TextBox();
			this.btnIniciar = new Button();
			this.btnSair = new Button();
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
			this.groupBox1.BackColor = SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.lbRespostas);
			this.groupBox1.Controls.Add(this.btnResponder);
			this.groupBox1.Controls.Add(this.lblMostrarResposta);
			this.groupBox1.Controls.Add(this.txtPergunta);
			this.groupBox1.Controls.Add(this.btnIniciar);
			this.groupBox1.Controls.Add(this.btnSair);
			this.groupBox1.Controls.Add(this.btnProximo);
			this.groupBox1.Location = new Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(366, 323);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quiz";
			// 
			// lbRespostas
			// 
			this.lbRespostas.BackColor = SystemColors.ControlLight;
			this.lbRespostas.FormattingEnabled = true;
			this.lbRespostas.ItemHeight = 15;
			this.lbRespostas.Items.AddRange(new object[] { "Resposta", "Resposta", "Resposta" });
			this.lbRespostas.Location = new Point(93, 164);
			this.lbRespostas.Name = "lbRespostas";
			this.lbRespostas.Size = new Size(187, 64);
			this.lbRespostas.TabIndex = 25;
			// 
			// btnResponder
			// 
			this.btnResponder.Enabled = false;
			this.btnResponder.Location = new Point(197, 237);
			this.btnResponder.Name = "btnResponder";
			this.btnResponder.Size = new Size(83, 23);
			this.btnResponder.TabIndex = 12;
			this.btnResponder.Text = "RESPONDER";
			this.btnResponder.UseVisualStyleBackColor = true;
			this.btnResponder.Click += this.btnResponder_Click;
			// 
			// lblMostrarResposta
			// 
			this.lblMostrarResposta.AutoSize = true;
			this.lblMostrarResposta.Location = new Point(111, 19);
			this.lblMostrarResposta.Name = "lblMostrarResposta";
			this.lblMostrarResposta.Size = new Size(135, 15);
			this.lblMostrarResposta.TabIndex = 22;
			this.lblMostrarResposta.Text = "        INICIE O JOGO!        ";
			// 
			// txtPergunta
			// 
			this.txtPergunta.BackColor = SystemColors.ControlLight;
			this.txtPergunta.Location = new Point(6, 54);
			this.txtPergunta.Multiline = true;
			this.txtPergunta.Name = "txtPergunta";
			this.txtPergunta.Size = new Size(354, 93);
			this.txtPergunta.TabIndex = 14;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new Point(93, 266);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new Size(85, 23);
			this.btnIniciar.TabIndex = 13;
			this.btnIniciar.Text = "INICIAR";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += this.btnIniciar_Click;
			// 
			// btnSair
			// 
			this.btnSair.Location = new Point(197, 266);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new Size(85, 23);
			this.btnSair.TabIndex = 0;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += this.btnSair_Click;
			// 
			// btnProximo
			// 
			this.btnProximo.Enabled = false;
			this.btnProximo.Location = new Point(93, 237);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new Size(85, 23);
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
		private Label lblPrimeiraResposta;
		private ListBox lbRespostas;
		private Label lblMostrarResposta;
		private Button btnSair;
	}
}