namespace WebProgramlamaProje.Models
{
    public class UzmanlıkAlanlari
    {
        public int ID { get; set; }
        public string ad {  get; set; }
        public int sure { get; set; }
        public decimal fiyat { get; set; }

        public ICollection<CalisanUzmanlik> calisanlar { get; set; }

    }
}
