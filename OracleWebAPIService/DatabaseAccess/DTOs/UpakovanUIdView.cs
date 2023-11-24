using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Entiteti;

namespace DatabaseAccess.DTOs
{
    public class UpakovanUIdView
    {
        public LekView LekUpakovanU { get; set; }
        public PakovanjeView UpakovanUPakovanje { get; set; }

        public UpakovanUIdView()
        {

        }

        public UpakovanUIdView(UpakovanUId u)
        {
            LekUpakovanU = new LekView(u.LekUpakovanU);
            UpakovanUPakovanje = new PakovanjeView(u.UpakovanUPakovanje);
        }

    }
}
