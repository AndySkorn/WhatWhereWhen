namespace W3
{
    partial class GameBuilding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remTeam = new System.Windows.Forms.Button();
            this.createGame = new System.Windows.Forms.Button();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberTours = new System.Windows.Forms.MaskedTextBox();
            this.numberQuestions = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(145, 32);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(132, 20);
            this.gameName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название игры";
            // 
            // addTeam
            // 
            this.addTeam.Location = new System.Drawing.Point(300, 174);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(118, 25);
            this.addTeam.TabIndex = 3;
            this.addTeam.Text = "Создать команду";
            this.addTeam.UseVisualStyleBackColor = true;
            this.addTeam.Click += new System.EventHandler(this.addTeam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество туров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вопросов в туре";
            // 
            // remTeam
            // 
            this.remTeam.Enabled = false;
            this.remTeam.Location = new System.Drawing.Point(281, 271);
            this.remTeam.Name = "remTeam";
            this.remTeam.Size = new System.Drawing.Size(74, 23);
            this.remTeam.TabIndex = 9;
            this.remTeam.Text = ">";
            this.remTeam.UseVisualStyleBackColor = true;
            this.remTeam.Click += new System.EventHandler(this.remTeam_Click);
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(300, 145);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(118, 23);
            this.createGame.TabIndex = 10;
            this.createGame.Text = "Создать игру";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(16, 145);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(261, 251);
            this.teamListBox.TabIndex = 11;
            this.teamListBox.SelectedIndexChanged += new System.EventHandler(this.teamListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Список принятых команд";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(442, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 251);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Команды";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(281, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberTours
            // 
            this.numberTours.Location = new System.Drawing.Point(145, 62);
            this.numberTours.Mask = "00";
            this.numberTours.Name = "numberTours";
            this.numberTours.Size = new System.Drawing.Size(62, 20);
            this.numberTours.TabIndex = 16;
            this.numberTours.ValidatingType = typeof(int);
            // 
            // numberQuestions
            // 
            this.numberQuestions.Location = new System.Drawing.Point(145, 93);
            this.numberQuestions.Mask = "00";
            this.numberQuestions.Name = "numberQuestions";
            this.numberQuestions.Size = new System.Drawing.Size(62, 20);
            this.numberQuestions.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GameBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(729, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberQuestions);
            this.Controls.Add(this.numberTours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.remTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameName);
            this.Name = "GameBuilding";
            this.Text = "Создание игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remTeam;
        private System.Windows.Forms.Button createGame;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox numberTours;
        private System.Windows.Forms.MaskedTextBox numberQuestions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}