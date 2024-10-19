using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;
            //vid.Encoded

            btnVideoEncode.Click;
        }
    }
}
