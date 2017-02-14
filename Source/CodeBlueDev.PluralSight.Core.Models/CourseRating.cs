// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseRating.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents the rating for a course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents the rating for a course.
    /// </summary>
    [Serializable]
    public sealed class CourseRating
    {
        /// <summary>
        /// Gets or sets the average rating for the course.
        /// </summary>
        public decimal Average { get; set; }

        /// <summary>
        /// Gets or sets the number of users that have rated the course.
        /// </summary>
        public int RatersCount { get; set; }
    }
}
