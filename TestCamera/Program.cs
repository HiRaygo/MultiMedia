/*
 * 由SharpDevelop创建。
 * 用户： XiaoSanya
 * 日期: 2015/5/3
 * 时间: 12:14
 */
using System;
using Raygo.MM;
using System.Diagnostics;

namespace TestCamera
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Camera cm = new Camera(Process.GetCurrentProcess().MainWindowHandle,640,480);
			if(cm.StartCamera()){
				cm.CaptureImage("d:\\abc.jpg");
				cm.StopCamera();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}