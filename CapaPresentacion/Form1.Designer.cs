namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtnombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtdesc = new TextBox();
            label3 = new Label();
            txtprecio = new TextBox();
            label4 = new Label();
            txtmarca = new TextBox();
            label6 = new Label();
            txtstock = new TextBox();
            btnguardar = new Button();
            btneditar = new Button();
            btneliminar = new Button();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(138, 51);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(271, 29);
            txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 97);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // txtdesc
            // 
            txtdesc.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtdesc.Location = new Point(138, 89);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(271, 29);
            txtdesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 173);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Precio:";
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.Location = new Point(138, 164);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(271, 29);
            txtprecio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 135);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Marca:";
            // 
            // txtmarca
            // 
            txtmarca.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtmarca.Location = new Point(138, 126);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(271, 29);
            txtmarca.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 211);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "Stock:";
            // 
            // txtstock
            // 
            txtstock.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtstock.Location = new Point(138, 202);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(271, 29);
            txtstock.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Transparent;
            btnguardar.FlatAppearance.BorderColor = Color.ForestGreen;
            btnguardar.FlatAppearance.BorderSize = 3;
            btnguardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnguardar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Yet R", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnguardar.ForeColor = Color.Black;
            btnguardar.Location = new Point(65, 268);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(344, 66);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.MenuHighlight;
            btneditar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btneditar.FlatAppearance.BorderSize = 0;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btneditar.ForeColor = Color.White;
            btneditar.Location = new Point(65, 349);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(166, 48);
            btneditar.TabIndex = 12;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = SystemColors.MenuHighlight;
            btneliminar.FlatAppearance.BorderColor = Color.Red;
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseOverBackColor = Color.Red;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Yet R", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(243, 349);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(166, 48);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btneliminar);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btneditar);
            panel2.Controls.Add(txtdesc);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtmarca);
            panel2.Controls.Add(txtstock);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtprecio);
            panel2.Location = new Point(780, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 458);
            panel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yet R", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 14);
            label5.Name = "label5";
            label5.Size = new Size(215, 21);
            label5.TabIndex = 14;
            label5.Text = "Registro de Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DodgerBlue;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(751, 352);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yet R", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(205, 21);
            label7.TabIndex = 15;
            label7.Text = "Listado de Productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 426);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtnombre;
        private Label label1;
        private Label label2;
        private TextBox txtdesc;
        private Label label3;
        private TextBox txtprecio;
        private Label label4;
        private TextBox txtmarca;
        private Label label6;
        private TextBox txtstock;
        private Button btnguardar;
        private Button btneditar;
        private Button btneliminar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label7;
    }
}