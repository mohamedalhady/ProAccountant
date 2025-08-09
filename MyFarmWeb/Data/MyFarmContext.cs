using Humanizer;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Models.Interfaces;
using Models.Models;

using MyFarmWeb.Components.Account;
using MyFarmWeb.Repository;
using MyFarmWeb.Repository.Base;
using Radzen;
using System.Reflection.Emit;

namespace MyFarmWeb.Data
{
    public class MyFarmContext(DbContextOptions<MyFarmContext> options) : IdentityDbContext(options)
    {

        public DbSet<DataGridSetting> DataGridSettingModel { get; set; }
        public DbSet<DataGridColumnsFrozen> DataGridColumnsFrozen { get; set; }

        public DbSet<_Year> _Years { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public  DbSet<Dead> Deads { get; set; }
     public   DbSet<DirectExpenseDetails> DirectExpenseDetails { get; set; }
     public   DbSet<DirectExpenseHeader> DirectExpenseHeader { get; set; }
     public   DbSet<DirectIncomeDetails> DirectIncomeDetails { get; set; }
     public   DbSet<DirectIncomeHeader> DirectIncomeHeader { get; set; }
    
     public   DbSet<DocumentType> DocumentTypes { get; set; }
     public   DbSet<ExchangeDetails> ExchangeDetails { get; set; }
     public   DbSet<ExchangeHeader> ExchangeHeader { get; set; }
     public   DbSet<Expense> Expenses { get; set; }
     public   DbSet<ExpenseGroup> ExpenseGroups { get; set; }
     public   DbSet<Farm> Farms { get; set; }
     public   DbSet<FarmAgeStandard> FarmAgeStandards { get; set; }
     public   DbSet<FarmTransactionDetails> FarmTransactionDetails { get; set; }
     public   DbSet<FarmTransactionHeader> FarmTransactionHeader { get; set; }
     public   DbSet<FarmType> FarmTypes { get; set; }
     public   DbSet<FatteningPerformanceRate> FatteningPerformanceRate { get; set; }
     public   DbSet<Income> Incomes { get; set; }
     public   DbSet<IncomeGroup> IncomesGroups { get; set; }
     public   DbSet<Item> Items { get; set; }
     public   DbSet<ItemGroup> ItemsGroups { get; set; }
     public   DbSet<NewFarm> NewFarms { get; set; }
     public   DbSet<PaymentSafeDetails> PaymentSafeDetails { get; set; }
     public   DbSet<PaymentSafeHeader> PaymentSafeHeader { get; set; }
     public   DbSet<PaymentBankDetails> PaymentBankDetails { get; set; }
     public   DbSet<PaymentBankHeader> PaymentBankHeader { get; set; }
     public   DbSet<PurchaseInvoiceDetails> PurchaseInvoiceDetails { get; set; }
     public   DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeader { get; set; }
        public DbSet<PurchaseReverseDetails> PurchaseReverseDetails { get; set; }
        public DbSet<PurchaseReverseHeader> PurchaseReverseHeader { get; set; }
        public DbSet<SalesReverseDetails> SalesReverseDetails { get; set; }
        public DbSet<SalesReverseHeader> SalesReverseHeader { get; set; }
        public   DbSet<ReceiptSafeDetails> ReceiptSafeDetails { get; set; }
     public   DbSet<ReceiptSafeHeader> ReceiptSafeHeader { get; set; }
        public   DbSet<ReceiptBankDetails> ReceiptBankDetails { get; set; }
     public   DbSet<ReceiptBankHeader> ReceiptBankHeader { get; set; }
     public   DbSet<SalesInvoiceDetails> SalesInvoiceDetails { get; set; }
     public   DbSet<SalesInvoiceHeader> SalesInvoiceHeader { get; set; }
     public   DbSet<Store> Stores { get; set; }
     public   DbSet<StoreMovementDetails> StoreMovementDetails { get; set; }
     public   DbSet<StoreMovementHeader> StoreMovementHeader { get; set; }
     public   DbSet<StoreMovementType> StoreMovementTypes { get; set; }
     public   DbSet<SupplyDetails> SupplyDetails { get; set; }
     public   DbSet<SupplyHeader> SupplyHeader { get; set; }
     public   DbSet<TransferBetweenFarmsDetails> TransferBetweenFarmsDetails { get; set; }
     public   DbSet<TransferBetweenFarmsHeader> TransferBetweenFarmsHeader { get; set; }
     public   DbSet<Unit> Units { get; set; }
     public   DbSet<UnitsConverter> UnitsConverters { get; set; }
     public   DbSet<Vendor> Vendors { get; set; }
     public   DbSet<VendorGroup> VendorsGroup { get; set; }
        public DbSet<VendorTransaction> VendorTransactions { get; set; }
        public DbSet<CustomerTransaction> CustomerTransactions { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Safe> Safes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<SafeTransaction> SafeTransactions { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<BankOpeningBalanceDetails> BankOpeningBalanceDetails { get; set; }
        public DbSet<BankOpeningBalanceHeader> BankOpeningBalanceHeader { get; set; }
        public DbSet<SafeOpeningBalanceDetails> SafeOpeningBalanceDetails { get; set; }
        public DbSet<SafeOpeningBalanceHeader> SafeOpeningBalanceHeader { get; set; }
        public DbSet<ItemOpeningBalanceDetails> ItemOpeningBalanceDetails { get; set; }
        public DbSet<ItemOpeningBalanceHeader> ItemOpeningBalanceHeader { get; set; }
        public DbSet<CustomerOpeningBalanceDetails> CustomerOpeningBalanceDetails { get; set; }
        public DbSet<CustomerOpeningBalanceHeader> CustomerOpeningBalanceHeader { get; set; }
        public DbSet<VendorOpeningBalanceDetails> VendorOpeningBalanceDetails { get; set; }
        public DbSet<VendorOpeningBalanceHeader> VendorOpeningBalanceHeader { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        
            base.OnModelCreating(builder);
            
 

            builder.Entity<DirectExpenseHeader>().Property(x => x.DirectExpenseId).ValueGeneratedNever();
            builder.Entity<DirectIncomeHeader>().Property(x => x.DirectIncomeId).ValueGeneratedNever();
            builder.Entity<ExchangeHeader>().Property(x => x.ExchangeId).ValueGeneratedNever();
            builder.Entity<FarmTransactionHeader>().Property(x => x.TransactionId).ValueGeneratedNever();
            builder.Entity<PaymentSafeHeader>().Property(x => x.PaymentSafeId).ValueGeneratedNever();
            builder.Entity<PurchaseInvoiceHeader>().Property(x => x.PurchaseInvoiceId).ValueGeneratedNever();
            builder.Entity<PurchaseReverseHeader>().Property(x => x.PurchaseInvoiceId).ValueGeneratedNever();
            builder.Entity<ReceiptSafeHeader>().Property(x => x.ReceiptSafeId).ValueGeneratedNever();
            builder.Entity<ReceiptBankHeader>().Property(x => x.ReceiptBankId).ValueGeneratedNever();
            builder.Entity<PaymentBankHeader>().Property(x => x.PaymentBankId).ValueGeneratedNever();
            builder.Entity<SalesInvoiceHeader>().Property(x => x.SalesInvoiceId).ValueGeneratedNever();
            builder.Entity<SalesReverseHeader>().Property(x => x.SalesInvoiceId).ValueGeneratedNever();
            builder.Entity<StoreMovementHeader>().Property(x => x.MovementId).ValueGeneratedNever();
            builder.Entity<SupplyHeader>().Property(x => x.SupplyId).ValueGeneratedNever();
            builder.Entity<MenuItem>().Property(x => x.Id).ValueGeneratedNever();
            builder.Entity<BankOpeningBalanceHeader>().Property(x => x.BankBalanceId).ValueGeneratedNever();
            builder.Entity<SafeOpeningBalanceHeader>().Property(x => x.SafeBalanceId).ValueGeneratedNever();
            builder.Entity<ItemOpeningBalanceHeader>().Property(x => x.ItemBalanceId).ValueGeneratedNever();
            builder.Entity<CustomerOpeningBalanceHeader>().Property(x => x.CustomerBalanceId).ValueGeneratedNever();
            builder.Entity<VendorOpeningBalanceHeader>().Property(x => x.VendorBalanceId).ValueGeneratedNever();


        


            // builder.Entity<_Year>().Property(x => x.Year).ValueGeneratedNever();

            // set unicode(flase) for all column string
            foreach (var property in builder.Model.GetEntityTypes()
                 .SelectMany(e => e.GetProperties()
                     .Where(p => p.ClrType == typeof(string))))
            {
                property.SetIsUnicode(true);

            }
            //builder.Entity<FarmType>()
            //    .Property(e => e.FameTypeName)
            //    .IsUnicode(true);

            foreach (var relationalshib in builder.Model
               .GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationalshib.DeleteBehavior = DeleteBehavior.Restrict;
            }
            builder.Entity<Governorate>().HasData(new Governorate()
            {
                GovernorateId = 1,
                GovernorateName =  "الشرقية" 
            });

            builder.Entity<AccountType>().HasData
                (
                new AccountType() { AccountTypeId = 1 , AccountTypeName = "عميل"},
                new AccountType() { AccountTypeId = 2 , AccountTypeName = "مورد"},
                new AccountType() { AccountTypeId = 3 , AccountTypeName = "حساب"}
                );

            builder.Entity<FarmType>().HasData(new FarmType()
            {
                FarmTypeId = 1,
                FameTypeName = "تسمين ابيض"
            },new FarmType() { FarmTypeId = 2,FameTypeName = "تسمين ساسو"},new FarmType() { FarmTypeId = 3,FameTypeName = "تسمين بلدي"});
            builder.Entity<DocumentType>().HasData(
             new DocumentType() { DocumentTypeId = 1, DocumentTypeName = "فاتورة بيع" },
             new DocumentType() { DocumentTypeId = 2 , DocumentTypeName = "فاتورة مشتريات"},
             new DocumentType() { DocumentTypeId = 3, DocumentTypeName = "مصروف" },
             new DocumentType() { DocumentTypeId = 4, DocumentTypeName = "ايراد" },
             new DocumentType() { DocumentTypeId = 5, DocumentTypeName = "توريد مخزنى" },
             new DocumentType() { DocumentTypeId = 6, DocumentTypeName = "صرف مخزني" },
             new DocumentType() { DocumentTypeId = 7, DocumentTypeName = "مقبوض نقدي" },
             new DocumentType() { DocumentTypeId = 8, DocumentTypeName = "مدفوع نقدي" },
             new DocumentType() { DocumentTypeId = 9, DocumentTypeName = "مرتجع مبيعات" },
             new DocumentType() { DocumentTypeId = 10, DocumentTypeName = "مرتجع مشتريات" },
             new DocumentType() { DocumentTypeId = 11, DocumentTypeName = "مقبوض بنكي" } ,
             new DocumentType() { DocumentTypeId = 12, DocumentTypeName = "مدفوع بنكي" } ,
             new DocumentType() { DocumentTypeId = 13, DocumentTypeName = "رصيد افتتاحي" } 
            );
            builder.Entity<StoreMovementType>().HasData(new StoreMovementType() { TypeId = 1, TypeName = "وارد" }
            , new StoreMovementType() { TypeId = 2, TypeName = "منصرف" });

            builder.Entity<FarmAgeStandard>().HasData(new FarmAgeStandard() { FarmAgeId = 1,FarmTypeId = 1, StandardAge = 40 }, new FarmAgeStandard() { FarmAgeId = 2,FarmTypeId = 2, StandardAge = 65 },
                new FarmAgeStandard() { FarmAgeId = 3,FarmTypeId = 3, StandardAge = 40 });
         

       
           
        }
    }
}
