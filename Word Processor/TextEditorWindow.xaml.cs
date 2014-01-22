/* Emily Walls
 * April 15th, 2011
 * Text Editor
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;

namespace Word_Processor__1._0_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class TextEditorWindow : Window
    {
        // declare variables
        bool isModified = false;
        // to contain the inputted file name, location, and open file location (in that order)
        string[] locations = new string[3];

        // QUIT function
        public void quitProgram()
        {
            if (isModified == true)  // checks to see if changes were made to the file before being saved
            {
                MessageBoxResult result;
                result = MessageBox.Show("\tFile not saved! Do you wish to save before closing?\t", "Warning!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    saveFileFunc();
                    Environment.Exit(0);
                }
                else if (result == MessageBoxResult.No)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void closeWindowFunc()
        {
            // check to see if there are unsaved changes to the file before closing the window
            if (isModified == true)
            {
                MessageBoxResult result = MessageBox.Show("\tFile not saved! Do you wish to save before closing?\t", "Warning!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    saveFileFunc();
                    Close();
                }
                else if (result == MessageBoxResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        // OPEN file function
        public void openFileFunc()
        {
            // add a ".txt" extension to the name if none is given
            locations[2] = openFile_txt.Text;
            fileContents_txt.Text = @"";
            if (locations[2].Contains(".txt") == false)
            {
                locations[2] += ".txt";
                titleLabel.Content = fileName_txt.Text;
           }
            try
            {
                using (StreamReader fReader = new StreamReader(locations[2]))
                {
                        string line;
                        // read and display lines from the file until end of the file is reached
                        while ((line = fReader.ReadLine()) != null)
                        {
                            fileContents_txt.Text += line + "\n";
                        }
                }
                filePath_txt.Text = openFile_txt.Text;
            }
            catch
            {
                // open a new window that tells the user an error occurred
                Exception fileOpenException = new Exception();
                fileOpenException.Show();
            }

    }
        // SAVE file function
        void saveFileFunc()
        {
            // declare and assign variables
            locations[1] = filePath_txt.Text;
            string fileContents = fileContents_txt.Text;
            locations[0] = fileName_txt.Text;

            // if there is no ".txt" extention on the end, ask if user wishes to add one
            if (locations[0].Contains(".txt") == false)
            {
                MessageBoxResult result = MessageBox.Show("No '.txt' extension given. Add it?", "Warning!", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    locations[0] += ".txt";
                    titleLabel.Content = fileName_txt.Text;
                }
            }

            try
            {
                // write file from provided name and contents
                StreamWriter writer = new StreamWriter(locations[1] + locations[0]);
                writer.WriteLine(fileContents);
                writer.Close();

                FileSaved saveWindow = new FileSaved();
                saveWindow.Show();
            }
            catch
            {
                // open a window saying an error occurred if an error occurs
                saveException savefileException = new saveException();
                savefileException.Show();
            }

            // remove the "*" from the titleLabel to show the file is no longer modified.
            titleLabel.Content = fileName_txt.Text;
            isModified = false;
        }

        // NEW file function
        void newFileFunc()
        {
            TextEditorWindow newFile = new TextEditorWindow();
            newFile.Show();
        }

        public TextEditorWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // open a new text editor window to be able to edit or open parallel files
            TextEditorWindow mainWindow = new TextEditorWindow();
            saveFileFunc();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            // any comment explaining what happens here would be redundant
            newFileFunc();
        }

        private void quit_Button_Click(object sender, RoutedEventArgs e)
        {
            // quit the program
            quitProgram();
        }

        private void fileContents_txt_KeyDown(object sender, KeyEventArgs e)
        {
            titleLabel.Content = fileName_txt.Text + "*";  // "*" shows the file has been modified
        }

        // KEYBOARD SHORTCUTS
        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            // Close window keyboard shortcut (Ctrl and W)
            if (e.Key == Key.W && ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                closeWindowFunc();
            }

            // Save file keyboard shortcut (Ctrl and S)
            if (e.Key == Key.S && ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                saveFileFunc();
            }

            // New file keyboard shortcut (Ctrl and N)
            if (e.Key == Key.N && ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                newFileFunc();
            }

            // Quit program keyboard shortcut (Ctrl + Q)
            if (e.Key == Key.Q && ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                quitProgram();
            }

            // open file keyboard shortcut (Ctrl and O)
            if (e.Key == Key.O && ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control))
            {
                openFileFunc();
            }
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            openFileFunc();
        }

        private void fileContents_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // if text is changed in the contents textbox, tell the user by adding a * to the end of the file name
            titleLabel.Content = fileName_txt.Text + "*";
            isModified = true;
        }

        private void fileName_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // rename the title to the name of the file and add * if the file isn't saved
            titleLabel.Content = fileName_txt.Text;
            if (isModified == true)
            {
                titleLabel.Content = fileName_txt.Text + "*";
            }
            else
            {
                titleLabel.Content = fileName_txt.Text;
            }
        }

        private void CloseWinButton_Click(object sender, RoutedEventArgs e)
        {
            closeWindowFunc();
        }
    }
}