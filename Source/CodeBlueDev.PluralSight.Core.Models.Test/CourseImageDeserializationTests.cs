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
        /// <summary>
        /// Tests that a CourseImage JSON response with valid values is deserialized correctly to a CourseImage model.
        /// </summary>
        [Test, Category("Course Image")]
        public void CourseImageJsonShouldDeserializeToCourseImageModel()
        {
            // Arrange
            const string Json = @"
            {  
               ""courseListUrl"":""//pluralsight-res.cloudinary.com/image/upload/w_120/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg"",
               ""defaultUrl"":""//pluralsight-res.cloudinary.com/image/upload/w_1200/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg"",
               ""smallUrl"":""//pluralsight-res.cloudinary.com/image/upload/w_400/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg""
            }";

            // Act
            CourseImage courseImage = JsonConvert.DeserializeObject<CourseImage>(Json);

            // Assert
            Assert.IsNotNull(courseImage);
            Assert.AreEqual(@"//pluralsight-res.cloudinary.com/image/upload/w_120/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg", courseImage.CourseListUrl);
            Assert.AreEqual(@"//pluralsight-res.cloudinary.com/image/upload/w_1200/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg", courseImage.DefaultUrl);
            Assert.AreEqual(@"//pluralsight-res.cloudinary.com/image/upload/w_400/pluralsight-static/course-images/play-by-play-csharp-q-and-a-with-scott-allen-and-jon-skeet-v1.jpg", courseImage.SmallUrl);
        }


        /// <summary>
        /// Tests that a JSON response with null values is deserialized correctly to a CourseImage model with null values.
        /// </summary>
        [Test, Category("Course Image")]
        public void CourseImageJsonWithNullValuesShouldDeserializeToCourseImageModel()
        {
            // Arrange
            const string Json = @"
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
