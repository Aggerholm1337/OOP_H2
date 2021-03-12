using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Program
{
    public interface ISellerModel
    {
        int ZipCode { get; set; }

        string bidNotification();
    }
}
