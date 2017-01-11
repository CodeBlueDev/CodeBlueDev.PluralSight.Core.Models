// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of objects.
    /// </summary>
    [TestFixture]
    public class ModelDeserializationTests
    {
        /// <summary>
        /// Tests if an Author JSON block can be deserialized to an Author model.
        /// </summary>
        [Test]
        public void AuthorJsonShouldDeserializeIntoAuthorModel()
        {
            // Arrange
            const string Json = @"
            {
                ""handle"":""mark-heath"",
                ""firstName"":""Mark"",
                ""lastname"":""Heath""
            }";

            // Act
            Author author = JsonConvert.DeserializeObject<Author>(Json);

            // Assert
            Assert.IsNotNull(author);
            Assert.AreEqual("mark-heath", author.Handle);
            Assert.AreEqual("Mark", author.FirstName);
            Assert.AreEqual("Heath", author.LastName);
        }

        /// <summary>
        /// Tests if an Author JSON block with multiple Authors can be deserialized to multiple Author models.
        /// </summary>
        [Test]
        public void AuthorJsonWithMultipleAuthorsShouldDeserializeIntoMultipleAuthorModels()
        {
            // Arrange
            const string Json = @"
            [
                {
                    ""handle"":""steve-smith"",
                    ""firstName"":""Steve"",
                    ""lastName"":""Smith""
                },
                {
                    ""handle"":""david-starr"",
                    ""firstName"":""David"",
                    ""lastName"":""Starr""
                }
            ]";

            // Act
            Author[] authors = JsonConvert.DeserializeObject<Author[]>(Json);

            // Assert
            Assert.IsNotNull(authors);
            Assert.AreEqual(2, authors.Length);
        }
    }
}
