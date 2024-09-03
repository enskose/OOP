namespace _2_Ornekler
{

    public class Kitaplar
    {
        // Prop adı, class adı ile aynı olamaz

        public string kitapAdi { get; set; }
        public string yazar { get; set; }
        public string cevirmen { get; set; }
        public string yayinEvi { get; set; }
        public DateOnly baskiYili { get; set; }
        public string barkod { get; set; }
        public short sayfaSayisi { get; set; }

    }
}