using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РГР_УД
{
    public partial class ChooseOperation : Form
    {
        public ChooseOperation()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOperation SO = new SelectOperation();
            SO.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertOperation IO = new InsertOperation();
            IO.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteOperation DO = new DeleteOperation();
            DO.Show();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateOperation UO = new UpdateOperation();
            UO.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }
    }
}
