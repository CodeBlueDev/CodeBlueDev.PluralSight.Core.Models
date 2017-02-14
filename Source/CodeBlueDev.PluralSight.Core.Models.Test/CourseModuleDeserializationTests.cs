namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

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
            const string Json = @"
            {
                ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
                ""title"":""Creating Excellent Windows Forms Applications"",
                ""duration"":""PT27M"",
                ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
            }";

            // Act
            CourseModule module = JsonConvert.DeserializeObject<CourseModule>(Json);

            // Assert
            Assert.IsNotNull(module);
            Assert.AreEqual("windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1", module.Id);
            Assert.AreEqual("Creating Excellent Windows Forms Applications", module.Title);
            Assert.AreEqual("PT27M", module.Duration);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", module.PlayerUrl);
        }

        /// <summary>
        /// Tests if a Course Module JSON block with multiple Modules can be deserialized to multiple Course Module models.
        /// </summary>
        [Test, Category("Course Module")]
        public void CourseModuleJsonWithMultipleCourseModulesShouldDeserializeIntoMultipleCourseModuleModels()
        {
            // Arrange
            const string Json = @"
            [
                {
                    ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
                    ""title"":""Creating Excellent Windows Forms Applications"",
                    ""duration"":""PT27M"",
                    ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
                },
                {
                    ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2"",
                    ""title"":""Resizing and Layout"",
                    ""duration"":""PT43M12S"",
                    ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=0&mode=live"",
                }
            ]";

            // Act
            CourseModule[] modules = JsonConvert.DeserializeObject<CourseModule[]>(Json);

            // Assert
            Assert.IsNotNull(modules);
            Assert.AreEqual(2, modules.Length);
        }
    }
}
