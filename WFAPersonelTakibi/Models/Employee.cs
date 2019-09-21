using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi.Models
{
    //public enum Gender    Gender a gelip sağ tık yap Quick action yap ve ilkine tıkla. otomatikman gender clası oluşturacak. Daha sonra   public Gender Gender { get; set; }  yazılır.

    //{
    //    Male, Female, Karışık  //Türkçe karakter kullanabiliriz.
    //}

    //public enum Gender
    //{
    //    Male, Female, Karışık
    //}
    public partial class Employee
    {

        public Guid Id { get; set; }
        [Required,MaxLength(50)]
        public string FirstName { get; set; }
        [Required,MaxLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EMail { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required, MaxLength(24)]
        public string Phone { get; set; }
        [Required,MaxLength(300)]
        public string Address { get; set; }
        [MaxLength(150)]
        public string Imageurl { get; set; }

    }
}
