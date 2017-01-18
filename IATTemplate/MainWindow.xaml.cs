using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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


namespace IATTemplate
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            String fileName = selectSetupFile();
            InitializeComponent();
            InitialiseTest(fileName);
        }

        public string selectSetupFile()
        {
            // Opens a dialog to locate the data file and returns its directory + name

            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".*";
            dialog.FileName = ""; ;
            dialog.Multiselect = false;
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                return dialog.FileName;
            }
            return null;
        }

        public void OnKeyPressed(object sender, KeyEventArgs e)
        {
            
        }

        private void InitialiseTest(string fileName)
        {
            //Use the functions below to initialise everything you need.
        }

        private StreamReader OpenAndReadStream(string fileName)
        {
            /* Use the fileName string to create a Stream for file reading
             * You can read each line in the file, 
             * check whether each line records information about a category
             * or about the how categories are splited
             */

            throw new NotImplementedException(); //delete this line
        }

        private void CreateItems(string data)
        {
            // Extract all items in the data.
        }

        private void SetSortRule(string data)
        {
            // Extract and set sort rule
        }

        private void popNextItem()
        {
            /* Think about the life cycle of this test:
             * When to start the timer?
             * When to record the result?
             * When to stop the test?
             */


        }

        private void examineAnswerAndStoreResult(char c)
        {
            // Check if the user's answer is correct and store the relevant data.
        }
    }
}
