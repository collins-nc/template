namespace template.core.services;

using Entities;
using interfaces;
using Microsoft.EntityFrameworkCore;

public class UserService : IUserService
{


    public async Task<List<Users>> GetUsers(AppDbContext dbContext)
    {
        return await dbContext.Users.ToListAsync();
    }
    public async Task<Users?> GetUser(AppDbContext dbContext, int id)
    {
        return await dbContext.Users.FirstOrDefaultAsync(p => p.Id == id);

    }
}
