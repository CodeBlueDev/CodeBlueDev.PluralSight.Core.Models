// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Author.cs" company="CodeBlueDev">
//   Copyright (c) CodeBlueDev. All rights reserved.
// </copyright>
// <summary>
//   Represents a PluralSight Author.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a PluralSight Author.
    /// </summary>
    /// <example>
    /// "author": {
    ///   "authorId": "75098b43-9787-43af-ab9d-a1994cede9a4",
    ///   "id": "mark-heath",
    ///   "handle": "mark-heath",
    ///   "firstName": "Mark",
    ///   "lastName": "Heath",
    ///   "displayName": "Mark Heath"
    ///  }
    /// </example>
    [DataContract]
    [Serializable]
    public sealed class Author
    {
        /// <summary>
        /// Gets or sets the globally unique identifier of the PluralSight author.
        /// </summary>
        [DataMember(Name = "authorId")]
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the PluralSight author.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the handle of the PluralSight author.
        /// </summary>
        [DataMember(Name = "handle")]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets the first name of the PluralSight author.
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the PluralSight author.
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the PluralSight author.
        /// </summary>
        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }
    }
}
