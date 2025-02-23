﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            jokeCategoriesCmbBox.DataSource = categories;
        }

        private async void RandomJokeBtn_Click(object sender, EventArgs e)
        {
            Joke randomJoke = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(randomJoke.JokeText);
        }
    }
}
