using Models.Models;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<_Year> Years { get; }
        IRepository<Governorate> Governorates { get; }
        IRepository<FarmType> FarmType { get; }
        IRepository<Farm> Farms { get; }
        IRepository<NewFarm> NewFarm { get; }
        IRepository<Vendor> Vendors { get; }
        IRepository<VendorGroup> VendorGroups { get; }
        IRepository<Customer> Customers { get; }
        IRepository<CustomerGroup> CustomerGroups { get; }
        IRepository<FarmAgeStandard> FarmAgeStandard { get; }
        IRepository<ItemGroup> ItemGroups { get; }
        IRepository<Item> Items { get; }
        IRepository<Store> Stores { get; }
        IRepository<Unit> Units { get; }
        IUnitConverter UnitsConverter { get; }
        IRepository<ExpenseGroup> ExpenseGroups { get; }
        IRepository<Expense> Expenses { get; }
        IRepository<Income> Incomes { get; }
        IRepository<IncomeGroup> IncomeGroups { get; }
        IPurchase PurchaseInvoiceDetails { get; }
        ISales SalesInvoiceDetails { get; }
        IRepository<PurchaseInvoiceHeader> PurchaseInvoiceHeader { get; }
        IRepository<SalesInvoiceHeader> SalesInvoiceHeader { get; }
        IStore StoreMovementDetails { get; }
        IRepository<StoreMovementHeader> StoreMovementHeader { get; }
        IRepository<VendorTransaction> VendorTransaction { get; }
        IRepository<CustomerTransaction> CustomerTransaction { get; }
        IPurchaseReverse PurchaseReverseDetails { get; }
        IRepository<PurchaseReverseHeader> PurchaseReverseHeader { get; }

        ISalesReverse SalesReverseDetails { get; }
        IRepository<SalesReverseHeader> SalesReverseHeader { get; }
        IRepository<Safe> Safe { get; }
        IRepository<Bank> Bank { get; }
        IReceiptSafe ReceiptSafeDetails { get; }
        IReceiptBank ReceiptBankDetails { get; }
        IRepository<ReceiptSafeHeader> ReceiptSafeHeader { get; }
        IRepository<ReceiptBankHeader> ReceiptBankHeader { get; }
  
        IPaymentSafe PaymentSafeDetails { get; }
        IPaymentBank PaymentBankDetails { get; }
        IRepository<PaymentSafeHeader> PaymentSafeHeader { get; }
        IRepository<PaymentBankHeader> PaymentBankHeader { get; }

        IBankTransactions BankTransactions { get; }
        ISafeTransactions SafeTransactions { get; }

        IRepository<MenuItem> MenuItems { get; }
        IRepository<SupplyDetails> SupplyDetails { get; }
        IRepository<SupplyHeader> SupplyHeader { get; }
        IRepository<ExchangeDetails> ExchangeDetails { get; }
        IRepository<ExchangeHeader> ExchangeHeader { get; }
        IRepository<ItemOpeningBalanceDetails> ItemOpeningBalanceDetails { get; }
        IRepository<ItemOpeningBalanceHeader> ItemOpeningBalanceHeader { get; }
        IRepository<VendorOpeningBalanceDetails> VendorOpeningBalanceDetails { get; }
        IRepository<VendorOpeningBalanceHeader> VendorOpeningBalanceHeader { get; }
        IRepository<CustomerOpeningBalanceDetails> CustomerOpeningBalanceDetails { get; }
        IRepository<CustomerOpeningBalanceHeader> CustomerOpeningBalanceHeader { get; }
        IRepository<SafeOpeningBalanceDetails> SafeOpeningBalanceDetails { get; }
        IRepository<SafeOpeningBalanceHeader> SafeOpeningBalanceHeader { get; }
        IRepository<BankOpeningBalanceDetails> BankOpeningBalanceDetails { get; }
        IRepository<BankOpeningBalanceHeader> BankOpeningBalanceHeader { get; }
        int CommitChanges();
    }
}
