using System;

namespace Versenyzők
{
    class Pilóta
    {
        public string Név { get; set; }
        public DateTime SzületésiDátum { get; set; }
        public string Nemzetiség { get; set; }
        public int? Rajtszám { get; set; }

        public Pilóta(string sor)
        {
            string[] s = sor.Split(';');
            Név = s[0];
            SzületésiDátum = DateTime.Parse(s[1]);
            Nemzetiség = s[2];
            Rajtszám = s[3] == "" ? null : int.Parse(s[3]);
        }
    }
}
