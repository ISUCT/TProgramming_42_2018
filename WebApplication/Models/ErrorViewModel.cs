using System;

namespace WebApplication.Models
{

     //иерархия наследования Abp.Сеть.Mvc.Модели .ErrorViewModel
    public class ErrorViewModel//модель исключений
    {
        public string RequestId { get; set; }//параметр???

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);//IsNullOrEmpty проверяет являится ли строка null
    }
}