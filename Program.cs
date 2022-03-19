// See https://aka.ms/new-console-template for more information

//Variablen Deklaration 
int registerNumber = 2356;
bool programmLoop = true;
string userInput;
int keyNumber;
int keyIndex;
Random random = new Random();
string[] products = new string[20];
int[] keyNumbers = new int[20];
Dictionary<int, string> productDictionary = new Dictionary<int, string>();
Dictionary<string, decimal> priceDictionary = new Dictionary<string, decimal>();

// Initialisieren der Variablen
// Generieren der KeyNumbers für das Warenverzeichnis
for(int i = 0; i < 20; i++)
{
    keyNumber = random.Next(112233, 999999);
    // Prüfen ob Zahl schon im Array vergeben ist 
    keyIndex = Array.IndexOf(keyNumbers, keyNumber);

    if(keyIndex <= -1)
    {
        keyNumbers[i] = keyNumber;  
    }
    else
    {
        while(keyIndex > -1)
        {
            keyNumber = random.Next(112233, 999999);
        }

        keyNumbers[i] = keyNumber;
    }


}

// Zuweisung der im Lager befindlichen Produkte
products[0] = "Grafikkarte NGrafik 2018";
products[1] = "Netzwerkkarte NETdot 2019";
products[2] = "USB Funk Maus";
products[3] = "MotBo Motherboard Gaming";
products[4] = "Tastatur USB Funk";
products[5] = "LCD Monitor 20zoll";
products[6] = "CPU BestCore Core16";
products[7] = "Gaming RAM 16GB";
products[8] = "SSD SATA 2TB";
products[9] = "HDD SATA 16TB";
products[10] = "HDD SATA 2TB";
products[11] = "SSD SATA 500GB";
products[12] = "CPU Kühlpaste";
products[13] = "Computer Kabel Set";
products[14] = "PC Gehäuselüfter";
products[15] = "Gehäuse Gaming";
products[16] = "Gehäuse Desktop";
products[17] = "Betriebssystem OperationOS";
products[18] = "Lautsprecher BeastTone";
products[19] = "WebCam BetterWatch";

// Befüllen des Produktverzeichnisses aus Produktnummer und Ware
for(int i = 0; i < 20; i++)
{
    productDictionary.Add(keyNumbers[i], products[i]);
}

// Befüllen der Waren-Preis-Liste
priceDictionary.Add(products[0], 599.99M);
priceDictionary.Add(products[1], 49.89M);
priceDictionary.Add(products[2], 12.99M);
priceDictionary.Add(products[3], 126.79M);
priceDictionary.Add(products[4], 29.49M);
priceDictionary.Add(products[5], 289.99M);
priceDictionary.Add(products[6], 487.39M);
priceDictionary.Add(products[7], 79.99M);
priceDictionary.Add(products[8], 159.99M);
priceDictionary.Add(products[9], 124.99M);
priceDictionary.Add(products[10], 49.99M);
priceDictionary.Add(products[11], 4.99M);
priceDictionary.Add(products[12], 4.99M);
priceDictionary.Add(products[13], 19.99M);
priceDictionary.Add(products[14], 19.99M);
priceDictionary.Add(products[15], 79.89M);
priceDictionary.Add(products[16], 29.99M);
priceDictionary.Add(products[17], 24.89M);
priceDictionary.Add(products[18], 59.99M);
priceDictionary.Add(products[19], 19.99M);




// Anwendung
while (programmLoop)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Registrierkasse {0}", registerNumber);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------------");
    Console.WriteLine();
    Console.WriteLine("Was möchten Sie tun?");
    Console.WriteLine("[1] Produkt-Liste anzeigen");
    Console.WriteLine("[2] Preis-Liste anzeigen");
    Console.WriteLine("[3] Beenden");
    Console.WriteLine();
    Console.Write("Eingabe: ");
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Unsere Produkte: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------");
            Console.WriteLine();

            foreach(KeyValuePair<int, string> pair in productDictionary)
            {
                Console.WriteLine(pair);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Was wollen Sie machen?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[1] Zum Hauptmenü");
            Console.WriteLine("[2] Preis anzeigen");
            Console.WriteLine("[3] Produkt hinzufügen");
            Console.WriteLine("[4] Produkt entfernen");
            Console.WriteLine("[5] Beenden");
            Console.WriteLine();
            Console.Write("Eingabe: ");
            string userInput_PD = Console.ReadLine();

            switch (userInput_PD)
            {
                case "1":
                        break;

                case "2":
                    Console.WriteLine();
                    Console.Write("Produktnummer eingeben: ");
                    int produktNumberInput = Convert.ToInt32(Console.ReadLine());
                    string value = productDictionary[produktNumberInput].ToString();
                    int valueIndex = Array.IndexOf(products, value);

                    if(valueIndex > -1)
                    {
                        decimal priceValue = priceDictionary[value];
                        Console.WriteLine("Produkt: {0} | Preis: {1}", value, priceDictionary[value]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Kein Produkt gefunden!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                        break;

                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Produkt der Warendatenbank hinzufügen");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.Write("Warenbezeichnung: ");
                    string newProduct = Console.ReadLine();
                    Console.Write("Produktpreis [in Euro]: ");
                    decimal priceNewProduct = Convert.ToDecimal(Console.ReadLine());
                    int newProductKeyNumber;
                   

                   
                        Console.Write("Warennummer hinzufügen [XXXXXX] : ");
                        int newProductKeyNumberInput = Convert.ToInt32(Console.ReadLine());
                        int newProductKeyNumberIndex = Array.IndexOf(keyNumbers, newProductKeyNumberInput);

                        if (newProductKeyNumberIndex <= -1)
                        {
                            newProductKeyNumber = newProductKeyNumberInput;
                            Array.Resize(ref products, products.Length + 1);
                            products[products.Length - 1] = newProduct;
                            productDictionary.Add(newProductKeyNumber, newProduct);
                            priceDictionary.Add(newProduct, priceNewProduct);

                        }
                        else if (newProductKeyNumberIndex > -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nummer bereits vergeben...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        break;

                case "4":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Produkt aus dem Warenverzeichnis entfernen");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                    foreach(KeyValuePair<int, string> kvp in productDictionary)
                    {
                        Console.WriteLine(kvp);
                    }
                    Console.WriteLine();
                    Console.Write("Welches Produkt möchten Sie löschen: ");
                    int deleteProduct = Convert.ToInt32(Console.ReadLine());
                    int deleteProductIndex = Array.IndexOf(keyNumbers, deleteProduct);

                    if(deleteProductIndex > -1)
                    {
                        productDictionary.Remove(keyNumbers[deleteProductIndex]);
                    }
                        break;

                case "5":
                    programmLoop = false;
                    break;

                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("FEHLERHAFTE EINGABE!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;


            }
            break;

        case "2":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Preisliste");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------");
            Console.WriteLine();

            foreach(KeyValuePair<string, decimal> kvp in priceDictionary)
            {
                Console.WriteLine(kvp);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Zum Hauptmenü zurück...");

            break;

        case "3":
            programmLoop = false;
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FEHLERHAFTE EINGABE!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }



    Console.ReadKey();
}


