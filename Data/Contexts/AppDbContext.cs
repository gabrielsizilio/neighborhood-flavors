using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<Menu> Menu { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Restaurant> Restaurant { get; set; }
    public DbSet<ItemMenu> ItemMenus { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.Menus)
            .WithOne() 
            .HasForeignKey(m => m.RestaurantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Menu>()
            .HasMany(m => m.Comments)
            .WithOne()
            .HasForeignKey(c => c.MenuId)
            .OnDelete(DeleteBehavior.Cascade); 

        modelBuilder.Entity<Menu>()
            .HasMany(m => m.Ratings)
            .WithOne()
            .HasForeignKey(r => r.MenuId)
            .OnDelete(DeleteBehavior.Cascade); 

        modelBuilder.Entity<Menu>()
            .HasMany(m => m.ItemMenus)
            .WithOne(im => im.Menu)
            .HasForeignKey(im => im.MenuId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ItemMenu>()
        .HasKey(im => new { im.Id });  

        modelBuilder.Entity<ItemMenu>()
            .HasOne(im => im.Menu)
            .WithMany(m => m.ItemMenus)
            .HasForeignKey(im => im.MenuId);  

        modelBuilder.Entity<ItemMenu>()
            .HasOne(im => im.Item)
            .WithMany(i => i.ItemMenus)
            .HasForeignKey(im => im.ItemId);


        // Adicionar dados de outras entidades
        modelBuilder.Entity<Restaurant>().HasData(RetornaRestaurant());
        modelBuilder.Entity<Menu>().HasData(RetornaMenu());
        modelBuilder.Entity<Item>().HasData(RetornaItem());
        modelBuilder.Entity<ItemMenu>().HasData(RetornaItensMenu());
        modelBuilder.Entity<User>().HasData(RetornaUser());
        modelBuilder.Entity<Comment>().HasData(RetornaComment());
        modelBuilder.Entity<Rating>().HasData(RetornaRating());

        base.OnModelCreating(modelBuilder);
    }

    private List<User> RetornaUser()
    {
        return new List<User>
        {
            new User { Id = 1, Name = "Suzy", Email = "suzy@gmail.com", Password = "senha123" },
            new User { Id = 2, Name = "Cozinharte", Email = "cozinharte@gmail.com", Password = "senha456" },
            new User { Id = 3, Name = "Filipe", Email = "filipe@gmail.com", Password = "123456" },
        };
    }

    private List<Restaurant> RetornaRestaurant()
    {
        return new List<Restaurant>
        {
            new Restaurant { Id = 1, Name = "Cozinharte", UserId = 2 },
            new Restaurant { Id = 2, Name = "Suzy", UserId = 1 }
        };
    }

    private List<Menu> RetornaMenu()
    {
        return new List<Menu>
        {
            new Menu { Id = 1, avgRating = 4.5 , RestaurantId = 1},  
            new Menu { Id = 2, avgRating = 4.0 , RestaurantId = 2},
            new Menu { Id = 3, avgRating = 4.75 , RestaurantId = 1} 
        };
    }

    private List<Item> RetornaItem()
    {
        return new List<Item>
        {
            new Item { Id = 1, ItemName = "Carne bovina" },
            new Item { Id = 2, ItemName = "Carne Suina" },
            new Item { Id = 3, ItemName = "Couve de Flor" },
            new Item { Id = 4, ItemName = "Arroz" }
        };
    }

    private List<ItemMenu> RetornaItensMenu()
    {
        return new List<ItemMenu>
        {
            new ItemMenu { Id= 1, ItemId = 1, MenuId = 1 },
            new ItemMenu { Id= 2, ItemId = 2, MenuId = 2 },
            new ItemMenu { Id= 3, ItemId = 3, MenuId = 1 },
            new ItemMenu { Id= 4, ItemId = 4, MenuId = 2 },
            new ItemMenu { Id= 5, ItemId = 1, MenuId = 3 },
            new ItemMenu { Id= 6, ItemId = 2, MenuId = 3 },
            new ItemMenu { Id= 7, ItemId = 3, MenuId = 3 },
            new ItemMenu { Id= 8, ItemId = 4, MenuId = 3 }
        };
    }

    private List<Comment> RetornaComment()
    {
        return new List<Comment>
        {
            new Comment { Id = 1, CommentText = "Comida muito boa!", PublishDate = DateTime.Now, MenuId = 1, UserId = 3 },
            new Comment { Id = 2, CommentText = "Atendimento excelente", PublishDate = DateTime.Now, MenuId = 2, UserId = 3 },
            new Comment { Id = 3, CommentText = "Pouca variedade de pratos", PublishDate = DateTime.Now, MenuId = 1, UserId = 3 },
            new Comment { Id = 4, CommentText = "Recomendo o restaurante", PublishDate = DateTime.Now, MenuId = 2, UserId = 3 }
        };
    }

    


    private List<Rating> RetornaRating()
    {
        return new List<Rating>
        {
            new Rating { Id = 1, Score = 5, MenuId = 1, UserId = 3 },
            new Rating { Id = 2, Score = 4, MenuId = 2, UserId = 3 },
            new Rating { Id = 3, Score = 3, MenuId = 1, UserId = 3 },
            new Rating { Id = 4, Score = 5, MenuId = 2, UserId = 3 }
        };
    }

}