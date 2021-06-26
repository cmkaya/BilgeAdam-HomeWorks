using System;
using System.Windows.Forms;

namespace InterfacesDemo3
{
    public partial class MainPageForm : Form
    {
        // To prevent open more than one same menu item, objects are created here, not inside their methods.
        CircleForm circleForm = new CircleForm();
        TetragonForm tetragonForm = new TetragonForm();
        TrianglesForm trianglesForm = new TrianglesForm();
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void trianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trianglesForm.Show();
        }

        private void tetragonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tetragonForm.Show();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleForm.Show();
        }
    }
}
