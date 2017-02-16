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

    /// <summary>
    /// Represents a Transcript Clip.
    /// </summary>
    [Serializable]
    public sealed class TranscriptClip
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="CourseClip"/> the Transcript is for.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the player url of the <see cref="CourseClip"/> the Transcript is for.
        /// </summary>
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TranscriptSegment">segments</see>.
        /// </summary>
        public TranscriptSegment[] Segments { get; set; }
    }
}
