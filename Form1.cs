using Amazon.Runtime.Internal.Util;
using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback
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

		public Index()
		{
			InitializeComponent();
		}

		private void Index_Load(object sender, EventArgs e)
		{
			
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
					musica = Encoding.UTF8.GetBytes(section["musica"]);
					cantor = Encoding.UTF8.GetBytes(section["artista"]);
					video = section["arquivo"];
					trecho = Encoding.UTF8.GetBytes(section["inicio"]);
					lblNomeMusica.Visible = true;
					lblMusica.Text = Encoding.UTF8.GetString(musica);
					lblMusica.Visible = true;
					lblCantor.Text = Encoding.UTF8.GetString(cantor);
					lblCantor.Visible = true;
					lblNomeCantor.Visible = true;
					lblNomeTrecho.Visible = true;
					lblTrecho.Text = Encoding.UTF8.GetString(trecho);
					lblTrecho.Visible = true;
				}
				else
				{
					encontrado = true;
					musica = Encoding.UTF8.GetBytes("Não Encontrado");
					cantor = Encoding.UTF8.GetBytes("Não Encontrado");
					video = "";
					trecho = Encoding.UTF8.GetBytes("Não Encontrado");
					lblNomeMusica.Visible = true;
					lblMusica.Text = Encoding.UTF8.GetString(musica);
					lblMusica.Visible = true;
					lblCantor.Text = Encoding.UTF8.GetString(cantor);
					lblCantor.Visible = true;
					lblNomeCantor.Visible = true;
					lblNomeTrecho.Visible = true;
					lblTrecho.Text = Encoding.UTF8.GetString(trecho);
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
			if(txtNumero.Text.Length >= 4 && e.KeyCode == Keys.Enter && encontrado)
			{
				player.Visible = true;
				player.Show();
				var url = @"\musicas\" + video;
				player.newMedia(url);
				player.Ctlcontrols.play();


			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
