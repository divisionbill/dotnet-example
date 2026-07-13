using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using Api.Controllers;
using Api.Models;
using Api.Context;

namespace Api.Tests;
public class UserControllerTests
{
    private UserController _controller;
    private AppDbContext _context;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "test_database")
            .Options;
        _context = new AppDbContext(options);
        _controller = new UserController(_context);

        SeedData();
    }

    [Test]
    public async Task Test_GetUsers()
    {
        var result = await _controller.GetUsers();
        var users = result.Value.ToList();
        Assert.AreEqual(2, users.Count);
    }

    // Add other test methods for CRUD operations

    private void SeedData()
    {
        var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
                new User { Id = 2, Name = "Alice Johnson", Email = "alice@example.com" }
            };
        _context.Users.AddRange(users);
        _context.SaveChanges();
    }
}
