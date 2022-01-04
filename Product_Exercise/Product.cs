using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Exercise
{
    enum Categories
    {
        Dairy, Fruit, Beverages, Bread

    }

    class Product
    {

        private decimal weight;
        private string name;
        private DateTime productionDate;
        private DateTime expirationDate;
        private string producer;
        private Categories category;

        public decimal Weight { get => weight; }
        public string Name { get => name; }
        public DateTime ProductionDate { get => productionDate; }
        public string Producer { get => producer; }
        public Categories Category { get => category; }


        public DateTime ExpirationDate {

            get
            {
                switch (category)
                {
                    case Categories.Dairy:
                        return productionDate.AddDays(7);

                        break;
                    case Categories.Fruit:

                        return productionDate.AddDays(2);
                        break;
                    case Categories.Beverages:

                        return productionDate.AddYears(3);
                        break;
                    case Categories.Bread:

                        return productionDate.AddDays(4);
                        break;
                    default:
                        return DateTime.Now;
                        break;
                }
            } 
        
        }

        public Product(string name, decimal weight, DateTime productionDate, string producer, Categories category)
        {
            this.name = name;
            this.weight = weight;
            this.productionDate = productionDate;
            this.producer = producer;
            this.category = category;

        }

    }
}
