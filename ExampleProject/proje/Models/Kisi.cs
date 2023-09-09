using System.ComponentModel.DataAnnotations;

namespace proje.Models
{
    public class Kisi
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }

    }
}
