using System;

namespace Book.Models.ViewModels
{
    public class ErrorModel
    {
        public string RequestID { get; set; }
        public bool showRequestId => !string.IsNullOrEmpty(RequestID);
    }
}
