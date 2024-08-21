using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Test2.Models
{
    public class Pelicula
    {
        Test_bdEntities test_BdEntities = new Test_bdEntities();
        [Key]
        public int peli_id { get; set; }

        public string peli_titu { get; set; }

        public DateTime? peli_estreno { get; set; }

        public string peli_genero { get; set; }

        public decimal? peli_precio { get; set; }

        public List<Pelicula> ObtenerDatos()
        {
            var obtener = (from p in test_BdEntities.Tbl_pelicula select p).ToList();

            List<Pelicula> listaPelicula = new List<Pelicula>();
            foreach (var item in obtener)
            {
                Pelicula peli = new Pelicula();
                peli.peli_titu = item.peli_titu;
                peli.peli_estreno = item.peli_estreno;
                peli.peli_genero = item.peli_genero;
                peli.peli_precio = item.peli_precio;
                listaPelicula.Add(peli);
            }
            return listaPelicula;
        }
    }
}