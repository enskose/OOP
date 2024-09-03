namespace _1_Giris
{

    public struct Kisi
    {
        public string ad;
        public string soyad;
        string _tcno;
        public string gsm;
        
        //Kontrollü veri girişi. Tc numarası 11 karakterden uzun olamaz
        #region SetTcNo

        public void SetTcNo(string value)
                {
                    if (!string.IsNullOrEmpty(value) && value.Length == 11)
                    {
                        _tcno = value;
                    }
                }

        #endregion
        
        //TcNo son 4 hanesini göstermek
        #region GetTcNo
            public string GetTcNo()
                    {
                        if (!string.IsNullOrEmpty(_tcno))
                        {
                            return _tcno.Substring(7);
                        }
                        else
                        {
                            return " ";
                        }
                    }
        

        #endregion
        
    }

    public class Personel
    {
        string _tcNo;
        public string ad { get; set; }
        public string soyad { get; set; }

        // Tcno Kapsüllenmiş. Get ve Set metodları koşula bağlı veri girişi, çıkışı - Capsulation
        public string tcno
        {
            get
            {
                if (!string.IsNullOrEmpty(_tcNo))
                    return _tcNo.Substring(7);
                else
                {
                    return " ";
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _tcNo = value;
                }
            }
        }
        public string gsm { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Struct ile çalışma

            // Kisi kisi = new Kisi();
            // kisi.ad = "Enes";
            // kisi.soyad = "Köse";
            // kisi.SetTcNo = "1023293843";
            // kisi.gsm = "123434";
            #endregion

            #region Class ile çalışma
            Personel personel = new Personel();
            

            #endregion
        }
    }
}