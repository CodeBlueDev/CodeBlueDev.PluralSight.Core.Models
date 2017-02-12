// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseClip.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Course's Module's clip.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Course's Module's clip.
    /// </summary>
    [Serializable]
    public sealed class CourseClip
    {
        /// <summary>
        /// Gets or sets the id of the PluralSight Course Clip.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Course Clip.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Course Clip.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight player url of the PluralSight Course Clip.
        /// </summary>
        public string PlayerUrl { get; set; }
    }
}
