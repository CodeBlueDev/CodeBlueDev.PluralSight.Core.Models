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
        /// Gets or sets the current users rating for the course.
        /// </summary>
        public int CurrentUsersRating { get; set; }

        /// <summary>
        /// Gets or sets the average rating for the course.
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the rating for the course.
        /// </summary>
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can rate this course.
        /// </summary>
        public bool CanRateThisCourse { get; set; }

        /// <summary>
        /// Gets or sets the course name.
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Gets or sets the number of users that have rated the course.
        /// </summary>
        public int NumberOfRaters { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has rated the course.
        /// </summary>
        public bool HasUserRatedCourse { get; set; }
    }
}
