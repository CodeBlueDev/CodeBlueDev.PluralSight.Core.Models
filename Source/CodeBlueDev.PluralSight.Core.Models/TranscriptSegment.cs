// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptSegment.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Transcript Segment.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Transcript Segment.
    /// </summary>
    [Serializable]
    public sealed class TranscriptSegment
    {
        /// <summary>
        /// Gets or sets the transcript text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the display time where the text occurs.
        /// </summary>
        public double DisplayTime { get; set; }
    }
}
