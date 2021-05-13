
namespace AppVentaNelson.Vistas
{
    partial class FormLogui
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtPaswork = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(119, 200);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(107, 30);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtPaswork
            // 
            this.txtPaswork.Location = new System.Drawing.Point(80, 139);
            this.txtPaswork.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaswork.Name = "txtPaswork";
            this.txtPaswork.Size = new System.Drawing.Size(197, 20);
            this.txtPaswork.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(80, 85);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // FormLogui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 314);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtPaswork);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FormLogui";
            this.Text = "FormLogui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtPaswork;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}