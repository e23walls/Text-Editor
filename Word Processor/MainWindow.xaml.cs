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
using Microsoft.Win32;


namespace Word_Processor__1._0_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void createFileFunc()
        {
            // open text editing window and close the starter one
            TextEditorWindow themainWindow = new TextEditorWindow();
            themainWindow.Show();
            Close();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            createFileFunc();
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            // kill the program
            Environment.Exit(0);
        }

        // keyboard shortcuts
        private void startWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.N) || (e.Key == Key.Enter))
            {
                createFileFunc();
            }

            else if (e.Key == Key.Q)
            {
                Environment.Exit(0);
            }
        }
    }
}