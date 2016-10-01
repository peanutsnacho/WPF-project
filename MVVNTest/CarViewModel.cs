﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVNTest
{
    public class CarViewModel :INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private ICar _car;

        public CarViewModel(ICar car)
        {
            _car = car;
            Validate();
        }

        public int CarID
        {
            get { return _car.CarID; }
            set { _car.CarID = value; RaisePropertyChanged("CarID"); }
        }

        public string Name
        {
            get { return _car.Name; }
            set { _car.Name = value; RaisePropertyChanged("Name"); }
        }

        public IProducer Producer
        {
            get { return _car.Producer; }
            set { _car.Producer = value; RaisePropertyChanged("Producer"); }
        }

        public float Price
        {
            get { return _car.Price; }
            set { _car.Price = value; RaisePropertyChanged("Price"); }
        }

        public int ProdYear
        {
            get { return _car.ProdYear; }
            set { _car.ProdYear = value; RaisePropertyChanged("ProdYear"); }
        }

        public string Color
        {
            get { return _car.Color; }
            set { _car.Color = value; RaisePropertyChanged("Color"); }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                Validate();
            }
        }

        private Dictionary<string, List<string>> _validationErrors =
            new Dictionary<string, List<string>>();

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || !_validationErrors.ContainsKey(propertyName))
                return null;
            return _validationErrors[propertyName];
        }

        public bool HasErrors
        {
            get { return _validationErrors.SelectMany(x => x.Value).ToList().Count > 0; }
        }

        public void Validate()
        {
            List<string> errors = new List<string>();
            if (this.Name == null)
            {
                errors.Add("Name cannot be null");
            }
            else
            {
                if (this.Name.Length < 3)
                {
                    errors.Add("Name must be longer than 3 characters");
                }
            }
            _validationErrors["Name"] = errors;

            errors = new List<string>();

            if (this.Price < 10)
            {
                errors.Add("Price cannot be less then 10");
            }
            if (this.Price < 5)
            {
                errors.Add("Price cannot be lett then 5");
            }
            _validationErrors["Price"] = errors;
        }

    }
}
