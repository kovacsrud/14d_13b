namespace OsztalyokListak
{
    public class Szemely
    {
        

        public string KeresztNev { get; set; }
        public int SzuletesiEv { get; set; }
        public string SzuletesiHely { get; set; }
        public string VezetekNev { get; set; }


        public Szemely(string keresztNev, string vezetekNev, int szuletesiEv, string szuletesiHely)
        {
            KeresztNev = keresztNev;
            SzuletesiEv = szuletesiEv;
            SzuletesiHely = szuletesiHely;
            VezetekNev = vezetekNev;
        }

        public int Eletkor()
        {
            return 2019 - SzuletesiEv;
        }

    }
}