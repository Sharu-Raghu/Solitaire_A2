using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Card1
{

    public partial class MainForm : Form
    {

        public static int CARD_CAP = 30;

        public MainForm()
        {
            InitializeComponent();
            Height = 800;
            Width = 1200;

            Rectangle m_rect;

            //Create the quick access arrays.
            //foundations.Add(Foundation1);
            //foundations.Add(Foundation2);
            //foundations.Add(Foundation3);
            //foundations.Add(Foundation4);

            //Screen Rectangle
            m_rect = new Rectangle(0, 0, Width, Height);

            //Creating All decks
            int cap = CARD_CAP;

            //Tableaus.Add(Tableau1);
            //tableaus.Add(Tableau2);
            //tableaus.Add(Tableau3);
            //tableaus.Add(Tableau4);
            //tableaus.Add(Tableau5);
            //tableaus.Add(Tableau6);
            //tableaus.Add(Tableau7);

            //CreateCards();
            CreateTableaus();

            //Image imgAceDiamond = Image.FromFile(@"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\DA.PNG");

            //Foundation_1.Image = imgAceDiamond;


        }
        //start for the button click
        public void CreateCards(object sender, EventArgs e)
        {
            /*Cards cards = new Cards();
            int horizontal = 30;
            int vertical = 30;

            Button[] buttonArray = new Button[9];
            Button btn = new Button();
            int coIN = 0;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(80, 150);
                buttonArray[i].Location = new Point(horizontal, vertical);
                buttonArray[i].Text = " My btn" + i.ToString();
                buttonArray[i].TextImageRelation = TextImageRelation.TextBeforeImage;
                buttonArray[i].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                buttonArray[i].Image = Image.FromFile(@"C:\Temp\Solitaire_assignment2\Solitaire\Card1\Resources\Decks\Classic\HA.png");

                if ((i + 1) % 3 == 0)
                {
                    coIN = coIN + 1;
                    vertical = 30;
                    horizontal = 30 + coIN * 110;
                }
                else vertical += 160;
                //buttonArray[i].MouseDown += new MouseEventHandler(OnbtnDown);

            } */

        }
        //end part

        public void CreateTableaus()
        {
            Tableaus tableaus = new Tableaus(new Cards());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tableau deck = new Tableau(this);


        }

        private void New_game_Click(object sender, EventArgs e)
        {
            CreateCards(sender, e);
        }
    }
}
