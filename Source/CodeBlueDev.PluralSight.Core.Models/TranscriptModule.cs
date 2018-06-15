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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a Transcript Module.
    /// </summary>
    /// <example>
    /// "module": {
    ///   "title": "Creating Excellent Windows Forms Applications",
    ///   "playerUrl": "//app.pluralsight.com/player?course=windows-forms-best-practices&amp;author=mark-heath&amp;name=windows-forms-best-practices-m1&amp;clip=0&amp;mode=live",
    ///   "clips": [
    ///     ..
    ///   ]
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class TranscriptModule
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="CourseModule"/> the Transcript is for.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the player url of the <see cref="CourseModule"/> the Transcript is for.
        /// </summary>
        [DataMember(Name = "playerUrl")]
        public string PlayerUrl { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="TranscriptModuleClip">clips</see>.
        /// </summary>
        [DataMember(Name = "clips")]
        public TranscriptModuleClip[] Clips { get; set; }
    }
}
