using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Mem_Word
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate { Application.Run(new Save()); }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Dispose(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(delegate { Application.Run(new Review()); }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Dispose(true);
        }
    }
}
