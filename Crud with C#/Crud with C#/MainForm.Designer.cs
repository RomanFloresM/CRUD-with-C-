/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 03:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Crud_with_C_
{
	partial class MainForm
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
			this.correobox = new System.Windows.Forms.TextBox();
			this.contrabox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// correobox
			// 
			this.correobox.Location = new System.Drawing.Point(142, 68);
			this.correobox.Name = "correobox";
			this.correobox.Size = new System.Drawing.Size(100, 20);
			this.correobox.TabIndex = 0;
			// 
			// contrabox
			// 
			this.contrabox.Location = new System.Drawing.Point(142, 127);
			this.contrabox.Name = "contrabox";
			this.contrabox.PasswordChar = '*';
			this.contrabox.Size = new System.Drawing.Size(100, 20);
			this.contrabox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Location = new System.Drawing.Point(36, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Correo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoEllipsis = true;
			this.label2.Location = new System.Drawing.Point(36, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "contraseña";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label2.UseMnemonic = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(226, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(36, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(166, 189);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "salir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(101, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "Agregar ";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.contrabox);
			this.Controls.Add(this.correobox);
			this.Name = "MainForm";
			this.Text = "examen";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox contrabox;
		private System.Windows.Forms.TextBox correobox;
	}
}
