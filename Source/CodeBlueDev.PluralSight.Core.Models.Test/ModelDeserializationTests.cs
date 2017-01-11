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

        /// <summary>
        /// Tests if a Clip JSON block can be deserialized to a Clip model.
        /// </summary>
        [Test]
        public void ClipJsonShouldDeserializeIntoClipModel()
        {
            // Arrange
            const string Json = @"{
                ""transcripts"": [],
                ""clipIndex"": 0,
                ""title"": ""Module Introduction"",
                ""hasBeenViewed"": true,
                ""duration"": ""00:00:57"",
                ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices"",
                ""userMayViewClip"": true,
                ""clickActionDescription"": ""View with player"",
                ""isHighlighted"": true,
                ""name"": ""windows-forms-best-practices-m1-01"",
                ""isBookmarked"": true,
                ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                ""hasBeenViewedAltText"": ""You have not watched this Clip.""
            }";

            // Act
            Clip clip = JsonConvert.DeserializeObject<Clip>(Json);

            // Assert
            Assert.IsNotNull(clip);
            Assert.AreEqual(0, clip.ClipIndex);
            Assert.AreEqual("Module Introduction", clip.Title);
            Assert.IsTrue(clip.HasBeenViewed);
            Assert.AreEqual(new TimeSpan(00, 00, 57), clip.Duration);
            Assert.AreEqual("author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices", clip.PlayerParameters);
            Assert.IsTrue(clip.UserMayViewClip);
            Assert.AreEqual("View with player", clip.ClickActionDescription);
            Assert.IsTrue(clip.IsHighlighted);
            Assert.AreEqual("windows-forms-best-practices-m1-01", clip.Name);
            Assert.IsTrue(clip.IsBookmarked);
            Assert.AreEqual("cs/has-not-been-viewed-checkmark-15-v1.png", clip.HasBeenViewedImageUrl);
            Assert.AreEqual("You have not watched this Clip.", clip.HasBeenViewedAltText);
        }

        /// <summary>
        /// Tests if a Clip JSON block with multiple Clips can be deserialized to multiple Clip models.
        /// </summary>
        [Test]
        public void ClipJsonWithMultipleClipsShouldDeserializeIntoMultipleClipModels()
        {
            // Arrange
            const string Json = @"[
                {
                    ""transcripts"": [],
                    ""clipIndex"": 0,
                    ""title"": ""Module Introduction"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:00:57"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-01"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                },
                {
                    ""transcripts"": [],
                    ""clipIndex"": 1,
                    ""title"": ""Is Windows Forms Dead?"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:01:36"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=1&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-02"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                }
            ]";

            // Act
            Clip[] clips = JsonConvert.DeserializeObject<Clip[]>(Json);

            // Assert
            Assert.IsNotNull(clips);
            Assert.AreEqual(2, clips.Length);
        }
    }
}
