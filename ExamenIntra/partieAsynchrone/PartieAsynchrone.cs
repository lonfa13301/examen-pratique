using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIntra.partieAsynchrone
{
    class PartieAsynchrone
    {
        public static void Start()
        {
            new PartieAsynchrone().DeveloppementWeb();
        }

        async void DeveloppementWeb()
        {
            Console.WriteLine("A. Développons une application web.");
            Task frontEnd = FrontEnd();
            Task baseDeDonnees = BaseDeDonnees();
            Task backEnd = BackEnd();
           
            await Task.WhenAll(frontEnd, backEnd, baseDeDonnees);
            await Deploiement();
            Console.WriteLine("B. L'application web est complétée.");

        }

        async Task Multimedia()
        {
            Console.WriteLine("C. Commander des ressource multimédia.");
            await Task.Delay(5000);
            Console.WriteLine("D. Recevoir des ressources multimédia.");
        }

        async Task FrontEnd()
        {
            Console.WriteLine("E. Début du développement Front End.");
            Task recevoirMultimedia = Multimedia();
            await Task.Delay(1000);
            await recevoirMultimedia;
            Console.WriteLine("F. Fin du développement Front End.");

        }

        async Task BackEnd()
        {
            await BaseDeDonnees();
            Console.WriteLine("G. Début du développement Back End.");
            await Task.Delay(2000);
            Console.WriteLine("H. Fin du développement Back End.");

        }

        async Task Deploiement()
        {
            Console.WriteLine("I. Début du déploiement.");
            await Task.Delay(1000);
            Console.WriteLine("J. Fin du déploiement.");
        }

        async Task BaseDeDonnees()
        {
            Console.WriteLine("K. Début base de donnes.");
            await Task.Delay(1000);
            Console.WriteLine("K. Fin base de donnes.");
        }
    }
}
