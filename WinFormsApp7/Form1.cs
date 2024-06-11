namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        bool x = false;
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap[] imagas = { Resource1.png_transparent_super_mario_coin_illustration_super_mario_bros_super_mario_world_minecraft_coin_stack_angle_heroes_super_mario_bros_thumbnail, Resource1.png_transparent_gummy_bear_gummi_candy_bear_purple_food_animals_thumbnail, Resource1.png_transparent_candy_food_sweets_sweet_goody_sweetie_sugar };
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.Location = new Point(100, 100);
            timer1.Start();
            x = true;
            Refresh();
            count2++;
            label1.Text = count2.ToString();
            
        }
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 3)
            {
                pictureBox1.Size = new Size(200, 200);
                timer1.Stop();
                count = 0;
                x = false;
                Refresh();

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<Point> points = new();
            Bitmap animal =imagas[new Random().Next(3)];
            Point point = new Point(400, 100);
            points.Add(point);
            if (x)
                if (new Random().Next(0, 10) == 0)
                    e.Graphics.DrawImage(
                        animal,
                        points[0].X, points[0].Y,300,300);
            new Random().Next(0, 1);
        }
        int count2=0;
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text= count2.ToString();
        }
    }
}
