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
    public partial class EditGuest : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private String mstrno = "";
        public EditGuest()
        {
            InitializeComponent();
        }
        public EditGuest(string strno)
        {
            InitializeComponent();
            mstrno = strno;
          
         }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditGuest_Load(object sender, EventArgs e)
        {
            var model = db.Guests.FirstOrDefault(m => m.客户编号 == mstrno);
            if (model == null)
            {
                return;
            }
            tbGNum.Text = model.客户编号;
            tbGName.Text = model.客户名称;
            tbContent.Text = model.联系人;
            tbPhone.Text = model.联系电话;
            tbEmail.Text = model.邮箱;
            tbAdress.Text = model.联系地址;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strNum = "";
            string strName = "";
            string strContent = "";
            string strPhone = "";
            string strEmail = "";
            string strAdress = "";

            strNum = tbGNum.Text.Trim();
            strName = tbGName.Text.Trim();
            strContent = tbContent.Text.Trim();
            strPhone = tbPhone.Text.Trim();
            strEmail = tbEmail.Text.Trim();
            strAdress = tbAdress.Text.Trim();

            var model = db.Guests.FirstOrDefault(m => m.客户编号 == strNum);
            model.客户编号 = strNum;
            model.客户名称 = strName;
            model.联系人 = strContent;
            model.联系电话 = strPhone;
            model.邮箱 = strEmail;
            model.联系地址 = strAdress;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("修改失败!");
                return;
            }

            MessageBox.Show("修改成功!");
            this.Close();
        }
    }
}
