using System.Threading.Tasks;

namespace StudentAccounting.Core.Services.Abstractions
{
    public interface IUniqueCheckService
    {
        Task<bool> CheckAsync(object value);
    }
}
