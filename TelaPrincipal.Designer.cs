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
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.lbRespostas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbRespostas.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespostas.FormattingEnabled = true;
            this.lbRespostas.ItemHeight = 15;
            this.lbRespostas.Items.AddRange(new object[] {
            "Resposta",
            "Resposta",
            "Resposta"});
            this.lbRespostas.Location = new System.Drawing.Point(69, 161);
            this.lbRespostas.Name = "lbRespostas";
            this.lbRespostas.Size = new System.Drawing.Size(201, 64);
            this.lbRespostas.TabIndex = 25;
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnResponder.Enabled = false;
            this.btnResponder.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResponder.Location = new System.Drawing.Point(168, 237);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(102, 23);
            this.btnResponder.TabIndex = 12;
            this.btnResponder.Text = "RESPONDER";
            this.btnResponder.UseVisualStyleBackColor = false;
            // 
            // lblMostrarResposta
            // 
            this.lblMostrarResposta.AutoSize = true;
            this.lblMostrarResposta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMostrarResposta.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarResposta.Location = new System.Drawing.Point(74, 19);
            this.lblMostrarResposta.Name = "lblMostrarResposta";
            this.lblMostrarResposta.Size = new System.Drawing.Size(181, 15);
            this.lblMostrarResposta.TabIndex = 22;
            this.lblMostrarResposta.Text = "        INICIE O JOGO!        ";
            // 
            // txtPergunta
            // 
            this.txtPergunta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPergunta.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPergunta.Location = new System.Drawing.Point(6, 54);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(354, 93);
            this.txtPergunta.TabIndex = 14;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIniciar.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(69, 266);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 23);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Salmon;
            this.btnSair.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(168, 266);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnProximo.Enabled = false;
            this.btnProximo.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.Location = new System.Drawing.Point(69, 237);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 23);
            this.btnProximo.TabIndex = 11;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 324);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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