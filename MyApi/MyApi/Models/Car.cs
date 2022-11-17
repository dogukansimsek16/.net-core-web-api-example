using MyApi.Context;
using MyApi.Models.Abstracts;
using MyApi.Models.Base;
using System.Linq.Expressions;

namespace MyApi.Models
{
  
    // Vehicle base classtan alınan Car sınıfı ve özellikleri
    public class Car : Vehicle
    {
        public bool Headlights { get; set; }
        public string Wheels { get; set; }
    }
}
