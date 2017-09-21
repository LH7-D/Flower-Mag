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
    public partial class Register : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注册成功！", "注册成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
         //   this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            string strName = "";
            string strPawword = "";
            string strPhone = "";
            string strType = "";
            string strEmail = "";

            lbMessage1.Text = "";
            lbMessage2.Text = "";
            lbMessage3.Text = "";
            lbMessage4.Text = "";
            lbMessage5.Text = "";
            lbMessage6.Text = "";
            // 校验
            if (texUsername.Text.Trim() == "")
            {
                lbMessage1.Text = "用户名不能为空!";
                texUsername.Focus();
                return;
            }
            if (texPassword.Text.Trim() == "")
            {

                lbMessage2.Text = "密码不能为空!";
                texPassword.Focus();
                return;
            }
            if (texPhone.Text.Trim() == "")
            {

                lbMessage4.Text = "手机号不能为空!";
                texPhone.Focus();
                return;
            }
            if (tbEmail.Text.Trim() == "")
            {

                lbMessage5.Text = "邮箱不能为空!";
                tbEmail.Focus();
                return;
            }
            if (texType.Text.Trim() == "")
            {
                lbMessage6.Text = "用户类型不能为空!";
                texType.Focus();
                return;
            }
            if (texPassword.Text.Trim() != texPassword1.Text.Trim())
            {
                lbMessage3.Text = "两次密码不同！";
                texPhone.Focus();
                return;
            }

            // 获取数据
            strName = texUsername.Text.Trim();
            strPawword = texPassword.Text.Trim();
            strPhone = texPhone.Text.Trim();
            strType = texType.Text.Trim();
            strEmail = tbEmail.Text.Trim();

            // 检验学号是否重复
            if (db.manges.Any(m => m.user_name == strName) == true)
            {
                MessageBox.Show("用户名重复!");
                texUsername.Focus();
                return;
            }


            DBCL.mange mode1 = new DBCL.mange();
            mode1.user_name = strName;
            mode1.user_password = strPawword;
            mode1.user_phone = strPhone;
            mode1.user_type = strType;
            mode1.user_email = strEmail;


            try
            {
                db.manges.Add(mode1);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("注册失败!");
                return;
            }

            MessageBox.Show("注册成功，欢迎使用!");
            this.Close();
            login frmMain = new login();
            frmMain.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
