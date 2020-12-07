using System;
using System.Collections.Generic;

namespace RentalKendaraan_107.Models
{
    public partial class Costumer
    {
        public int IdCostumer { get; set; }
        public string NamaCostumer { get; set; }
        public string Nik { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public int? IdGender { get; set; }
    }
}
