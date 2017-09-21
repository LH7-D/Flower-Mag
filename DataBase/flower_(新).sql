/**********购货退货单************/
create table OrReject(
   订单编号 nvarchar(20) not null,  
   商品名称  nvarchar(20) not null,          
   退货数量 decimal not null ,               
   退货日期 nvarchar(20) not null,                         
   供应商  nvarchar(20) not null,          
   所属仓库 nvarchar(20) not null,         
   应退款金额 decimal not null ,
   primary key(订单编号,商品名称)
)

/***********************销货单表*****************************/
create table Sell(
   订单编号 nvarchar(20) not null ,   
   商品名称  nvarchar(20) not null,          
   销货数量 decimal not null ,               
   销货日期 nvarchar(20) not null,           
   客户编号  nvarchar(20) not null, 
   客户名称  nvarchar(20) not null,      
   所属仓库 nvarchar(20) not null,       
   已付款金额  decimal null , 
   总金额 decimal  null , 
   付款方式 nvarchar(20) null,
   未付款金额 decimal null , 
   primary key(订单编号,商品名称)   
)
/***************销货退货单**********************/
create table Sell_Reject(
   订单编号 nvarchar(20) not null,   
   商品名称  nvarchar(20) not null,          
   退货数量 decimal not null ,               
   退货日期 nvarchar(20) not null,           
   客户编号  nvarchar(20) not null, 
   客户名称  nvarchar(20) not null,      
   所属仓库 nvarchar(20) not null,       
   应退款金额  decimal null , 
   primary key(订单编号,商品名称)
)

/***********************客户信息表******************************/
create table Guest(
    客户编号 nvarchar(20) not null primary key,/*客户编号*/
    客户名称 nvarchar(20),/*客户名称*/
    联系人 nvarchar(10),
    联系电话 nvarchar(20),
    邮箱 nvarchar(20),
    联系地址 nvarchar(40)
)

create table Store(
    id int identity(1,1) not null ,
    入库单号 nvarchar(20) not null,
    仓库编号 nvarchar(20),
    仓库名称 nvarchar(20),  /*仓库名称*/ 
    商品编号  nvarchar(20),/*商品编号*/
    商品名称  nvarchar(20),/*商品名称*/
    库存量 decimal not null,
    primary key(id,入库单号)
)