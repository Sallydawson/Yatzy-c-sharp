
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;

	private global::Gtk.Fixed fixed5;

	private global::Gtk.Entry entry_hoejde;

	private global::Gtk.Label Højde;

	private global::Gtk.Button button3;

	private global::Gtk.Entry entry_vaegt;

	private global::Gtk.Label label2;

	private global::Gtk.Label label4;

	private global::Gtk.Label label3;

	private global::Gtk.Label label5;

	private global::Gtk.Entry entry12;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.fixed5 = new global::Gtk.Fixed();
		this.fixed5.Name = "fixed5";
		this.fixed5.HasWindow = false;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.entry_hoejde = new global::Gtk.Entry();
		this.entry_hoejde.CanFocus = true;
		this.entry_hoejde.Name = "entry_hoejde";
		this.entry_hoejde.IsEditable = true;
		this.fixed5.Add(this.entry_hoejde);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.entry_hoejde]));
		w1.X = 230;
		w1.Y = 91;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.Højde = new global::Gtk.Label();
		this.Højde.Name = "Højde";
		this.Højde.LabelProp = global::Mono.Unix.Catalog.GetString("Højde");
		this.fixed5.Add(this.Højde);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.Højde]));
		w2.X = 180;
		w2.Y = 93;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Udregn BMI");
		this.fixed5.Add(this.button3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.button3]));
		w3.X = 230;
		w3.Y = 196;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.entry_vaegt = new global::Gtk.Entry();
		this.entry_vaegt.CanFocus = true;
		this.entry_vaegt.Name = "entry_vaegt";
		this.entry_vaegt.IsEditable = true;
		this.fixed5.Add(this.entry_vaegt);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.entry_vaegt]));
		w4.X = 230;
		w4.Y = 139;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Vægt");
		this.fixed5.Add(this.label2);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.label2]));
		w5.X = 180;
		w5.Y = 142;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("KG");
		this.fixed5.Add(this.label4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.label4]));
		w6.X = 400;
		w6.Y = 142;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("CM");
		this.fixed5.Add(this.label3);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.label3]));
		w7.X = 400;
		w7.Y = 93;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Din BMI er =");
		this.fixed5.Add(this.label5);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.label5]));
		w8.X = 180;
		w8.Y = 252;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.entry12 = new global::Gtk.Entry();
		this.entry12.WidthRequest = 82;
		this.entry12.CanFocus = true;
		this.entry12.Name = "entry12";
		this.entry12.IsEditable = false;
		this.fixed5.Add(this.entry12);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed5[this.entry12]));
		w9.X = 230;
		w9.Y = 273;
		this.alignment1.Add(this.fixed5);
		this.Add(this.alignment1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 606;
		this.DefaultHeight = 317;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button3.Clicked += new global::System.EventHandler(this.on_click);
	}
}
