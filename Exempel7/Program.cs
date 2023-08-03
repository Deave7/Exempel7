using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Exempel7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skriv in den metoden du vill testa, t.ex: Exempel712();
            Exempel753();
        }

        static void Exempel712() //Övning 7.1.2
        {
            Console.WriteLine("This part of the program will add two numbers."); //Skriver till konsollen och talar om vad vi kommer att göra
            Console.WriteLine("Please enter your first number: "); //Ber om siffra nummer 1 
            int number1 = Convert.ToInt32(Console.ReadLine()); //initierar variablen number1 och sätter den till vad användaren skriver i. Notera att man måste konvertera resultatet till int eftersom det användaren skriver in blir en string. 

            Console.WriteLine("Please enter your second number: "); 
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2; //Initierar variablen result och sätter dess värde till number1 + number2
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + result); //Skriver ut resultatet 
            Console.ReadLine(); //Hindrar programmet från att stänga sig självt 
        }

        static void Exempel713() //Övning 7.1.3
        {
            Console.WriteLine("This part of the program will calculate the sum of three numbers and their average value"); //Skriver till konsollen och talar om vad vi kommer att göra

            Console.WriteLine("Please enter your first number: "); //Ber om siffra nummer 1 
            int number1 = Convert.ToInt32(Console.ReadLine()); //initierar variablen number1 och sätter den till vad användaren skriver i. Notera att man måste konvertera resultatet till int eftersom det användaren skriver in blir en string. 

            Console.WriteLine("Please enter your second number: "); 
            int number2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Please enter your third number: ");  
            int number3 = Convert.ToInt32(Console.ReadLine()); 

            int sum = number1 + number2 + number3; //Initierar variablen sum och adderar number1,2,3
            int averageValue = sum / 3; //Initierar variablen averageValue och räknar ut medelvärdet

            Console.WriteLine("The sum is: " + sum + " and the average value is: " + averageValue); //Skriver ut resultatet
            Console.ReadLine(); //Hindrar programmet från att stänga sig självt
        }

        static void Exempel714() //Övning 7.1.4
        {
            Console.WriteLine("This part in the program rounds a inputed decimal to the closest integer"); //Skriver till konsollen och talar om vad vi kommer att göra

            Console.WriteLine("Please enter a decimal number"); //Ber användaren att skriva in ett decimaltal
            double number1 = Convert.ToDouble(Console.ReadLine()); //initierar variablen double och konverterar användar input till double

            double number2 = number1; //Initierar variablen number2 och sätter den till värdet av number1

            number2 = Math.Round(number2, 0); // Avrundar number2 till tal med 0 decimaler och sätter sedan number2 till det nya värdet

            Console.WriteLine("Your decimal: " + number1 + " was rounded to: " + number2); //Skriver ut resultatet
            Console.ReadLine(); //Hindrar programmet från att stänga sig självt
        }

        static void Exempel715() //Övning 7.1.5
        {
            Console.WriteLine("This part in the program takes two inputed names and prints a little story"); //Skriver till konsollen och talar om vad vi kommer att göra

            Console.WriteLine("Please enter name one: ");
            string name1 = Console.ReadLine(); //initierar variablen name1 och sätter den till det användaren skriver i

            Console.WriteLine("Please enter name two: ");
            string name2 = Console.ReadLine(); //initierar variablen name2 och sätter den till det användaren skriver i

            Console.WriteLine("There once was a person called " + name1); //Prints the story to the console
            Console.WriteLine(name1 + " always wanted to travel the world, swim with dolphins, climb mountains and dive in all the oceans of the world.");
            Console.WriteLine("On their travels " + name1 + " met a wonderful person. They were called: " + name2 + ".");
            Console.Write(name2 + " was a bit more timid and shy but wanted to come out of their shell. ");
            Console.WriteLine("With " + name1 + "'s help they were able to leave their hometown and see the world! :)");
        }

        static void Exempel716() //Övning 7.1.6
        {
            Console.WriteLine("This part in the program rounds a inputed decimal to the closest integer"); //Skriver till konsollen och talar om vad vi kommer att göra

            Console.WriteLine("Please enter a decimal number"); //Ber användaren att skriva in ett decimaltal
            double number1 = Convert.ToDouble(Console.ReadLine()); //initierar variablen double och konverterar användar input till double

            double number2 = number1; //Initierar variablen number2 och sätter den till värdet av number1

            number2 = Math.Round(number2, 2); // Avrundar number2 till tal med 2 decimaler och sätter sedan number2 till det nya värdet

            Console.WriteLine("Your decimal: " + number1 + " was rounded to: " + number2); //Skriver ut resultatet
            Console.ReadLine(); //Hindrar programmet från att stänga sig självt
        }

        static void Exempel717() //Övning 7.1.7
        {
            char myChar = (char)88; //Initierar variablen myChar till värde 88 i Unicode tabellen
            Console.WriteLine(myChar); //Skriver ut variablen myChar

            //Genom sättet ovan kan man skriva ut ett antal symboler som saknas på ett vanligt tangentbord
        }

        static void Exempel719() //Övning 7.1.9
        {
            /* Om man delar två variabler av typen int blir svaret alltid också en int. Därför får vi resultatet 0 istället för 0,5
            int a = 1;
            int b = 2;
            float c = a / b;
            Console.WriteLine(c); 
            */

            float a = 1; //Genom att ändra variabeltypen till float från början får vi rätt svar
            float b = 2;
            float c = a / b;
            Console.WriteLine(c);

            int d = 1; //Man kan också ändra en av variablerna (i det här fallet d) till en float så fungerar det som förväntat
            int e = 2;
            float f = (float)d / e;
            Console.WriteLine(f);
        }

        static void Exempel7110() //Övning 7.1.10
        {
            int a = 8 % 5; //Operatorn % ger rest(det som blir över) vid en division, i exemplet 8/5 går 1 gång sen har vi 3 kvar
            Console.WriteLine(a);
        }

        static void Exempel731() //Övning 7.3.1
        {
            Console.WriteLine("Is there nice weather outside? y/n"); //Frågar användaren om vädret är fint ute. Ber om svaret y(es) eller n(o)
            char answer = Convert.ToChar(Console.ReadLine()); //Intierar variablen char -> konverterar användarens svar från en string till en char -> sätter variablen answer till svaret

            if (answer == 'y') //Om användaren svarar y skriver vi ut raden under, annars händer ingenting
            {
                Console.WriteLine("Let's head out for a picnic!");
            }
        }

        static void Exempel732() //Övning 7.3.2
        {
            Console.WriteLine("Is there nice weather outside? y/n"); //Frågar användaren om vädret är fint ute. Ber om svaret y(es) eller n(o)
            char answer = Convert.ToChar(Console.ReadLine()); //Intierar variablen char -> konverterar användarens svar från en string till en char -> sätter variablen answer till svaret

            if (answer == 'y') //Om användaren svarar y skriver vi ut raden under
            {
                Console.WriteLine("Lets head out for a picnic!");
            }
            else if (answer == 'n' || answer == 'N') //Om användaren svarar n skriver vi ut raden under. Notera att användaren kan svara med litet eller stort N
            {
                Console.WriteLine("Lets stay inside and read a book instead");
            }
        }

        static void Exempel733() //Övning 7.3.3
        {
            Console.WriteLine("Is there nice weather outside? y/n"); //Frågar användaren om vädret är fint ute. Ber om svaret y(es) eller n(o)
            char answer = Convert.ToChar(Console.ReadLine()); //Intierar variablen char -> konverterar användarens svar från en string till en char -> sätter variablen answer till svaret

            if (answer == 'y' || answer == 'Y') //Om användaren svarar y skriver vi ut raden under Notera att användaren kan svara med litet eller stort y
            {
                Console.WriteLine("Lets head out for a picnic!");
            }
            else if (answer == 'n' || answer == 'N') //Om användaren svarar n skriver vi ut raden under. Notera att användaren kan svara med litet eller stort N
            {
                Console.WriteLine("Lets stay inside and read a book instead");
            }
            else //Om användaren inte svarar med j/J eller n/N skriver vi ut raden under
            {
                Console.WriteLine("I don't understand");
            }
        }

        static void Exempel734() //Övning 7.3.4
        {
            Console.WriteLine("This part of the program will ask you to input the temperature of the swedish cities \"Östersund\" and \"Åmål\"."); //Berättar vad progammet kommer att göra

            Console.WriteLine("Please input the temperature of Östersund: "); //Ber om temperaturen i Östersund
            double tempÖ = Convert.ToDouble(Console.ReadLine()); // Initierar variablen tempÖ -> konverterar svaret till en double och sätter den till användarens svar

            Console.WriteLine("Please input the temperature of Åmål: "); //Ber om temperaturen i Åmål
            double tempÅ = Convert.ToDouble(Console.ReadLine()); // Initierar variablen tempå -> konverterar svaret till en double och sätter den till användarens svar

            if (tempÅ > tempÖ) //Om tempÅ är större än tempÖ skriv ut raden under
            {
                Console.WriteLine("Östersund is colder then Åmål");
            }
            else if (tempÖ > tempÅ) //Om tempÖ är större än tempÅ skriv ut raden under
            {
                Console.WriteLine("Åmål is colder than Östersund");
            }
            else //Om inget av de övre if satserna blir sann skriv ut raden under. Bör endsast vara om man matar in samma temperatur i båda städerna
            {
                Console.WriteLine("The temperature in both cities are the same");
            }
        }

        static void Exempel735() //Övning 7.3.5
        {
            Console.Write("Ange temperatur för Östersund: "); //Ber om temperaturen i Östersund
            int ostersund = Convert.ToInt32(Console.ReadLine()); //Initerar variablen ostersund -> konverterar användarens svar från en string till en int och sätter värdet till det användarens svar

            Console.Write("Ange temperatur för Åmål: "); //Ber om temperaturen i Åmål
            int amal = Convert.ToInt32(Console.ReadLine()); //Initerar variablen amal -> konverterar användarens svar från en string till en int och sätter värdet till det användarens svar

            Console.Write("Ange temperatur för Arboga: "); //Ber om temperaturen i Arboga
            int arboga = Convert.ToInt32(Console.ReadLine()); //Initerar variablen arboga -> konverterar användarens svar från en string till en int och sätter värdet till det användarens svar

            if (amal > ostersund && arboga > ostersund) //Om amal är större än ostersund OCH arboga är större än ostersund skriv ut raden under
            {
                Console.WriteLine("Det är kallast i Östersund");
            }
            else if (ostersund > amal && arboga > amal) //Om ostersund är större än amal OCH arboga är större än amal skriv ut raden under
            {
                Console.WriteLine("Det är kallast i Åmål");
            }
            else if (ostersund > arboga && amal > arboga) //Om ostersund är större än arboga OCH amal är större än arboga skriv ut raden under
            {                                             //La till denna satsen eftersom användaren skulle kunna skriva i samma temperatur i alla tre städerna och då skulle else satsen från exemplet inte vara sann.
                Console.WriteLine("Det är kallast i Arboga");
            }
            else //Om ingen av satserna ovan är sann skriv ut raden under
            {
                Console.WriteLine("Det är lika kallt i alla städer");
            }
        }

        static void Exempel736() //Övning 7.3.6
        {
            /* Exemplet har missat ett likamedtecken i if satsen = är tilldelning inte likamed som är ==. Se tillrättad kod under exemplet 
             * Det specifika felmeddelandet får vi för att en int ej kan omvandlas till en bool rätt av. En bool kan endast ha två värden, true eller false
            int var = 10;
            if (var = 10)
                Console.WriteLine("den är 10!");
            */
            int var = 10;
            if (var == 10)
            {
                Console.WriteLine("den är 10!");
            }
        }

        static void Exempel742() //Övning 7.4.2
        {
            int balance = 0; //Initerar variablen balance för att den ska kunna användas överallt. 

            while (true) //Eftersom true alltid är true och aldrig ändras fortsätter loopen tills vi väljer att gå ur den 
            {
                Console.WriteLine("Choose something from the menu: "); //Olika menyval
                Console.WriteLine("[D]eposit");
                Console.WriteLine("[W]ithdrawl");
                Console.WriteLine("[B]alance");
                Console.WriteLine("[Q]uit");
                string choice = Console.ReadLine(); //Initierar och sätter variavlen choice till användarens input
                

                switch (choice) //switch sats för variablen choice
                {
                    case "D": //Om man svarar D
                        Console.WriteLine("How much would you like to deposit: ");
                        int deposit = Convert.ToInt32(Console.ReadLine()); //Initerar variablen deposit -> Konverterar användarens svar till en int och sätter det värdet till variablen
                        balance = deposit + balance; //sätter värdet på balance till deposit + balance. Alltså det användaren valt att "sätta in" på sitt konto
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        break; //Går ut ur det nuvarande varvet i loopen

                    case "W": //Om man svarar W
                        Console.WriteLine("How much would you like to withdraw: ");
                        int withdrawl = Convert.ToInt32(Console.ReadLine()); 
                        balance = balance - withdrawl; //sätter värdet på balance till balance - withdrawl. Alltså det användaren valt att "ta ut" från sitt konto
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        break; //Går ut ur det nuvarande varvet i loopen

                    case "B":
                        Console.WriteLine("This is your current balance: " + balance); //Skriver ut det nuvarande värdet på variablen balance
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        break; //Går ut ur det nuvarande varvet i loopen

                    case "Q":
                        Console.WriteLine("Quitting the program, see you next time! :)");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        return; //går utanför loopen

                    default: //Om användaren inte ger oss korrekt input skrivs raderna nedan ut
                        Console.WriteLine("Invalid input, try again!");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        break; //Går ut ur det nuvarande varvet i loopen


                }
            }
        }

        static void Exempel751() //Övning 7.5.1
        {
            Console.WriteLine("This part of the program will print the numbers 1 through 20 with a while loop."); //Berättar vad programmet kommer att göra 

            int i = 1; //Initierar variablen i och sätter dess värde till 1 (för att första varvet av while loopen ska skriva 1)
            while (i < 21) //Kör loopen tills i < 21 inte längre är sant
            {
                Console.WriteLine(i); //Skriver ut variablen 1
                i++; //Lägger till +1 till variablen i's värde
            }
        }

        static void Exempel752() //Övning 7.5.2
        {
            Console.WriteLine("This part of the program will ask you to enter a number between 1 and 100. It will then print the remaining numbers up to 101."); //Förklarar vad vi ska göra 

            Console.WriteLine("Please enter a number between 1-100: "); //Ber användaren skriva in ett tal mellan 1 och 100
            int i = Convert.ToInt32(Console.ReadLine()); // intierar variablen i -> konverterar användarens svar till en int och sätter värdet av i till användarens svar

            while (i < 102) //Kör loopen tills i inte längre är mindre än 102
            {
                Console.Write(i + " "); //Skriv ut variablen i's värde och ett mellanslag 
                i++; //Lägg till +1 till variablen i's värde
            }
        }

        static void Exempel753() //Övning 7.5.3
        {
            
            Console.WriteLine("This part of the program will ask you to enter how many times you want to flip a coin. It will then show you the results of the flips.\n"); //Berättar vad programmet kommer att göra

        
            Console.WriteLine("Please enter how many times you wish to flip a coin: \n"); //Frågar användaren hur många gånger de vill singla slant
            int times = Convert.ToInt32(Console.ReadLine()); //intierar variablen times till det värde användaren skriver i 
            int i = 0; //initierar variablen i till 0 (loop styrning)

            string[] coin = { "Heads", "Tails" }; //Skapar ett fält med två värden för att kunna räkna hur många gånger myntet har landat på en specifik sida
            int heads = 0; //intierar variablen heads till 0
            int tails = 0; //initierar variablen tails till 0
            var rand = new Random(); //initierar variablen rand och sätter den till att skapa ett ny random instans
            const int faces = 2; //intierar den konstanta variablen faces till 2 (så många sidor har ett mynt)

            while (i < times) //medans i är mindre än times kör vi loopen 
            {
                int flip = rand.Next(faces); //här singlar vi myntet, vi initierar variablen flip till en random intans där värdet kan vara 0 eller 1 
                if (flip == 1) //OM flip blir 1 
                {
                    Console.WriteLine("Coin landed on heads\n"); //Berättar resultatet
                    heads += 1; //Lägger till +1 till heads i fältet coins

                    Console.WriteLine($"You have landed on heads: {heads} time(s)"); //berättar hur många gånger myntet har landat på heads

                    Console.WriteLine($"You have landed on heads: {tails} time(s)\n"); //berättar hur många gånger myntet har landat på tails 
                    i++; // lägger till +1 till i's värde
                }
                else
                {
                    Console.WriteLine("Coin landed on tails\n"); //Berättar resultatet
                    tails += 1; //Lägger till +1 till heads i fältet coins

                    Console.WriteLine($"You have landed on heads: {heads} time(s)"); //berättar hur många gånger myntet har landat på heads

                    Console.WriteLine($"You have landed on heads: {tails} time(s)\n"); //berättar hur många gånger myntet har landat på tails 
                    i++; // lägger till +1 till i's värde
                }
            }
            Console.WriteLine("Goodbye!"); 
        }
    }
}