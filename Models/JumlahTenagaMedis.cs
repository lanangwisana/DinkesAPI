namespace DinkesAPI.Models {
    public class JumlahTenagaMedis {
        public int ID_Jumlahtm { get; set; }
        public int dokter { get; set; }
        public int perawat { get; set; }
        public int bidan { get; set; }

        public int ID_faskes { get; set; }
        public Faskes? Faskes { get; set; }
    }
}