using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoojinProject1.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MessageBody { get; set; }
        public string Email { get; set; }

        public int DateTime { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
