using System;
using Humanizer;
using System.Globalization;

namespace KataQuatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            bool saisieValide = false;

            // Vérifie si un argument a été passé en ligne de commande (ex: dotnet run 385)
            if (args.Length > 0 && int.TryParse(args[0], out nombre))
            {
                if (nombre >= 0 && nombre <= 9999)
                {
                    saisieValide = true;
                }
            }

            // Si aucun argument valide n'a été fourni, on demande l'entrée à l'utilisateur
            if (!saisieValide)
            {
                Console.WriteLine("Donnez-moi un nombre entre 0 et 9999: ");

                // Gère l'entrée de l'utilisateur
                while (saisieValide == false)
                {
                    string? x = Console.ReadLine();

                    if (int.TryParse(x, out nombre))
                    {
                        if (nombre >= 0 && nombre <= 9999)
                        {
                            saisieValide = true;
                        }
                        else
                        {
                            Console.WriteLine("Entrée invalide. Veuillez taper un nombre entre 0 et 9999 : ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide. Veuillez taper un nombre : ");
                    }
                }
            }

            // Boucle jusqu'à arriver à 4
            while (nombre != 4)
            {
                Console.WriteLine("------------------------------------------------");
                string NombreEnLettres = nombre.ToWords(new CultureInfo("fr-CH")).Replace("octante", "huitante");
                Console.WriteLine(NombreEnLettres + " vaut: " + NombreEnLettres.Length);
                nombre = NombreEnLettres.Length;
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Le Quatre est magique !!");
        }
    }
}