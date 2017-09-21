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
    public partial class EditFactory : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private String mstrno = "";
        public EditFactory()
        {
            InitializeComponent();
        }
        public EditFactory(string strno)
        {
            InitializeComponent();
            mstrno = strno;
          
         }
        private void EditFactory_Load(object sender, EventArgs e)
        {
            var model = db.Factories.FirstOrDefault(m => m.供应商编号 == mstrno);
            if (model == null)
            {
                return;
            }
            tbFNumber.Text = model.供应商编号;
            tbFName.Text = model.供应商名称;
            tbFContect.Text = model.联系人;
            tbFPhone.Text = model.联系电话;
            tbFAddress.Text = model.供应商地址;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strNum = "";
            string strName = "";
            string strContent = "";
            string strPhone = "";
            string strAdress = "";

            strNum = tbFNumber.Text.Trim();
            strName = tbFName.Text.Trim();
            strContent = tbFContect.Text.Trim();
            strPhone = tbFPhone.Text.Trim();
            strAdress = tbFAddress.Text.Trim();

            var model = db.Factories.FirstOrDefault(m => m.供应商编号 == strNum);
            model.供应商编号 = strNum;
            model.供应商名称 = strName;
            model.联系人 = strContent;
            model.联系电话 = strPhone;
            model.供应商地址 = strAdress;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("供应商信息修改失败!");
                return;
            }

            MessageBox.Show("供应商信息修改成功!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
