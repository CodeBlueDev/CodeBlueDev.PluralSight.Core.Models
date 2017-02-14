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
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Clip objects.
    /// </summary>
    [TestFixture]
    public class CourseClipDeserializationTests
    {
        /// <summary>
        /// Tests if a Course Clip JSON block can be deserialized to a Course Clip model.
        /// </summary>
        [Test, Category("Course Clip")]
        public void ClipJsonShouldDeserializeIntoClipModel()
        {
            // Arrange
            const string Json = @"{
                ""id"":""windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01"",
                ""title"":""Module Introduction"",
                ""duration"":""PT57.051S"",
                ""playerUrl"":""/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live""
            }";

            // Act
            CourseClip clip = JsonConvert.DeserializeObject<CourseClip>(Json);

            // Assert
            Assert.IsNotNull(clip);
            Assert.AreEqual("windows-forms-best-practices|mark-heath|windows-forms-best-practices-m1|windows-forms-best-practices-m1-01", clip.Id);
            Assert.AreEqual("Module Introduction", clip.Title);
            Assert.AreEqual("PT57.051S", clip.Duration);
            Assert.AreEqual("/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", clip.PlayerUrl);
        }

        /// <summary>
        /// Tests if a Course Clip JSON block with multiple Course Clips can be deserialized to multiple Course Clip models.
        /// </summary>
        [Test, Category("Course Clip")]
        public void CourseClipJsonWithMultipleCourseClipsShouldDeserializeIntoMultipleCourseClipModels()
        {
            // Arrange
            const string Json = @"[
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
                }
            ]";

            // Act
            CourseClip[] clips = JsonConvert.DeserializeObject<CourseClip[]>(Json);

            // Assert
            Assert.IsNotNull(clips);
            Assert.AreEqual(2, clips.Length);
        }
    }
}
