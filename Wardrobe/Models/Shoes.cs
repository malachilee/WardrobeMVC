using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wardrobe.Models
{
    [MetadataType(typeof(Shometedata))]
    public partial class Shoes
    {
    }

    public class Shometedata
    {
        public int BottomsID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        public string Photo { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}