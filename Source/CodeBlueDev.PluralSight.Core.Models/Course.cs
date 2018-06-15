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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Course.
    /// </summary>
    [DataContract(Name = "course")]
    [Serializable]
    public sealed class Course
    {
        /// <summary>
        /// Gets or sets the id of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the globally unique identifier of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "courseId")]
        public Guid CourseId { get; set; }

        /// <summary>
        /// Gets or sets the slug identifier of the PluralSight Course
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the date the PluralSight Course was published on.
        /// </summary>
        [DataMember(Name = "publishedOn")]
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the date the PluralSight Course was last updated on.
        /// </summary>
        [DataMember(Name = "updatedOn")]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the display date of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "displayDate")]
        public DateTime DisplayDate { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the short description of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the description of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course level.
        /// </summary>
        [DataMember(Name = "level")]
        public CourseLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the popularity score of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "popularityScore")]
        public int PopularityScore { get; set; }

        /// <summary>
        /// Gets or sets the image url of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "courseImageUrl")]
        public string CourseImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight player url.
        /// </summary>
        [DataMember(Name = "playerUrl")]
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Course has a learning check.
        /// </summary>
        [DataMember(Name = "hasLearningCheck")]
        public bool IsLearningCheckAvailable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Course has a transcript.
        /// </summary>
        [DataMember(Name = "hasTranscript")]
        public bool IsTranscriptAvailable { get; set; }

        /// <summary>
        /// Gets or sets the rating of the PluralSight Course.
        /// </summary>
        [DataMember(Name = "rating")]
        public CourseRating Rating { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course image.
        /// </summary>
        [DataMember(Name = "courseImage")]
        public Image CourseImage { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course image.
        /// </summary>
        [DataMember(Name = "image")]
        public Image Image { get; set; }

        /// <summary>
        /// Gets or sets the intended audience(s) for the PluralSight Course.
        /// </summary>
        [DataMember(Name = "audiences")]
        public string[] Audiences { get; set; }

        /// <summary>
        /// Gets or sets the Course Modules associated with the PluralSight Course.
        /// </summary>
        [DataMember(Name = "modules")]
        public CourseModule[] Modules { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight Course Author(s).
        /// </summary>
        [DataMember(Name = "authors")]
        public Author[] Authors { get; set; }

        /// <summary>
        /// Gets or sets the skill paths the PluralSight Course is a part of.
        /// </summary>
        [DataMember(Name = "skillPaths")]
        public SkillPath[] SkillPaths { get; set; }
    }
}
