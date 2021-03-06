USE [master]
GO
/****** Object:  Database [AMW]    Script Date: 6/18/2019 4:50:29 PM ******/
CREATE DATABASE [AMW]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AMW', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.BABLU\MSSQL\DATA\AMW.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AMW_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.BABLU\MSSQL\DATA\AMW_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AMW] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AMW].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AMW] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AMW] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AMW] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AMW] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AMW] SET ARITHABORT OFF 
GO
ALTER DATABASE [AMW] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AMW] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AMW] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AMW] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AMW] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AMW] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AMW] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AMW] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AMW] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AMW] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AMW] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AMW] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AMW] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AMW] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AMW] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AMW] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AMW] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AMW] SET RECOVERY FULL 
GO
ALTER DATABASE [AMW] SET  MULTI_USER 
GO
ALTER DATABASE [AMW] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AMW] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AMW] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AMW] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AMW] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AMW', N'ON'
GO
USE [AMW]
GO
USE [AMW]
GO
/****** Object:  Sequence [dbo].[invoiceSequence]    Script Date: 6/18/2019 4:50:29 PM ******/
CREATE SEQUENCE [dbo].[invoiceSequence] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[additionalInfo]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[additionalInfo](
	[yrYR] [nvarchar](6) NULL,
	[trial] [bit] NULL,
	[prefix] [nvarchar](10) NOT NULL,
	[suffix] [nvarchar](10) NOT NULL,
	[billCounter] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Attendence]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendence](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmpPersonalID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[InTime] [time](7) NOT NULL,
	[InAttendBy] [int] NOT NULL,
	[OutTime] [time](7) NULL,
	[OutAttendBy] [int] NULL,
 CONSTRAINT [PK_Attendence] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientlDtlsTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientlDtlsTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MailingAddress] [nvarchar](150) NULL,
	[ShippingAddress] [nvarchar](150) NULL,
	[EMail] [nvarchar](50) NULL,
	[Phone] [nchar](11) NULL,
	[Mobile] [nchar](10) NOT NULL,
	[Fax] [nchar](15) NULL,
	[UIN] [nvarchar](50) NULL,
	[PAN_IT] [nvarchar](50) NULL,
	[AddedBy] [int] NOT NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_ClientlDtlsTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeePersonalTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeePersonalTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DOB] [date] NULL,
	[Mobile] [nchar](10) NOT NULL,
	[Address] [nvarchar](150) NULL,
	[Alt_mobile] [nchar](10) NULL,
	[Alt_add] [nvarchar](150) NULL,
	[UIN] [nvarchar](50) NULL,
	[DocType] [nvarchar](50) NULL,
	[Salary] [float] NULL,
	[EligibleLogin] [bit] NOT NULL,
	[E_Mail] [nvarchar](50) NULL,
	[BankAC] [nvarchar](50) NULL,
	[JoinDate] [date] NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmployeePersonalTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeProfessionalDetails]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeProfessionalDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_P_ID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Rank] [int] NOT NULL CONSTRAINT [DF_EmployeeProfessionalDetails_Rank]  DEFAULT ((2)),
	[Status] [bit] NOT NULL,
	[ProfilePic] [nvarchar](50) NULL,
	[EmpLeaveType] [int] NULL,
 CONSTRAINT [PK_EmployeeProfessionalDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeVacation]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeVacation](
	[ID] [int] NOT NULL,
	[FromDate] [date] NOT NULL,
	[ToDate] [date] NOT NULL,
	[Reason] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvoiceIItemTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceIItemTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[QTY] [decimal](18, 2) NOT NULL,
	[Rate] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_InvoiceIItemTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvoiceTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[Inv_refNo] [nvarchar](50) NOT NULL,
	[BillAmt] [float] NOT NULL,
	[SGST] [float] NOT NULL,
	[CGST] [float] NOT NULL,
	[Discount] [float] NOT NULL CONSTRAINT [DF_InvoiceTable_Discount]  DEFAULT ((0.0)),
	[IssueDate] [date] NOT NULL,
	[DeliveryAddress] [nvarchar](150) NULL,
	[ShippingCharges] [float] NOT NULL CONSTRAINT [DF_InvoiceTable_ShippingCharges]  DEFAULT ((0.0)),
	[MantainanceCharges] [float] NOT NULL CONSTRAINT [DF_InvoiceTable_MantainanceCharges]  DEFAULT ((0.0)),
	[AdditionalCharges] [float] NOT NULL CONSTRAINT [DF_InvoiceTable_AdditionalCharges]  DEFAULT ((0.0)),
	[Description] [nvarchar](150) NULL,
	[BilledBy] [int] NOT NULL,
	[StateCode] [nvarchar](50) NULL,
	[PlaceOfSupply] [nvarchar](50) NULL,
 CONSTRAINT [PK_InvoiceTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Qty] [decimal](18, 2) NOT NULL,
	[CP] [decimal](18, 2) NOT NULL,
	[SP] [decimal](18, 2) NOT NULL,
	[Status] [bit] NOT NULL CONSTRAINT [DF_ItemTable_Status]  DEFAULT ((1)),
	[HSN] [nvarchar](50) NOT NULL,
	[MaxDiscUpto] [decimal](18, 2) NOT NULL CONSTRAINT [DF_ItemTable_MaxDiscUpto]  DEFAULT ((0.0)),
	[LastModifiedBy] [int] NOT NULL,
	[LastModifiedDate] [date] NOT NULL CONSTRAINT [DF_ItemTable_LastModifiedDate]  DEFAULT (getdate()),
	[Description] [nvarchar](150) NULL,
	[WtPerPcs] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ItemTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaymentDescription]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDescription](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PayDtlsID] [int] NOT NULL,
	[PaymentTaken] [decimal](18, 2) NOT NULL,
	[AcceptedBy] [int] NOT NULL,
	[PayMode] [nvarchar](50) NOT NULL,
	[PaymentDate] [date] NOT NULL CONSTRAINT [DF_PaymentDescription_PaymentDate]  DEFAULT (getdate()),
	[ChequeNo] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_PaymentDescription] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaymentDetails]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[TotalAmt] [decimal](18, 2) NOT NULL,
	[Paid] [decimal](18, 2) NOT NULL CONSTRAINT [DF_PaymentDetails_Paid]  DEFAULT ((0.0)),
	[DueDate] [date] NULL,
	[Discount] [decimal](18, 2) NOT NULL CONSTRAINT [DF_PaymentDetails_Discount]  DEFAULT ((0.0)),
	[NextInstallmentDate] [date] NULL,
	[NextInstallmentSaidAmt] [decimal](18, 2) NULL CONSTRAINT [DF_PaymentDetails_NextInstallmentSaidAmt]  DEFAULT ((0)),
 CONSTRAINT [PK_PaymentDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseClientlDtlsTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseClientlDtlsTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MailingAddress] [nvarchar](150) NULL,
	[EMail] [nvarchar](50) NULL,
	[Phone] [nchar](11) NULL,
	[Mobile] [nchar](10) NOT NULL,
	[Fax] [nchar](15) NULL,
	[UIN] [nvarchar](50) NULL,
	[PAN_IT] [nvarchar](50) NULL,
	[AddedBy] [int] NOT NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_PurchaseClientlDtlsTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseInvoiceIItemTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInvoiceIItemTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[QTY] [decimal](18, 2) NOT NULL,
	[Rate] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_PurchaseInvoiceIItemTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseInvoiceTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInvoiceTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[Inv_refNo] [nvarchar](50) NOT NULL,
	[BillAmt] [decimal](18, 2) NOT NULL,
	[SGST] [decimal](18, 2) NOT NULL,
	[CGST] [decimal](18, 2) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[IssueDate] [date] NOT NULL,
	[ShippingCharges] [decimal](18, 2) NOT NULL,
	[MantainanceCharges] [decimal](18, 2) NOT NULL,
	[AdditionalCharges] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[DateOfReceive] [date] NULL,
 CONSTRAINT [PK_PurchaseInvoiceTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseItemTable]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseItemTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Qty] [decimal](18, 2) NOT NULL,
	[CP] [decimal](18, 2) NOT NULL,
	[Status] [bit] NOT NULL,
	[HSN] [nvarchar](50) NOT NULL,
	[stockedAt] [nvarchar](50) NULL,
	[LastModifiedBy] [int] NOT NULL,
	[LastModifiedDate] [date] NOT NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_PurchaseItemTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[additionalInfo] ([yrYR], [trial], [prefix], [suffix], [billCounter]) VALUES (N'_18-19', 0, N'AMW_', N'_18-19', 115)
SET IDENTITY_INSERT [dbo].[Attendence] ON 

INSERT [dbo].[Attendence] ([ID], [EmpPersonalID], [Date], [InTime], [InAttendBy], [OutTime], [OutAttendBy]) VALUES (1, 1, CAST(N'2018-09-15' AS Date), CAST(N'11:20:20' AS Time), 1, CAST(N'19:15:15' AS Time), 1)
INSERT [dbo].[Attendence] ([ID], [EmpPersonalID], [Date], [InTime], [InAttendBy], [OutTime], [OutAttendBy]) VALUES (5, 4, CAST(N'2018-09-15' AS Date), CAST(N'12:02:02' AS Time), 1, NULL, NULL)
INSERT [dbo].[Attendence] ([ID], [EmpPersonalID], [Date], [InTime], [InAttendBy], [OutTime], [OutAttendBy]) VALUES (15, 1, CAST(N'2018-09-16' AS Date), CAST(N'09:07:15' AS Time), 1, CAST(N'09:07:39' AS Time), 1)
SET IDENTITY_INSERT [dbo].[Attendence] OFF
SET IDENTITY_INSERT [dbo].[ClientlDtlsTable] ON 

INSERT [dbo].[ClientlDtlsTable] ([ID], [Name], [MailingAddress], [ShippingAddress], [EMail], [Phone], [Mobile], [Fax], [UIN], [PAN_IT], [AddedBy], [Description]) VALUES (3, N'General', NULL, NULL, NULL, NULL, N'9999999999', NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[ClientlDtlsTable] ([ID], [Name], [MailingAddress], [ShippingAddress], [EMail], [Phone], [Mobile], [Fax], [UIN], [PAN_IT], [AddedBy], [Description]) VALUES (4, N'Vikash steel', N'blah', N'blah', N'', N'           ', N'          ', N'               ', N'GST-1278654741-5', N'', 1, N'')
INSERT [dbo].[ClientlDtlsTable] ([ID], [Name], [MailingAddress], [ShippingAddress], [EMail], [Phone], [Mobile], [Fax], [UIN], [PAN_IT], [AddedBy], [Description]) VALUES (5, N'New store', N'WB', N'', N'', N'1234       ', N'          ', N'               ', N'', N'', 1, N'')
SET IDENTITY_INSERT [dbo].[ClientlDtlsTable] OFF
SET IDENTITY_INSERT [dbo].[EmployeePersonalTable] ON 

INSERT [dbo].[EmployeePersonalTable] ([ID], [Name], [DOB], [Mobile], [Address], [Alt_mobile], [Alt_add], [UIN], [DocType], [Salary], [EligibleLogin], [E_Mail], [BankAC], [JoinDate], [Photo]) VALUES (1, N'Bablu', NULL, N'7278133904', N'101 netaji subhas nagar colony', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[EmployeePersonalTable] ([ID], [Name], [DOB], [Mobile], [Address], [Alt_mobile], [Alt_add], [UIN], [DocType], [Salary], [EligibleLogin], [E_Mail], [BankAC], [JoinDate], [Photo]) VALUES (4, N'W', NULL, N'123456789 ', N'101', NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[EmployeePersonalTable] OFF
SET IDENTITY_INSERT [dbo].[EmployeeProfessionalDetails] ON 

INSERT [dbo].[EmployeeProfessionalDetails] ([ID], [Emp_P_ID], [UserName], [Password], [Rank], [Status], [ProfilePic], [EmpLeaveType]) VALUES (1, 1, N'bablu', N'1234', 1, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[EmployeeProfessionalDetails] OFF
SET IDENTITY_INSERT [dbo].[InvoiceIItemTable] ON 

INSERT [dbo].[InvoiceIItemTable] ([ID], [InvoiceID], [ItemID], [QTY], [Rate]) VALUES (2, 2, 1, CAST(2.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceIItemTable] ([ID], [InvoiceID], [ItemID], [QTY], [Rate]) VALUES (3, 3, 1, CAST(2.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceIItemTable] ([ID], [InvoiceID], [ItemID], [QTY], [Rate]) VALUES (1002, 4, 1, CAST(4.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceIItemTable] ([ID], [InvoiceID], [ItemID], [QTY], [Rate]) VALUES (1003, 5, 2, CAST(5.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)))
INSERT [dbo].[InvoiceIItemTable] ([ID], [InvoiceID], [ItemID], [QTY], [Rate]) VALUES (1004, 5, 1, CAST(2.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[InvoiceIItemTable] OFF
SET IDENTITY_INSERT [dbo].[InvoiceTable] ON 

INSERT [dbo].[InvoiceTable] ([ID], [ClientID], [Inv_refNo], [BillAmt], [SGST], [CGST], [Discount], [IssueDate], [DeliveryAddress], [ShippingCharges], [MantainanceCharges], [AdditionalCharges], [Description], [BilledBy], [StateCode], [PlaceOfSupply]) VALUES (2, 3, N'AMW_411_18-19', 202, 18.18, 18.18, 0, CAST(N'2019-06-05' AS Date), N'', 0, 0, 0, N'', 1, N'19        ', N'')
INSERT [dbo].[InvoiceTable] ([ID], [ClientID], [Inv_refNo], [BillAmt], [SGST], [CGST], [Discount], [IssueDate], [DeliveryAddress], [ShippingCharges], [MantainanceCharges], [AdditionalCharges], [Description], [BilledBy], [StateCode], [PlaceOfSupply]) VALUES (3, 3, N'AMW_412_18-19', 152, 13.68, 13.68, 0, CAST(N'2019-06-05' AS Date), N'', 0, 0, 0, N'', 1, N'19        ', N'')
INSERT [dbo].[InvoiceTable] ([ID], [ClientID], [Inv_refNo], [BillAmt], [SGST], [CGST], [Discount], [IssueDate], [DeliveryAddress], [ShippingCharges], [MantainanceCharges], [AdditionalCharges], [Description], [BilledBy], [StateCode], [PlaceOfSupply]) VALUES (4, 3, N'AMW_413_18-19', 405, 36.45, 36.45, 0, CAST(N'2019-06-18' AS Date), N'', 0, 0, 0, N'', 1, N'19        ', N'WB')
INSERT [dbo].[InvoiceTable] ([ID], [ClientID], [Inv_refNo], [BillAmt], [SGST], [CGST], [Discount], [IssueDate], [DeliveryAddress], [ShippingCharges], [MantainanceCharges], [AdditionalCharges], [Description], [BilledBy], [StateCode], [PlaceOfSupply]) VALUES (5, 3, N'AMW_111_18-19', 708, 63.72, 63.72, 0, CAST(N'2019-06-18' AS Date), N'', 0, 0, 0, N'', 1, N'19        ', N'')
SET IDENTITY_INSERT [dbo].[InvoiceTable] OFF
SET IDENTITY_INSERT [dbo].[ItemTable] ON 

INSERT [dbo].[ItemTable] ([ID], [Name], [Type], [Qty], [CP], [SP], [Status], [HSN], [MaxDiscUpto], [LastModifiedBy], [LastModifiedDate], [Description], [WtPerPcs]) VALUES (1, N'Aluminium Ingot', N'Machine', CAST(40.00 AS Decimal(18, 2)), CAST(49.00 AS Decimal(18, 2)), CAST(101.25 AS Decimal(18, 2)), 1, N'23', CAST(0.00 AS Decimal(18, 2)), 1, CAST(N'2019-06-05' AS Date), N'', CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[ItemTable] ([ID], [Name], [Type], [Qty], [CP], [SP], [Status], [HSN], [MaxDiscUpto], [LastModifiedBy], [LastModifiedDate], [Description], [WtPerPcs]) VALUES (2, N'Copper Bar', N'Bar', CAST(45.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(101.00 AS Decimal(18, 2)), 1, N'8765', CAST(0.00 AS Decimal(18, 2)), 1, CAST(N'2019-06-18' AS Date), N'', CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[ItemTable] OFF
SET IDENTITY_INSERT [dbo].[PaymentDescription] ON 

INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (2, 2, CAST(0.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), N'', NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (4, 3, CAST(0.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), N'', NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (9, 3, CAST(179.36 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (10, 2, CAST(138.36 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (11, 2, CAST(10.30 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (12, 2, CAST(89.65 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (13, 2, CAST(1.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-05' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (1009, 4, CAST(100.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-18' AS Date), N'', NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (1010, 4, CAST(377.90 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-18' AS Date), NULL, NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (1011, 5, CAST(100.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-18' AS Date), N'2323ddsfds', NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (1012, 5, CAST(300.00 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-18' AS Date), N'2335445454', NULL)
INSERT [dbo].[PaymentDescription] ([ID], [PayDtlsID], [PaymentTaken], [AcceptedBy], [PayMode], [PaymentDate], [ChequeNo], [Description]) VALUES (1013, 5, CAST(435.44 AS Decimal(18, 2)), 1, N'', CAST(N'2019-06-18' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[PaymentDescription] OFF
SET IDENTITY_INSERT [dbo].[PaymentDetails] ON 

INSERT [dbo].[PaymentDetails] ([ID], [InvoiceID], [TotalAmt], [Paid], [DueDate], [Discount], [NextInstallmentDate], [NextInstallmentSaidAmt]) VALUES (2, 2, CAST(238.36 AS Decimal(18, 2)), CAST(239.31 AS Decimal(18, 2)), CAST(N'2019-12-05' AS Date), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[PaymentDetails] ([ID], [InvoiceID], [TotalAmt], [Paid], [DueDate], [Discount], [NextInstallmentDate], [NextInstallmentSaidAmt]) VALUES (3, 3, CAST(179.36 AS Decimal(18, 2)), CAST(179.36 AS Decimal(18, 2)), CAST(N'2019-12-05' AS Date), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[PaymentDetails] ([ID], [InvoiceID], [TotalAmt], [Paid], [DueDate], [Discount], [NextInstallmentDate], [NextInstallmentSaidAmt]) VALUES (4, 4, CAST(477.90 AS Decimal(18, 2)), CAST(477.90 AS Decimal(18, 2)), CAST(N'2019-12-18' AS Date), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[PaymentDetails] ([ID], [InvoiceID], [TotalAmt], [Paid], [DueDate], [Discount], [NextInstallmentDate], [NextInstallmentSaidAmt]) VALUES (5, 5, CAST(835.44 AS Decimal(18, 2)), CAST(835.44 AS Decimal(18, 2)), CAST(N'2019-12-18' AS Date), CAST(0.00 AS Decimal(18, 2)), NULL, NULL)
SET IDENTITY_INSERT [dbo].[PaymentDetails] OFF
/****** Object:  Index [IX_Attendence]    Script Date: 6/18/2019 4:50:29 PM ******/
ALTER TABLE [dbo].[Attendence] ADD  CONSTRAINT [IX_Attendence] UNIQUE NONCLUSTERED 
(
	[Date] ASC,
	[EmpPersonalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_EmployeePersonalTable]    Script Date: 6/18/2019 4:50:29 PM ******/
ALTER TABLE [dbo].[EmployeePersonalTable] ADD  CONSTRAINT [IX_EmployeePersonalTable] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ItemTable_1]    Script Date: 6/18/2019 4:50:29 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ItemTable_1] ON [dbo].[ItemTable]
(
	[Name] ASC,
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable] ADD  CONSTRAINT [DF_PurchaseInvoiceTable_Discount]  DEFAULT ((0.0)) FOR [Discount]
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable] ADD  CONSTRAINT [DF_PurchaseInvoiceTable_ShippingCharges]  DEFAULT ((0.0)) FOR [ShippingCharges]
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable] ADD  CONSTRAINT [DF_PurchaseInvoiceTable_MantainanceCharges]  DEFAULT ((0.0)) FOR [MantainanceCharges]
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable] ADD  CONSTRAINT [DF_PurchaseInvoiceTable_AdditionalCharges]  DEFAULT ((0.0)) FOR [AdditionalCharges]
GO
ALTER TABLE [dbo].[PurchaseItemTable] ADD  CONSTRAINT [DF_PurchaseItemTable_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[PurchaseItemTable] ADD  CONSTRAINT [DF_PurchaseItemTable_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO
ALTER TABLE [dbo].[Attendence]  WITH CHECK ADD  CONSTRAINT [FK_Attendence_EmployeePersonalTable] FOREIGN KEY([EmpPersonalID])
REFERENCES [dbo].[EmployeePersonalTable] ([ID])
GO
ALTER TABLE [dbo].[Attendence] CHECK CONSTRAINT [FK_Attendence_EmployeePersonalTable]
GO
ALTER TABLE [dbo].[Attendence]  WITH CHECK ADD  CONSTRAINT [FK_Attendence_EmployeeProfessionalDetails] FOREIGN KEY([InAttendBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[Attendence] CHECK CONSTRAINT [FK_Attendence_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[Attendence]  WITH CHECK ADD  CONSTRAINT [FK_Attendence_EmployeeProfessionalDetails1] FOREIGN KEY([OutAttendBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[Attendence] CHECK CONSTRAINT [FK_Attendence_EmployeeProfessionalDetails1]
GO
ALTER TABLE [dbo].[ClientlDtlsTable]  WITH CHECK ADD  CONSTRAINT [FK_ClientlDtlsTable_EmployeeProfessionalDetails] FOREIGN KEY([AddedBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[ClientlDtlsTable] CHECK CONSTRAINT [FK_ClientlDtlsTable_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[EmployeeProfessionalDetails]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProfessionalDetails_EmployeePersonalTable] FOREIGN KEY([Emp_P_ID])
REFERENCES [dbo].[EmployeePersonalTable] ([ID])
GO
ALTER TABLE [dbo].[EmployeeProfessionalDetails] CHECK CONSTRAINT [FK_EmployeeProfessionalDetails_EmployeePersonalTable]
GO
ALTER TABLE [dbo].[InvoiceIItemTable]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceIItemTable_InvoiceTable] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceTable] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceIItemTable] CHECK CONSTRAINT [FK_InvoiceIItemTable_InvoiceTable]
GO
ALTER TABLE [dbo].[InvoiceIItemTable]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceIItemTable_ItemTable] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ItemTable] ([ID])
GO
ALTER TABLE [dbo].[InvoiceIItemTable] CHECK CONSTRAINT [FK_InvoiceIItemTable_ItemTable]
GO
ALTER TABLE [dbo].[InvoiceTable]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceTable_ClientlDtlsTable] FOREIGN KEY([ClientID])
REFERENCES [dbo].[ClientlDtlsTable] ([ID])
GO
ALTER TABLE [dbo].[InvoiceTable] CHECK CONSTRAINT [FK_InvoiceTable_ClientlDtlsTable]
GO
ALTER TABLE [dbo].[InvoiceTable]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceTable_EmployeeProfessionalDetails] FOREIGN KEY([BilledBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[InvoiceTable] CHECK CONSTRAINT [FK_InvoiceTable_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_ItemTable_EmployeeProfessionalDetails] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_ItemTable_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[PaymentDescription]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDescription_EmployeeProfessionalDetails] FOREIGN KEY([AcceptedBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[PaymentDescription] CHECK CONSTRAINT [FK_PaymentDescription_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[PaymentDescription]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDescription_PaymentDetails_cascade] FOREIGN KEY([PayDtlsID])
REFERENCES [dbo].[PaymentDetails] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaymentDescription] CHECK CONSTRAINT [FK_PaymentDescription_PaymentDetails_cascade]
GO
ALTER TABLE [dbo].[PaymentDetails]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetails_InvoiceTable] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[InvoiceTable] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaymentDetails] CHECK CONSTRAINT [FK_PaymentDetails_InvoiceTable]
GO
ALTER TABLE [dbo].[PurchaseClientlDtlsTable]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseClientlDtlsTable_EmployeeProfessionalDetails] FOREIGN KEY([AddedBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[PurchaseClientlDtlsTable] CHECK CONSTRAINT [FK_PurchaseClientlDtlsTable_EmployeeProfessionalDetails]
GO
ALTER TABLE [dbo].[PurchaseInvoiceIItemTable]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseInvoiceIItemTable_InvoiceTable] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[PurchaseInvoiceTable] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseInvoiceIItemTable] CHECK CONSTRAINT [FK_PurchaseInvoiceIItemTable_InvoiceTable]
GO
ALTER TABLE [dbo].[PurchaseInvoiceIItemTable]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseInvoiceIItemTable_ItemTable] FOREIGN KEY([ItemID])
REFERENCES [dbo].[PurchaseItemTable] ([ID])
GO
ALTER TABLE [dbo].[PurchaseInvoiceIItemTable] CHECK CONSTRAINT [FK_PurchaseInvoiceIItemTable_ItemTable]
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseInvoiceTable_ClientlDtlsTable] FOREIGN KEY([ClientID])
REFERENCES [dbo].[PurchaseClientlDtlsTable] ([ID])
GO
ALTER TABLE [dbo].[PurchaseInvoiceTable] CHECK CONSTRAINT [FK_PurchaseInvoiceTable_ClientlDtlsTable]
GO
ALTER TABLE [dbo].[PurchaseItemTable]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseItemTable_EmployeeProfessionalDetails] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[EmployeeProfessionalDetails] ([ID])
GO
ALTER TABLE [dbo].[PurchaseItemTable] CHECK CONSTRAINT [FK_PurchaseItemTable_EmployeeProfessionalDetails]
GO
/****** Object:  StoredProcedure [dbo].[AddAttendence]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddAttendence]
@empName nvarchar(50),
@date date,
@time Time,
@attendBy int
as
begin
	declare @AttID int, @empID int
	set @empID =(select id from EmployeePersonalTable where name=@empName)
	set @AttID=(select ISNULL(id,0) from Attendence where EmpPersonalID=@empID and Date=@date)
	if @AttID>0
		update Attendence set OutTime=@time, OutAttendBy=@attendBy where id=@AttID
	else
		insert into Attendence(Date,EmpPersonalID,InAttendBy,InTime) values(@date, @empID, @attendBy, @time)	
end

(select id from EmployeePersonalTable where name='Bablu')

GO
/****** Object:  StoredProcedure [dbo].[addInvoiceItems]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addInvoiceItems]
@invID int,
@itemName nvarchar(50),
@itemType nvarchar(50),
@QTY decimal,
@rate decimal
as
begin
declare @itemID as integer
set @itemID= (select id from ItemTable where Name=@itemName and Type=@itemType)
update ItemTable set Qty=qty-@QTY where id=@itemID
insert into InvoiceIItemTable(InvoiceID,ItemID,QTY,Rate) values(@invID,@itemID,@QTY,@rate)
select max(id) from InvoiceTable
end





GO
/****** Object:  StoredProcedure [dbo].[addNewClient]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addNewClient]
@Name	nvarchar(50),
@MailingAddress	nvarchar(150),
@ShippingAddress	nvarchar(150),
@EMail	nvarchar(50),
@Phone	nchar(11),
@Mobile	nchar(10),
@Fax	nchar(15),
@UIN	nvarchar(50),
@PAN_IT	nvarchar(50),
@AddedBy	int,
@Description	nvarchar(150)
as
begin
	insert into ClientlDtlsTable(name,MailingAddress,ShippingAddress,EMail,Phone,Mobile,Fax,UIN,PAN_IT,AddedBy,Description) 
						  values(@Name, @MailingAddress, @ShippingAddress, @EMail, @Phone, @Mobile, @Fax, @UIN, @PAN_IT, @AddedBy, @Description)	

end



GO
/****** Object:  StoredProcedure [dbo].[addNewInvoice]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addNewInvoice]
	@ClientName nvarchar(50),	
	@BillAmt float ,
	@SGST float ,
	@CGST float ,
	@Discount float NULL,	
	@DeliveryAddress nvarchar(150) NULL,
	@ShippingCharges float NULL,
	@MantainanceCharges float NULL,
	@AdditionalCharges float  NULL,
	@Description nvarchar(150) NULL,
	@BilledBy int ,
	@IssueDate date,
	@StateCode nchar(10) NULL,
	@PlaceOfSupply nvarchar(50) NULL,
	@IsChallan bit,
	@invNo nvarchar(30) null
	as
	begin
	
	if @IsChallan=1
		set @invNo=concat('WBill_',1+(select max(id) from InvoiceTable))	
	
	insert into InvoiceTable(ClientID,Inv_refNo,AdditionalCharges,BillAmt,BilledBy,CGST,DeliveryAddress,Description,Discount,MantainanceCharges,PlaceOfSupply,SGST,ShippingCharges,StateCode, IssueDate) 
					  values( (select id from ClientlDtlsTable where Name=@ClientName),@invNo,@AdditionalCharges,@BillAmt,@BilledBy,@CGST,@DeliveryAddress,@Description,@Discount,@MantainanceCharges,@PlaceOfSupply,@SGST,@ShippingCharges,@StateCode, @IssueDate) 		
	
	update additionalInfo set billCounter=billCounter+1

	select max(id) from InvoiceTable
	end
GO
/****** Object:  StoredProcedure [dbo].[addNewItem]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addNewItem](
@Name nvarchar(20),
@Type nvarchar(20),
@Qty decimal,
@HSN nvarchar(20) ,
@wtPerPc decimal,
@cp decimal,
@sp decimal,
@description nvarchar(50) null,
@user int
)
as
begin
insert into ItemTable(Name,Type,Qty,HSN,sp,cp,Description,LastModifiedBy, WtPerPcs) values(@Name,@Type,@Qty,@HSN,@sp,@cp,@description,@user, @wtPerPc)
end








GO
/****** Object:  StoredProcedure [dbo].[addNewpayDesc]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addNewpayDesc]
@PayDtlsID	int,
@PaymentTaken	float,
@AcceptedBy	int,
@PayMode	nvarchar(50),
@ChequeNo	nvarchar(50) null
as
begin
insert into PaymentDescription(PayDtlsID,AcceptedBy,ChequeNo,PaymentDate,PaymentTaken,PayMode)
						values(@PayDtlsID,@AcceptedBy,@ChequeNo,GETDATE(),@PaymentTaken,@PayMode)
end
	





GO
/****** Object:  StoredProcedure [dbo].[addPayDtls]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addPayDtls]
@InvoiceID	int,
@TotalAmt	float,
@Paid	float,
@DueDate	date null,
@Discount	float null,
@NextInstallmentDate	date,
@NextInstallmentSaidAmt	decimal(18,2) null
as
begin 
if @TotalAmt=@Paid
begin 
set @DueDate=GETDATE()
set @NextInstallmentDate=GETDATE()
set @NextInstallmentSaidAmt=0
end 
else

insert into PaymentDetails(InvoiceID,TotalAmt,Paid,DueDate,Discount,NextInstallmentDate,NextInstallmentSaidAmt)
					values(@InvoiceID,@TotalAmt,@Paid,@DueDate,@Discount,@NextInstallmentDate,@NextInstallmentSaidAmt)
select max(id) from PaymentDetails
end





GO
/****** Object:  StoredProcedure [dbo].[addPaymentDesc]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addPaymentDesc]
@payDtlsID int,
@amtReceived float,
@acceptedBy int,
@payMode nvarchar(50),
@chequeNo nvarchar(50) null,
@description nvarchar(500) null,
@nextPayAmt float null,
@nextDate date null
as
begin
	insert into PaymentDescription(AcceptedBy,ChequeNo,Description,PayDtlsID,PaymentDate,PaymentTaken,PayMode) 
							values(@acceptedBy,@chequeNo,@description,@payDtlsID,GETDATE(),@amtReceived,@payMode)
	update PaymentDetails set NextInstallmentDate=@nextDate, NextInstallmentSaidAmt=@nextPayAmt,Paid=Paid+@amtReceived where ID=@payDtlsID
end






GO
/****** Object:  StoredProcedure [dbo].[changeUserPass]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[changeUserPass]
@newPass nvarchar(50),
@oldUser nvarchar(50)
as
begin 
update EmployeeProfessionalDetails set  Password=@newPass where UserName=@oldUser
end



GO
/****** Object:  StoredProcedure [dbo].[clearedPayList]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[clearedPayList]
as
begin 
select i.Inv_refNo as 'Invoice No',i.IssueDate as 'Issue date', c.Name as 'Client name',p.TotalAmt as 'Billed Amt(₹)' from (InvoiceTable i join PaymentDetails p on p.InvoiceID=i.ID) join ClientlDtlsTable c on i.ClientID=c.ID where p.TotalAmt<=p.Paid
end





GO
/****** Object:  StoredProcedure [dbo].[duePayList]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[duePayList]
as
begin 
select  i.Inv_refNo as 'Invoice No',i.IssueDate as 'Issue date', c.Name as 'Client name', c.Phone as 'Phone No.',p.TotalAmt as 'Billed Amt(₹)', p.Paid as 'Paid(₹)',(p.TotalAmt-p.Paid) as 'Due(₹)', p.DueDate as 'Due Date', p.NextInstallmentDate as 'Next installment date', p.NextInstallmentSaidAmt as 'Next installment amt(₹)' from (InvoiceTable i join PaymentDetails p on p.InvoiceID=i.ID) join ClientlDtlsTable c on i.ClientID=c.ID where p.TotalAmt>p.Paid
end





GO
/****** Object:  StoredProcedure [dbo].[EditItem]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditItem](
@Name nvarchar(20),
@Type nvarchar(20),
@Qty decimal,
@HSN nvarchar(20) ,
@StockedAt nvarchar(20) null,
@cp decimal,
@sp decimal,
@description nvarchar(50) null,
@user int,
@itemID int
)
as
begin
update ItemTable set name=@Name,type=@Type,qty=@Qty,hsn=@HSN,stockedAt=@StockedAt,cp=@cp,sp= @sp,Description=@description,LastModifiedBy= @user where id=@itemID
end








GO
/****** Object:  StoredProcedure [dbo].[getAllItems]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getAllItems]
as
begin
select ROW_NUMBER() over (order by(select 1)) as 'SRNO', i.Name,i.Type,i.Qty,i.HSN,i.CP ,i.SP,i.WtPerPcs,e.UserName as 'Last modified by',i.LastModifiedDate,i.Description from ItemTable i join EmployeeProfessionalDetails e on i.LastModifiedBy=e.ID
end





GO
/****** Object:  StoredProcedure [dbo].[itemType]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[itemType]
@item nvarchar(50)
as
begin
select Type from ItemTable where Name=@item
end





GO
/****** Object:  StoredProcedure [dbo].[PROC_deleteExistingInvoioceOrChallan]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PROC_deleteExistingInvoioceOrChallan](
@BillRef nvarchar(50)
)
as
begin 	
	declare @itemID int, @qty int
	declare itemCursor cursor for
		select ItemID,QTY from InvoiceIItemTable where InvoiceID = (select id from InvoiceTable where Inv_refNo=@BillRef)

	open itemCursor
	fetch next from itemCursor into @itemID, @qty

	while @@FETCH_STATUS = 0
	begin
		update ItemTable set Qty=qty+@qty where ID=@itemID
		fetch next from itemCursor into @itemID, @qty
	end
	close itemCursor
	deallocate itemCursor

	delete from InvoiceTable where Inv_refNo=@BillRef
end



GO
/****** Object:  StoredProcedure [dbo].[ReportAttendence]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReportAttendence]
@empName nvarchar(50)
as
begin
	declare @empID as int
	set @empID=(select id from EmployeePersonalTable where name=@empName)	
	select intime ,ISNULL(OutTime,'00:00:00') as OutTime  from Attendence where (date=convert(date,GETDATE()) and EmpPersonalID=@empID)
end 

GO
/****** Object:  StoredProcedure [dbo].[resetSeq]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[resetSeq]
as
begin
alter sequence invoiceSequence restart
update additionalInfo set yrYR=(select( CONCAT(convert(nvarchar,(select (year (getdate() )%100))),'-', convert(nvarchar, (select (year (getdate() )%100+1))) )  ))
end



GO
/****** Object:  StoredProcedure [dbo].[ReurnItemQtyRate]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReurnItemQtyRate]
@item nvarchar(50),
@type nvarchar(50)
as
begin
select Qty,SP from ItemTable where Name=@item and Type=@type
end





GO
/****** Object:  StoredProcedure [dbo].[viewClients]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[viewClients]
as
begin
select c.Name,c.MailingAddress,c.Mobile,ROUND(isnull(Due,0),2 ) as 'Due(₹)' from ClientlDtlsTable c left outer join (select ClientID, SUM(p.TotalAmt)-sum(p.Paid) 'Due' from paymentDetails p join InvoiceTable i on p.InvoiceID=i.ID group by i.ClientID) r on r.ClientID=c.ID
end

 




GO
/****** Object:  StoredProcedure [dbo].[viewPayDtls]    Script Date: 6/18/2019 4:50:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[viewPayDtls]
@invNO nvarchar(50)
as
begin 
	select p.PaymentDate as 'Date', p.PaymentTaken as 'Amt accepted(₹)', p.PayMode as 'Payment mode',ISNULL(CONVERT(nvarchar(20), p.ChequeNo),'__') as 'Payment ID',ISNULL( p.Description,'___') as 'Description' from PaymentDescription p where p.PayDtlsID=(select id from PaymentDetails s where s.InvoiceID=(select id from InvoiceTable i where i.Inv_refNo=@invNO)) order by p.ID asc
	select c.Name,ISNULL(convert(nvarchar(20),c.Mobile),'___'),ISNULL(c.ShippingAddress,'___'), ISNULL(CONVERT(nvarchar(20),c.Phone),'___'), (i.BillAmt+i.SGST+i.CGST) from InvoiceTable i join ClientlDtlsTable c on i.ClientID=c.ID where Inv_refNo=@invNO
	select id from PaymentDetails s where s.InvoiceID=(select id from InvoiceTable i where i.Inv_refNo=@invNO)
end






GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 - shows for employee who get salary when holiday
2 - shows for employee who don''t get salary when holiday' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EmployeeProfessionalDetails', @level2type=N'COLUMN',@level2name=N'EmpLeaveType'
GO
USE [master]
GO
ALTER DATABASE [AMW] SET  READ_WRITE 
GO
