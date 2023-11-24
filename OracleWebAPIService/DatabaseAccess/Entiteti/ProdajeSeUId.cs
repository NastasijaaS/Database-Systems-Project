using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseAccess.Entiteti
    {
        public class ProdajeSeUId
        {
            public virtual Lek LekProdajeSeU { get; set; }
            public virtual ProdajnoMesto ProdajeSeUProdajnoMesto { get; set; }
            public override bool Equals(object obj)
            {
                if (Object.ReferenceEquals(this, obj))
                    return true;

                if (obj.GetType() != typeof(ProdajeSeUId))
                    return false;

                ProdajeSeUId recievedObject = (ProdajeSeUId)obj;

                if ((LekProdajeSeU.IdLeka == recievedObject.LekProdajeSeU.IdLeka) &&
                    (ProdajeSeUProdajnoMesto.Id == recievedObject.ProdajeSeUProdajnoMesto.Id))
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

