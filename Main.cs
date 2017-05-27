using System;
using Gtk;

namespace MonoDella
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Della della = new Della();
			della.testRun();

			Application.Init();
			MainWindow win = new MainWindow ();
			//win.Title = "Della CASE Tool";
			win.Title = "MonoDella";
			win.Show();
			Application.Run();
		}
	}
}