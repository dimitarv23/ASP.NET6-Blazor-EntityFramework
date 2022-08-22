using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                       serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book { Title = "Tiny C# Projects", Author = "TutorialsEU", CallNumber = "AXD 2029" },
                    new Book { Title = "Tiny Android Projects", Author = "TutorialsEU", CallNumber = "AKQ 3018" });
                context.SaveChanges();
            }
        }
    }
}
