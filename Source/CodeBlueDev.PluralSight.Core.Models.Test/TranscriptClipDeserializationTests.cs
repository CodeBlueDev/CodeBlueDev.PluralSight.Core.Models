// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptClipDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Transcript Clip objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Transcript Clip objects.
    /// </summary>
    [TestFixture]
    public class TranscriptClipDeserializationTests
    {
        /// <summary>
        /// Tests if a Transcript Clip JSON block can be deserialized to a Transcript Clip model.
        /// </summary>
        [Test, Category("Transcript Clip")]
        public void TranscriptClipJsonShouldDeserializeIntoTranscriptClipModel()
        {
            // Arrange
            const string Json = @"
            {
              ""title"": ""Module Introduction"",
              ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
              ""segments"": [
                {
                  ""text"": ""Hi, my name's Mark Heath"",
                  ""displayTime"": 2.0
                },
                {
                  ""text"": ""and welcome to this Pluralsight course"",
                  ""displayTime"": 4.0
                },
                {
                  ""text"": ""on Windows Forms Best Practices."",
                  ""displayTime"": 6.0
                },
                {
                  ""text"": ""In this course, we'll be looking at how you can create"",
                  ""displayTime"": 10.0
                },
                {
                  ""text"": ""excellent Windows Forms applications."",
                  ""displayTime"": 12.0
                },
                {
                  ""text"": ""And in this first introductory module,"",
                  ""displayTime"": 17.0
                },
                {
                  ""text"": ""we're going to answer the question,"",
                  ""displayTime"": 20.0
                },
                {
                  ""text"": ""why would will still want to use Windows Forms,"",
                  ""displayTime"": 22.0
                },
                {
                  ""text"": ""given that it's now quite an old technology?"",
                  ""displayTime"": 25.0
                },
                {
                  ""text"": ""I want to explain some of the reasons why I think"",
                  ""displayTime"": 29.0
                },
                {
                  ""text"": ""you can still create excellent Windows applications"",
                  ""displayTime"": 31.0
                },
                {
                  ""text"": ""using Windows Forms if you apply some of the best practices"",
                  ""displayTime"": 35.0
                },
                {
                  ""text"": ""that we'll be learning in this course."",
                  ""displayTime"": 39.0
                },
                {
                  ""text"": ""And in this module, we'll also introduce a demo application"",
                  ""displayTime"": 42.0
                },
                {
                  ""text"": ""that we're going to be improving"",
                  ""displayTime"": 46.0
                },
                {
                  ""text"": ""as we go through this course."",
                  ""displayTime"": 47.0
                },
                {
                  ""text"": ""So this application will start out with some problems"",
                  ""displayTime"": 50.0
                },
                {
                  ""text"": ""that we'll be fixing as we go along."",
                  ""displayTime"": 52.0
                }
              ]
            }";

            // Act
            TranscriptClip transcriptClip = JsonConvert.DeserializeObject<TranscriptClip>(Json);

            // Assert
            Assert.IsNotNull(transcriptClip);
            Assert.AreEqual("Module Introduction", transcriptClip.Title);
            Assert.AreEqual("//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", transcriptClip.PlayerUrl);
            Assert.IsNotNull(transcriptClip.Segments);
            Assert.IsTrue(transcriptClip.Segments.Length > 1);
        }

        /// <summary>
        /// Tests if a Transcript Clip JSON block with multiple Transcript Clip can be deserialized to multiple Transcript Clip models.
        /// </summary>
        [Test, Category("Transcript Clip")]
        public void TranscriptClipJsonWithMultipleTranscriptClipsShouldDeserializeIntoMultipleTranscriptClipModels()
        {
            // Arrange
            const string Json = @"
            [
                {
                  ""title"": ""Module Introduction"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""Hi, my name's Mark Heath"",
                      ""displayTime"": 2.0
                    },
                    {
                      ""text"": ""and welcome to this Pluralsight course"",
                      ""displayTime"": 4.0
                    },
                    {
                      ""text"": ""on Windows Forms Best Practices."",
                      ""displayTime"": 6.0
                    },
                    {
                      ""text"": ""In this course, we'll be looking at how you can create"",
                      ""displayTime"": 10.0
                    },
                    {
                      ""text"": ""excellent Windows Forms applications."",
                      ""displayTime"": 12.0
                    },
                    {
                      ""text"": ""And in this first introductory module,"",
                      ""displayTime"": 17.0
                    },
                    {
                      ""text"": ""we're going to answer the question,"",
                      ""displayTime"": 20.0
                    },
                    {
                      ""text"": ""why would will still want to use Windows Forms,"",
                      ""displayTime"": 22.0
                    },
                    {
                      ""text"": ""given that it's now quite an old technology?"",
                      ""displayTime"": 25.0
                    },
                    {
                      ""text"": ""I want to explain some of the reasons why I think"",
                      ""displayTime"": 29.0
                    },
                    {
                      ""text"": ""you can still create excellent Windows applications"",
                      ""displayTime"": 31.0
                    },
                    {
                      ""text"": ""using Windows Forms if you apply some of the best practices"",
                      ""displayTime"": 35.0
                    },
                    {
                      ""text"": ""that we'll be learning in this course."",
                      ""displayTime"": 39.0
                    },
                    {
                      ""text"": ""And in this module, we'll also introduce a demo application"",
                      ""displayTime"": 42.0
                    },
                    {
                      ""text"": ""that we're going to be improving"",
                      ""displayTime"": 46.0
                    },
                    {
                      ""text"": ""as we go through this course."",
                      ""displayTime"": 47.0
                    },
                    {
                      ""text"": ""So this application will start out with some problems"",
                      ""displayTime"": 50.0
                    },
                    {
                      ""text"": ""that we'll be fixing as we go along."",
                      ""displayTime"": 52.0
                    }
                  ]
                },
                {
                  ""title"": ""Is Windows Forms Dead?"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=1&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""Let's start off by addressing the slightly awkward question,"",
                      ""displayTime"": 1.9485667
                    },
                    {
                      ""text"": ""is Windows Forms dead?"",
                      ""displayTime"": 4.9485667
                    },
                    {
                      ""text"": ""Well, it certainly has been around for a long time."",
                      ""displayTime"": 7.9485667
                    },
                    {
                      ""text"": ""It was part of the initial version of .NET"",
                      ""displayTime"": 10.9485667
                    },
                    {
                      ""text"": ""that was released in 2002."",
                      ""displayTime"": 13.9485667
                    },
                    {
                      ""text"": ""And in 2006, with .NET 3,"",
                      ""displayTime"": 15.9485667
                    },
                    {
                      ""text"": ""WPF was launched which, in many ways,"",
                      ""displayTime"": 19.9485667
                    },
                    {
                      ""text"": ""is the successor to Windows Forms."",
                      ""displayTime"": 22.9485667
                    },
                    {
                      ""text"": ""But Windows Forms remained part of the framework"",
                      ""displayTime"": 25.9485667
                    },
                    {
                      ""text"": ""and you could continue to use it and it continued"",
                      ""displayTime"": 28.9485667
                    },
                    {
                      ""text"": ""to get some new features; although the last time"",
                      ""displayTime"": 30.9485667
                    },
                    {
                      ""text"": ""significant Windows Forms new features were added"",
                      ""displayTime"": 34.9485667
                    },
                    {
                      ""text"": ""was part of .NET 3.5, in 2008."",
                      ""displayTime"": 37.9485667
                    },
                    {
                      ""text"": ""Since then, Windows Forms has been, in strictly,"",
                      ""displayTime"": 40.9485667
                    },
                    {
                      ""text"": ""maintenance-only mode."",
                      ""displayTime"": 44.9485667
                    },
                    {
                      ""text"": ""The only changes are bug fixes,"",
                      ""displayTime"": 46.9485667
                    },
                    {
                      ""text"": ""but Microsoft are still fixing bugs."",
                      ""displayTime"": 48.9485667
                    },
                    {
                      ""text"": ""Say for example, in quite a recent version"",
                      ""displayTime"": 50.9485667
                    },
                    {
                      ""text"": ""of the .NET framework, a number of Windows Forms bugs"",
                      ""displayTime"": 52.9485667
                    },
                    {
                      ""text"": ""to do with high-resolution screens were fixed."",
                      ""displayTime"": 56.9485667
                    },
                    {
                      ""text"": ""But although Windows Forms isn't picking"",
                      ""displayTime"": 59.9485667
                    },
                    {
                      ""text"": ""up any new features,"",
                      ""displayTime"": 61.9485667
                    },
                    {
                      ""text"": ""it certainly is still part of the framework."",
                      ""displayTime"": 62.9485667
                    },
                    {
                      ""text"": ""And in the latest version of Visual Studio,"",
                      ""displayTime"": 65.9485667
                    },
                    {
                      ""text"": ""you can create new Windows Forms applications."",
                      ""displayTime"": 67.9485667
                    },
                    {
                      ""text"": ""There's one sense in which Windows Forms"",
                      ""displayTime"": 71.9485667
                    },
                    {
                      ""text"": ""not getting any new features is an advantage."",
                      ""displayTime"": 73.9485667
                    },
                    {
                      ""text"": ""It means that the programming model is mature and stable."",
                      ""displayTime"": 76.9485667
                    },
                    {
                      ""text"": ""It's not going to change under your feet unlike,"",
                      ""displayTime"": 80.9485667
                    },
                    {
                      ""text"": ""say for example, some of the newer web frameworks"",
                      ""displayTime"": 83.9485667
                    },
                    {
                      ""text"": ""that seem to have breaking changes on a monthly basis."",
                      ""displayTime"": 86.9485667
                    },
                    {
                      ""text"": ""With Windows Forms, you just need to learn it once,"",
                      ""displayTime"": 89.9485667
                    },
                    {
                      ""text"": ""and it's not going to change."",
                      ""displayTime"": 92.9485667
                    }
                  ]
                }
            ]";

            // Act
            TranscriptClip[] transcriptClips = JsonConvert.DeserializeObject<TranscriptClip[]>(Json);

            // Asssert
            Assert.IsNotNull(transcriptClips);
            Assert.AreEqual(2, transcriptClips.Length);
        }
    }
}
