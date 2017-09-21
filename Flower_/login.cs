using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_
{
    public partial class login : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();

        // 函数 ***************************************************************
        // 初始化控件
        private void InitControls()
        {
            lbMessage.Text = "";
        }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Register()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strName = "";
            string strPawword = "";
            lbMessage.Text = "";
            // 校验
            if (username.Text.Trim() == "")
            {
                lbMessage.Text = "用户名不能为空!";
                //MessageBox.Show("学号不能为空!");
                username.Focus();
                return;
            }
            if (password.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空!");
                password.Focus();
                return;
            }

            // 获取数据
            strName = username.Text.Trim();
            strPawword = password.Text.Trim();

            DBCL.mange model = new DBCL.mange();
            try
            {
                if (db.manges.Any(m => m.user_name == strName) == false)
                {
                    MessageBox.Show("用户名不存在!");
                }
                else if (db.manges.Any(m => m.user_password == strPawword) == false)
                    MessageBox.Show("密码错误!");
                else
                {
                    MessageBox.Show("登陆成功！");
                    this.Hide();
                    Main frmMain = new Main();
                    frmMain.Show();
                }
            }
            catch
            {
                MessageBox.Show("登录失败!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
