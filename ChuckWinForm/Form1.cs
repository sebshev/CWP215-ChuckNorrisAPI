using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var categories = await ChuckNorrisClient.GetCategories();
            foreach (var c in categories)
            {
                categorieCmbBox.Items.Add(c);
            }
            
        }

        private async void randJokeBtn_Click(object sender, EventArgs e)
        {
            var joke = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(joke.JokeText, "Joke");
        }
    }
}
