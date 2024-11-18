using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data;

namespace LibrarySystem.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LSContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LSContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null LSContext");
                }
                if (context.Book.Any()) return;

                context.Book.AddRange(
                    new Book { Id = 1, Title = "The Lord of the Rings: The Fellowship of the Ring", Author = "J. R. R. Tolkien", Genre = "Fantasy", PublishedDate = DateTime.Parse("2023-01-01"), imgURL = "https://1.bp.blogspot.com/-3Qr51FbCt7A/UP-ccYH1e0I/AAAAAAAAA2w/2aM1a9ZcBnk/s1600/the-lord-of-the-rings-fellowship-of-the-rings_1.jpg"},
                    new Book { Id = 2, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Fantasy", PublishedDate = DateTime.Parse("2022-12-01"), imgURL = "https://dailytimes.com.pk/assets/uploads/2021/07/06/the-alchemist-a-graphic-novel-1017x1536.jpg"},
                    new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", PublishedDate = DateTime.Parse("2024-01-01"), imgURL = "https://cdn2.penguin.com.au/covers/original/9781784752637.jpg"},
                    new Book { Id = 4, Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Genre = "Science Fiction", PublishedDate = DateTime.Parse("2023-02-01"), imgURL = "https://4.bp.blogspot.com/_KFxmlXHAk1A/TT3xWKVzB9I/AAAAAAAACTE/NE4KyvH94ys/s1600/hitchhikers_guide_to_the_galaxy_v1.jpg"},
                    new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J. D. Salinger", Genre = "Coming-of-Age", PublishedDate = DateTime.Parse("2024-03-01"), imgURL = "https://i1.wp.com/bookstoker.com/wp-content/uploads/2019/03/The-Catcher-in-the-Rye-by-J.D.-Salinger.jpeg?fit=1089,1600&ssl=1"},
                    new Book { Id = 6, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", PublishedDate = DateTime.Parse("2023-04-01"), imgURL = "https://image.tmdb.org/t/p/original/ddzcKLZsz1Z3eGvSTrFYxFfCiJq.jpg"},
                    new Book { Id = 7, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", PublishedDate = DateTime.Parse("2022-11-01"), imgURL = "https://image.tmdb.org/t/p/original/vAxWpk857xbpaeoSvkRsfMbokPl.jpg"},
                    new Book { Id = 8, Title = "Animal Farm", Author = "George Orwell", Genre = "Allegory", PublishedDate = DateTime.Parse("2024-02-01"), imgURL = "https://upload.wikimedia.org/wikipedia/commons/f/fb/Animal_Farm_-_1st_edition.jpg"},
                    new Book { Id = 9, Title = "The Book Thief", Author = "Markus Zusak", Genre = "Historical Fiction", PublishedDate = DateTime.Parse("2023-03-01"), imgURL = "https://lumiere-a.akamaihd.net/v1/images/image_7324f2be.jpeg?region=0,0,1400,2100"},
                    new Book { Id = 10, Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", Genre = "Magical Realism", PublishedDate = DateTime.Parse("2022-10-01"), imgURL = "https://interactive.wttw.com/sites/default/files/one-hundred-years-of-solitude@2x.jpg"}
                );
                context.SaveChanges();
            }
        }
    }
}
