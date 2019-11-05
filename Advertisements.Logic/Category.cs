using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Advertisements.Logic
{
    /// <summary>
    /// Kategorijas dati
    /// </summary>
    public class Category : BaseData
    {
        /// <summary>
        /// Nosaukums
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Virskategorijas identifikators.
        /// Ja nav definets - pamatkategorija.
        /// </summary>
        public int? CategoryId { get; set; }
        [NotMapped]
        public int AdvertisementCount { get; set; }
    }
}
