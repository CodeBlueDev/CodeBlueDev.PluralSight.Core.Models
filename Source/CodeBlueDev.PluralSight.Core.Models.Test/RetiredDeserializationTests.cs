// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RetiredDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Course Retired objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Course Retired objects.
    /// </summary>
    [TestFixture]
    public class RetiredDeserializationTests
    {
        /// <summary>
        /// Tests if an Retired JSON block can be deserialized to an Retired model.
        /// </summary>
        [Test, Category("Retired")]
        public void RetiredJsonShouldDeserializeIntoRetiredModel()
        {
            // Arrange
            const string Json = @"
            {
                ""isRetired"":true,
                ""reason"":""Test"",
                ""replacementId"":""N/A""
            }";

            // Act
            Retired retired = JsonConvert.DeserializeObject<Retired>(Json);

            // Assert
            Assert.IsNotNull(retired);
            Assert.IsTrue(retired.IsRetired);
            Assert.IsFalse(string.IsNullOrEmpty(retired.Reason));
            Assert.AreEqual("Test", retired.Reason);
            Assert.IsFalse(string.IsNullOrEmpty(retired.ReplacementId));
        }
    }
}
