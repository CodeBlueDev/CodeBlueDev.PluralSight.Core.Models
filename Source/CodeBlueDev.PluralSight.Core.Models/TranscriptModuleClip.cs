// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptClip.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a Transcript Clip.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a Transcript Clip.
    /// </summary>
    /// <example>
    /// "clip": {
    ///   "title": "Module Introduction",
    ///   "playerUrl": "//app.pluralsight.com/player?course=windows-forms-best-practices&amp;author=mark-heath&amp;name=windows-forms-best-practices-m1&amp;clip=0&amp;mode=live",
    ///   "segments": [
    ///     ..
    ///   ]
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class TranscriptModuleClip
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="CourseModuleClip"/> the Transcript is for.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the player url of the <see cref="CourseModuleClip"/> the Transcript is for.
        /// </summary>
        [DataMember(Name = "playerUrl")]
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TranscriptModuleClipSegment">segments</see>.
        /// </summary>
        [DataMember(Name = "segments")]
        public TranscriptModuleClipSegment[] Segments { get; set; }
    }
}
