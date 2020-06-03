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
using BLL.Abstract;
using DLL.IMPL.Service;

namespace trpz
{
    public class ViewM : INotifyPropertyChanged
    {
        Delivery delivery = new Delivery();

        IGoodService _goodService = new GoodService();
        IStorageService _storageService = new StorageService();
        IOrderService _orderService = new OrderService();




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
        public ObservableCollection<StorageDTO> StoragesVM{ get; set; }
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
                        OrderDTO newOrder = new OrderDTO
                        {
                            ID = OrdersVM.Count(),
                            NameCustomer = Сustomer,
                            TimeLeft = delivery.orderProcessing(SelectedStorage.Distance, SelectedGood.ExecutionTime),
                            GoodIN = SelectedGood.ID,
                            StorageIN = SelectedStorage.ID
                        };
                        OrdersVM.Insert(OrdersVM.Count, newOrder);
                        _orderService.Create(newOrder);
                    }));
            }
        }






        public ViewM()
        {
            GoodsVM = new ObservableCollection<GoodDTO>(_goodService.GetAll());
            StoragesVM = new ObservableCollection<StorageDTO>(_storageService.GetAll());
            OrdersVM = new ObservableCollection<OrderDTO>(_orderService.GetAll());
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
