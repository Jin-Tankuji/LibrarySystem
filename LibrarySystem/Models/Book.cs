using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author {  get; set; }
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
        public string imgURL { get; set; }
    }
}
