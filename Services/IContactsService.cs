using Business.DTOs;

namespace PortfolioFrontend.Services;

public interface IContactsService<T>
{
    Task<ServiceResponse> PostDataAsync(T model);
    // Task<IEnumerable<T>> GetContactsAsync();
}