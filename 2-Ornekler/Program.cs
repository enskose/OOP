using _2_Ornekler.Bilgisayarlar;

namespace _2_Ornekler
{
    
    class Program
    {
        // Struct'lar stack alanında tutulurken, Class'lar heap alanında tutulur.
        static void Main(string[] args)
        {
            #region Class Instance Alma
            // 1. yol
            Kitaplar kitap = new Kitaplar();
            kitap.kitapAdi = "Ince Memed";
            kitap.yazar = "Yasar Kemal";
            kitap.baskiYili = new DateOnly(1967, 1, 1);
            kitap.sayfaSayisi = 300;
            kitap.yayinEvi = "YapıKredi";

            // 2. yol Object initilation
            Kitaplar kitap2 = new Kitaplar()
            {
                yazar = "Orhan Pamuk",
                yayinEvi = "YapıKredi",
                kitapAdi = "Yeni Hayat",
                baskiYili = new DateOnly(2000, 1, 1),
                sayfaSayisi = 250,
                barkod = "123123123"
            };
            
            // enum içeren class'lardan instance alma
            Otomobil otomobil = new Otomobil();
            otomobil.KasaTipi = KasaTipi.Cabrio;
            otomobil.YakitTipi = YakitTipi.Benzin;
            otomobil.Cekis = Cekis.ArkadanItis;
            otomobil.Marka = "BMW";
            otomobil.Model = "3.20";

            // var kasalar = Enum.GetNames(typeof(KasaTipi));
            // foreach (var item in kasalar)
            // {
            //     Console.WriteLine(item);
            // }

            Anakart anakart = new Anakart()
            {
                AnakartMarka = "MSI",
                AnakartModel = "B450M Mortar Max",
            };

            Bellek bellek = new Bellek()
            {
                BellekKapasite = "32GB",
                BellekMarka = "HyperX",
                BellekModel = "Fury DDR4"
            };

            Depolama depolama = new Depolama()
            {
                DepolamaKapasite = "1TB",
                DepolamaMarka = "Samsung",
                DepolamaModel = "970 EVO Plus NVMe",
                DepolamaTur = "SSD",
            };

            EkranKarti ekranKarti = new EkranKarti()
            {
                EkranKartiMarka = "Nvidia Geforce",
                EkranKartiModel = "RTX 4080TI",
            };

            GucKaynagi gucKaynagi = new GucKaynagi()
            {
                GucKaynagiMarka = "Corsair",
                GucKaynagiWatt = "750w",
                GucKaynagiModel = "RM750x",
            };

            Islemci islemci = new Islemci()
            {
                IslemciModel = "Ryzen 5",
                IslemciMarka = "AMD",
                IslemciSurum = "5600X",
            };

            Kasa kasa = new Kasa()
            {
                KasaBoyut = "Compact",
                KasaMarka = "NZXT",
                KasaModel = "H510",
                KasaRenk = "Beyaz"
            };


            #endregion
            
            
            
        }
    }
}