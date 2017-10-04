// This file contain the functionnal code of the MainWindow class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IotaSeedGenerator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Random numbers generator to create entropy
		Random rnd1; // Random numbers generator 1
        Random rnd2; // Random numbers generator 2
        Random rnd3; // Random numbers generator 3

        const int SEED_LEN = 81; // Recommended length for a iota key

        public MainWindow()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden; // Hide the window until it's fully arty
            initGraphic(); // Doing the making up
            rnd1 = new Random();
            Thread.Sleep(100); // If initialized too fast one after another, it seems the generator are somewhat producing similar numbers
            rnd2 = new Random();
            Thread.Sleep(150); // ""
            rnd3 = new Random();
            Thread.Sleep(100); // ""
            fillTextBoxes(); // Generating seeds, that's why we're here for anyway
            Visibility = Visibility.Visible; // Et voilà !
        }

        // This function generates one seed in a single iteration and returns it
        string getOneSeed()
        {
            // We create some entropy
            int timeOffset = (int)DateTime.Now.Ticks;

            // 4 times the same caracters in different orders, in order to create some entropy
            List<string> authorizedCharList = new List<string>(new string[] { "YHNUJIKOLPMAQWZSXEDCRFVTGB9", "9ABCDEFGHIJKLMNOPQRSTUVWXYZ", "QWERTYUIOPASDF9GHJKLMZXCVBN", "ZBSOLDE9HUXYANJIWQGKMPFVTRC" });

            string seed = "";
            Random rnd = new Random();

            // We build the seed using each list right above, one at a time.
			// Both the time offset (DateTime.Now.Ticks) and the random generator are used to chose the letters
            for (int i = 0; i < SEED_LEN; i++)
            {
                int index = Math.Abs(timeOffset + rnd.Next(0))%authorizedCharList.Count;
                seed += authorizedCharList[index][rnd1.Next(0, authorizedCharList[index].Length)];
            }

            return seed;
        }

        // This function generates one seed using "v" iterations and returns it
        private string getOneSeed(int v)
        {
            string seed = getOneSeed();

            // Mixing seeds v times
			for (int i = 0; i < v; i++) seed = mixSeed(seed, getOneSeed());

            return seed;
        }

        // This function mixes the seed1 with the seed2 and returns the result.
        // For each caracter, it randomly select the corresponding caractère of seed1 or seed2.
        private string mixSeed(string seed1, string seed2)
        {
            string seed = "";

            Random rnd = new Random();

            // We go through all the strings seed1 and seed2, randomly picking up a caracter from one or
            // the other in order to build the new seed.
            for (int i = 0; i < SEED_LEN ; i++)
            {
                if (0 == rnd.Next() % 2) seed += seed1[i];
                else seed += seed2[i];
            }

            return seed;
        }
    }
}
