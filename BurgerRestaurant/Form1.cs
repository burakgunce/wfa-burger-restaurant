using BurgerRestaurant.Concrete;

namespace BurgerRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Siparisler = new List<Order>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisEkraniGetir();
        }

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{Name="Whopper",Cost=120},
            new Menu{Name="Big Chicken",Cost=90}
        };

        public static List<Material> Malzemeler = new List<Material>()
        {
            new Material{Name="Ket�ap",Cost=5},
            new Material{Name="Mayonez",Cost=10}
        };
        public static List<Order> Siparisler;

        private void SiparisEkraniGetir()
        {
            Formlar�Kapat();

            Form2 form2 = new();
            BringTheScreen(form2);
        }

        private void Formlar�Kapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }




        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEkraniGetir();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            Form5 form5 = new Form5();
            BringTheScreen(form5);
        }

        public void BringTheScreen(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            this.Width = form.Width + 40;
            this.Height = form.Height + 80;
            form.Show();
        }

        private void sipari�leriG�r�nt�leToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            Form3 form3 = new Form3();
            BringTheScreen(form3);
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar�Kapat();

            Form4 form4 = new Form4();
            BringTheScreen(form4);
        }
    }
}