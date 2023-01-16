/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 05:03 p. m.
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
	/// Description of grid.
	/// </summary>
	public partial class grid : Form
	{
		
		public grid(usuario a)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			labelID.Text = Convert.ToString(a.Id);
			LaNickaname.Text = a.Nickname;
			LaCorreo.Text = a.Correo;
			Lafecha.Text = a.Fecha;
			
			
			string selete = "select * from examusuario2 with(nolock)";
			string login = @"Data Source=127.0.0.1;Initial Catalog=Pruebas;User ID=admin;Password=admin";
			
			SqlConnection cnn = new SqlConnection(login);
			
			cnn.Open();
			
			SqlDataAdapter b = new SqlDataAdapter(selete, cnn);
			
			DataSet d = new DataSet();
			
			b.Fill(d, "examusuario2");
			tablita.DataSource = d;
			tablita.DataMember = "examusuario2";
			
			cnn.Close();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BuscarTextChanged(object sender, EventArgs e)
		{
			
			string selete = "select * from examusuario2 with(nolock) where Nickname like( '%"+ buscar.Text +"%')" ;
			string login = @"Data Source=127.0.0.1;Initial Catalog=Pruebas;User ID=admin;Password=admin";
			
			SqlConnection cnn = new SqlConnection(login);
			
			cnn.Open();
			
			SqlDataAdapter b = new SqlDataAdapter(selete, cnn);
			
			DataSet d = new DataSet();
			
			b.Fill(d, "examusuario2");
			tablita.DataSource = d;
			tablita.DataMember = "examusuario2";
			
			cnn.Close();
		}
		
		void EliminarClick(object sender, EventArgs e)
		{
			string a = Convert.ToString(tablita.CurrentRow.Cells[0].Value);
				
				
			string selete = "select * from examusuario2 with(nolock) where Nickname like( '%"+ buscar.Text +"%')" ;
			string login = @"Data Source=127.0.0.1;Initial Catalog=Pruebas;User ID=admin;Password=admin";
			string delete = "delete from examusuario2 where id = "+a;
			
			
			SqlConnection cnn = new SqlConnection(login);
			
			cnn.Open();
			
			SqlCommand exe = cnn.CreateCommand();
			exe.CommandText = delete;
			
				
			if (exe.ExecuteNonQuery() > 0) {
				SqlDataAdapter b = new SqlDataAdapter(selete, cnn);
			
				DataSet d = new DataSet();
				
				b.Fill(d, "examusuario2");
				tablita.DataSource = d;
				tablita.DataMember = "examusuario2";
			
			}
			else {
				MessageBox.Show("Tenemos un problema houston");
			}
			
			
			cnn.Close();
							
		}
		
		void AgregarClick(object sender, EventArgs e)
		{
			var form2 = new agregar();
	        form2.ShowDialog();
	        InitializeComponent();
		    
		}
	}
}
