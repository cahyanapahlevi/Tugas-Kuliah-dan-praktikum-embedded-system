/*
 * Created by SharpDevelop.
 * User: Cahyana
 * Date: 25/04/2018
 * Time: 14:54:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace tugas1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string dataTerima;
		delegate void stringInvoke(string text);
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			serialPort1.PortName = comboBox1.SelectedItem.ToString();
			serialPort1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
			
			serialPort1.Open();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			serialPort1.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("on");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("off");
		}
		
		void comboBox1_mouse(object sender, MouseEventArgs e)
		{
			comboBox1.Items.Clear();
			string[] ports = SerialPort.GetPortNames();
			foreach (string port in ports)
			{
				comboBox1.Items.Add(port);
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen == true)
			{
				radioButton1.Text = "Status: Terhubung";
				radioButton1.Checked = true;
			}
			else
			{
				radioButton1.Text = "Status: Tidak Terhubung";
				radioButton1.Checked = false;
			}
			
			//PRAKTIKUM 5 P2//
			/*if (labelDataSerial.Text.Substring(0,1) == "1")
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = false;
			}
			else
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;
			}
			if (labelDataSerial.Text.Substring(1,1) == "1")
			{
				pictureBox3.Visible = true;
				pictureBox4.Visible = false;
			}
			else
			{
				pictureBox3.Visible = false;
				pictureBox4.Visible = true;
			}
			if (labelDataSerial.Text.Substring(2,1) == "1")
			{
				pictureBox5.Visible = true;
				pictureBox6.Visible = false;
			}
			else
			{
				pictureBox5.Visible = false;
				pictureBox6.Visible = true;
			}*/
			
			//PRAKTIKUM 6//
			int nA = labelDataSerial.Text.IndexOf("A");
			int nB = labelDataSerial.Text.IndexOf("B");
			int nC = labelDataSerial.Text.IndexOf("C");
			int nD = labelDataSerial.Text.IndexOf("D");
			
			label1.Text = "Nilai: " + labelDataSerial.Text.Substring(nA + 1, nB - nA-1);
			label2.Text = "Nilai: " + labelDataSerial.Text.Substring(nB + 1, nC - nB-1);
			label3.Text = "Nilai: " + labelDataSerial.Text.Substring(nC + 1, nD - nC-1);
			
			int value1 = Convert.ToInt32(labelDataSerial.Text.Substring(nA + 1, nB - nA-1));
			int value2 = Convert.ToInt32(labelDataSerial.Text.Substring(nB + 1, nC - nB-1));
			int value3 = Convert.ToInt32(labelDataSerial.Text.Substring(nC + 1, nD - nC-1));
			
			vScrollBar1.Value = value1;
			vScrollBar2.Value = value2;
			vScrollBar3.Value = value3;
		}
				
		void Button5Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("A");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("B");
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("C");
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("D");
		}
		
		
		void Button9Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("a");
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("b");
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("c");
		}
		void Button12Click(object sender, EventArgs e)
		{
			serialPort1.WriteLine("d");
		}
		
		
		
		void VScrollBar1Scroll(object sender, ScrollEventArgs e)
		{
			label1.Text = "Nilai: " + vScrollBar1.Value.ToString();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				timer2.Enabled = true;
			}
			if (checkBox1.Checked == false)
			{
				timer2.Enabled = false;
			}
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			String dataKirim = "A" + vScrollBar1.Value.ToString() + "B" +
				vScrollBar2.Value.ToString() + "C" +
				vScrollBar3.Value.ToString() + "D";
			textBox1.Text = dataKirim;
			serialPort1.WriteLine(dataKirim);
		}
		
		void VScrollBar2Scroll(object sender, ScrollEventArgs e)
		{
			label2.Text = "Nilai: " + vScrollBar1.Value.ToString();
		}
		
		void VScrollBar3Scroll(object sender, ScrollEventArgs e)
		{
			label3.Text = "Nilai: " + vScrollBar1.Value.ToString();
		}
		
		
		void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			dataTerima = serialPort1.ReadLine();
			SetText(dataTerima);
			dataTerima = "";
		}
		void SetText(string text)
		{
			if (this.labelDataSerial.InvokeRequired)
			{
				stringInvoke d = new stringInvoke(SetText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.labelDataSerial.Text =text;
			}
		}
		
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LabelDataSerialClick(object sender, EventArgs e)
		{
			
		}		
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void Timer3Tick(object sender, EventArgs e)
		{
			string dataRecord;
			DateTime localDate = DateTime.Now;
			dataRecord = localDate.ToString() + ": " + vScrollBar3.Value.ToString();
			listBox1.Items.Add(dataRecord);
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked ==true)
			{
				timer3.Enabled = true;
			}
			else
			{
				timer3.Enabled = false;
			}
		}
	}
}
