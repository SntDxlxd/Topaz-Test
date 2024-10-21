using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Test.Models;

namespace Test.ViewModels
{
    public class SomeViewModel : ViewModelBase
    {
        private string _data;

        public string Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        public ICommand GetDataCommand
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    var ds = new SomeSource();
                    Data = await ds.GetDataAsync(); // Получаем данные из пользовательской формы
                });
            }
        }
    }
}
