using BusinessObject.Models;
using DataAccess.ConstVariable;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace DataAccess.Context
{
    public class MongoDBContext : IdentityDbContext<User>
    {
        public IMongoCollection<User>? Users { get; set; }
        public IMongoCollection<Product> Products { get; set; }
        public IMongoCollection<Cart> Carts { get; set; }
        public IMongoCollection<Order> Orders { get; set; }

        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDBContext(DbContextOptions<MongoDBContext> options) : base(options)
        {
            _client = new MongoClient(ConstVarDB.connectionString);
            _database = _client.GetDatabase(ConstVarDB.databaseName);

            Users = _database.GetCollection<User>(ConstVarDB.UserCollection);
            Products = _database.GetCollection<Product>(ConstVarDB.ProductCollection);
            Carts = _database.GetCollection<Cart>(ConstVarDB.CartCollection);
            Orders = _database.GetCollection<Order>(ConstVarDB.OrderCollection);
        }

        public MongoDBContext() : this(new DbContextOptions<MongoDBContext>())
        {
        }
    }

}
