using Programmieraufgabe;

public class RunCode{

    static void Main(string[] args){
        
        //erzeuge (neues) Radio-Objekt und setze Standardwerte
        var radio = new Radio(true, 50.0, 123.7); //on/off, volume, frequency
        KonsolenAusgabe(radio);

        //Aenderung der Werte kann ueber Setter Methoden erfolgen, z.B.:
        radio.on = false;
        radio.volume = -25.0;
        radio.frequency = -10.0;
        /*Um Werte erneut ausgeben zu lassen, muss Wert erneut ueber Getter Methoden
        in Variable gespeichert werden. Ausgabe ueber Konsole moeglich*/
        KonsolenAusgabe(radio);       
    }

    private static void KonsolenAusgabe(Radio radio){
        
        /*erhalte ueber Getter Methoden die aktuellen Werte
        von Radio an/aus, Lautstaerke und Frequenz und speichere diese in Variablen*/
        bool radioOn = radio.on;
        double volume = radio.volume;
        double frequency = radio.frequency;

        /*catch negative Werte fuer Frequenz und Lautstärke, da das nicht negativ sein kann.
        Setzte Wert dann auf 0. (Koennte je nach Wunsch/Anforderung anders behandelt werden)*/
        if(volume < 0){
            volume = 0.0;
        }

        if(frequency < 0){
            frequency = 0.0;
        }

        //Ausgabe der Werte/des Status in Konsole
        if (radioOn == true){
            Console.WriteLine("\nRadio ist an.");
        }else{
            Console.WriteLine("\nRadio ist aus.");
        }
        Console.WriteLine("Radio Lautstärke ist " + volume + " db.\nSpiele Musik ab.\nDadadie Dadadada.");
        Console.WriteLine("Radio Frequenz ist " + frequency + " Hz.\n\n");
    }

}