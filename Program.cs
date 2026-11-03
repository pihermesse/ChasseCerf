namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */

        int fleches = 5;
        int tirsReussis = 0;

        Console.WriteLine("Vous commencez votre chasse");

        while (fleches > 0 && tirsReussis < 3)
        {
            Console.WriteLine("\nFlèches restantes : " + fleches);

            Console.Write("Résultat du tir (touche/rate) : ");
            string resultat = Console.ReadLine().ToLower();

            // Vérifier si la réponse est valide
            while (resultat != "touche" && resultat != "rate")
            {
                Console.WriteLine("Réponse invalide !");
                Console.Write("Veuillez écrire touche ou rate : ");
                resultat = Console.ReadLine().ToLower();
            }

            // Vérifier le résultat du tir
            if (resultat == "touche")
            {
                tirsReussis++;
                Console.WriteLine("Bien joué ! Le cerf est touché.");

                if (tirsReussis == 3)
                {
                    Console.WriteLine("Le cerf est abattu !");
                }
            }
            else
            {
                Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
            }

            // Décrémenter les flèches
            fleches--;
        }

        // Bilan final
        Console.WriteLine("\n===== BILAN DE LA CHASSE =====");
        Console.WriteLine("Tirs réussis : " + tirsReussis);
        Console.WriteLine("Flèches restantes : " + fleches);

        if (tirsReussis == 3)
        {
            Console.WriteLine("Résultat : chasse réussie !");
        }
        else
        {
            Console.WriteLine("Résultat : chasse échouée !");
        }
    }
}