﻿/*
 * In questo esercizio dovrete leggere un file CSV e salvare 
 * tutti gli indirizzi contenuti al sul interno all’interno
 * di una lista di oggetti istanziati a partire dalla classe Indirizzo.
 * 
 * Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari”
 * che possono accadere a questo genere di file: vi chiedo di pensarci e di
 * gestire come meglio crediate queste casistiche.
 */

string path = "../../../addresses.csv";

List<Address> addressesList = new List<Address>();


if (File.Exists(path))
{
    StreamReader addressesFile = File.OpenText(path);

    string headerFile = addressesFile.ReadLine();

    int lineCount = 1;

    while (!addressesFile.EndOfStream)
    {
        string row = addressesFile.ReadLine();
        lineCount++;

        try
        {
            string[] data = row.Split(",");

            if(data.Length == 6)
            {
                foreach (string address in data)
                {
                    if(address == "")
                    {
                        throw new Exception($"* * \"{row}\" * *\nIndirizzo n.{lineCount} non completo\n");
                        //salto prossimo indirizzo
                        break;
                    }
                }

                string name = data[0];
                string surname = data[1];
                string street = data[2];
                string city = data[3];
                string province = data[4];
                string zipCode = data[5];

                addressesList.Add(new Address(name, surname, street, city, province, zipCode));
            }
            else
            {
                throw new Exception($"* * \"{row}\" * *\nFormattazione indirizzo n.{lineCount} sbagliata\n");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }        
    }
}
else
{
    Console.WriteLine("Attenzione non ho trovato nessun file!");
}




public class Address
{
    public string Name { get;   set; }
    public string Surname { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Province { get; private set; }
    public string ZipCode { get; private set; }

    public Address (string name, string surname, string street, string city, string province, string zipCode)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        ZipCode = zipCode;
    }
}