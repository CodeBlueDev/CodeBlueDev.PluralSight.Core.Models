// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Module.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Module.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Module.
    /// </summary>
    [Serializable]
    public sealed class Module
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user may view the first clip in the module.
        /// </summary>
        public bool UserMayViewFirstClip { get; set; }

        /// <summary>
        /// Gets or sets the module reference used by PluralSight.
        /// </summary>
        public string ModuleRef { get; set; }

        /// <summary>
        /// Gets or sets the title of the module.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the module.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the duration of the module.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all clips in a module have been viewed.
        /// </summary>
        public bool HasBeenViewed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the module is highlighted.
        /// </summary>
        public bool IsHighlighted { get; set; }

        /// <summary>
        /// Gets or sets the fragment identifier used by PluralSight to represent the module.
        /// </summary>
        public string FragmentIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the first clip launch click handler text used by the PluralSight video player.
        /// </summary>
        public string FirstClipLaunchClickHandler { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user may bookmark the module.
        /// </summary>
        public bool UserMayBookmark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the module is bookmarked by the user.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets the clips contained by the module.
        /// </summary>
        public Clip[] Clips { get; set; }

        /// <summary>
        /// Gets or sets the image URL for a module that has already been viewed by the user.
        /// </summary>
        public string HasBeenViewedImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the text displayed in the alt tag when the module has already been viewed by the user.
        /// </summary>
        public string HasBeenViewedAltText { get; set; }
    }
}
