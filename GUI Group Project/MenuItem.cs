namespace GUI_Group_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuItem
    {
        public int Id { get; set; }

        public string Meal_Type { get; set; }

        public string Item_Type { get; set; }

        public string Item_Name { get; set; }

        public string Item_Price { get; set; }
    }
}
