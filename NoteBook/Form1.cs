using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string defaultDirectory = @"C:\Users\ASUS\winform\NoteBook\NoteBook\bin\Debug\NoteBook";
            string fileName = Path.Combine(defaultDirectory, Filename.Text + "." + comboBox1.Text);

            if (!File.Exists(fileName)) // If file does not exist
            {
                File.Create(fileName).Close(); // Create file
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(TextField.Text); // Write text to .txt file
                }
            }
            else // If file already exists
            {
                DialogResult dialogResult = MessageBox.Show(fileName + " already exists. Do you want to replace the file?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(TextField.Text); // Write text to .txt file
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Choose another name for your file.");
                }
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\ASUS\winform\NoteBook\NoteBook\bin\Debug\NoteBook";

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    TextField.Text = text;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        
    }

        private void btnnew_Click(object sender, EventArgs e)
        {
            TextField.Clear();
            Filename = null;
            comboBox1.Text = "";
        }
    }
}
