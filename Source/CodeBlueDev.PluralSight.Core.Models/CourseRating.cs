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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the rating for a course.
    /// </summary>
    /// <example>
    /// "rating": {
    ///    "average": 4.6,
    ///    "ratersCount": 316
    /// }
    /// </example>
    [DataContract(Name = "rating")]
    [Serializable]
    public sealed class CourseRating
    {
        /// <summary>
        /// Gets or sets the average rating for the course.
        /// </summary>
        [DataMember(Name = "average")]
        public decimal Average { get; set; }

        /// <summary>
        /// Gets or sets the number of users that have rated the course.
        /// </summary>
        [DataMember(Name = "ratersCount")]
        public int RatersCount { get; set; }
    }
}
