using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class RadiUId
    {
        public virtual Zaposleni ZaposleniRadiU { get; set; }
        public virtual ProdajnoMesto RadiUProdajnoMesto { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(RadiUId))
                return false;

            RadiUId recievedObject = (RadiUId)obj;

            if ((ZaposleniRadiU.MaticniBroj == recievedObject.ZaposleniRadiU.MaticniBroj) &&
                (RadiUProdajnoMesto.Id == recievedObject.RadiUProdajnoMesto.Id))
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
