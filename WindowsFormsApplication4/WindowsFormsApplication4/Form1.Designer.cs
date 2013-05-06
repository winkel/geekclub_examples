namespace WindowsFormsApplication4
{
	partial class Form1
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
			this.cornerA1 = new System.Windows.Forms.PictureBox();
			this.cornerA2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.cornerA1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cornerA2)).BeginInit();
			this.SuspendLayout();
			// 
			// cornerA1
			// 
			this.cornerA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cornerA1.Location = new System.Drawing.Point(53, 39);
			this.cornerA1.Margin = new System.Windows.Forms.Padding(0);
			this.cornerA1.Name = "cornerA1";
			this.cornerA1.Size = new System.Drawing.Size(9, 9);
			this.cornerA1.TabIndex = 0;
			this.cornerA1.TabStop = false;
			this.cornerA1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cornerA1_MouseDown);
			this.cornerA1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cornerA1_MouseMove);
			this.cornerA1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cornerA1_MouseUp);
			// 
			// cornerA2
			// 
			this.cornerA2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cornerA2.Location = new System.Drawing.Point(53, 155);
			this.cornerA2.Margin = new System.Windows.Forms.Padding(0);
			this.cornerA2.Name = "cornerA2";
			this.cornerA2.Size = new System.Drawing.Size(10, 10);
			this.cornerA2.TabIndex = 1;
			this.cornerA2.TabStop = false;
			this.cornerA2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cornerA2_MouseDown);
			this.cornerA2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cornerA2_MouseMove);
			this.cornerA2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cornerA2_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.cornerA2);
			this.Controls.Add(this.cornerA1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.cornerA1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cornerA2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox cornerA1;
		private System.Windows.Forms.PictureBox cornerA2;
	}
}

