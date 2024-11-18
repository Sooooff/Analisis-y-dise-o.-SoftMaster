namespace SoftMaster
{
   partial class modulosPrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modulosPrin));
            this.bInventario = new System.Windows.Forms.Button();
            this.bfacturacion = new System.Windows.Forms.Button();
            this.bReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bInventario
            // 
            this.bInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bInventario.BackgroundImage")));
            this.bInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bInventario.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInventario.Location = new System.Drawing.Point(71, 161);
            this.bInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInventario.Name = "bInventario";
            this.bInventario.Size = new System.Drawing.Size(276, 250);
            this.bInventario.TabIndex = 0;
            this.bInventario.UseVisualStyleBackColor = true;
            this.bInventario.Click += new System.EventHandler(this.bInventario_Click);
            // 
            // bfacturacion
            // 
            this.bfacturacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfacturacion.BackgroundImage")));
            this.bfacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfacturacion.Location = new System.Drawing.Point(389, 161);
            this.bfacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfacturacion.Name = "bfacturacion";
            this.bfacturacion.Size = new System.Drawing.Size(276, 250);
            this.bfacturacion.TabIndex = 1;
            this.bfacturacion.UseVisualStyleBackColor = true;
            // 
            // bReporte
            // 
            this.bReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bReporte.BackgroundImage")));
            this.bReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReporte.Location = new System.Drawing.Point(716, 161);
            this.bReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bReporte.Name = "bReporte";
            this.bReporte.Size = new System.Drawing.Size(276, 250);
            this.bReporte.TabIndex = 2;
            this.bReporte.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Facturacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione al sitio al que desea ingresar";
            // 
            // Reporte
            // 
            this.Reporte.AutoSize = true;
            this.Reporte.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(124, 428);
            this.Reporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(124, 31);
            this.Reporte.TabIndex = 7;
            this.Reporte.Text = "Inventario";
            // 
            // modulosPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bReporte);
            this.Controls.Add(this.bfacturacion);
            this.Controls.Add(this.bInventario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "modulosPrin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.modulosPrin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button bInventario;
      private System.Windows.Forms.Button bfacturacion;
      private System.Windows.Forms.Button bReporte;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label Reporte;
   }
}