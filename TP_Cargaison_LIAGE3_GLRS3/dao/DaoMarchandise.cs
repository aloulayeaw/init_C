using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Cargaison_LIAGE3_GLRS3.models;

namespace TP_Cargaison_LIAGE3_GLRS3.dao
{
    class DaoMarchandise : ICargaison<Marchandise>
    {
        public add(Marchandise objet)
        {
            marchandise.Add(new Aerienne()
            {
                Distance = 100000,
                PoidsTotal=0,
                VolumeTotal=0

            }
            );
            marchandise.Add(new Aerienne()
            {
                Distance =70000 ,
                PoidsTotal = 0,
                VolumeTotal = 0

            }
            );
        }

        public List<Marchandise> getAll()
        {
            throw new NotImplementedException();
        }

        public Marchandise getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marchandise> getMarchandiseByCargaison(Cargaison cargaison)
        {
            return this.Marchandise;
        }


    }


}
