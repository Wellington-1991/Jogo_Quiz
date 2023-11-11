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
            this.lbRespostas = new System.Windows.Forms.ListBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblMostrarResposta = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.lbRespostas);
            this.groupBox1.Controls.Add(this.btnResponder);
            this.groupBox1.Controls.Add(this.lblMostrarResposta);
            this.groupBox1.Controls.Add(this.txtPergunta);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 323);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz";
            // 
            // lbRespostas
            // 
            this.lbRespostas.FormattingEnabled = true;
            this.lbRespostas.ItemHeight = 15;
            this.lbRespostas.Items.AddRange(new object[] {
            "Resposta",
            "Resposta",
            "Resposta"});
            this.lbRespostas.Location = new System.Drawing.Point(93, 164);
            this.lbRespostas.Name = "lbRespostas";
            this.lbRespostas.Size = new System.Drawing.Size(187, 64);
            this.lbRespostas.TabIndex = 25;
            // 
            // btnResponder
            // 
            this.btnResponder.Enabled = false;
            this.btnResponder.Location = new System.Drawing.Point(197, 237);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(83, 23);
            this.btnResponder.TabIndex = 12;
            this.btnResponder.Text = "RESPONDER";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblMostrarResposta
            // 
            this.lblMostrarResposta.AutoSize = true;
            this.lblMostrarResposta.Location = new System.Drawing.Point(111, 19);
            this.lblMostrarResposta.Name = "lblMostrarResposta";
            this.lblMostrarResposta.Size = new System.Drawing.Size(135, 15);
            this.lblMostrarResposta.TabIndex = 22;
            this.lblMostrarResposta.Text = "        INICIE O JOGO!        ";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(6, 54);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(354, 93);
            this.txtPergunta.TabIndex = 14;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(93, 266);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(85, 23);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(197, 266);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Location = new System.Drawing.Point(93, 237);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(85, 23);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
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