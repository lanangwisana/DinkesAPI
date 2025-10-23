using System.ComponentModel.DataAnnotations;

namespace DinkesAPI.Models {
    public class Faskes {
        [Key]
        public int ID_faskes { get; set; }

        public string? nama_faskes { get; set; }
        public string? jenis_faskes { get; set; }
        public string? alamat_faskes { get; set; }

        public List<JumlahTenagaMedis>? JumlahTenagaMedis { get; set; }
    }
}