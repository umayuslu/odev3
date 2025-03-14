using System;
using System.Collections.Generic;

class Araba
{
    public string Marka { get; set; }
    public double Benzintuketimi{ get; set; }
    
    
}

class Program
{static void Main()
    {
        List<Araba> arabalar = new List<Araba>() ;
        Araba bmw = new Araba() { Marka = "BMW", Benzintuketimi = 30 };
        Araba porsche = new Araba() { Marka = "PORSCHE", Benzintuketimi = 20 };
        Araba mercedes = new Araba() { Marka = "MERCESHE", Benzintuketimi = 34 };
        arabalar.Add(bmw);
        arabalar.Add(porsche);
        arabalar.Add(mercedes);

        double totalyakittuketimi=0;
        
        foreach (var araba in arabalar)
        {
            Console.WriteLine("MARKA: " + araba.Marka + " YAKIT TÜKETİMİ: " + araba.Benzintuketimi);

        }
        
        foreach (var araba in arabalar)
        {
            totalyakittuketimi+=araba.Benzintuketimi;
            Console.WriteLine("Toplam yakıt tüketimi:" + totalyakittuketimi);

        }

    }
}