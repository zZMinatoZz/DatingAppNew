using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface ICrudRepository
    {
        void Add<T>(T entity) where T: class;

        void Remove<T>(T entity) where T: class;

        Task<bool> SaveAll(); 
    }
}