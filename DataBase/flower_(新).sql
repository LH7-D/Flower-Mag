/**********�����˻���************/
create table OrReject(
   ������� nvarchar(20) not null,  
   ��Ʒ����  nvarchar(20) not null,          
   �˻����� decimal not null ,               
   �˻����� nvarchar(20) not null,                         
   ��Ӧ��  nvarchar(20) not null,          
   �����ֿ� nvarchar(20) not null,         
   Ӧ�˿��� decimal not null ,
   primary key(�������,��Ʒ����)
)

/***********************��������*****************************/
create table Sell(
   ������� nvarchar(20) not null ,   
   ��Ʒ����  nvarchar(20) not null,          
   �������� decimal not null ,               
   �������� nvarchar(20) not null,           
   �ͻ����  nvarchar(20) not null, 
   �ͻ�����  nvarchar(20) not null,      
   �����ֿ� nvarchar(20) not null,       
   �Ѹ�����  decimal null , 
   �ܽ�� decimal  null , 
   ���ʽ nvarchar(20) null,
   δ������ decimal null , 
   primary key(�������,��Ʒ����)   
)
/***************�����˻���**********************/
create table Sell_Reject(
   ������� nvarchar(20) not null,   
   ��Ʒ����  nvarchar(20) not null,          
   �˻����� decimal not null ,               
   �˻����� nvarchar(20) not null,           
   �ͻ����  nvarchar(20) not null, 
   �ͻ�����  nvarchar(20) not null,      
   �����ֿ� nvarchar(20) not null,       
   Ӧ�˿���  decimal null , 
   primary key(�������,��Ʒ����)
)

/***********************�ͻ���Ϣ��******************************/
create table Guest(
    �ͻ���� nvarchar(20) not null primary key,/*�ͻ����*/
    �ͻ����� nvarchar(20),/*�ͻ�����*/
    ��ϵ�� nvarchar(10),
    ��ϵ�绰 nvarchar(20),
    ���� nvarchar(20),
    ��ϵ��ַ nvarchar(40)
)

create table Store(
    id int identity(1,1) not null ,
    ��ⵥ�� nvarchar(20) not null,
    �ֿ��� nvarchar(20),
    �ֿ����� nvarchar(20),  /*�ֿ�����*/ 
    ��Ʒ���  nvarchar(20),/*��Ʒ���*/
    ��Ʒ����  nvarchar(20),/*��Ʒ����*/
    ����� decimal not null,
    primary key(id,��ⵥ��)
)