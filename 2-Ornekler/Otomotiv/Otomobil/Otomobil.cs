namespace _2_Ornekler
{
    public class Otomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public KasaTipi KasaTipi { get; set; }
        public Vites Vites { get; set; }
        public DateOnly UretimYili { get; set; }
        public Cekis Cekis { get; set; }
        public YakitTipi YakitTipi { get; set; }
    }
}