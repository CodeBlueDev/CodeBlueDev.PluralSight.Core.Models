// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Transcript.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a Transcript.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a Transcript.
    /// </summary>
    [Serializable]
    public sealed class Transcript
    {
        /// <summary>
        /// Gets or sets the <see cref="TranscriptModule">modules</see>.
        /// </summary>
        public TranscriptModule[] Modules { get; set; }
    }
}
