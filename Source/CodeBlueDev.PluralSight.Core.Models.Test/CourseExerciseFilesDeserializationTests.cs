// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseExerciseFilesDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight CourseExerciseFiles values.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight CourseExerciseFiles values.
    /// </summary>
    [TestFixture]
    public class CourseExerciseFilesDeserializationTests
    {
        /// <summary>
        /// Tests if a Course Excercise File JSON block can be deserialized to a Course Exercise Files model.
        /// </summary>
        [Category("Exercise Files")]
        [Test]
        public void BeginnerCourseLevelJsonShouldDeserializeIntoCourseLevelEnum()
        {
            // Arrange
            const string Json = @"{
  ""exerciseFilesUrl"": ""http://s.pluralsight.com/course-materials/windows-forms-best-practices/866AB96258/20140926213054/windows-forms-best-practices.zip?userHandle=8950de64-5ab8-4b06-afc0-076d718589f4""
}";

            // Act
            CourseExerciseFiles courseExerciseFiles = JsonConvert.DeserializeObject<CourseExerciseFiles>(Json);

            // Assert
            Assert.IsNotNull(courseExerciseFiles);
            Assert.IsFalse(string.IsNullOrEmpty(courseExerciseFiles.ExerciseFilesUrl));
            Assert.AreEqual("http://s.pluralsight.com/course-materials/windows-forms-best-practices/866AB96258/20140926213054/windows-forms-best-practices.zip?userHandle=8950de64-5ab8-4b06-afc0-076d718589f4", courseExerciseFiles.ExerciseFilesUrl);
        }
    }
}
