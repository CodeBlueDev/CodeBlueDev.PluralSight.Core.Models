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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Transcript Segment.
    /// </summary>
    /// <example>
    /// "segment": {
    ///   "text": "Hi, my name's Mark Heath",
    ///   "displayTime": 2.0
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class TranscriptModuleClipSegment
    {
        /// <summary>
        /// Gets or sets the transcript text.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the display time where the text occurs.
        /// </summary>
        [DataMember(Name = "displayTime")]
        public double DisplayTime { get; set; }
    }
}
