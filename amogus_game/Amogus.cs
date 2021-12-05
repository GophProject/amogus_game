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
        static string[] words = {"праздник", "новый год", "космос","космонавт", "предатель", "зима", "снегопад" };
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;
        public Amogus()
        {
            InitializeComponent();
            words = new string[] { "праздник", "новый год", "космос", "космонавт", "предатель", "зима", "снегопад" };
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            current_word = "";
            show_text = "";
            lives = lives_image.Length;
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
            for(int i = 0; i < lives_image.Length; i++)
            {
                lives_image[1].Image = image;
            }
        }
        string get_show_text(string word)
        {
        }
        bool is_countains(string word, char symbol)
        {
        }
        string get_new_show_text(string word, char symbol, string old_show_text)
        {
        }
        void button_symbol_click (TextBox wordArea, char symbol, Button cur_button, Button start_button)
        }
    }
}
