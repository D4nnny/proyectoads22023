﻿
namespace Vista_PrototipoMenu
{
    partial class TrasladoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrasladoProductos));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_precioUnit = new System.Windows.Forms.TextBox();
            this.txt_precioTotal = new System.Windows.Forms.TextBox();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_bodega = new System.Windows.Forms.TextBox();
            this.txt_almacen = new System.Windows.Forms.TextBox();
            this.txt_nombreProc = new System.Windows.Forms.TextBox();
            this.txt_idProc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_costoTotal = new System.Windows.Forms.Label();
            this.lbl_precioTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_traslaProd = new System.Windows.Forms.DataGridView();
            this.btn_remover = new System.Windows.Forms.Button();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precioUnit);
            this.groupBox3.Controls.Add(this.txt_precioTotal);
            this.groupBox3.Controls.Add(this.txt_costoTotal);
            this.groupBox3.Controls.Add(this.txt_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(557, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(480, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contabilidad";
            // 
            // txt_precioUnit
            // 
            this.txt_precioUnit.Location = new System.Drawing.Point(188, 112);
            this.txt_precioUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precioUnit.Name = "txt_precioUnit";
            this.txt_precioUnit.Size = new System.Drawing.Size(269, 23);
            this.txt_precioUnit.TabIndex = 7;
            this.txt_precioUnit.Tag = "Prod_PrecioUnitario";
            // 
            // txt_precioTotal
            // 
            this.txt_precioTotal.Location = new System.Drawing.Point(188, 84);
            this.txt_precioTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precioTotal.Name = "txt_precioTotal";
            this.txt_precioTotal.Size = new System.Drawing.Size(269, 23);
            this.txt_precioTotal.TabIndex = 6;
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Location = new System.Drawing.Point(188, 57);
            this.txt_costoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(269, 23);
            this.txt_costoTotal.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(188, 28);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(269, 23);
            this.txt_cantidad.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Precio Unitario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Costo Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_bodega);
            this.groupBox2.Controls.Add(this.txt_almacen);
            this.groupBox2.Controls.Add(this.txt_nombreProc);
            this.groupBox2.Controls.Add(this.txt_idProc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(480, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // txt_bodega
            // 
            this.txt_bodega.Location = new System.Drawing.Point(188, 112);
            this.txt_bodega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bodega.Name = "txt_bodega";
            this.txt_bodega.Size = new System.Drawing.Size(269, 23);
            this.txt_bodega.TabIndex = 7;
            this.txt_bodega.Tag = "Alm_Ubicacion";
            // 
            // txt_almacen
            // 
            this.txt_almacen.Location = new System.Drawing.Point(188, 84);
            this.txt_almacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_almacen.Name = "txt_almacen";
            this.txt_almacen.Size = new System.Drawing.Size(269, 23);
            this.txt_almacen.TabIndex = 6;
            this.txt_almacen.Tag = "Pk_AlmacenID";
            // 
            // txt_nombreProc
            // 
            this.txt_nombreProc.Location = new System.Drawing.Point(188, 57);
            this.txt_nombreProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreProc.Name = "txt_nombreProc";
            this.txt_nombreProc.Size = new System.Drawing.Size(269, 23);
            this.txt_nombreProc.TabIndex = 5;
            this.txt_nombreProc.Tag = "Prod_Nombre";
            // 
            // txt_idProc
            // 
            this.txt_idProc.Location = new System.Drawing.Point(188, 28);
            this.txt_idProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idProc.Name = "txt_idProc";
            this.txt_idProc.Size = new System.Drawing.Size(269, 23);
            this.txt_idProc.TabIndex = 4;
            this.txt_idProc.Tag = "Pk_ProductoID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bodega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Almacen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombreDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idDoc);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(31, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1005, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentación";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.Image")));
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_aceptar.Location = new System.Drawing.Point(791, 18);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(192, 66);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(543, 52);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(175, 23);
            this.txt_fecha.TabIndex = 13;
            this.txt_fecha.Tag = "Doc_Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha:";
            // 
            // txt_nombreDoc
            // 
            this.txt_nombreDoc.Location = new System.Drawing.Point(543, 23);
            this.txt_nombreDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreDoc.Name = "txt_nombreDoc";
            this.txt_nombreDoc.Size = new System.Drawing.Size(175, 23);
            this.txt_nombreDoc.TabIndex = 11;
            this.txt_nombreDoc.Tag = "Doc_Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Documento:";
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(147, 53);
            this.txt_destino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(289, 23);
            this.txt_destino.TabIndex = 8;
            this.txt_destino.Tag = "Alm_Ubicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destino:";
            // 
            // txt_idDoc
            // 
            this.txt_idDoc.Location = new System.Drawing.Point(147, 25);
            this.txt_idDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idDoc.Name = "txt_idDoc";
            this.txt_idDoc.Size = new System.Drawing.Size(289, 23);
            this.txt_idDoc.TabIndex = 6;
            this.txt_idDoc.Tag = "Pk_DocumentoID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(71, 801);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "COSTO TOTAL:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 801);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "PRECIO TOTAL:";
            // 
            // lbl_costoTotal
            // 
            this.lbl_costoTotal.AutoSize = true;
            this.lbl_costoTotal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoTotal.Location = new System.Drawing.Point(97, 828);
            this.lbl_costoTotal.Name = "lbl_costoTotal";
            this.lbl_costoTotal.Size = new System.Drawing.Size(21, 19);
            this.lbl_costoTotal.TabIndex = 17;
            this.lbl_costoTotal.Text = "...";
            // 
            // lbl_precioTotal
            // 
            this.lbl_precioTotal.AutoSize = true;
            this.lbl_precioTotal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioTotal.Location = new System.Drawing.Point(446, 828);
            this.lbl_precioTotal.Name = "lbl_precioTotal";
            this.lbl_precioTotal.Size = new System.Drawing.Size(21, 19);
            this.lbl_precioTotal.TabIndex = 18;
            this.lbl_precioTotal.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_traslaProd);
            this.groupBox4.Controls.Add(this.btn_remover);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(31, 434);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1005, 353);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Traslados";
            // 
            // dgv_traslaProd
            // 
            this.dgv_traslaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_traslaProd.Location = new System.Drawing.Point(32, 30);
            this.dgv_traslaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_traslaProd.Name = "dgv_traslaProd";
            this.dgv_traslaProd.RowHeadersWidth = 51;
            this.dgv_traslaProd.RowTemplate.Height = 24;
            this.dgv_traslaProd.Size = new System.Drawing.Size(853, 304);
            this.dgv_traslaProd.TabIndex = 0;
            this.dgv_traslaProd.Tag = "tbl_productos";
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_remover.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Image = ((System.Drawing.Image)(resources.GetObject("btn_remover.Image")));
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_remover.Location = new System.Drawing.Point(896, 30);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(87, 71);
            this.btn_remover.TabIndex = 14;
            this.btn_remover.Text = "Remover";
            this.btn_remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(163, 6);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 181);
            this.navegador1.TabIndex = 20;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // TrasladoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1064, 872);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_precioTotal);
            this.Controls.Add(this.lbl_costoTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "TrasladoProductos";
            this.Text = "4500 - TrasladoProductos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_precioUnit;
        private System.Windows.Forms.TextBox txt_precioTotal;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_bodega;
        private System.Windows.Forms.TextBox txt_almacen;
        private System.Windows.Forms.TextBox txt_nombreProc;
        private System.Windows.Forms.TextBox txt_idProc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_costoTotal;
        private System.Windows.Forms.Label lbl_precioTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_traslaProd;
        private System.Windows.Forms.Button btn_remover;
        private NavegadorVista.Navegador navegador1;
    }
}