// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranscriptModuleDeserializationTests.cs" company="CodeBlueDev">
//   All rights reserved.
// </copyright>
// <summary>
//   Tests deserialization of PluralSight Transcript Module objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CodeBlueDev.PluralSight.Core.Models.Test
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    /// <summary>
    /// Tests deserialization of PluralSight Transcript Module objects.
    /// </summary>
    [TestFixture]
    public class TranscriptModuleDeserializationTests
    {
        /// <summary>
        /// Tests if a Transcript Module JSON block can be deserialized to a Transcript Module model.
        /// </summary>
        [Test, Category("Transcript Module")]
        public void TranscriptModuleJsonShouldDeserializeIntoTranscriptModuleModel()
        {
            // Arrange
            const string Json = @"
            {
              ""title"": ""Creating Excellent Windows Forms Applications"",
              ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live"",
              ""clips"": [
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
                },
                {
                  ""title"": ""Why Use Windows Forms?"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=2&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""But if WPF has been out for so long,"",
                      ""displayTime"": 1.8767779
                    },
                    {
                      ""text"": ""why is anyone still using Windows Forms?"",
                      ""displayTime"": 4.8767779
                    },
                    {
                      ""text"": ""Well, the answer to that question is simple."",
                      ""displayTime"": 7.8767779
                    },
                    {
                      ""text"": ""It's all about return on investment."",
                      ""displayTime"": 9.8767779
                    },
                    {
                      ""text"": ""A lot of companies and developers have invested"",
                      ""displayTime"": 12.8767779
                    },
                    {
                      ""text"": ""significant amounts of time and money"",
                      ""displayTime"": 14.8767779
                    },
                    {
                      ""text"": ""into learning Windows Forms and building things with it."",
                      ""displayTime"": 17.8767779
                    },
                    {
                      ""text"": ""So many companies have got large, existing applications"",
                      ""displayTime"": 21.8767779
                    },
                    {
                      ""text"": ""containing lots of code and with lots of customers."",
                      ""displayTime"": 24.8767779
                    },
                    {
                      ""text"": ""And even if they want to rewrite it in WPF,"",
                      ""displayTime"": 28.8767779
                    },
                    {
                      ""text"": ""or maybe move it to HTML5,"",
                      ""displayTime"": 31.8767779
                    },
                    {
                      ""text"": ""it would just take too long to migrate."",
                      ""displayTime"": 33.8767779
                    },
                    {
                      ""text"": ""Also, a lot of developers have invested a significant amount"",
                      ""displayTime"": 37.8767779
                    },
                    {
                      ""text"": ""of time in learning Windows Forms."",
                      ""displayTime"": 40.8767779
                    },
                    {
                      ""text"": ""And so they want to take advantage of what they already know"",
                      ""displayTime"": 43.8767779
                    },
                    {
                      ""text"": ""instead of learning a brand new user interface paradigm."",
                      ""displayTime"": 46.8767779
                    },
                    {
                      ""text"": ""And so, I still come across many companies"",
                      ""displayTime"": 50.8767779
                    },
                    {
                      ""text"": ""that are creating brand new applications in Windows Forms,"",
                      ""displayTime"": 52.8767779
                    },
                    {
                      ""text"": ""even today, because that's what they know how to use."",
                      ""displayTime"": 56.8767779
                    },
                    {
                      ""text"": ""And also, many companies have got existing control libraries"",
                      ""displayTime"": 60.8767779
                    },
                    {
                      ""text"": ""that they either bought or built themselves"",
                      ""displayTime"": 64.8767779
                    },
                    {
                      ""text"": ""in order to give their application a custom"",
                      ""displayTime"": 67.8767779
                    },
                    {
                      ""text"": ""and distinctive look and feel."",
                      ""displayTime"": 69.8767779
                    },
                    {
                      ""text"": ""And again, if they were to move away to a new technology,"",
                      ""displayTime"": 73.8767779
                    },
                    {
                      ""text"": ""all of that work would have to be redone."",
                      ""displayTime"": 75.8767779
                    },
                    {
                      ""text"": ""So Windows Forms may be an old technology,"",
                      ""displayTime"": 79.8767779
                    },
                    {
                      ""text"": ""but it's certainly still getting a lot of use."",
                      ""displayTime"": 82.8767779
                    }
                  ]
                },
                {
                  ""title"": ""Building Great Windows Forms Applications"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=3&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""So as I said in the introduction,"",
                      ""displayTime"": 1.3251668
                    },
                    {
                      ""text"": ""this course is all about helping you"",
                      ""displayTime"": 3.3251668
                    },
                    {
                      ""text"": ""to build great Windows Forms applications."",
                      ""displayTime"": 5.3251668
                    },
                    {
                      ""text"": ""You see, just because it's an old technology,"",
                      ""displayTime"": 9.3251668
                    },
                    {
                      ""text"": ""doesn't mean it has to look terrible."",
                      ""displayTime"": 12.3251668
                    },
                    {
                      ""text"": ""And I'm sure we've all seen rather ugly"",
                      ""displayTime"": 14.3251668
                    },
                    {
                      ""text"": ""Windows Forms applications maybe looking a little bit"",
                      ""displayTime"": 17.3251668
                    },
                    {
                      ""text"": ""like this screenshot."",
                      ""displayTime"": 19.3251668
                    },
                    {
                      ""text"": ""Nor does it have to be difficult to use."",
                      ""displayTime"": 21.3251668
                    },
                    {
                      ""text"": ""In fact, you can use Windows Forms"",
                      ""displayTime"": 24.3251668
                    },
                    {
                      ""text"": ""to create very modern-looking user interfaces,"",
                      ""displayTime"": 26.3251668
                    },
                    {
                      ""text"": ""such as this example which uses an open-source"",
                      ""displayTime"": 29.3251668
                    },
                    {
                      ""text"": ""Windows Forms controls library to make the application"",
                      ""displayTime"": 32.3251668
                    },
                    {
                      ""text"": ""look very much like the Windows 8 style."",
                      ""displayTime"": 36.3251668
                    },
                    {
                      ""text"": ""And also, in Windows Forms, it's completely possible"",
                      ""displayTime"": 40.3251668
                    },
                    {
                      ""text"": ""to write maintainable and well architected code."",
                      ""displayTime"": 43.3251668
                    },
                    {
                      ""text"": ""You can use all of the good programming practices"",
                      ""displayTime"": 47.3251668
                    },
                    {
                      ""text"": ""and techniques that you'll learn about in other courses"",
                      ""displayTime"": 50.3251668
                    },
                    {
                      ""text"": ""here on Pluralsight, such as Test Driven Development,"",
                      ""displayTime"": 52.3251668
                    },
                    {
                      ""text"": ""writing 'Clean' code, writing SOLID code,"",
                      ""displayTime"": 56.3251668
                    },
                    {
                      ""text"": ""making use of good design patterns, and using inversion"",
                      ""displayTime"": 60.3251668
                    },
                    {
                      ""text"": ""of control containers for dependency injection."",
                      ""displayTime"": 65.3251668
                    },
                    {
                      ""text"": ""And not only that, you're not completely stuck"",
                      ""displayTime"": 69.3251668
                    },
                    {
                      ""text"": ""on using only the old parts of the .NET framework"",
                      ""displayTime"": 72.3251668
                    },
                    {
                      ""text"": ""that were around when Windows Forms was introduced."",
                      ""displayTime"": 76.3251668
                    },
                    {
                      ""text"": ""You can combine Windows Forms developments"",
                      ""displayTime"": 79.3251668
                    },
                    {
                      ""text"": ""with some of the newer bits of .NET,"",
                      ""displayTime"": 81.3251668
                    },
                    {
                      ""text"": ""such as using LINQ to make it easier to work"",
                      ""displayTime"": 83.3251668
                    },
                    {
                      ""text"": ""with some of the Windows Forms controls,"",
                      ""displayTime"": 86.3251668
                    },
                    {
                      ""text"": ""or using Reactive extensions,"",
                      ""displayTime"": 89.3251668
                    },
                    {
                      ""text"": ""or the C-sharp 5 async and await keywords"",
                      ""displayTime"": 93.3251668
                    },
                    {
                      ""text"": ""for multi-threaded code."",
                      ""displayTime"": 96.3251668
                    },
                    {
                      ""text"": ""You can even, if you want, make use"",
                      ""displayTime"": 99.3251668
                    },
                    {
                      ""text"": ""of some of the newer languages"",
                      ""displayTime"": 101.3251668
                    },
                    {
                      ""text"": ""like the functional F-sharp language,"",
                      ""displayTime"": 102.3251668
                    },
                    {
                      ""text"": ""or the dynamic IronPython language."",
                      ""displayTime"": 105.3251668
                    },
                    {
                      ""text"": ""So Windows Forms development doesn't necessarily need"",
                      ""displayTime"": 108.3251668
                    },
                    {
                      ""text"": ""to be boring and stuck in the past."",
                      ""displayTime"": 111.3251668
                    },
                    {
                      ""text"": ""If you want to use some of these new things with it,"",
                      ""displayTime"": 114.3251668
                    },
                    {
                      ""text"": ""you're certainly able to do that."",
                      ""displayTime"": 116.3251668
                    }
                  ]
                },
                {
                  ""title"": ""Moving Away From Windows Forms"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=4&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""Now, of course, having said that,"",
                      ""displayTime"": 1.486978
                    },
                    {
                      ""text"": ""some of you will still be wanting to move away"",
                      ""displayTime"": 3.486978
                    },
                    {
                      ""text"": ""from Windows Forms to a newer technology such as WPF,"",
                      ""displayTime"": 5.486978
                    },
                    {
                      ""text"": ""and there are several reasons why you might want to do that."",
                      ""displayTime"": 9.486978
                    },
                    {
                      ""text"": ""WPF does offer a number of distinct advantages"",
                      ""displayTime"": 12.486978
                    },
                    {
                      ""text"": ""over Windows Forms."",
                      ""displayTime"": 15.486978
                    },
                    {
                      ""text"": ""It's got more powerful animation capabilities."",
                      ""displayTime"": 17.486978
                    },
                    {
                      ""text"": ""It's got a much richer data binding model."",
                      ""displayTime"": 20.486978
                    },
                    {
                      ""text"": ""It supports patterns such as MVVM."",
                      ""displayTime"": 23.486978
                    },
                    {
                      ""text"": ""And Windows Forms has a few inherent limitations"",
                      ""displayTime"": 27.486978
                    },
                    {
                      ""text"": ""that might cause you some issues."",
                      ""displayTime"": 30.486978
                    },
                    {
                      ""text"": ""Most notably, you can't use Windows Forms"",
                      ""displayTime"": 32.486978
                    },
                    {
                      ""text"": ""to create Windows 8 Store applications,"",
                      ""displayTime"": 35.486978
                    },
                    {
                      ""text"": ""and you can't use it to create Windows phone applications."",
                      ""displayTime"": 39.486978
                    },
                    {
                      ""text"": ""So, if your application needs to target mobile"",
                      ""displayTime"": 43.486978
                    },
                    {
                      ""text"": ""or tablet PCs, then you're going to need to think"",
                      ""displayTime"": 45.486978
                    },
                    {
                      ""text"": ""about how you can transition away from Windows Forms."",
                      ""displayTime"": 49.486978
                    },
                    {
                      ""text"": ""And so, in this course, I'll be trying to show you"",
                      ""displayTime"": 53.486978
                    },
                    {
                      ""text"": ""some of the ways that you can prepare"",
                      ""displayTime"": 55.486978
                    },
                    {
                      ""text"": ""to make that transition."",
                      ""displayTime"": 57.486978
                    },
                    {
                      ""text"": ""In particular, we'll see how you can decouple"",
                      ""displayTime"": 60.486978
                    },
                    {
                      ""text"": ""your business logic from your user interface code"",
                      ""displayTime"": 62.486978
                    },
                    {
                      ""text"": ""so that the business logic is reusable."",
                      ""displayTime"": 65.486978
                    },
                    {
                      ""text"": ""And we'll also see how it's possible to combine"",
                      ""displayTime"": 69.486978
                    },
                    {
                      ""text"": ""Windows Forms with WPF, or even web technologies,"",
                      ""displayTime"": 71.486978
                    },
                    {
                      ""text"": ""by hosting them inside of Windows Forms application."",
                      ""displayTime"": 76.486978
                    }
                  ]
                },
                {
                  ""title"": ""Course Prerequisites and Contents"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=5&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""Now I am going to assume, in this course,"",
                      ""displayTime"": 2.4617225
                    },
                    {
                      ""text"": ""that you already know the basics of Windows Forms,"",
                      ""displayTime"": 4.4617225
                    },
                    {
                      ""text"": ""how to create a new project, drag some controls"",
                      ""displayTime"": 7.4617225
                    },
                    {
                      ""text"": ""onto the designer, how to set properties on those controls,"",
                      ""displayTime"": 10.4617225
                    },
                    {
                      ""text"": ""and add event handlers, and how to view the code behind"",
                      ""displayTime"": 14.4617225
                    },
                    {
                      ""text"": ""for a form."",
                      ""displayTime"": 17.4617225
                    },
                    {
                      ""text"": ""And I'm also going to assume that you know"",
                      ""displayTime"": 19.4617225
                    },
                    {
                      ""text"": ""the basic controls of Windows Forms, buttons and text boxes,"",
                      ""displayTime"": 21.4617225
                    },
                    {
                      ""text"": ""combo boxes and so on."",
                      ""displayTime"": 25.4617225
                    },
                    {
                      ""text"": ""But if you'd like to have a refresher"",
                      ""displayTime"": 28.4617225
                    },
                    {
                      ""text"": ""on the basics of Windows Forms,"",
                      ""displayTime"": 30.4617225
                    },
                    {
                      ""text"": ""then Rob Windsor has created this Pluralsight course"",
                      ""displayTime"": 32.4617225
                    },
                    {
                      ""text"": ""that covers some more introductory topics."",
                      ""displayTime"": 35.4617225
                    },
                    {
                      ""text"": ""And he also, in this course, looks at SDI"",
                      ""displayTime"": 39.4617225
                    },
                    {
                      ""text"": ""and MDI applications as well as data binding"",
                      ""displayTime"": 42.4617225
                    },
                    {
                      ""text"": ""directly to databases which are both topics"",
                      ""displayTime"": 44.4617225
                    },
                    {
                      ""text"": ""that we won't be explicitly covering in this course."",
                      ""displayTime"": 47.4617225
                    },
                    {
                      ""text"": ""So what will we be covering in this course?"",
                      ""displayTime"": 54.4617225
                    },
                    {
                      ""text"": ""Well, we'll be looking at some best practices"",
                      ""displayTime"": 57.4617225
                    },
                    {
                      ""text"": ""for how you layout your forms, how you make them resizable,"",
                      ""displayTime"": 59.4617225
                    },
                    {
                      ""text"": ""how we can make our application,"",
                      ""displayTime"": 64.4617225
                    },
                    {
                      ""text"": ""generally, more usable and accessible."",
                      ""displayTime"": 66.4617225
                    },
                    {
                      ""text"": ""We'll also be focusing on how we can write"",
                      ""displayTime"": 69.4617225
                    },
                    {
                      ""text"": ""maintainable Windows Forms code"",
                      ""displayTime"": 72.4617225
                    },
                    {
                      ""text"": ""and make sure it's also testable."",
                      ""displayTime"": 74.4617225
                    },
                    {
                      ""text"": ""We'll also see some best practices"",
                      ""displayTime"": 77.4617225
                    },
                    {
                      ""text"": ""for writing multi-threaded Windows Forms applications"",
                      ""displayTime"": 79.4617225
                    },
                    {
                      ""text"": ""and how we should handle exceptions."",
                      ""displayTime"": 83.4617225
                    },
                    {
                      ""text"": ""We'll also see how you can create your own custom controls"",
                      ""displayTime"": 86.4617225
                    },
                    {
                      ""text"": ""when the standard ones don't quite do what you need."",
                      ""displayTime"": 90.4617225
                    },
                    {
                      ""text"": ""And finally, we'll also see some practices"",
                      ""displayTime"": 94.4617225
                    },
                    {
                      ""text"": ""for how we can inter-operate with other technologies"",
                      ""displayTime"": 97.4617225
                    },
                    {
                      ""text"": ""inside of our Windows Forms applications."",
                      ""displayTime"": 100.4617225
                    },
                    {
                      ""text"": ""I do also want to say a brief word"",
                      ""displayTime"": 105.4617225
                    },
                    {
                      ""text"": ""about the term best practices."",
                      ""displayTime"": 106.4617225
                    },
                    {
                      ""text"": ""Although it's in the title of this course,"",
                      ""displayTime"": 109.4617225
                    },
                    {
                      ""text"": ""it can be a bit misleading."",
                      ""displayTime"": 111.4617225
                    },
                    {
                      ""text"": ""Best practices are, in fact, relative."",
                      ""displayTime"": 113.4617225
                    },
                    {
                      ""text"": ""They're simply better ways of working than, maybe,"",
                      ""displayTime"": 116.4617225
                    },
                    {
                      ""text"": ""the typical ways Windows Forms applications"",
                      ""displayTime"": 119.4617225
                    },
                    {
                      ""text"": ""get developed in."",
                      ""displayTime"": 121.4617225
                    },
                    {
                      ""text"": ""I want to show you how you can avoid some"",
                      ""displayTime"": 123.4617225
                    },
                    {
                      ""text"": ""of the common pitfalls and problems that you might run into."",
                      ""displayTime"": 125.4617225
                    },
                    {
                      ""text"": ""And also, best practices are contextual."",
                      ""displayTime"": 129.4617225
                    },
                    {
                      ""text"": ""They don't necessarily apply in every situation"",
                      ""displayTime"": 133.4617225
                    },
                    {
                      ""text"": ""and to every Windows Forms application that you'll create."",
                      ""displayTime"": 137.4617225
                    },
                    {
                      ""text"": ""Not every application needs to be localize-able,"",
                      ""displayTime"": 140.4617225
                    },
                    {
                      ""text"": ""for example."",
                      ""displayTime"": 143.4617225
                    },
                    {
                      ""text"": ""And it may be overkill to apply all of the patterns"",
                      ""displayTime"": 145.4617225
                    },
                    {
                      ""text"": ""that we're going to be discussing into your application."",
                      ""displayTime"": 147.4617225
                    },
                    {
                      ""text"": ""So think of these as suggestions, and not rules,"",
                      ""displayTime"": 151.4617225
                    },
                    {
                      ""text"": ""and take the ones that apply to your application."",
                      ""displayTime"": 154.4617225
                    }
                  ]
                },
                {
                  ""title"": ""Introducing the Demo Application"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=6&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""So let me now introduce the demo application"",
                      ""displayTime"": 1.9421781
                    },
                    {
                      ""text"": ""that we're going to be working on throughout this course."",
                      ""displayTime"": 4.9421781
                    },
                    {
                      ""text"": ""It's called My Podcasts, and it's a very simple application"",
                      ""displayTime"": 8.9421781
                    },
                    {
                      ""text"": ""that allows you to manage a list of podcasts"",
                      ""displayTime"": 12.9421781
                    },
                    {
                      ""text"": ""that you're interested in and see the episodes."",
                      ""displayTime"": 15.9421781
                    },
                    {
                      ""text"": ""And within this application you can listen to the episodes,"",
                      ""displayTime"": 19.9421781
                    },
                    {
                      ""text"": ""of course, but you can also add notes, tags, and ratings"",
                      ""displayTime"": 22.9421781
                    },
                    {
                      ""text"": ""to each episode of the podcast."",
                      ""displayTime"": 26.9421781
                    },
                    {
                      ""text"": ""So here you can see, the My Podcasts application running."",
                      ""displayTime"": 31.9421781
                    },
                    {
                      ""text"": ""I've already loaded it up with a few subscriptions"",
                      ""displayTime"": 35.9421781
                    },
                    {
                      ""text"": ""to a number of programming podcasts"",
                      ""displayTime"": 38.9421781
                    },
                    {
                      ""text"": ""that I like to listen to."",
                      ""displayTime"": 40.9421781
                    },
                    {
                      ""text"": ""If we select one of these podcasts,"",
                      ""displayTime"": 42.9421781
                    },
                    {
                      ""text"": ""we'll see the episodes in that podcast."",
                      ""displayTime"": 46.9421781
                    },
                    {
                      ""text"": ""And if we select an episode,"",
                      ""displayTime"": 49.9421781
                    },
                    {
                      ""text"": ""then we'll see some details about that episode."",
                      ""displayTime"": 53.9421781
                    },
                    {
                      ""text"": ""And here, we can type some notes."",
                      ""displayTime"": 56.9421781
                    },
                    {
                      ""text"": ""We can give it a rating."",
                      ""displayTime"": 61.9421781
                    },
                    {
                      ""text"": ""We can mark it as a favorite."",
                      ""displayTime"": 64.9421781
                    },
                    {
                      ""text"": ""And, we can even play it."",
                      ""displayTime"": 67.9421781
                    },
                    {
                      ""text"": ""But for now, that's just going to open a web browser"",
                      ""displayTime"": 68.9421781
                    },
                    {
                      ""text"": ""with the URL of that episode."",
                      ""displayTime"": 71.9421781
                    },
                    {
                      ""text"": ""If we want to add a new subscription, we click add, here."",
                      ""displayTime"": 74.9421781
                    },
                    {
                      ""text"": ""And already you're seeing the first bug in this application"",
                      ""displayTime"": 79.9421781
                    },
                    {
                      ""text"": ""in that the form that it brought up"",
                      ""displayTime"": 82.9421781
                    },
                    {
                      ""text"": ""isn't even on this screen."",
                      ""displayTime"": 84.9421781
                    },
                    {
                      ""text"": ""So, let me drag it into view."",
                      ""displayTime"": 86.9421781
                    },
                    {
                      ""text"": ""Here we can enter the feed URL for a new podcast."",
                      ""displayTime"": 90.9421781
                    },
                    {
                      ""text"": ""And this highlights another problem with our application."",
                      ""displayTime"": 97.9421781
                    },
                    {
                      ""text"": ""It's got no error handling whatsoever."",
                      ""displayTime"": 100.9421781
                    },
                    {
                      ""text"": ""So, entering that invalid URL has crashed the application."",
                      ""displayTime"": 103.9421781
                    }
                  ]
                },
                {
                  ""title"": ""Naming Controls"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=7&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""So, let's take this opportunity to have a quick look"",
                      ""displayTime"": 1.7263559
                    },
                    {
                      ""text"": ""at the code for our demo application."",
                      ""displayTime"": 3.7263559
                    },
                    {
                      ""text"": ""The first thing that you'll be able to see, here,"",
                      ""displayTime"": 6.7263559
                    },
                    {
                      ""text"": ""is when the form loads, we go off and we start reading"",
                      ""displayTime"": 8.7263559
                    },
                    {
                      ""text"": ""from an XML file and that XML file has got the addresses"",
                      ""displayTime"": 11.7263559
                    },
                    {
                      ""text"": ""of all the podcasts we subscribed to."",
                      ""displayTime"": 15.7263559
                    },
                    {
                      ""text"": ""And so, further down here,"",
                      ""displayTime"": 18.7263559
                    },
                    {
                      ""text"": ""you can see that we're actually going off to the internet"",
                      ""displayTime"": 22.7263559
                    },
                    {
                      ""text"": ""and downloading that podcast and then doing some pausing"",
                      ""displayTime"": 25.7263559
                    },
                    {
                      ""text"": ""of the RSS feed that comes back."",
                      ""displayTime"": 28.7263559
                    },
                    {
                      ""text"": ""And this is typical of many Windows Forms applications"",
                      ""displayTime"": 31.7263559
                    },
                    {
                      ""text"": ""that I see."",
                      ""displayTime"": 34.7263559
                    },
                    {
                      ""text"": ""Right in the code behind of the GUI component,"",
                      ""displayTime"": 35.7263559
                    },
                    {
                      ""text"": ""they'll be going off and doing various bits"",
                      ""displayTime"": 38.7263559
                    },
                    {
                      ""text"": ""of business logic, and the trouble"",
                      ""displayTime"": 40.7263559
                    },
                    {
                      ""text"": ""with this is it makes your code extremely difficult"",
                      ""displayTime"": 42.7263559
                    },
                    {
                      ""text"": ""to effectively test."",
                      ""displayTime"": 45.7263559
                    },
                    {
                      ""text"": ""So, we'll be looking at ways, later in this course,"",
                      ""displayTime"": 47.7263559
                    },
                    {
                      ""text"": ""that we can sort this problem out."",
                      ""displayTime"": 49.7263559
                    },
                    {
                      ""text"": ""But for now, we're going to focus on a few other problems"",
                      ""displayTime"": 53.7263559
                    },
                    {
                      ""text"": ""with this code."",
                      ""displayTime"": 56.7263559
                    },
                    {
                      ""text"": ""Let's go down and have a look at this event handler."",
                      ""displayTime"": 57.7263559
                    },
                    {
                      ""text"": ""Here we can see that when the selected index"",
                      ""displayTime"": 61.7263559
                    },
                    {
                      ""text"": ""of list box two changes, then we update the contents"",
                      ""displayTime"": 64.7263559
                    },
                    {
                      ""text"": ""of various text boxes and other GUI components."",
                      ""displayTime"": 67.7263559
                    },
                    {
                      ""text"": ""But as you can see here in the code,"",
                      ""displayTime"": 71.7263559
                    },
                    {
                      ""text"": ""all of our controls have still got their default names"",
                      ""displayTime"": 73.7263559
                    },
                    {
                      ""text"": ""that the Windows Forms designer gave them."",
                      ""displayTime"": 76.7263559
                    },
                    {
                      ""text"": ""And so my first best practice is an obvious one and, yet,"",
                      ""displayTime"": 79.7263559
                    },
                    {
                      ""text"": ""it's one that many Windows Forms developers seem to overlook"",
                      ""displayTime"": 82.7263559
                    },
                    {
                      ""text"": ""and that's give all of your controls meaningful names."",
                      ""displayTime"": 86.7263559
                    },
                    {
                      ""text"": ""You don't have to accept the default"",
                      ""displayTime"": 90.7263559
                    },
                    {
                      ""text"": ""that the Windows Forms designer gives them."",
                      ""displayTime"": 92.7263559
                    },
                    {
                      ""text"": ""And not only the controls, but the names"",
                      ""displayTime"": 95.7263559
                    },
                    {
                      ""text"": ""of the event handlers are also auto-generated,"",
                      ""displayTime"": 97.7263559
                    },
                    {
                      ""text"": ""and so it's a good idea to rename those as well."",
                      ""displayTime"": 100.7263559
                    },
                    {
                      ""text"": ""So, let's rename the names of our controls"",
                      ""displayTime"": 105.7263559
                    },
                    {
                      ""text"": ""and event handlers to make this application easier to read."",
                      ""displayTime"": 107.7263559
                    },
                    {
                      ""text"": ""I won't make you watch while I do this, as it's just a case"",
                      ""displayTime"": 111.7263559
                    },
                    {
                      ""text"": ""of using the refactoring tools within Visual Studio."",
                      ""displayTime"": 114.7263559
                    },
                    {
                      ""text"": ""And so here you can see, I've renamed the controls"",
                      ""displayTime"": 119.7263559
                    },
                    {
                      ""text"": ""and the event handlers and it only took a few seconds to do,"",
                      ""displayTime"": 123.7263559
                    },
                    {
                      ""text"": ""but hopefully you can see how much more readable"",
                      ""displayTime"": 126.7263559
                    },
                    {
                      ""text"": ""the code is already."",
                      ""displayTime"": 129.7263559
                    },
                    {
                      ""text"": ""So do take time to do this"",
                      ""displayTime"": 131.7263559
                    },
                    {
                      ""text"": ""on your own Windows Forms projects."",
                      ""displayTime"": 133.7263559
                    }
                  ]
                },
                {
                  ""title"": ""Using Data Binding"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=8&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""The next thing I want us to look at is the way we discover"",
                      ""displayTime"": 1.1481226
                    },
                    {
                      ""text"": ""which podcast we've currently got selected"",
                      ""displayTime"": 4.1481226
                    },
                    {
                      ""text"": ""and which episode within that podcast."",
                      ""displayTime"": 7.1481226
                    },
                    {
                      ""text"": ""And you can see here, in this line of code,"",
                      ""displayTime"": 10.1481226
                    },
                    {
                      ""text"": ""the way we do it is we see what the selected index"",
                      ""displayTime"": 12.1481226
                    },
                    {
                      ""text"": ""in the list box of podcasts is and we use that index"",
                      ""displayTime"": 15.1481226
                    },
                    {
                      ""text"": ""to look up into a list."",
                      ""displayTime"": 19.1481226
                    },
                    {
                      ""text"": ""And you'll see here is the list of podcasts"",
                      ""displayTime"": 22.1481226
                    },
                    {
                      ""text"": ""that's stored separately."",
                      ""displayTime"": 25.1481226
                    },
                    {
                      ""text"": ""And this is quite a common technique"",
                      ""displayTime"": 27.1481226
                    },
                    {
                      ""text"": ""that I see in a lot of Windows Forms applications."",
                      ""displayTime"": 29.1481226
                    },
                    {
                      ""text"": ""But actually, it does open you up"",
                      ""displayTime"": 32.1481226
                    },
                    {
                      ""text"": ""to some potential problems, and you can see one"",
                      ""displayTime"": 34.1481226
                    },
                    {
                      ""text"": ""of those problems here in this application."",
                      ""displayTime"": 38.1481226
                    },
                    {
                      ""text"": ""Let's have a look at what happens when we remove a podcast."",
                      ""displayTime"": 41.1481226
                    },
                    {
                      ""text"": ""Here we can see, in the button click handler"",
                      ""displayTime"": 46.1481226
                    },
                    {
                      ""text"": ""for the remove podcast button, that when we remove a podcast"",
                      ""displayTime"": 49.1481226
                    },
                    {
                      ""text"": ""we're taking it out of the list control."",
                      ""displayTime"": 53.1481226
                    },
                    {
                      ""text"": ""But we've forgotten to take it out"",
                      ""displayTime"": 56.1481226
                    },
                    {
                      ""text"": ""of our separate list of podcasts."",
                      ""displayTime"": 58.1481226
                    },
                    {
                      ""text"": ""This means that the indexes of the items"",
                      ""displayTime"": 61.1481226
                    },
                    {
                      ""text"": ""in that list box are now out of sync"",
                      ""displayTime"": 63.1481226
                    },
                    {
                      ""text"": ""with the indexes of the corresponding podcasts"",
                      ""displayTime"": 66.1481226
                    },
                    {
                      ""text"": ""in our list of podcasts."",
                      ""displayTime"": 69.1481226
                    },
                    {
                      ""text"": ""But there's an easier way of doing this with Windows Forms."",
                      ""displayTime"": 72.1481226
                    },
                    {
                      ""text"": ""Let's have a look at the code where we're adding something"",
                      ""displayTime"": 75.1481226
                    },
                    {
                      ""text"": ""to our list box."",
                      ""displayTime"": 78.1481226
                    },
                    {
                      ""text"": ""Here, we're filling up the list box of podcasts"",
                      ""displayTime"": 80.1481226
                    },
                    {
                      ""text"": ""by simply adding the title of each podcast"",
                      ""displayTime"": 83.1481226
                    },
                    {
                      ""text"": ""into the list box."",
                      ""displayTime"": 86.1481226
                    },
                    {
                      ""text"": ""But the items that you add to a list box"",
                      ""displayTime"": 88.1481226
                    },
                    {
                      ""text"": ""don't have to be strings, they can be any object."",
                      ""displayTime"": 91.1481226
                    },
                    {
                      ""text"": ""So we could actually add the podcast object, itself,"",
                      ""displayTime"": 94.1481226
                    },
                    {
                      ""text"": ""to the list box."",
                      ""displayTime"": 97.1481226
                    },
                    {
                      ""text"": ""Let's make that change now."",
                      ""displayTime"": 99.1481226
                    },
                    {
                      ""text"": ""Now, let's run this and see what happens."",
                      ""displayTime"": 103.1481226
                    },
                    {
                      ""text"": ""And you can see here, that now we've lost the titles"",
                      ""displayTime"": 107.1481226
                    },
                    {
                      ""text"": ""of our podcasts and that's because Windows Forms"",
                      ""displayTime"": 110.1481226
                    },
                    {
                      ""text"": ""doesn't know what text to display to represent a podcast."",
                      ""displayTime"": 113.1481226
                    },
                    {
                      ""text"": ""But we can fix that quite easily"",
                      ""displayTime"": 117.1481226
                    },
                    {
                      ""text"": ""using the display member property of the list box."",
                      ""displayTime"": 119.1481226
                    },
                    {
                      ""text"": ""Now let's run our application again,"",
                      ""displayTime"": 129.1481226
                    },
                    {
                      ""text"": ""and we can see that now we've got the correct text again."",
                      ""displayTime"": 133.1481226
                    },
                    {
                      ""text"": ""The advantage of this is that now we don't need"",
                      ""displayTime"": 137.1481226
                    },
                    {
                      ""text"": ""to maintain that separate list of podcasts."",
                      ""displayTime"": 139.1481226
                    },
                    {
                      ""text"": ""So let's just make it a local variable,"",
                      ""displayTime"": 143.1481226
                    },
                    {
                      ""text"": ""and now we just need to update the code"",
                      ""displayTime"": 150.1481226
                    },
                    {
                      ""text"": ""that discovers which podcast we've got selected."",
                      ""displayTime"": 152.1481226
                    },
                    {
                      ""text"": ""So instead of indexing into our list of podcasts,"",
                      ""displayTime"": 156.1481226
                    },
                    {
                      ""text"": ""we can simply cast the selected item in the list box"",
                      ""displayTime"": 159.1481226
                    },
                    {
                      ""text"": ""into a podcast, like this."",
                      ""displayTime"": 163.1481226
                    },
                    {
                      ""text"": ""And this means, that we're always getting the podcast"",
                      ""displayTime"": 172.1481226
                    },
                    {
                      ""text"": ""that's actually being displayed in the list box."",
                      ""displayTime"": 175.1481226
                    },
                    {
                      ""text"": ""And we need to make this same fix in a few other places"",
                      ""displayTime"": 178.1481226
                    },
                    {
                      ""text"": ""in the code."",
                      ""displayTime"": 181.1481226
                    },
                    {
                      ""text"": ""So, I'll just do that quickly now."",
                      ""displayTime"": 182.1481226
                    },
                    {
                      ""text"": ""I'm making this simple change has also had the side effect"",
                      ""displayTime"": 186.1481226
                    },
                    {
                      ""text"": ""of fixing that bug we mentioned earlier."",
                      ""displayTime"": 189.1481226
                    },
                    {
                      ""text"": ""Now when we remove a podcast simply by removing it"",
                      ""displayTime"": 191.1481226
                    },
                    {
                      ""text"": ""from the list, it's now completely gone,"",
                      ""displayTime"": 194.1481226
                    },
                    {
                      ""text"": ""and we've not got the mismatch of what you've got selected"",
                      ""displayTime"": 197.1481226
                    },
                    {
                      ""text"": ""in the GUI to what podcast you're working on."",
                      ""displayTime"": 200.1481226
                    },
                    {
                      ""text"": ""Let's apply this same technique to the episodes list box."",
                      ""displayTime"": 204.1481226
                    },
                    {
                      ""text"": ""Here, again, you can see that we're simply looping through"",
                      ""displayTime"": 209.1481226
                    },
                    {
                      ""text"": ""all the episodes in the selected podcast"",
                      ""displayTime"": 212.1481226
                    },
                    {
                      ""text"": ""and adding the title of that episode"",
                      ""displayTime"": 215.1481226
                    },
                    {
                      ""text"": ""to the episodes list box."",
                      ""displayTime"": 217.1481226
                    },
                    {
                      ""text"": ""Now we can eliminate this whole thing if we make use"",
                      ""displayTime"": 220.1481226
                    },
                    {
                      ""text"": ""of the list box data source property."",
                      ""displayTime"": 223.1481226
                    },
                    {
                      ""text"": ""This allows us to get rid of the loop,"",
                      ""displayTime"": 234.1481226
                    },
                    {
                      ""text"": ""and it also removes the need for us to explicitly"",
                      ""displayTime"": 237.1481226
                    },
                    {
                      ""text"": ""clear the list box."",
                      ""displayTime"": 239.1481226
                    },
                    {
                      ""text"": ""So as you can see, this simplifies the code."",
                      ""displayTime"": 243.1481226
                    },
                    {
                      ""text"": ""Now we do need to remember"",
                      ""displayTime"": 246.1481226
                    },
                    {
                      ""text"": ""to set the display member of this list box, as well,"",
                      ""displayTime"": 247.1481226
                    },
                    {
                      ""text"": ""but we probably wouldn't do that here,"",
                      ""displayTime"": 250.1481226
                    },
                    {
                      ""text"": ""we'd do it in the designer or in the constructor"",
                      ""displayTime"": 252.1481226
                    },
                    {
                      ""text"": ""of the form to tell the list box"",
                      ""displayTime"": 255.1481226
                    },
                    {
                      ""text"": ""that the property that we want to display is the title,"",
                      ""displayTime"": 258.1481226
                    },
                    {
                      ""text"": ""and that does need to be set"",
                      ""displayTime"": 261.1481226
                    },
                    {
                      ""text"": ""before you set the data source or it won't work."",
                      ""displayTime"": 263.1481226
                    },
                    {
                      ""text"": ""And making this change allows us to simplify"",
                      ""displayTime"": 267.1481226
                    },
                    {
                      ""text"": ""this complicated line of code down here."",
                      ""displayTime"": 270.1481226
                    },
                    {
                      ""text"": ""Now what we need to do is to simply cast"",
                      ""displayTime"": 273.1481226
                    },
                    {
                      ""text"": ""the selected item from the episodes list box to an episode."",
                      ""displayTime"": 276.1481226
                    },
                    {
                      ""text"": ""So now I've made those changes,"",
                      ""displayTime"": 288.1481226
                    },
                    {
                      ""text"": ""and we're making use of list box data binding"",
                      ""displayTime"": 289.1481226
                    },
                    {
                      ""text"": ""just to make it slightly easier to track"",
                      ""displayTime"": 292.1481226
                    },
                    {
                      ""text"": ""what current podcast and episode we're looking at."",
                      ""displayTime"": 294.1481226
                    },
                    {
                      ""text"": ""Now Windows Forms data binding isn't as powerful"",
                      ""displayTime"": 298.1481226
                    },
                    {
                      ""text"": ""as what you'll find in WPF, but it is worthwhile making use"",
                      ""displayTime"": 301.1481226
                    },
                    {
                      ""text"": ""of what is there if it helps simplify the code"",
                      ""displayTime"": 305.1481226
                    },
                    {
                      ""text"": ""that you're writing in the code behind."",
                      ""displayTime"": 308.1481226
                    }
                  ]
                },
                {
                  ""title"": ""Setting Default Properties on Forms"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=9&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""The next problem I want to talk about"",
                      ""displayTime"": 1.0610893
                    },
                    {
                      ""text"": ""is to do with the default properties of Windows Forms."",
                      ""displayTime"": 3.0610893
                    },
                    {
                      ""text"": ""Let me start the application to show you what I mean."",
                      ""displayTime"": 9.0610893
                    },
                    {
                      ""text"": ""This form has got all the default properties."",
                      ""displayTime"": 15.0610893
                    },
                    {
                      ""text"": ""It means it's got the default icon,"",
                      ""displayTime"": 17.0610893
                    },
                    {
                      ""text"": ""which you probably want to change"",
                      ""displayTime"": 19.0610893
                    },
                    {
                      ""text"": ""for a commercial application."",
                      ""displayTime"": 21.0610893
                    },
                    {
                      ""text"": ""It's got a minimize and maximize button,"",
                      ""displayTime"": 23.0610893
                    },
                    {
                      ""text"": ""a close button, and a resizable border."",
                      ""displayTime"": 26.0610893
                    },
                    {
                      ""text"": ""And you'll see that currently we haven't implemented"",
                      ""displayTime"": 31.0610893
                    },
                    {
                      ""text"": ""resizing in this application which we'll be covering"",
                      ""displayTime"": 34.0610893
                    },
                    {
                      ""text"": ""in the next module."",
                      ""displayTime"": 36.0610893
                    },
                    {
                      ""text"": ""And as we saw earlier, when we click the add button,"",
                      ""displayTime"": 38.0610893
                    },
                    {
                      ""text"": ""the add new podcast dialog is appearing"",
                      ""displayTime"": 41.0610893
                    },
                    {
                      ""text"": ""on the wrong monitor and that's"",
                      ""displayTime"": 43.0610893
                    },
                    {
                      ""text"": ""because it's got the default window location property set."",
                      ""displayTime"": 45.0610893
                    },
                    {
                      ""text"": ""If I drag it into view, you'll see"",
                      ""displayTime"": 48.0610893
                    },
                    {
                      ""text"": ""that this form is also resizable,"",
                      ""displayTime"": 50.0610893
                    },
                    {
                      ""text"": ""has the default icon,"",
                      ""displayTime"": 54.0610893
                    },
                    {
                      ""text"": ""and even has a minimize and maximize buttons."",
                      ""displayTime"": 55.0610893
                    },
                    {
                      ""text"": ""The maximize button is probably pointless"",
                      ""displayTime"": 58.0610893
                    },
                    {
                      ""text"": ""on a form like this given that it's only got one text box"",
                      ""displayTime"": 60.0610893
                    },
                    {
                      ""text"": ""and an OK button."",
                      ""displayTime"": 64.0610893
                    },
                    {
                      ""text"": ""Also, you can't see it on this screenshot,"",
                      ""displayTime"": 65.0610893
                    },
                    {
                      ""text"": ""but both of these windows have got an icon"",
                      ""displayTime"": 68.0610893
                    },
                    {
                      ""text"": ""in the window's taskbar."",
                      ""displayTime"": 70.0610893
                    },
                    {
                      ""text"": ""So, let's go back to Visual Studio"",
                      ""displayTime"": 72.0610893
                    },
                    {
                      ""text"": ""and look at some of the default properties"",
                      ""displayTime"": 74.0610893
                    },
                    {
                      ""text"": ""of a Windows form."",
                      ""displayTime"": 76.0610893
                    },
                    {
                      ""text"": ""Now with many Windows Forms controls,"",
                      ""displayTime"": 81.0610893
                    },
                    {
                      ""text"": ""the default values of their properties are quite sensible."",
                      ""displayTime"": 83.0610893
                    },
                    {
                      ""text"": ""With labels and text boxes and buttons,"",
                      ""displayTime"": 86.0610893
                    },
                    {
                      ""text"": ""you probably only have to customize one property,"",
                      ""displayTime"": 89.0610893
                    },
                    {
                      ""text"": ""at most."",
                      ""displayTime"": 92.0610893
                    },
                    {
                      ""text"": ""But with Windows Forms, there are a lot of properties"",
                      ""displayTime"": 93.0610893
                    },
                    {
                      ""text"": ""that you may need to customize for your application."",
                      ""displayTime"": 96.0610893
                    },
                    {
                      ""text"": ""We won't look at every Windows Forms property here"",
                      ""displayTime"": 100.0610893
                    },
                    {
                      ""text"": ""because that would take a long time,"",
                      ""displayTime"": 102.0610893
                    },
                    {
                      ""text"": ""but let's have a look at a few of the ones"",
                      ""displayTime"": 104.0610893
                    },
                    {
                      ""text"": ""that you might want to customize"",
                      ""displayTime"": 106.0610893
                    },
                    {
                      ""text"": ""whenever you're creating a new form."",
                      ""displayTime"": 107.0610893
                    },
                    {
                      ""text"": ""The first one I'll highlight here is the accept button."",
                      ""displayTime"": 111.0610893
                    },
                    {
                      ""text"": ""This is the button that will be triggered"",
                      ""displayTime"": 114.0610893
                    },
                    {
                      ""text"": ""when you press the enter key."",
                      ""displayTime"": 116.0610893
                    },
                    {
                      ""text"": ""On this form, the Add New Podcast form,"",
                      ""displayTime"": 118.0610893
                    },
                    {
                      ""text"": ""it would make sense for the OK button to be selected."",
                      ""displayTime"": 120.0610893
                    },
                    {
                      ""text"": ""So, let's do that now."",
                      ""displayTime"": 124.0610893
                    },
                    {
                      ""text"": ""And as you can see, Windows actually styles that button"",
                      ""displayTime"": 129.0610893
                    },
                    {
                      ""text"": ""differently to show the user this is the one"",
                      ""displayTime"": 131.0610893
                    },
                    {
                      ""text"": ""that's going to be selected"",
                      ""displayTime"": 134.0610893
                    },
                    {
                      ""text"": ""when they press the enter button."",
                      ""displayTime"": 135.0610893
                    },
                    {
                      ""text"": ""If we'd had a cancel button on this form,"",
                      ""displayTime"": 138.0610893
                    },
                    {
                      ""text"": ""we could set that down here, and that's the button"",
                      ""displayTime"": 140.0610893
                    },
                    {
                      ""text"": ""that would be triggered when you press the escape key."",
                      ""displayTime"": 142.0610893
                    },
                    {
                      ""text"": ""If we look a bit further down on these properties,"",
                      ""displayTime"": 146.0610893
                    },
                    {
                      ""text"": ""we can see that we can adjust the form border style."",
                      ""displayTime"": 150.0610893
                    },
                    {
                      ""text"": ""Currently this form is resizable,"",
                      ""displayTime"": 154.0610893
                    },
                    {
                      ""text"": ""but if we wanted it not to be resizable,"",
                      ""displayTime"": 156.0610893
                    },
                    {
                      ""text"": ""we could choose one of these fixed sized options, here."",
                      ""displayTime"": 159.0610893
                    },
                    {
                      ""text"": ""You can see here that we can set the icon for the form"",
                      ""displayTime"": 165.0610893
                    },
                    {
                      ""text"": ""if you've got a custom icon for your application."",
                      ""displayTime"": 167.0610893
                    },
                    {
                      ""text"": ""And we can also set whether this form is localize-able"",
                      ""displayTime"": 171.0610893
                    },
                    {
                      ""text"": ""which is something we'll be looking at later in this course."",
                      ""displayTime"": 174.0610893
                    },
                    {
                      ""text"": ""For localized applications, you'll want to make sure"",
                      ""displayTime"": 178.0610893
                    },
                    {
                      ""text"": ""that you set this to true on every form you create."",
                      ""displayTime"": 180.0610893
                    },
                    {
                      ""text"": ""We've got the options here to turn off"",
                      ""displayTime"": 184.0610893
                    },
                    {
                      ""text"": ""the minimize and maximize buttons."",
                      ""displayTime"": 186.0610893
                    },
                    {
                      ""text"": ""And as we've said for this form,"",
                      ""displayTime"": 189.0610893
                    },
                    {
                      ""text"": ""it doesn't really make sense that they're there."",
                      ""displayTime"": 190.0610893
                    },
                    {
                      ""text"": ""So let's do that now."",
                      ""displayTime"": 192.0610893
                    },
                    {
                      ""text"": ""And if we look further down,"",
                      ""displayTime"": 195.0610893
                    },
                    {
                      ""text"": ""you'll see that here is the option"",
                      ""displayTime"": 197.0610893
                    },
                    {
                      ""text"": ""for whether this form shows an icon in the taskbar, or not."",
                      ""displayTime"": 198.0610893
                    },
                    {
                      ""text"": ""Usually, for the main form of your application,"",
                      ""displayTime"": 202.0610893
                    },
                    {
                      ""text"": ""you want to set this to true, but for your child windows"",
                      ""displayTime"": 205.0610893
                    },
                    {
                      ""text"": ""you probably want to set it to false."",
                      ""displayTime"": 208.0610893
                    },
                    {
                      ""text"": ""And finally, the location in which this window appeared in"",
                      ""displayTime"": 211.0610893
                    },
                    {
                      ""text"": ""also needed to be customized."",
                      ""displayTime"": 215.0610893
                    },
                    {
                      ""text"": ""The default location was putting it on my primary monitor,"",
                      ""displayTime"": 217.0610893
                    },
                    {
                      ""text"": ""and, yet, I was running the application"",
                      ""displayTime"": 220.0610893
                    },
                    {
                      ""text"": ""on my secondary monitor."",
                      ""displayTime"": 221.0610893
                    },
                    {
                      ""text"": ""There are various options that you can choose here."",
                      ""displayTime"": 224.0610893
                    },
                    {
                      ""text"": ""Probably the easiest, in this case,"",
                      ""displayTime"": 227.0610893
                    },
                    {
                      ""text"": ""is to use send to parent."",
                      ""displayTime"": 229.0610893
                    },
                    {
                      ""text"": ""This tells this form to appear in the center"",
                      ""displayTime"": 232.0610893
                    },
                    {
                      ""text"": ""of its parent window when it starts up."",
                      ""displayTime"": 235.0610893
                    },
                    {
                      ""text"": ""So it will appear right over the main My Podcast window."",
                      ""displayTime"": 238.0610893
                    },
                    {
                      ""text"": ""Let's run this application and see that in action."",
                      ""displayTime"": 241.0610893
                    },
                    {
                      ""text"": ""Now when we click the add new podcast button,"",
                      ""displayTime"": 245.0610893
                    },
                    {
                      ""text"": ""the form appears right over its parent."",
                      ""displayTime"": 249.0610893
                    },
                    {
                      ""text"": ""And as you can see, we've got no minimize"",
                      ""displayTime"": 252.0610893
                    },
                    {
                      ""text"": ""and maximize buttons although I have still left"",
                      ""displayTime"": 254.0610893
                    },
                    {
                      ""text"": ""this window resizable, at the moment."",
                      ""displayTime"": 256.0610893
                    },
                    {
                      ""text"": ""Now, it's not possible for me to tell you exactly"",
                      ""displayTime"": 260.0610893
                    },
                    {
                      ""text"": ""which properties on each form you need to set"",
                      ""displayTime"": 263.0610893
                    },
                    {
                      ""text"": ""for your application, but I would suggest"",
                      ""displayTime"": 265.0610893
                    },
                    {
                      ""text"": ""if you're making a large Windows Forms application"",
                      ""displayTime"": 268.0610893
                    },
                    {
                      ""text"": ""creating a checklist for developers to make sure"",
                      ""displayTime"": 271.0610893
                    },
                    {
                      ""text"": ""that they've set all the right properties"",
                      ""displayTime"": 274.0610893
                    },
                    {
                      ""text"": ""on each new form they create."",
                      ""displayTime"": 276.0610893
                    },
                    {
                      ""text"": ""This allows you to make sure you've got a"",
                      ""displayTime"": 278.0610893
                    },
                    {
                      ""text"": ""consistent experience right across your application."",
                      ""displayTime"": 280.0610893
                    }
                  ]
                },
                {
                  ""title"": ""Module Summary"",
                  ""playerUrl"": ""//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=10&mode=live"",
                  ""segments"": [
                    {
                      ""text"": ""Let's review what we've learned in this module."",
                      ""displayTime"": 2.0469893
                    },
                    {
                      ""text"": ""Yes, Windows Forms may be an old technology,"",
                      ""displayTime"": 5.0469893
                    },
                    {
                      ""text"": ""and you may even be wishing that you can get away from it,"",
                      ""displayTime"": 9.0469893
                    },
                    {
                      ""text"": ""but that doesn't mean you can't use it"",
                      ""displayTime"": 12.0469893
                    },
                    {
                      ""text"": ""to create excellent Windows Forms applications."",
                      ""displayTime"": 15.0469893
                    },
                    {
                      ""text"": ""With Windows Forms, there's no reason why your applications"",
                      ""displayTime"": 19.0469893
                    },
                    {
                      ""text"": ""can't be visually appealing, and, from a coding perspective,"",
                      ""displayTime"": 22.0469893
                    },
                    {
                      ""text"": ""it is possible for them to be well architected,"",
                      ""displayTime"": 26.0469893
                    },
                    {
                      ""text"": ""maintainable, and testable."",
                      ""displayTime"": 29.0469893
                    },
                    {
                      ""text"": ""And in this module, we also had a look"",
                      ""displayTime"": 33.0469893
                    },
                    {
                      ""text"": ""at the demo application that we're going to be working with"",
                      ""displayTime"": 35.0469893
                    },
                    {
                      ""text"": ""throughout the course which is an application that helps you"",
                      ""displayTime"": 39.0469893
                    },
                    {
                      ""text"": ""to keep track of the podcasts you're subscribed to."",
                      ""displayTime"": 42.0469893
                    },
                    {
                      ""text"": ""And it allowed us to introduce a few best practices"",
                      ""displayTime"": 46.0469893
                    },
                    {
                      ""text"": ""such as making sure that you give the controls"",
                      ""displayTime"": 49.0469893
                    },
                    {
                      ""text"": ""and events, in your code behind, meaningful names"",
                      ""displayTime"": 53.0469893
                    },
                    {
                      ""text"": ""rather than accepting the defaults"",
                      ""displayTime"": 56.0469893
                    },
                    {
                      ""text"": ""that the Windows Forms designer gives them."",
                      ""displayTime"": 58.0469893
                    },
                    {
                      ""text"": ""So use textBoxEpisodeName"",
                      ""displayTime"": 61.0469893
                    },
                    {
                      ""text"": ""instead of text box five."",
                      ""displayTime"": 63.0469893
                    },
                    {
                      ""text"": ""And use OnSelectedPodcastChanged instead"",
                      ""displayTime"": 66.0469893
                    },
                    {
                      ""text"": ""of list box two underscore selection changed."",
                      ""displayTime"": 69.0469893
                    },
                    {
                      ""text"": ""We also saw how it's sometimes possible"",
                      ""displayTime"": 74.0469893
                    },
                    {
                      ""text"": ""to simplify your code behind by making use"",
                      ""displayTime"": 77.0469893
                    },
                    {
                      ""text"": ""of the data binding features of Windows Forms."",
                      ""displayTime"": 80.0469893
                    },
                    {
                      ""text"": ""Yes, Windows Forms data binding isn't as powerful as WPF's,"",
                      ""displayTime"": 83.0469893
                    },
                    {
                      ""text"": ""but do still make use of it when it's available."",
                      ""displayTime"": 88.0469893
                    },
                    {
                      ""text"": ""In the example we looked at was with a list box"",
                      ""displayTime"": 91.0469893
                    },
                    {
                      ""text"": ""of setting its data source and display member properties"",
                      ""displayTime"": 94.0469893
                    },
                    {
                      ""text"": ""to allow us to data bind a list of podcasts to a list box."",
                      ""displayTime"": 98.0469893
                    },
                    {
                      ""text"": ""And although we didn't look at it, this exact same technique"",
                      ""displayTime"": 103.0469893
                    },
                    {
                      ""text"": ""can be used very effectively with combo boxes as well."",
                      ""displayTime"": 106.0469893
                    },
                    {
                      ""text"": ""And finally, we discussed the fact"",
                      ""displayTime"": 111.0469893
                    },
                    {
                      ""text"": ""that the default properties that your forms will have"",
                      ""displayTime"": 113.0469893
                    },
                    {
                      ""text"": ""when you create them with the Forms designer"",
                      ""displayTime"": 116.0469893
                    },
                    {
                      ""text"": ""won't always be the most appropriate for your application."",
                      ""displayTime"": 118.0469893
                    },
                    {
                      ""text"": ""So, it is important that when you create a new form"",
                      ""displayTime"": 122.0469893
                    },
                    {
                      ""text"": ""that you go through all the properties"",
                      ""displayTime"": 125.0469893
                    },
                    {
                      ""text"": ""and you check that they're set up correctly."",
                      ""displayTime"": 127.0469893
                    },
                    {
                      ""text"": ""We looked at several examples such as the accept button,"",
                      ""displayTime"": 130.0469893
                    },
                    {
                      ""text"": ""and cancel button properties, the localize-able flag,"",
                      ""displayTime"": 133.0469893
                    },
                    {
                      ""text"": ""whether it shows an icon in the taskbar or not,"",
                      ""displayTime"": 138.0469893
                    },
                    {
                      ""text"": ""what the start position of the form is,"",
                      ""displayTime"": 142.0469893
                    },
                    {
                      ""text"": ""and whether you've got a minimize or maximize box."",
                      ""displayTime"": 145.0469893
                    },
                    {
                      ""text"": ""And I recommended that you make a checklist"",
                      ""displayTime"": 148.0469893
                    },
                    {
                      ""text"": ""for your application that has the properties"",
                      ""displayTime"": 152.0469893
                    },
                    {
                      ""text"": ""that are important for you to set"",
                      ""displayTime"": 154.0469893
                    },
                    {
                      ""text"": ""so that you can make sure that all the forms you create"",
                      ""displayTime"": 156.0469893
                    },
                    {
                      ""text"": ""are setup appropriately and have a consistent look and feel"",
                      ""displayTime"": 159.0469893
                    },
                    {
                      ""text"": ""to them."",
                      ""displayTime"": 163.0469893
                    },
                    {
                      ""text"": ""In our next module, we're going to be looking"",
                      ""displayTime"": 164.0469893
                    },
                    {
                      ""text"": ""at the topics of laying out the controls on forms"",
                      ""displayTime"": 166.0469893
                    },
                    {
                      ""text"": ""and how we can make our forms resizable."",
                      ""displayTime"": 169.0469893
                    }
                  ]
                }
              ]
            }";

            // Act
            TranscriptModule transcriptModule = JsonConvert.DeserializeObject<TranscriptModule>(Json);

            // Assert
            Assert.IsNotNull(transcriptModule);
            Assert.AreEqual("Creating Excellent Windows Forms Applications", transcriptModule.Title);
            Assert.AreEqual("//app.pluralsight.com/player?course=windows-forms-best-practices&author=mark-heath&name=windows-forms-best-practices-m1&clip=0&mode=live", transcriptModule.PlayerUrl);
            Assert.IsNotNull(transcriptModule.Clips);
            Assert.IsTrue(transcriptModule.Clips.Length > 1);
        }
    }
}
