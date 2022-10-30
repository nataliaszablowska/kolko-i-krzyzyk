using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        private string Action = "X";
        public Form1()
        {
            InitializeComponent(Action);
        }
        private void ButtonOnClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (string.IsNullOrEmpty(button.Text))
            {
                button.Text = Action;
                if (IsPlayerWinnder())
                    EndGame(true);
                else if (IsEndOfGame())
                    EndGame(false);
                else
                    ChangeAction();
            }
        }

        private bool IsEndOfGame()
        {
            return !string.IsNullOrEmpty(button1.Text)
                && !string.IsNullOrEmpty(button2.Text)
                && !string.IsNullOrEmpty(button3.Text)
                && !string.IsNullOrEmpty(button4.Text)
                && !string.IsNullOrEmpty(button5.Text)
                && !string.IsNullOrEmpty(button6.Text)
                && !string.IsNullOrEmpty(button7.Text)
                && !string.IsNullOrEmpty(button8.Text)
                && !string.IsNullOrEmpty(button9.Text);
        }

        private void ButtonReplayOnClick(object sender, EventArgs e)
        {
            ClearButtons();
            EnableButtons(true);
            Action = "X";
            this.buttonReplay.Visible = false;
            this.label1.Text = "Czyj ruch?";
            this.label2.Text = Action;
        }

        private void ClearButtons()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }

        private void EndGame(bool isWinnder)
        {
            label2.Text = string.Empty;
            label1.Text = isWinnder ? $"KONIEC. Gracz {Action} wygrał" : "KONIEC. Remis.";
            EnableButtons(false);
            buttonReplay.Visible = true;
        }

        private void EnableButtons(bool enable)
        {
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button9.Enabled = enable;
        }

        private bool IsPlayerWinnder()
        {
            return (button1.Text == Action && button1.Text == button2.Text && button2.Text == button3.Text)
                || (button4.Text == Action && button4.Text == button5.Text && button5.Text == button6.Text)
                || (button7.Text == Action && button7.Text == button8.Text && button8.Text == button9.Text)
                || (button1.Text == Action && button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text == Action && button2.Text == button5.Text && button5.Text == button8.Text)
                || (button3.Text == Action && button3.Text == button6.Text && button6.Text == button9.Text)
                || (button1.Text == Action && button1.Text == button5.Text && button5.Text == button9.Text)
                || (button3.Text == Action && button3.Text == button5.Text && button5.Text == button7.Text)
                ;
        }

        private void ChangeAction()
        {
            Action = Action == "X" ? "Y" : "X";
            this.label2.Text = Action;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
