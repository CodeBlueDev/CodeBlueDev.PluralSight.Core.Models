// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseLevelDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight CourseLevel values.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using System;

    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight CourseLevel values.
    /// </summary>
    [TestFixture]
    public class CourseLevelDeserializationTests
    {
        /// <summary>
        /// Tests if a JSON block for a 'Beginner' Course Level can be deserialized to the appropriate CourseLevel enum value.
        /// </summary>
        [Category("Course Level")]
        [Test]
        public void BeginnerCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string json = @"""Beginner""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }

        /// <summary>
        /// Tests if a JSON block for an 'Intermediate' Course Level can be deserialize to the appropriate CourseLevel enum value.
        /// </summary>
        [Category("Course Level")]
        [Test]
        public void IntermediateCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string json = @"""Intermediate""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }

        /// <summary>
        /// Tests if a JSON block for an 'Advanced' Course Level can deserialized to the appropriate CourseLevel enum value.
        /// </summary>
        [Category("Course Level")]
        [Test]
        public void AdvancedCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string json = @"""Advanced""";

            // Act
            CourseLevel courseLevel = JsonConvert.DeserializeObject<CourseLevel>(json);

            // Assert
            Assert.IsTrue(Enum.IsDefined(typeof(CourseLevel), courseLevel));
        }
    }
}
