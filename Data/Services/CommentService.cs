namespace neighborhoodFlavors.Data;

public class CommentService
{
    private AppDbContext dbContext;

    public CommentService(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}