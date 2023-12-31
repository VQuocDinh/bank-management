USE [NGANHANG]
GO
/****** Object:  User [HTKN]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_A5A8D6D779E6482A9C65B5F03EA523CB]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE ROLE [MSmerge_A5A8D6D779E6482A9C65B5F03EA523CB]
GO
/****** Object:  DatabaseRole [MSmerge_BDBED1E791C74C3DB99411876EFD9C29]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE ROLE [MSmerge_BDBED1E791C74C3DB99411876EFD9C29]
GO
/****** Object:  DatabaseRole [MSmerge_F52CD4E290024E92A65C5404702FC5A6]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE ROLE [MSmerge_F52CD4E290024E92A65C5404702FC5A6]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_A5A8D6D779E6482A9C65B5F03EA523CB]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_BDBED1E791C74C3DB99411876EFD9C29]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_F52CD4E290024E92A65C5404702FC5A6]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 6/13/2023 5:33:54 PM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[TENCN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[TENCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_CHUYENTIEN]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_CHUYENTIEN](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK_CHUYEN] [nchar](9) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[SOTK_NHAN] [nchar](9) NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_CHUYENTIEN] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_GOIRUT]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_GOIRUT](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK] [nchar](9) NOT NULL,
	[LOAIGD] [nchar](2) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_GOIRUT] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[NGAYCAP] [date] NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [nchar](10) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[SOTK] [nchar](9) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[SODU] [money] NULL,
	[MACN] [nchar](10) NULL,
	[NGAYMOTK] [date] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[SOTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Get_Subscribes]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Subscribes]
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
WHERE  (SUBS.subscriber_server NOT LIKE '%SERVER3')
GO
/****** Object:  View [dbo].[NV_ROLE]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NV_ROLE] AS
SELECT D2.name AS NV  , D1.name AS ROLE
 FROM sys.database_role_members AS D0  
 LEFT JOIN sys.database_principals AS D1   ON D0.role_principal_id = D1.principal_id  
 LEFT JOIN sys.database_principals AS D2   ON D0.member_principal_id = D2.principal_id  
WHERE D1.name in ('NganHang','ChiNhanh') 
WITH CHECK OPTION;
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_6B587C65114F4276A83FE642233B4721]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [DF_GD_CHUYENTIEN_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_C6BDF004823744E4BF1EB0150CEF0ACE]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_SOTIEN]  DEFAULT ((100000)) FOR [SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [MSmerge_df_rowguid_2CB125AD622847A189BBE2D2FC93BE0E]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [MSmerge_df_rowguid_62A77812C89340E18E75E734D0271110]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_PHAI]  DEFAULT (N'Nam') FOR [PHAI]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_0E7FB1FCE79C4AD7952EDE26C75F3B00]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [SODU]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [MSmerge_df_rowguid_3028332A12C047E791555EBBB45925E6]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan] FOREIGN KEY([SOTK_CHUYEN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1] FOREIGN KEY([SOTK_NHAN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_NhanVien]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_TaiKhoan] FOREIGN KEY([SOTK])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([CMND])
REFERENCES [dbo].[KhachHang] ([CMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [CK_GD_CHUYENTIEN] CHECK  (([SOTIEN]>(0)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [CK_GD_CHUYENTIEN]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_58B30FBE_D096_4E20_8830_A7AEE2BBF4D6] CHECK NOT FOR REPLICATION (([MAGD]>=(1) AND [MAGD]<=(1001) OR [MAGD]>(1001) AND [MAGD]<=(2001)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [repl_identity_range_58B30FBE_D096_4E20_8830_A7AEE2BBF4D6]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_LOAIGD] CHECK  (([LOAIGD]='RT' OR [LOAIGD]='GT'))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_LOAIGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_SOTIEN] CHECK  (([SOTIEN]>=(100000)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_39535D7E_7872_4100_A6A8_6510E16BC6C2] CHECK NOT FOR REPLICATION (([MAGD]>=(1) AND [MAGD]<=(1001) OR [MAGD]>(1001) AND [MAGD]<=(2001)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [repl_identity_range_39535D7E_7872_4100_A6A8_6510E16BC6C2]
GO
/****** Object:  StoredProcedure [dbo].[frmCreateLogin_CreateLoginForEmployee]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmCreateLogin_CreateLoginForEmployee] @LGNAME VARCHAR(50), @PASS VARCHAR(50), @USERNAME VARCHAR(50), @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'NGANHANG'
  --
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  --
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'NganHang'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
    EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  END
RETURN 0  -- THANH CONG

GO
/****** Object:  StoredProcedure [dbo].[frmCreateLogin_DeleteLoginForEmployee]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmCreateLogin_DeleteLoginForEmployee] @LGNAME VARCHAR(50), @USRNAME VARCHAR(50)
AS
  EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME

GO
/****** Object:  StoredProcedure [dbo].[frmCreateLogin_DuplicateLOGIN]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmCreateLogin_DuplicateLOGIN] @TENLOGIN NVARCHAR (50), @ROLE NVARCHAR (50)
AS
DECLARE @Table TABLE
(
   /*TABLE DEFINITION*/
   TENLOGIN NVARCHAR (20),
   MANV Nvarchar(20),
   HOTEN Nvarchar(20),
   ROLE varchar(20)
)
INSERT INTO @Table 
EXEC frmCreateLogin_GetLoginsOfBranch @ROLE
BEGIN
	SELECT TENLOGIN FROM @Table WHERE TENLOGIN =@TENLOGIN
END

GO
/****** Object:  StoredProcedure [dbo].[frmCreateLogin_GetEmployeeNotHaveLogin]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmCreateLogin_GetEmployeeNotHaveLogin]
AS
BEGIN
SELECT * FROM NhanVien 
WHERE NOT EXISTS (SELECT NAME FROM sys.sysusers WHERE NAME = MANV) AND TrangThaiXoa = 0
END

GO
/****** Object:  StoredProcedure [dbo].[frmCreateLogin_GetLoginsOfBranch]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmCreateLogin_GetLoginsOfBranch] @ROLE VARCHAR(50) AS
BEGIN
	SELECT MASTER.name AS TENLOGIN, SYS.name AS MANV, HO+ ' '+ TEN AS HOTEN, VI.ROLE AS ROLE
	FROM [master].[sys].[sql_logins] AS MASTER
	LEFT JOIN sys.sysusers AS SYS 
	ON MASTER.sid = SYS.sid 
	LEFT JOIN NhanVien
	ON MANV = SYS.name 
	LEFT JOIN NV_ROLE AS VI
	ON MANV=VI.NV
	WHERE SYS.name<>'null' and SYS.name <>'HTKN' and MASTER.name <>'sa' AND VI.ROLE = @ROLE
	ORDER BY MASTER.name
END

GO
/****** Object:  StoredProcedure [dbo].[frmKhachHang_CreateCustomer]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmKhachHang_CreateCustomer] @CMND nchar(10),@HO nvarchar(50), @TEN nvarchar(10),@DIACHI nvarchar(100)
,@PHAI nvarchar(3), @NGAYCAP datetime,@SODT nvarchar(15),@MACN nchar(10)
AS
BEGIN
	IF EXISTS (SELECT CMND FROM KhachHang WHERE CMND = @CMND)
		BEGIN
			UPDATE KhachHang
				SET CMND = @CMND,
					HO = @HO,
					TEN = @TEN,
					DIACHI=@DIACHI,
					PHAI=@PHAI,
					NGAYCAP=@NGAYCAP,
					SODT = @SODT,
					MACN = @MACN
				WHERE CMND = @CMND
		END
	IF NOT EXISTS (SELECT CMND FROM KhachHang WHERE CMND = @CMND)
		BEGIN
			INSERT INTO KhachHang (CMND , HO , TEN , DIACHI , PHAI,NGAYCAP,SODT,MACN)
					VALUES (@CMND , @HO , @TEN , @DIACHI , @PHAI,@NGAYCAP,@SODT,@MACN)
		END 
END

GO
/****** Object:  StoredProcedure [dbo].[frmKhachHang_DeleteAccountNonGD]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmKhachHang_DeleteAccountNonGD] @CMND NVARCHAR (10)
AS
DELETE FROM TaiKhoan WHERE CMND=@CMND

GO
/****** Object:  StoredProcedure [dbo].[frmKhachHang_ExistsAccount]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmKhachHang_ExistsAccount] @CMND NVARCHAR (50)
AS
BEGIN
	SELECT CMND FROM TaiKhoan WHERE CMND = @CMND
END

GO
/****** Object:  StoredProcedure [dbo].[frmKhachHang_ExistsGD]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmKhachHang_ExistsGD] @CMND NVARCHAR (10)
AS
IF  EXISTS(SELECT CMND FROM KhachHang WHERE CMND =@CMND)
BEGIN
	SELECT SOTK FROM GD_GOIRUT
	WHERE SOTK IN 
	(SELECT SOTK FROM TaiKhoan WHERE CMND = @CMND)
END
ELSE
IF  EXISTS(SELECT CMND FROM LINK0.NGANHANG.DBO.KhachHang WHERE CMND =@CMND)
BEGIN
SELECT SOTK FROM GD_GOIRUT
	WHERE SOTK IN 
	(SELECT SOTK FROM LINK0.NGANHANG.DBO.TaiKhoan WHERE CMND = @CMND)
END

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_DSTaiKhoanKhachHang]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[frmOpenAcountCustormer_DSTaiKhoanKhachHang] @CMND NVARCHAR (10), @MACN NVARCHAR(10)
AS
IF  EXISTS(SELECT CMND FROM TaiKhoan where CMND = @CMND and MACN = @MACN)
	BEGIN
		SELECT SOTK, CMND, SODU,MACN, NGAYMOTK FROM TaiKhoan where CMND = @CMND and MACN = @MACN
	END
ELSE
IF  EXISTS(SELECT CMND FROM LINK0.NGANHANG.DBO.TaiKhoan where CMND = @CMND and MACN = @MACN)
	BEGIN
		SELECT SOTK, CMND, SODU,MACN, NGAYMOTK FROM LINK0.NGANHANG.DBO.TaiKhoan where CMND = @CMND and MACN = @MACN
	END

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_DSTKKH]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmOpenAcountCustormer_DSTKKH] @CMND NVARCHAR (10), @MACN NVARCHAR(10)
AS
IF  EXISTS(SELECT CMND FROM TaiKhoan where CMND = @CMND and MACN = @MACN)
	BEGIN
		SELECT SOTK, CMND, SODU,MACN, NGAYMOTK FROM TaiKhoan where CMND = @CMND and MACN = @MACN
	END
ELSE
IF  EXISTS(SELECT CMND FROM LINK0.NGANHANG.DBO.TaiKhoan where CMND = @CMND and MACN = @MACN)
	BEGIN
		SELECT SOTK, CMND, SODU,MACN, NGAYMOTK FROM LINK0.NGANHANG.DBO.TaiKhoan where CMND = @CMND and MACN = @MACN
	END

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_HasAcount]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmOpenAcountCustormer_HasAcount] @SOTK NVARCHAR (9)
AS
IF  EXISTS(SELECT CMND FROM TaiKhoan WHERE SOTK =@SOTK)
	BEGIN
		SELECT SOTK FROM TaiKhoan WHERE SOTK =@SOTK
	END
ELSE
IF  EXISTS(SELECT CMND FROM LINK0.NGANHANG.DBO.TaiKhoan WHERE SOTK =@SOTK)
	BEGIN
		SELECT SOTK FROM LINK0.NGANHANG.DBO.TaiKhoan WHERE SOTK =@SOTK
	END

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_MoTKKH]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmOpenAcountCustormer_MoTKKH] @SOTK nchar(9), @CMND nchar(10), @SODU money, @MACN nchar(10)
AS
BEGIN
	IF EXISTS (SELECT SOTK FROM TaiKhoan WHERE SOTK = @SOTK)
		BEGIN
			UPDATE TaiKhoan
				SET SODU = @SODU
				WHERE SOTK = @SOTK
		END
	IF NOT EXISTS (SELECT SOTK FROM TaiKhoan WHERE SOTK = @SOTK)
		BEGIN
			INSERT INTO TaiKhoan (SOTK , CMND , SODU , MACN )
					VALUES (@SOTK , @CMND , @SODU , @MACN )
		END 
END

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_ThongTinKhachHang]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmOpenAcountCustormer_ThongTinKhachHang] @CMND nchar(10)
AS
IF  EXISTS(SELECT CMND FROM KhachHang WHERE CMND =@CMND)
	BEGIN
		SELECT CMND, HO +' '+TEN AS HOTEN, MACN FROM KhachHang WHERE CMND = @CMND
	END
ELSE IF  EXISTS(SELECT CMND FROM LINK2.NGANHANG.DBO.KhachHang WHERE CMND =@CMND)
	BEGIN
		SELECT CMND, HO +' '+TEN AS HOTEN, MACN FROM LINK2.NGANHANG.DBO.KhachHang WHERE CMND = @CMND
	END
ELSE RAISERROR(N'KHÔNG TỒN TẠI KHÁCH HÀNG VỚI SỐ CMND NÀY', 16, 1);

GO
/****** Object:  StoredProcedure [dbo].[frmOpenAcountCustormer_XoaTKKhachHang ]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmOpenAcountCustormer_XoaTKKhachHang ] @SOTK nchar(10)
AS
BEGIN
	DELETE FROM TaiKhoan
	WHERE SOTK = @SOTK
END

GO
/****** Object:  StoredProcedure [dbo].[frmStatement_TimTKSaoKe]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmStatement_TimTKSaoKe] @SOTK NVARCHAR(9)
AS
DECLARE @MACN NCHAR(10),@CMND nchar(10)

IF EXISTS (SELECT SOTK FROM TaiKhoan WHERE SOTK = @SOTK)
BEGIN
	SET @CMND = (SELECT CMND FROM TaiKhoan WHERE SOTK = @SOTK)
END
ELSE IF EXISTS (SELECT SOTK FROM LINK0.NGANHANG.DBO.TaiKhoan WHERE SOTK = @SOTK)
BEGIN
	SET @CMND = (SELECT CMND FROM LINK0.NGANHANG.DBO.TaiKhoan WHERE SOTK = @SOTK)
END
ELSE
BEGIN
	RAISERROR(N'KHÔNG TỒN TẠI TÀI KHOẢN CẦN SAO KÊ', 16, 1);
RETURN
END

IF EXISTS (SELECT CMND FROM KhachHang WHERE CMND = @CMND)
BEGIN
	SET @MACN = (SELECT MACN FROM KhachHang WHERE CMND = @CMND)
END
	ELSE RAISERROR(N'TÀI KHOẢN CỦA KHÁCH HÀNG KHÔNG THUỘC CHI NHÁNH BẠN QUẢN LÝ!!. HÃY THỬ CHUYỂN CHI NHÁNH', 16, 1);
IF EXISTS (SELECT CMND FROM KhachHang WHERE CMND = @CMND)
BEGIN
	SELECT KH.HO + ' ' + KH.TEN + ' - '  + TK.SOTK AS HOTEN ,KH.CMND,TK.SOTK
	FROM (SELECT CMND,HO,TEN FROM KhachHang 
	WHERE CMND =@CMND) KH,
	(SELECT SOTK FROM TaiKhoan
	WHERE SOTK =@SOTK) TK
END
ELSE IF EXISTS (SELECT CMND FROM LINK0.NGANHANG.DBO.KhachHang WHERE CMND = @CMND AND MACN=@MACN)
BEGIN
	SELECT KH.HO + ' ' + KH.TEN + ' - '  + TK.SOTK AS HOTEN ,KH.CMND,TK.SOTK
	FROM (SELECT CMND,HO,TEN FROM LINK0.NGANHANG.DBO.KhachHang 
	WHERE CMND =@CMND) KH,
	(SELECT SOTK FROM LINK0.NGANHANG.DBO.TaiKhoan
	WHERE SOTK =@SOTK) TK
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Chuyen_Tien]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Chuyen_Tien]
	@SOTK_CHUYEN NCHAR(9),
	@SOTK_NHAN NCHAR(9),
	@SOTIEN MONEY,
	@NGAYGD DATETIME,
	@MANV NCHAR(10)
AS
BEGIN
	SET XACT_ABORT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	BEGIN TRY
		BEGIN TRANSACTION;

		DECLARE @SODU_CHUYEN MONEY;
		DECLARE @SODU_NHAN MONEY;

		-- Lấy số dư của tài khoản chuyển
		SELECT @SODU_CHUYEN = SODU
		FROM dbo.TaiKhoan
		WHERE SOTK = @SOTK_CHUYEN;

		-- Lấy số dư của tài khoản nhận
		SELECT @SODU_NHAN = SODU
		FROM dbo.TaiKhoan
		WHERE SOTK = @SOTK_NHAN;


		-- Thực hiện chuyển tiền
		INSERT INTO dbo.GD_CHUYENTIEN(SOTK_CHUYEN, NGAYGD, SOTIEN, SOTK_NHAN, MANV)
		VALUES (@SOTK_CHUYEN, @NGAYGD, @SOTIEN, @SOTK_NHAN, @MANV);

		-- Cập nhật số dư tài khoản nhận
		UPDATE dbo.TaiKhoan
		SET SODU = @SODU_NHAN + @SOTIEN
		WHERE SOTK = @SOTK_NHAN;

		-- Cập nhật số dư tài khoản chuyển
		UPDATE dbo.TaiKhoan
		SET SODU = @SODU_CHUYEN - @SOTIEN
		WHERE SOTK = @SOTK_CHUYEN;

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION;
			DECLARE @ErrorMessage NVARCHAR(2000);
			SELECT @ErrorMessage = 'LOI: ' + ERROR_MESSAGE();
			RAISERROR (@ErrorMessage, 16, 1);
			-- THROW;
		END;
	END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_Lay_Thong_Tin_NV_Tu_Login]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Lay_Thong_Tin_NV_Tu_Login]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_LietKeTaiKhoan]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LietKeTaiKhoan] @dateFrom AS DATE, @dateTo AS DATE, @LoaiSaoKe VARCHAR(3), @MACN NCHAR(10)
AS
BEGIN
IF EXISTS (SELECT MACN FROM LINK2.NGANHANG.dbo.KhachHang WHERE MACN = @MACN)
	BEGIN
			IF (@LoaiSaoKe = 'T')--TẤT CẢ CHI NHÁNH
			BEGIN
				SELECT TK.SOTK,KH.HO +' ' + KH.TEN AS HOTEN,TK.CMND,TK.MACN,TK.NGAYMOTK
				FROM LINK2.NGANHANG.dbo.KhachHang AS KH,
				(SELECT SOTK,CMND,MACN,NGAYMOTK FROM TaiKhoan WHERE NGAYMOTK BETWEEN @dateFrom AND @dateTo) AS TK 
				WHERE KH.CMND = TK.CMND	
				ORDER BY NGAYMOTK
			END
			ELSE IF (@LoaiSaoKe = 'C')--CHI NHÁNH HIỆN TẠI
			BEGIN
				SELECT TK.SOTK,KH.HO +' ' + KH.TEN AS HOTEN,TK.CMND,TK.MACN,TK.NGAYMOTK
				FROM LINK2.NGANHANG.dbo.KhachHang AS KH,
				(SELECT SOTK,CMND,MACN,NGAYMOTK FROM TaiKhoan WHERE NGAYMOTK BETWEEN @dateFrom AND @dateTo AND MACN = @MACN) AS TK 
				WHERE KH.CMND = TK.CMND
				ORDER BY NGAYMOTK
			END
	END
ELSE
	BEGIN
			IF (@LoaiSaoKe = 'T')--TẤT CẢ CHI NHÁNH
			BEGIN
				SELECT TK.SOTK,KH.HO +' ' + KH.TEN AS HOTEN,TK.CMND,TK.MACN,TK.NGAYMOTK
				FROM LINK0.NGANHANG.dbo.KhachHang AS KH,
				(SELECT SOTK,CMND,MACN,NGAYMOTK FROM LINK0.NGANHANG.dbo.TaiKhoan WHERE NGAYMOTK BETWEEN @dateFrom AND @dateTo) AS TK 
				WHERE KH.CMND = TK.CMND	
				ORDER BY NGAYMOTK
			END
			ELSE IF (@LoaiSaoKe = 'C')--CHI NHÁNH HIỆN TẠI
			BEGIN
				SELECT TK.SOTK,KH.HO +' ' + KH.TEN AS HOTEN,TK.CMND,TK.MACN,TK.NGAYMOTK
				FROM LINK0.NGANHANG.dbo.KhachHang AS KH,
				(SELECT SOTK,CMND,MACN,NGAYMOTK FROM LINK0.NGANHANG.dbo.TaiKhoan WHERE NGAYMOTK BETWEEN @dateFrom AND @dateTo AND MACN = @MACN) AS TK 
				WHERE KH.CMND = TK.CMND
				ORDER BY NGAYMOTK
			END
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_SaoKeTaiKhoanNganHang]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SaoKeTaiKhoanNganHang] @SOTK_SAOKE NCHAR(9), @dateFrom AS DATE, @dateTo AS DATE
AS
BEGIN
--the temporary tables can be read by the calling application(xtra report)
    SET NOCOUNT ON;  
    IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  

	CREATE TABLE #GD_Temp(SODUDAU money,NGAYGD DATETIME,LOAIGD nchar(10),SOTIEN money,SODUSAU money)

	DECLARE @CrsrVar CURSOR,  @SOTK nchar(9), @SOTIEN money, @SODUDAU money,  
	@SODUSAU money, @SOTK_NHAN nchar(9),  @SOTK_CHUYEN nchar(9),@SODUSAU_TK_NHAN money, @LOAIGD nchar(10),@NGAYGD DATETIME

	SET @CrsrVar=CURSOR KEYSET FOR 

	SELECT GR.SOTIEN,GR.LOAIGD,GR.NGAYGD FROM GD_GOIRUT AS GR
	WHERE GR.SOTK = @SOTK_SAOKE
	AND NGAYGD BETWEEN @dateFrom AND @dateTo	

	UNION ALL

	SELECT CT.SOTIEN,CT.SOTK_NHAN,CT.NGAYGD FROM GD_CHUYENTIEN AS CT
	WHERE CT.SOTK_CHUYEN = @SOTK_SAOKE
	AND NGAYGD BETWEEN @dateFrom AND @dateTo

	UNION ALL 

	SELECT CT_Nhan.SOTIEN,CT_Nhan.SOTK_NHAN,CT_Nhan.NGAYGD FROM GD_CHUYENTIEN AS CT_Nhan
	WHERE SOTK_NHAN =@SOTK_SAOKE
	AND NGAYGD BETWEEN @dateFrom AND @dateTo	
	ORDER BY NGAYGD DESC

	OPEN @CrsrVar
	FETCH NEXT FROM @CrsrVar INTO @SOTIEN,@LOAIGD,@NGAYGD
	SELECT @SODUDAU = SODU FROM dbo.TaiKhoan WHERE SOTK = @SOTK_SAOKE
	WHILE(@@FETCH_STATUS <>-1)
	BEGIN		
		IF @LOAIGD = N'GT'
			BEGIN		
				SET @SODUSAU = @SODUDAU + @SOTIEN
				INSERT INTO #GD_Temp Values(@SODUDAU,@NGAYGD,@LOAIGD,@SOTIEN,@SODUSAU) 
			END
		ELSE IF @LOAIGD = N'RT'
			BEGIN
				SET @SODUSAU = @SODUDAU - @SOTIEN
				INSERT INTO #GD_Temp Values(@SODUDAU,@NGAYGD,@LOAIGD,@SOTIEN,@SODUSAU) 
			END
		ELSE IF @LOAIGD = @SOTK_SAOKE
			BEGIN				
					SET @LOAIGD ='NT'
					SET @SODUSAU = @SODUDAU + @SOTIEN
					INSERT INTO #GD_Temp Values(@SODUDAU,@NGAYGD,@LOAIGD,@SOTIEN,@SODUSAU) 
				END
		ELSE 
			BEGIN				
				SET @LOAIGD ='CT'
				SET @SODUSAU = @SODUDAU - @SOTIEN
				INSERT INTO #GD_Temp Values(@SODUDAU,@NGAYGD,@LOAIGD,@SOTIEN,@SODUSAU) 
			END
		SET @SODUDAU = @SODUSAU
		FETCH NEXT FROM @CrsrVar INTO @SOTIEN,@LOAIGD,@NGAYGD
	END
	SELECT * FROM #GD_Temp
	ORDER BY NGAYGD 
	CLOSE @CrsrVar 
	DEALLOCATE @CrsrVar
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_TimNV]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TimNV]
  @X nvarchar(10)
AS
 DECLARE @MACN VARCHAR(10), @HO nvarchar(50), @TEN nvarchar(10)
 IF  exists(select MANV from  dbo.NHANVIEN  where MANV =@X)
 BEGIN
   	SELECT TENCN= (SELECT TENCN FROM dbo.CHINHANH),HO,TEN 
	FROM NHANVIEN WHERE MANV=@X
 END
 ELSE
  IF  exists(select MANV from  LINK0.NGANHANG.dbo.NHANVIEN  where MANV =@X)
  BEGIN
    SELECT  @MACN= MACN,  @HO=HO, @TEN=TEN 
   	    FROM LINK0.NGANHANG.dbo.NHANVIEN WHERE MANV=@X
   	SELECT  TENCN=TENCN,  HO=@HO, TEN =@TEN
   	 FROM LINK0.NGANHANG.dbo.CHINHANH  WHERE MACN=@MACN
   	                  
  END
  ELSE  -- không có nv
     raiserror ( 'Ma nhan vien khong co', 16, 1)



GO
/****** Object:  StoredProcedure [dbo].[spChuyenNV]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spChuyenNV] @MANV NCHAR(10), 
	@MACN nchar(10),
	@MANVMOI NCHAR(10)
AS
DECLARE @LGNAME VARCHAR(50)
DECLARE @USERNAME VARCHAR(50)
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRAN
		DECLARE @CMND nchar(10)
						

		SELECT @CMND = CMND FROM NhanVien WHERE MANV = @MANV

		IF EXISTS(select MANV
				from LINK1.NGANHANG.dbo.NhanVien
				where CMND = @CMND)
		BEGIN
				UPDATE LINK1.NGANHANG.dbo.NhanVien
				SET TrangThaiXoa = 0
				WHERE MANV = (	SELECT MANV FROM LINK1.NGANHANG.dbo.NhanVien
								WHERE @CMND = CMND)
		END
		ELSE

		BEGIN
			INSERT INTO LINK1.NGANHANG.dbo.NhanVien (MANV, HO, TEN, CMND, DIACHI, PHAI, SODT, MACN, TRANGTHAIXOA)
			(
					SELECT MANV = @MANVMOI, HO, TEN, CMND, DIACHI, PHAI, SODT, MACN = @MACN, TRANGTHAIXOA
					FROM dbo.NhanVien
					WHERE MANV = @MANV
)
		END
		
		UPDATE dbo.NhanVien
		SET TrangThaiXoa = 1
		WHERE MANV = @MANV
	COMMIT TRAN;
		
		IF EXISTS(SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR))
		BEGIN
			SET @LGNAME = CAST((SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS NVARCHAR)) AS VARCHAR(50))
			SET @USERNAME = CAST(@MANV AS VARCHAR(50))
			EXEC SP_DROPUSER @USERNAME;
			EXEC SP_DROPLOGIN @LGNAME;
		END	
END
GO
/****** Object:  StoredProcedure [dbo].[spDuplicateMaNV]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDuplicateMaNV] @MANV NVARCHAR (50)
AS
IF  EXISTS(SELECT MANV FROM NhanVien WHERE MANV =@MANV)
BEGIN
	SELECT MANV FROM NhanVien WHERE MANV = @MANV
END
ELSE
BEGIN
SELECT MANV FROM LINK0.NGANHANG.DBO.NhanVien WHERE MANV = @MANV
END

GO
/****** Object:  StoredProcedure [dbo].[spGuiRutTien]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGuiRutTien] @SOTK NCHAR(9), @LOAIGD NCHAR(2), @NGAYGD DATETIME, @SOTIEN MONEY, @MANV NCHAR(10)
AS
BEGIN
    SET XACT_ABORT ON;
    SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @SODUDAU MONEY;   
        DECLARE @SODUSAU MONEY;

		SELECT @SODUDAU = SODU
		FROM dbo.TaiKhoan
		WHERE SOTK = @SOTK;

        IF @LOAIGD = 'RT'
            SET @SODUSAU = @SODUDAU - @SOTIEN;
        ELSE IF @LOAIGD = 'GT'
            SET @SODUSAU = @SODUDAU + @SOTIEN;

        INSERT INTO dbo.GD_GOIRUT (SOTK, LOAIGD, NGAYGD, SOTIEN, MANV) 
        VALUES (@SOTK, @LOAIGD, @NGAYGD, @SOTIEN, @MANV);

        UPDATE dbo.TaiKhoan
        SET SODU = @SODUSAU
        WHERE SOTK = @SOTK;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF (@@TRANCOUNT > 0)
        BEGIN
            ROLLBACK TRANSACTION;
            DECLARE @ErrorMessage NVARCHAR(2000);
            SELECT @ErrorMessage = 'LOI: ' + ERROR_MESSAGE();
            RAISERROR (@ErrorMessage, 16, 1);
        END;
    END CATCH;
END;

GO
/****** Object:  StoredProcedure [dbo].[spLietKeKH]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spLietKeKH] @LOAI VARCHAR(1), @MACN NCHAR(10)
AS
BEGIN

	BEGIN
		IF (@LOAI ='T')
			SELECT CMND, HO+' '+TEN AS HOTEN, DIACHI,SODT,NGAYCAP,MACN FROM LINK2.NGANHANG.DBO.KHACHHANG
			ORDER BY HO, TEN;
		ELSE IF (@LOAI ='C')
			SELECT CMND, HO+' '+TEN AS HOTEN, DIACHI,SODT,NGAYCAP,MACN FROM DBO.KHACHHANG
			ORDER BY HO, TEN;
	END

END
GO
/****** Object:  StoredProcedure [dbo].[spSoTKNhan]    Script Date: 6/13/2023 5:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSoTKNhan] @SOTK nchar(9)
AS
IF  EXISTS(SELECT SOTK FROM TaiKhoan WHERE SOTK =@SOTK)
BEGIN
	SELECT  KH.HOTEN,TK.SOTK,TK.CMND,TK.MACN FROM 
	(SELECT HO+' '+TEN AS HOTEN FROM LINK2.NGANHANG.DBO.KhachHang WHERE CMND=(SELECT CMND FROM TaiKhoan WHERE SOTK=@SOTK)) KH,
	(SELECT SOTK,CMND, MACN FROM TaiKhoan WHERE  SOTK=@SOTK) TK
END
ELSE RAISERROR(N'KHÔNG TỒN TẠI TÀI KHOẢN NÀY', 16, 1);


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'‘GT’ : gởi tiền vào TK , ‘RT’ : rút tiền khỏi TK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GD_GOIRUT', @level2type=N'COLUMN',@level2name=N'LOAIGD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PUBS"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUBS"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Get_Subscribes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Get_Subscribes'
GO
