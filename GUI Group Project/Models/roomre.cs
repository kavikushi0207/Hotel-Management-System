namespace GUI_Group_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roomre
    {
        public int Id { get; set; }

        public int Customer_Id { get; set; }

        public string AC_NONAC { get; set; }

        public string Size { get; set; }

        public string FloorLevel { get; set; }
    }
}
