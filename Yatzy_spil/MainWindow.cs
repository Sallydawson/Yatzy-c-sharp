using System;
using Gtk;
using Yatzy_spil;



public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel) //mainwindow er vores contructer

    {
        Build();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //Klassen Muligheder --> mulighederNy (muligvis op under MainWindow:gtk.window)
    // --> mulighederNy = new Muligheder(baegerNy) (muligvis skal dette under "Build();"

    //public Muligheder mulighederNy = new Muligheder(b);
    public Bæger mitbaeger = new Bæger(); //opretter lige et nyt bæger fra bægerklassen
    //private static Bæger b;


    private void VisTerninger()
    {
        terning1.Text = Convert.ToString(mitbaeger.terning1.Oejne); //her smider vi antallet af øjne ud i vores entrys, så man kan se dem i interface
        terning2.Text = Convert.ToString(mitbaeger.terning2.Oejne);
        terning3.Text = Convert.ToString(mitbaeger.terning3.Oejne);
        terning4.Text = Convert.ToString(mitbaeger.terning4.Oejne);
        terning5.Text = Convert.ToString(mitbaeger.terning5.Oejne);
    }

    //KNAPPER

    protected void OnKastTerningerClicked(object sender, EventArgs e) //vores kast terninger knappe
    {
        mitbaeger.RystBaeger(); //her kaldes metoden frem, så det sker når man klikker på knappen
        //når programmet kører her, så er det en sekvens af objekter

        VisTerninger();
    }

}

