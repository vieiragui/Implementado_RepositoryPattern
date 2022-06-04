using System;
using TestandoRepositoryPattern.Model.Base;

namespace TestandoRepositoryPattern.Model
{
    public class Car : Entity
    {
        public string Name { get; set; }
        
        public string Model { get; set; }
        
        public int Year { get; set; }
        
        
        public Car(Guid id, string name, string model, int year) : base(id)
        {
            Name = name;
            Model = model;
            Year = year;
        }
    }
}