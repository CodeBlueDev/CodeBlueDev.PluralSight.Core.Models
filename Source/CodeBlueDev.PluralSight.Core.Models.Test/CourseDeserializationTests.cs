// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Course objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Course objects.
    /// </summary>
    [TestFixture]
    public class CourseDeserializationTests
    {
        /// <summary>
        /// Tests if a Course JSON block can be deserialized to a Course model.
        /// </summary>
        [Category("Course")]
        [Test]
        public void CourseJsonShouldDeserializeIntoCourseModel()
        {
            // Arrange
            const string Json = @"{
  ""id"": ""windows-forms-best-practices"",
  ""courseId"": ""24f3e2ce-88bc-44f5-a9b7-3b0f326c3494"",
  ""slug"": ""windows-forms-best-practices"",
  ""publishedOn"": ""2014-09-27"",
  ""updatedOn"": ""2014-09-27"",
  ""displayDate"": ""2014-09-27"",
  ""title"": ""Windows Forms Best Practices"",
  ""shortDescription"": ""This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability."",
  ""description"": ""This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application."",
  ""level"": ""Intermediate"",
  ""duration"": ""PT16562.2140000S"",
  ""popularityScore"": 229685,
  ""courseImageUrl"": ""https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg"",
  ""audiences"": [
    ""software-development""
  ],
  ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
  ""hasLearningCheck"": true,
  ""hasTranscript"": true
}";

            // Act
            Course course = JsonConvert.DeserializeObject<Course>(Json);

            // Assert
            Assert.IsNotNull(course);
            Assert.AreEqual("windows-forms-best-practices", course.Id);
            Assert.AreEqual(Guid.Parse("24f3e2ce-88bc-44f5-a9b7-3b0f326c3494"), course.CourseId);
            Assert.AreEqual("windows-forms-best-practices", course.Slug);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.PublishedDate);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.UpdatedDate);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.DisplayDate);
            Assert.AreEqual("Windows Forms Best Practices", course.Title);
            Assert.IsFalse(string.IsNullOrEmpty(course.ShortDescription));
            Assert.IsFalse(string.IsNullOrEmpty(course.Description));
            Assert.AreEqual(CourseLevel.Intermediate, course.Level);
            Assert.AreEqual("PT16562.2140000S", course.Duration);
            Assert.AreEqual(229685, course.PopularityScore);
            Assert.AreEqual("https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg", course.CourseImageUrl);
            Assert.IsNotNull(course.Audiences);
            Assert.IsTrue(course.Audiences.Any());
            Assert.AreEqual(new string[] { "software-development" }, course.Audiences);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", course.PlayerUrl);
            Assert.IsTrue(course.IsTranscriptAvailable);
            Assert.IsTrue(course.IsLearningCheckAvailable);
        }

        /// <summary>
        /// Tests if a Course JSON block with multiple Modules can be deserialized within the Course Model.
        /// </summary>
        [Category("Course")]
        [Test]
        public void FullCourseJsonWithMultipleModulesShouldDeserializeIntoFullCourseModelWithMultipleCourseModules()
        {
            // Arrange
            const string Json = @"{
  ""id"": ""windows-forms-best-practices"",
  ""courseId"": ""24f3e2ce-88bc-44f5-a9b7-3b0f326c3494"",
  ""slug"": ""windows-forms-best-practices"",
  ""publishedOn"": ""2014-09-27"",
  ""updatedOn"": ""2014-09-27"",
  ""displayDate"": ""2014-09-27"",
  ""title"": ""Windows Forms Best Practices"",
  ""shortDescription"": ""This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability."",
  ""description"": ""This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application."",
  ""level"": ""Intermediate"",
  ""duration"": ""PT16562.2140000S"",
  ""popularityScore"": 229685,
  ""courseImageUrl"": ""https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg"",
  ""playerUrl"": ""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
  ""hasLearningCheck"": true,
  ""hasTranscript"": true,
  ""rating"": {
    ""average"": 4.6,
    ""ratersCount"": 316
  },
  ""courseImage"": {
    ""alt"": ""Windows Forms Best Practices"",
    ""url"": ""https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg"",
    ""isDefault"": false
  },
  ""image"": {
    ""alt"": ""Windows Forms Best Practices"",
    ""url"": ""https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg"",
    ""isDefault"": false
  },
  ""audiences"": [
    ""software-development""
  ],
  ""modules"": [
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
  ],
  ""authors"": [
    {
      ""authorId"": ""75098b43-9787-43af-ab9d-a1994cede9a4"",
      ""id"": ""mark-heath"",
      ""handle"": ""mark-heath"",
      ""firstName"": ""Mark"",
      ""lastName"": ""Heath"",
      ""displayName"": ""Mark Heath""
    }
  ],
  ""skillPaths"": []
}";

            // Act
            Course course = JsonConvert.DeserializeObject<Course>(Json);

            // Assert
            Assert.IsNotNull(course);
            Assert.IsNotNull(course.Rating);
            Assert.IsNotNull(course.CourseImage);
            Assert.IsNotNull(course.Image);
            Assert.IsNotNull(course.Audiences);
            Assert.IsTrue(course.Audiences.Any());
            Assert.IsNotNull(course.Modules);
            Assert.IsTrue(course.Modules.Any());
            Assert.AreEqual(2, course.Modules.Length);
            Assert.IsNotNull(course.Authors);
            Assert.IsTrue(course.Authors.Any());
            Assert.IsNotNull(course.SkillPaths);
            Assert.IsFalse(course.SkillPaths.Any());
        }
    }
}
