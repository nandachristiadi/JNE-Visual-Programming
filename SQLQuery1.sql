Create Table Login_User(
Username Varchar(50) primary key not null,
Passwords varchar(50) not null)

create table Staff(
Staff_ID char(5) primary key not null,
Staff_Name varchar(50) not null,
Staff_Gender varchar(5) not null,
Staff_DOB date not null,
Staff_Position varchar(20) not null,
Staff_Phone char(15) not null,
Staff_Email varchar(20) not null)

create table Tarif(
Ship_type varchar(10) primary key not null,
Distance int,
Ship_Fee float(18),
Dist_Fee float(18))

Create table Transaksi(
No_Resi int IDENTITY(100,1) primary key not null,
   NoResi as RIGHT('R0000' + CONVERT(varchar(9),No_Resi),9),
Cust_Name Varchar(50) not null,
Cust_Phone char(15) not null,
Cust_Address varchar(50) not null,
Cust_Zip char(6) not null,
Cust_City Varchar(20) not null,
Cust_Country Varchar(20)not null,
Rec_Name Varchar(50),
Rec_Phone char(15),
Rec_Address varchar(50),
Rec_Zip char(6),
Rec_City varchar(20),
Rec_Country varchar(20),
Item_Type varchar(30) not null,
Item_Desc varchar(50) ,
Item_Weight int not null,
timeLimit date not null,
Staff_Id char(5) REFERENCES Staff(Staff_Id),
Ship_Type varchar(10) REFERENCES Tarif(Ship_type),
Ship_Date date not null,
ReceivedBy varchar (20) not null)


Create table Orders(
No_Order int IDENTITY(10,1) primary key not null,
   NoOrder as RIGHT('OR-0000' + CONVERT(varchar(9),No_Order),9),
No_Resi int REFERENCES Transaksi(No_Resi),
Ship_Type varchar(10) REFERENCES Tarif(Ship_type),
Orders_Date date,
Status_Order varchar (25)) 


create table Payment(
No_Payment int IDENTITY(1,1) primary key not null,
   NoPayment as RIGHT('PY0000' + CONVERT(varchar(9),No_Payment),9),
No_Resi int REFERENCES Transaksi(No_Resi),
Item_Weight int not null,
Ship_Type varchar(10) REFERENCES Tarif(Ship_type),
SubTotal int,
Pay_Method varchar(10) not null)

INSERT INTO [dbo].[Login_User]
           ([Username]
           ,[Passwords])
     VALUES
           ('Nanda','Rodrigrez'),
		   ('Kefas','gadingkaget'),
		   ('Natasya','Natasya123'),
		   ('Anggita','Anggita123'),
		   ('Syifa','Syifa123')

GO

INSERT INTO [dbo].[Staff]
           ([Staff_ID]
           ,[Staff_Name]
           ,[Staff_Gender]
           ,[Staff_DOB]
           ,[Staff_Position]
           ,[Staff_Phone]
           ,[Staff_Email])
     VALUES
           ('001', 'Rodrigrez', 'M','1993/11/15','Warehouse','082134875638','Rodrigrez@UMN.com'),
		   ('002', 'NamFuYu', 'M','1993/09/09','Stock','0821923856','Yahayuk@UMN.com'),
		   ('003', 'YuAdzan', 'F','1993/03/26','Manager','08214958467','Domain@UMN.com'),
		   ('004', 'Fernandez', 'M','1993/04/30','Warehouse','082103947','Fernandez@UMN.com'),
		   ('005', 'Benji', 'F','1994/03/03','Stock','0821672317','Benji@UMN.com')
GO

INSERT INTO [dbo].[Tarif]
           ([Ship_type]
           ,[Distance]
           ,[Ship_Fee]
           ,[Dist_Fee])
     VALUES
           ('Reg1','20','10000','5000'),
		   ('Reg2','16','10000','5000'),
		   ('Reg3','10','10000','5000'),
		   ('KLT1','20','25000','5000'),
		   ('KLT2','10','15000','5000')
GO

INSERT INTO [dbo].[Transaksi]
           (
           [Cust_Name]
           ,[Cust_Phone]
           ,[Cust_Address]
           ,[Cust_Zip]
           ,[Cust_City]
           ,[Cust_Country]
		   ,[Rec_Name]
		   ,[Rec_Phone]
		   ,[Rec_Address]
           ,[Rec_Zip]
           ,[Rec_City]
           ,[Rec_Country]
		   ,[Item_Type]
           ,[Item_Desc]
           ,[Item_Weight]
           ,[timeLimit]
		   ,[Staff_Id]
           ,[Ship_Type]
           ,[Ship_Date]
           ,[ReceivedBy])
     VALUES
			('Kefas','081107896655','Jl.Jalan','16916','Jakarta','INA','Nanda','081289772233','Jl. Pulang','17518','Bogor','INA','Elektronik','Lampu','1','2020/11/30','001','Reg1','2020/11/30','Daendels')

GO

INSERT INTO [dbo].[Orders]
           ([No_Resi]
           ,[Ship_Type]
           ,[Orders_Date],
		   [Status_Order])
     VALUES
           ('100','Reg1','2020/11/30','On Process')
GO

INSERT INTO [dbo].[Payment]
           ([No_Resi]
           ,[Item_Weight]
           ,[Ship_Type]
           ,[SubTotal]
           ,[Pay_Method])
     VALUES
           ('100','1','Reg1','20000','Cash')
GO
