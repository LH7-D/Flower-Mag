//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBCL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order1
    {
        public string 订单编号 { get; set; }
        public string 商品名称 { get; set; }
        public decimal 购货数量 { get; set; }
        public string 购货日期 { get; set; }
        public decimal 零售价 { get; set; }
        public string 供应商 { get; set; }
        public string 所属仓库 { get; set; }
        public Nullable<decimal> 折扣率 { get; set; }
        public Nullable<decimal> 折扣额 { get; set; }
        public Nullable<decimal> 已付款金额 { get; set; }
        public Nullable<decimal> 总金额 { get; set; }
        public string 付款方式 { get; set; }
        public Nullable<decimal> 未付款金额 { get; set; }
    }
}
