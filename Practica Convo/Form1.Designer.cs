
namespace Practica_Convo
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
            this.btnSaldo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.LblMov = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.btnSaldo);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Saldo:";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(9, 39);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.LblMov);
            this.groupBox2.Controls.Add(this.btnRetirar);
            this.groupBox2.Controls.Add(this.btnDepositar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Location = new System.Drawing.Point(4, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones a Realizar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(23, 35);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(124, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad en Cordobas";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(23, 91);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(61, 77);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(91, 91);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(56, 77);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // LblMov
            // 
            this.LblMov.AutoSize = true;
            this.LblMov.Location = new System.Drawing.Point(297, 16);
            this.LblMov.Name = "LblMov";
            this.LblMov.Size = new System.Drawing.Size(106, 13);
            this.LblMov.TabIndex = 5;
            this.LblMov.Text = "Lista de Movimientos";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 52);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(91, 43);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 77);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(611, 295);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cajero Automatico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblMov;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

