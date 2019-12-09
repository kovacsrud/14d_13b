using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csudh
{
    class Program
    {
        public struct Domain
        {
            public string domain;
            public string ipaddress;
            public string[] domainLevels;

            public Domain(string sor)
            {
                var e = sor.Split(';');
                domain = e[0];
                ipaddress = e[1];
                var d = e[0].Split('.');
                domainLevels = new string[d.Length];
                for (int i = 0; i < d.Length; i++)
                {
                    domainLevels[i] = d[i];
                }
            }

        }

        public static string DomainSzint(string d,int szint)
        {
            var e = d.Split('.');
            if (szint > e.Length)
            {
                return "Nincs";
            }
            //if (e[szint - 1] == null)
            //{
            //    return "Nincs";
            //}
            else
            {
                return e[szint - 1];
            }


        }


        static void Main(string[] args)
        {
            //String testdomain = "adbc.efg.hujkl";

            //Console.WriteLine(DomainSzint(testdomain,1));
            //Console.WriteLine(DomainSzint(testdomain, 2));
            //Console.WriteLine(DomainSzint(testdomain, 3));
            //Console.WriteLine(DomainSzint(testdomain, 4));
            //Console.WriteLine(DomainSzint(testdomain, 5));

            List<Domain> domainek = new List<Domain>();

            try
            {
                var sorok = File.ReadAllLines(@"c:/ftproot/csudh/csudh.txt",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    domainek.Add(new Domain(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3, domainek száma:{domainek.Count}");
            //HTML fájl készítése

            string htmlOut = "";

            htmlOut += "<HTML>";
            htmlOut += "<HEAD>";
            htmlOut += "<TITLE>";
            htmlOut += "Csudh";
            htmlOut += "</TITLE>";
            htmlOut += "</HEAD>";
            htmlOut += "<BODY>";
            htmlOut += "<TABLE>";
            htmlOut += "<TR>";
            htmlOut += "<TD>Ssz</TD>";
            htmlOut += "<TD>Host domainneve</TD>";
            htmlOut += "<TD>Host ip címe</TD>";
            htmlOut += "<TD>Szint 1.</TD>";
            htmlOut += "<TD>Szint 2.</TD>";
            htmlOut += "<TD>Szint 3.</TD>";
            htmlOut += "<TD>Szint 4.</TD>";
            htmlOut += "<TD>Szint 5.</TD>";
            htmlOut += "</TR>";
            var sorszam = 1;
            foreach (var d in domainek)
            {
                htmlOut += "<TR>";
                htmlOut += $"<TD>{sorszam++}</TD>";
                htmlOut += $"<TD>{d.domain}</TD>";
                htmlOut += $"<TD>{d.ipaddress}</TD>";
                for (int i = 0; i < 5; i++)
                {
                    htmlOut += $"<TD>{DomainSzint(d.domain,i+1)}</TD>";
                }
                htmlOut += "</TR>";

            }
            htmlOut += "</TABLE>";
            htmlOut += "</BODY>";
            htmlOut += "</HTML>";

            try
            {
                File.WriteAllText(@"csudh.html",htmlOut);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
