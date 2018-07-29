/*
 * Created by SharpDevelop.
 * User: Cahyana
 * Date: 25/04/2018
 * Time: 14:54:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelDataSerial = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(13, 27);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "COMPORT";
			this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_mouse);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
									"9600",
									"19200",
									"38400",
									"57600",
									"115200"});
			this.comboBox2.Location = new System.Drawing.Point(13, 74);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "BAUD RATE";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(13, 110);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(121, 33);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Status: Tidak Terhubung";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Hubungkan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 199);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Putuskan";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(225, 28);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 109);
			this.button3.TabIndex = 5;
			this.button3.Text = "Nyala";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(225, 143);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 90);
			this.button4.TabIndex = 6;
			this.button4.Text = "Matikan";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(357, 28);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "L1 ON";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(357, 66);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "L2 ON";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(357, 146);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 9;
			this.button7.Text = "L3 ON";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(357, 210);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 10;
			this.button8.Text = "L4 ON";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(461, 28);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 11;
			this.button9.Text = "L1 OFF";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(461, 66);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 12;
			this.button10.Text = "L2 OFF";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(461, 146);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 13;
			this.button11.Text = "L3 OFF";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(461, 210);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 14;
			this.button12.Text = "L4 OFF";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.LargeChange = 0;
			this.vScrollBar1.Location = new System.Drawing.Point(555, 28);
			this.vScrollBar1.Maximum = 255;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(73, 141);
			this.vScrollBar1.SmallChange = 0;
			this.vScrollBar1.TabIndex = 15;
			this.vScrollBar1.Value = 255;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1Scroll);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(555, 210);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Aktif Timer";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(557, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "label1";
			// 
			// vScrollBar2
			// 
			this.vScrollBar2.LargeChange = 0;
			this.vScrollBar2.Location = new System.Drawing.Point(651, 28);
			this.vScrollBar2.Maximum = 255;
			this.vScrollBar2.Name = "vScrollBar2";
			this.vScrollBar2.Size = new System.Drawing.Size(72, 139);
			this.vScrollBar2.SmallChange = 0;
			this.vScrollBar2.TabIndex = 18;
			this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar2Scroll);
			// 
			// vScrollBar3
			// 
			this.vScrollBar3.LargeChange = 0;
			this.vScrollBar3.Location = new System.Drawing.Point(740, 27);
			this.vScrollBar3.Maximum = 255;
			this.vScrollBar3.Name = "vScrollBar3";
			this.vScrollBar3.Size = new System.Drawing.Size(72, 146);
			this.vScrollBar3.SmallChange = 0;
			this.vScrollBar3.TabIndex = 19;
			this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar3Scroll);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(651, 212);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(161, 20);
			this.textBox1.TabIndex = 20;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(651, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(740, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "label3";
			// 
			// labelDataSerial
			// 
			this.labelDataSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDataSerial.Location = new System.Drawing.Point(18, 148);
			this.labelDataSerial.Name = "labelDataSerial";
			this.labelDataSerial.Size = new System.Drawing.Size(100, 23);
			this.labelDataSerial.TabIndex = 23;
			this.labelDataSerial.Text = "A0B100C20D";
			this.labelDataSerial.Click += new System.EventHandler(this.LabelDataSerialClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(140, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(73, 93);
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(141, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(73, 93);
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(140, 129);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(74, 93);
			this.pictureBox3.TabIndex = 26;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(140, 130);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(76, 91);
			this.pictureBox4.TabIndex = 27;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(140, 232);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(74, 89);
			this.pictureBox5.TabIndex = 28;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(140, 233);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(74, 87);
			this.pictureBox6.TabIndex = 29;
			this.pictureBox6.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
									"Data Record:"});
			this.listBox1.Location = new System.Drawing.Point(830, 28);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(188, 173);
			this.listBox1.TabIndex = 30;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(830, 208);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 31;
			this.checkBox2.Text = "Start Record";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// timer3
			// 
			this.timer3.Interval = 2000;
			this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 343);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelDataSerial);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.vScrollBar3);
			this.Controls.Add(this.vScrollBar2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "MainForm";
			this.Text = "tugas1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelDataSerial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.VScrollBar vScrollBar3;
		private System.Windows.Forms.VScrollBar vScrollBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
