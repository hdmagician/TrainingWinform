using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const int WTileSize = 16;
        const int HTileSize = 9;

        string Map;

        Image Human;
        Image HumanF;
        Image HumanL;
        Image HumanR;
        Image HumanB;
        Image Wall;
        Image Road;
        Image Box;
        Image Dot;
        int WTile;
        int HTile;

        int XHuman;
        int YHuman;
        public Form1()
        {
            InitializeComponent();

            HumanF = new Bitmap(Properties.Resources.HumanF);
            WTile = HumanF.Width;
            HTile = HumanF.Height;
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            HumanB = new Bitmap(Properties.Resources.HumanB);
            Human = HumanF;
            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Box = new Bitmap(Properties.Resources.Box);
            Dot = new Bitmap(Properties.Resources.Dot);

            XHuman = 0;
            YHuman = 0;

            Map = "# B #    BBB   #";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < WTileSize; ++i)
            {
                if ('#' == Map[i])
                {
                    e.Graphics.DrawImage(Wall, WTile * i, 0);
                }
                else if ('B' == Map[i])
                {
                    e.Graphics.DrawImage(Box, WTile * i, 0);
                }
            }
            e.Graphics.DrawImage(Human, XHuman, YHuman);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    XHuman = XHuman - 10;
                    Human = HumanL;
                    break;
                case Keys.Right:
                    XHuman = XHuman + 10;
                    Human = HumanR;
                    break;
                case Keys.Up:
                    YHuman = YHuman - 10;
                    Human = HumanB;
                    break;
                case Keys.Down:
                    YHuman = YHuman + 10;
                    Human = HumanF;
                    break;
                default:
                    return;
            }

            Refresh();

        }
    }
}