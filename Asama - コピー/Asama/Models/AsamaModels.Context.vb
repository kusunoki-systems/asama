﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはテンプレートから生成されました。
'
'     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
'     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property C__MigrationHistory() As DbSet(Of C__MigrationHistory)
    Public Overridable Property AspNetRoles() As DbSet(Of AspNetRoles)
    Public Overridable Property AspNetUserClaims() As DbSet(Of AspNetUserClaims)
    Public Overridable Property AspNetUserLogins() As DbSet(Of AspNetUserLogins)
    Public Overridable Property AspNetUsers() As DbSet(Of AspNetUsers)
    Public Overridable Property M_Color() As DbSet(Of M_Color)
    Public Overridable Property M_ColorType() As DbSet(Of M_ColorType)
    Public Overridable Property M_Customer() As DbSet(Of M_Customer)
    Public Overridable Property M_Item() As DbSet(Of M_Item)
    Public Overridable Property M_Maker() As DbSet(Of M_Maker)
    Public Overridable Property M_Season() As DbSet(Of M_Season)
    Public Overridable Property M_Size() As DbSet(Of M_Size)
    Public Overridable Property M_SizeType() As DbSet(Of M_SizeType)
    Public Overridable Property M_StaffBase() As DbSet(Of M_StaffBase)
    Public Overridable Property M_StaffPassword() As DbSet(Of M_StaffPassword)
    Public Overridable Property M_Supplier() As DbSet(Of M_Supplier)
    Public Overridable Property T_ArrivalBody() As DbSet(Of T_ArrivalBody)
    Public Overridable Property T_ArrivalHeader() As DbSet(Of T_ArrivalHeader)
    Public Overridable Property T_DeliverBody() As DbSet(Of T_DeliverBody)
    Public Overridable Property T_DeliverHeader() As DbSet(Of T_DeliverHeader)
    Public Overridable Property T_HachuBody() As DbSet(Of T_HachuBody)
    Public Overridable Property T_HachuHeader() As DbSet(Of T_HachuHeader)
    Public Overridable Property T_InvoiceBody() As DbSet(Of T_InvoiceBody)
    Public Overridable Property T_InvoiceHeader() As DbSet(Of T_InvoiceHeader)
    Public Overridable Property T_JuchuBody() As DbSet(Of T_JuchuBody)
    Public Overridable Property T_JuchuHeader() As DbSet(Of T_JuchuHeader)
    Public Overridable Property T_Nyukin() As DbSet(Of T_Nyukin)
    Public Overridable Property T_PaymentBody() As DbSet(Of T_PaymentBody)
    Public Overridable Property T_PaymentHeader() As DbSet(Of T_PaymentHeader)

End Class
