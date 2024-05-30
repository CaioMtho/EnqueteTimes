
namespace EnqueteTimes
{
    public partial class Form1 : Form
    {
        Classifique clas = new Classifique();
        public Form1()
        {
            InitializeComponent();
            resCor.Text = Convert.ToString(clas.Resultado("cor"));
            resPal.Text = Convert.ToString(clas.Resultado("pal"));
            resSan.Text = Convert.ToString(clas.Resultado("san"));
            resSao.Text = Convert.ToString(clas.Resultado("sao"));
        }

        private void corimg_Click(object sender, EventArgs e)
        {
            clas.Acrescente("cor");
            resCor.Text = Convert.ToString(clas.Resultado("cor"));
        }

        private void palimg_Click(object sender, EventArgs e)
        {
            clas.Acrescente("pal");
            resPal.Text = Convert.ToString(clas.Resultado("pal"));
        }

        private void sanimg_Click(object sender, EventArgs e)
        {
            clas.Acrescente("san");
            resSan.Text = Convert.ToString(clas.Resultado("san"));

        }

        private void saoimg_Click(object sender, EventArgs e)
        {
            clas.Acrescente("sao");
            resSao.Text = Convert.ToString(clas.Resultado("sao"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (clas.Ganhador())
            {
                case 0: MessageBox.Show("O Corinthians foi o vencedor!"); break;
                case 1: MessageBox.Show("O São Paulo foi o vencedor!"); break;
                case 2: MessageBox.Show("O Palmeiras foi o vencedor!"); break;
                case 3: MessageBox.Show("O Santos foi o vencedor!"); break;
                case 4: MessageBox.Show("Empate!"); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clas.Redefina();
            resCor.Text = "0";
            resPal.Text = "0";
            resSan.Text = "0";
            resSao.Text = "0";

        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada clique no escudo contará um voto para o respectivo clube, aperte \"Restaurar\" para reiniciar a votação e \"Encerrar\" para mostrar o vencedor!");
        }
    }
}
