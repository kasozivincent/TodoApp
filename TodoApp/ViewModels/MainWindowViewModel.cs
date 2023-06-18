using Prism.Mvvm;
using System.Collections.Generic;
using TodoApp.Model;
using TodoApp.Services;

namespace TodoApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly DataProvider dataProvider;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private List<TodoItem> todoItem = new();
        public List<TodoItem> TodoItems
        {
            get { return todoItem; }
            set { SetProperty(ref todoItem, value); }
        }

        public MainWindowViewModel(DataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
            TodoItems = dataProvider.Read();
        }
    }
}
