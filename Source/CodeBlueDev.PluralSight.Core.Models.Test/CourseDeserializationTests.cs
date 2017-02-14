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
        [Test]
        public void CourseJsonShouldDeserializeIntoCourseModel()
        {
            // Arrange
            const string Json = @"
            {
                ""id"":""windows-forms-best-practices"",
                ""publishedOn"":""2014-09-27T00:00:00Z"",
                ""updatedOn"":""2014-09-27T00:00:00Z"",
                ""title"":""Windows Forms Best Practices"",
                ""shortDescription"":""This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability."",
                ""description"":""This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application."",
                ""duration"":""PT4H35M57S"",
                ""popularityScore"":289905,
                ""hasTranscript"":true,
                ""hasAssessment"":true,
                ""hasLearningCheck"":true,
                ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
            }";

            // Act
            Course course = JsonConvert.DeserializeObject<Course>(Json);

            // Assert
            Assert.IsNotNull(course);
            Assert.AreEqual("windows-forms-best-practices", course.Id);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.PublishedOn);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.UpdatedOn);
            Assert.AreEqual("Windows Forms Best Practices", course.Title);
            Assert.IsFalse(string.IsNullOrEmpty(course.ShortDescription));
            Assert.IsFalse(string.IsNullOrEmpty(course.Description));
            Assert.AreEqual("PT4H35M57S", course.Duration);
            Assert.AreEqual(289905, course.PopularityScore);
            Assert.IsTrue(course.HasTranscript);
            Assert.IsTrue(course.HasAssessment);
            Assert.IsTrue(course.HasLearningCheck);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", course.PlayerUrl);
        }
    }
}
