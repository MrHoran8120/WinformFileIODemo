using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformFileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Demo of richtextbox file open and file save
        private void button2_Click(object sender, EventArgs e)
        // Simple save of the contents of a richtextbox
        {

            #region - This section handles the Filename and path dialog
            SaveFileDialog myPrompt = new SaveFileDialog();
            // Set the file name to myText.txt, set the type filter
            // to text files, and set the initial directory to the 
            // MyDocuments folder.
            myPrompt.FileName = "myText";
            // DefaultExt is only used when "All files" is selected from 
            // the filter box and no extension is specified by the user.
            myPrompt.DefaultExt = "txt";
            myPrompt.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            myPrompt.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult result = myPrompt.ShowDialog();
            #endregion

            // now we check if the user pressed cancel or ok
            if (result == DialogResult.OK)
            {
                // saving a richtextbox - note that the filename
                // also contains the path.
                richTextBox1.SaveFile(myPrompt.FileName, RichTextBoxStreamType.PlainText);
            }

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            #region - This section handles the Filename and path dialog
            OpenFileDialog myPrompt = new OpenFileDialog();
            // Set the file name to myText.txt, set the type filter
            // to text files, and set the initial directory to the 
            // MyDocuments folder.
            myPrompt.FileName = "myText";
            // DefaultExt is only used when "All files" is selected from 
            // the filter box and no extension is specified by the user.
            myPrompt.DefaultExt = "txt";
            myPrompt.Filter =
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            myPrompt.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            DialogResult result = myPrompt.ShowDialog();
            #endregion

            if (result == DialogResult.OK)
            {
                // saving a richtextbox - note that the filename
                // also contains the path.
                richTextBox1.LoadFile(myPrompt.FileName, RichTextBoxStreamType.PlainText);
            }

        }
        #endregion 
        #region Demo of streamwriter and streamread - here we are writing the contents of a list to a text file

        private void streamWriter_Click(object sender, EventArgs e)
        {

        }






        #endregion

    

        
    }
}
