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
    public partial class Answer : BaseForm
    {
        private List<TeamsInGame> teamsInGame = new List<TeamsInGame>();
        private int numQuestion = Data.getInstance().countQuestion;

        private List<Team> teamList1; //Не ответившие
        private List<Team> teamList2; //Ответившие
        private Team buf1; //Не ответившие команды -> Ответившие
        private Team buf2; //Ответившие команды -> Не ответившие


        //2. сохранение ответов команд при нажатии кнопки сохранить
        public Answer()
        {
            InitializeComponent();
            teamsInGame = Data.getInstance().teamsInGame;

            button1.Enabled = false;
            button2.Enabled = false;


            teamList1 = new List<Team>();
            teamList2 = new List<Team>();
            for (int i = 0; i < teamsInGame.Count; i++)
                teamList1.Add(teamsInGame[i].team);

            bindData();
        }

        private void bindData() //Обновить данные в списках
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            listBox1.BeginUpdate();
            listBox2.BeginUpdate();

            listBox1.DataSource = teamList1;
            listBox1.DisplayMember = "NameTeam";
            listBox1.ValueMember = "TeamId";

            listBox2.DataSource = teamList2;
            listBox2.DisplayMember = "NameTeam";
            listBox2.ValueMember = "TeamId";

            listBox1.EndUpdate();
            listBox2.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
                button2.Enabled = false;
            else
            {
                button2.Enabled = true;
                buf1 = teamList1[index];
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
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
            listBox2.BeginUpdate();

            teamList1.Add(buf2);

            teamList2.Remove(buf2);

            button1.Enabled = false;
            listBox1.EndUpdate();
            listBox2.EndUpdate();
            bindData();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox2.BeginUpdate();

            teamList2.Add(buf1);

            teamList1.Remove(buf1);

            button2.Enabled = false;
            listBox1.EndUpdate();
            listBox2.EndUpdate();
            bindData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < teamList2.Count; i++)
            {
                for (int j = 0; j < teamsInGame.Count; j++)
                    if (teamList2[i].teamId == teamsInGame[j].team.teamId)
                    {
                        teamsInGame[j].question[numQuestion].teamAnswer = true;
                        teamsInGame[j].count+=1;
                    }
            }

            Data.getInstance().teamsInGame = teamsInGame;
            
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox2.BeginUpdate();
            foreach (Team i in teamList2)
            {
                teamList1.Add(i);
            }
            teamList2.Clear();

            button2.Enabled = false;
            listBox1.EndUpdate();
            listBox2.EndUpdate();
            bindData();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox2.BeginUpdate();
            foreach (Team i in teamList1)
            {
                teamList2.Add(i);
            }
            teamList1.Clear();
           
            button2.Enabled = false;
            listBox1.EndUpdate();
            listBox2.EndUpdate();
            bindData();
        }
    }
}
