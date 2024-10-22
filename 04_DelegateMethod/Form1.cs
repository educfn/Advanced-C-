namespace _04_DelegateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //btnClick.Click += delegate (object sender, EventArgs e){
            btnClick.Click += delegate
            {
                MessageBox.Show("Olá, fui clicado!");
            };
        }
    }
}
