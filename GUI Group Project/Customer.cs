namespace GUI_Group_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int CustomerId { get; set; }

        public string First_Name { get; set; }

        public string Second_Name { get; set; }

        public string NIC { get; set; }

        public string Contact_No { get; set; }
    }
}
