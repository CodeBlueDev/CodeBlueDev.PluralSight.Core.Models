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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a Transcript.
    /// </summary>
    /// <example>
    /// {
    ///   "modules": [
    ///     ..
    ///   ]
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class Transcript
    {
        /// <summary>
        /// Gets or sets the <see cref="TranscriptModule">modules</see>.
        /// </summary>
        [DataMember(Name = "modules")]
        public TranscriptModule[] Modules { get; set; }
    }
}
