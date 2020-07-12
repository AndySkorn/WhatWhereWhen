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
    public partial class GameBuilding : BaseForm
    {

        private static int sequence = 1;

        private List<Team> teamList1; //Принятые
        private List<Team> teamList2; //Доступные
        private Team buf1; //Принятые команды -> доступные
        private Team buf2; //Доступные команды -> принятые
        public GameBuilding()
        {
            InitializeComponent();
            teamList1 = new List<Team>();
            teamList2 = new List<Team>(Data.getInstance().teams);

            bindData();
        }


        private void addTeam_Click(object sender, EventArgs e)
        {
            TeamBuilding teamBuilding = new TeamBuilding(this);
            ShowNextForm(teamBuilding, false);
            var team = Data.getInstance().createdTeam;
            Data.getInstance().teams.Add(team);
            teamList2.Add(team);
            bindData();
        }

        private void bindData() //Обновить данные в списках
        {
            listBox1.DataSource = null;
            teamListBox.DataSource = null;
            listBox1.BeginUpdate();
            teamListBox.BeginUpdate();
            listBox1.DataSource = teamList2;
            listBox1.DisplayMember = "NameTeam";
            listBox1.ValueMember = "TeamId";

            teamListBox.DataSource = teamList1;
            teamListBox.DisplayMember = "NameTeam";
            teamListBox.ValueMember = "TeamId";
            listBox1.EndUpdate();
            teamListBox.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
                button1.Enabled = false;
            else
            {

                button1.Enabled = true;
                buf2 = teamList2[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            teamListBox.BeginUpdate();
            teamList1.Add(buf2);
            teamList2.Remove(buf2);

            button1.Enabled = false;
            listBox1.EndUpdate();
            teamListBox.EndUpdate();
            bindData();

        }
        private void teamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = teamListBox.SelectedIndex;
            if (index == -1)
                remTeam.Enabled = false;
            else
            {
                remTeam.Enabled = true;

                buf1 = teamList1[index];
            }
        }
        private void remTeam_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            teamListBox.BeginUpdate();
            teamList2.Add(buf1);
            teamList1.Remove(buf1);
            remTeam.Enabled = false;

            listBox1.EndUpdate();
            teamListBox.EndUpdate();
            bindData();
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            if (gameName.TextLength > 0 && numberTours.TextLength > 0
               && numberQuestions.TextLength > 0 && teamList1.Count > 0)
            {
                string _gameName = gameName.Text;
                int _numberTours = Convert.ToInt32(numberTours.Text);
                int _numberQuestions = Convert.ToInt32(numberQuestions.Text);
                int _gameId = sequence;
                sequence += 1;
                int countTeam = teamList1.Count;

                int _countQuestions = _numberTours * _numberQuestions;

                List<TeamsInGame> _teamsInGame = new List<TeamsInGame>();
                for (int i = 0; i < countTeam; i -= -1)
                {
                    TeamsInGame t = new TeamsInGame(teamList1[i], _countQuestions);
                    _teamsInGame.Add(t);
                }

                Game game = new Game(_gameName, _numberTours, _numberQuestions, _gameId, _teamsInGame, _countQuestions);
                Data.getInstance().createdGame = game;
                this.Close();
            }

            else
            {
                MessageBox.Show("Введите название игры, количество туров, количество вопросов в туре и примите минимум одну команду");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            teamListBox.BeginUpdate();
            foreach (Team i in teamList2)
            {
                teamList1.Add(i);
            }
            teamList2.Clear();

            button1.Enabled = false;
            listBox1.EndUpdate();
            teamListBox.EndUpdate();
            bindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            teamListBox.BeginUpdate();
            foreach (Team i in teamList1)
            {
                teamList2.Add(i);
            }
            teamList1.Clear();

            button1.Enabled = false;
            listBox1.EndUpdate();
            teamListBox.EndUpdate();
            bindData();
        }
    }
}

