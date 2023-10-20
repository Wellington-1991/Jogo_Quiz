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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFinalizarCadastroJogador = new System.Windows.Forms.Button();
            this.gpbCadastrarJogador = new System.Windows.Forms.GroupBox();
            this.gpbCadastrarPergunta = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbCadastrarJogador.SuspendLayout();
            this.gpbCadastrarPergunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(96, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Digite seu nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 23);
            this.txtNome.TabIndex = 1;
            // 
            // btnFinalizarCadastroJogador
            // 
            this.btnFinalizarCadastroJogador.Location = new System.Drawing.Point(440, 32);
            this.btnFinalizarCadastroJogador.Name = "btnFinalizarCadastroJogador";
            this.btnFinalizarCadastroJogador.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizarCadastroJogador.TabIndex = 2;
            this.btnFinalizarCadastroJogador.Text = "Finalizar Cadastro";
            this.btnFinalizarCadastroJogador.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastroJogador.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gpbCadastrarJogador
            // 
            this.gpbCadastrarJogador.Controls.Add(this.txtNome);
            this.gpbCadastrarJogador.Controls.Add(this.lblNome);
            this.gpbCadastrarJogador.Controls.Add(this.btnFinalizarCadastroJogador);
            this.gpbCadastrarJogador.Location = new System.Drawing.Point(0, 2);
            this.gpbCadastrarJogador.Name = "gpbCadastrarJogador";
            this.gpbCadastrarJogador.Size = new System.Drawing.Size(618, 74);
            this.gpbCadastrarJogador.TabIndex = 3;
            this.gpbCadastrarJogador.TabStop = false;
            this.gpbCadastrarJogador.Text = "Cadastrar Jogador";
            // 
            // gpbCadastrarPergunta
            // 
            this.gpbCadastrarPergunta.Controls.Add(this.label3);
            this.gpbCadastrarPergunta.Controls.Add(this.label2);
            this.gpbCadastrarPergunta.Controls.Add(this.label1);
            this.gpbCadastrarPergunta.Controls.Add(this.rbtResposta3);
            this.gpbCadastrarPergunta.Controls.Add(this.rbtResposta2);
            this.gpbCadastrarPergunta.Controls.Add(this.rbtResposta1);
            this.gpbCadastrarPergunta.Controls.Add(this.lblResposta);
            this.gpbCadastrarPergunta.Controls.Add(this.txtResposta1);
            this.gpbCadastrarPergunta.Controls.Add(this.textBox3);
            this.gpbCadastrarPergunta.Controls.Add(this.textBox4);
            this.gpbCadastrarPergunta.Controls.Add(this.txtNomeResposta);
            this.gpbCadastrarPergunta.Controls.Add(this.lblNomeResposta);
            this.gpbCadastrarPergunta.Controls.Add(this.btnFinalizarCadastroPergunta);
            this.gpbCadastrarPergunta.Location = new System.Drawing.Point(0, 77);
            this.gpbCadastrarPergunta.Name = "gpbCadastrarPergunta";
            this.gpbCadastrarPergunta.Size = new System.Drawing.Size(618, 175);
            this.gpbCadastrarPergunta.TabIndex = 4;
            this.gpbCadastrarPergunta.TabStop = false;
            this.gpbCadastrarPergunta.Text = "Cadastrar Pergunta";
            // 
            // rbtResposta3
            // 
            this.rbtResposta3.AutoSize = true;
            this.rbtResposta3.Location = new System.Drawing.Point(505, 143);
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
            this.rbtResposta2.Location = new System.Drawing.Point(506, 112);
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
            this.rbtResposta1.Location = new System.Drawing.Point(506, 82);
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
            this.lblResposta.Location = new System.Drawing.Point(22, 84);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(102, 15);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Insira 3 Respostas:";
            // 
            // txtResposta1
            // 
            this.txtResposta1.Location = new System.Drawing.Point(137, 84);
            this.txtResposta1.Name = "txtResposta1";
            this.txtResposta1.Size = new System.Drawing.Size(285, 23);
            this.txtResposta1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 23);
            this.textBox4.TabIndex = 10;
            // 
            // txtNomeResposta
            // 
            this.txtNomeResposta.Location = new System.Drawing.Point(137, 32);
            this.txtNomeResposta.Name = "txtNomeResposta";
            this.txtNomeResposta.Size = new System.Drawing.Size(285, 23);
            this.txtNomeResposta.TabIndex = 1;
            // 
            // lblNomeResposta
            // 
            this.lblNomeResposta.AutoSize = true;
            this.lblNomeResposta.Location = new System.Drawing.Point(22, 34);
            this.lblNomeResposta.Name = "lblNomeResposta";
            this.lblNomeResposta.Size = new System.Drawing.Size(96, 15);
            this.lblNomeResposta.TabIndex = 0;
            this.lblNomeResposta.Text = "Digite seu nome:";
            // 
            // btnFinalizarCadastroPergunta
            // 
            this.btnFinalizarCadastroPergunta.Location = new System.Drawing.Point(440, 32);
            this.btnFinalizarCadastroPergunta.Name = "btnFinalizarCadastroPergunta";
            this.btnFinalizarCadastroPergunta.Size = new System.Drawing.Size(120, 23);
            this.btnFinalizarCadastroPergunta.TabIndex = 2;
            this.btnFinalizarCadastroPergunta.Text = "Finalizar Cadstro";
            this.btnFinalizarCadastroPergunta.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastroPergunta.Click += new System.EventHandler(this.btnFinalizarCadastroPergunta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Correta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Correta?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Correta?";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 365);
            this.Controls.Add(this.gpbCadastrarPergunta);
            this.Controls.Add(this.gpbCadastrarJogador);
            this.Name = "TelaCadastro";
            this.Text = "y";
            this.gpbCadastrarJogador.ResumeLayout(false);
            this.gpbCadastrarJogador.PerformLayout();
            this.gpbCadastrarPergunta.ResumeLayout(false);
            this.gpbCadastrarPergunta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnFinalizarCadastroJogador;
        private GroupBox gpbCadastrarJogador;
        private GroupBox gpbCadastrarPergunta;
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