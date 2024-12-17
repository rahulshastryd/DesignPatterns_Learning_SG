using DesignPatterns.Patterns.Builder.Classes;
using DesignPatterns.Patterns.FluentBuilder.Classes;
using DesignPatterns.Patterns.FunctionalBuilder.Models;
using DesignPatterns.Patterns.LiskovSubstitutionPrinciple.Classes;
using DesignPatterns.Patterns.OpenClosedPrinciple.Class;
using DesignPatterns.Patterns.SRP;
using System;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SRP
            var j = new Journal();
            j.AddEntry("I am learning");
            j.AddEntry("I am in the office");
            Console.WriteLine(j);

            //var p = new Persistance();
            //var filename = @"C:\Users\Rahul.Shastry\OneDrive - Scientific Games, LLC\Desktop";
            //p.SaveToFile(j,filename, true);

            //OCP
            var apple = new Product
            (
                "Apple",
                Color.red,
                Size.Small
            );
            var tree = new Product
            (
                "Tree",
                Color.green,
                Size.Large
            );
            var house = new Product
            (
                "House",
                Color.blue,
                Size.Huge
            );

            Product[] products = { apple, tree, house };
            var gf = new GenericFilter();
            Console.WriteLine("Green products");
            foreach (var p in gf.Filter(products,new ColorSpecification(Color.green)))
            {
                Console.WriteLine($"  - {p.Name} is green");
            }

            Console.WriteLine("    Huge blue items");
            foreach(var p in gf.Filter(products,new AndSpecification<Product>(new ColorSpecification(Color.blue),new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }


            static double Area(Rectangle r) => r.width * r.height;
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            // should be able to substitute a base type for a subtype
            /*Square*/
            Rectangle sq = new Square();
            sq.width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");

            //Builder Pattern
            // Create a Warrior
            Hero warrior = new HeroBuilder()
                .SetName("Aragorn")
                .SetClass("Warrior")
                .SetHealth(200)
                .SetAttack(50)
                .SetSpecialSkill("Sword Mastery")
                .Build();

            // Create a Mage
            Hero mage = new HeroBuilder()
                .SetName("Gandalf")
                .SetClass("Mage")
                .SetHealth(150)
                .SetAttack(70)
                .SetSpecialSkill("Fireball")
                .Build();

            // Print the heroes
            Console.WriteLine(warrior);
            Console.WriteLine(mage);

            // Build a Sword
            Weapon sword = new WeaponBuilder()
                .SetName("Excalibur")
                .SetDamage(100)
                .SetRange(1)
                .SetElement("Light")
                .Build();

            // Build a Bow
            Weapon bow = new WeaponBuilder()
                .SetName("Shadow Bow")
                .SetDamage(75)
                .SetRange(10)
                .SetElement("Darkness")
                .Build();

            // Build a Staff
            Weapon staff = new WeaponBuilder()
                .SetName("Elder Staff")
                .SetDamage(50)
                .SetRange(5)
                .SetElement("Fire")
                .Build();

            // Print the weapons
            Console.WriteLine(sword);
            Console.WriteLine(bow);
            Console.WriteLine(staff);

            //Functional Builder Pattern
            var equipment = new EquipmentBuilder()
                .Industry("Mining")
                .EquipmentType("Excavator")
                .EquipmentMake("JCB")
                .EquipmentModel("5Tx")
                .PurchaseYear(2025)
                .Build();

            Console.WriteLine(equipment.Industry + " " + equipment.Type + " " + equipment.Make + " " + equipment.Model + " " + equipment.PurchaseYear);
        }
    }
}
