namespace GUI_Group_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dj
    {
        public int Id { get; set; }

        public int Customer_Id { get; set; }

        public string No_of_hours { get; set; }

        public string Meal { get; set; }

        public string otherfac { get; set; }
    }
}
