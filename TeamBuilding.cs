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
    public partial class TeamBuilding : BaseForm
    {
        private static int sequence = 1;
        public TeamBuilding()
        {
            InitializeComponent();
        }
        public TeamBuilding(GameBuilding gameBuilding)
        {
            InitializeComponent();
        }

        private void TeamBuilding_Load(object sender, EventArgs e)
        {
            addTeam.Enabled = false;
        }
        private void teamName_TextChanged(object sender, EventArgs e)
        {
           if(teamName.TextLength > 0)
            {
                addTeam.Enabled = true;
            }
           else
            {
                addTeam.Enabled = false;
            }
        }
        private void leagueBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTeam_Click(object sender, EventArgs e)
        {
            string _nameTeam = teamName.Text;
            string _league = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            int _teamId = sequence;
            sequence += 1;
            Team _team= new Team(_nameTeam, _league, _teamId);
            Data.getInstance().createdTeam = _team;
            this.Close();
        }

        
    }
}
