using System;

class PrawoOhma{
    static void Main(){
        //Deklaracja zmiennych:
        //U - napięcie [V]
        //I - natężenie prądu [A]
        //R - opór elektryczny [ohm]
        double U, I, R;
        int wybor;

        Console.WriteLine("Symulacja prawa Ohma");
        Console.WriteLine("\nCo chcesz obliczyc?");
        Console.WriteLine("1 - Napiecie(U)");
        Console.WriteLine("2 - Natezenie(I)");
        Console.WriteLine("3 - Opor(R)");
        Console.Write("Twoj wybor: ");

        //Zamienia tekst (string) na liczbe całkowita (int):
        wybor = Convert.ToInt32(Console.ReadLine());

        //Obliczanie napiecia U
        if(wybor==1){
            Console.Write("Podaj opor R [ohm]: ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj natezenie I [A]: ");
            I = Convert.ToDouble(Console.ReadLine());

            U = R * I;
            Console.WriteLine($"Napiecie U = {U:F2} V");
        }
        //Obliczanie natezenia I
        else if(wybor==2){
            Console.Write("Podaj napiecie U [V]: ");
            U = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj opor R [ohm]: ");
            R = Convert.ToDouble(Console.ReadLine());

            //Dzielimy wartosci, wiec nalezy sprawdzic, czy nie dochodzi do dzielenia pzrez zero
            if(R==0){
                Console.WriteLine("Blad: opor nie moze byc rowny 0!");
            }
            else{
                I = U / R;
                Console.WriteLine($"Natezenie I = {I:F2} A");
            }
        }
        //Obliczanie oporu R
        else if(wybor==3){
            Console.Write("Podaj napiecie U [V]: ");
            U = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj natezenie I [A]: ");
            I = Convert.ToDouble(Console.ReadLine());
            
            //Dzielimy wartosci, wiec nalezy sprawdzic, czy nie dochodzi do dzielenia pzrez zero
            if(I==0){
                Console.WriteLine("Blad: natezenie nie moze byc rowne 0!");
            }
            else{
                R = U / I;
                Console.WriteLine($"Opor R = {R:F2} ohm");
            }
        }

        //Obsluga nieprawidlowego wyboru
        else{
            Console.WriteLine("Nieprawidlowy wybor!");
        }

        Console.WriteLine("\nNacisnij dowolny klawisz, aby zakonczyc...");
        Console.ReadKey();
    }
}
