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
    public partial class EditOrder : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private String mstrno = "";

        public EditOrder()
        {
            InitializeComponent();
        }

        public EditOrder(String strno)
        {
            InitializeComponent();
            mstrno = strno;
            //商品的的触发
            var model1 = db.Products.Select(m => m);
            this.cb_name.DataSource = model1.ToArray();
            this.cb_name.DisplayMember = "商品名称";

            //仓库的触发
            var model2 = db.Repertories.Select(m => m);
            this.cb_cangku.DataSource = model2.ToArray();
            this.cb_cangku.DisplayMember = "仓库名称";
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = "";
            string name = "";
            int num = 0;
            string time = "";
            string cangku = "";
            string shangjia = "";
            decimal danjia = 0;
            decimal lv = 0;
            decimal ze = 0;
            decimal yi = 0;
            String style = "";
            decimal zo = 0;
            decimal wei = 0;



            no = tb_no.Text.Trim();
            name = cb_name.Text.Trim();
            num = Convert.ToInt32(tb_num.Text.Trim());
            time = dateTimePicker1.Text.Trim();
            cangku = cb_cangku.Text.Trim();
            shangjia = cb_sj.Text.Trim();
            danjia = Convert.ToDecimal(tb_danjia.Text.Trim());
            lv = Convert.ToDecimal(tb_lv.Text.Trim());
            ze = Convert.ToDecimal(textBox1.Text.Trim());
            yi = Convert.ToDecimal(textBox2.Text.Trim());
            style = comboBox1.Text.Trim();
            zo = Convert.ToDecimal(textBox6.Text.Trim());
            wei = Convert.ToDecimal(textBox4.Text.Trim());

            var model = db.Order1.FirstOrDefault(m => m.订单编号 == no);
            model.订单编号 = no;
            model.商品名称 = name;
            model.购货数量 = num;
            model.购货日期 = time;
            model.所属仓库 = cangku;
            model.供应商 = shangjia;
            model.零售价 = danjia;
            model.折扣率 = lv;
            model.折扣额 = ze;
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

        private void tb_num_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_danjia_TextChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(textBox2.Text, out d);   //已付款
            textBox6.Text = (a * b).ToString();      //总金额
            textBox1.Text = (a * b * c).ToString();  //折扣额
            textBox4.Text = (a * b - a * b * c - d).ToString();  //未付款
        }

        private void tb_lv_TextChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(textBox2.Text, out d);   //已付款
            textBox1.Text = (a * b * c).ToString();  //折扣额
            textBox4.Text = (a * b - a * b * c - d).ToString();  //未付款
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(textBox2.Text, out d);   //已付款
            textBox4.Text = (a * b - a * b * c - d).ToString();  //未付款
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            var model = db.Order1.FirstOrDefault(m => m.订单编号 == mstrno);
            if (model == null)
            {
                return;
            }

            tb_no.Text = model.订单编号;
            cb_name.Text = model.商品名称;
            tb_num.Text = model.购货数量.ToString();
           
            dateTimePicker1.Text = model.购货日期;
            cb_cangku.Text = model.所属仓库;
            cb_sj.Text = model.供应商;
            tb_danjia.Text = model.零售价.ToString();
            tb_lv.Text = model.折扣率.ToString();
            textBox1.Text = model.折扣率.ToString();
            textBox6.Text = model.总金额.ToString();
            textBox2.Text = model.已付款金额.ToString();
            comboBox1.Text = model.付款方式;
            textBox4.Text = model.未付款金额.ToString();
        }

        private void tb_danjia_TextChanged_1(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(textBox2.Text, out d);   //已付款
            textBox1.Text = (a * b * c).ToString();  //折扣额
            textBox4.Text = (a * b - a * b * c - d).ToString();  //未付款
        }

        private void tb_num_TextChanged_1(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(textBox2.Text, out d);   //已付款
            textBox6.Text = (a * b).ToString();      //总金额
            textBox1.Text = (a * b * c).ToString();  //折扣额
            textBox4.Text = (a * b - a * b * c - d).ToString();  //未付款
        }
    }
}
