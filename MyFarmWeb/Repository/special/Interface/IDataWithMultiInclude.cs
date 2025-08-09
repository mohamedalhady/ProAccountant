using Models.Models;

namespace MyFarmWeb.Repository.special.Interface
{
    public interface IDataWithMultiInclude<T> where T : class
    {
        IEnumerable<T> GetDataWithMultiInclude(string UserId);   // GetDataWithMultiInclude
        IEnumerable<T> GetDataWithMultiIncludeById(int InvoiceID, string UserId); // GetDataWithMultiIncludeById
        IEnumerable<T> FilterDocumentData(string UserId,DateTime From , DateTime To ,int DocumntID, Dictionary<string, int[]> args); // FilterData

    }
}
