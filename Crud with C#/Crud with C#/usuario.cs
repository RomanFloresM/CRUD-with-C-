/*
 * Created by SharpDevelop.
 * User: rmflores
 * Date: 04/01/2023
 * Time: 01:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Crud_with_C_
{
	/// <summary>
	/// Description of usuario.
	/// </summary>
	public class usuario
	{
		
		
		private string nickname;
			
		private string correo;
		
		private string pass;
		
		private string fecha;
		
		private int id;
		
		
		
		
		
		
		public usuario()
		{
			
		}
		
		public void set_Nick (string a ) {
			nickname = a;
		}
		
		public void set_correo(string a) {
			correo = a;
		}
		
		public void set_pass (string a) {
			byte[] aBytes =  ASCIIEncoding.ASCII.GetBytes(a);
			
			aBytes = new MD5CryptoServiceProvider().ComputeHash(aBytes);
			                                      
			var sha = new System.Security.Cryptography.SHA256Managed();
			
			byte[] ValorHash = sha.ComputeHash(aBytes);
			
			pass = BitConverter.ToString(ValorHash);
			
		
		}
		
		public void set_fecha(string a){
			fecha = a;
		}
		
		public void set_id(int a) {
			id = a;
		}
		
		public string Nickname {
			get { return nickname; }
		}
		
		public string Correo {
			get { return correo; }
		}
		
		public string Pass {
			get { return pass; }
		}
		
		public string Fecha {
			get { return fecha; }
		}
		
		public int Id {
			get { return id; }
		}
		
	}
}
