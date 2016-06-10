namespace Nasa.Janelas
{
    partial class FormMov
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
            this.lbx_Resultado = new System.Windows.Forms.ListBox();
            this.p_Principal = new System.Windows.Forms.Panel();
            this.btn_MoverRoboDois = new System.Windows.Forms.Button();
            this.txt_PosiSegRobo = new System.Windows.Forms.TextBox();
            this.txt_PosiPriRobo = new System.Windows.Forms.TextBox();
            this.txt_PosiEntrada = new System.Windows.Forms.TextBox();
            this.btn_MoverRoboUm = new System.Windows.Forms.Button();
            this.txt_MoviSegRobo = new System.Windows.Forms.TextBox();
            this.txt_MoviPriRobo = new System.Windows.Forms.TextBox();
            this.lb_MovSegRobo = new System.Windows.Forms.Label();
            this.lb_PosiSegRobo = new System.Windows.Forms.Label();
            this.lb_MovPriRobo = new System.Windows.Forms.Label();
            this.lb_PosiPriRobo = new System.Windows.Forms.Label();
            this.lb_PosiEntrada = new System.Windows.Forms.Label();
            this.p_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_Resultado
            // 
            this.lbx_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbx_Resultado.FormattingEnabled = true;
            this.lbx_Resultado.Items.AddRange(new object[] {
            "Histórico de Resultados:"});
            this.lbx_Resultado.Location = new System.Drawing.Point(13, 155);
            this.lbx_Resultado.Name = "lbx_Resultado";
            this.lbx_Resultado.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_Resultado.Size = new System.Drawing.Size(533, 121);
            this.lbx_Resultado.TabIndex = 8;
            // 
            // p_Principal
            // 
            this.p_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Principal.Controls.Add(this.btn_MoverRoboDois);
            this.p_Principal.Controls.Add(this.txt_PosiSegRobo);
            this.p_Principal.Controls.Add(this.txt_PosiPriRobo);
            this.p_Principal.Controls.Add(this.txt_PosiEntrada);
            this.p_Principal.Controls.Add(this.btn_MoverRoboUm);
            this.p_Principal.Controls.Add(this.txt_MoviSegRobo);
            this.p_Principal.Controls.Add(this.txt_MoviPriRobo);
            this.p_Principal.Controls.Add(this.lb_MovSegRobo);
            this.p_Principal.Controls.Add(this.lb_PosiSegRobo);
            this.p_Principal.Controls.Add(this.lb_MovPriRobo);
            this.p_Principal.Controls.Add(this.lb_PosiPriRobo);
            this.p_Principal.Controls.Add(this.lb_PosiEntrada);
            this.p_Principal.Controls.Add(this.lbx_Resultado);
            this.p_Principal.Location = new System.Drawing.Point(12, 12);
            this.p_Principal.Name = "p_Principal";
            this.p_Principal.Size = new System.Drawing.Size(557, 300);
            this.p_Principal.TabIndex = 14;
            // 
            // btn_MoverRoboDois
            // 
            this.btn_MoverRoboDois.Location = new System.Drawing.Point(431, 101);
            this.btn_MoverRoboDois.Name = "btn_MoverRoboDois";
            this.btn_MoverRoboDois.Size = new System.Drawing.Size(86, 35);
            this.btn_MoverRoboDois.TabIndex = 7;
            this.btn_MoverRoboDois.Text = "Mover Robô 2";
            this.btn_MoverRoboDois.UseVisualStyleBackColor = true;
            this.btn_MoverRoboDois.Click += new System.EventHandler(this.btn_MoverRoboDois_Click);
            // 
            // txt_PosiSegRobo
            // 
            this.txt_PosiSegRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PosiSegRobo.Location = new System.Drawing.Point(431, 47);
            this.txt_PosiSegRobo.MaxLength = 4;
            this.txt_PosiSegRobo.Name = "txt_PosiSegRobo";
            this.txt_PosiSegRobo.Size = new System.Drawing.Size(46, 20);
            this.txt_PosiSegRobo.TabIndex = 5;
            this.txt_PosiSegRobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PosiSegRobo_KeyPress);
            this.txt_PosiSegRobo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PosiSegRobo_KeyUp);
            // 
            // txt_PosiPriRobo
            // 
            this.txt_PosiPriRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PosiPriRobo.Location = new System.Drawing.Point(128, 47);
            this.txt_PosiPriRobo.MaxLength = 4;
            this.txt_PosiPriRobo.Name = "txt_PosiPriRobo";
            this.txt_PosiPriRobo.Size = new System.Drawing.Size(46, 20);
            this.txt_PosiPriRobo.TabIndex = 2;
            this.txt_PosiPriRobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PosiPriRobo_KeyPress);
            this.txt_PosiPriRobo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PosiPriRobo_KeyUp);
            // 
            // txt_PosiEntrada
            // 
            this.txt_PosiEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PosiEntrada.Location = new System.Drawing.Point(329, 11);
            this.txt_PosiEntrada.MaxLength = 3;
            this.txt_PosiEntrada.Name = "txt_PosiEntrada";
            this.txt_PosiEntrada.Size = new System.Drawing.Size(46, 20);
            this.txt_PosiEntrada.TabIndex = 1;
            this.txt_PosiEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PosiEntrada_KeyPress);
            this.txt_PosiEntrada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PosiEntrada_KeyUp);
            // 
            // btn_MoverRoboUm
            // 
            this.btn_MoverRoboUm.Location = new System.Drawing.Point(128, 101);
            this.btn_MoverRoboUm.Name = "btn_MoverRoboUm";
            this.btn_MoverRoboUm.Size = new System.Drawing.Size(86, 35);
            this.btn_MoverRoboUm.TabIndex = 4;
            this.btn_MoverRoboUm.Text = "Mover Robô 1";
            this.btn_MoverRoboUm.UseVisualStyleBackColor = true;
            this.btn_MoverRoboUm.Click += new System.EventHandler(this.btn_MoverRoboUm_Click);
            // 
            // txt_MoviSegRobo
            // 
            this.txt_MoviSegRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_MoviSegRobo.Location = new System.Drawing.Point(431, 75);
            this.txt_MoviSegRobo.Name = "txt_MoviSegRobo";
            this.txt_MoviSegRobo.Size = new System.Drawing.Size(115, 20);
            this.txt_MoviSegRobo.TabIndex = 6;
            this.txt_MoviSegRobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MoviSegTratamento_KeyPress);
            // 
            // txt_MoviPriRobo
            // 
            this.txt_MoviPriRobo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_MoviPriRobo.Location = new System.Drawing.Point(128, 75);
            this.txt_MoviPriRobo.Name = "txt_MoviPriRobo";
            this.txt_MoviPriRobo.Size = new System.Drawing.Size(115, 20);
            this.txt_MoviPriRobo.TabIndex = 3;
            this.txt_MoviPriRobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MoviPriTratamento_KeyPress);
            // 
            // lb_MovSegRobo
            // 
            this.lb_MovSegRobo.AutoSize = true;
            this.lb_MovSegRobo.Location = new System.Drawing.Point(307, 78);
            this.lb_MovSegRobo.Name = "lb_MovSegRobo";
            this.lb_MovSegRobo.Size = new System.Drawing.Size(118, 13);
            this.lb_MovSegRobo.TabIndex = 13;
            this.lb_MovSegRobo.Text = "Movimentação Robô 2:";
            // 
            // lb_PosiSegRobo
            // 
            this.lb_PosiSegRobo.AutoSize = true;
            this.lb_PosiSegRobo.Location = new System.Drawing.Point(339, 50);
            this.lb_PosiSegRobo.Name = "lb_PosiSegRobo";
            this.lb_PosiSegRobo.Size = new System.Drawing.Size(86, 13);
            this.lb_PosiSegRobo.TabIndex = 12;
            this.lb_PosiSegRobo.Text = "Posição Robô 2:";
            // 
            // lb_MovPriRobo
            // 
            this.lb_MovPriRobo.AutoSize = true;
            this.lb_MovPriRobo.Location = new System.Drawing.Point(4, 78);
            this.lb_MovPriRobo.Name = "lb_MovPriRobo";
            this.lb_MovPriRobo.Size = new System.Drawing.Size(118, 13);
            this.lb_MovPriRobo.TabIndex = 11;
            this.lb_MovPriRobo.Text = "Movimentação Robô 1:";
            // 
            // lb_PosiPriRobo
            // 
            this.lb_PosiPriRobo.AutoSize = true;
            this.lb_PosiPriRobo.Location = new System.Drawing.Point(35, 50);
            this.lb_PosiPriRobo.Name = "lb_PosiPriRobo";
            this.lb_PosiPriRobo.Size = new System.Drawing.Size(87, 17);
            this.lb_PosiPriRobo.TabIndex = 10;
            this.lb_PosiPriRobo.Text = "Posição Robô 1:";
            this.lb_PosiPriRobo.UseCompatibleTextRendering = true;
            // 
            // lb_PosiEntrada
            // 
            this.lb_PosiEntrada.AutoSize = true;
            this.lb_PosiEntrada.Location = new System.Drawing.Point(164, 14);
            this.lb_PosiEntrada.Name = "lb_PosiEntrada";
            this.lb_PosiEntrada.Size = new System.Drawing.Size(159, 13);
            this.lb_PosiEntrada.TabIndex = 9;
            this.lb_PosiEntrada.Text = "Posição de Entrada no Planalto:";
            // 
            // FormMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 327);
            this.Controls.Add(this.p_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMov";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Robôs";
            this.p_Principal.ResumeLayout(false);
            this.p_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Resultado;
        private System.Windows.Forms.Panel p_Principal;
        private System.Windows.Forms.Label lb_MovSegRobo;
        private System.Windows.Forms.Label lb_PosiSegRobo;
        private System.Windows.Forms.Label lb_MovPriRobo;
        private System.Windows.Forms.Label lb_PosiPriRobo;
        private System.Windows.Forms.Label lb_PosiEntrada;
        private System.Windows.Forms.Button btn_MoverRoboUm;
        private System.Windows.Forms.TextBox txt_MoviSegRobo;
        private System.Windows.Forms.TextBox txt_MoviPriRobo;
        private System.Windows.Forms.TextBox txt_PosiSegRobo;
        private System.Windows.Forms.TextBox txt_PosiPriRobo;
        private System.Windows.Forms.TextBox txt_PosiEntrada;
        private System.Windows.Forms.Button btn_MoverRoboDois;
    }
}