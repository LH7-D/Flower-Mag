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
    public partial class Main : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDropDown1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void 购货订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.购货订单.Parent = tabControl1;

            tabControl1.Visible = true;
            //触发
            string time = "";
            time = dateTimePicker1.Text.Trim();
            var model = db.Order1.Select(m => m);
           if (time != "")
            {
                model = model.Where(m => m.购货日期.IndexOf(time) >= 0);
            }
            this.dataGridView1.DataSource = model.ToList();


            //商品的的触发
            var model1 = db.Products.Select(m => m);
            this.cb_name.DataSource = model1.ToArray();
            this.cb_name.DisplayMember = "商品名称";

            //仓库的触发
            var model2 = db.Repertories.Select(m => m);
            this.cb_cangku.DataSource = model2.ToArray();
            this.cb_cangku.DisplayMember = "仓库名称";

            //供应商触发
            var model3 = db.Factories.Select(m => m);
            this.cb_sj.DataSource = model3.ToArray();
            this.cb_sj.DisplayMember = "供应商名称";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void 购货销货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.购货退货单.Parent = tabControl1;

            //购货单的的触发
            var model = db.Order1.Select(m => m);
            this.comboBox9.DataSource = model.ToArray();
            this.comboBox9.DisplayMember = "订单编号";

            var model1 = db.Products.Select(m => m);
            this.comboBox8.DataSource = model1.ToArray();
            this.comboBox8.DisplayMember = "商品名称";
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出系统！","退出成功！",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 销货订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.销货订单.Parent = tabControl1;


            //触发
            string time = "";
            time = time1.Text.Trim();
            var model = db.Sells.Select(m => m);
            if (time != "")
            {
                model = model.Where(m => m.销货日期.IndexOf(time) >= 0);
            }
            this.dataGridView5.DataSource = model.ToList();


            //商品的的触发
            var model1 = db.Products.Select(m => m);
            this.tbName.DataSource = model1.ToArray();
            this.tbName.DisplayMember = "商品名称";

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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void 销货退货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.销货退货单.Parent = tabControl1;

            //销货退货单的触发
            var model = db.Sells.Select(m => m);
            this.comboBox11.DataSource = model.ToArray();
            this.comboBox11.DisplayMember = "订单编号";

            var model1 = db.Products.Select(m => m);
            this.comboBox10.DataSource = model1.ToArray();
            this.comboBox10.DisplayMember = "商品名称";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void 盘点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.盘点.Parent = tabControl1;

            //商品的的触发
            var mod = db.Products.Select(m => m);
            this.cbPName.DataSource = mod.ToArray();
            this.cbPName.DisplayMember = "商品名称";
             //仓库的的触发
            var mod1 = db.Repertories.Select(m => m);
            this.cbPck.DataSource = mod1.ToArray();
            this.cbPck.DisplayMember = "仓库名称";
          
        }

        private void 收入单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.收入单.Parent = tabControl1;

            
            var model = db.salaries .Select(m => m);
            
            this.dataGridView6.DataSource = model.ToList();
        }

        private void 支出单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.支出单.Parent = tabControl1;

            var model = db.pays.Select(m => m);

            this.dataGridView12.DataSource = model.ToList();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridViewX10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 应付账款明细表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.应付账款单.Parent = tabControl1;
        }

        private void 仓库情况报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.仓库情况报表.Parent = tabControl1;
        }

        private void 应收账款明细表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.应收账款单.Parent = tabControl1;
        }

        private void dataGridViewX14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应收账款单.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.客户管理.Parent = tabControl1;
            
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.供应商管理.Parent = tabControl1;
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.仓库管理.Parent = null;
            this.商品管理.Parent = tabControl1;
        }

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.tabPage1.Parent = null;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.应付账款单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = tabControl1;
        }

        private void button27_Click(object sender, EventArgs e)
        {
        }

        private void button35_Click(object sender, EventArgs e)
        {
            (new Add_store()).Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            (new Add_product()).Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            String Factory_Number = textBox26.Text.Trim();
            var model = db.Factories.Select(m => m);

            if (Factory_Number != "") {
                model = model.Where(m => m.供应商编号.IndexOf(Factory_Number) >= 0);
            }
            this.dataGridView9.DataSource = model.ToList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click_1(object sender, EventArgs e)
        {
        }

        private void button37_Click(object sender, EventArgs e)
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
            time = dt_time.Text.Trim();
            cangku = cb_cangku.Text.Trim();
            shangjia = cb_sj.Text.Trim();
            danjia = Convert.ToDecimal(tb_danjia.Text.Trim());
            lv = Convert.ToDecimal(tb_lv.Text.Trim());
            ze = Convert.ToDecimal(tb_zk.Text.Trim());
            yi = Convert.ToDecimal(tb_yf.Text.Trim());
            style = comboBox4.Text.Trim();
            zo = Convert.ToDecimal(tb_zj.Text.Trim());
            wei = Convert.ToDecimal(tb_wf.Text.Trim());

            DBCL.Order1 model1 = new DBCL.Order1();
            model1.订单编号 = no;
            model1.商品名称 = name;
            model1.购货数量 = num;
            model1.购货日期 = time;
            model1.所属仓库 = cangku;
            model1.供应商 = shangjia;
            model1.零售价 = danjia;
            model1.折扣率 = lv;
            model1.折扣额 = ze;
            model1.已付款金额 = yi;
            model1.总金额 = zo;
            model1.付款方式 = style;
            model1.未付款金额 = wei;
            /***********按仓库名称查询仓库编号***************/
            var model2 = db.Repertories .FirstOrDefault(m=>m.仓库名称==cangku);
            string id = "";
            id = model2.仓库编号;
            /**************按商品名称查找商品编号*******************/
            var model4 = db.Products.FirstOrDefault(m => m.商品名称 == name);
            string id1 = "";
            id1 = model4.商品编号;
            /************Store仓库插入信息*********************/
            DBCL.Store model3 = new DBCL.Store();
            model3.入库单号 = no;
            model3.仓库编号 = id;
            model3.仓库名称 = cangku;
            model3.商品编号 = id1;
            model3.商品名称 = name;
            model3.库存量 =num;

            DBCL.pay model5 = new DBCL.pay();
            model5.结算号 = no;
            model5.结算账户 = shangjia;
            model5.付款金额 = yi;
            model5.结算方式 = style;

            try
            {
                db.Order1.Add(model1);
                db.SaveChanges();
                db.Stores.Add(model3);
                db.SaveChanges();
                db.pays.Add(model5);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("信息填写错误!");
                return;
            }

            MessageBox.Show("购货单成功添加!");
            //清空
            tb_no.Text = "";
            cb_name.Text = "";
            tb_num.Text = "";
            cb_cangku.Text = "";
            dt_time.Text = "";
            cb_sj.Text = "";
            tb_danjia.Text = "";
            tb_lv.Text = "";
            tb_yf.Text = "";
            comboBox4.Text = "";
            tb_zj.Text = "";
            tb_zk.Text = "";
            tb_wf.Text = "";


            //触发
            string time1 = "";
            time1 = dateTimePicker1.Text.Trim();
            var model = db.Order1.Select(m => m);
            if (time1 != "")
            {
                model = model.Where(m => m.购货日期.IndexOf(time1) >= 0);
            }
            this.dataGridView1.DataSource = model.ToList();


        }

        private void tb_num_TextChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(tb_yf.Text, out d);
            tb_zj.Text = (a * b).ToString();
            tb_zk.Text = (a * b * c).ToString();
            tb_wf.Text = (a * b - a * b * c - d).ToString();

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
            decimal.TryParse(tb_yf.Text, out d);
            tb_zj.Text = (a * b).ToString();
            tb_zk.Text = (a * b * c).ToString();
            tb_wf.Text = (a * b - a * b * c - d).ToString();
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
            tb_zk.Text = (a * b * c).ToString();
            decimal.TryParse(tb_yf.Text, out d);
            tb_wf.Text = (a * b - a * b * c - d).ToString();
        }

        private void tb_yf_TextChanged(object sender, EventArgs e)
        {
            int a;
            decimal b;
            decimal c;
            decimal d;
            int.TryParse(tb_num.Text, out a);
            decimal.TryParse(tb_danjia.Text, out b);
            decimal.TryParse(tb_lv.Text, out c);
            decimal.TryParse(tb_yf.Text, out d);
            tb_wf.Text = (a * b - a * b * c - d).ToString();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int count = 0;
            string strno = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        var model = db.Order1.FirstOrDefault(m => m.订单编号 == strno);
                        count++;
                    }
                }
            }

            if (count > 1)
            {
                MessageBox.Show("只能修改一个！");
            }

            else
            {
                EditOrder edit = new EditOrder(strno);
                edit.Show(this);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string strno = "";
            string strname = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        strname = dataGridView1.Rows[i].Cells[2].Value.ToString();

                        var model = db.Order1.FirstOrDefault(m => m.订单编号 == strno && m.商品名称 == strname);
                        if (model == null)
                        {
                            continue;
                        }

                        db.Order1.Remove(model);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("删除成功！");
            string time = "";
            time = dateTimePicker1.Text.Trim();
            var model1 = db.Order1.Select(m => m);
            if (time != "")
            {
                model1 = model1.Where(m => m.购货日期.IndexOf(time) >= 0);
            }
            this.dataGridView1.DataSource = model1.ToList();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchHistory sh = new SearchHistory();
            sh.Show();
        }

        private void cb_cangku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string strNum = "";
            string strName = "";
            int num = 0;
            string strTime = "";
            string strCk = "";
            string strcbNum = "";
            string strcbName ="";
            string strcbType = "";
            decimal strtbPrice = 0;
            decimal dectbYfk = 0;
            decimal dectbWfk = 0;

            strNum = tbNumber.Text.Trim();
            strName = tbName.Text.Trim();
            num = Convert.ToInt32(Number.Text.Trim());
            strTime = tbDate.Text.Trim();
            strCk = cbCk.Text.Trim();
            strcbNum = cbNum.Text.Trim();
            strcbName = cbName.Text.Trim();
            strcbType = cbType.Text.Trim();
            strtbPrice = Convert.ToDecimal(tbPrice.Text.Trim());
            dectbYfk = Convert.ToDecimal(tbYfk.Text.Trim());
            dectbWfk = Convert.ToDecimal(tbWfk.Text.Trim());
           
           
            DBCL.Sell model7 = new DBCL.Sell();
            model7.订单编号 = strNum;
            model7.商品名称 = strName;
            model7.销货数量 = num;
            model7.销货日期 = strTime;
            model7.客户编号 = strcbNum;
            model7.客户名称 = strcbName;
            model7.所属仓库 = strCk;
            model7.付款方式 = strcbType;
            model7.已付款金额 = dectbYfk;
            model7.总金额 = strtbPrice;
            model7.未付款金额 = dectbWfk;

            DBCL.salary model111 = new DBCL.salary();
            model111.结算号 = strNum;
            model111.结算账户 = strcbName;
            model111.收款金额 = dectbYfk;
            model111.结算方式 = strcbType;

            try
            {
                db.Sells.Add(model7); 
                db.SaveChanges();
                db.salaries.Add(model111);
                db.SaveChanges(); 
            }
            catch
            {
                MessageBox.Show("信息填写错误!");
                return;
            }

            MessageBox.Show("添加成功!");

            //修改仓库货物信息表
            var model1 = db.Stores.FirstOrDefault(m => m.商品名称 == strName);
            decimal d = model1.库存量;
            model1.库存量 = d - num;
            try
            {
                db.SaveChanges();
            }
            catch
            {
                return;
            }

            //清空
            tb_no.Text = "";
            cb_name.Text = "";
            tb_num.Text = "";
            cb_cangku.Text = "";
            dt_time.Text = "";
            cb_sj.Text = "";
            tb_danjia.Text = "";
            tb_lv.Text = "";
            tb_yf.Text = "";
            comboBox4.Text = "";
            tb_zj.Text = "";
            tb_zk.Text = "";
            tb_wf.Text = "";


            //触发
            string time = "";
            time = time1.Text.Trim();
            var model8= db.Sells.Select(m => m);
            if (time != "")
            {
                model8 = model8.Where(m => m.销货日期.IndexOf(time) >= 0);
            }
            this.dataGridView5.DataSource = model8.ToList();
        }

        private void tb_wf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYfk_TextChanged(object sender, EventArgs e)
        {
           /* decimal a;
            decimal b;
            decimal c;
            decimal.TryParse(tbYfk.Text, out a);
            decimal.TryParse(tbPrice.Text,out b);
            c=b - a;
            tbWfk.Text = c.ToString();*/
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
          /*  decimal a;
            decimal b;
            decimal c;
            decimal.TryParse(tbYfk.Text, out a);
            decimal.TryParse(tbPrice.Text, out b);
            c = b - a;
            tbWfk.Text = c.ToString();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            string strno = "";
            string strname = "";
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                if (dataGridView5.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView5.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView5.Rows[i].Cells[1].Value.ToString();
                        strname = dataGridView5.Rows[i].Cells[2].Value.ToString();
                        var model = db.Sells.FirstOrDefault(m => m.订单编号 == strno && m.商品名称 == strname);
                        count++;
                    }
                }
            }

            if (count > 1)
            {
                MessageBox.Show("只能修改一个！");
            }

            else
            {
                EditSell edit = new EditSell(strno);
                edit.Show(this);
              
                var model1 = db.Sells.Select(m => m);
                if (strno != "")
                {
                    model1 = model1.Where(m => m.订单编号.IndexOf(strno) >= 0);
                }
                this.dataGridView5.DataSource = model1.ToList();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string strno = "";
            string strname = "";
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                if (dataGridView5.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView5.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView5.Rows[i].Cells[1].Value.ToString();
                        strname = dataGridView5.Rows[i].Cells[2].Value.ToString();

                        var model = db.Sells.FirstOrDefault(m => m.订单编号 == strno && m.商品名称 == strname);
                        if (model == null)
                        {
                            continue;
                        }

                        db.Sells.Remove(model);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("删除成功！");
            string time = "";
            time = time1.Text.Trim();
            var model1 = db.Sells.Select(m => m);
            if (time != "")
            {
                model1 = model1.Where(m => m.销货日期.IndexOf(time) >= 0);
            }
            this.dataGridView5.DataSource = model1.ToList();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string strno = "";
            string strname = "";
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                if (dataGridView5.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView5.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView5.Rows[i].Cells[1].Value.ToString();
                        strname = dataGridView5.Rows[i].Cells[2].Value.ToString();
                        var model = db.Sells.FirstOrDefault(m => m.订单编号 == strno && m.商品名称 == strname);
                    }
                }
            }
            var model1 = db.Sells.Select(m => m);
            if (strno != "")
            {
                model1 = model1.Where(m => m.订单编号.IndexOf(strno) >= 0);
            }
            this.dataGridView5.DataSource = model1.ToList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchSell sh = new SearchSell();
            sh.Show();
        }

        private void 销货退货单_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
          
        }

        private void button42_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tabControl1.Visible = true;
            this.购货订单.Parent = null;
            this.购货退货单.Parent = null;
            this.销货订单.Parent = null;
            this.销货退货单.Parent = null;
            this.盘点.Parent = null;
            this.收入单.Parent = null;
            this.支出单.Parent = null;
            this.仓库情况报表.Parent = null;
            this.应付账款单.Parent = null;
            this.应收账款单.Parent = null;
            this.客户管理.Parent = null;
            this.供应商管理.Parent = null;
            this.商品管理.Parent = null;
            this.仓库管理.Parent = null;
            this.tabPage1.Parent = tabControl1;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string strNum = "";
            var model8 = db.Guests.Select(m => m);

            strNum = tbGNum.Text.Trim();

            if (strNum != "")
            {
                model8 = model8.Where(m => m.客户编号.IndexOf(strNum) >= 0);
            }
            this.dataGridView8.DataSource = model8.ToList();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string strno = "";
            for (int i = 0; i < dataGridView8.Rows.Count; i++)
            {
                if (dataGridView8.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView8.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView8.Rows[i].Cells[1].Value.ToString();
                        var model9 = db.Guests.FirstOrDefault(m => m.客户编号 == strno );
                        if (model9 == null)
                        {
                            continue;
                        }

                        db.Guests.Remove(model9);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("删除成功！");
            var model10 = db.Guests.Select(m => m);
            this.dataGridView8.DataSource = model10.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            string strno = "";
            for (int i = 0; i < dataGridView8.Rows.Count; i++)
            {
                if (dataGridView8.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView8.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView8.Rows[i].Cells[1].Value.ToString();
                        var model11 = db.Guests.FirstOrDefault(m => m.客户编号 == strno);
                        count++;
                    }
                }
            }

            if (count > 1)
            {
                MessageBox.Show("只能修改一个！");
            }

            else
            {
                EditGuest edit = new EditGuest(strno);
                edit.Show(this);
            }
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string strno = "";
            for (int i = 0; i < dataGridView9.Rows.Count; i++)
            {
                if (dataGridView9.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView9.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView9.Rows[i].Cells[1].Value.ToString();
                        var model9 = db.Factories.FirstOrDefault(m => m.供应商编号 == strno);
                        if (model9 == null)
                        {
                            continue;
                        }

                        db.Factories.Remove(model9);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("删除成功！");
            var model10 = db.Factories.Select(m => m);
            this.dataGridView9.DataSource = model10.ToList();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            int count = 0;
            string strno = "";
            for (int i = 0; i < dataGridView9.Rows.Count; i++)
            {
                if (dataGridView9.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView9.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView9.Rows[i].Cells[1].Value.ToString();
                        var model11 = db.Factories.FirstOrDefault(m => m.供应商编号 == strno);
                        count++;
                    }
                }
            }

            if (count > 1)
            {
                MessageBox.Show("只能修改一个！");
            }

            else
            {
                EditFactory edit = new EditFactory(strno);
                edit.Show(this);
            }
        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            String Product_Number = textBox27.Text.Trim();
            var model = db.Products.Select(m => m);

            if (Product_Number != "")
            {
                model = model.Where(m => m.商品编号.IndexOf(Product_Number) >= 0);
            }
            this.dataGridView10.DataSource = model.ToList();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            string strno = "";
            for (int i = 0; i < dataGridView10.Rows.Count; i++)
            {
                if (dataGridView10.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView10.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView10.Rows[i].Cells[1].Value.ToString();
                        var model11 = db.Products.FirstOrDefault(m => m.商品编号 == strno);
                        count++;
                    }
                }
            }
            if (count > 1)
            {
                MessageBox.Show("只能修改一个！");
            }

            else
            {
                EditProduct edit = new EditProduct(strno);
                edit.Show(this);
            }

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            string strno = "";
            for (int i = 0; i < dataGridView10.Rows.Count; i++)
            {
                if (dataGridView10.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView10.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView10.Rows[i].Cells[1].Value.ToString();
                        var model10 = db.Products.FirstOrDefault(m => m.商品编号 == strno);
                        if (model10 == null)
                        {
                            continue;
                        }

                        db.Products.Remove(model10);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("该商品已删除成功！");
            var model11 = db.Products.Select(m => m);
            this.dataGridView10.DataSource = model11.ToList();
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
            

            DBCL.Product model13 = new DBCL.Product();
            model13.商品编号 = strFNum;
            model13.商品名称 = strFName;
            model13.商品单价 = Convert.ToInt32(strFPrice);
            model13.零售价 = Convert.ToInt32(strFLs);
            model13.联系地址 = strFAddress;
            model13.当前库存 = strFKc;


            try
            {
                db.Products.Add(model13);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("信息填写错误!");
                return;
            }

            MessageBox.Show("商品成功添加!");
            //清空
            tbFNum.Text="";
            tbFName.Text="";
            tbFPrice.Text = "";
            tbFLs.Text = "";
            tbFAddress.Text = "";
            tbFKc.Text = "";

            var model = db.Products.Select(m => m);
            model = model.Where(m => m.商品编号.IndexOf(strFNum) >= 0);
            this.dataGridView10.DataSource = model.ToList();
        }
        /******************仓库管理************/
        private void button35_Click_1(object sender, EventArgs e)
        {
            String str = textBox2.Text.Trim();
            var model = db.Repertories.Select(m => m);

            if (str != "")
            {
                model = model.Where(m => m.仓库编号.IndexOf(str) >= 0);
            }
            this.dataGridView11.DataSource = model.ToList();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            string strno = "";
            for (int i = 0; i < dataGridView11.Rows.Count; i++)
            {
                if (dataGridView11.Rows[i].Cells[0].Value != null) //判断该行的复选框是否存在  
                {
                    if (dataGridView11.Rows[i].Cells[0].Value.ToString() == "True") //判断该复选框是否被选中  
                    {
                        strno = dataGridView11.Rows[i].Cells[1].Value.ToString();
                        var model1 = db.Repertories.FirstOrDefault(m => m.仓库编号 == strno);
                        if (model1 == null)
                        {
                            continue;
                        }

                        db.Repertories.Remove(model1);
                    }
                }
            }
            db.SaveChanges();
            MessageBox.Show("该仓库信息已删除成功！");
            var model0 = db.Repertories.Select(m => m);
            this.dataGridView11.DataSource = model0.ToList();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string strRNum = "";
            string strRName = "";

            strRNum = tbRNum.Text.Trim();
            strRName = tbRName.Text.Trim();
          
            DBCL.Repertory mo = new DBCL.Repertory();
            mo.仓库编号 = strRNum;
            mo.仓库名称 = strRName;


            try
            {
                db.Repertories.Add(mo);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("信息填写错误!");
                return;
            }

            MessageBox.Show("新仓库已成功添加!");
            //清空
            tbRNum.Text = "";
            tbRName.Text = "";

            var l = db.Repertories.Select(m => m);
            l = l.Where(m => m.仓库编号.IndexOf(strRNum) >= 0);
            this.dataGridView11.DataSource = l.ToList();
        }
        /***********************关闭条件***************************/
        
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“flower_DataSet3.pay”中。您可以根据需要移动或删除它。
            this.payTableAdapter.Fill(this.flower_DataSet3.pay);
            // TODO:  这行代码将数据加载到表“flower_DataSet2.salary”中。您可以根据需要移动或删除它。
            this.salaryTableAdapter.Fill(this.flower_DataSet2.salary);
            //绘制的方式OwnerDrawFixed表示由窗体绘制大小也一样
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Padding = new System.Drawing.Point(CLOSE_SIZE, CLOSE_SIZE);
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
        }
        const int CLOSE_SIZE = 15;
        //绘制“Ｘ”号即关闭按钮
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle myTabRect = this.tabControl1.GetTabRect(e.Index);

                //先添加TabPage属性   
                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, myTabRect.X, myTabRect.Y);

                //再画一个矩形框
                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE), 0);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //填充矩形框
                Color recColor = e.State == DrawItemState.Selected ? Color.White : Color.Red;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(Color.Black))
                {
                    ////=============================================
                    //自己画X
                    ////"\"线
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);
                    //"/"线
                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);

                }
                e.Graphics.Dispose();
            }
            catch (Exception)
            { }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = e.X, y = e.Y;
                    //计算关闭区域   
                    Rectangle myTabRect = this.tabControl1.GetTabRect(this.tabControl1.SelectedIndex);

                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE), 0);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;

                    //如果鼠标在区域内就关闭选项卡   
                    bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                    if (isClose == true)
                    {
                        this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                    }
                }
            }
            catch { }
        }
        // 结束画“X”号 **********************************************************************************   
        private void button47_Click(object sender, EventArgs e)
        {
            string strNum = "";
            string strName = "";
            string strContent = "";
            string strPhone = "";
            string strEmail = "";
            string strAdress = "";

            strNum = textBox17.Text.Trim();
            strName = tbGName.Text.Trim();
            strContent = tbContent.Text.Trim();
            strPhone = tbPhone.Text.Trim();
            strEmail = tbEmail.Text.Trim();
            strAdress = tbAdress.Text.Trim();

            DBCL.Guest model3 = new DBCL.Guest();
            model3.客户编号 = strNum;
            model3.客户名称 = strName;
            model3.联系电话 = strPhone;
            model3.联系人 = strContent;
            model3.联系地址 = strAdress;
            model3.邮箱 = strEmail;


            try
            {
                db.Guests.Add(model3);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("信息填写错误!");
                return;
            }

            MessageBox.Show("新客户添加成功!");
            //清空
            

             var model = db.Guests.Select(m => m);
             model = model.Where(m => m.客户编号.IndexOf(strNum) >= 0);
            this.dataGridView8.DataSource = model.ToList();
            textBox17.Text = "";
            tbGName.Text = "";
            tbContent.Text = "";
            tbAdress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }
        /******************供应商修改********************/
        private void button8_Click_1(object sender, EventArgs e)
        {
            string strFNumber = "";
            string strFName = "";
            string strFContect = "";
            string strFPhone = "";
            string strFAddress = "";
            lbMessage1.Text = "";
            lbMessage2.Text = "";
            lbMessage3.Text = "";
            lbMessage4.Text = "";
            lbMessage6.Text = "";
            // 校验
            if (tbFNumber.Text.Trim() == "")
            {
                lbMessage1.Text = "请输入供应商编号!";
                tbFNumber.Focus();
                return;
            }
            if (textBox31.Text.Trim() == "")
            {

                lbMessage2.Text = "请填写供应商名！";
                tbFName.Focus();
                return;
            }
            if (tbFContect.Text.Trim() == "")
            {

                lbMessage3.Text = "请填写联系人!";
                tbFContect.Focus();
                return;
            }
            if (tbFPhone.Text.Trim() == "")
            {

                lbMessage4.Text = "请输入联系电话!";
                tbFPhone.Focus();
                return;
            }

            if (textBox32.Text.Trim() == "")
            {
                lbMessage6.Text = "请输入联系地址！";
                textBox32.Focus();
                return;
            }

            // 获取数据
            strFNumber = tbFNumber.Text.Trim();
            strFName = textBox31.Text.Trim();
            strFContect = tbFContect.Text.Trim();
            strFPhone = tbFPhone.Text.Trim();
            strFAddress = textBox32.Text.Trim();

            // 检验学号是否重复
            if (db.Factories.Any(m => m.供应商编号 == strFNumber) == true)
            {
                MessageBox.Show("供应商已存在!");
                tbFNumber.Focus();
                return;
            }


            DBCL.Factory ft = new DBCL.Factory();
            ft.供应商编号 = strFNumber;
            ft.供应商名称 = strFName;
            ft.联系人 = strFContect;
            ft.联系电话 = strFPhone;
            ft.供应商地址 = strFAddress;

            try
            {
                db.Factories.Add(ft);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }

            MessageBox.Show("供应商已添加成功!");
            var l = db.Factories.Select(m => m);
            l = l.Where(m => m.供应商编号.IndexOf(strFNumber) >= 0);
            this.dataGridView9.DataSource = l.ToList();
            tbFNumber.Text = "";
            textBox31.Text = "";
            tbFContect.Text = "";
            tbFPhone.Text = "";
            textBox32.Text = "";
        }

        private void cbNum_TextChanged(object sender, EventArgs e)
        {
            string strNum = "";
            strNum = cbNum.Text.Trim();
            var model4 = db.Guests.FirstOrDefault(m => m.客户编号 == strNum);
            if (model4 == null)
            {
                return;
            }
            cbName.Text = model4.客户名称;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string strNum = "";
            string strTime = "";
            var model = db.Order1.Select(m => m);

            strNum = comboBox9.Text.Trim();
            strTime = comboBox8.Text.Trim();
            if (strNum != "")
            {
                model = model.Where(m => m.订单编号.IndexOf(strNum) >= 0);
            }
            if (strTime != "")
            {
                model = model.Where(m => m.商品名称.IndexOf(strTime) >= 0);
            }
            // this.dataGridView2.DataSource = model.ToList();
            var mod = db.Order1.FirstOrDefault(m => m.订单编号 == strNum && m.商品名称 == strTime);
            if (mod == null)
            {
                return;
            }
            tbTNum.Text = mod.订单编号;
            tbTName.Text = mod.商品名称;
            tbTGy.Text = mod.供应商;
            tbTCk.Text = mod.所属仓库;
          
        }
        /**************购货退货单商品单号触发事件******************/
        private void comboBox9_TextChanged(object sender, EventArgs e)
        {
            string strNum = "";
            strNum = comboBox9.Text.Trim();
            var del = db.Order1.FirstOrDefault(m => m.订单编号 == strNum);
            if (del == null)
            {
                return;
            }
            comboBox8.Text = del.商品名称;
        }
        /****************购货退货退货事件********************/
        private void button1_Click_1(object sender, EventArgs e)
        {
            string strTNo = "";
            string strTName = "";
            decimal TNum = 0;
            string strTDate = "";
            string strTgy = "";
            string strTC = "";
            decimal strTk = 0;

            strTNo = tbTNum.Text.Trim();
            strTName = tbTName.Text.Trim();
            TNum = Convert.ToInt32(tbTNumber.Text.Trim());
            strTDate = date.Text.Trim();
            strTgy = tbTGy.Text.Trim();
            strTC = tbTCk.Text.Trim();
            strTk = Convert.ToInt32(tbTPrice.Text.Trim());

           var model1 = db.Stores.FirstOrDefault(m => m.入库单号 == strTNo && m.商品名称 == strTName);
            decimal d = model1.库存量;
            model1.库存量 = d - TNum;
       
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("修改失败!");
                return;
            }


            DBCL.OrReject mo = new DBCL.OrReject();
            mo.订单编号 = strTNo;
            mo.商品名称 = strTName;
            mo.退货数量 = TNum;
            mo.退货日期 = strTDate;
            mo.供应商 = strTgy;
            mo.所属仓库 = strTC;
            mo.应退款金额 = strTk;

            try
            {
                db.OrRejects.Add(mo);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("商品退回失败!");
                return;
            }
            MessageBox.Show("商品已成功退回！");

            //触发
            var model = db.OrRejects.Select(m => m);

            String str = dateTimePicker2.Text.Trim();
            if (str != "")
            {
                model = model.Where(m => m.退货日期.IndexOf(str) >= 0);
            }
            this.dataGridView3.DataSource = model.ToList();

            tbTNum.Text="";
            tbTName.Text="";
            tbTNumber.Text="";
            date.Text="";
            tbTGy.Text="";
            tbTCk.Text="";
            tbTPrice.Text="";

        }

        private void button36_Click(object sender, EventArgs e)
        {
            var model = db.OrRejects.Select(m => m);

            String str = dateTimePicker2.Text.Trim();
            if (str != "")
            {
                model = model.Where(m => m.退货日期.IndexOf(str) >= 0);
            }
            this.dataGridView3.DataSource = model.ToList();
        }
        /********************销货退回订单编号触发事件************************/
        private void comboBox11_TextChanged(object sender, EventArgs e)
        {
            string strNum = "";
            strNum = comboBox11.Text.Trim();
            var del = db.Sells.FirstOrDefault(m => m.订单编号 == strNum);
            if (del == null)
            {
                return;
            }
            comboBox10.Text = del.商品名称;
        }
        /*****************销货退回查询按钮**********************/
        private void button7_Click_1(object sender, EventArgs e)
        {
            string strNum = "";
            string strName = "";
            var model = db.Sells.Select(m => m);

            strNum = comboBox11.Text.Trim();
            strName = comboBox10.Text.Trim();
            if (strNum != "")
            {
                model = model.Where(m => m.订单编号.IndexOf(strNum) >= 0);
            }
            if (strName != "")
            {
                model = model.Where(m => m.商品名称.IndexOf(strName) >= 0);
            }
            // this.dataGridView2.DataSource = model.ToList();
            var mod = db.Sells.FirstOrDefault(m => m.订单编号 == strNum && m.商品名称 == strName);
            if (mod == null)
            {
                return;
            }
            tbSNo.Text = mod.订单编号;
            tbSName.Text = mod.商品名称;
            tbSCnum.Text = mod.客户编号;
            tbSCname.Text = mod.客户名称;
            tbSCk.Text = mod.所属仓库;  

        }
        /******************销货退货退货按钮************************/
        private void button42_Click_1(object sender, EventArgs e)
        {
            string strTNo = "";
            string strTName = "";
            decimal TNum = 0;
            string strTDate = "";
            string strCnum = "";
            string strCname = "";
            string strCk = "";
            decimal dPrice = 0;

            strTNo = tbSNo.Text.Trim();
            strTName = tbSName.Text.Trim();
            TNum = Convert.ToInt32(tbSNum.Text.Trim());
            strTDate = tbSDate.Text.Trim();
            strCnum = tbSCnum.Text.Trim();
            strCname= tbSCname.Text.Trim();
            strCk = tbSCk.Text.Trim();
            dPrice = Convert.ToInt32(tbSPrice.Text.Trim());

            var model1 = db.Stores.FirstOrDefault(m => m.商品名称 == strTName);
            decimal d = model1.库存量;
            model1.库存量 = d + TNum;

            try
            {
                db.SaveChanges();
            }
            catch
            {
            }


            DBCL.Sell_Reject mo = new DBCL.Sell_Reject();
            mo.订单编号 = strTNo;
            mo.商品名称 = strTName;
            mo.退货数量 = TNum;
            mo.退货日期 = strTDate;
            mo.客户编号 = strCnum;
            mo.客户名称 = strCname;
            mo.所属仓库 = strCk;
            mo.应退款金额 = dPrice;

            try
            {
                db.Sell_Reject.Add(mo);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("销货退货失败!");
                return;
            }
            MessageBox.Show("销货已成功退回！");

            //触发
            var model = db.Sell_Reject.Select(m => m);

            String str = dateTimePicker3.Text.Trim();
            if (str != "")
            {
                model = model.Where(m => m.退货日期.IndexOf(str) >= 0);
            }
            this.dataGridView7.DataSource = model.ToList();
            tbSNo.Text = "";
            tbSName.Text = "";
            tbSNum.Text = "";
            tbSDate.Text = "";
            tbSCnum.Text = "";
            tbSCname.Text = "";
            tbSCk.Text = "";
            tbSPrice.Text = "";
            
        }

        private void dataGridViewX7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }
        /****************盘点********************/
        private void button9_Click(object sender, EventArgs e)
        {
           
            string name = cbPName.Text.Trim();
            string ck = cbPck.Text.Trim();

            var model = db.Stores.Select(m => m);

            if (name != "")
            {
                model = model.Where(m => m.商品名称.IndexOf(name) >= 0);
            }
            if (ck != "")
            {
                model = model.Where(m => m.仓库名称.IndexOf(ck) >= 0);
            }
            this.dataGridView2.DataSource = model.ToList();

          
          
                decimal num = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    num += Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
                
                }
                textBox4.Text = num.ToString();

                textBox4.Text.Trim();
                textBox5.Text.Trim();
                textBox6.Text.Trim();
                
            
          

        }
        /******************库存数量********************/
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = 0;
                decimal num = 0;
                num1 = Convert.ToInt32(textBox5.Text.Trim());
                num = Convert.ToInt32(textBox4.Text.Trim());
                decimal n = num - num1;
                textBox6.Text = n.ToString();
            }
            catch { }
            
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbGNum_TextChanged(object sender, EventArgs e)
        {
            tbGNum.Text = "";
        }
          
        


    }
}
