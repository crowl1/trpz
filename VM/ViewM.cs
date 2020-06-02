using System;
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


        public ObservableCollection<OrderDTO> OrdersVM { get; set; }
        

        private OrderDTO _selectedOrder;
        public OrderDTO SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        private GoodDTO _selectedGood;
        public ObservableCollection<GoodDTO> GoodsVM { get; set; }
        public GoodDTO SelectedGood
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


        private StorageDTO _selectedStorage;
        public ObservableCollection<StorageDTO> StoragesVM { get; set; }
        public StorageDTO SelectedStorage
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
                        OrdersVM.Insert(OrdersVM.Count, new OrderDTO {ID = OrdersVM.Count(), NameCustomer = Сustomer, TimeLeft = delivery.orderProcessing(SelectedStorage.Distance, SelectedGood.ExecutionTime), GoodID = SelectedGood.ID, StarageID = SelectedStorage.ID });
                        Files<OrderDTO>.Write(OrdersVM, "\\order.json");
                    }));
            }
        }






        public ViewM()
        {
            if (OrdersVM == null)
            {
                GoodsVM = Files<GoodDTO>.Read("\\good.json");
                StoragesVM = Files<StorageDTO>.Read("\\storage.json");
                OrdersVM = Files<OrderDTO>.Read("\\order.json");
            }
            

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
