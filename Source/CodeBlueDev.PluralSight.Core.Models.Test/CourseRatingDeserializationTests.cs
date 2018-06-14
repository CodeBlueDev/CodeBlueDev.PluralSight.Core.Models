// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseRatingDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight CourseRating objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight CourseRating objects.
    /// </summary>
    [TestFixture]
    public class CourseRatingDeserializationTests
    {
        /// <summary>
        /// Tests if a Course Rating JSON block can be deserialized to a Course Rating model.
        /// </summary>
        [Category("Course Rating")]
        [Test]
        public void CourseRatingJsonShouldDeserializeIntoCourseRatingModel()
        {
            // Arrange
            const string json = @"
            {
                ""average"":4.6,
                ""ratersCount"":298
            }";

            // Act
            CourseRating courseRating = JsonConvert.DeserializeObject<CourseRating>(json);

            // Assert
            Assert.IsNotNull(courseRating);
            Assert.AreEqual(4.6, courseRating.AverageRating);
            Assert.AreEqual(298, courseRating.NumberOfRatings);
        }
    }
}
