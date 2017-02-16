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

        /// <summary>
        /// Tests if a Course JSON block with multiple Modules can be deserialized within the Course Model.
        /// </summary>
        [Test, Category("Course")]
        public void FullCourseJsonWithMultipleModulesShouldDeserializeIntoFullCourseModelWithMultipleCourseModules()
        {
            // Arrange
            string Json = @"
            {
               ""id"":""windows-forms-best-practices"",
               ""publishedOn"":""2014-09-27T00:00:00Z"",
               ""updatedOn"":""2014-09-27T00:00:00Z"",
               ""title"":""Windows Forms Best Practices"",
               ""shortDescription"":""This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability."",
               ""description"":""This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application."",
               ""level"":""Intermediate"",
               ""duration"":""PT4H35M57S"",
               ""popularityScore"":257732,
               ""hasTranscript"":true,
               ""hasAssessment"":true,
               ""hasLearningCheck"":true,
               ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
               ""skillPaths"":null,
               ""retired"":{
                  ""isRetired"":false,
                  ""reason"":"""",
                  ""replacementId"":""""
               },
               ""rating"":{
                  ""average"":4.6,
                  ""ratersCount"":298
               },
               ""modules"":[
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
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2"",
                     ""title"":""Resizing and Layout"",
                     ""duration"":""PT43M12S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT1M57.05200000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-02"",
                           ""title"":""Resizing"",
                           ""duration"":""PT2M46.185S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-03"",
                           ""title"":""Demo - Anchoring Controls"",
                           ""duration"":""PT3M2.1839999999999975S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-04"",
                           ""title"":""Demo - Resizing Labels"",
                           ""duration"":""PT2M20.039999999999992S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-05"",
                           ""title"":""Demo - Split Container"",
                           ""duration"":""PT5M32.185S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-06"",
                           ""title"":""Demo - Table Layout Panel"",
                           ""duration"":""PT2M41.16999999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-07"",
                           ""title"":""Demo - Minimum Sizes"",
                           ""duration"":""PT1M13.375S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-08"",
                           ""title"":""Demo - Flow Layout Panel"",
                           ""duration"":""PT4M44.259000000000015S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-09"",
                           ""title"":""Layouts"",
                           ""duration"":""PT7M9.591999999999985S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-10"",
                           ""title"":""Demo - Explorer Style Layout"",
                           ""duration"":""PT6M30.97800000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=9&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-11"",
                           ""title"":""Demo - Creating the Podcasts View"",
                           ""duration"":""PT2M57.656000000000006S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=10&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m2|windows-forms-best-practices-m2-12"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT2M18.320999999999998S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m2&clip=11&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3"",
                     ""title"":""Usability, Accessibility, and Localization"",
                     ""duration"":""PT46M59S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT1M55.983999999999995S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-02"",
                           ""title"":""Accessibility"",
                           ""duration"":""PT2M34.715S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-03"",
                           ""title"":""Demo - Accessibility"",
                           ""duration"":""PT4M38.45400000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-04"",
                           ""title"":""Keyboard Navigation"",
                           ""duration"":""PT4M43.98000000000002S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-05"",
                           ""title"":""Demo - Keyboard Navigation"",
                           ""duration"":""PT5M10.77600000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-06"",
                           ""title"":""Usability"",
                           ""duration"":""PT4M18.97199999999998S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-07"",
                           ""title"":""Helping the User to Get it Right"",
                           ""duration"":""PT3M33.64699999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-08"",
                           ""title"":""Demo - Tooltips"",
                           ""duration"":""PT1M41.587S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-09"",
                           ""title"":""Demo - First Run and ErrorProvider"",
                           ""duration"":""PT3M43.30600000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-10"",
                           ""title"":""Localization"",
                           ""duration"":""PT5M7.6410000000000196S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=9&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-11"",
                           ""title"":""Demo - Localization"",
                           ""duration"":""PT6M24.987000000000023S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=10&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m3|windows-forms-best-practices-m3-12"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT3M5.318000000000012S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m3&clip=11&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4"",
                     ""title"":""Exceptions and Threading"",
                     ""duration"":""PT37M37S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT3M26.123999999999995S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-02"",
                           ""title"":""Unhandled Exceptions"",
                           ""duration"":""PT1M54.59S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-03"",
                           ""title"":""Global Exception Handlers"",
                           ""duration"":""PT1M32.578S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-04"",
                           ""title"":""Exception Handling Guidelines"",
                           ""duration"":""PT2M16.324000000000012S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-05"",
                           ""title"":""Where to Handle Exceptions"",
                           ""duration"":""PT2M29.907999999999987S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-06"",
                           ""title"":""Demo - Global Exception Handler"",
                           ""duration"":""PT2M31.85900000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-07"",
                           ""title"":""Demo - Handling Anticipated Exceptions"",
                           ""duration"":""PT3M58.19S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-08"",
                           ""title"":""Ways to Start a Thread"",
                           ""duration"":""PT7M14.375999999999976S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-09"",
                           ""title"":""Updating the User Interface"",
                           ""duration"":""PT1M57.656000000000006S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-10"",
                           ""title"":""While a Task Is Running"",
                           ""duration"":""PT1M33.971000000000004S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=9&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-11"",
                           ""title"":""Demo - Awaiting a Task"",
                           ""duration"":""PT4M16.975000000000023S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=10&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-12"",
                           ""title"":""Demo - Thread Exceptions and Timeouts"",
                           ""duration"":""PT2M15.256S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=11&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m4|windows-forms-best-practices-m4-13"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT2M9.77600000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m4&clip=12&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5"",
                     ""title"":""Patterns for Maintainable Code"",
                     ""duration"":""PT44M5S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT4M47.649S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-02"",
                           ""title"":""Segregate Your User Interface"",
                           ""duration"":""PT3M0.6510000000000105S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-03"",
                           ""title"":""Extract Business Logic From Code Behind"",
                           ""duration"":""PT3M44.44399999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-04"",
                           ""title"":""More Business Logic to Extract"",
                           ""duration"":""PT1M17.322000000000003S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-05"",
                           ""title"":""The Model View Presenter Pattern"",
                           ""duration"":""PT2M1.718999999999994S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-06"",
                           ""title"":""Creating View Interfaces"",
                           ""duration"":""PT4M57.12299999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-07"",
                           ""title"":""Connecting the Presenter"",
                           ""duration"":""PT2M14.837999999999994S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-08"",
                           ""title"":""Refactoring the MainForm Presenter"",
                           ""duration"":""PT2M29.25800000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-09"",
                           ""title"":""The Command Pattern"",
                           ""duration"":""PT2M27.191000000000003S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-10"",
                           ""title"":""Implementing the Command Pattern"",
                           ""duration"":""PT4M39.59100000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=9&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-11"",
                           ""title"":""Event Aggregators"",
                           ""duration"":""PT3M5.248999999999995S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=10&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-12"",
                           ""title"":""Using an Event Aggregator"",
                           ""duration"":""PT6M8.384999999999991S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=11&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m5|windows-forms-best-practices-m5-13"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT3M12.051999999999992S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m5&clip=12&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6"",
                     ""title"":""Creating Custom Controls"",
                     ""duration"":""PT42M29S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT3M34.042S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-02"",
                           ""title"":""Choosing a Starting Point"",
                           ""duration"":""PT4M20.249000000000024S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-03"",
                           ""title"":""Creating a Custom Control"",
                           ""duration"":""PT1M3.4369999999999976S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-04"",
                           ""title"":""Drawing With GDI+"",
                           ""duration"":""PT3M12.656000000000006S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-05"",
                           ""title"":""Rendering the Waveform"",
                           ""duration"":""PT5M23.17500000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-06"",
                           ""title"":""Adding in Scrollbars"",
                           ""duration"":""PT3M53.17500000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-07"",
                           ""title"":""Showing the Playback Position"",
                           ""duration"":""PT4M52.988999999999976S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-08"",
                           ""title"":""Repositioning With the Mouse"",
                           ""duration"":""PT3M54.638000000000005S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-09"",
                           ""title"":""Drag and Scroll Repositioning"",
                           ""duration"":""PT4M42.91199999999998S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-10"",
                           ""title"":""Creating Drop-Down Forms"",
                           ""duration"":""PT3M34.18100000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=9&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m6|windows-forms-best-practices-m6-11"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT3M58.12100000000001S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m6&clip=10&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7"",
                     ""title"":""Interoperability"",
                     ""duration"":""PT24M22S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT2M14.443999999999988S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-02"",
                           ""title"":""Invoking Windows APIs"",
                           ""duration"":""PT3M6.5260000000000105S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-03"",
                           ""title"":""Touch Support Demo"",
                           ""duration"":""PT2M19.040999999999997S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-04"",
                           ""title"":""Hosting Web Content"",
                           ""duration"":""PT2M40.589S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-05"",
                           ""title"":""WebBrowser Demo"",
                           ""duration"":""PT2M5.248000000000005S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-06"",
                           ""title"":""Rendering HTML Fragments"",
                           ""duration"":""PT1M13.305000000000007S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=5&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-07"",
                           ""title"":""Accessing the DOM"",
                           ""duration"":""PT2M5.573999999999998S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=6&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-08"",
                           ""title"":""Hosting WPF Content"",
                           ""duration"":""PT4M31.440999999999974S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=7&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-09"",
                           ""title"":""Incremental Migration"",
                           ""duration"":""PT2M18.181999999999988S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=8&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m7|windows-forms-best-practices-m7-10"",
                           ""title"":""Module Summary"",
                           ""duration"":""PT1M48.182S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m7&clip=9&mode=live""
                        }
                     ]
                  },
                  {
                     ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8"",
                     ""title"":""Conclusion"",
                     ""duration"":""PT10M13S"",
                     ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=0&mode=live"",
                     ""clips"":[
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-01"",
                           ""title"":""Module Introduction"",
                           ""duration"":""PT1M14.257000000000005S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=0&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-02"",
                           ""title"":""User Experience"",
                           ""duration"":""PT2M34.78399999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=1&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-03"",
                           ""title"":""Coding Practices"",
                           ""duration"":""PT2M23.77799999999999S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=2&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-04"",
                           ""title"":""Extensibility"",
                           ""duration"":""PT1M35.456999999999994S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=3&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-05"",
                           ""title"":""The Demo Application"",
                           ""duration"":""PT1M41.378S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=4&mode=live""
                        },
                        {
                           ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m8|windows-forms-best-practices-m8-06"",
                           ""title"":""Course Conclusion"",
                           ""duration"":""PT44.304S"",
                           ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m8&clip=5&mode=live""
                        }
                     ]
                  }
               ],
               ""courseImage"":{
                  ""courseListUrl"":null,
                  ""defaultUrl"":null,
                  ""smallUrl"":null
               },
               ""authors"":[
                  {
                     ""id"":""mark-heath"",
                     ""firstName"":""Mark"",
                     ""lastName"":""Heath"",
                     ""displayName"":""Mark Heath""
                  }
               ],
               ""audiences"":[
                  ""software-development""
               ]
            }";

            // Act
            Course course = JsonConvert.DeserializeObject<Course>(Json);

            // Assert
            Assert.IsNotNull(course);
            Assert.AreEqual(CourseLevel.Intermediate, course.Level);
            Assert.IsTrue(course.Modules.Any());
            Assert.IsNull(course.SkillPaths);
            Assert.IsNotNull(course.Retired);
            Assert.IsNotNull(course.Rating);
            Assert.IsNotNull(course.CourseImage);
            Assert.IsNotNull(course.Authors);
            Assert.IsTrue(course.Authors.Any());
            Assert.IsNotNull(course.Audiences);
            Assert.IsTrue(course.Audiences.Any());
        }
    }
}
