using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBuilderASSign
{
    public class Program
    {
        static void Main(string[] args)
        {
            MealBuilder builder;

            Sales sales = new Sales();

            builder= new MealOne();
            sales.Construct(builder);
            builder.Meal.Show();
            builder = new MealTwo();
            sales.Construct(builder);
            builder.Meal.Show();
            builder = new MealThree();
            sales.Construct(builder);
            builder.Meal.Show();

        }
    }
    class Sales
    {
        public void Construct(MealBuilder mealBuilder)
        {
            mealBuilder.BuildBurger();
            mealBuilder.BuildDessert();
            mealBuilder.BuildDrink();
            mealBuilder.BuildToy();
        }
    }
    abstract class MealBuilder
    {
        protected Meal meal;
        public Meal Meal
        {
            get
            {
                return meal;
            }
        }
        public abstract void BuildBurger();
        public abstract void BuildDessert();
        public abstract void BuildDrink();
        public abstract void BuildToy();
    }
    class MealOne : MealBuilder
    {
        public MealOne()
        {
            meal = new Meal("Combo Meal at 125");
        }
        public override void BuildBurger()
        {
            meal["burger"] = "Ham burger";
        }

        public override void BuildDessert()
        {
            meal["dessert"] = "French Fries";
        }

        public override void BuildDrink()
        {
            meal["drink"] = "Coco-Cola";
        }

        public override void BuildToy()
        {
            meal["toy"] = "Dinosaur";
        }
    }
    class MealTwo : MealBuilder
    {
        public MealTwo()
        {
            meal = new Meal("200 Meal");
        }
        public override void BuildBurger()
        {
            meal["burger"] = "Cheese burger";
        }

        public override void BuildDessert()
        {
            meal["dessert"] = "Donut";
        }

        public override void BuildDrink()
        {
            meal["drink"] = "Sprite";
        }

        public override void BuildToy()
        {
            meal["toy"] = "Car";
        }
    }
    class MealThree : MealBuilder
    {
        public MealThree()
        {
            meal = new Meal("Offer Meal");
        }
        public override void BuildBurger()
        {
            meal["burger"] = "Chicken burger";
        }

        public override void BuildDessert()
        {
            meal["dessert"] = "Cake";
        }

        public override void BuildDrink()
        {
            meal["drink"] = "Pepsi";
        }

        public override void BuildToy()
        {
            meal["toy"] = "Spin";
        }
    }
    class Meal
    {
        private string _mealType;
        public Meal(string mealType)
        {
            this._mealType= mealType;
        }
        private Dictionary<string, string> _items = new Dictionary<string, string>();
        public string this[string key]
        {
            get
            {
                return _items[key];
            }
            set
            {
                _items[key] = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Meal Type :{0}",_mealType);
            Console.WriteLine("Burger :{0}", _items["burger"]);
            Console.WriteLine("Dessert :{0}", _items["dessert"]);
            Console.WriteLine("Drink :{0}", _items["drink"]);
            Console.WriteLine("Toy :{0}", _items["toy"]);
        }
    }
}
