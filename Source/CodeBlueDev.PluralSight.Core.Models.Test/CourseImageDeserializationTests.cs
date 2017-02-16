// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseImageDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Course objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Course objects.
    /// </summary>
    [TestFixture]
    public class CourseImageDeserializationTests
    {
        // TODO: Find a course with a valid course image

        /// <summary>
        /// Tests that a JSON response with null values is deserialized correctly to a CourseImage model with null values.
        /// </summary>
        [Test, Category("Course Image")]
        public void CourseImageJsonWithNullValuesShouldDeserializeToCourseImageModel()
        {
            // Arrange
            string Json = @"
            {
              ""courseListUrl"":null,
              ""defaultUrl"":null,
              ""smallUrl"":null
            }";

            // Act
            CourseImage courseImage = JsonConvert.DeserializeObject<CourseImage>(Json);

            // Assert
            Assert.IsNotNull(courseImage);
            Assert.IsNull(courseImage.CourseListUrl);
            Assert.IsNull(courseImage.DefaultUrl);
            Assert.IsNull(courseImage.SmallUrl);
        }
    }
}
