using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class BaseEntity
    {
        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public string? CreatedInfo {get; set;}


        // @TODO These should be standardized DTO objects see...https://www.npgsql.org/efcore/mapping/json.html?tabs=data-annotations%2Cpoco
        [Column(TypeName = "jsonb")]
        public string? UpdatedInfo {get; set;}
    }
    public class Post : BaseEntity
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Body {get; set;}
        public string Status {get; set;}

        public DateTime? PublishedAt {get; set;}
        public int[] AuthorIds {get; set;}
    }
    public class RecordInfo {
        public DateTime TimeStamp {get; set;}
        public int AdminId {get; set;}
    }
}