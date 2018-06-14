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
    public class ImageDeserializationTests
    {
        /// <summary>
        /// Tests that a Image JSON response with valid values is deserialized correctly to a CourseImage model.
        /// </summary>
        [Category("Course Image")]
        [Test]
        public void CourseImageJsonShouldDeserializeToCourseImageModel()
        {
            // Arrange
            const string json = @"{
  ""alt"": ""Windows Forms Best Practices"",
  ""url"": ""https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg"",
  ""isDefault"": false
}";

            // Act
            Image image = JsonConvert.DeserializeObject<Image>(json);

            // Assert
            Assert.IsNotNull(image);
            Assert.AreEqual(@"Windows Forms Best Practices", image.AltText);
            Assert.AreEqual(@"https://pluralsight.imgix.net/course-images/windows-forms-best-practices-v1.jpg", image.Url);
            Assert.AreEqual(false, image.IsDefault);
        }
    }
}
