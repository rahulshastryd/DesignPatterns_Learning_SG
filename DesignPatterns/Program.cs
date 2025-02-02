using DesignPatterns.Patterns.Builder.Classes;
using DesignPatterns.Patterns.CommandPattern.Classes.Invoker;
using DesignPatterns.Patterns.Factory.AbstractFactory.Factory;
using DesignPatterns.Patterns.Factory.AbstractFactory.Factory.DocumentFactory;
using DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces;
using DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces.IFormatter;
using DesignPatterns.Patterns.FluentBuilder.Classes;
using DesignPatterns.Patterns.FunctionalBuilder.Models;
using DesignPatterns.Patterns.LiskovSubstitutionPrinciple.Classes;
using DesignPatterns.Patterns.OpenClosedPrinciple.Class;
using DesignPatterns.Patterns.ProxyPattern.Models;
using DesignPatterns.Patterns.SRP;
using System;
using DesignPatterns.Patterns.CommandPattern.Classes.Models;
using System.Collections.Generic;
using DesignPatterns.Patterns.Adapter.Interfaces;
using DesignPatterns.Patterns.Adapter.Adapter;
using DesignPatterns.Patterns.Facade.FacadeClass;

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

            //Proxy Pattern 
            //Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            //Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            //FolderProxy folderProxy1 = new FolderProxy(emp1);
            //folderProxy1.PerformReadWriteOperatrion();
            //Console.WriteLine();
            //Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            //Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            //FolderProxy folderProxy2 = new FolderProxy(emp2);
            //folderProxy2.PerformReadWriteOperatrion();
            //Console.Read();

            // Factory Design Pattern
            Console.WriteLine("Select the Payment Gateway(PayPal, Stripe, CreditCard) :");
            string gatewayName = Console.ReadLine();
            try
            {
                IPaymentGateway paymentGateway = PaymentGateWayFactory.CreatePaymentGateway(gatewayName);
                paymentGateway.ProcessPayment(99.99M);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

            Console.WriteLine("Enter the content to convert");
            string content = Console.ReadLine();

            Console.WriteLine("Select the type format you want to convert(DOCX,PDF,TXT)");
            string fileFormat = Console.ReadLine();
            try
            {
                IDocumentConverter documentConverter = DocumentConverterFactory.CreateDocumentConverter(fileFormat);
                Console.WriteLine(documentConverter.Convert(content));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            //Command Pattern
            DineChef dineChef = new DineChef();
            dineChef.SetOrderCommand(1);
            dineChef.SetMenuItem(new MenuItem()
            {
                Item = "Vegetable Burger",
                Quantity = 1,
                TableNumber = 3,
                Tags = new List<Tag>
                {
                    new Tag() { TagName = "Jalapenos,"}, new Tag() { TagName = " Cheese," }, new Tag() { TagName = " Tomato" }
                }
            });
            dineChef.ExecuteCommand();

            dineChef.SetOrderCommand(1);
            dineChef.SetMenuItem(new MenuItem()
            {
                Item = "Veg Momos",
                Quantity = 2,
                TableNumber = 9,
                Tags = new List<Tag>
                {
                    new Tag() { TagName = "Jalapenos,"}, new Tag() { TagName = " Cheese," }, new Tag() { TagName = " Tomato" }
                }
            });

            //dineChef.SetOrderCommand(2);/* Modify Order */
            //dineChef.SetMenuItem(new MenuItem()
            //{
            //    TableNumber = 1,
            //    Item = "Super Mega Burger",
            //    Quantity = 1,
            //    Tags = new List<Tag>() { new Tag() { TagName = "Jalapenos," }, new Tag() { TagName = " Cheese" } }
            //});
            //dineChef.ExecuteCommand();

            //dineChef.ExecuteCommand();
            //dineChef.ShowCurrentOrder();

            //Adapter Pattern 
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget employeeAdapter = new EmployeeAdapter();
            employeeAdapter.ProcessCompanySalary(employeesArray);
            Console.Read();

            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
