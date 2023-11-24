using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class UpakovanUView
    {
        public UpakovanUIdView Id { get; set; }
        public int Kolicina { get; set; }
        public string Sastav { get; set; }
        
        public UpakovanUView()
        {

        }

        public UpakovanUView(UpakovanU u)
        {
            Id = new UpakovanUIdView(u.Id);
            Kolicina = u.Kolicina;
            Sastav = u.Sastav;
        }

    }
}
