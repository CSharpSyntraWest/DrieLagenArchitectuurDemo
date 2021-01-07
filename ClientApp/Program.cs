using BussinessLogic;
using System;
using System.Collections.Generic;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBierenPrijzenService bierPrijzenService = new BierenPrijzenService();
            IDictionary<string,double> bierenMetPrijzen = bierPrijzenService.GeefBierenMetPrijzen();
            foreach(KeyValuePair<string,double> bierMetPrijs in bierenMetPrijzen)
            {
                Console.WriteLine($"Naam bier={bierMetPrijs.Key} -> prijs bier: {bierMetPrijs.Value}");
            }
            Console.ReadKey();
        }
    }
}
