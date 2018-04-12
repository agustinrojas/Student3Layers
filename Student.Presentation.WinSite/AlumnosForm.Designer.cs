namespace Student.Presentation.WinSite
{
    partial class AlumnosForm
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
            this.BtnTxt = new System.Windows.Forms.Button();
            this.BtnJson = new System.Windows.Forms.Button();
            this.BtnXml = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDateBron = new System.Windows.Forms.Label();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionCast = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionCat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionIng = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSql = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTxt
            // 
            this.BtnTxt.Location = new System.Drawing.Point(30, 293);
            this.BtnTxt.Name = "BtnTxt";
            this.BtnTxt.Size = new System.Drawing.Size(94, 58);
            this.BtnTxt.TabIndex = 0;
            this.BtnTxt.Text = "Txt";
            this.BtnTxt.UseVisualStyleBackColor = true;
            this.BtnTxt.Click += new System.EventHandler(this.BtnTxt_Click);
            // 
            // BtnJson
            // 
            this.BtnJson.Location = new System.Drawing.Point(165, 293);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(94, 58);
            this.BtnJson.TabIndex = 1;
            this.BtnJson.Text = "Json";
            this.BtnJson.UseVisualStyleBackColor = true;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // BtnXml
            // 
            this.BtnXml.Location = new System.Drawing.Point(314, 293);
            this.BtnXml.Name = "BtnXml";
            this.BtnXml.Size = new System.Drawing.Size(94, 58);
            this.BtnXml.TabIndex = 2;
            this.BtnXml.Text = "Xml";
            this.BtnXml.UseVisualStyleBackColor = true;
            this.BtnXml.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(188, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(40, 20);
            this.textId.TabIndex = 3;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(188, 80);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(242, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(188, 117);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(242, 20);
            this.textApellido.TabIndex = 5;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(188, 153);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(242, 20);
            this.textDni.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(57, 160);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "Dni";
            // 
            // lblDateBron
            // 
            this.lblDateBron.AutoSize = true;
            this.lblDateBron.Location = new System.Drawing.Point(57, 199);
            this.lblDateBron.Name = "lblDateBron";
            this.lblDateBron.Size = new System.Drawing.Size(108, 13);
            this.lblDateBron.TabIndex = 11;
            this.lblDateBron.Text = "Fecha de Nacimiento";
            // 
            // dateBorn
            // 
            this.dateBorn.Location = new System.Drawing.Point(188, 193);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(236, 20);
            this.dateBorn.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.idiomaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistro});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // MenuRegistro
            // 
            this.MenuRegistro.Name = "MenuRegistro";
            this.MenuRegistro.Size = new System.Drawing.Size(98, 22);
            this.MenuRegistro.Text = "Lista";
            this.MenuRegistro.Click += new System.EventHandler(this.MenuRegistro_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOptionCast,
            this.MenuOptionCat,
            this.MenuOptionIng});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // MenuOptionCast
            // 
            this.MenuOptionCast.Name = "MenuOptionCast";
            this.MenuOptionCast.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionCast.Text = "Castellano";
            this.MenuOptionCast.Click += new System.EventHandler(this.MenuOptionCast_Click);
            // 
            // MenuOptionCat
            // 
            this.MenuOptionCat.Name = "MenuOptionCat";
            this.MenuOptionCat.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionCat.Text = "Catalán";
            this.MenuOptionCat.Click += new System.EventHandler(this.MenuOptionCat_Click);
            // 
            // MenuOptionIng
            // 
            this.MenuOptionIng.Name = "MenuOptionIng";
            this.MenuOptionIng.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionIng.Text = "Inglés";
            this.MenuOptionIng.Click += new System.EventHandler(this.MenuOptionIng_Click);
            // 
            // BtnSql
            // 
            this.BtnSql.Location = new System.Drawing.Point(457, 293);
            this.BtnSql.Name = "BtnSql";
            this.BtnSql.Size = new System.Drawing.Size(94, 58);
            this.BtnSql.TabIndex = 14;
            this.BtnSql.Text = "DataBase";
            this.BtnSql.UseVisualStyleBackColor = true;
            this.BtnSql.Click += new System.EventHandler(this.BtnSql_Click);
            // 
            // AlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.BtnSql);
            this.Controls.Add(this.dateBorn);
            this.Controls.Add(this.lblDateBron);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.BtnXml);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.BtnTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlumnosForm";
            this.Text = "AlumnosShowForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTxt;
        private System.Windows.Forms.Button BtnJson;
        private System.Windows.Forms.Button BtnXml;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDateBron;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistro;
        private System.Windows.Forms.Button BtnSql;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionCast;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionCat;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionIng;
    }
}