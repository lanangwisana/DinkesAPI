namespace DinkesAPI.Models {
    public class Faskes {
        public int ID_faskes { get; set; }
        public string? nama_faskes { get; set; }
        public string? jenis_faskes { get; set; }
        public string? alamat_faskes { get; set; }

        public JumlahTenagaMedis? JumlahTenagaMedis { get; set; }
    }
}