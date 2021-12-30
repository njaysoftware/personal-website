using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class Post
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Body {get; set;}
        public string Status {get; set;}

        // @TODO Can these be abstracted away because we want them on every entity
        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public DateTime CreatedInfo {get; set;}


        // @TODO Can these be abstracted away because we want them on every entity
        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public DateTime UpdatedInfo {get; set;}

        public DateTime? PublishedAt {get; set;}
        public int[] AuthorIds {get; set;}
    }
}