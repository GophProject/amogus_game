using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amogus_game
{
    public partial class Amogus : Form
    {
        static string[] words = { "подарки", "космос", "космонавт", "зима", "снегопад", "ёлка" };
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;
        public Amogus()
        {
            InitializeComponent();
            words = new string[] { "подарки", "космос", "космонавт", "зима", "снегопад", "ёлка" };
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            current_word = "";
            show_text = "";
            lives = lives_image.Length;
            start_game(textBox1, lives_image);
        }
        void start_game(TextBox wordArea)
        {
            Random random = new Random();
            int index = random.Next(words.Length);
            current_word = words[index];
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            lives = lives_image.Length;
        }
        void start_game(TextBox wordArea, PictureBox[] lives_image)
        {
            start_game(wordArea);
            var image = Properties.Resources.live;
            for (int i = 0; i < lives_image.Length; i++)
            {
                lives_image[1].Image = image;
            }
        }
        string get_show_text(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    result += '*';
                }
                else
                {
                    result += ' ';
                }
            }
            return result;
        }
        bool is_countains(string word, char symbol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }
        string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string new_show_text = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    new_show_text += symbol;
                }
                else
                {
                    new_show_text += old_show_text[i];
                }
            }
            return new_show_text;
        }
        void button_symbol_click(TextBox wordArea, char symbol, Button cur_button, Button start_button)
        {
            bool is_count = is_countains(current_word, symbol);
            if (is_count)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }

            if (lives == 0)
            {
                using (Game_over_ game_Over_ = new Game_over_())
                {
                    game_Over_.ShowDialog();
                }
                start_button.PerformClick();
            }

            else if (!is_countains(show_text, '*'))
            {
                using (Level_complete_ success = new Level_complete_())
                {
                    success.ShowDialog();
                }
            }
            cur_button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'а', button1, restart_game);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'б', button2, restart_game);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'в', button10, restart_game);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'г', button9, restart_game);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'д', button8, restart_game);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'е', button7, restart_game);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ё', button6, restart_game);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ж', button5, restart_game);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'з', button4, restart_game);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'и', button3, restart_game);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'й', button17, restart_game);
        }
    }
}
