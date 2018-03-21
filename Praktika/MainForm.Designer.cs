/*
 * Created by SharpDevelop.
 * User: honmi
 * Date: 08.06.2017
 * Time: 2:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace praktika
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox airDensity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox gasDensity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox weight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox volume;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox gasP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox height;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox baloonP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox arhimedF;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox upF;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox gasWeight;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.TextBox temperature;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Timer tmr;
		private System.Windows.Forms.PictureBox imgBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.airDensity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gasDensity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.weight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.volume = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.gasP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.baloonP = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.arhimedF = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.upF = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.gasWeight = new System.Windows.Forms.TextBox();
			this.Start = new System.Windows.Forms.Button();
			this.temperature = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tmr = new System.Windows.Forms.Timer(this.components);
			this.imgBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
			this.SuspendLayout();
			// 
			// airDensity
			// 
			this.airDensity.Location = new System.Drawing.Point(12, 575);
			this.airDensity.Name = "airDensity";
			this.airDensity.ReadOnly = true;
			this.airDensity.Size = new System.Drawing.Size(165, 20);
			this.airDensity.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 555);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Плотность воздуха (кг/м^3)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Плотность газа (кг/м^3)";
			// 
			// gasDensity
			// 
			this.gasDensity.Location = new System.Drawing.Point(12, 29);
			this.gasDensity.Name = "gasDensity";
			this.gasDensity.Size = new System.Drawing.Size(165, 20);
			this.gasDensity.TabIndex = 2;
			this.gasDensity.Text = "0,178";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Масса груза (кг)";
			// 
			// weight
			// 
			this.weight.Location = new System.Drawing.Point(12, 72);
			this.weight.Name = "weight";
			this.weight.Size = new System.Drawing.Size(165, 20);
			this.weight.TabIndex = 4;
			this.weight.Text = "50";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Объем шара (м^3)";
			// 
			// volume
			// 
			this.volume.Location = new System.Drawing.Point(12, 115);
			this.volume.Name = "volume";
			this.volume.Size = new System.Drawing.Size(165, 20);
			this.volume.TabIndex = 6;
			this.volume.Text = "10";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Вес газа (Н)";
			// 
			// gasP
			// 
			this.gasP.Location = new System.Drawing.Point(12, 372);
			this.gasP.Name = "gasP";
			this.gasP.ReadOnly = true;
			this.gasP.Size = new System.Drawing.Size(165, 20);
			this.gasP.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 512);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Высота над уровнем моря (м)";
			// 
			// height
			// 
			this.height.Location = new System.Drawing.Point(12, 532);
			this.height.Name = "height";
			this.height.ReadOnly = true;
			this.height.Size = new System.Drawing.Size(165, 20);
			this.height.TabIndex = 10;
			this.height.Text = "0";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 395);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "Вес шара (Н)";
			// 
			// baloonP
			// 
			this.baloonP.Location = new System.Drawing.Point(12, 415);
			this.baloonP.Name = "baloonP";
			this.baloonP.ReadOnly = true;
			this.baloonP.Size = new System.Drawing.Size(165, 20);
			this.baloonP.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 598);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(165, 15);
			this.label9.TabIndex = 17;
			this.label9.Text = "Сила Архимеда (Н)";
			// 
			// arhimedF
			// 
			this.arhimedF.Location = new System.Drawing.Point(12, 616);
			this.arhimedF.Name = "arhimedF";
			this.arhimedF.ReadOnly = true;
			this.arhimedF.Size = new System.Drawing.Size(165, 20);
			this.arhimedF.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 639);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(165, 15);
			this.label10.TabIndex = 19;
			this.label10.Text = "Подъемная сила (Н)";
			// 
			// upF
			// 
			this.upF.Location = new System.Drawing.Point(12, 657);
			this.upF.Name = "upF";
			this.upF.ReadOnly = true;
			this.upF.Size = new System.Drawing.Size(165, 20);
			this.upF.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 309);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 17);
			this.label8.TabIndex = 21;
			this.label8.Text = "Масса газа (кг)";
			// 
			// gasWeight
			// 
			this.gasWeight.Location = new System.Drawing.Point(12, 329);
			this.gasWeight.Name = "gasWeight";
			this.gasWeight.ReadOnly = true;
			this.gasWeight.Size = new System.Drawing.Size(165, 20);
			this.gasWeight.TabIndex = 20;
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(12, 198);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(165, 23);
			this.Start.TabIndex = 22;
			this.Start.Text = "Старт";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.StartClick);
			// 
			// temperature
			// 
			this.temperature.Location = new System.Drawing.Point(12, 172);
			this.temperature.Name = "temperature";
			this.temperature.Size = new System.Drawing.Size(165, 20);
			this.temperature.TabIndex = 23;
			this.temperature.Text = "15";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(165, 31);
			this.label11.TabIndex = 24;
			this.label11.Text = "Температура воздуха на уровне моря (°C)";
			// 
			// tmr
			// 
			this.tmr.Interval = 1;
			this.tmr.Tick += new System.EventHandler(this.TmrTick);
			// 
			// imgBox
			// 
			this.imgBox.BackColor = System.Drawing.Color.Transparent;
			this.imgBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgBox.BackgroundImage")));
			this.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.imgBox.Location = new System.Drawing.Point(485, 519);
			this.imgBox.Name = "imgBox";
			this.imgBox.Size = new System.Drawing.Size(95, 158);
			this.imgBox.TabIndex = 25;
			this.imgBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1008, 689);
			this.Controls.Add(this.imgBox);
			this.Controls.Add(this.temperature);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Start);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.gasWeight);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.upF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gasDensity);
			this.Controls.Add(this.weight);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.arhimedF);
			this.Controls.Add(this.volume);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.baloonP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.height);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gasP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.airDensity);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "МОДЕЛЬ АЭРОСТАТА";
			((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
