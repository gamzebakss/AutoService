using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class FotolariGoster : Form
    {
        public FotolariGoster(Image img)
        {
            InitializeComponent();
            picFoto.Image = img;

        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
