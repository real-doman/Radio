namespace Programmieraufgabe;

public class Radio{

    public bool on { get; set; }
    public double volume{ get; set; }
    public double frequency { get; set; }

    public Radio(bool on, double volume, double frequency){

        //verhindere negative Werte fuer Lautstearke und Frequenz
        //funktioniert nur bei objekt erzeugung, nicht wenn setter Methode verwendet wird
        if(volume < 0){
            volume = 0.0;
        }

        if(frequency < 0){
            frequency = 0.0;
        }

        this.on = on;
        this.volume = volume;
        this.frequency = frequency;
    }

}