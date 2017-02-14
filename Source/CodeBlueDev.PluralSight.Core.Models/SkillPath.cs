// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkillPath.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Skill Path.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;

    /// <summary>
    /// Represents a PluralSight Skill Path.
    /// </summary>
    [Serializable]
    public sealed class SkillPath
    {
        /// <summary>
        /// Gets or sets the id of the PluralSight Skill Path.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Skill Path.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Skill Path is retired.
        /// </summary>
        public bool Retired { get; set; }

        /// <summary>
        /// Gets or sets the url of the PluralSight Skill Path.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the url slug of the PluralSight Skill Path.
        /// </summary>
        public string UrlSlug { get; set; }

        /// <summary>
        /// Gets or sets the icon url of the PluralSight Skill Path.
        /// </summary>
        public string IconUrl { get; set; }
    }
}
