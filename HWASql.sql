create database hyundai;
select * from [dbo].[AspNetUsers]
select * from [dbo].[AspNetUserRoles]
select * from [dbo].[AspNetRoles]
select * from 

select * from 
select * from ;

insert into AspNetRoles values(1,'Admin');
insert into AspNetRoles values(2,'Guest');

insert into AspNetUserRoles values('222d6490-1ddc-484d-af5f-7fc98216cb56',2);
create table Product_Category_Master(
ProductCategoryID int Primary key,
ProductCategoryName varchar(50)
);




Create Table Product(
ProductId int Primary key Identity(1,1),
ProductName varchar(50),
ProductCategoryID int foreign key references Product_Category_Master(ProductCategoryID),
UnitPrice decimal,
MFGDate datetime,
TotalNumberAvailable int
)


select * from Product_Category_Master pcm, Product p where pcm.ProductCategoryID=p.ProductCategoryID and p.ProductName='santro'
and pcm.ProductCategoryName='MARUTHI'

insert into Product_Category_Master values(1,'MARUTHI');
insert into Product_Category_Master values(2,'AUDI');
insert into Product_Category_Master values(3,'BMW');
insert into Product_Category_Master values(4,'HYUNDAI');

SELECT * from Product_Category_Master;


create or alter procedure (@ProductName varchar(50), @ProductCategoryID int,@UnitPrice decimal,
@MFGDate datetime,
@TotalNumberAvailable int)
as

begin 

insert into Product(ProductName,ProductCategoryID ,UnitPrice ,MFGDate ,TotalNumberAvailable)
values(@ProductName , @ProductCategoryID ,@UnitPrice ,@MFGDate,@TotalNumberAvailable )

end

select * from Product













