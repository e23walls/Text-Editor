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
using System.Windows.Shapes;

namespace Word_Processor__1._0_
{
    /// <summary>
    /// Interaction logic for Exception.xaml
    /// </summary>
    public partial class Exception : Window
    {
        public Exception()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Exception_KeyDown(object sender, KeyEventArgs e)
        {
            // keyboard shortcuts

            // Close window keyboard shortcut
            if (e.Key == Key.Enter)
            {
                Close();
            }
        }
    }
}
