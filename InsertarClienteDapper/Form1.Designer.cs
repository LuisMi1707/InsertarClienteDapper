namespace InsertarClienteDapper
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.txbIDProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbBuscarporID = new System.Windows.Forms.TextBox();
            this.btnBuscarporID = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(39, 96);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(483, 265);
            this.dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marca";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(627, 139);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 6;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(627, 165);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txbDescripcion.TabIndex = 7;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(627, 191);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 8;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecio_KeyPress);
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(627, 217);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(100, 20);
            this.txbStock.TabIndex = 9;
            this.txbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbStock_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(627, 243);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 20);
            this.txbMarca.TabIndex = 10;
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Location = new System.Drawing.Point(627, 311);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(100, 23);
            this.btnInsertarProducto.TabIndex = 11;
            this.btnInsertarProducto.Text = "Insertar";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categoria";
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(627, 269);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(100, 20);
            this.txbCategoria.TabIndex = 13;
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(39, 385);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(100, 23);
            this.btnObtenerTodo.TabIndex = 14;
            this.btnObtenerTodo.Text = "Obtener Todo";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // txbIDProducto
            // 
            this.txbIDProducto.Location = new System.Drawing.Point(627, 113);
            this.txbIDProducto.Name = "txbIDProducto";
            this.txbIDProducto.Size = new System.Drawing.Size(100, 20);
            this.txbIDProducto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "IDProducto";
            // 
            // txbBuscarporID
            // 
            this.txbBuscarporID.Location = new System.Drawing.Point(332, 388);
            this.txbBuscarporID.Name = "txbBuscarporID";
            this.txbBuscarporID.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarporID.TabIndex = 17;
            // 
            // btnBuscarporID
            // 
            this.btnBuscarporID.Location = new System.Drawing.Point(439, 386);
            this.btnBuscarporID.Name = "btnBuscarporID";
            this.btnBuscarporID.Size = new System.Drawing.Size(83, 23);
            this.btnBuscarporID.TabIndex = 18;
            this.btnBuscarporID.Text = "Buscar por ID";
            this.btnBuscarporID.UseVisualStyleBackColor = true;
            this.btnBuscarporID.Click += new System.EventHandler(this.btnBuscarporID_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Insertar producto con Dapper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscarporID);
            this.Controls.Add(this.txbBuscarporID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIDProducto);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInsertarProducto);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCategoria;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.TextBox txbIDProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBuscarporID;
        private System.Windows.Forms.Button btnBuscarporID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

