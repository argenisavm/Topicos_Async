namespace AsyncEjemplo
{
	partial class NoAsync
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.Imagen = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(92, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 47);
			this.button1.TabIndex = 0;
			this.button1.Text = "Iniciar Tarea";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Imagen
			// 
			this.Imagen.Location = new System.Drawing.Point(92, 188);
			this.Imagen.Name = "Imagen";
			this.Imagen.Size = new System.Drawing.Size(149, 47);
			this.Imagen.TabIndex = 1;
			this.Imagen.Text = "Imagen";
			this.Imagen.UseVisualStyleBackColor = true;
			this.Imagen.Click += new System.EventHandler(this.Imagen_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(302, 68);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(348, 47);
			this.progressBar1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AsyncEjemplo.Properties.Resources.IMG_0414;
			this.pictureBox1.Location = new System.Drawing.Point(377, 188);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(161, 165);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(575, 390);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 33);
			this.button2.TabIndex = 4;
			this.button2.Text = "Volver";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// NoAsync
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.Imagen);
			this.Controls.Add(this.button1);
			this.Name = "NoAsync";
			this.Text = "NoAsync";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Imagen;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
	}
}