using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Media;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Game_Show_Night_2017
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //
        //Variables
        //
        Button[] questionButtons;
        Button[] questionButtonsBoard;
        Label[] questionLabels;
        Label[] answerLabels;
        CheckBox[] checkBoxBoard;
        //Path of data
        string Path = @"C:\Users\" + Environment.UserName + @"\Documents\my games\Game Show Night 2017\GSN Final Game.xlsx";
        //Holds all data and tests against choice
        string[,,] Questions;
        string[,,] Answers;
        int[,] correctAnswers;
        int Division = 0;
        int currentQuestion = 1;
        int answerChoice = 1;
        string teamName1 = "Team 1";
        string teamName2 = "Team 2";
        //Keeps track of score and team to answer
        int[] scoreTeam = new int[2 + 1];
        //Used to remove answers from screen
        int[,] defaultLocation = new int[1 + 1, 2 + 1];
        int removeAnswerTimer = 0;
        int showAnswerNumber = 0;
        bool questionMode = false;
        //Sets Sound
        bool[] sound = new bool[5 + 1];
        SoundPlayer soundWrong;
        SoundPlayer soundCorrect1;
        SoundPlayer soundCorrect2;
        SoundPlayer soundSelect;
        SoundPlayer soundTime;
        //Form2
        public Form2 form2 = new Form2();
        //
        //
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
            setGame();
            form2.Show();
        }
        //
        //Timers
        //
        private void frameRate_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (checkBoxBoard[i].Checked == true)
                {
                    questionButtons[i].Visible = false;
                    questionButtonsBoard[i].Enabled = false;
                }
                else
                {
                    questionButtons[i].Visible = true;
                    if (questionMode == false) questionButtonsBoard[i].Enabled = true;
                }
            }
        }

        private void timerRemoveAnswer_Tick(object sender, EventArgs e)
        {
            removeAnswerTimer++;
            if (removeAnswerTimer >= 50)
            {
                answerLabels[answerChoice].Location = new Point(answerLabels[answerChoice].Location.X - 9, answerLabels[answerChoice].Location.Y);
                if (answerLabels[answerChoice].Location.X + answerLabels[answerChoice].Size.Width <= -10)
                {
                    buttonHighlight1.Enabled = true;
                    buttonHighlight2.Enabled = true;
                    buttonHighlight3.Enabled = true;
                    buttonHighlight4.Enabled = true;
                    removeAnswerTimer = 0;
                    timerRemoveAnswer.Enabled = false;
                }

            }
        }

        private void timerShowAnswer_Tick(object sender, EventArgs e)
        {
            answerLabels[showAnswerNumber].Location = new Point(answerLabels[showAnswerNumber].Location.X + 9, answerLabels[showAnswerNumber].Location.Y);
            if (answerLabels[showAnswerNumber].Location.X >= 130)
            {
                timerShowAnswer.Enabled = false;
                if (showAnswerNumber != 4) buttonShowAnswers.Enabled = true;
            }

        }
        //
        //Functions
        //
        private void setGame()
        {
            Questions = new string[3, 12 + 1, 2 + 1];
            Answers = new string[3, 12 + 1, 5 + 1];
            correctAnswers = new int[3, 12 + 1];
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook;
            try
            {
                xlWorkbook = xlApp.Workbooks.Open(Path);
            }
            catch
            {
                MessageBox.Show("Could not find GSN Final Game.xlsx, please locate.");
                if (openFileDialogGSNFinalGame.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogGSNFinalGame.FileName, Path);
                    panelFindDoc.Visible = false;
                }
                else
                {
                    panelFindDoc.Visible = true;
                    return;
                }
            }

            xlWorkbook = xlApp.Workbooks.Open(Path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
           
           
            
            

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            int ADQuestions = 1;
            while (xlRange.Cells[ADQuestions, 1].Value2.ToString() != "AD")
            {
                ADQuestions++;
            }
            while (xlRange.Cells[ADQuestions, 1].Value2.ToString() == "AD")
            {
                ADQuestions++;
            }
            int JHQuestions = ADQuestions;
            while (xlRange.Cells[JHQuestions, 1].Value2.ToString() == "JH")
            {
                JHQuestions++;
            }
            int SHQuestions = JHQuestions;
            while (SHQuestions < rowCount && xlRange.Cells[SHQuestions, 1].Value2.ToString() == "SH")
            {
                SHQuestions++;
            }

            for (int i = 2; i < ADQuestions; i++)
            {
                Questions[0, i - 1, 1] = xlRange.Cells[i, 3].Value2.ToString();
                Questions[0, i - 1, 2] = xlRange.Cells[i, 9].Value2.ToString();
                Answers[0, i - 1, 5] = xlRange.Cells[i, 10].Value2.ToString();
                correctAnswers[0, i - 1] = Convert.ToInt32(xlRange.Cells[i, 8].Value2);
                for (int j = 4; j <= 7; j++)
                {
                    Answers[0, i - 1, j - 3] = xlRange.Cells[i, j].Value2.ToString();
                }
            }
            for (int i = ADQuestions; i < JHQuestions; i++)
            {
                Questions[1, i - ADQuestions + 1, 1] = xlRange.Cells[i, 3].Value2.ToString();
                Questions[1, i - ADQuestions + 1, 2] = xlRange.Cells[i, 9].Value2.ToString();
                Answers[1, i - ADQuestions + 1, 5] = xlRange.Cells[i, 10].Value2.ToString();
                correctAnswers[1, i - ADQuestions + 1] = Convert.ToInt32(xlRange.Cells[i, 8].Value2);
                for (int j = 4; j <= 7; j++)
                {
                    Answers[1, i - ADQuestions + 1, j - 3] = xlRange.Cells[i, j].Value2.ToString();
                }
            }
            for (int i = JHQuestions; i < SHQuestions; i++)
            {
                Questions[2, i - JHQuestions + 1, 1] = xlRange.Cells[i, 3].Value2.ToString();
                Questions[2, i - JHQuestions + 1, 2] = xlRange.Cells[i, 9].Value2.ToString();
                Answers[2, i - JHQuestions + 1, 5] = xlRange.Cells[i, 10].Value2.ToString();
                correctAnswers[2, i - JHQuestions + 1] = Convert.ToInt32(xlRange.Cells[i, 8].Value2);
                for (int j = 4; j <= 7; j++)
                {
                    Answers[2, i - JHQuestions + 1, j - 3] = xlRange.Cells[i, j].Value2.ToString();
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                Questions[i, 0, 1] = "Chicago is ";
                Answers[i, 0, 1] = "a City";
                Answers[i, 0, 2] = "windy";
                Answers[i, 0, 3] = "in South America";
                Answers[i, 0, 4] = "in Illinois";
                Questions[i, 0, 2] = "What is the biggest country in South America?";
                Answers[i, 0, 5] = "Brazil";
                correctAnswers[i, 0] = 3;
            }

            xlWorkbook.Save();
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void setQuestion(int number)
        {
            questionLabels[1].Text = Questions[Division, number, 1];
            answerLabels[1].Text = Answers[Division, number, 1];
            answerLabels[2].Text = Answers[Division, number, 2];
            answerLabels[3].Text = Answers[Division, number, 3];
            answerLabels[4].Text = Answers[Division, number, 4];
            questionLabels[2].Text = Questions[Division, number, 2];
            answerLabels[5].Text = Answers[Division, number, 5];

            labelQuestion1.Text = Questions[Division, number, 1];
            labelAnswer1.Text = Answers[Division, number, 1];
            labelAnswer2.Text = Answers[Division, number, 2];
            labelAnswer3.Text = Answers[Division, number, 3];
            labelAnswer4.Text = Answers[Division, number, 4];
            labelQuestion2.Text = Questions[Division, number, 2];
            labelCorrectAnswer.Text = "" + correctAnswers[Division, currentQuestion];
            labelAnswer5.Text = Answers[Division, currentQuestion, 5];

            buttonDisplayBoard.Enabled = true;
            buttonShowAnswers.Enabled = true;
            buttonCheckAnswer.Enabled = true;
            buttonHighlight1.Enabled = true;
            buttonHighlight2.Enabled = true;
            buttonHighlight3.Enabled = true;
            buttonHighlight4.Enabled = true;
            buttonResetAnswers.Enabled = true;
            buttonShowFollowUp.Enabled = true;
            buttonCheckFollowUp.Enabled = true;
            buttonWrongFollowUp.Enabled = true;
            buttonHideFollowUp.Enabled = true;
            questionMode = true;
            for (int i = 1; i <= 12; i++)
            {
                questionButtonsBoard[i].Enabled = false;
            }

            resetBoard();

            if (currentQuestion != 0) checkBoxBoard[currentQuestion].Checked = true;
            form2.panelBoard.Visible = false;
            form2.panelQuestion.Visible = true;
        }

        private void resetBoard()
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].Location = new Point((0 - answerLabels[i].Size.Width), defaultLocation[1, 2] - 80 + i * 80);
                //answerLabels[i].Location = new Point(defaultLocation[1, 1], defaultLocation[1,2]-80 + i * 80);
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
            questionLabels[2].Visible = false;
            answerLabels[5].Visible = false;
            form2.pictureBoxWrongAnswer.Visible = false;
            showAnswerNumber = 0;
        }

        private void Initialize()
        {
            questionLabels = new Label[2 + 1];
            answerLabels = new Label[5 + 1];
            questionLabels[1] = form2.labelQuestion1;
            answerLabels[1] = form2.labelAnswer1;
            answerLabels[2] = form2.labelAnswer2;
            answerLabels[3] = form2.labelAnswer3;
            answerLabels[4] = form2.labelAnswer4;
            questionLabels[2] = form2.labelQuestion2;
            answerLabels[5] = form2.labelAnswer5;

            questionButtons = new Button[12 + 1];
            questionButtons[1] = form2.buttonQuestion1;
            questionButtons[2] = form2.buttonQuestion2;
            questionButtons[3] = form2.buttonQuestion3;
            questionButtons[4] = form2.buttonQuestion4;
            questionButtons[5] = form2.buttonQuestion5;
            questionButtons[6] = form2.buttonQuestion6;
            questionButtons[7] = form2.buttonQuestion7;
            questionButtons[8] = form2.buttonQuestion8;
            questionButtons[9] = form2.buttonQuestion9;
            questionButtons[10] = form2.buttonQuestion10;
            questionButtons[11] = form2.buttonQuestion11;
            questionButtons[12] = form2.buttonQuestion12;

            questionButtonsBoard = new Button[12 + 1];
            questionButtonsBoard[1] = buttonBoard1;
            questionButtonsBoard[2] = buttonBoard2;
            questionButtonsBoard[3] = buttonBoard3;
            questionButtonsBoard[4] = buttonBoard4;
            questionButtonsBoard[5] = buttonBoard5;
            questionButtonsBoard[6] = buttonBoard6;
            questionButtonsBoard[7] = buttonBoard7;
            questionButtonsBoard[8] = buttonBoard8;
            questionButtonsBoard[9] = buttonBoard9;
            questionButtonsBoard[10] = buttonBoard10;
            questionButtonsBoard[11] = buttonBoard11;
            questionButtonsBoard[12] = buttonBoard12;

            checkBoxBoard = new CheckBox[12 + 1];
            checkBoxBoard[1] = checkBoxBoard1;
            checkBoxBoard[2] = checkBoxBoard2;
            checkBoxBoard[3] = checkBoxBoard3;
            checkBoxBoard[4] = checkBoxBoard4;
            checkBoxBoard[5] = checkBoxBoard5;
            checkBoxBoard[6] = checkBoxBoard6;
            checkBoxBoard[7] = checkBoxBoard7;
            checkBoxBoard[8] = checkBoxBoard8;
            checkBoxBoard[9] = checkBoxBoard9;
            checkBoxBoard[10] = checkBoxBoard10;
            checkBoxBoard[11] = checkBoxBoard11;
            checkBoxBoard[12] = checkBoxBoard12;

            defaultLocation[1, 1] = answerLabels[1].Location.X;
            defaultLocation[1, 2] = answerLabels[1].Location.Y;

            setSounds();
        }

        private void setSounds()
        {
            for (int i = 1; i <= 5; i++)
            {
                sound[i] = false;
            }
            if (File.Exists(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzWrong.wav"))
            {
                soundWrong = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzWrong.wav");
                sound[1] = true;
            }
            else
            {
                MessageBox.Show("Could not find BuzzWrong.wav, please locate.");
                if (openFileDialogSounds.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogSounds.FileName, @"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzWrong.wav");
                    soundWrong = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzWrong.wav");
                    sound[1] = true;
                }
                else
                {
                    sound[2] = false;
                }
            }

            if (File.Exists(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect1.wav"))
            {
                soundCorrect1 = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect1.wav");
                sound[2] = true;
            }
            else
            {
                MessageBox.Show("Could not find BuzzCorrect1.wav, please locate.");
                if (openFileDialogSounds.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogSounds.FileName, @"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect1.wav");
                    soundCorrect1 = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect1.wav");
                    sound[2] = true;
                }
                else
                {
                    sound[2] = false;
                }
            }

            if (File.Exists(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect2.wav"))
            {
                soundCorrect2 = new SoundPlayer(@"C: \Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect2.wav");
                sound[3] = true;
            }
            else
            {
                MessageBox.Show("Could not find BuzzCorrect2.wav, please locate.");
                if (openFileDialogSounds.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogSounds.FileName, @"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect2.wav");
                    soundCorrect2 = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzCorrect2.wav");
                    sound[3] = true;
                }
                else
                {
                    sound[3] = false;
                }
            }

            if (File.Exists(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzSelect.wav"))
            {
                soundSelect = new SoundPlayer(@"C: \Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzSelect.wav");
                sound[4] = true;
            }
            else
            {
                MessageBox.Show("Could not find BuzzSelect.wav, please locate.");
                if (openFileDialogSounds.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogSounds.FileName, @"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzSelect.wav");
                    soundSelect = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzSelect.wav");
                    sound[4] = true;
                }
                else
                {
                    sound[4] = false;
                }
            }

            if (File.Exists(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzTime.wav"))
            {
                soundTime = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzTime.wav");
                sound[5] = true;
            }
            else
            {
                MessageBox.Show("Could not find BuzzTime.wav, please locate.");
                if (openFileDialogSounds.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialogSounds.FileName, @"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzTime.wav");
                    soundTime = new SoundPlayer(@"C:\Users\Jacob\Documents\my games\Game Show Night 2017\Sounds\BuzzTime.wav");
                    sound[5] = true;
                }
                else
                {
                    sound[5] = false;
                }
            }

            
        }
        //
        //Buttons
        //
        private void buttonBoard1_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());
            setQuestion(currentQuestion);
        }

        private void buttonBoard2_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());
            setQuestion(currentQuestion);
        }

        private void buttonBoard3_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard4_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard5_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard6_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard7_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard8_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard9_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString()[sender.ToString().Length - 1].ToString());

            setQuestion(currentQuestion);
        }

        private void buttonBoard10_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString().Substring(sender.ToString().Length - 2, 2));

            setQuestion(currentQuestion);
        }

        private void buttonBoard11_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString().Substring(sender.ToString().Length - 2, 2));

            setQuestion(currentQuestion);
        }

        private void buttonBoard12_Click(object sender, EventArgs e)
        {
            currentQuestion = Int32.Parse(sender.ToString().Substring(sender.ToString().Length - 2, 2));

            setQuestion(currentQuestion);
        }

        private void buttonDisplayBoard_Click(object sender, EventArgs e)
        {
            buttonDisplayBoard.Enabled = false;
            buttonCheckAnswer.Enabled = false;
            buttonHighlight1.Enabled = false;
            buttonHighlight2.Enabled = false;
            buttonHighlight3.Enabled = false;
            buttonHighlight4.Enabled = false;
            buttonResetAnswers.Enabled = false;
            buttonShowFollowUp.Enabled = false;
            buttonCheckFollowUp.Enabled = false;
            buttonWrongFollowUp.Enabled = false;
            buttonHideFollowUp.Enabled = false;
            questionMode = false;

            form2.panelBoard.Visible = true;
            form2.panelQuestion.Visible = false;
        }

        private void buttonShowWinner_Click(object sender, EventArgs e)
        {
            if (form2.panelWinScreen.Visible == false)
            {
                if (scoreTeam[1] > scoreTeam[2])
                {
                    form2.panelWinScreen.Visible = true;
                    form2.panelBoard.Visible = false;
                    form2.panelQuestion.Visible = false;
                    form2.labelWin1.Text = "Congratulations " + teamName1 + ".";
                }
                if (scoreTeam[2] > scoreTeam[1])
                {
                    form2.panelWinScreen.Visible = true;
                    form2.panelBoard.Visible = false;
                    form2.panelQuestion.Visible = false;
                    form2.labelWin1.Text = "Congratulations " + teamName2 + ".";
                }
            }
            else
            {
                form2.panelWinScreen.Visible = false;
                form2.panelBoard.Visible = true;
            }
        }

        private void buttonResetBoard_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                checkBoxBoard[i].Checked = false;
            }
        }


        private void buttonDivisionJH_Click(object sender, EventArgs e)
        {
            Division = 1;
            buttonDivisionJH.Enabled = false;
            buttonDivisionSH.Enabled = true;
            buttonDivisionAD.Enabled = true;
        }

        private void buttonDivisionSH_Click(object sender, EventArgs e)
        {
            Division = 2;
            buttonDivisionJH.Enabled = true;
            buttonDivisionSH.Enabled = false;
            buttonDivisionAD.Enabled = true;
        }

        private void buttonDivisionAD_Click(object sender, EventArgs e)
        {
            Division = 0;
            buttonDivisionJH.Enabled = true;
            buttonDivisionSH.Enabled = true;
            buttonDivisionAD.Enabled = false;
        }


        private void buttonSetNames_Click(object sender, EventArgs e)
        {
            form2.labelTeam1.Text = textBoxTeam1Name.Text;
            teamName1 = textBoxTeam1Name.Text;
            form2.labelTeam2.Text = textBoxTeam2Name.Text;
            teamName2 = textBoxTeam2Name.Text;
        }

        private void buttonScoreSet1_Click(object sender, EventArgs e)
        {
            scoreTeam[1] = Int32.Parse(textBoxScoreSet1.Text);
            labelScore1.Text = "Score: " + scoreTeam[1];
            form2.labelScoreTeam1.Text = "Score: " + scoreTeam[1];
        }

        private void buttonScoreSet11_Click(object sender, EventArgs e)
        {
            scoreTeam[1]++;
            labelScore1.Text = "Score: " + scoreTeam[1];
            form2.labelScoreTeam1.Text = "Score: " + scoreTeam[1];
        }

        private void buttonScoreSet12_Click(object sender, EventArgs e)
        {
            scoreTeam[1] = scoreTeam[1] + 2;
            labelScore1.Text = "Score: " + scoreTeam[1];
            form2.labelScoreTeam1.Text = "Score: " + scoreTeam[1];
        }

        private void buttonScoreSet21_Click(object sender, EventArgs e)
        {
            scoreTeam[2]++;
            labelScore2.Text = "Score: " + scoreTeam[2];
            form2.labelScoreTeam2.Text = "Score: " + scoreTeam[2];
        }

        private void buttonScoreSet22_Click(object sender, EventArgs e)
        {
            scoreTeam[2] = scoreTeam[2] + 2;
            labelScore2.Text = "Score: " + scoreTeam[2];
            form2.labelScoreTeam2.Text = "Score: " + scoreTeam[2];
        }

        private void buttonScoreSet2_Click(object sender, EventArgs e)
        {
            scoreTeam[2] = Int32.Parse(textBoxScoreSet2.Text);
            labelScore2.Text = "Score: " + scoreTeam[2];
            form2.labelScoreTeam2.Text = "Score: " + scoreTeam[2];
        }


        private void buttonShowAnswers_Click(object sender, EventArgs e)
        {
            showAnswerNumber++;
            timerShowAnswer.Enabled = true;
            buttonShowAnswers.Enabled = false;
        }

        private void buttonHighlight1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
            answerLabels[1].BackColor = Color.Yellow;
            answerLabels[1].ForeColor = Color.Black;
            answerChoice = 1;
            if (sound[5] == true) soundSelect.Play();
        }

        private void buttonHighlight2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
            answerLabels[2].BackColor = Color.Yellow;
            answerLabels[2].ForeColor = Color.Black;
            answerChoice = 2;
            if (sound[5] == true) soundSelect.Play();
        }

        private void buttonHighlight3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
            answerLabels[3].BackColor = Color.Yellow;
            answerLabels[3].ForeColor = Color.Black;
            answerChoice = 3;
            if (sound[5] == true) soundSelect.Play();
        }

        private void buttonHighlight4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
            answerLabels[4].BackColor = Color.Yellow;
            answerLabels[4].ForeColor = Color.Black;
            answerChoice = 4;
            if (sound[5] == true) soundSelect.Play();
        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            if (answerChoice == correctAnswers[Division, currentQuestion])
            {
                answerLabels[answerChoice].BackColor = Color.LimeGreen;
                answerLabels[answerChoice].ForeColor = Color.Black;
                if (checkBoxBuzz.Checked == true)
                {
                    if (sound[2] == true) soundCorrect1.Play();
                }
            }
            else
            {
                answerLabels[answerChoice].BackColor = Color.Red;
                answerLabels[answerChoice].ForeColor = Color.Black;
                buttonHighlight1.Enabled = false;
                buttonHighlight2.Enabled = false;
                buttonHighlight3.Enabled = false;
                buttonHighlight4.Enabled = false;
                timerRemoveAnswer.Enabled = true;
                if (checkBoxBuzz.Checked == true)
                {
                    if (sound[1] == true) soundWrong.Play();
                }
            }
        }

        private void buttonResetAnswers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                answerLabels[i].Location = new Point(defaultLocation[1, 1], defaultLocation[1, 2] - 80 + i * 80);
                answerLabels[i].BackColor = Color.Black;
                answerLabels[i].ForeColor = Color.White;
            }
        }

        private void buttonShowFollowUp_Click(object sender, EventArgs e)
        {
            questionLabels[2].Visible = true;
        }

        private void buttonCheckFollowUp_Click(object sender, EventArgs e)
        {
            form2.labelAnswer5.Visible = true;
            answerLabels[5].Visible = true;
            if (checkBoxBuzz.Checked == true)
            {
                if (sound[3] == true) soundCorrect2.Play();
            }
        }

        private void buttonWrongFollowUp_Click(object sender, EventArgs e)
        {
            form2.pictureBoxWrongAnswer.Visible = true;
            if (checkBoxBuzz.Checked == true)
            {
                if (sound[1] == true) soundWrong.Play();
            }
        }

        private void buttonHideFollowUp_Click(object sender, EventArgs e)
        {
            answerLabels[5].Visible = false;
            form2.pictureBoxWrongAnswer.Visible = false;
        }


        private void buttonShowCorrectAnswer_Click(object sender, EventArgs e)
        {
            if (buttonShowCorrectAnswer.Text == "Show Answer")
            {
                buttonShowCorrectAnswer.Text = "Hide";
                labelCorrectAnswer.Visible = true;
            }
            else
            {
                buttonShowCorrectAnswer.Text = "Show Answer";
                labelCorrectAnswer.Visible = false;
            }
        }

        private void buttonShowCorrectFollowUp_Click(object sender, EventArgs e)
        {
            if (buttonShowCorrectFollowUp.Text == "Show Answer")
            {
                buttonShowCorrectFollowUp.Text = "Hide";
                labelAnswer5.Visible = true;
            }
            else
            {
                buttonShowCorrectFollowUp.Text = "Show Answer";
                labelAnswer5.Visible = false;
            }
        }


        private void buttonShowExample_Click(object sender, EventArgs e)
        {
            setQuestion(0);
            currentQuestion = 0;
        }
        

        private void buttonBuzzCorrect1_Click(object sender, EventArgs e)
        {
            if (sound[2] == true) soundCorrect1.Play();
        }

        private void buttonBuzzCorrect2_Click(object sender, EventArgs e)
        {
            if (sound[3] == true) soundCorrect2.Play();
        }

        private void buttonBuzzWrong_Click(object sender, EventArgs e)
        {
            if (sound[1] == true) soundWrong.Play();
        }

        private void buttonBuzzTime_Click(object sender, EventArgs e)
        {
            if (sound[4] == true) soundTime.Play();
        }

        private void buttonShowForm2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void buttonFindDoc_Click(object sender, EventArgs e)
        {
            setGame();
        }
    }
}
