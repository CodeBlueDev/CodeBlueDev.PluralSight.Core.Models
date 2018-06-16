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
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Skill Path.
    /// </summary>
    /// <example>
    /// "skillPath": {
    ///   "id":"7e0ce425-0263-45ce-a6c1-186ae706654e",
    ///   "iconUrl":"https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png",
    ///   "retired":false,
    ///   "title":"C#",
    ///   "url":"/paths/skills/csharp",
    ///   "urlSlug":"csharp"
    /// }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class SkillPath
    {
        /// <summary>
        /// Gets or sets the id of the PluralSight Skill Path.
        /// </summary>
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the icon url of the PluralSight Skill Path.
        /// </summary>
        [DataMember(Name = "iconUrl")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the PluralSight Skill Path is retired.
        /// </summary>
        [DataMember(Name = "retired")]
        public bool IsRetired { get; set; }

        /// <summary>
        /// Gets or sets the title of the PluralSight Skill Path.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the url of the PluralSight Skill Path.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the url slug of the PluralSight Skill Path.
        /// </summary>
        [DataMember(Name = "urlSlug")]
        public string UrlSlug { get; set; }
    }
}
