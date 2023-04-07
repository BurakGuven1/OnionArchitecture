using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Context
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; } //Order entitysine karşılık "Orders" diye bir tablo oluştursun. Modeli de entity'den alsın.
        public DbSet<Customer> Customers { get; set; }

        //bunlara her yerden erişmek için IoC container'a koyulmalı.
        //ETicaretAPI.API'ye bir şekil gönderilmesi lazım. Onion arch.'ta katmanlar arası bir şey gönderirken "Registration" sınıfını kullanırız. "ServiceRegistration" IoC'ye arayüzüne bir extension sağlıyor ( IServiceCollection services )
    }
}
