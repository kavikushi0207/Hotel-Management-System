namespace GUI_Group_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hallre
    {
        public int Id { get; set; }

        public int Customer_Id { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Floor { get; set; }
    }
}
