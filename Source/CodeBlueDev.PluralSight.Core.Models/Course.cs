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
    /// <example>
    /// "course": {
    ///   "id": "windows-forms-best-practices",
    ///   "courseId": "24f3e2ce-88bc-44f5-a9b7-3b0f326c3494",
    ///   "slug": "windows-forms-best-practices",
    ///   "publishedOn": "2014-09-27",
    ///   "updatedOn": "2014-09-27",
    ///   "displayDate": "2014-09-27",
    ///   "title": "Windows Forms Best Practices",
    ///   "shortDescription": "This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability.",
    ///   "description": "This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application.",
    ///   "level": "Intermediate",
    ///   "duration": "PT16562.2140000S",
    ///   "rating": {
    ///     ..
    ///   },
    ///   "popularityScore": 229685,
    ///   "courseImageUrl": "https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg",
    ///   "courseImage": {
    ///     ..
    ///   },
    ///   "image": {
    ///     ..
    ///   },
    ///   "audiences": [
    ///     "software-development"
    ///   ],
    ///   "modules": [
    ///     {
    ///       ..
    ///       "clips": [
    ///         {
    ///           ..
    ///         },
    ///         ..
    ///       ]
    ///     },
    ///     ..
    ///   ],
    ///   "playerUrl": "/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live",
    ///   "authors": [
    ///     {
    ///       ..
    ///     }
    ///   ],
    ///   "skillPaths": [
    ///     {
    ///       ..
    ///     }
    ///   ],
    ///   "hasLearningCheck": true,
    ///   "hasTranscript": true
    /// }
    /// </example>
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
