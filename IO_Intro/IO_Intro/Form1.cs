// --------------------------------------------
// Datei:			IO_Intro
// Datum:			05.05.2020
// Ersteller:		Florian Buechi
// Version:		    1.0
// Änderungen:		
// 					
// Beschreibung:
// Das Programm speichert in, liest aus,erstellt und leert eine Datei.

// --------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;

namespace IO_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\users\flo\Desktop\test";
            string appendText = textBox1.Text + Environment.NewLine;                //Button save wird geklickt = Das programm speichert die Eingabe in die Datei.
            File.AppendAllText(path, appendText);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\users\flo\Desktop\test";                             //Button Read wird gegklickt = Das Programm liest die Datei aus und gibt diese aus.
            textBox2.Text = File.ReadAllText(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\users\flo\Desktop\test";                             //Button clear File wird gegklickt = Das Programm leert die Datei.
            File.WriteAllText(path, string.Empty);
        }
    }
}
