using Microsoft.EntityFrameworkCore;
using PrimerParcialAplic2.Data;
using PrimerParcialAplic2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrimerParcialAplic2.Controllers
{
    public class InscripcionControllers
    {
        public bool Guardar (Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            if (inscripciones.InscripcionId == 0)
            {
                paso = Insertar(inscripciones);

            }else
            {
                paso=
            }
        }
        public bool Insertar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

            db.inscripciones.Find(inscripciones);
            paso = db.SaveChanges() > 0;

            return paso;
        }
        public bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.inscripciones.Add(inscripciones).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public Inscripciones Buscar(int Id)
        {
            Contexto db = new Contexto();

            Inscripciones inscripciones = new Inscripciones();
            try
            {
               inscripciones= db.inscripciones.Find(Id);
            }
            catch (Exception) 
            {

                throw;
            }
            return  inscripciones;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Inscripciones inscripciones = new Inscripciones();
            Contexto db = new Contexto();
            try
            {
                inscripciones = db.inscripciones.Find(Id);
                db.Entry(inscripciones).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public List<Inscripciones> GetInscripciones(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> Lista;
            Contexto db = new Contexto();

            try
            {
                Lista = db.inscripciones.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;

        }
    }
}
