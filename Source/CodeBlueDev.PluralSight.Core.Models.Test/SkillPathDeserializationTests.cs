// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkillPathDeserializationTests.cs" company="">
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
        [Test, Category("Skill Path")]
        public void SkillPathJsonShouldDeserializeIntoSkillPathModel()
        {
            // Arrange
            const string Json = @"
            {
                ""id"":""aa6392b6-3da4-4698-8b48-b71f11af3213"",
                ""title"":""C#"",
                ""retired"":false,
                ""url"":""/paths/skills/csharp"",
                ""urlSlug"":""csharp"",
                ""iconUrl"":""https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png""
            }";

            // Act
            SkillPath skillPath = JsonConvert.DeserializeObject<SkillPath>(Json);

            // Assert
            Assert.IsNotNull(skillPath);
            Assert.AreEqual(Guid.Parse("aa6392b6-3da4-4698-8b48-b71f11af3213"), skillPath.Id);
            Assert.AreEqual("C#", skillPath.Title);
            Assert.IsFalse(skillPath.Retired);
            Assert.AreEqual("/paths/skills/csharp", skillPath.Url);
            Assert.AreEqual("csharp", skillPath.UrlSlug);
            Assert.AreEqual("https://pluralsight.imgix.net/paths/path-icons/csharp-e7b8fcd4ce.png", skillPath.IconUrl);
        }
    }
}
