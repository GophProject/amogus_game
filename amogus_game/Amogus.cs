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
                lives_image[i].Image = image;
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
                Close();
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

        private void button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'к', button27, restart_game);
        }

        private void restart_game_Click(object sender, EventArgs e)
        {
            start_game(textBox1, lives_image);
            Button[] buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button30, button31, button32, button33 };
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'л', button26, restart_game);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'м', button25, restart_game);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'н', button24, restart_game);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'о', button23, restart_game);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'п', button22, restart_game);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'р', button21, restart_game);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'с', button20, restart_game);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'т', button19, restart_game);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'у', button18, restart_game);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ф', button16, restart_game);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'х', button15, restart_game);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ц', button14, restart_game);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ч', button13, restart_game);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ш', button12, restart_game);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'щ', button11, restart_game);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ы', button33, restart_game);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ъ', button32, restart_game);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ь', button31, restart_game);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'э', button30, restart_game);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'ю', button29, restart_game);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(textBox1, 'я', button28, restart_game);
        }
    }
}
