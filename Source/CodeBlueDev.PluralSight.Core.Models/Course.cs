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
        /// Gets or sets the id of the PluralSight Course.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the date the PluralSight Course was published on.
        /// </summary>
        public DateTime PublishedOn { get; set; }

        /// <summary>
        /// Gets or sets the date the PluralSight Course was last updated on.
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Course.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the short description of the PluralSight Course.
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the PluralSight Course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course level.
        /// </summary>
        public CourseLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Course.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the popularity score of the PluralSight Course.
        /// </summary>
        public int PopularityScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Course has a transcript.
        /// </summary>
        public bool HasTranscript { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Course has an assessment.
        /// </summary>
        public bool HasAssessment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Course has a learning check.
        /// </summary>
        public bool HasLearningCheck { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight player url.
        /// </summary>
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the skill paths the PluralSight Course is a part of.
        /// </summary>
        public SkillPath[] SkillPaths { get; set; }

        /// <summary>
        /// Gets or sets the retired status of the PluralSight Course.
        /// </summary>
        public Retired Retired { get; set; }

        /// <summary>
        /// Gets or sets the rating of the PluralSight Course.
        /// </summary>
        public CourseRating Rating { get; set; }

        /// <summary>
        /// Gets or sets the Course Modules assocaited with the PluralSight Course.
        /// </summary>
        public CourseModule[] Modules { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course image(s).
        /// </summary>
        public CourseImage CourseImage { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course Author(s).
        /// </summary>
        public Author[] Authors { get; set; }

        /// <summary>
        /// Gets or sets the intended audience(s) for the PluralSight Course.
        /// </summary>
        public string[] Audiences { get; set; }
    }
}
