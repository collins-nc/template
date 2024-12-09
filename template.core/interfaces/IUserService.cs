namespace template.core.interfaces;

using Entities;
using Microsoft.EntityFrameworkCore;

public interface IUserService
{
    Task<List<Users>> GetUsers(AppDbContext dbContext);
    
    Task<Users?> GetUser(AppDbContext dbContext, int id);
}
