// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptModule.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a Transcript Module.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a Transcript Module.
    /// </summary>
    [Serializable]
    public sealed class TranscriptModule
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="CourseModule"/> the Transcript is for.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the player url of the <see cref="CourseModule"/> the Transcript is for.
        /// </summary>
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TranscriptClip">clips</see>.
        /// </summary>
        public TranscriptClip[] Clips { get; set; }
    }
}
