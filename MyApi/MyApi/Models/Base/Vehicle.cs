using MyApi.Enums;
using MyApi.Models.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace MyApi.Models.Base
{
    // BASE MODEL
    public class Vehicle : IVehicle
    {
        [Key]
        public int Id { get; set; }
        public ColorEnum Color { get; set; }
        public string Name { get; set; }
    }
}
