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
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Course's Module's clip.
    /// </summary>
    [DataContract]
    [Serializable]
    public sealed class CourseModuleClip
    {
        /// <summary>
        /// The TimeSpan representation of the duration.
        /// </summary>
        private TimeSpan? durationTimeSpan;

        /// <summary>
        /// Gets or sets the id of the PluralSight Module Course Clip.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the globally unique id for the PluralSight Module Course Clip.
        /// </summary>
        [DataMember(Name = "clipId")]
        public Guid ClipId { get; set; }

        /// <summary>
        /// Gets or sets the deprecated id of the PluralSight Module Course Clip.
        /// </summary>
        [DataMember(Name = "deprecatedId")]
        public string DeprecatedId { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Module Course Clip.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the PluralSight Module Course Clip.
        /// </summary>
        [DataMember(Name = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Module.
        /// </summary>
        [DataMember(Name = "moduleTitle")]
        public string ModuleTitle { get; set; }

        /// <summary>
        /// Gets or sets the PluralSight player url of the PluralSight Course Module Clip.
        /// </summary>
        [DataMember(Name = "playerUrl")]
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the (zero-based) index of the PluralSight Course Module Clip in the PluralSight Course Module.
        /// </summary>
        [DataMember(Name = "ordering")]
        public int Index { get; set; }

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
                    this.durationTimeSpan
                        ?? (this.durationTimeSpan =
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
