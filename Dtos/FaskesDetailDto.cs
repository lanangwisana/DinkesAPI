namespace DinkesAPI.Dtos
{
    public class FaskesDetailDto
    {
        public string ID_faskes { get; set; }
        public string? nama_faskes { get; set; }
        public string? jenis_faskes { get; set; }
        public string? alamat_faskes { get; set; }
        public int dokter { get; set; }
        public int perawat { get; set; }
        public int bidan { get; set; }
    }
}