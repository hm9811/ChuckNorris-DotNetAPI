﻿using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Joke jokes = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(jokes.JokeText);
        }

        private void categoriesCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string[] choice = (string[])await ChuckNorrisClient.GetCategories();
            categoriesCbox.Items.AddRange(choice);

            categoriesCbox.SelectedIndex = 0;
        }
    }
}
