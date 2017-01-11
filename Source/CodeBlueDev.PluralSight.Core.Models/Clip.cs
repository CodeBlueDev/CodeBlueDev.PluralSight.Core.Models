// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Clip.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Course's Module's clip.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Course's Module's clip.
    /// </summary>
    [Serializable]
    public sealed class Clip
    {
        // TODO: Need to prototype Transcripts.

        /// <summary>
        /// Gets or sets the clip index in the PluralSight <see cref="Module"/>.
        /// </summary>
        public int ClipIndex { get; set; }

        /// <summary>
        /// Gets or sets the title of the clip.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the clip has been viewed.
        /// </summary>
        public bool HasBeenViewed { get; set; }

        /// <summary>
        /// Gets or sets the duration of the clip.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets the clip's player parameters.
        /// </summary>
        public string PlayerParameters { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user may view the clip.
        /// </summary>
        public bool UserMayViewClip { get; set; }

        /// <summary>
        /// Gets or sets the click action description for the clip.
        /// </summary>
        public string ClickActionDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the clip is highlighted.
        /// </summary>
        public bool IsHighlighted { get; set; }

        /// <summary>
        /// Gets or sets the name of the clip.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the clip is bookmarked by the user.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets the has been viewed image url for the clip.
        /// </summary>
        public string HasBeenViewedImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the has been viewed alt text for the clip. 
        /// </summary>
        public string HasBeenViewedAltText { get; set; }
    }
}
