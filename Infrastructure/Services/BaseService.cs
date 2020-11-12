using DTO;

namespace Infrastructure.Services
{
    public abstract class BaseService
    {
        protected static ActiveUser ActiveUser { get; set; }
    }
}