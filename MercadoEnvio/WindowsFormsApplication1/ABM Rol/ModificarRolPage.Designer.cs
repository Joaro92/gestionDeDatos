﻿namespace WindowsFormsApplication1.ABM_Rol
{
    partial class ModificarRolPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FuncionalidadesChkLst = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RolesCombobox = new System.Windows.Forms.ComboBox();
            this.RolActivoChk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(20, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 474);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FuncionalidadesChkLst);
            this.groupBox4.Location = new System.Drawing.Point(396, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 430);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionalidades";
            // 
            // FuncionalidadesChkLst
            // 
            this.FuncionalidadesChkLst.FormattingEnabled = true;
            this.FuncionalidadesChkLst.Items.AddRange(new object[] {
            "ABMs",
            "Publicacion",
            "Compra/Oferta",
            "Historial Compra",
            "Facturacion",
            "Estadisticas",
            "Mostrar Mis Datos",
            "Calificar"});
            this.FuncionalidadesChkLst.Location = new System.Drawing.Point(13, 21);
            this.FuncionalidadesChkLst.Name = "FuncionalidadesChkLst";
            this.FuncionalidadesChkLst.Size = new System.Drawing.Size(560, 394);
            this.FuncionalidadesChkLst.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RolesCombobox);
            this.groupBox3.Controls.Add(this.RolActivoChk);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(9, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 430);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rol";
            // 
            // RolesCombobox
            // 
            this.RolesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolesCombobox.FormattingEnabled = true;
            this.RolesCombobox.Location = new System.Drawing.Point(75, 46);
            this.RolesCombobox.Name = "RolesCombobox";
            this.RolesCombobox.Size = new System.Drawing.Size(190, 21);
            this.RolesCombobox.TabIndex = 7;
            this.RolesCombobox.SelectedIndexChanged += new System.EventHandler(this.selecciondeRol);
            // 
            // RolActivoChk
            // 
            this.RolActivoChk.AutoSize = true;
            this.RolActivoChk.Location = new System.Drawing.Point(296, 49);
            this.RolActivoChk.Name = "RolActivoChk";
            this.RolActivoChk.Size = new System.Drawing.Size(56, 17);
            this.RolActivoChk.TabIndex = 6;
            this.RolActivoChk.Text = "Activo";
            this.RolActivoChk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(20, 542);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarRolPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarRolPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModificarRolPage_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox FuncionalidadesChkLst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox RolActivoChk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox RolesCombobox;
    }
}