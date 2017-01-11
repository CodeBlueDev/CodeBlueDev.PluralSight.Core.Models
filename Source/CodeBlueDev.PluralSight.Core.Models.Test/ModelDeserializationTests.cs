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

        /// <summary>
        /// Tests if a Module JSON block can be deserialized to a Module model.
        /// </summary>
        [Test]
        public void ModuleJsonShouldDeserializeIntoModuleModel()
        {
            // Arrange
            const string Json = @"
            {
                ""userMayViewFirstClip"": false,
                ""moduleRef"": ""mark-heath/windows-forms-best-practices-m1"",
                ""title"": ""Creating Excellent Windows Forms Applications"",
                ""description"": ""This module discusses why you might still be using Windows Forms, despite it\n  now being a fairly old technology. We make the case that it is still possible to create\nexcellent applications in Windows Forms. We also introduce the demo application that we'll\nbe improving throughout this course, and begin by renaming controls, using data binding, and\nchecking that our forms have appropriate default properties set. "",
                ""duration"": ""00:27:00"",
                ""hasBeenViewed"": false,
                ""isHighlighted"": false,
                ""fragmentIdentifier"": ""windows-forms-best-practices-m1"",
                ""firstClipLaunchClickHandler"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices"",
                ""userMayBookmark"": false,
                ""isBookmarked"": false,
                ""clips"": [
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
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 2,
                    ""title"": ""Why Use Windows Forms?"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:01:27"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=2&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-03"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 3,
                    ""title"": ""Building Great Windows Forms Applications"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:01:59"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=3&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-04"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 4,
                    ""title"": ""Moving Away From Windows Forms"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:01:21"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=4&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-05"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 5,
                    ""title"": ""Course Prerequisites and Contents"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:02:40"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=5&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-06"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 6,
                    ""title"": ""Introducing the Demo Application"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:01:48"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=6&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-07"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 7,
                    ""title"": ""Naming Controls"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:02:17"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=7&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-08"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 8,
                    ""title"": ""Using Data Binding"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:05:12"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=8&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-09"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 9,
                    ""title"": ""Setting Default Properties on Forms"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:04:44"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=9&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-10"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  },
                  {
                    ""transcripts"": [],
                    ""clipIndex"": 10,
                    ""title"": ""Module Summary"",
                    ""hasBeenViewed"": false,
                    ""duration"": ""00:02:54"",
                    ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=10&course=windows-forms-best-practices"",
                    ""userMayViewClip"": false,
                    ""clickActionDescription"": ""View with player"",
                    ""isHighlighted"": false,
                    ""name"": ""windows-forms-best-practices-m1-11"",
                    ""isBookmarked"": false,
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                  }
                ],
                ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                ""hasBeenViewedAltText"": ""You have not watched this Module.""
            }";

            // Act
            Module module = JsonConvert.DeserializeObject<Module>(Json);

            // Assert
            Assert.IsNotNull(module);
            Assert.IsFalse(module.UserMayViewFirstClip);
            Assert.AreEqual("mark-heath/windows-forms-best-practices-m1", module.ModuleRef);
            Assert.AreEqual("Creating Excellent Windows Forms Applications", module.Title);
            Assert.AreEqual("This module discusses why you might still be using Windows Forms, despite it\n  now being a fairly old technology. We make the case that it is still possible to create\nexcellent applications in Windows Forms. We also introduce the demo application that we'll\nbe improving throughout this course, and begin by renaming controls, using data binding, and\nchecking that our forms have appropriate default properties set. ", module.Description);
            Assert.AreEqual(new TimeSpan(0, 27, 0), module.Duration);
            Assert.IsFalse(module.HasBeenViewed);
            Assert.IsFalse(module.IsHighlighted);
            Assert.AreEqual("windows-forms-best-practices-m1", module.FragmentIdentifier);
            Assert.AreEqual("author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices", module.FirstClipLaunchClickHandler);
            Assert.IsFalse(module.UserMayBookmark);
            Assert.IsFalse(module.IsBookmarked);
            Assert.IsNotNull(module.Clips);
            Assert.Greater(module.Clips.Length, 0);
            Assert.AreEqual("cs/has-not-been-viewed-checkmark-15-v1.png", module.HasBeenViewedImageUrl);
            Assert.AreEqual("You have not watched this Module.", module.HasBeenViewedAltText);
        }

        /// <summary>
        /// Tests if a Module JSON block with multiple Modules can be deserialized to multiple Module models.
        /// </summary>
        [Test]
        public void ModuleJsonWithMultipleModulesShouldDeserializeIntoMultipleModuleModels()
        {
            // Arrange
            const string Json = @"
            [
                {
                    ""userMayViewFirstClip"": false,
                    ""moduleRef"": ""mark-heath/windows-forms-best-practices-m1"",
                    ""title"": ""Creating Excellent Windows Forms Applications"",
                    ""description"": ""This module discusses why you might still be using Windows Forms, despite it\n  now being a fairly old technology. We make the case that it is still possible to create\nexcellent applications in Windows Forms. We also introduce the demo application that we'll\nbe improving throughout this course, and begin by renaming controls, using data binding, and\nchecking that our forms have appropriate default properties set. "",
                    ""duration"": ""00:27:00"",
                    ""hasBeenViewed"": false,
                    ""isHighlighted"": false,
                    ""fragmentIdentifier"": ""windows-forms-best-practices-m1"",
                    ""firstClipLaunchClickHandler"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices"",
                    ""userMayBookmark"": false,
                    ""isBookmarked"": false,
                    ""clips"": [
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
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 2,
                        ""title"": ""Why Use Windows Forms?"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:27"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=2&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-03"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 3,
                        ""title"": ""Building Great Windows Forms Applications"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:59"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=3&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-04"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 4,
                        ""title"": ""Moving Away From Windows Forms"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:21"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=4&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-05"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 5,
                        ""title"": ""Course Prerequisites and Contents"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:40"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=5&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-06"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 6,
                        ""title"": ""Introducing the Demo Application"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:48"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=6&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-07"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 7,
                        ""title"": ""Naming Controls"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:17"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=7&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-08"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 8,
                        ""title"": ""Using Data Binding"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:05:12"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=8&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-09"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 9,
                        ""title"": ""Setting Default Properties on Forms"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:04:44"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=9&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-10"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 10,
                        ""title"": ""Module Summary"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:54"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=10&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m1-11"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      }
                    ],
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Module.""
                },
                {
                    ""userMayViewFirstClip"": false,
                    ""moduleRef"": ""mark-heath/windows-forms-best-practices-m2"",
                    ""title"": ""Resizing and Layout"",
                    ""description"": ""This module explores several techniques in Windows Forms to enable your application to have an excellent resize experience. We'll also consider several different options for laying out your user interface to show the most important data and commands."",
                    ""duration"": ""00:43:12"",
                    ""hasBeenViewed"": false,
                    ""isHighlighted"": false,
                    ""fragmentIdentifier"": ""windows-forms-best-practices-m2"",
                    ""firstClipLaunchClickHandler"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=0&course=windows-forms-best-practices"",
                    ""userMayBookmark"": false,
                    ""isBookmarked"": false,
                    ""clips"": [
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 0,
                        ""title"": ""Module Introduction"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:57"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=0&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-01"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 1,
                        ""title"": ""Resizing"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:46"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=1&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-02"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 2,
                        ""title"": ""Demo - Anchoring Controls"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:03:02"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=2&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-03"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 3,
                        ""title"": ""Demo - Resizing Labels"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:20"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=3&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-04"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 4,
                        ""title"": ""Demo - Split Container"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:05:32"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=4&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-05"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 5,
                        ""title"": ""Demo - Table Layout Panel"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:41"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=5&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-06"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 6,
                        ""title"": ""Demo - Minimum Sizes"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:01:13"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=6&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-07"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 7,
                        ""title"": ""Demo - Flow Layout Panel"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:04:44"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=7&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-08"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 8,
                        ""title"": ""Layouts"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:07:09"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=8&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-09"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 9,
                        ""title"": ""Demo - Explorer Style Layout"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:06:30"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=9&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-10"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 10,
                        ""title"": ""Demo - Creating the Podcasts View"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:57"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=10&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-11"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      },
                      {
                        ""transcripts"": [],
                        ""clipIndex"": 11,
                        ""title"": ""Module Summary"",
                        ""hasBeenViewed"": false,
                        ""duration"": ""00:02:18"",
                        ""playerParameters"": ""author=mark-heath&name=windows-forms-best-practices-m2&mode=live&clip=11&course=windows-forms-best-practices"",
                        ""userMayViewClip"": false,
                        ""clickActionDescription"": ""View with player"",
                        ""isHighlighted"": false,
                        ""name"": ""windows-forms-best-practices-m2-12"",
                        ""isBookmarked"": false,
                        ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                        ""hasBeenViewedAltText"": ""You have not watched this Clip.""
                      }
                    ],
                    ""hasBeenViewedImageUrl"": ""cs/has-not-been-viewed-checkmark-15-v1.png"",
                    ""hasBeenViewedAltText"": ""You have not watched this Module.""
                }
            ]";

            // Act
            Module[] modules = JsonConvert.DeserializeObject<Module[]>(Json);

            // Assert
            Assert.IsNotNull(modules);
            Assert.AreEqual(2, modules.Length);

            foreach (Module module in modules)
            {
                Assert.IsNotNull(module.Clips);
                Assert.Greater(module.Clips.Length, 0);
            }
        }
    }
}
