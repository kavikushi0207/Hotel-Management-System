namespace GUI_Group_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employer
    {
        public int EmployerID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string NIC { get; set; }

        public string Contact { get; set; }

        public string EmpRole { get; set; }
    }
}
