/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 01:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Crud_with_C_
{
	partial class agregar
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
			this.nickBox = new System.Windows.Forms.TextBox();
			this.mailbox = new System.Windows.Forms.TextBox();
			this.passbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nickBox
			// 
			this.nickBox.Location = new System.Drawing.Point(196, 54);
			this.nickBox.Name = "nickBox";
			this.nickBox.Size = new System.Drawing.Size(163, 20);
			this.nickBox.TabIndex = 0;
			// 
			// mailbox
			// 
			this.mailbox.Location = new System.Drawing.Point(196, 110);
			this.mailbox.Name = "mailbox";
			this.mailbox.Size = new System.Drawing.Size(163, 20);
			this.mailbox.TabIndex = 1;
			// 
			// passbox
			// 
			this.passbox.Location = new System.Drawing.Point(196, 161);
			this.passbox.Name = "passbox";
			this.passbox.PasswordChar = 'X';
			this.passbox.Size = new System.Drawing.Size(163, 20);
			this.passbox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(76, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nickname";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(76, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Correo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(76, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Contraseña";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(105, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Registrar Usuario";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(265, 220);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "cerrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 305);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passbox);
			this.Controls.Add(this.mailbox);
			this.Controls.Add(this.nickBox);
			this.Name = "agregar";
			this.Text = "agregar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox passbox;
		private System.Windows.Forms.TextBox mailbox;
		private System.Windows.Forms.TextBox nickBox;
	}
}
