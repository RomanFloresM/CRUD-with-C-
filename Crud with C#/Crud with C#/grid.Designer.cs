/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 05:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Crud_with_C_
{
	partial class grid
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LaNickaname = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LaCorreo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Lafecha = new System.Windows.Forms.Label();
			this.buscar = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Agregar = new System.Windows.Forms.Button();
			this.tablita = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.tablita)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// labelID
			// 
			this.labelID.Location = new System.Drawing.Point(43, 9);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(100, 23);
			this.labelID.TabIndex = 1;
			this.labelID.Text = "vacio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nickname: ";
			// 
			// LaNickaname
			// 
			this.LaNickaname.Location = new System.Drawing.Point(79, 32);
			this.LaNickaname.Name = "LaNickaname";
			this.LaNickaname.Size = new System.Drawing.Size(100, 23);
			this.LaNickaname.TabIndex = 3;
			this.LaNickaname.Text = "Nickname";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(327, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Correo: ";
			// 
			// LaCorreo
			// 
			this.LaCorreo.Location = new System.Drawing.Point(377, 8);
			this.LaCorreo.Name = "LaCorreo";
			this.LaCorreo.Size = new System.Drawing.Size(156, 23);
			this.LaCorreo.TabIndex = 5;
			this.LaCorreo.Text = "label4";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(330, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fecha Registro";
			// 
			// Lafecha
			// 
			this.Lafecha.Location = new System.Drawing.Point(436, 32);
			this.Lafecha.Name = "Lafecha";
			this.Lafecha.Size = new System.Drawing.Size(88, 23);
			this.Lafecha.TabIndex = 7;
			this.Lafecha.Text = "label5";
			// 
			// buscar
			// 
			this.buscar.Location = new System.Drawing.Point(64, 65);
			this.buscar.Name = "buscar";
			this.buscar.Size = new System.Drawing.Size(100, 20);
			this.buscar.TabIndex = 9;
			this.buscar.TextChanged += new System.EventHandler(this.BuscarTextChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Buscar";
			// 
			// Eliminar
			// 
			this.Eliminar.Location = new System.Drawing.Point(79, 328);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(75, 23);
			this.Eliminar.TabIndex = 11;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.EliminarClick);
			// 
			// Agregar
			// 
			this.Agregar.Location = new System.Drawing.Point(352, 328);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(75, 23);
			this.Agregar.TabIndex = 12;
			this.Agregar.Text = "Agregar";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.AgregarClick);
			// 
			// tablita
			// 
			this.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablita.Location = new System.Drawing.Point(12, 114);
			this.tablita.Name = "tablita";
			this.tablita.Size = new System.Drawing.Size(521, 198);
			this.tablita.TabIndex = 13;
			// 
			// grid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 363);
			this.Controls.Add(this.tablita);
			this.Controls.Add(this.Agregar);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.buscar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Lafecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LaCorreo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LaNickaname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.label1);
			this.Name = "grid";
			this.Text = "grid";
			((System.ComponentModel.ISupportInitialize)(this.tablita)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView tablita;
		private System.Windows.Forms.Button Agregar;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox buscar;
		
		private System.Windows.Forms.Label Lafecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LaCorreo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LaNickaname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label label1;
	}
}
