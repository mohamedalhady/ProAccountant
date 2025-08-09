using Models.Models;
using MyFarmWeb.Data;
using MyFarmWeb.Repository.Base;
using MyFarmWeb.Repository.special.Class;
using MyFarmWeb.Repository.special.Interface;

namespace MyFarmWeb.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected MyFarmContext contextdb;
        public UnitOfWork(MyFarmContext myFarmContext)
        {
            contextdb = myFarmContext;
            Years = new MainRepository<_Year>(contextdb);
            Governorates = new MainRepository<Governorate>(contextdb);
            Customers = new MainRepository<Customer>(contextdb);
            FarmType = new MainRepository<FarmType>(contextdb);
            Farms = new MainRepository<Farm>(contextdb);
            NewFarm = new MainRepository<NewFarm>(contextdb);
            Vendors = new MainRepository<Vendor>(contextdb);
            VendorGroups = new MainRepository<VendorGroup>(contextdb);
            FarmAgeStandard = new MainRepository<FarmAgeStandard>(contextdb);
            ItemGroups = new MainRepository<ItemGroup>(contextdb);
            Items = new MainRepository<Item>(contextdb);
            Customers = new MainRepository<Customer>(contextdb);
            CustomerGroups = new MainRepository<CustomerGroup>(contextdb);
            Stores = new MainRepository<Store>(contextdb);
            Units = new MainRepository<Unit>(contextdb);
            ExpenseGroups = new MainRepository<ExpenseGroup>(contextdb);
            Expenses = new MainRepository<Expense>(contextdb);
            IncomeGroups = new MainRepository<IncomeGroup>(contextdb);
            Incomes = new MainRepository<Income>(contextdb);
            PurchaseInvoiceDetails = new Purchasespecial(contextdb);
            SalesInvoiceDetails = new Salesspecial(contextdb);
            PurchaseInvoiceHeader = new MainRepository<PurchaseInvoiceHeader>(contextdb);
            SalesInvoiceHeader = new MainRepository<SalesInvoiceHeader>(contextdb);
            StoreMovementDetails = new StoreSpecial(contextdb);
            StoreMovementHeader = new MainRepository<StoreMovementHeader>(contextdb);
            VendorTransaction = new MainRepository<VendorTransaction>(contextdb);
            CustomerTransaction = new MainRepository<CustomerTransaction>(contextdb);
            PurchaseReverseDetails = new PurchaseReverseSpecial(contextdb);
            PurchaseReverseHeader = new MainRepository<PurchaseReverseHeader>(contextdb);
            SalesReverseDetails = new SalesReverseSpecial(contextdb);
            SalesReverseHeader = new MainRepository<SalesReverseHeader>(contextdb);
            UnitsConverter = new UnitConvert(myFarmContext);
            Safe = new MainRepository<Safe>(myFarmContext);
            Bank = new MainRepository<Bank>(myFarmContext);
            ReceiptSafeHeader = new MainRepository<ReceiptSafeHeader>(myFarmContext);
            ReceiptBankHeader = new MainRepository<ReceiptBankHeader>(myFarmContext);
            ReceiptSafeDetails = new ReceiptSafeSpecial(myFarmContext);
            ReceiptBankDetails = new ReceiptBankSpecial(myFarmContext);
            PaymentSafeHeader = new MainRepository<PaymentSafeHeader>(myFarmContext);
            PaymentSafeDetails = new PaymentSafeSpecial(myFarmContext);
            PaymentBankHeader = new MainRepository<PaymentBankHeader>(myFarmContext);
            PaymentBankDetails = new PaymentBankSpecial(myFarmContext);
            BankTransactions = new BankTransactionsSpecial(myFarmContext);
            SafeTransactions = new SafeTransactionsSpecial(myFarmContext);
            MenuItems = new MainRepository<MenuItem>(myFarmContext);
            SupplyHeader = new MainRepository<SupplyHeader>(myFarmContext);
            SupplyDetails = new MainRepository<SupplyDetails>(myFarmContext);
            ExchangeHeader = new MainRepository<ExchangeHeader>(myFarmContext);
            ExchangeDetails = new MainRepository<ExchangeDetails>(myFarmContext);
            ItemOpeningBalanceHeader = new MainRepository<ItemOpeningBalanceHeader>(myFarmContext);
            ItemOpeningBalanceDetails = new MainRepository<ItemOpeningBalanceDetails>(myFarmContext);
            VendorOpeningBalanceHeader = new MainRepository<VendorOpeningBalanceHeader>(myFarmContext);
            VendorOpeningBalanceDetails = new MainRepository<VendorOpeningBalanceDetails>(myFarmContext);
            CustomerOpeningBalanceHeader = new MainRepository<CustomerOpeningBalanceHeader>(myFarmContext);
            CustomerOpeningBalanceDetails = new MainRepository<CustomerOpeningBalanceDetails>(myFarmContext);
            SafeOpeningBalanceHeader = new MainRepository<SafeOpeningBalanceHeader>(myFarmContext);
            SafeOpeningBalanceDetails = new MainRepository<SafeOpeningBalanceDetails>(myFarmContext);
            BankOpeningBalanceHeader = new MainRepository<BankOpeningBalanceHeader>(myFarmContext);
            BankOpeningBalanceDetails = new MainRepository<BankOpeningBalanceDetails>(myFarmContext);
        }

        public IRepository<_Year> Years { get; private set; }

        public IRepository<Governorate> Governorates { get;private set; }
        public IRepository<Customer> Customers { get; private set; }
        public IRepository<CustomerGroup> CustomerGroups { get; private set; }
        public IRepository<FarmType> FarmType { get; private set; }
        public IRepository<Farm> Farms { get; private set; }
        public IRepository<NewFarm> NewFarm { get; private set; }
        public IRepository<Vendor> Vendors { get; private set; }
        public IRepository<VendorGroup> VendorGroups { get; private set; }
        public IRepository<FarmAgeStandard> FarmAgeStandard { get; private set; }
        public IRepository<ItemGroup> ItemGroups { get; private set; }
        public IRepository<Item> Items { get; private set; }
        public IRepository<Store> Stores { get; private set; }
        public IRepository<Unit> Units { get; private set; }

        public IRepository<ExpenseGroup> ExpenseGroups { get; private set; }

        public IRepository<Expense> Expenses { get; private set; }

        public IRepository<Income> Incomes { get; private set; }

        public IRepository<IncomeGroup> IncomeGroups { get; private set; }
        public IPurchase PurchaseInvoiceDetails { get; private set; }
        public ISales SalesInvoiceDetails { get; private set; }
        public IRepository<SalesInvoiceHeader> SalesInvoiceHeader { get; private set; }

        public IPurchaseReverse PurchaseReverseDetails { get; private set; }
        public IRepository<PurchaseInvoiceHeader> PurchaseInvoiceHeader { get; private set; }
        public IRepository<PurchaseReverseHeader> PurchaseReverseHeader { get; private set; }

        public IStore StoreMovementDetails { get; private set; }
        public IRepository<StoreMovementHeader> StoreMovementHeader { get; private set; }
        public IRepository<VendorTransaction> VendorTransaction { get; private set; }
        public IRepository<CustomerTransaction> CustomerTransaction { get; private set; }

        public ISalesReverse SalesReverseDetails { get; private set; }

        public IRepository<SalesReverseHeader> SalesReverseHeader { get; private set; }
        public IUnitConverter UnitsConverter { get; private set; }
        public IRepository<Safe> Safe { get;private set; }
        public IRepository<Bank> Bank { get;private set; }

        public IReceiptSafe ReceiptSafeDetails { get; private set; }

        public IRepository<ReceiptSafeHeader> ReceiptSafeHeader { get; private set; }
        public IRepository<ReceiptBankHeader> ReceiptBankHeader { get; private set; }
        public ISafeTransactions SafeTransactions { get; private set; }
        public IBankTransactions BankTransactions { get; private set; }
        public IRepository<MenuItem> MenuItems { get; private set; }

        public IPaymentSafe PaymentSafeDetails { get; private set; }
        public IPaymentBank PaymentBankDetails { get; private set; }

        public IRepository<PaymentSafeHeader> PaymentSafeHeader { get; private set; }
        public IRepository<PaymentBankHeader> PaymentBankHeader { get; private set; }

        public IReceiptBank ReceiptBankDetails { get; private set; }

        public IRepository<SupplyDetails> SupplyDetails { get; private set; }

        public IRepository<SupplyHeader> SupplyHeader { get; private set; }

        public IRepository<ExchangeDetails> ExchangeDetails { get; private set; }

        public IRepository<ExchangeHeader> ExchangeHeader { get; private set; }

        public IRepository<ItemOpeningBalanceDetails> ItemOpeningBalanceDetails { get; private set; }

        public IRepository<ItemOpeningBalanceHeader> ItemOpeningBalanceHeader { get; private set; }

        public IRepository<VendorOpeningBalanceDetails> VendorOpeningBalanceDetails { get; private set; }

        public IRepository<VendorOpeningBalanceHeader> VendorOpeningBalanceHeader { get; private set; }

        public IRepository<CustomerOpeningBalanceDetails> CustomerOpeningBalanceDetails { get; private set; }

        public IRepository<CustomerOpeningBalanceHeader> CustomerOpeningBalanceHeader { get; private set; }

        public IRepository<SafeOpeningBalanceDetails> SafeOpeningBalanceDetails { get; private set; }

        public IRepository<SafeOpeningBalanceHeader> SafeOpeningBalanceHeader { get; private set; }

        public IRepository<BankOpeningBalanceDetails> BankOpeningBalanceDetails { get; private set; }

        public IRepository<BankOpeningBalanceHeader> BankOpeningBalanceHeader { get; private set; }

        public int CommitChanges()
        {
            return contextdb.SaveChanges();
        }

        public void Dispose()
        {
          contextdb.Dispose();
        }
    }
}
