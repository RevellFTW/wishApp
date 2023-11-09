using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wishApp.Controller;
using wishApp.DAO;
using wishApp.Model;

namespace wishApp
{
    public partial class Form1 : Form
    {
        private readonly WishController controller;
        public Form1()
        {
            controller = new WishController(new WishDAO());
            InitializeComponent();
        }

        private void újKívánságToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new NewWish(controller);
            form.ShowDialog();
        }

        private void listázásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wishesDataGridView.DataSource = null;
            wishesDataGridView.DataSource = controller.GetWishModels();
            wishesDataGridView.Visible = true;
            wishesDataGridView.ReadOnly = true; //nincs nyúlkapiszka
            wishesDataGridView.Columns["ID"].Visible = false;
        }
    }
}
