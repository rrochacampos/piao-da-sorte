namespace JogoPiao
{
    partial class FormJogo
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
            this.components = new System.ComponentModel.Container();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.picInicial = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVisor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnENTER = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblTentativas = new System.Windows.Forms.Label();
            this.lblNumerosJogados = new System.Windows.Forms.Label();
            this.lblNumeroSorteado = new System.Windows.Forms.Label();
            this.btnOpcao = new System.Windows.Forms.Button();
            this.tipSair = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // picGif
            // 
            this.picGif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGif.Image = global::JogoPiao.Properties.Resources.pião;
            this.picGif.Location = new System.Drawing.Point(98, 237);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(326, 359);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 0;
            this.picGif.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::JogoPiao.Properties.Resources._25706;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(466, 382);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(58, 54);
            this.btnSair.TabIndex = 2;
            this.tipSair.SetToolTip(this.btnSair, "Fechar o jogo");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picInicial
            // 
            this.picInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInicial.Image = global::JogoPiao.Properties.Resources._01;
            this.picInicial.Location = new System.Drawing.Point(98, 237);
            this.picInicial.Name = "picInicial";
            this.picInicial.Size = new System.Drawing.Size(326, 359);
            this.picInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInicial.TabIndex = 3;
            this.picInicial.TabStop = false;
            this.picInicial.Click += new System.EventHandler(this.picInicial_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.informarNumero);
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.White;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVisor.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ForeColor = System.Drawing.Color.Black;
            this.lblVisor.Location = new System.Drawing.Point(12, 39);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(740, 38);
            this.lblVisor.TabIndex = 6;
            this.lblVisor.Text = "Clique no pião para começar";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(687, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.informarNumero);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(611, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.informarNumero);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(687, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.informarNumero);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(611, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.informarNumero);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(687, 433);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.informarNumero);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(611, 469);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.informarNumero);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(687, 469);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.informarNumero);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(611, 505);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 30);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.informarNumero);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(687, 505);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 30);
            this.button10.TabIndex = 15;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.informarNumero);
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.DarkRed;
            this.btnDEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.Location = new System.Drawing.Point(611, 541);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(57, 44);
            this.btnDEL.TabIndex = 16;
            this.btnDEL.Text = "DEL";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnENTER
            // 
            this.btnENTER.BackColor = System.Drawing.Color.Green;
            this.btnENTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnENTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENTER.Location = new System.Drawing.Point(674, 541);
            this.btnENTER.Name = "btnENTER";
            this.btnENTER.Size = new System.Drawing.Size(59, 44);
            this.btnENTER.TabIndex = 17;
            this.btnENTER.Text = "ENTER";
            this.btnENTER.UseVisualStyleBackColor = false;
            this.btnENTER.Click += new System.EventHandler(this.btnENTER_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.BackColor = System.Drawing.Color.White;
            this.txtNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeros.Location = new System.Drawing.Point(624, 327);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ReadOnly = true;
            this.txtNumeros.Size = new System.Drawing.Size(100, 17);
            this.txtNumeros.TabIndex = 18;
            this.txtNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblTentativas
            // 
            this.lblTentativas.BackColor = System.Drawing.Color.Transparent;
            this.lblTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.Location = new System.Drawing.Point(103, 252);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(134, 23);
            this.lblTentativas.TabIndex = 19;
            this.lblTentativas.Text = "Tentativas: ";
            // 
            // lblNumerosJogados
            // 
            this.lblNumerosJogados.BackColor = System.Drawing.Color.Transparent;
            this.lblNumerosJogados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerosJogados.Location = new System.Drawing.Point(103, 286);
            this.lblNumerosJogados.Name = "lblNumerosJogados";
            this.lblNumerosJogados.Size = new System.Drawing.Size(214, 133);
            this.lblNumerosJogados.TabIndex = 20;
            this.lblNumerosJogados.Text = "Números jogados: ";
            // 
            // lblNumeroSorteado
            // 
            this.lblNumeroSorteado.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSorteado.ForeColor = System.Drawing.Color.White;
            this.lblNumeroSorteado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNumeroSorteado.Location = new System.Drawing.Point(312, 286);
            this.lblNumeroSorteado.Name = "lblNumeroSorteado";
            this.lblNumeroSorteado.Size = new System.Drawing.Size(112, 87);
            this.lblNumeroSorteado.TabIndex = 21;
            this.lblNumeroSorteado.Text = "?";
            this.lblNumeroSorteado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpcao
            // 
            this.btnOpcao.BackColor = System.Drawing.Color.Black;
            this.btnOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao.ForeColor = System.Drawing.Color.White;
            this.btnOpcao.Location = new System.Drawing.Point(215, 532);
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Size = new System.Drawing.Size(102, 44);
            this.btnOpcao.TabIndex = 22;
            this.btnOpcao.Text = "Desistir";
            this.btnOpcao.UseVisualStyleBackColor = false;
            this.btnOpcao.Click += new System.EventHandler(this.btnOpcao_Click);
            // 
            // tipSair
            // 
            this.tipSair.BackColor = System.Drawing.SystemColors.WindowText;
            this.tipSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tipSair.OwnerDraw = true;
            this.tipSair.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.tipSair_Draw);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoPiao.Properties.Resources.fundo22;
            this.ClientSize = new System.Drawing.Size(764, 670);
            this.Controls.Add(this.picInicial);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.lblNumeroSorteado);
            this.Controls.Add(this.lblNumerosJogados);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnENTER);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOpcao);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pião do Número da Sorte";
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picInicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnENTER;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblTentativas;
        private System.Windows.Forms.Label lblNumerosJogados;
        private System.Windows.Forms.Label lblNumeroSorteado;
        private System.Windows.Forms.Button btnOpcao;
        private System.Windows.Forms.ToolTip tipSair;
    }
}

