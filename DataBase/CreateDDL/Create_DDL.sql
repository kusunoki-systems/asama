-- Project Name : �A�L�[�g
-- Date/Time    : 2017/11/22 18:47:18
-- Author       : fsiuser1
-- RDBMS Type   : Microsoft SQL Server 2008 �`
-- Application  : A5:SQL Mk-2

-- �x���`�[�{�f�B
create table T_PaymentBody (
  PaymentlNo VARCHAR(10) not null
  , PaymentBodyID INTEGER not null
  , ArrivalNo VARCHAR(10)
  , Arrival DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_PaymentBody_PKC primary key (PaymentlNo,PaymentBodyID)
) ;

-- �x���`�[�w�b�_�[
create table T_Payment (
  PaymentNo VARCHAR(10)
  , SupplierCd CHAR(6) not null
  , PaymentDate DATE
  , PaymentAmount DECIMAL
) ;

-- �����`�[�w�b�_�[
create table T_Nyukin (
  NyukinNo VARCHAR(10) not null
  , CustomerCd CHAR(6) not null
  , Amount DECIMAL not null
  , NyukinDate DATETIME not null
  , NyukinMethod NVARCHAR(100)
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_Nyukin_PKC primary key (NyukinNo)
) ;

-- ���ד`�[�{�f�B
create table T_ArrivalBody (
  ArrivalNo VARCHAR(10) not null
  , ArrivalBodyID INTEGER not null
  , ProductCd VARCHAR(20) not null
  , ProductName NVARCHAR(100)
  , Quantity INTEGER
  , Size NVARCHAR(4)
  , Color NVARCHAR(50)
  , RetailPrice DECIMAL
  , Price DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_ArrivalBody_PKC primary key (ArrivalNo,ArrivalBodyID)
) ;

-- ���ד`�[�w�b�_�[
create table T_ArrivalHeader (
  ArrivalNo VARCHAR(10)
  , SupplierCd CHAR(6) not null
  , ArrivalDate DATE
  , ArrivalAmount DECIMAL
) ;

-- ���i�}�X�^
create table M_PRODUCT (
  ProductCd VARCHAR(20) not null
  , MakerName NVARCHAR(100)
  , Season NVARCHAR(100)
  , MakerCd CHAR(6)
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint M_PRODUCT_PKC primary key (ProductCd)
) ;

-- ���[�J�[�}�X�^
create table M_MAKER (
  MakerCd CHAR(6) not null
  , MakerName NVARCHAR(100) not null
  , MakerContact NVARCHAR(max)
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint M_MAKER_PKC primary key (MakerCd)
) ;

-- �����`�[�{�f�B
create table T_InvoiceBody (
  HachuNo VARCHAR(10) not null
  , HachuBodyID INTEGER not null
  , ProductCd VARCHAR(20) not null
  , ProductName NVARCHAR(100)
  , Quantity INTEGER
  , Size NVARCHAR(4)
  , Color NVARCHAR(50)
  , RetailPrice DECIMAL
  , Price DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_InvoiceBody_PKC primary key (HachuNo,HachuBodyID)
) ;

-- �����`�[�w�b�_�[
create table T_InvoiceHeader (
  InvoiceNo VARCHAR(10)
  , CustomerCd CHAR(6) not null
  , InvoiceDate DATE
) ;

-- �󒍓`�[�{�f�B
create table T_HachuBody (
  HachuNo VARCHAR(10) not null
  , HachuBodyID INTEGER not null
  , ProductCd VARCHAR(20) not null
  , ProductName NVARCHAR(100)
  , Quantity INTEGER
  , Size NVARCHAR(4)
  , Color NVARCHAR(50)
  , RetailPrice DECIMAL
  , Price DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_HachuBody_PKC primary key (HachuNo,HachuBodyID)
) ;

-- �����`�[�w�b�_�[
create table T_HachuHeader (
  HachuNo VARCHAR(10)
  , SupplierCd CHAR(6) not null
  , HachuDate DATE
  , HachuAmount DECIMAL
  , OrderNo VARCHAR(10)
) ;

-- �o�ד`�[�{�f�B
create table T_DeliverBody (
  DeliverNo VARCHAR(10) not null
  , DeliverBodyID INTEGER not null
  , ProductCd VARCHAR(20) not null
  , ProductName NVARCHAR(100)
  , Quantity INTEGER
  , Size NVARCHAR(4)
  , Color NVARCHAR(50)
  , RetailPrice DECIMAL
  , Price DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_DeliverBody_PKC primary key (DeliverNo,DeliverBodyID)
) ;

-- �o�ד`�[�w�b�_�[
create table T_DeliverHeader (
  DeliverNo VARCHAR(10)
  , CustomerCd CHAR(6) not null
  , DeliverDate DATE
) ;

-- �󒍓`�[�{�f�B
create table T_JuchuBody (
  JuchuNo VARCHAR(10) not null
  , JuchuBodyID INTEGER not null
  , ProductCd VARCHAR(20) not null
  , ProductName NVARCHAR(100)
  , Quantity INTEGER
  , Size NVARCHAR(4)
  , Color NVARCHAR(50)
  , RetailPrice DECIMAL
  , Price DECIMAL
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint T_JuchuBody_PKC primary key (JuchuNo,JuchuBodyID)
) ;

-- �󒍓`�[�w�b�_�[
create table T_JuchuHeader (
  JuchuNo VARCHAR(10)
  , CustomerCd CHAR(6) not null
  , JuchuDate DATE
) ;

-- ���Ӑ�}�X�^
create table M_Customer (
  CustomerCd CHAR(6) not null
  , CustomerName NVARCHAR(100) not null
  , CustomerContact NVARCHAR(max)
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint M_Customer_PKC primary key (CustomerCd)
) ;

-- �d����}�X�^
create table M_SUPPLIER (
  SupplierCd CHAR(6) not null
  , SupplierName NVARCHAR(100) not null
  , SupplierContact NVARCHAR(max)
  , InsertedBy NVARCHAR(100)
  , InsertedAt DATETIME
  , UpdatedBy NVARCHAR(100)
  , UpdatedAt DATETIME
  , constraint M_SUPPLIER_PKC primary key (SupplierCd)
) ;

EXECUTE sp_addextendedproperty N'MS_Description', N'�x���`�[�{�f�B', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�x���`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'PaymentlNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�x���`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'PaymentBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'ArrivalNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���׋��z', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'Arrival';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_PaymentBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�x���`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_Payment', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�x���`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_Payment', N'COLUMN', N'PaymentNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�d����R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_Payment', N'COLUMN', N'SupplierCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'�x����', N'SCHEMA', N'dbo', N'TABLE', N'T_Payment', N'COLUMN', N'PaymentDate';
EXECUTE sp_addextendedproperty N'MS_Description', N'�x�����z', N'SCHEMA', N'dbo', N'TABLE', N'T_Payment', N'COLUMN', N'PaymentAmount';

EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'NyukinNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'CustomerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'Amount';
EXECUTE sp_addextendedproperty N'MS_Description', N'������', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'NyukinDate';
EXECUTE sp_addextendedproperty N'MS_Description', N'�������@', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'NyukinMethod';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_Nyukin', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[�{�f�B', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'ArrivalNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'ArrivalBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'ProductName';
EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'Quantity';
EXECUTE sp_addextendedproperty N'MS_Description', N'�T�C�Y', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'Size';
EXECUTE sp_addextendedproperty N'MS_Description', N'�J���[', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'Color';
EXECUTE sp_addextendedproperty N'MS_Description', N'���P��', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'RetailPrice';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'Price';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalHeader', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'���ד`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalHeader', N'COLUMN', N'ArrivalNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�d����R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalHeader', N'COLUMN', N'SupplierCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���ד�', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalHeader', N'COLUMN', N'ArrivalDate';
EXECUTE sp_addextendedproperty N'MS_Description', N'���׋��z', N'SCHEMA', N'dbo', N'TABLE', N'T_ArrivalHeader', N'COLUMN', N'ArrivalAmount';

EXECUTE sp_addextendedproperty N'MS_Description', N'���i�}�X�^', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'MakerName';
EXECUTE sp_addextendedproperty N'MS_Description', N'�V�[�Y��', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'Season';
EXECUTE sp_addextendedproperty N'MS_Description', N'���[�J�[�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'MakerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'M_PRODUCT', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'���[�J�[�}�X�^', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'���[�J�[�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'MakerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���[�J�[��', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'MakerName';
EXECUTE sp_addextendedproperty N'MS_Description', N'���[�J�[�A����', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'MakerContact';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'M_MAKER', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�{�f�B', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'HachuNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'HachuBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'ProductName';
EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'Quantity';
EXECUTE sp_addextendedproperty N'MS_Description', N'�T�C�Y', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'Size';
EXECUTE sp_addextendedproperty N'MS_Description', N'�J���[', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'Color';
EXECUTE sp_addextendedproperty N'MS_Description', N'���P��', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'RetailPrice';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'Price';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceHeader', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceHeader', N'COLUMN', N'InvoiceNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceHeader', N'COLUMN', N'CustomerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'������', N'SCHEMA', N'dbo', N'TABLE', N'T_InvoiceHeader', N'COLUMN', N'InvoiceDate';

EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�{�f�B', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'HachuNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'HachuBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'ProductName';
EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'Quantity';
EXECUTE sp_addextendedproperty N'MS_Description', N'�T�C�Y', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'Size';
EXECUTE sp_addextendedproperty N'MS_Description', N'�J���[', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'Color';
EXECUTE sp_addextendedproperty N'MS_Description', N'���P��', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'RetailPrice';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'Price';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�����`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', N'COLUMN', N'HachuNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�d����R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', N'COLUMN', N'SupplierCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'������', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', N'COLUMN', N'HachuDate';
EXECUTE sp_addextendedproperty N'MS_Description', N'�������z', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', N'COLUMN', N'HachuAmount';
EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�ԍ�:��=�����̏ꍇ', N'SCHEMA', N'dbo', N'TABLE', N'T_HachuHeader', N'COLUMN', N'OrderNo';

EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד`�[�{�f�B:', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'DeliverNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'DeliverBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'ProductName';
EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'Quantity';
EXECUTE sp_addextendedproperty N'MS_Description', N'�T�C�Y', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'Size';
EXECUTE sp_addextendedproperty N'MS_Description', N'�J���[', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'Color';
EXECUTE sp_addextendedproperty N'MS_Description', N'���P��', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'RetailPrice';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'Price';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverHeader', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverHeader', N'COLUMN', N'DeliverNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverHeader', N'COLUMN', N'CustomerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'�o�ד�', N'SCHEMA', N'dbo', N'TABLE', N'T_DeliverHeader', N'COLUMN', N'DeliverDate';

EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�{�f�B', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'JuchuNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[���הԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'JuchuBodyID';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'ProductCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���i��', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'ProductName';
EXECUTE sp_addextendedproperty N'MS_Description', N'����', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'Quantity';
EXECUTE sp_addextendedproperty N'MS_Description', N'�T�C�Y', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'Size';
EXECUTE sp_addextendedproperty N'MS_Description', N'�J���[', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'Color';
EXECUTE sp_addextendedproperty N'MS_Description', N'���P��', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'RetailPrice';
EXECUTE sp_addextendedproperty N'MS_Description', N'���z', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'Price';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuBody', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�w�b�_�[', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuHeader', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓`�[�ԍ�', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuHeader', N'COLUMN', N'JuchuNo';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuHeader', N'COLUMN', N'CustomerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'�󒍓�', N'SCHEMA', N'dbo', N'TABLE', N'T_JuchuHeader', N'COLUMN', N'JuchuDate';

EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�}�X�^', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'CustomerCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ於', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'CustomerName';
EXECUTE sp_addextendedproperty N'MS_Description', N'���Ӑ�A����', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'CustomerContact';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'M_Customer', N'COLUMN', N'UpdatedAt';

EXECUTE sp_addextendedproperty N'MS_Description', N'�d����}�X�^', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', NULL, NULL;
EXECUTE sp_addextendedproperty N'MS_Description', N'�d����R�[�h', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'SupplierCd';
EXECUTE sp_addextendedproperty N'MS_Description', N'�d���於', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'SupplierName';
EXECUTE sp_addextendedproperty N'MS_Description', N'�d����A����', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'SupplierContact';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ���', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'InsertedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�ǉ�����', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'InsertedAt';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V��', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'UpdatedBy';
EXECUTE sp_addextendedproperty N'MS_Description', N'�X�V����', N'SCHEMA', N'dbo', N'TABLE', N'M_SUPPLIER', N'COLUMN', N'UpdatedAt';

