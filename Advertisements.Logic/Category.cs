using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
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
    }
}
