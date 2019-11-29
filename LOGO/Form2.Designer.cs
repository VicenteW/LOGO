namespace WindowsFormsApplication6
{
    partial class Form2
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
            this.lbl_Comand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Comand
            // 
            this.lbl_Comand.AutoSize = true;
            this.lbl_Comand.Location = new System.Drawing.Point(12, 9);
            this.lbl_Comand.Name = "lbl_Comand";
            this.lbl_Comand.Size = new System.Drawing.Size(0, 17);
            this.lbl_Comand.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 372);
            this.Controls.Add(this.lbl_Comand);
            this.Name = "Form2";
            this.Text = "Lista de Comandos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Comand;
    }
}