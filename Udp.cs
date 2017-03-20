using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace Udp
{
	public partial class Form1: Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		IPAddress ip;
		IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
		string protocol;
		long time;
		Socket aimSocket;
		UdpClient RecUdpClient;
		
		private void Form1_Load(object sender, EventArgs e)
		{
			cobProtocol.SelectedIndex = 0;
			txtIP.Text = GetAddressIP();
			
