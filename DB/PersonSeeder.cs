using System;
namespace APIAssignment1 {
    public class PersonSeeder
{
    private readonly PersonContext _context;
    public PersonSeeder(PersonContext context)
    {
        _context = context;
    }
 
    public void SeedData()
    {
        AddNewType(new PostType { Id = 0, Name = "Standard" });
        AddNewType(new PostType { Id = 1, Name = "Aside" });
        AddNewType(new PostType { Id = 2, Name = "Snippet" });
        _context.SaveChanges();
    }
 
    // since we run this seeder when the app starts
    // we should avoid adding duplicates, so check first
    // then add
    private void AddNewType(PostType postType)
    {
        var existingType = _context.PostTypes.FirstOrDefault(p => p.Name == postType.Name);
        if(existingType == null)
        {
            _context.PostTypes.Add(postType);
        }
    }
}
}

