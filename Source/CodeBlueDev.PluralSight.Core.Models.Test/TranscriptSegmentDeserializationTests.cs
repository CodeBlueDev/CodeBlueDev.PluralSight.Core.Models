// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptSegmentDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Transcript Segment objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Transcript Segment objects.
    /// </summary>
    [TestFixture]
    public class TranscriptSegmentDeserializationTests
    {
        /// <summary>
        /// Tests if a Transcript Segment JSON block can be deserialized to a Transcript Segment model.
        /// </summary>
        [Test, Category("Transcript Segment")]
        public void TranscriptSegmentJsonShouldDeserializeIntoTranscriptSegmentModel()
        {
            // Arrange
            const string Json = @"
            {
              ""text"": ""Hi, my name's Mark Heath"",
              ""displayTime"": 2.0
            }";

            // Act
            TranscriptModuleClipSegment transcriptSegment = JsonConvert.DeserializeObject<TranscriptModuleClipSegment>(Json);

            // Assert
            Assert.IsNotNull(transcriptSegment);
            Assert.AreEqual("Hi, my name's Mark Heath", transcriptSegment.Text);
            Assert.AreEqual(2.0, transcriptSegment.DisplayTime);
        }

        /// <summary>
        /// Tests if a Transcript Segment JSON block with multiple Transcript Segments can be deserialized to multiple Transcript Segment models.
        /// </summary>
        [Test, Category("Transcript Segment")]
        public void
            TranscriptSegmentJsonWithMultipleTranscriptSegmentsShouldDeserializeIntoMultipleTranscriptSegmentModels()
        {
            // Arrange
            const string Json = @"
            [
                {
                  ""text"": ""Hi, my name's Mark Heath"",
                  ""displayTime"": 2.0
                },
                {
                  ""text"": ""and welcome to this Pluralsight course"",
                  ""displayTime"": 4.0
                }
            ]";

            // Act
            TranscriptModuleClipSegment[] transcriptSegments = JsonConvert.DeserializeObject<TranscriptModuleClipSegment[]>(Json);

            // Assert
            Assert.IsNotNull(transcriptSegments);
            Assert.AreEqual(2, transcriptSegments.Length);
        }
    }
}
