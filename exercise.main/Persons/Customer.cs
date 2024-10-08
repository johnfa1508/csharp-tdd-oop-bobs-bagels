﻿using exercise.main.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Persons
{
    public class Customer : Person
    {
        #region
        private Basket _basket;
        public Basket Basket { get => _basket; }
        #endregion

        public Customer(string name, bool isManager) : base(name, isManager) 
        {
            _basket = new Basket();
        }
        public bool AddItemToBasket(Item item)
        {
            return _basket.Add(item);
        }

        public bool RemoveItemFromBasket(Item bagel)
        {
            return _basket.Remove(bagel);
        }

        public double GetTotalSumOfBasket()
        {
            return _basket.GetTotalSumOfBasket();
        }

        public double GetCostOfItem(Item item)
        {
            return item.Price;
        }

        public bool AddFillingToBagel(Bagel bagel, Filling filling)
        {
            return _basket.AddFillingToBagel(bagel, filling);
        }

        public bool ChangeBasketCapacity(Manager manager, int capacity) 
        {
            if (manager.IsManager)
            {
                _basket.Capacity = capacity;
                
                return true;
            }

            return false;
        }

        public Receipt Checkout(string shopName)
        {
            return _basket.Checkout(shopName);
        }
    }
}
