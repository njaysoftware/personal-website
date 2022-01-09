using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class Admin : BaseEntity
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string Password {get; set;}
        public bool Disabled {get; set;}

        // I guess I need anothe table to accomplish this.
        // public Post[] Posts {get; set;}
    }
}