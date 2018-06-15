// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseClipDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Clip objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Clip objects.
    /// </summary>
    [TestFixture]
    public class CourseClipDeserializationTests
    {
        /// <summary>
        /// Tests if a Course Module Clip JSON block can be deserialized to a Course Module Clip model.
        /// </summary>
        [Category("Course Module Clip")]
        [Test]
        public void ClipJsonShouldDeserializeIntoClipModel()
        {
            // Arrange
            const string Json = @"{
          ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
          ""clipId"": ""d9b3e34e-7ddd-4201-a703-0145fbb689f7"",
          ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
          ""title"": ""Module Introduction"",
          ""duration"": ""PT57.0510000S"",
          ""moduleTitle"": ""Creating Excellent Windows Forms Applications"",
          ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
          ""ordering"": 0
        }";

            // Act
            CourseModuleClip clip = JsonConvert.DeserializeObject<CourseModuleClip>(Json);

            // Assert
            Assert.IsNotNull(clip);
            Assert.AreEqual("windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01", clip.Id);
            Assert.AreEqual(Guid.Parse("d9b3e34e-7ddd-4201-a703-0145fbb689f7"), clip.ClipId);
            Assert.AreEqual("mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01", clip.DeprecatedId);
            Assert.AreEqual("Module Introduction", clip.Title);
            Assert.AreEqual("PT57.0510000S", clip.Duration);
            Assert.AreEqual("Creating Excellent Windows Forms Applications", clip.ModuleTitle);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", clip.PlayerUrl);
            Assert.AreEqual(0, clip.Index);
        }

        /// <summary>
        /// Tests if a Course Module Clip JSON block with multiple Course Module Clips can be deserialized to multiple Course Module Clip models.
        /// </summary>
        [Category("Course Module Clip")]
        [Test]
        public void CourseClipJsonWithMultipleCourseClipsShouldDeserializeIntoMultipleCourseClipModels()
        {
            // Arrange
            const string Json = @"[
        {
          ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
          ""clipId"": ""d9b3e34e-7ddd-4201-a703-0145fbb689f7"",
          ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
          ""title"": ""Module Introduction"",
          ""duration"": ""PT57.0510000S"",
          ""moduleTitle"": ""Creating Excellent Windows Forms Applications"",
          ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
          ""ordering"": 0
        },
        {
          ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-02"",
          ""clipId"": ""23e0dc65-cf48-4b9d-b72d-0c843f75d65d"",
          ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-02"",
          ""title"": ""Is Windows Forms Dead?"",
          ""duration"": ""PT96.5720000S"",
          ""moduleTitle"": ""Creating Excellent Windows Forms Applications"",
          ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=1&mode=live"",
          ""ordering"": 1
        }
      ]";

            // Act
            CourseModuleClip[] clips = JsonConvert.DeserializeObject<CourseModuleClip[]>(Json);

            // Assert
            Assert.IsNotNull(clips);
            Assert.AreEqual(2, clips.Length);
        }
    }
}
