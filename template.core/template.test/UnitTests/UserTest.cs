namespace template.test.UnitTests;

using core;
using core.interfaces;
using core.services;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

public class UserTest(IDbContextFactory<AppDbContext> contextFactory,IServiceProvider serviceProvider)
{
    
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async void User(int id )
    {
        await using var dbContext = await contextFactory.CreateDbContextAsync();
        var service = serviceProvider.GetRequiredService<IUserService>();
        var user = service.GetUser(dbContext,id);

        user.Should().NotBeNull();
    }
}
