using Amazon.Runtime.Internal.Util;
using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static karaokeAB.Program;

namespace karaokeAB
{
	

	public partial class Index : Form
	{
		byte[] musica;
		byte[] cantor;
		byte[] trecho;
		String video = "";
		bool encontrado = false;
		String pesquisado = "";
		FullScreen fullScreen = new FullScreen();

		public Index()
		{
			InitializeComponent();
		}
		
		private void Index_Load(object sender, EventArgs e)
		{
			var fullScreenMode = true;
			
			if (fullScreenMode)  // FullScreenMode is an enum
			{
				fullScreen.EnterFullScreenMode(this);
				fullScreenMode = true;
			}
			else
			{
				fullScreen.LeaveFullScreenMode(this);
				fullScreenMode = false;
			}
			txtNumero.Focus();
		}
		
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
			if(txtNumero.Text.Length >= 4)
			{

				if(txtNumero.Text.Length == 4)
				{
					pesquisado = txtNumero.Text.PadLeft(5, '0');
				}
				IniFile arquivo = new IniFile(@"BD.ini");
				arquivo.TryGetSection(pesquisado, out var section);
				if(section != null && section.Count() >0)
				{
					encontrado = true;
					musica = Encoding.Default.GetBytes(section["musica"].ToString());
					cantor = Encoding.Default.GetBytes(section["artista"].ToString());
					video = section["arquivo"];
					trecho = Encoding.Default.GetBytes(section["inicio"].ToString());
					lblNomeMusica.Visible = true;
					lblMusica.Text = Encoding.UTF8.GetString(musica).ToUpper();
					lblMusica.Visible = true;
					lblCantor.Text = Encoding.UTF8.GetString(cantor).ToUpper();
					lblCantor.Visible = true;
					lblNomeCantor.Visible = true;
					lblNomeTrecho.Visible = true;
					lblTrecho.Text = Encoding.UTF8.GetString(trecho).ToUpper();
					lblTrecho.Visible = true;
				}
				else
				{
					var textoNao = "Nao Encontrado";

					byte[] nao = new byte[textoNao.Length];
					for (int i = 0; i < textoNao.Length; ++i)
					{
						nao[i] = (byte)textoNao[i];
					}

					

					encontrado = true;
					musica = nao;
					cantor = nao;
					video = "";
					trecho = nao;
					lblNomeMusica.Visible = true;
					lblMusica.Text = Encoding.UTF8.GetString(musica).ToUpper();
					lblMusica.Visible = true;
					lblCantor.Text = Encoding.UTF8.GetString(cantor).ToUpper();
					lblCantor.Visible = true;
					lblNomeCantor.Visible = true;
					lblNomeTrecho.Visible = true;
					lblTrecho.Text = Encoding.UTF8.GetString(trecho).ToUpper();
					lblTrecho.Visible = true;

				}

			}
			else
			{
				lblNomeMusica.Visible = false;
				lblMusica.Visible = false;
				lblCantor.Visible = false;
				lblNomeCantor.Visible = false;
				lblNomeTrecho.Visible = false;
				lblTrecho.Visible = false;
			}
		}
		
		private void txtNumero_KeyDown(object sender, KeyEventArgs e)
		{
			var tecla = e.KeyCode;
			if(txtNumero.Text.Length >= 4 && e.KeyCode == Keys.Enter && encontrado)
			{
				
				
				var url = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +"/musicas/" + video;
				vlcControl1.Visible = true;
				vlcControl1.VlcMediaPlayer.Video.FullScreen = true;
				vlcControl1.Show();
				vlcControl1.Video.FullScreen = true;
				
				vlcControl1.Play(new Uri(url));

				var status = vlcControl1.State;


			}
			if (e.KeyCode == Keys.Up)
			{
				
			}
			if (e.KeyData.ToString() == "Down")
			{
				vlcControl1.Audio.Channel -= 5;
			}
			
		if (e.KeyData.ToString() == "Escape")
			{
				vlcControl1.Stop();
				vlcControl1.Visible = false;
				lblNomeMusica.Visible = false;
				lblMusica.Visible = false;
				lblCantor.Visible = false;
				lblNomeCantor.Visible = false;
				lblNomeTrecho.Visible = false;
				lblTrecho.Visible = false;
				txtNumero_Click(null, null);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void lblNomeMusica_Click(object sender, EventArgs e)
		{

		}

		private void lblMusica_Click(object sender, EventArgs e)
		{

		}
		

		private void txtNumero_Click(object sender, EventArgs e)
		{
			txtNumero.Text = "";
			txtNumero.Focus();
		}

		private void vlcControl1_Playing(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
		{
		
		}
	}
}
