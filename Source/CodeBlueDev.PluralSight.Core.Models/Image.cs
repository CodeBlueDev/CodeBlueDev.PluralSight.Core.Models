// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseImage.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents an image for PluralSight.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an image for PluralSight.
    /// </summary>
    /// <example>
    /// "image": {
    ///   "alt": "Windows Forms Best Practices",
    ///   "url": "https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg",
    ///   "isDefault": false
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class Image
    {
        /// <summary>
        /// Gets or sets the alternate text for the image.
        /// </summary>
        [DataMember(Name = "alt")]
        public string AltText { get; set; }

        /// <summary>
        /// Gets or sets the url for the image.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the image is the default image.
        /// </summary>
        [DataMember(Name = "isDefault")]
        public bool IsDefault { get; set; }
    }
}
