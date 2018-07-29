/*
 * Created by SharpDevelop.
 * User: Cahyana
 * Date: 25/04/2018
 * Time: 13:09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace latihan1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void Button2Click(object sender, EventArgs e)
		{
			serialPort1.PortName = comboBox1.SelectedItem.ToString();
			serialPort1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
			
			serialPort1.Open();	
		}
		void Button1Click(object sender, EventArgs e)
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
				
		void comboBox1_Mouse(object sender, MouseEventArgs e)
		{
			comboBox1.Items.Clear();
			string[] ports = SerialPort.GetPortNames();
			foreach(string port in ports)
			{
				comboBox1.Items.Add(port);
			}
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen == true)
			{
				radioButton1.Text ="Status : Terhubung ";
				radioButton1.Checked = true;
			}
			else
			{
				radioButton1.Text="Status: Tidak Terhubung";
				radioButton1.Checked = false;
			}
		}
		
		void comboBox1Selected(object sender, EventArgs e)
		{
			
		}
		
		
	}
}
