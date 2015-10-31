using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLibrary
{
    public class AlgoExample
    {
        /// <summary>
        /// Tri par insertion
        /// </summary>
        /// <param name="A">Liste d'entier</param>
        public static void TriParInsertion(List<int> A)
        {
            for (int j = 1; j < A.Count(); j++)
            {
                //Clé courante
                int key = A[j];

                //insére A[j] dans la séquence  triée A[0.. j -1] , on démarre le tri sur l'élement 0
                int i = j - 1;

                //Recherche d'une valeur plus grande dans le tableau que la clé courante,boucle tant que la valeur courante n'est pas positionné au bonne emplacement
                while ((i >= 0) && (A[i] > key))
                {
                    //switch avec les valeurs descendantes
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
        }
    }
}