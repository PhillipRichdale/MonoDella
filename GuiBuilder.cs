/*
using System;

namespace MonoDella
{
	public class GuiBuilder
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action DellaAction;
		private global::Gtk.Action BearbeitenAction;
		private global::Gtk.Action AnsichtAction;
		private global::Gtk.Action HilfeAction;
		private global::Gtk.VBox mainVBox;
		private global::Gtk.MenuBar mainMenuBar;
		private global::Gtk.ScrolledWindow scrollArea;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.Statusbar statusbar;
		public GuiBuilder (Gtk.Window win)
		{
			win.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup aG = new global::Gtk.ActionGroup ("Default");

			win.DellaAction = new global::Gtk.Action ("DellaAction", global::Mono.Unix.Catalog.GetString ("Della"), null, null);
			win.DellaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Della");
			aG.Add (this.DellaAction, null);

			win.BearbeitenAction = new global::Gtk.Action ("BearbeitenAction", global::Mono.Unix.Catalog.GetString ("Bearbeiten"), null, null);
			win.BearbeitenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Bearbeiten");
			aG.Add (this.BearbeitenAction, null);

			win.AnsichtAction = new global::Gtk.Action ("AnsichtAction", global::Mono.Unix.Catalog.GetString ("Ansicht"), null, null);
			win.AnsichtAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Ansicht");
			aG.Add (this.AnsichtAction, null);

			win.HilfeAction = new global::Gtk.Action ("HilfeAction", global::Mono.Unix.Catalog.GetString ("Hilfe"), null, null);
			win.HilfeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hilfe");
			aG.Add (this.HilfeAction, null);

			win.UIManager.InsertActionGroup (aG, 0);
			win.AddAccelGroup (this.UIManager.AccelGroup);
			win.Name = "MainWindow";
			win.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			win.WindowPosition = ((global::Gtk.WindowPosition)(4));
			win.AllowShrink = true;
			win.Gravity = ((global::Gdk.Gravity)(5));

			// Container child MainWindow.Gtk.Container+ContainerChild
			win.mainVBox = new global::Gtk.VBox ();
			win.mainVBox.Name = "mainVBox";
			win.mainVBox.Spacing = 6;

			// Container child mainVBox.Gtk.Box+BoxChild
			win.UIManager.AddUiFromString ("<ui><menubar name='mainMenuBar'><menu name='DellaAction1' action='DellaAction1'/><menu name='BearbeitenAction' action='BearbeitenAction'/><menu name='AnsichtAction' action='AnsichtAction'/><menu name='HilfeAction' action='HilfeAction'/></menubar></ui>");
			win.mainMenuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/mainMenuBar")));
			win.mainMenuBar.Name = "mainMenuBar";
			win.mainVBox.Add (this.mainMenuBar);

			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.mainMenuBar]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;

			// Container child mainVBox.Gtk.Box+BoxChild
			this.scrollArea = new global::Gtk.ScrolledWindow ();
			this.scrollArea.CanFocus = true;
			this.scrollArea.Name = "scrollArea";
			this.scrollArea.ShadowType = ((global::Gtk.ShadowType)(1));

			// Container child scrollArea.Gtk.Container+ContainerChild
			global::Gtk.Viewport w3 = new global::Gtk.Viewport ();
			w3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			w3.Add (this.fixed2);
			this.scrollArea.Add (w3);
			this.mainVBox.Add (this.scrollArea);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.scrollArea]));
			w6.Position = 1;
			// Container child mainVBox.Gtk.Box+BoxChild
			this.statusbar = new global::Gtk.Statusbar ();
			this.statusbar.Name = "statusbar";
			this.statusbar.Spacing = 6;
			this.mainVBox.Add (this.statusbar);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.mainVBox [this.statusbar]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.mainVBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 604;
			this.DefaultHeight = 400;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}
	}
}
*/