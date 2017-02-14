// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseImage.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Course's images.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents the image of the PluralSight Course.
    /// </summary>
    [Serializable]
    public sealed class CourseImage
    {
        /// <summary>
        /// Gets or sets the course list image url.
        /// </summary>
        public string CourseListUrl { get; set; }

        /// <summary>
        /// Gets or sets the default image url.
        /// </summary>
        public string DefaultUrl { get; set; }

        /// <summary>
        /// Gets or sets the small image url.
        /// </summary>
        public string SmallUrl { get; set; }
    }
}
