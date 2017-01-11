// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Course.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Course.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Course.
    /// </summary>
    [Serializable]
    public sealed class Course
    {
        /// <summary>
        /// Gets or sets the title of the course.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="CourseLevel">level</see> of the course.
        /// </summary>
        public CourseLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the duration of the course.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the release date of the course.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Author">author(s)</see> of the course.
        /// </summary>
        public Author[] Authors { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the course has a transcript.
        /// </summary>
        public bool HasTranscript { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="CourseRating">course rating</see> of a course.
        /// </summary>
        public CourseRating CourseRating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the course is retired.
        /// </summary>
        public bool IsRetired { get; set; }

        /// <summary>
        /// Gets or sets the short description of the course.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the course is bookmarked by the user.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user may save the course.
        /// </summary>
        public bool UserMaySaveCourse { get; set; }

        /// <summary>
        /// Gets or sets the replacement course name if the course has been retired.
        /// </summary>
        public string ReplacementCourseName { get; set; }

        /// <summary>
        /// Gets or sets the retired reason if the course has been retired.
        /// </summary>
        public string RetiredReason { get; set; }

        /// <summary>
        /// Gets or sets the replacement course title if the course has been retired.
        /// </summary>
        public string ReplacementCourseTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the course is valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is authorized for a transcript for the course.
        /// </summary>
        public bool IsUserAuthorizedForTranscript { get; set; }
    }
}
