﻿namespace AdminThemeBC.Models
{
    public class CustomerModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string GSTNo { get; set; }
        public string CityName { get; set; }
        public string PinCode { get; set; }
        public double NetAmount { get; set; }
        public int UserID { get; set; }
    }

}
