using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace W3
{
    public partial class Form1 : BaseForm
    {
        private List<Game> gameList;
        private Game buf;
        public Form1()
        {
            InitializeComponent();
            gameList = new List<Game>(Data.getInstance().games);
            bindData();
        }

        private void bindData() //Обновить данные в списках
        {
            listBox1.DataSource = null;
            listBox1.BeginUpdate();
            listBox1.DataSource = gameList;
            listBox1.DisplayMember = "NameGame";
            listBox1.ValueMember = "GameID";


            listBox1.EndUpdate();
        }


        private void createGame_Click(object sender, EventArgs e)
        {
            GameBuilding gameForm = new GameBuilding();
            ShowNextForm(gameForm, false);
            var game = Data.getInstance().createdGame;
            Data.getInstance().games.Add(game);
            gameList.Add(game);
            bindData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
                toolStripMenuItem1.Enabled = false;
            else
            {
                toolStripMenuItem1.Enabled = true;

                buf = gameList[index];
                Data.getInstance().selectedGame = buf;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Просмотр игры
        {
            CurrentGame resultForm = new CurrentGame();
            ShowNextForm(resultForm, false);

        }
    }
}
