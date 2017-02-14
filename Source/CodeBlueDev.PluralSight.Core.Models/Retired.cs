// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Retired.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents the retired status of a PluralSight Course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents the retired status of a PluralSight Course.
    /// </summary>
    [Serializable]
    public sealed class Retired
    {
        /// <summary>
        /// Gets or sets a value indicating whether a PluralSight Course is retired.
        /// </summary>
        public bool IsRetired { get; set; }

        /// <summary>
        /// Gets or sets the reason a PluralSight Course is retired.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the replacement id of the PluralSight Course that replaces the retired PluralSight Course.
        /// </summary>
        public string ReplacementId { get; set; }
    }
}
