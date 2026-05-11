using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class Form3 : Form
    {
        public Form3(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(MdiParent);
            form2.Show();
            Close();
        }
    }
}
