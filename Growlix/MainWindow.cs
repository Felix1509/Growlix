using Entities;
using NHibernate;

namespace Growlix
{
    public partial class MainWindow : Form
    {
        // To Open a usable Session use sf.OpenSession(). Dont forget to close ;)
        private ISessionFactory sf { get; set; }
        private List<Spending> Ausgaben { get; set; }
        public MainWindow(ISessionFactory _sf)
        {
            InitializeComponent();
            sf = _sf;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinNewSpending wns = new WinNewSpending(sf);
            wns.ShowDialog();
            textBox1.Text = "DU HURENSOHN";
        }
    }
}
