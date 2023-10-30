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
			this.button3 = new Button();
			this.txtPergunta = new TextBox();
			this.button4 = new Button();
			this.btnCadastrarPerguntas = new Button();
			this.gdvGridResposta = new DataGridView();
			this.BtnJogador = new Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.gdvGridResposta).BeginInit();
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
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.txtPergunta);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.btnCadastrarPerguntas);
			this.groupBox1.Controls.Add(this.gdvGridResposta);
			this.groupBox1.Controls.Add(this.BtnJogador);
			this.groupBox1.Location = new Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(576, 373);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button3
			// 
			this.button3.Location = new Point(288, 338);
			this.button3.Name = "button3";
			this.button3.Size = new Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// txtPergunta
			// 
			this.txtPergunta.Location = new Point(88, 39);
			this.txtPergunta.Name = "txtPergunta";
			this.txtPergunta.Size = new Size(344, 23);
			this.txtPergunta.TabIndex = 14;
			// 
			// button4
			// 
			this.button4.Location = new Point(389, 338);
			this.button4.Name = "button4";
			this.button4.Size = new Size(75, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// btnCadastrarPerguntas
			// 
			this.btnCadastrarPerguntas.Location = new Point(150, 338);
			this.btnCadastrarPerguntas.Name = "btnCadastrarPerguntas";
			this.btnCadastrarPerguntas.Size = new Size(132, 23);
			this.btnCadastrarPerguntas.TabIndex = 0;
			this.btnCadastrarPerguntas.Text = "CadastrarPerguntas";
			this.btnCadastrarPerguntas.UseVisualStyleBackColor = true;
			// 
			// gdvGridResposta
			// 
			this.gdvGridResposta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdvGridResposta.Location = new Point(88, 88);
			this.gdvGridResposta.Name = "gdvGridResposta";
			this.gdvGridResposta.RowTemplate.Height = 25;
			this.gdvGridResposta.Size = new Size(344, 187);
			this.gdvGridResposta.TabIndex = 12;
			// 
			// BtnJogador
			// 
			this.BtnJogador.Location = new Point(12, 338);
			this.BtnJogador.Name = "BtnJogador";
			this.BtnJogador.Size = new Size(132, 23);
			this.BtnJogador.TabIndex = 11;
			this.BtnJogador.Text = "CriarJogador";
			this.BtnJogador.UseVisualStyleBackColor = true;
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(573, 373);
			this.Controls.Add(this.groupBox1);
			this.Name = "TelaPrincipal";
			this.Text = "Jogo_Quiz";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.gdvGridResposta).EndInit();
			this.ResumeLayout(false);
		}

		#endregion
		private ContextMenuStrip contextMenuStrip1;
		private GroupBox groupBox1;
		private Button button3;
		private Button button4;
		private Button btnCadastrarPerguntas;
		private Button BtnJogador;
		private DataGridView gdvGridResposta;
		private TextBox txtPergunta;
	}
}