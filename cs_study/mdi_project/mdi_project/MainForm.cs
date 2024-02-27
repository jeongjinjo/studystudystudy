using mdi_project.todo;
using mdi_project.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //mdi컨테이너로 만드는거???? 
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userform1=UserForm.getInstance();
            userform1.MdiParent = this;
            userform1.Show();
        }

        private void 할일관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodoForm todoForm = new TodoForm();
            todoForm.MdiParent = this;
            todoForm.Show();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
