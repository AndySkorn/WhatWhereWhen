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
    public partial class CurrentGame : BaseForm
    {
        //TODO

        //4. вывод итоговых мест
        //5. научиться работать с файлами

        

        private int sequence; //Номер вопроса
        private int countQuestions;
        private int countTeam;
        private int countTours;

        private Game game = new Game();
        private List<TeamsInGame> teamsInGame = new List<TeamsInGame>();
        private List<Team> teams = new List<Team>();
        private DataTable dt = new DataTable();




        public CurrentGame()
        {
            InitializeComponent();

            game = Data.getInstance().selectedGame;
            teamsInGame = game.teamsInGame;

            countTeam = teamsInGame.Count();
            sequence = game.countQuestion;

            countQuestions = game.amt;

            countTours = game.numberTours;

            

            for (int i = 0; i < countTours; i++)
            {
                TabPage newTabPage = new TabPage();
                newTabPage.Text = "Тур №"+(i+1);
                tabControl1.TabPages.Add(newTabPage);

                
            }

            dt.Columns.Add("Название команды");
            dt.Columns.Add("Лига");
            for (int j = 1; j <= countQuestions; j++)
            {
                dt.Columns.Add("" + j);

            }

            initTable();

        }
        private void initTable()
        {
            dt.Rows.Clear();
            for (int i = 0; i < countTeam; i -= -1)
            {
                DataRow r = dt.NewRow();
                r["Название команды"] = teamsInGame[i].team.nameTeam;
                r["Лига"] = teamsInGame[i].team.league;
                for (int j = 0; j < countQuestions; j++)
                    if (teamsInGame[i].question[j].teamAnswer)
                        r["" + (j + 1)] = "+";
                    else
                        r["" + (j + 1)] = "-";

                dt.Rows.Add(r);
            }

            dataGridView1.DataSource = dt;
            


        }


        private void answerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.getInstance().teamsInGame = teamsInGame;
            Data.getInstance().countQuestion = sequence;
            
            Answer answerForm = new Answer();
            ShowNextForm(answerForm, false);
        
            teamsInGame = Data.getInstance().teamsInGame;
            sequence++;

            teamsInGame.Sort((x, y) =>
            {
                if (x.team.league.Equals(y.team.league))
                    return y.count.CompareTo(x.count);
                else
                    return y.team.league.CompareTo(x.team.league);
            }
            );

            initTable();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            game.teamsInGame = teamsInGame;
            game.countQuestion = sequence;
            Data.getInstance().selectedGame = game;

            


            this.Close();
        }

        
    }
}
