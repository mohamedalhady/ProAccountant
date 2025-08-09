using Models.Models;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IGetDataForReport
    {
        IEnumerable<InvoiceForReport> GetDocumentDataForReport(string UserId);
        IEnumerable<InvoiceForReport> FilterDocumentDataForReport(int[] vendorid, int[] itemsid, int[] storeid, DateTime from, DateTime to, int invoiceid, string userid); // FilterData
        IEnumerable<AccountStatementReport> CreateAccountStatement(int[] mansid, DateTime from, DateTime to, string userid); // CreateAccountStatement
        IEnumerable<AccountStatementReport> CreateAccountStatement(int manid, DateTime from, DateTime to); // CreateAccountStatement

    }
}
