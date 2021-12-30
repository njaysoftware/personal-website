using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class Admins
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string Password {get; set;}
        public bool Disabled {get; set;}

        // @TODO I'm Okay leaving this as a string for now... But it might be standard enough to make into a POCO later
        [Column(TypeName = "jsonb")]
        public string Perms { get; set; }

        // @TODO Can these be abstracted away because we want them on every entity
        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public DateTime CreatedInfo {get; set;}

        // @TODO Can these be abstracted away because we want them on every entity
        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public DateTime UpdatedInfo {get; set;}

        public Post[] Posts {get; set;}
    }
}