using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int puntos= 0;
		if(this.radiobutton2.Active)puntos++;
		if(this.spinbutton1.Text=="4")puntos++;
		if(this.checkbutton1.Active)puntos++;
		if(this.checkbutton2.Active)puntos++;
		DateTime fecha = this.calendar1.GetDate();
		string fechaseleccionada=fecha.ToShortDateString();
		if (fechaseleccionada=="16/09/1810"){
			puntos++;
	}
		MessageDialog md = new MessageDialog (null, DialogFlags.Modal,MessageType.Info, 
		                                      ButtonsType.None,"Este es tu resultado: "+puntos); 
		md.Show();
}
}
