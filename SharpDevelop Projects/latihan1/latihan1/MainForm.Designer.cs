/*
 * Created by SharpDevelop.
 * User: Cahyana
 * Date: 25/04/2018
 * Time: 13:09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace latihan1
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(23, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "COMPORT";
			this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_Mouse);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1Selected);
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
			this.comboBox2.Location = new System.Drawing.Point(23, 51);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "BAUDRATE";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(23, 78);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(121, 47);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 131);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 38);
			this.button2.TabIndex = 5;
			this.button2.Text = "Sambungkan";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 175);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 37);
			this.button1.TabIndex = 6;
			this.button1.Text = "Putuskan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(200, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(197, 87);
			this.button3.TabIndex = 8;
			this.button3.Text = "Nyalakan Lampu";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(200, 117);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(197, 86);
			this.button4.TabIndex = 9;
			this.button4.Text = "Matikan Lampu";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 279);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "MainForm";
			this.Text = "latihan1";
			this.ResumeLayout(false);
		}
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		
		void RadioButton1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
