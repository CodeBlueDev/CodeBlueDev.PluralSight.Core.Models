// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseModule.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Module.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Course's Module.
    /// </summary>
    [Serializable]
    public sealed class CourseModule
    {
        /// <summary>
        /// Gets or sets the id of the PluralSight Course Module.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Course Module.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Course Module.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the player url of the PluralSight Course Module.
        /// </summary>
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the clips of the PluralSight Course Module.
        /// </summary>
        public CourseClip[] Clips { get; set; }
    }
}
