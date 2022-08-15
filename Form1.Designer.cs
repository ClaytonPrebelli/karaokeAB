namespace karaokeAB
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
			this.player = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(610, 664);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(200, 55);
			this.txtNumero.TabIndex = 0;
			this.txtNumero.Text = "0000";
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
			// 
			// lblNomeMusica
			// 
			this.lblNomeMusica.AutoSize = true;
			this.lblNomeMusica.BackColor = System.Drawing.Color.Transparent;
			this.lblNomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeMusica.Location = new System.Drawing.Point(473, 476);
			this.lblNomeMusica.Name = "lblNomeMusica";
			this.lblNomeMusica.Size = new System.Drawing.Size(127, 37);
			this.lblNomeMusica.TabIndex = 1;
			this.lblNomeMusica.Text = "Musica:";
			this.lblNomeMusica.Visible = false;
			// 
			// lblMusica
			// 
			this.lblMusica.AutoSize = true;
			this.lblMusica.BackColor = System.Drawing.Color.Transparent;
			this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMusica.Location = new System.Drawing.Point(606, 476);
			this.lblMusica.Name = "lblMusica";
			this.lblMusica.Size = new System.Drawing.Size(259, 37);
			this.lblMusica.TabIndex = 2;
			this.lblMusica.Text = "Nome da musica";
			this.lblMusica.Visible = false;
			// 
			// lblNomeCantor
			// 
			this.lblNomeCantor.AutoSize = true;
			this.lblNomeCantor.BackColor = System.Drawing.Color.Transparent;
			this.lblNomeCantor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.lblCantor.BackColor = System.Drawing.Color.Transparent;
			this.lblCantor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.lblNomeTrecho.BackColor = System.Drawing.Color.Transparent;
			this.lblNomeTrecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.lblTrecho.BackColor = System.Drawing.Color.Transparent;
			this.lblTrecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTrecho.Location = new System.Drawing.Point(609, 570);
			this.lblTrecho.Name = "lblTrecho";
			this.lblTrecho.Size = new System.Drawing.Size(238, 33);
			this.lblTrecho.TabIndex = 6;
			this.lblTrecho.Text = "trecho da musica";
			this.lblTrecho.Visible = false;
			// 
			// player
			// 
			this.player.Enabled = true;
			this.player.Location = new System.Drawing.Point(982, 383);
			this.player.Name = "player";
			this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
			this.player.Size = new System.Drawing.Size(324, 177);
			this.player.TabIndex = 7;
			// 
			// Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 752);
			this.ControlBox = false;
			this.Controls.Add(this.player);
			this.Controls.Add(this.lblTrecho);
			this.Controls.Add(this.lblNomeTrecho);
			this.Controls.Add(this.lblCantor);
			this.Controls.Add(this.lblNomeCantor);
			this.Controls.Add(this.lblMusica);
			this.Controls.Add(this.lblNomeMusica);
			this.Controls.Add(this.txtNumero);
			this.Name = "Index";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nome da musica";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Index_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNomeMusica;
		private System.Windows.Forms.Label lblMusica;
		private System.Windows.Forms.Label lblNomeCantor;
		private System.Windows.Forms.Label lblCantor;
		private System.Windows.Forms.Label lblNomeTrecho;
		private System.Windows.Forms.Label lblTrecho;
		private AxWMPLib.AxWindowsMediaPlayer player;
	}
}

