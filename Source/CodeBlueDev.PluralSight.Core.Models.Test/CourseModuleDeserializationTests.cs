// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseModuleDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests if a Course Module JSON block can be deserialized to a Course Module model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests if a Course Module JSON block can be deserialized to a Course Module model.
    /// </summary>
    [TestFixture]
    public class CourseModuleDeserializationTests
    {
        /// <summary>
        /// Tests if a Course Module JSON block can be deserialized to a Course Module model.
        /// </summary>
        [Test, Category("Course Module")]
        public void CourseModuleJsonShouldDeserializeIntoCourseModuleModel()
        {
            // Arrange
            const string Json = @"{
      ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
      ""moduleId"": ""4617ec56-4a2b-4a4b-8e05-a82d558079e1"",
      ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1"",
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""title"": ""Creating Excellent Windows Forms Applications"",
      ""duration"": ""PT1620.7300000S"",
      ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
    }";

            // Act
            CourseModule module = JsonConvert.DeserializeObject<CourseModule>(Json);

            // Assert
            Assert.IsNotNull(module);
            Assert.AreEqual("windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1", module.Id);
            Assert.AreEqual(Guid.Parse("4617ec56-4a2b-4a4b-8e05-a82d558079e1"), module.ModuleId);
            Assert.AreEqual("mark-heath|windows-forms-best-practices-m1", module.DeprecatedId);
            Assert.AreEqual(Guid.Parse("75098b43-9787-43af-ab9d-a1994cede9a4"), module.AuthorId);
            Assert.AreEqual("Creating Excellent Windows Forms Applications", module.Title);
            Assert.AreEqual("PT1620.7300000S", module.Duration);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", module.PlayerUrl);
        }

        /// <summary>
        /// Tests if a Course Module JSON block with multiple Modules can be deserialized to multiple Course Module models.
        /// </summary>
        [Test, Category("Course Module")]
        public void CourseModuleJsonWithMultipleCourseModulesShouldDeserializeIntoMultipleCourseModuleModels()
        {
            // Arrange
            const string Json = @"[
    {
      ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
      ""moduleId"": ""4617ec56-4a2b-4a4b-8e05-a82d558079e1"",
      ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1"",
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""title"": ""Creating Excellent Windows Forms Applications"",
      ""duration"": ""PT1620.7300000S"",
      ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
    },
    {
      ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
      ""moduleId"": ""4617ec56-4a2b-4a4b-8e05-a82d558079e1"",
      ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1"",
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""title"": ""Creating Excellent Windows Forms Applications"",
      ""duration"": ""PT1620.7300000S"",
      ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
    }
]";

            // Act
            CourseModule[] modules = JsonConvert.DeserializeObject<CourseModule[]>(Json);

            // Assert
            Assert.IsNotNull(modules);
            Assert.AreEqual(2, modules.Length);
        }

        /// <summary>
        /// Tests if a Course Module JSON block with multiple Course Clips can be deserialized.
        /// </summary>
        [Test, Category("Course Module")]
        public void CourseModuleJsonWithMultipleCourseClipsShouldDeserializeWithMultipleCourseClips()
        {
            // Arrange
            const string Json = @"{
      ""id"": ""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
      ""moduleId"": ""4617ec56-4a2b-4a4b-8e05-a82d558079e1"",
      ""deprecatedId"": ""mark-heath|windows-forms-best-practices-m1"",
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""title"": ""Creating Excellent Windows Forms Applications"",
      ""duration"": ""PT1620.7300000S"",
      ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
      ""clips"": [
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
      ]
    }";

            // Act
            CourseModule module = JsonConvert.DeserializeObject<CourseModule>(Json);

            // Assert
            Assert.IsNotNull(module);
            Assert.IsNotNull(module.Clips);
            Assert.IsTrue(module.Clips.Any());
            Assert.AreEqual(2, module.Clips.Length);
        }
    }
}
