﻿namespace WebProgramlamaProje.Models
{
    public class CalisanUzmanlik
    {
        public int ID { get; set; }
        public int calisan_ID { get; set; }
        public int uzmanlik_ID { get; set; }

        public Calisanlar calisan {  get; set; }
        public UzmanlıkAlanlari uzmanlik { get; set; }


    }
}
