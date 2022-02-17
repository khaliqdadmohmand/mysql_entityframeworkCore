using System.ComponentModel.DataAnnotations;

namespace mysqldemo.Models
{
    public class table1
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone  { get; set; }
    }
}
