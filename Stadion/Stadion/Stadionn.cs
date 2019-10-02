namespace Stadion
{
    public class Stadionn
    {
        

        public int ferohely { get; set; }
        public string nev1 { get; set; }
        public string nev2 { get; set; }
        public string varos { get; set; }

        public Stadionn(string varos, string nev1, string nev2, int ferohely)
        {
            this.ferohely = ferohely;
            this.nev1 = nev1;
            this.nev2 = nev2;
            this.varos = varos;
        }

    }
}