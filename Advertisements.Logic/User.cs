﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
    /// <summary>
    /// Lietotajs
    /// </summary>
    public class User : BaseData
    {
        /// <summary>
        /// E-pasts
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Parole
        /// </summary>
        public string Password { get; set; }

    }
}
