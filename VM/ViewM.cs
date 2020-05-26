﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using M;
using Infrastructure;

namespace VM
{
    public class ViewM : INotifyPropertyChanged
    {
        static void Main(string[] args)
        {

        }
        Delivery delivery = new Delivery();


        public ObservableCollection<Order> OrdersVM { get; set; }
        

        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        private Good _selectedGood;
        public ObservableCollection<Good> GoodsVM { get; set; }
        public Good SelectedGood
        {
            get { return _selectedGood; }
            set
            {
                _selectedGood = value;
                OnPropertyChanged("SelectedGood");
            }
        }


        private string _customer;
        public string Сustomer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged("Сustomer");
            }

        }


        private Storage _selectedStorage;
        public ObservableCollection<Storage> StoragesVM { get; set; }
        public Storage SelectedStorage
        {
            get { return _selectedStorage; }
            set
            {
                _selectedStorage = value;
                OnPropertyChanged("SelectedStorage");
            }
        }




        private RelayCommand _addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        OrdersVM.Insert(0, new Order { NameCustomer = Сustomer, TimeLeft = delivery.orderProcessing(SelectedStorage.Distance, SelectedGood.ExecutionTime) });
                    }));
            }
        }






        public ViewM()
        {
            StoragesVM = new Storages();
            GoodsVM = new Goods();
            OrdersVM = new ObservableCollection<Order> { };

            SelectedStorage = StoragesVM.FirstOrDefault();
            SelectedGood = GoodsVM.FirstOrDefault();
            _customer = "Анонім";
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

    }
    
}
