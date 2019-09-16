namespace OOP0916
{
    class MegJobbEmber
    {
       

        public bool Hajadon { get; set; }
        public int Kor { get; set; }
        public int Magassag { get; set; }
        public string Neme { get; set; }
        public string Nev { get; set; }
        public int Suly { get; set; }

        public MegJobbEmber()
        { }

        public MegJobbEmber(bool hajadon, int kor, int magassag, string neme, string nev, int suly)
        {
            Hajadon = hajadon;
            Kor = kor;
            Magassag = magassag;
            Neme = neme;
            Nev = nev;
            Suly = suly;
        }


    }
}