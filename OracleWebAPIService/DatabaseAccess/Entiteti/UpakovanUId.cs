using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class UpakovanUId
    {
        public virtual Lek LekUpakovanU { get; set; }
        public virtual Pakovanje UpakovanUPakovanje { get; set; }
        public UpakovanUId()//novo
        {

        }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(UpakovanUId))
                return false;

            UpakovanUId recievedObject = (UpakovanUId)obj;

            if ((LekUpakovanU.IdLeka == recievedObject.LekUpakovanU.IdLeka) &&
                (UpakovanUPakovanje.IdPakovanja == recievedObject.UpakovanUPakovanje.IdPakovanja))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

