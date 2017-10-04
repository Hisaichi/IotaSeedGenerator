// This file contain the GUI specific code of the MainWindow class

using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace IotaSeedGenerator
{
    public partial class MainWindow : Window
    {
        List<TextBox> textBoxesSeed = new List<TextBox>(); // list of the text Boxes containing seeds
        List<Button> seedButtons = new List<Button>(); // list of the buttons assoaciated with each text Box containing seeds

        // Reset the seed textBoxes to normal (color, text, ...)
		private void resetSeedBoxes()
        {
            int i = 0;
            foreach (TextBox textBoxSeed in textBoxesSeed)
            {
                if (0 == ++i % 2) textBoxSeed.Background = Brushes.LightGray;
                else textBoxSeed.Background = Brushes.White;
                textBoxSeed.Foreground = Brushes.Black;
            }
        }

        // Reset the seed buttons to normal (color, text, ...)
		private void resetSeedButtons()
        {
            int i = 0;
            foreach (Button button in seedButtons) button.Content = "Pick";
        }

        // Fill the textBoxes with seeds
		private void fillTextBoxes()
        {
            const int nbOccurences = 1111;
            foreach (TextBox textBoxSeed in textBoxesSeed) textBoxSeed.Text = getOneSeed(nbOccurences + new Random().Next(0, 177));
        }

        // What happens when one click on a button near a seed
		private void seedButtonAction(object sender, TextBox tb)
        {
            Clipboard.SetText(tb.Text); // Copy the seed to the clipboard
            resetSeedBoxes(); // Reset the seed textBoxes to normal (color, text, ...)
            resetSeedButtons(); // Reset the seed buttons to normal (color, text, ...)
            tb.Background = Brushes.DarkMagenta; // Color the clicked TextBox background in black
            tb.Foreground = Brushes.White; // Color the clicked TextBox text in white
            Button b = (Button)sender; // Convert the sender oject into button, cause yes, it's a button
            b.Content = "Piked !"; // Assign a cool text to the button clicked
        }

        private void generate_button_Click(object sender, RoutedEventArgs e)
        {
            fillTextBoxes(); // Fill the textBoxes with seeds
            resetSeedBoxes(); // Reset the seed textBoxes to normal (color, text, ...)
            resetSeedButtons(); // Reset the seed buttons to normal (color, text, ...)
        }

        // That's not pretty, that's why it's hidden here at the bottom.
		// It chooses colors, mainly, and create both the textBoxesSeed list and the seedButtons list.
		// Dealing with list makes it easier to code and read.
		private void initGraphic()
        {
            // textBoxesSeed list
			textBoxesSeed.Add(textBoxSeed1);
            textBoxesSeed.Add(textBoxSeed2);
            textBoxesSeed.Add(textBoxSeed3);
            textBoxesSeed.Add(textBoxSeed4);
            textBoxesSeed.Add(textBoxSeed5);
            textBoxesSeed.Add(textBoxSeed6);
            textBoxesSeed.Add(textBoxSeed7);
            textBoxesSeed.Add(textBoxSeed8);
            textBoxesSeed.Add(textBoxSeed9);
            textBoxesSeed.Add(textBoxSeed10);
            textBoxesSeed.Add(textBoxSeed11);
            textBoxesSeed.Add(textBoxSeed12);
            textBoxesSeed.Add(textBoxSeed13);
            textBoxesSeed.Add(textBoxSeed14);
            textBoxesSeed.Add(textBoxSeed15);
            textBoxesSeed.Add(textBoxSeed16);

            // seedButtons list
            seedButtons.Add(seedButton1);
            seedButtons.Add(seedButton2);
            seedButtons.Add(seedButton3);
            seedButtons.Add(seedButton4);
            seedButtons.Add(seedButton5);
            seedButtons.Add(seedButton6);
            seedButtons.Add(seedButton7);
            seedButtons.Add(seedButton8);
            seedButtons.Add(seedButton9);
            seedButtons.Add(seedButton10);
            seedButtons.Add(seedButton11);
            seedButtons.Add(seedButton12);
            seedButtons.Add(seedButton13);
            seedButtons.Add(seedButton14);
            seedButtons.Add(seedButton15);
            seedButtons.Add(seedButton16);

            resetSeedBoxes(); // Correct 
            resetSeedButtons();
        }
        
        // Action associated with the click for each button
		private void Button_Click_1(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed1); }
        private void Button_Click_2(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed2); }
        private void Button_Click_3(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed3); }
        private void Button_Click_4(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed4); }
        private void Button_Click_5(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed5); }
        private void Button_Click_6(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed6); }
        private void Button_Click_7(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed7); }
        private void Button_Click_8(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed8); }
        private void Button_Click_9(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed9); }
        private void Button_Click_10(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed10); }
        private void Button_Click_11(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed11); }
        private void Button_Click_12(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed12); }
        private void Button_Click_13(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed13); }
        private void Button_Click_14(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed14); }
        private void Button_Click_15(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed15); }
        private void Button_Click_16(object sender, RoutedEventArgs e) { seedButtonAction(sender, textBoxSeed16); }
    }
}