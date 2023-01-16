/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 03:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;  
using System.Data;  
using System.Data.SqlClient;  
using System.Configuration;

namespace Crud_with_C_
{
	/// <summary>
	/// Description of login.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string login = @"Data Source=127.0.0.1;Initial Catalog=Pruebas;User ID=admin;Password=admin";
			int c = 0;
			usuario a = new usuario();
			a.set_correo(correobox.Text);
			a.set_pass(contrabox.Text);
			
			using (SqlConnection cnn = new SqlConnection(login)) {
				using (SqlCommand b = new SqlCommand("examSpConsultacorreo", cnn)) {
					cnn.Open();
					b.CommandType = CommandType.StoredProcedure;
					
					b.Parameters.Add("@correo", SqlDbType.VarChar).Value = a.Correo;
					b.Parameters.Add("@pass", SqlDbType.VarChar).Value = a.Pass;
					
					c = Convert.ToInt32(b.ExecuteScalar());
					
					
					if (c > 0) {
						SqlCommand selete = new SqlCommand("Select RegistroFecha from examusuario2 with(nolock) where correo = '"+ a.Correo +"'", cnn);
						
						 
						string result = Convert.ToString(selete.ExecuteScalar());
						
						a.set_fecha(result);
						
						selete = new SqlCommand("Select id from examusuario2 with(nolock) where correo = '"+ a.Correo +"'", cnn);
						
						
						int id_r = Convert.ToInt32(selete.ExecuteScalar());
						
						a.set_id(id_r);
						
						selete = new SqlCommand("Select Nickname from examusuario2 with(nolock) where correo = '"+ a.Correo +"'", cnn);
						
						
						string N = Convert.ToString(selete.ExecuteScalar());
						
						a.set_Nick(N);
						
						
						cnn.Close();
						
						
						var form2 = new grid(a);
						this.Hide();
				        form2.ShowDialog();
				        
					    this.Close();
						
					}
					else {
						MessageBox.Show("Correo o contraseña invalidos intente de nuevo");
					}
					
					cnn.Close();
				}
			}
			
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	
		    this.Close();
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			var form2 = new agregar();
			
			form2.ShowDialog();
		}
	}
}
