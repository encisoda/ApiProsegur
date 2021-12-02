using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WinFormsApp2
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}

	public class Clima
	{

		static HttpClient client = new HttpClient();
		private const string URL = "api.openweathermap.org/data/2.5/weather?q=";
		private string APIkey = "9df32da903b50f1451dd73ec93f04cc6";


	}


}
