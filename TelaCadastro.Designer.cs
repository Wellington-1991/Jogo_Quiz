namespace Jogo_Quiz
{
    partial class TelaCadastro
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
            this.lblCadatrarJogador = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFinalizarCadastroJogador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtResposta3 = new System.Windows.Forms.RadioButton();
            this.rbtResposta2 = new System.Windows.Forms.RadioButton();
            this.rbtResposta1 = new System.Windows.Forms.RadioButton();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtResposta1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtNomeResposta = new System.Windows.Forms.TextBox();
            this.lblNomeResposta = new System.Windows.Forms.Label();
            this.btnFinalizarCadastroPergunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadatrarJogador
            // 
            this.lblCadatrarJogador.AutoSize = true;
            this.lblCadatrarJogador.Location = new System.Drawing.Point(18, 14);
            this.lblCadatrarJogador.Name = "lblCadatrarJogador";
            this.lblCadatrarJogador.Size = new System.Drawing.Size(114, 15);
            this.lblCadatrarJogador.TabIndex = 0;
            this.lblCadatrarJogador.Text = "Cadastrar o jogador:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 23);
            this.txtNome.TabIndex = 1;
            // 
            // btnFinalizarCadastroJogador
            // 
            this.btnFinalizarCadastroJogador.Location = new System.Drawing.Point(447, 12);
            this.btnFinalizarCadastroJogador.Name = "btnFinalizarCadastroJogador";
            this.btnFinalizarCadastroJogador.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizarCadastroJogador.TabIndex = 2;
            this.btnFinalizarCadastroJogador.Text = "Finalizar Cadastro";
            this.btnFinalizarCadastroJogador.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastroJogador.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Correta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Correta?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Correta?";
            // 
            // rbtResposta3
            // 
            this.rbtResposta3.AutoSize = true;
            this.rbtResposta3.Location = new System.Drawing.Point(514, 421);
            this.rbtResposta3.Name = "rbtResposta3";
            this.rbtResposta3.Size = new System.Drawing.Size(51, 19);
            this.rbtResposta3.TabIndex = 13;
            this.rbtResposta3.TabStop = true;
            this.rbtResposta3.Text = "NÃO";
            this.rbtResposta3.UseVisualStyleBackColor = true;
            // 
            // rbtResposta2
            // 
            this.rbtResposta2.AutoSize = true;
            this.rbtResposta2.Location = new System.Drawing.Point(513, 392);
            this.rbtResposta2.Name = "rbtResposta2";
            this.rbtResposta2.Size = new System.Drawing.Size(51, 19);
            this.rbtResposta2.TabIndex = 12;
            this.rbtResposta2.TabStop = true;
            this.rbtResposta2.Text = "NÃO";
            this.rbtResposta2.UseVisualStyleBackColor = true;
            // 
            // rbtResposta1
            // 
            this.rbtResposta1.AutoSize = true;
            this.rbtResposta1.Location = new System.Drawing.Point(513, 362);
            this.rbtResposta1.Name = "rbtResposta1";
            this.rbtResposta1.Size = new System.Drawing.Size(51, 19);
            this.rbtResposta1.TabIndex = 11;
            this.rbtResposta1.TabStop = true;
            this.rbtResposta1.Text = "NÃO";
            this.rbtResposta1.UseVisualStyleBackColor = true;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(29, 364);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(102, 15);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Insira 3 Respostas:";
            // 
            // txtResposta1
            // 
            this.txtResposta1.Location = new System.Drawing.Point(144, 364);
            this.txtResposta1.Name = "txtResposta1";
            this.txtResposta1.Size = new System.Drawing.Size(285, 23);
            this.txtResposta1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 391);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 420);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 23);
            this.textBox4.TabIndex = 10;
            // 
            // txtNomeResposta
            // 
            this.txtNomeResposta.Location = new System.Drawing.Point(144, 312);
            this.txtNomeResposta.Name = "txtNomeResposta";
            this.txtNomeResposta.Size = new System.Drawing.Size(285, 23);
            this.txtNomeResposta.TabIndex = 1;
            // 
            // lblNomeResposta
            // 
            this.lblNomeResposta.AutoSize = true;
            this.lblNomeResposta.Location = new System.Drawing.Point(29, 314);
            this.lblNomeResposta.Name = "lblNomeResposta";
            this.lblNomeResposta.Size = new System.Drawing.Size(96, 15);
            this.lblNomeResposta.TabIndex = 0;
            this.lblNomeResposta.Text = "Digite seu nome:";
            // 
            // btnFinalizarCadastroPergunta
            // 
            this.btnFinalizarCadastroPergunta.Location = new System.Drawing.Point(447, 312);
            this.btnFinalizarCadastroPergunta.Name = "btnFinalizarCadastroPergunta";
            this.btnFinalizarCadastroPergunta.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizarCadastroPergunta.TabIndex = 2;
            this.btnFinalizarCadastroPergunta.Text = "Finalizar Cadstro";
            this.btnFinalizarCadastroPergunta.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastroPergunta.Click += new System.EventHandler(this.btnFinalizarCadastroPergunta_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCadatrarJogador);
            this.Controls.Add(this.rbtResposta3);
            this.Controls.Add(this.btnFinalizarCadastroJogador);
            this.Controls.Add(this.rbtResposta2);
            this.Controls.Add(this.lblNomeResposta);
            this.Controls.Add(this.rbtResposta1);
            this.Controls.Add(this.btnFinalizarCadastroPergunta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtNomeResposta);
            this.Controls.Add(this.txtResposta1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Name = "TelaCadastro";
            this.Text = "y";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCadatrarJogador;
        private TextBox txtNome;
        private Button btnFinalizarCadastroJogador;
        private RadioButton rbtResposta3;
        private RadioButton rbtResposta2;
        private RadioButton rbtResposta1;
        private Label lblResposta;
        private TextBox txtResposta1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtNomeResposta;
        private Label lblNomeResposta;
        private Button btnFinalizarCadastroPergunta;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}