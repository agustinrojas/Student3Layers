namespace Student.Presentation.WinSite
{
    partial class AlumnosShowForm
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Btntxt = new System.Windows.Forms.Button();
            this.BtnJso = new System.Windows.Forms.Button();
            this.BtnXml = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBoxSelect = new System.Windows.Forms.ComboBox();
            this.BtnSql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(82, 158);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(634, 220);
            this.DataGrid.TabIndex = 0;
            // 
            // Btntxt
            // 
            this.Btntxt.Location = new System.Drawing.Point(82, 27);
            this.Btntxt.Name = "Btntxt";
            this.Btntxt.Size = new System.Drawing.Size(126, 39);
            this.Btntxt.TabIndex = 1;
            this.Btntxt.Text = "Txt";
            this.Btntxt.UseVisualStyleBackColor = true;
            this.Btntxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnJso
            // 
            this.BtnJso.Location = new System.Drawing.Point(248, 27);
            this.BtnJso.Name = "BtnJso";
            this.BtnJso.Size = new System.Drawing.Size(126, 39);
            this.BtnJso.TabIndex = 2;
            this.BtnJso.Text = "Json";
            this.BtnJso.UseVisualStyleBackColor = true;
            this.BtnJso.Click += new System.EventHandler(this.BtnJso_Click);
            // 
            // BtnXml
            // 
            this.BtnXml.Location = new System.Drawing.Point(418, 27);
            this.BtnXml.Name = "BtnXml";
            this.BtnXml.Size = new System.Drawing.Size(126, 39);
            this.BtnXml.TabIndex = 3;
            this.BtnXml.Text = "Xml";
            this.BtnXml.UseVisualStyleBackColor = true;
            this.BtnXml.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(590, 89);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(126, 39);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(82, 108);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(207, 20);
            this.textValue.TabIndex = 9;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(313, 89);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Campo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(79, 89);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(94, 13);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Introduzca el valor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Registrar";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // CBoxSelect
            // 
            this.CBoxSelect.FormattingEnabled = true;
            this.CBoxSelect.Items.AddRange(new object[] {
            "Guid",
            "ID",
            "Nombre",
            "Apellidos",
            "Edad",
            "Fecha de Nacimiento",
            "Fecha de Registro"});
            this.CBoxSelect.Location = new System.Drawing.Point(316, 107);
            this.CBoxSelect.Name = "CBoxSelect";
            this.CBoxSelect.Size = new System.Drawing.Size(228, 21);
            this.CBoxSelect.TabIndex = 20;
            // 
            // BtnSql
            // 
            this.BtnSql.Location = new System.Drawing.Point(590, 27);
            this.BtnSql.Name = "BtnSql";
            this.BtnSql.Size = new System.Drawing.Size(126, 39);
            this.BtnSql.TabIndex = 21;
            this.BtnSql.Text = "Database";
            this.BtnSql.UseVisualStyleBackColor = true;
            this.BtnSql.Click += new System.EventHandler(this.BtnSql_Click);
            // 
            // AlumnosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 390);
            this.Controls.Add(this.BtnSql);
            this.Controls.Add(this.CBoxSelect);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnXml);
            this.Controls.Add(this.BtnJso);
            this.Controls.Add(this.Btntxt);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlumnosShowForm";
            this.Text = "AlumnoForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button Btntxt;
        private System.Windows.Forms.Button BtnJso;
        private System.Windows.Forms.Button BtnXml;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBoxSelect;
        private System.Windows.Forms.Button BtnSql;
    }
}