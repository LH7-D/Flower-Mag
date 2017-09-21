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
    public partial class EditSell : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private String mstrno = "";
        public EditSell()
        {
            InitializeComponent();
        }
        public EditSell(string strno)
        {
            InitializeComponent();
            mstrno = strno;
          
            //仓库的触发
            var model2 = db.Repertories.Select(m => m);
            this.cbCk.DataSource = model2.ToArray();
            this.cbCk.DisplayMember = "仓库名称";
            //客户的触发
            var model3 = db.Guests.Select(m => m);
            this.cbNum.DataSource = model3.ToArray();
            this.cbNum.DisplayMember = "客户编号";
            this.cbName.DataSource = model3.ToArray();
            this.cbName.DisplayMember = "客户名称";
        }
        private void EditSell_Load(object sender, EventArgs e)
        {
            var model = db.Sells.FirstOrDefault(m => m.订单编号 == mstrno);
            if (model == null)
            {
                return;
            }

            tb_no.Text = model.订单编号;
            tbName.Text = model.商品名称;
            tb_num.Text = model.销货数量.ToString();

            dateTimePicker1.Text = model.销货日期;
            cbCk.Text = model.所属仓库;
            cbNum.Text = model.客户编号;
            cbName.Text = model.客户名称;
            textBox6.Text = model.总金额.ToString();
            textBox2.Text = model.已付款金额.ToString();
            comboBox1.Text = model.付款方式;
            textBox4.Text = model.未付款金额.ToString();
        }

        private void panel1_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = "";
            string name = "";
            int num = 0;
            string time = "";
            string cangku = "";
            string khbh = "";
            string khname = "";
            decimal yi = 0;
            string style = "";
            decimal zo = 0;
            decimal wei = 0;



            no = tb_no.Text.Trim();
            name = tbName.Text.Trim();
            num = Convert.ToInt32(tb_num.Text.Trim());
            time = dateTimePicker1.Text.Trim();
            cangku = cbCk.Text.Trim();
            khbh = cbNum.Text.Trim();
            khname = cbName.Text.Trim();
            yi = Convert.ToDecimal(textBox2.Text.Trim());
            style = comboBox1.Text.Trim();
            zo = Convert.ToDecimal(textBox6.Text.Trim());
            wei = Convert.ToDecimal(textBox4.Text.Trim());

            var model = db.Sells.FirstOrDefault(m => m.订单编号 == no);
            model.订单编号 = no;
            model.商品名称 = name;
            model.销货数量 = num;
            model.销货日期 = time;
            model.客户编号 = khbh;
            model.客户名称 = khname;
            model.所属仓库 = cangku;
           
            model.已付款金额 = yi;
            model.总金额 = zo;
            model.付款方式 = style;
            model.未付款金额 = wei;

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
