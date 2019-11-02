using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    /// <summary>
    /// Kategorijas dati
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Identifikators
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nosaukums
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Virskategorijas identifikators.
        /// Ja nav definets - pamatkategorija.
        /// </summary>
        public int? CategoryId { get; set; }
        /// <summary>
        /// Virtuāla kolonna - preču skaits
        /// </summary>
        [NotMapped]
        public int ItemCount { get; set; }
    }
}
