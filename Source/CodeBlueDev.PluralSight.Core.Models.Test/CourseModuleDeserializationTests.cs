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

        /// <summary>
        /// Tests if a Course Module JSON block with multiple Course Clips can be deserialized.
        /// </summary>
        [Test, Category("Course Module")]
        public void CourseModuleJsonWithMultipleCourseClipsShouldDeserializeWithMultipleCourseClips()
        {
            // Arrange
            const string Json = @"
             {
                 ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1"",
                 ""title"":""Creating Excellent Windows Forms Applications"",
                 ""duration"":""PT27M"",
                 ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
                 ""clips"":[  
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
                       ""title"":""Module Introduction"",
                       ""duration"":""PT57.051S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-02"",
                       ""title"":""Is Windows Forms Dead?"",
                       ""duration"":""PT1M36.572S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=1&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-03"",
                       ""title"":""Why Use Windows Forms?"",
                       ""duration"":""PT1M27.052000000000007S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=2&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-04"",
                       ""title"":""Building Great Windows Forms Applications"",
                       ""duration"":""PT1M59.837999999999994S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=3&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-05"",
                       ""title"":""Moving Away From Windows Forms"",
                       ""duration"":""PT1M21.525000000000006S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=4&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-06"",
                       ""title"":""Course Prerequisites and Contents"",
                       ""duration"":""PT2M40.52000000000001S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=5&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-07"",
                       ""title"":""Introducing the Demo Application"",
                       ""duration"":""PT1M48.715999999999994S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=6&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-08"",
                       ""title"":""Naming Controls"",
                       ""duration"":""PT2M17.578000000000003S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=7&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-09"",
                       ""title"":""Using Data Binding"",
                       ""duration"":""PT5M12.586999999999989S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=8&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-10"",
                       ""title"":""Setting Default Properties on Forms"",
                       ""duration"":""PT4M44.51400000000001S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=9&mode=live""
                    },
                    {  
                       ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-11"",
                       ""title"":""Module Summary"",
                       ""duration"":""PT2M54.77699999999999S"",
                       ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=10&mode=live""
                    }
                 ]
              }";

            // Act
            CourseModule module = JsonConvert.DeserializeObject<CourseModule>(Json);

            // Assert
            Assert.IsNotNull(module);
            Assert.IsTrue(module.Clips.Any());
        }
    }
}
