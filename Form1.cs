using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace passwordgeneretor
{
    public partial class Form1 : Form
    {
        char beginningChar, endChar;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButn_Click(object sender, EventArgs e)
        {
            displayLBox.Items.Clear();
            Random generateRandom = new Random();
            beginningChar = char.Parse(restrictionsF.Text);
            endChar = char.Parse(restrictionsT.Text);
            counter = int.Parse(lengthBox.Text);
            string[] collection = new string[counter];
            
            for (int i = 0;i<counter;i++ )
            {
                string character="";
                for (int counterChar = 0; counterChar < counter;counterChar++ )
                character += Convert.ToChar((generateRandom.Next(beginningChar, endChar)));
                 collection[i] = character;
                displayLBox.Items.Add(collection[i]);
            }
        }

        private void displayLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
