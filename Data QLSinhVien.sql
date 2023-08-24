create database sale 
go
use sale
create table area(
id int,
name nvarchar(255)
)
go
create table customer00 (
id int,
name nvarchar(255),
id_area int
)
go
insert into area values (1, 'Bac')
insert into area values (2, 'Trung')
insert into area values (3, 'Tay Nguyen')
insert into area values (4, 'Dong Nam')
insert into area values (5, 'Tay Nam')
go
insert into customer00 values (1, 'Nguyen Van A', 1)
insert into customer00 values (2, 'Nguyen Van B', 2)
insert into customer00 values (3, 'Nguyen Van C', 2)
insert into customer00 values (4, 'Nguyen Van D', 3)
insert into customer00 values (5, 'Nguyen Van E', 5)
insert into customer00 values (6, 'Nguyen Van F', 4)
insert into customer00 values (7, 'Nguyen Van G', 5)

--Lấy tài khoản và mk
CREATE PROC PROCLOGIN
@user nvarchar(100),
@pass nvarchar(100)
AS
BEGIN
	SELECT * FROM TableTaiKhoan WHERE TaiKhoan = @user AND MatKhau = @pass
END
GO