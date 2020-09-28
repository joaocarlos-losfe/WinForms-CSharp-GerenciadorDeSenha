namespace Your_Keys
{
    partial class form_home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_info_total_de_registros = new System.Windows.Forms.Label();
            this.btn_copiar_texto = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listv_dados_keys = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listv_copiar_area_de_transferencia = new System.Windows.Forms.ListView();
            this.btn_fechar_area_de_transferencia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_info_total_de_registros);
            this.panel1.Controls.Add(this.btn_copiar_texto);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_remover);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 78);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(382, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de registros:";
            // 
            // lbl_info_total_de_registros
            // 
            this.lbl_info_total_de_registros.AutoSize = true;
            this.lbl_info_total_de_registros.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_total_de_registros.ForeColor = System.Drawing.Color.White;
            this.lbl_info_total_de_registros.Location = new System.Drawing.Point(553, 25);
            this.lbl_info_total_de_registros.Name = "lbl_info_total_de_registros";
            this.lbl_info_total_de_registros.Size = new System.Drawing.Size(23, 28);
            this.lbl_info_total_de_registros.TabIndex = 6;
            this.lbl_info_total_de_registros.Text = "0";
            this.lbl_info_total_de_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_copiar_texto
            // 
            this.btn_copiar_texto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_copiar_texto.BackgroundImage")));
            this.btn_copiar_texto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_copiar_texto.FlatAppearance.BorderSize = 0;
            this.btn_copiar_texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copiar_texto.Location = new System.Drawing.Point(739, 23);
            this.btn_copiar_texto.Name = "btn_copiar_texto";
            this.btn_copiar_texto.Size = new System.Drawing.Size(32, 32);
            this.btn_copiar_texto.TabIndex = 5;
            this.btn_copiar_texto.UseVisualStyleBackColor = true;
            this.btn_copiar_texto.Visible = false;
            this.btn_copiar_texto.Click += new System.EventHandler(this.button1_Click);
            this.btn_copiar_texto.MouseHover += new System.EventHandler(this.btn_copiar_texto_MouseHover);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(797, 23);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(32, 32);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            this.btn_editar.MouseHover += new System.EventHandler(this.btn_editar_MouseHover);
            // 
            // btn_remover
            // 
            this.btn_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_remover.BackgroundImage")));
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Location = new System.Drawing.Point(855, 23);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(32, 32);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Visible = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            this.btn_remover.MouseHover += new System.EventHandler(this.btn_remover_MouseHover);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Location = new System.Drawing.Point(913, 23);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(32, 32);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            this.btn_adicionar.MouseHover += new System.EventHandler(this.btn_adicionar_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Keys";
            // 
            // listv_dados_keys
            // 
            this.listv_dados_keys.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listv_dados_keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.listv_dados_keys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listv_dados_keys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listv_dados_keys.ForeColor = System.Drawing.Color.White;
            this.listv_dados_keys.FullRowSelect = true;
            this.listv_dados_keys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listv_dados_keys.HideSelection = false;
            this.listv_dados_keys.Location = new System.Drawing.Point(12, 84);
            this.listv_dados_keys.MultiSelect = false;
            this.listv_dados_keys.Name = "listv_dados_keys";
            this.listv_dados_keys.Size = new System.Drawing.Size(934, 398);
            this.listv_dados_keys.TabIndex = 1;
            this.listv_dados_keys.UseCompatibleStateImageBehavior = false;
            this.listv_dados_keys.View = System.Windows.Forms.View.Details;
            this.listv_dados_keys.SelectedIndexChanged += new System.EventHandler(this.listv_dados_keys_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "*";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serviço";
            this.columnHeader2.Width = 178;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Website";
            this.columnHeader3.Width = 178;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email associado";
            this.columnHeader4.Width = 178;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Usuário";
            this.columnHeader5.Width = 178;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "senha";
            this.columnHeader6.Width = 170;
            // 
            // listv_copiar_area_de_transferencia
            // 
            this.listv_copiar_area_de_transferencia.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listv_copiar_area_de_transferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listv_copiar_area_de_transferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listv_copiar_area_de_transferencia.HideSelection = false;
            this.listv_copiar_area_de_transferencia.Location = new System.Drawing.Point(620, 60);
            this.listv_copiar_area_de_transferencia.Name = "listv_copiar_area_de_transferencia";
            this.listv_copiar_area_de_transferencia.Size = new System.Drawing.Size(270, 133);
            this.listv_copiar_area_de_transferencia.TabIndex = 2;
            this.listv_copiar_area_de_transferencia.TileSize = new System.Drawing.Size(228, 24);
            this.listv_copiar_area_de_transferencia.UseCompatibleStateImageBehavior = false;
            this.listv_copiar_area_de_transferencia.View = System.Windows.Forms.View.Tile;
            this.listv_copiar_area_de_transferencia.Visible = false;
            this.listv_copiar_area_de_transferencia.SelectedIndexChanged += new System.EventHandler(this.listv_copiar_area_de_transferencia_SelectedIndexChanged);
            // 
            // btn_fechar_area_de_transferencia
            // 
            this.btn_fechar_area_de_transferencia.BackColor = System.Drawing.Color.White;
            this.btn_fechar_area_de_transferencia.FlatAppearance.BorderSize = 0;
            this.btn_fechar_area_de_transferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_area_de_transferencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar_area_de_transferencia.ForeColor = System.Drawing.Color.Red;
            this.btn_fechar_area_de_transferencia.Location = new System.Drawing.Point(869, 62);
            this.btn_fechar_area_de_transferencia.Name = "btn_fechar_area_de_transferencia";
            this.btn_fechar_area_de_transferencia.Size = new System.Drawing.Size(21, 23);
            this.btn_fechar_area_de_transferencia.TabIndex = 3;
            this.btn_fechar_area_de_transferencia.Text = "X";
            this.btn_fechar_area_de_transferencia.UseVisualStyleBackColor = false;
            this.btn_fechar_area_de_transferencia.Visible = false;
            this.btn_fechar_area_de_transferencia.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(958, 494);
            this.Controls.Add(this.btn_fechar_area_de_transferencia);
            this.Controls.Add(this.listv_copiar_area_de_transferencia);
            this.Controls.Add(this.listv_dados_keys);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(974, 533);
            this.MinimumSize = new System.Drawing.Size(974, 533);
            this.Name = "form_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listv_dados_keys;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_copiar_texto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_info_total_de_registros;
        private System.Windows.Forms.ListView listv_copiar_area_de_transferencia;
        private System.Windows.Forms.Button btn_fechar_area_de_transferencia;
    }
}

