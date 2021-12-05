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
        static string[] words = { };
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;
        public Amogus()
        {
            InitializeComponent();
        }
    }
}
