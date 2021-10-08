using Api.Helpers;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api.Models
{
    public class DataContext : DbContext {
        public DataContext (DbContextOptions options) : base (options) { }

		public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, AccountNo = "GR32882957347263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 2, AccountNo = "GR00324783252634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 3, AccountNo = "GR12309848325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 4, AccountNo = "GR12309845325290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 5, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 6, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 7, AccountNo = "GR32882957367263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 8, AccountNo = "GR00324783252634032", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 9, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 10, AccountNo = "GR12339845325290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 11, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 12, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 13, AccountNo = "GR32882957747263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 14, AccountNo = "GR00324783252631532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 15, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 16, AccountNo = "GR12309845329290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 17, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 18, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 19, AccountNo = "GR32882957387263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 20, AccountNo = "GR01324783252634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 21, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 22, AccountNo = "GR12309845305290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 23, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 24, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 25, AccountNo = "GR32882957347293523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 26, AccountNo = "GR00774783252634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 27, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 28, AccountNo = "GR12309840025290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 29, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 30, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 31, AccountNo = "GR32882957347063523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 32, AccountNo = "GR00324783992634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 33, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 34, AccountNo = "GR12309845005290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 35, AccountNo = "GR16632489265422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 36, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 37, AccountNo = "GR32882957227263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 38, AccountNo = "GR00324711152634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 39, AccountNo = "GR12309845325265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 40, AccountNo = "GR12309845325299065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 41, AccountNo = "GR16632489222422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 42, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 43, AccountNo = "GR32882957457263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 44, AccountNo = "GR00324443252634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 45, AccountNo = "GR12309845325265400", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 46, AccountNo = "GR12309845325200065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 47, AccountNo = "GR16632489765422345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 48, AccountNo = "GR72347888234865443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 49, AccountNo = "GR32882988347263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 50, AccountNo = "GR00324788852634532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 51, AccountNo = "GR12309845885265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 52, AccountNo = "GR12309845388290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 53, AccountNo = "GR16632489265882345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 54, AccountNo = "GR72347888234265443", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 55, AccountNo = "GR32882957388263523", Amount = 5000, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 56, AccountNo = "GR00324783252004532", Amount = 18500, UserId = 1, CreatedAt = DateTime.Now },
                new Account { Id = 57, AccountNo = "GR12309845112265443", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 58, AccountNo = "GR12309811325290065", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 59, AccountNo = "GR16632489261122345", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 60, AccountNo = "GR72347888237765464", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 61, AccountNo = "GR12309845325265492", Amount = 25450, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 62, AccountNo = "GR12309845325290023", Amount = 13670, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 63, AccountNo = "GR16632489265422388", Amount = 72344, UserId = 1, CreatedAt = DateTime.Now },
				new Account { Id = 64, AccountNo = "GR72347888234265464", Amount = 2114, UserId = 1, CreatedAt = DateTime.Now }
            );

            Utility.CreatePasswordHash("123456", out byte[] passwordHash, out byte[] passwordSalt);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, PasswordHash = passwordHash, PasswordSalt = passwordSalt, Role = "Admin", Username = "admin" },
                new User { Id = 2, PasswordHash = passwordHash, PasswordSalt = passwordSalt, Role = "Customer", Username = "customer" }
            );
        }
    }
}