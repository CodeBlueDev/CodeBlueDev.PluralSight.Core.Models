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
        [Test]
        public void AuthorJsonShouldDeserializeIntoAuthorModel()
        {
            // Arrange
            const string Json = @"
            {
                ""id"":""mark-heath"",
                ""firstName"":""Mark"",
                ""lastName"":""Heath"",
                ""displayName"":""Mark Heath""
            }";

            // Act
            Author author = JsonConvert.DeserializeObject<Author>(Json);

            // Assert
            Assert.IsNotNull(author);
            Assert.AreEqual("mark-heath", author.Id);
            Assert.AreEqual("Mark", author.FirstName);
            Assert.AreEqual("Heath", author.LastName);
            Assert.AreEqual("Mark Heath", author.DisplayName);
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
                    ""id"":""steve-smith"",
                    ""firstName"":""Steve"",
                    ""lastName"":""Smith""
                    ""displayName"":""Steve Smith""
                },
                {
                    ""id"":""david-starr"",
                    ""firstName"":""David"",
                    ""lastName"":""Starr""
                    ""displayName"":""David Starr""
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