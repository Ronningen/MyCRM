using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clients c = new Clients();
            IEnumerable<Clients> t = new List<Clients>() { c };
            CC f= new CC(t.First());
            f.DO();
            foreach (var p in typeof(Clients).GetProperties())
                Console.WriteLine(p.Name + ": " + p.GetValue(c)?.ToString());
        }
    }

    public class CC
    {
        Clients clients;
        public CC(Clients clients)
        {
            this.clients = clients;
        }
        public void DO()
        {
            clients.LastName = "dsadasd";
        }
    }
}
