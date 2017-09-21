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
    public partial class SearchSell : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        public SearchSell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strtime = "";
            string strnum = "";
            var model = db.Sells.Select(m => m);

            strtime = tbTime.Text.Trim();
            strnum = tbNum.Text.Trim();
            if (strtime != "")
            {
                model = model.Where(m => m.销货日期.IndexOf(strtime) >= 0);
            }
            if (strnum != "")
            {
                model = model.Where(m => m.订单编号.IndexOf(strnum) >= 0);
            }
            this.dataGridView1.DataSource = model.ToList();
        }
    }
}
