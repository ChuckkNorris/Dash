using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash.ViewModels {
    public class ItemsViewModel {
        public ObservableCollection<Item> ItemCollection { get; set; }

        public ItemsViewModel() {
            ItemCollection = new ObservableCollection<Item>();
            AddItemCommand = new RelayCommand(AddNewItem);
            AddItems();
        }

        private void AddItems() {
            List<Item> itemsToAdd = new List<Item>() {
                new Item() {
                    Text = "Create Angular2 Architecture Document",
                    FileName = "Angular2.docx"
                },
                new Item() {
                    Text = "Create Angular2 Presentation for MeetUp",
                    FileName = "Angular2.pptx"
                }
            };
            foreach (var item in itemsToAdd) {
                this.ItemCollection.Add(item);
            }
        }

        

        public RelayCommand AddItemCommand { get; set; } 
        private void AddNewItem() {
            this.ItemCollection.Add(new Item());
        }
    }

    public class Item {
        public bool IsComplete { get; set; } = false;
        public string Text { get; set; }
        public string FileName { get; set; }
    }
}
