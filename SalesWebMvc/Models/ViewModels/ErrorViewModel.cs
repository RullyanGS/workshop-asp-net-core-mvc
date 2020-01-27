using System;

//namespace SalesWebMvc.Models.ViewModels
namespace SalesWebMvc
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}