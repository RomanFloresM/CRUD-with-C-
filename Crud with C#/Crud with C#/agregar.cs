/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 01:40 p. m.
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
using System.Text.RegularExpressions;



namespace Crud_with_C_
{	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class agregar : Form
	{
		
		public agregar()
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
			
			string prueba = mailbox.Text;
		
			bool verificarEmail = prueba.Contains("@") && prueba.Contains(".com") || prueba.Contains(".mx");
			
			string nickname = nickBox.Text;
            bool verificarNickname = Regex.IsMatch(nickname, @"^[a-zA-Z0-9]+$");
            
            if (verificarEmail == true  && verificarNickname == true) {
            	string login = @"Data Source=127.0.0.1;Initial Catalog=Pruebas;User ID=admin;Password=admin";
            	string buscar = "select isnull(correo,'No') from examusuario2 where correo = '" + mailbox.Text + "'";
				usuario a = new usuario();
				
				
				a.set_Nick(nickBox.Text);
				a.set_correo(mailbox.Text);
				a.set_pass(passbox.Text);
				
				
				
				using (SqlConnection cnn = new SqlConnection(login)) {
					using (SqlCommand b = new SqlCommand("examSpInsertarUsuario", cnn)) {
						
						cnn.Open();
						
						SqlCommand resultado = cnn.CreateCommand();
						resultado.CommandText = buscar;
						
						if (Convert.ToString(resultado.ExecuteScalar()) == "No") {
							b.CommandType = CommandType.StoredProcedure;
						
							b.Parameters.Add("@Nick", SqlDbType.VarChar).Value = a.Nickname;
							b.Parameters.Add("@mail", SqlDbType.VarChar).Value = a.Correo;
							b.Parameters.Add("@pass", SqlDbType.VarChar).Value = a.Pass;
							
							b.ExecuteNonQuery();
							MessageBox.Show("Exito puedes ingresar otro usuario");
						}
						
						
						MessageBox.Show("Correo repetido");
						cnn.Close();
					}
				}
				
				
				
				nickBox.Clear();
				mailbox.Clear();
				passbox.Clear();
			
            }
            	
            else {
            	MessageBox.Show("Correo o Nickname incorrectos");
            	
            }
			
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
	        
		    
		}
		
	}
}
