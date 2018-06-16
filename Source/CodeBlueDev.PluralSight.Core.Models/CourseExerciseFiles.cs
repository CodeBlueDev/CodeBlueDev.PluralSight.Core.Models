// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseExerciseFiles.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Course's exercise files information.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Course's exercise files information.
    /// </summary>
    /// <example>
    /// {
    ///  "exerciseFilesUrl": "http://s.pluralsight.com/course-materials/windows-forms-best-practices/866AB96258/20140926213054/windows-forms-best-practices.zip?userHandle=03b9fd64-819c-4def-a610-52457b0479ec"
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public class CourseExerciseFiles
    {
        /// <summary>
        /// Gets or sets the Exercise Files Url for a PluralSight Course.
        /// </summary>
        [DataMember(Name = "exerciseFilesUrl")]
        public string ExerciseFilesUrl { get; set; }
    }
}
