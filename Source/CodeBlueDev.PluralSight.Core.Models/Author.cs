// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Author.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Author.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Author.
    /// </summary>
    [Serializable]
    public sealed class Author
    {
        /// <summary>
        /// Gets or sets the handle used by PluralSight to represent the author.
        /// </summary>
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets the first name of the PluralSight author.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the PluralSight author.
        /// </summary>
        public string LastName { get; set; }
    }
}
