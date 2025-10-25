using System.ComponentModel.DataAnnotations;
namespace DinkesAPI.Models {
    public class JumlahTenagaMedis {
        [Key]
        public string ID_Jumlahtm { get; set; }
        
        public int dokter { get; set; }
        public int perawat { get; set; }
        public int bidan { get; set; }

        public string ID_faskes { get; set; }
        public Faskes? Faskes { get; set; }
    }
}