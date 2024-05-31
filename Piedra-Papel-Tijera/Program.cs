using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_Papel_Tijera
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool mPlayAgain = true;

            while (mPlayAgain)
            {
                Console.Clear();

                char mUserChoice = GetUserChoice();
                char mPcChoice = GetPcChoice();
                Console.WriteLine($"La máquina elige la opción: {mPcChoice}");

                string mResult = DetermineWinner(mUserChoice, mPcChoice);
                Console.WriteLine(mResult);

                Console.Write("¿Quieres jugar de nuevo? (Y/N): ");
                char mPlayAgainChoice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                mPlayAgain = (mPlayAgainChoice == 'Y');
            }
        }

        #region ELECCION USUARIO
        static char GetUserChoice()
        {
            char mChoice;
            bool mValidChoice = false;

            do
            {
                Console.WriteLine("===================== PIEDRA - PAPEL - TIJERA =====================");
                Console.WriteLine("Elija su opción");
                Console.WriteLine();
                Console.WriteLine("P - Piedra");
                Console.WriteLine("P - Papel");
                Console.WriteLine("T - Tijeras");
                Console.WriteLine();
                Console.Write("Opcion: ");

                mChoice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                mValidChoice = (mChoice == 'P' || mChoice == 'P' || mChoice == 'T');

                if (!mValidChoice)
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                }

            } while (!mValidChoice);

            return mChoice;
        }
        #endregion

        #region ELECCION USUARIO
        static char GetPcChoice()
        {
            Random mRandom = new Random();
            int mRandomOption = mRandom.Next(3);

            switch (mRandomOption)
            {
                case 0:
                    return 'P';
                case 1:
                    return 'P';
                case 2:
                    return 'T';
                default:
                    return ' ';
            }
        }
        #endregion

        #region DETERMINAR GANADOR
        static string DetermineWinner(char pUserChoice, char pPcChoice)
        {
            if (pUserChoice == pPcChoice)
            {
                return "¡Es un empate!";
            }
            else if ((pUserChoice == 'P' && pPcChoice == 'T') ||
                     (pUserChoice == 'P' && pPcChoice == 'P') ||
                     (pUserChoice == 'T' && pPcChoice == 'P'))
            {
                return "¡Ganaste!";
            }
            else
            {
                return "¡La PC ganó!";
            }
        }
        #endregion

    }
}
