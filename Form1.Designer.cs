using System;
using Vlc.DotNet.Core;

namespace KaraokePrebelli
{
	partial class Index
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNomeMusica = new System.Windows.Forms.Label();
			this.lblMusica = new System.Windows.Forms.Label();
			this.lblNomeCantor = new System.Windows.Forms.Label();
			this.lblCantor = new System.Windows.Forms.Label();
			this.lblNomeTrecho = new System.Windows.Forms.Label();
			this.lblTrecho = new System.Windows.Forms.Label();
			this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNumero.BackColor = System.Drawing.Color.Black;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.Yellow;
			this.txtNumero.Location = new System.Drawing.Point(610, 662);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(200, 62);
			this.txtNumero.TabIndex = 0;
			this.txtNumero.Text = "0000";
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNumero.Click += new System.EventHandler(this.txtNumero_Click);
			this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
			// 
			// lblNomeMusica
			// 
			this.lblNomeMusica.AutoSize = true;
			this.lblNomeMusica.BackColor = System.Drawing.Color.Black;
			this.lblNomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeMusica.ForeColor = System.Drawing.Color.Yellow;
			this.lblNomeMusica.Location = new System.Drawing.Point(473, 476);
			this.lblNomeMusica.Name = "lblNomeMusica";
			this.lblNomeMusica.Size = new System.Drawing.Size(127, 37);
			this.lblNomeMusica.TabIndex = 1;
			this.lblNomeMusica.Text = "Musica:";
			this.lblNomeMusica.Visible = false;
			this.lblNomeMusica.Click += new System.EventHandler(this.lblNomeMusica_Click);
			// 
			// lblMusica
			// 
			this.lblMusica.AutoSize = true;
			this.lblMusica.BackColor = System.Drawing.Color.Black;
			this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMusica.ForeColor = System.Drawing.Color.Yellow;
			this.lblMusica.Location = new System.Drawing.Point(606, 476);
			this.lblMusica.Name = "lblMusica";
			this.lblMusica.Size = new System.Drawing.Size(259, 37);
			this.lblMusica.TabIndex = 2;
			this.lblMusica.Text = "Nome da musica";
			this.lblMusica.Visible = false;
			this.lblMusica.Click += new System.EventHandler(this.lblMusica_Click);
			// 
			// lblNomeCantor
			// 
			this.lblNomeCantor.AutoSize = true;
			this.lblNomeCantor.BackColor = System.Drawing.Color.Black;
			this.lblNomeCantor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeCantor.ForeColor = System.Drawing.Color.Yellow;
			this.lblNomeCantor.Location = new System.Drawing.Point(473, 523);
			this.lblNomeCantor.Name = "lblNomeCantor";
			this.lblNomeCantor.Size = new System.Drawing.Size(123, 37);
			this.lblNomeCantor.TabIndex = 3;
			this.lblNomeCantor.Text = "Cantor:";
			this.lblNomeCantor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNomeCantor.Visible = false;
			this.lblNomeCantor.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblCantor
			// 
			this.lblCantor.AutoSize = true;
			this.lblCantor.BackColor = System.Drawing.Color.Black;
			this.lblCantor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantor.ForeColor = System.Drawing.Color.Yellow;
			this.lblCantor.Location = new System.Drawing.Point(608, 523);
			this.lblCantor.Name = "lblCantor";
			this.lblCantor.Size = new System.Drawing.Size(254, 37);
			this.lblCantor.TabIndex = 4;
			this.lblCantor.Text = "Nome do Cantor";
			this.lblCantor.Visible = false;
			this.lblCantor.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// lblNomeTrecho
			// 
			this.lblNomeTrecho.AutoSize = true;
			this.lblNomeTrecho.BackColor = System.Drawing.Color.Black;
			this.lblNomeTrecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeTrecho.ForeColor = System.Drawing.Color.Yellow;
			this.lblNomeTrecho.Location = new System.Drawing.Point(473, 570);
			this.lblNomeTrecho.Name = "lblNomeTrecho";
			this.lblNomeTrecho.Size = new System.Drawing.Size(117, 37);
			this.lblNomeTrecho.TabIndex = 5;
			this.lblNomeTrecho.Text = "Trecho";
			this.lblNomeTrecho.Visible = false;
			// 
			// lblTrecho
			// 
			this.lblTrecho.AutoSize = true;
			this.lblTrecho.BackColor = System.Drawing.Color.Black;
			this.lblTrecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrecho.ForeColor = System.Drawing.Color.Yellow;
			this.lblTrecho.Location = new System.Drawing.Point(609, 570);
			this.lblTrecho.Name = "lblTrecho";
			this.lblTrecho.Size = new System.Drawing.Size(238, 33);
			this.lblTrecho.TabIndex = 6;
			this.lblTrecho.Text = "trecho da musica";
			this.lblTrecho.Visible = false;
			// 
			// vlcControl1
			// 
			this.vlcControl1.BackColor = System.Drawing.Color.Black;
			this.vlcControl1.Location = new System.Drawing.Point(0, 0);
			this.vlcControl1.MaximumSize = new System.Drawing.Size(1366, 791);
			this.vlcControl1.MinimumSize = new System.Drawing.Size(1366, 791);
			this.vlcControl1.Name = "vlcControl1";
			this.vlcControl1.Size = new System.Drawing.Size(1366, 791);
			this.vlcControl1.Spu = -1;
			this.vlcControl1.TabIndex = 7;
			this.vlcControl1.TabStop = false;
			this.vlcControl1.Text = "player";
			this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
			this.vlcControl1.VlcMediaplayerOptions = null;
			this.vlcControl1.EndReached += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEndReachedEventArgs>(this.vlcControl1_EndReached);
			this.vlcControl1.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.vlcControl1_Playing);
			this.vlcControl1.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.vlcControl1_Stopped_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1366, 788);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1350, 749);
			this.ControlBox = false;
			this.Controls.Add(this.lblTrecho);
			this.Controls.Add(this.lblNomeTrecho);
			this.Controls.Add(this.lblCantor);
			this.Controls.Add(this.lblNomeCantor);
			this.Controls.Add(this.lblMusica);
			this.Controls.Add(this.lblNomeMusica);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.vlcControl1);
			this.DoubleBuffered = true;
			this.Name = "Index";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nome da musica";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Index_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void vlcControl1_Stopped(object sender, VlcMediaPlayerStoppedEventArgs e)
		{

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNomeMusica;
		private System.Windows.Forms.Label lblMusica;
		private System.Windows.Forms.Label lblNomeCantor;
		private System.Windows.Forms.Label lblCantor;
		private System.Windows.Forms.Label lblNomeTrecho;
		private System.Windows.Forms.Label lblTrecho;
		public Vlc.DotNet.Forms.VlcControl vlcControl1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

