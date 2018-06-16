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
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Course's Module.
    /// </summary>
    /// <example>
    /// "modules": [
    ///   {
    ///     "id": "windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1",
    ///     "moduleId": "4617ec56-4a2b-4a4b-8e05-a82d558079e1",
    ///     "deprecatedId": "mark-heath|windows-forms-best-practices-m1",
    ///     "authorId": "75098b43-9787-43af-ab9d-a1994cede9a4",
    ///     "title": "Creating Excellent Windows Forms Applications",
    ///     "duration": "PT1620.7300000S",
    ///     "playerUrl": "/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live",
    ///     "clips": [
    ///       {
    ///       ...
    ///       }
    ///     ]
    ///   }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class CourseModule
    {
        /// <summary>
        /// The TimeSpan representation of the duration.
        /// </summary>
        private TimeSpan? _durationTimeSpan;

        /// <summary>
        /// Gets or sets the id of the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the globally unique identifier for the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "moduleId")]
        public Guid ModuleId { get; set; }

        /// <summary>
        /// Gets or sets the deprecated id for the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "deprecatedId")]
        public string DeprecatedId { get; set; }

        /// <summary>
        /// Gets or sets the globally unique identifier for the PluralSight Author.
        /// </summary>
        [DataMember(Name = "authorId")]
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the player url of the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "playerUrl")]
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the clips of the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "clips")]
        public CourseModuleClip[] Clips { get; set; }

        /// <summary>
        /// Gets the TimeSpan representation of the PluralSight Course Module Clip Duration.
        /// </summary>
        [IgnoreDataMember]
        public TimeSpan? DurationTimeSpan
        {
            get
            {
                if (string.IsNullOrEmpty(this.Duration))
                {
                    return null;
                }

                return
                    this._durationTimeSpan
                    ?? (this._durationTimeSpan =
                        TimeSpan.FromSeconds(
                            double.Parse(
                                string.Join(
                                    string.Empty,
                                    this.Duration.Where(character =>
                                        char.IsDigit(character)
                                        || character == '.')))));
            }
        }
    }
}
