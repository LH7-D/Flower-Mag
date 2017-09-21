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
    public partial class SearchHistory : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        public SearchHistory()
        {
            InitializeComponent();
        }

        private void SearchHistory_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“flower_DataSet1.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.flower_DataSet1.Product);
            // TODO:  这行代码将数据加载到表“flower_DataSet.Repertory”中。您可以根据需要移动或删除它。
            this.repertoryTableAdapter.Fill(this.flower_DataSet.Repertory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strtime = "";
            string strck = "";
            var model = db.Order1.Select(m => m);

            strtime = tbTime.Text.Trim();
            strck = tbCk.Text.Trim();
            if (strtime != "")
            {
                model = model.Where(m => m.购货日期.IndexOf(strtime) >= 0);
            }
            if (strck != "")
            {
                model = model.Where(m => m.所属仓库.IndexOf(strck) >= 0);
            }
            this.dataGridView1.DataSource = model.ToList();
        }
    }
}
