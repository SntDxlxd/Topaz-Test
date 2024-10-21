using System;
using System.Collections.Generic;
using System.Text;
using Test.Views;
using System.Threading.Tasks;

namespace Test.Models
{
    public class SomeSource
    {
        private string inputValue;

        public async Task<string> GetDataAsync()
        {
            var inputForm = new InputForm();

            // Используем задачу для ожидания закрытия окна
            var tcs = new TaskCompletionSource<string>();
            inputForm.Closed += (sender, args) =>
            {
                tcs.SetResult(inputForm.InputText);  // Передаем введенные данные после закрытия
            };

            inputForm.Show();

            return await tcs.Task;  // Ждем закрытия формы и возвращаем данные
        }
    }
}
