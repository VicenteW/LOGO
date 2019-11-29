namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cargarcod = new System.Windows.Forms.Button();
            this.btn_Savecod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cleartxt = new System.Windows.Forms.Button();
            this.Codigotxt = new System.Windows.Forms.RichTextBox();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_comand = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.instrucciontxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Cargarcod);
            this.groupBox1.Controls.Add(this.btn_Savecod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cleartxt);
            this.groupBox1.Controls.Add(this.Codigotxt);
            this.groupBox1.Controls.Add(this.btn_Ejecutar);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_comand);
            this.groupBox1.Location = new System.Drawing.Point(821, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 686);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herramientas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cargarcod
            // 
            this.btn_Cargarcod.Location = new System.Drawing.Point(6, 590);
            this.btn_Cargarcod.Name = "btn_Cargarcod";
            this.btn_Cargarcod.Size = new System.Drawing.Size(192, 37);
            this.btn_Cargarcod.TabIndex = 7;
            this.btn_Cargarcod.Text = "Cargar Codigo";
            this.btn_Cargarcod.UseVisualStyleBackColor = true;
            this.btn_Cargarcod.Click += new System.EventHandler(this.btn_Cargarcod_Click);
            // 
            // btn_Savecod
            // 
            this.btn_Savecod.Location = new System.Drawing.Point(6, 547);
            this.btn_Savecod.Name = "btn_Savecod";
            this.btn_Savecod.Size = new System.Drawing.Size(192, 37);
            this.btn_Savecod.TabIndex = 6;
            this.btn_Savecod.Text = "Guardar Codigo";
            this.btn_Savecod.UseVisualStyleBackColor = true;
            this.btn_Savecod.Click += new System.EventHandler(this.btn_Savecod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese su codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Cleartxt
            // 
            this.btn_Cleartxt.Location = new System.Drawing.Point(6, 504);
            this.btn_Cleartxt.Name = "btn_Cleartxt";
            this.btn_Cleartxt.Size = new System.Drawing.Size(192, 37);
            this.btn_Cleartxt.TabIndex = 4;
            this.btn_Cleartxt.Text = "Borrar Codigo";
            this.btn_Cleartxt.UseVisualStyleBackColor = true;
            this.btn_Cleartxt.Click += new System.EventHandler(this.btn_Cleartxt_Click);
            // 
            // Codigotxt
            // 
            this.Codigotxt.Location = new System.Drawing.Point(6, 127);
            this.Codigotxt.Name = "Codigotxt";
            this.Codigotxt.Size = new System.Drawing.Size(192, 331);
            this.Codigotxt.TabIndex = 3;
            this.Codigotxt.Text = "";
            this.Codigotxt.TextChanged += new System.EventHandler(this.Codigotxt_TextChanged);
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(6, 464);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(192, 34);
            this.btn_Ejecutar.TabIndex = 2;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Clear.Location = new System.Drawing.Point(6, 72);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(192, 32);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Borrar Página";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_comand
            // 
            this.btn_comand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_comand.FlatAppearance.BorderSize = 6;
            this.btn_comand.Location = new System.Drawing.Point(6, 32);
            this.btn_comand.Name = "btn_comand";
            this.btn_comand.Size = new System.Drawing.Size(192, 34);
            this.btn_comand.TabIndex = 0;
            this.btn_comand.Text = "Comandos";
            this.btn_comand.UseVisualStyleBackColor = true;
            this.btn_comand.Click += new System.EventHandler(this.btn_comand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 650);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // instrucciontxt
            // 
            this.instrucciontxt.AutoSize = true;
            this.instrucciontxt.Location = new System.Drawing.Point(12, 20);
            this.instrucciontxt.Name = "instrucciontxt";
            this.instrucciontxt.Size = new System.Drawing.Size(0, 17);
            this.instrucciontxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1038, 718);
            this.Controls.Add(this.instrucciontxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cleartxt;
        private System.Windows.Forms.RichTextBox Codigotxt;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_comand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cargarcod;
        private System.Windows.Forms.Button btn_Savecod;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label instrucciontxt;
    }
}

