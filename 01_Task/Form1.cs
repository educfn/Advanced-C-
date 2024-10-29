using System.Net;

namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //REDE, ARMAZENAMENTO, TELA/DISPLAY
        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            //TASK - Asynchrono (Thread)
            string endereco = txtSite.Text;

            WebClient web = new WebClient();
            //string html = web.DownloadString(endereco);

            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }
    }
}
