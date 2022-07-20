using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
  public class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    public readonly HotelListingDbContext _context;

    public GenericRepository(HotelListingDbContext context)
    {
      this._context = context;
    }

    public async Task<T> AddAsync(T entity)
    {
      await _context.AddAsync(entity);
      await _context.SaveChangesAsync();
      return entity;
    }

    public async Task<List<T>> GetAllAsync()
    {
      return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetAsync(int? id)
    {
      if (id is null)
      {
        return null;
      }
      return await _context.Set<T>().FindAsync(id);
    }

    public Task DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
      throw new NotImplementedException();

    }
    public Task<bool> Exists(int id)
    {
      throw new NotImplementedException();
    }
  }
}