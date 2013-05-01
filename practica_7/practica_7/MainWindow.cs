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
		int puntos =0;


		if(this.opca.Active)
			puntos++;

		if(this.spm.Text == "4")

		if(this.opa.Active)
			puntos++;
		if(this.opd.Active)
			puntos++;



		DateTime fecha = this.calendario.GetDate();
		string fechaseleccionada = fecha.ToShortDateString();
		if(fechaseleccionada == "16/09/1810"){
			puntos++;
		}
		string a,b;

		a= nombre.Text;
		b= codigo.Text;







		MessageDialog md = new MessageDialog (null, 
		                                      DialogFlags.Modal,
		                                      MessageType.Info, 
		                                      ButtonsType.None,"Nombre : "+ a +"\n"+ "Codigo: "+b + "\n" +
		                                      "Grupo: " +
		                                      "Ha obtenido: " + puntos + " aciertos");
		md.Show();
		                                      

	}


}
