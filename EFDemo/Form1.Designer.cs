namespace EFDemo
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxObtenerPorID = new System.Windows.Forms.TextBox();
            this.btnObtenerPorID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1038, 389);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(502, 465);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(114, 45);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Cargar Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "IDCustomer";
            // 
            // tboxObtenerPorID
            // 
            this.tboxObtenerPorID.Location = new System.Drawing.Point(103, 462);
            this.tboxObtenerPorID.Name = "tboxObtenerPorID";
            this.tboxObtenerPorID.Size = new System.Drawing.Size(140, 22);
            this.tboxObtenerPorID.TabIndex = 4;
            // 
            // btnObtenerPorID
            // 
            this.btnObtenerPorID.Location = new System.Drawing.Point(263, 456);
            this.btnObtenerPorID.Name = "btnObtenerPorID";
            this.btnObtenerPorID.Size = new System.Drawing.Size(114, 34);
            this.btnObtenerPorID.TabIndex = 5;
            this.btnObtenerPorID.Text = "obtener";
            this.btnObtenerPorID.UseVisualStyleBackColor = true;
            this.btnObtenerPorID.Click += new System.EventHandler(this.btnObtenerPorID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnObtenerPorID);
            this.Controls.Add(this.tboxObtenerPorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxObtenerPorID;
        private System.Windows.Forms.Button btnObtenerPorID;
    }
}

