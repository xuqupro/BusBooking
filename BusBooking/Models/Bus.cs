using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace BusBooking.Models
{
    [Table("bookingbus.bus")]
    public class Bus
    {
        [Key]
        public int IdBus { get; set; }
        [StringLength(64)]
        public string LicencePlates { get; set; }
        [StringLength(64)]
        public string Color { get; set; }
        public string DriverName { get; set; }
    }
}