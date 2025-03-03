using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; }= null!;
        [Required]
        public string Email { get; set; }= null!;
        [Required]
        public string Password { get; set; }= null!;
    }
}
