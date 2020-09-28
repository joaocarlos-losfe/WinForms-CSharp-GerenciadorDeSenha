namespace Your_Keys
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.chbox_mostrar_key = new System.Windows.Forms.CheckBox();
            this.lbl_info_erro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Keys";
            // 
            // txtbox_key
            // 
            this.txtbox_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_key.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_key.Location = new System.Drawing.Point(136, 144);
            this.txtbox_key.Name = "txtbox_key";
            this.txtbox_key.PasswordChar = '*';
            this.txtbox_key.Size = new System.Drawing.Size(537, 25);
            this.txtbox_key.TabIndex = 4;
            this.txtbox_key.TextChanged += new System.EventHandler(this.txtbox_key_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe sua key";
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_entrar.Location = new System.Drawing.Point(367, 230);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 29);
            this.btn_entrar.TabIndex = 6;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Visible = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // chbox_mostrar_key
            // 
            this.chbox_mostrar_key.AutoSize = true;
            this.chbox_mostrar_key.ForeColor = System.Drawing.Color.White;
            this.chbox_mostrar_key.Location = new System.Drawing.Point(364, 185);
            this.chbox_mostrar_key.Name = "chbox_mostrar_key";
            this.chbox_mostrar_key.Size = new System.Drawing.Size(81, 17);
            this.chbox_mostrar_key.TabIndex = 7;
            this.chbox_mostrar_key.Text = "Mostrar key";
            this.chbox_mostrar_key.UseVisualStyleBackColor = true;
            this.chbox_mostrar_key.CheckedChanged += new System.EventHandler(this.chbox_mostrar_key_CheckedChanged);
            // 
            // lbl_info_erro
            // 
            this.lbl_info_erro.AutoSize = true;
            this.lbl_info_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_erro.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_info_erro.Location = new System.Drawing.Point(313, 279);
            this.lbl_info_erro.Name = "lbl_info_erro";
            this.lbl_info_erro.Size = new System.Drawing.Size(182, 17);
            this.lbl_info_erro.TabIndex = 8;
            this.lbl_info_erro.Text = "Usuário ou senha invalido !!";
            this.lbl_info_erro.Visible = false;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(804, 321);
            this.Controls.Add(this.lbl_info_erro);
            this.Controls.Add(this.chbox_mostrar_key);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_key);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 360);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_login";
            this.Load += new System.EventHandler(this.form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.CheckBox chbox_mostrar_key;
        private System.Windows.Forms.Label lbl_info_erro;
    }
}