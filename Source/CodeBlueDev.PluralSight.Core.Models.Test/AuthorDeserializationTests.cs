// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Author objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Author objects.
    /// </summary>
    [TestFixture]
    public class AuthorDeserializationTests
    {
        /// <summary>
        /// Tests if an Author JSON block can be deserialized to an Author model.
        /// </summary>
        [Category("Author")]
        [Test]
        public void AuthorJsonShouldDeserializeIntoAuthorModel()
        {
            // Arrange
            const string json = @"{
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""id"": ""mark-heath"",
      ""handle"": ""mark-heath"",
      ""firstName"": ""Mark"",
      ""lastName"": ""Heath"",
      ""displayName"": ""Mark Heath""
    }";

            // Act
            Author author = JsonConvert.DeserializeObject<Author>(json);

            // Assert
            Assert.IsNotNull(author);
            Assert.AreEqual(Guid.Parse("75098b43-9787-43af-ab9d-a1994cede9a4"), author.AuthorId);
            Assert.AreEqual("mark-heath", author.Id);
            Assert.AreEqual("mark-heath", author.Handle);
            Assert.AreEqual("Mark", author.FirstName);
            Assert.AreEqual("Heath", author.LastName);
            Assert.AreEqual("Mark Heath", author.DisplayName);
        }

        /// <summary>
        /// Tests if an Author JSON block with multiple Authors can be deserialized to multiple Author models.
        /// </summary>
        [Category("Author")]
        [Test]
        public void AuthorJsonWithMultipleAuthorsShouldDeserializeIntoMultipleAuthorModels()
        {
            // Arrange
            const string json = @"[
  {
    ""authorId"": ""0658e934-b452-48dd-af92-7baa8a020802"",
    ""id"": ""steve-smith"",
    ""handle"": ""steve-smith"",
    ""firstName"": ""Steve"",
    ""lastName"": ""Smith"",
    ""displayName"": ""Steve Smith""
  },
  {
    ""authorId"": ""c7dc9469-fdeb-4716-9792-e5650e1e54ca"",
    ""id"": ""david-starr"",
    ""handle"": ""david-starr"",
    ""firstName"": ""David"",
    ""lastName"": ""Starr"",
    ""displayName"": ""David Starr""
  }
]";

            // Act
            Author[] authors = JsonConvert.DeserializeObject<Author[]>(json);

            // Assert
            Assert.IsNotNull(authors);
            Assert.AreEqual(2, authors.Length);
        }
    }
}