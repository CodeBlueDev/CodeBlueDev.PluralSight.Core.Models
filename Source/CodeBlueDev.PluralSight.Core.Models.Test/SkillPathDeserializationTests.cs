// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkillPathDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Skill Path objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Skill Path objects.
    /// </summary>
    [TestFixture]
    public class SkillPathDeserializationTests
    {
        /// <summary>
        /// Tests if an Skill Path JSON block can be deserialized to a Skill Path model.
        /// </summary>
        [Category("Skill Path")]
        [Test]
        public void SkillPathJsonShouldDeserializeIntoSkillPathModel()
        {
            // Arrange
            const string Json = @"{
      ""id"":""7e0ce425-0263-45ce-a6c1-186ae706654e"",
      ""iconUrl"":""https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png"",
      ""retired"":false,
      ""title"":""C#"",
      ""url"":""/paths/skills/csharp"",
      ""urlSlug"":""csharp""
    }";

            // Act
            SkillPath skillPath = JsonConvert.DeserializeObject<SkillPath>(Json);

            // Assert
            Assert.IsNotNull(skillPath);
            Assert.AreEqual(Guid.Parse("7e0ce425-0263-45ce-a6c1-186ae706654e"), skillPath.Id);
            Assert.AreEqual("https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png", skillPath.IconUrl);
            Assert.IsFalse(skillPath.IsRetired);
            Assert.AreEqual("C#", skillPath.Title);
            Assert.AreEqual("/paths/skills/csharp", skillPath.Url);
            Assert.AreEqual("csharp", skillPath.UrlSlug);
        }

        /// <summary>
        /// Tests if an Skill Path JSON block with multiple Skill Paths can be deserialized to multiple Skill Path models.
        /// </summary>
        [Category("Skill Path")]
        [Test]
        public void SkillPathJsonWithMultipleSkillPathsShouldDeserializeIntoMultipleSkillPathModels()
        {
            // Arrange
            const string Json = @"[
  {
    ""id"":""7e0ce425-0263-45ce-a6c1-186ae706654e"",
    ""iconUrl"":""https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png"",
    ""retired"":false,
    ""title"":""C#"",
    ""url"":""/paths/skills/csharp"",
    ""urlSlug"":""csharp""
  },
  {
    ""id"":""7e0ce425-0263-45ce-a6c1-186ae706654e"",
    ""iconUrl"":""https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png"",
    ""retired"":false,
    ""title"":""C#"",
    ""url"":""/paths/skills/csharp"",
    ""urlSlug"":""csharp""
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
