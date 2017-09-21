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
    public partial class EditProduct : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private String mstrno = "";
        public EditProduct()
        {
            InitializeComponent();
        }
        public EditProduct(string strno)
        {
            InitializeComponent();
            mstrno = strno;

        }
        private void EditProduct_Load(object sender, EventArgs e)
        {
            var model = db.Products.FirstOrDefault(m => m.商品编号 == mstrno);
            if (model == null)
            {
                return;
            }
            tbFNum.Text = model.商品编号;
            tbFName.Text = model.商品名称;
            tbFAddress.Text = model.联系地址;
            tbFPrice.Text = model.商品单价.ToString();
            tbFLs.Text = model.零售价.ToString();
            tbFKc.Text = model.当前库存;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string strFNum = "";
            string strFName = "";
            string strFPrice = "";
            string strFLs = "";
            string strFAddress = "";
            string strFKc = "";

            strFNum = tbFNum.Text.Trim();
            strFName = tbFName.Text.Trim();
            strFPrice = tbFPrice.Text.Trim();
            strFLs = tbFLs.Text.Trim();
            strFAddress = tbFAddress.Text.Trim();
            strFKc = tbFKc.Text.Trim();

            var model = db.Products.FirstOrDefault(m => m.商品编号 == strFNum);
            model.商品编号 = strFNum;
            model.商品名称 = strFName;
            model.商品单价 = Convert.ToInt32(strFPrice);
            model.零售价 = Convert.ToInt32(strFLs);
            model.联系地址 = strFAddress;
            model.当前库存 = strFKc;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("修改失败!");
                return;
            }

            MessageBox.Show("商品信息修改成功!");
            this.Close();
        }
    }
}
