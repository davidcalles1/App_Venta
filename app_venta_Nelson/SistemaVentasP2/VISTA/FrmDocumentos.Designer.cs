
namespace SistemaVentasP2.VISTA
{
    partial class FrmDocumentos
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateDocumento = new System.Windows.Forms.Button();
            this.btnRemoveDocumento = new System.Windows.Forms.Button();
            this.btnAgregarDocumento = new System.Windows.Forms.Button();
            this.txtIdDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(12, 30);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(220, 20);
            this.txtDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del documento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(287, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(351, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del documento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnUpdateDocumento
            // 
            this.btnUpdateDocumento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDocumento.Location = new System.Drawing.Point(144, 85);
            this.btnUpdateDocumento.Name = "btnUpdateDocumento";
            this.btnUpdateDocumento.Size = new System.Drawing.Size(88, 31);
            this.btnUpdateDocumento.TabIndex = 16;
            this.btnUpdateDocumento.Text = "Actualizar";
            this.btnUpdateDocumento.UseVisualStyleBackColor = false;
            this.btnUpdateDocumento.Click += new System.EventHandler(this.btnUpdateDocumento_Click);
            // 
            // btnRemoveDocumento
            // 
            this.btnRemoveDocumento.BackColor = System.Drawing.Color.Red;
            this.btnRemoveDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDocumento.Location = new System.Drawing.Point(96, 122);
            this.btnRemoveDocumento.Name = "btnRemoveDocumento";
            this.btnRemoveDocumento.Size = new System.Drawing.Size(88, 31);
            this.btnRemoveDocumento.TabIndex = 15;
            this.btnRemoveDocumento.Text = "Eliminar";
            this.btnRemoveDocumento.UseVisualStyleBackColor = false;
            this.btnRemoveDocumento.Click += new System.EventHandler(this.btnRemoveDocumento_Click);
            // 
            // btnAgregarDocumento
            // 
            this.btnAgregarDocumento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocumento.Location = new System.Drawing.Point(33, 85);
            this.btnAgregarDocumento.Name = "btnAgregarDocumento";
            this.btnAgregarDocumento.Size = new System.Drawing.Size(88, 31);
            this.btnAgregarDocumento.TabIndex = 14;
            this.btnAgregarDocumento.Text = "Agregar";
            this.btnAgregarDocumento.UseVisualStyleBackColor = false;
            this.btnAgregarDocumento.Click += new System.EventHandler(this.btnAgregarDocumento_Click);
            // 
            // txtIdDocumento
            // 
            this.txtIdDocumento.Location = new System.Drawing.Point(179, 7);
            this.txtIdDocumento.Name = "txtIdDocumento";
            this.txtIdDocumento.Size = new System.Drawing.Size(63, 20);
            this.txtIdDocumento.TabIndex = 17;
            this.txtIdDocumento.Visible = false;
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(655, 280);
            this.Controls.Add(this.txtIdDocumento);
            this.Controls.Add(this.btnUpdateDocumento);
            this.Controls.Add(this.btnRemoveDocumento);
            this.Controls.Add(this.btnAgregarDocumento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocumentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateDocumento;
        private System.Windows.Forms.Button btnRemoveDocumento;
        private System.Windows.Forms.Button btnAgregarDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtIdDocumento;
    }
}