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

        /// <summary>
        /// Tests if a Course JSON block can be deserialized to a Course model.
        /// </summary>
        [Test]
        public void CourseJsonShouldDeserializeIntoCourseModel()
        {
            // Arrange
            const string Json = @"
            {
                ""title"":""Windows Forms Best Practices"",
                ""level"":""Intermediate"",
                ""duration"":""04:35:57"",
                ""releaseDate"":""2014-09-27T00:00:00Z"",
                ""name"":""windows-forms-best-practices"",
                ""authors"":[
                    {
                        ""handle"":""mark-heath"",
                        ""firstName"":""Mark"",
                        ""lastName"":""Heath""
                    }
                ],
                ""hasTranscript"":true,
                ""courseRating"":
                {
                    ""currentUsersRating"":0,
                    ""averageRating"":4.6,
                    ""rating"":4.6,
                    ""canRateThisCourse"":false,
                    ""courseName"":""windows-forms-best-practices"",
                    ""numberOfRaters"":297,
                    ""hasUserRatedCourse"":false
                },
                ""isRetired"":true,
                ""shortDescription"":""This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability."",
                ""description"":""This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application."",
                ""isBookmarked"":true,
                ""userMaySaveCourse"":true,
                ""replacementCourseName"":"""",
                ""retiredReason"":"""",
                ""replacementCourseTitle"":"""",
                ""isValid"":true,
                ""isUserAuthorizedForTranscript"":true
            }";

            // Act
            Course course = JsonConvert.DeserializeObject<Course>(Json);

            // Assert
            Assert.IsNotNull(course);
            Assert.AreEqual("Windows Forms Best Practices", course.Title);
            Assert.AreEqual(new TimeSpan(4, 35, 57), course.Duration);
            Assert.AreEqual(new DateTime(2014, 9, 27), course.ReleaseDate);
            Assert.AreEqual("windows-forms-best-practices", course.Name);
            Assert.IsNotNull(course.Authors);
            Assert.AreEqual(1, course.Authors.Length);
            Assert.IsTrue(course.HasTranscript);
            Assert.IsNotNull(course.CourseRating);
            Assert.IsTrue(course.IsRetired);
            Assert.IsFalse(string.IsNullOrEmpty(course.ShortDescription));
            Assert.IsFalse(string.IsNullOrEmpty(course.Description));
            Assert.IsTrue(course.IsBookmarked);
            Assert.IsTrue(course.UserMaySaveCourse);
            Assert.IsTrue(string.IsNullOrEmpty(course.ReplacementCourseName));
            Assert.IsTrue(string.IsNullOrEmpty(course.RetiredReason));
            Assert.IsTrue(string.IsNullOrEmpty(course.ReplacementCourseTitle));
            Assert.IsTrue(course.IsValid);
            Assert.IsTrue(course.IsUserAuthorizedForTranscript);
        }

        /// <summary>
        /// Tests if a JSON block for a 'Beginner' Course Level can be deserialized to the appropriate CourseLevel enum value.
        /// </summary>
        [Test]
        public void BeginnerCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string Json = @"""Beginner""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(Json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }

        /// <summary>
        /// Tests if a JSON block for an 'Intermediate' Course Level can be deserialize to the appropriate CourseLevel enum value.
        /// </summary>
        [Test]
        public void IntermediateCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string Json = @"""Intermediate""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(Json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }

        /// <summary>
        /// Tests if a JSON block for an 'Advanced' Course Level can deserialized to the appropriate CourseLevel enum value.
        /// </summary>
        [Test]
        public void AdvancedCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string Json = @"""Advanced""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(Json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }

        /// <summary>
        /// Tests if a Course Rating JSON block can be deserialized to a Course Rating model.
        /// </summary>
        [Test]
        public void CourseRatingJsonShouldDeserializeIntoCourseRatingModel()
        {
            // Arrange
            const string Json = @"
            {
                ""currentUsersRating"":0,
                ""averageRating"":4.6,
                ""rating"":4.6,
                ""canRateThisCourse"":true,
                ""courseName"":""windows-forms-best-practices"",
                ""numberOfRaters"":297,
                ""hasUserRatedCourse"":true
            }";

            // Act
            CourseRating courseRating = JsonConvert.DeserializeObject<CourseRating>(Json);

            // Assert
            Assert.IsNotNull(courseRating);
            Assert.AreEqual(0, courseRating.CurrentUsersRating);
            Assert.AreEqual(4.6, courseRating.AverageRating);
            Assert.AreEqual(4.6, courseRating.Rating);
            Assert.IsTrue(courseRating.CanRateThisCourse);
            Assert.AreEqual("windows-forms-best-practices", courseRating.CourseName);
            Assert.AreEqual(297, courseRating.NumberOfRaters);
            Assert.IsTrue(courseRating.HasUserRatedCourse);
        }
    }
}
