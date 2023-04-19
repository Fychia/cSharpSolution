namespace PharmacyManagement
{
    public partial class Load : Form
    {
        int startload = 0;
        public Load()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startload += 1;
            loadProgressbar.Value = startload;
            if (loadProgressbar.Value == 100)
            {
                loadProgressbar.Value = 0;
                timerLoad.Stop();

                Login myLogin = new Login();
                this.Hide();
                myLogin.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timerLoad.Start();
        }
    }
}