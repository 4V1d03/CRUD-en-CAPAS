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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(751, 352);
            dataGridView1.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(881, 17);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(271, 27);
            txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(808, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(786, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(881, 50);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(271, 27);
            txtdesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(825, 121);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Precio:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(881, 116);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(271, 27);
            txtprecio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(825, 88);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "Marca:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(881, 83);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(271, 27);
            txtmarca.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(825, 154);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 10;
            label6.Text = "Stock:";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(881, 149);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(271, 27);
            txtstock.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(808, 201);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(344, 66);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(808, 282);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(166, 48);
            btneditar.TabIndex = 12;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(986, 282);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(166, 48);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 390);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(label6);
            Controls.Add(txtstock);
            Controls.Add(label3);
            Controls.Add(txtprecio);
            Controls.Add(label4);
            Controls.Add(txtmarca);
            Controls.Add(label2);
            Controls.Add(txtdesc);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
    }
}