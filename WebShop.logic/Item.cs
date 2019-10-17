using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    /// <summary>
    /// Prece
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Identifikators
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Nosaukums
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Apraksts
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Foto
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Kategorijas identifikators, kurai prece pieder.
        /// </summary>
        public int CategoryId { get; set; }
}
}
