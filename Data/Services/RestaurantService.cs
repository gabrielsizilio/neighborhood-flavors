using Microsoft.EntityFrameworkCore;
namespace neighborhoodFlavors.Data;

public class RestaurantService
{
    private AppDbContext dbContext;

    public RestaurantService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Restaurant>> GetRestaurantsAsync()
    {
        return await dbContext.Restaurant.ToListAsync();
    }

    public async Task<Restaurant> AddRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            dbContext.Restaurant.Add(restaurant);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return restaurant;
    }

    public async Task<Restaurant> UpdateRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            var RestaurantExist = dbContext.Restaurant.FirstOrDefault(r => r.Id == restaurant.Id);
            if (RestaurantExist != null)
            {
                dbContext.Restaurant.Update(restaurant);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return restaurant;
    }

    public async Task DeleteRestaurantAsync(Restaurant restaurant)
    {
        try
        {
            dbContext.Restaurant.Remove(restaurant);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

}