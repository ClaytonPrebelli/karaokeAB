
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KaraokePrebelli
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
		var status = vlcControl1.State;
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
		object senderGeral = new object();
		private async void txtNumero_KeyDown(object sender, KeyEventArgs e)
		{
			senderGeral = sender;
			var tecla = e.KeyCode;
			if (txtNumero.Text.Length >= 4 && e.KeyCode == Keys.Enter && encontrado)
			{


				playVideo();
				



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
					fechaVideo();

				}
			
			



		}
		public void playVideo()
		{
			
			var url = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/musicas/" + video;
			vlcControl1.Play(new Uri(url));

			
			
				vlcControl1.BringToFront();
				vlcControl1.VlcMediaPlayer.Video.FullScreen = true;
				vlcControl1.Show();
				vlcControl1.Video.FullScreen = true;
			
			
			/*
			vlcControl1.SendToBack();
			vlcControl1.SendToBack();
			vlcControl1.Stop();
			lblNomeMusica.Visible = false;
			lblMusica.Visible = false;
			lblCantor.Visible = false;
			lblNomeCantor.Visible = false;
			lblNomeTrecho.Visible = false;
			lblTrecho.Visible = false;
			txtNumero_Click(null, null);*/
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
		public void fechaVideo()
		{
			if (vlcControl1.State.ToString() == "Stopped")
			{

			}
			else { vlcControl1.Stop(); }
			vlcControl1.SendToBack();
			vlcControl1.SendToBack();
			lblNomeMusica.Visible = false;
			lblMusica.Visible = false;
			lblCantor.Visible = false;
			lblNomeCantor.Visible = false;
			lblNomeTrecho.Visible = false;
			lblTrecho.Visible = false;
			txtNumero_Click(null, null);
			
			
			


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
		
		private void vlcControl1_EndReached(object sender, Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs e)
		{
			//SendKeys.SendWait("{ESC}");
			
			/*vlcControl1.Invoke(new Action(() =>
		   {
			   vlcControl1.Stop();
			   vlcControl1.SendToBack();
			   
		   }));
			lblNomeMusica.Invoke(new Action(() =>
			{
				lblNomeMusica.Visible = false;
				lblNomeMusica.Text = "";
			}));
			lblMusica.Invoke(new Action(() =>
			   {
				   lblMusica.Visible = false;
			   }));
			lblCantor.Invoke(new Action(() =>
			{
				lblCantor.Visible = false;
			}));
			lblNomeCantor.Invoke(new Action(() =>
			{
				lblNomeCantor.Visible = false;
			}));
			lblNomeTrecho.Invoke(new Action(() =>
			{
				lblNomeTrecho.Visible = false;
			}));
			lblTrecho.Invoke(new Action(() =>
			{
				lblTrecho.Visible = false;

			}));




			
			txtNumero_Click(null, null);*/


			//txtNumero_KeyDown(sender, pressionarEsc);




		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void vlcControl1_Stopped_1(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
		{
		
			
		}
		
	}
}
