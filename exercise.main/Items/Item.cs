﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Items
{
    public abstract class Item
    {
        #region Properties
        private string _sku;
        private double _price;
        private double _originalPrice;
        private string _variant;
        private int _quantity;
        private double _moneySaved;

        public string Sku { get => _sku; set => _sku = value; }
        public double Price { get => _price; set => _price = value; }
        public double OriginalPrice { get => _originalPrice; set => _originalPrice = value; }
        public string Variant { get => _variant; set => _variant = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public double MoneySaved { get => _moneySaved; set => _moneySaved = value; }
        #endregion

        protected Item()
        {
        }
        
        protected Item(string skuID, double price, string variant)
        {
            _sku = skuID;
            _price = price;
            _variant = variant;
        }

        protected Item(string skuID) 
        {

        }

        public void CheckForDiscount()
        {
            if (_sku == "BGLO" | _sku == "BGLE")
            {
                _price = Math.Round((2.49 * (_quantity / 6)) + (_originalPrice * (_quantity % 6)), 2);
            } else if (_sku == "BGLP")
            {
                _price = Math.Round((3.99 * (_quantity / 12)) + (_originalPrice * (_quantity % 12)), 2);
            }

            _moneySaved = Math.Round((_originalPrice * _quantity) - _price, 2);
        }
    }
}
