# Contributing

Thank you for your interest in contributing to this project.

The following text is a set of guidelines for contributing to the project hosted on GitHub. These are just guidelines, not rules. Use your best judgment, and feel free to propose changes to this document in a pull request.

Following these guidelines helps to communicate that you respect the time of the developers managing and developing this open source project. In return, they should reciprocate that respect in addressing your issue, assessing changes, and helping you finalize your pull requests.

#### Table of Contents

[What Should I Know Before I Get Started?](#what-should-i-know-before-i-get-started)
  * [Code of Conduct](#code-of-conduct)
  * [Project Purpose](#project-purpose)
  * [Documentation](#documentation)

[How Do I Get Started?](#how-do-i-get-started?)
  * [Prerequisites](#prerequisites)
  * [Get the Code](#get-the-code)
  * [Building the Project](#building-the-project)
  * [Running the Tests](#running-the-tests)

[How Can I Contribute?](#how-can-i-contribute)
  * [Reporting Security Vulnerabilities](#reporting-security-vulnerabilities)
  * [Reporting Bugs](#reporting-bugs)
    * [Before Submitting a Bug Report](#before-submitting-a-bug-report)
    * [How Do I Submit A (Good) Bug Report?](#how-do-i-submit-a-good-bug-report)
  * [Suggesting Enhancements](#suggesting-enhancements)
    * [Before Submitting an Enhancement Request](#before-submitting-an-enhancement-request)
    * [How Do I Submit A (Good) Enhancement Request?](#how-do-i-submit-a-good-enhancement-request)
  * [Your First Code Contribution](#your-first-code-contribution)
  * [Pull Requests](#pull-requests)

[Style Guides](#style-guides)
  * [Git Commit Messages](#git-commit-messages)
  * [C# Style Guide](#c#-style-guide)
  * [Unit Test Style Guide](#unit-test-style-guide)
  * [Documentation Style Guide](#documentation-style-guide)

[Additional Notes](#additional-notes)
  * [Issue and Pull Request Labels](#issue-and-pull-request-labels)
    * [Type of Issue and Issue State](#type-of-issue-and-issue-state)
    * [Topic Categories](#topic-categories)
    * [Pull Request Labels](#pull-request-labels)

## What Should I Know Before I Get Started?

### Code of Conduct

This project adheres to the Contributor Covenant [code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to [codebluedev@gmail.com](mailto:codebluedev@gmail.com).

### Project Purpose

This project aims to be a referenced assembly containing PluralSight domain models that can be utilized by other .NET projects. By abstracting the domain models in this way any logic pertaining to the domain models is decoupled. Which allows the domain models to be used by more projects. This means the project does not contain any implementation details, so any feature requests should be pushed to their respective components consuming this resource. Each component should have its own repository and can be contributed to there.

To get a sense of this, here are a few libraries that use this project:

* [CodeBlueDev.PluralSight.Net](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Net) - A web request library for interacting with the PluralSight website via objects. In essence, the project emulates the web requests a web browser would make but with specific functionality tied to the web responses given by the PluralSight website. This allows custom applications to be written that interface with the PluralSight website.

### Documentation

If you have any questions, check to see if the answer can be found in the [wiki](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/wiki). For a specific version of the library, check the [documentation](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/Documentation). If it is not documented in either of these places, please reach out via [email](mailto:codebluedev@gmail.com) or [social media](https://twitter.com/intent/tweet?text=@CodeBlueDev). Please do not use the issue tracker for support questions.

## How Do I Get Started?

### Prerequisites

This section guides you through the items that are required to set up the project from source. Following these guidelines will help you set the environment up to be able to build, run, and test the project.

#### .NET Framework v4.6.2

The project is built on the [.NET Framework version 4.6.2](https://www.microsoft.com/en-us/download/details.aspx?id=48130). Although there is nothing explicitly preventing this library from running on a previous version of the .NET Framework.

#### Visual Studio

The project is built using [Visual Studio 2015](https://msdn.microsoft.com/en-us/library/dd831853.aspx). Although previous versions of Visual Studio should be compatible. The project maintainer(s) recommend the following extensions:

* CodeMaid
* Productivity Power Tools

#### NUnit

The project's unit tests utilize the [NUnit](http://nunit.org/) unit-testing framework.

#### ReSharper

The project maintainer(s) highly recommend the use of [ReSharper](https://www.jetbrains.com/resharper/) to ensure code quality. The project maintainers also recommend the following ReSharper extensions:

* StyleCop by JetBrains
* Enhanced Tooltip
* Cyclomatic Complexity

### Get the Code

```sh
git clone https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models.git CodeBlueDev.PluralSight.Core.Models
```

### Building the Project

This section guides you through compiling the project from source. Following these guidelines will help you get a working assembly on your local machine for development and testing purposes.

#### Command Line

**Windows:**

From the Source/CodeBlueDev.PluralSight.Core.Models.dll directory...

```sh
csc.exe /t:library /out:CodeBlueDev.PluralSight.Core.Models.dll Author.cs Course.cs ...
```

More information about Command-Line building can be found at the [MSDN website](https://msdn.microsoft.com/en-us/library/78f4aasd(VS.80).aspx).

#### Visual Studio

Open the CodeBlueDev.PluralSight.Core.Models.sln in the root directory of the project. Under the Build menu item select the Rebuild Solution option. 

### Running the Tests

This section guides you through running the unit tests included in the source. Following these guidelines will help you get the unit tests running to verify the library works as designed. The CodeBlueDev.PluralSight.Core.Models.Tests project must be compiled prior to running the unit tests.

#### Command Line

```sh
nunit3-console -targetargs:" --domain=single  Source\CodeBlueDev.PluralSight.Core.Models.Test\bin\Release\CodeBlueDev.PluralSight.Core.Models.Test.dll"
```

More information about running the unit tests from the Command-Lin can be found in the [NUnit documentation](https://github.com/nunit/docs/wiki/Console-Command-Line).

#### Visual Studio

Open the CodeBlueDev.PluralSight.Core.Models.sln in the root directory of the project. Under the Test menu item, open the Test Explorer window under Windows.

> Build your solution to discover all available tests. Click "Run All" to build, discover, and run all tests in your solution.

## How Can I Contribute?

### Reporting Security Vulnerabilities

You must never report security related issues, vulnerabilities or bugs including sensitive information to the bug tracker, or elsewhere in public. Send an email disclosing the vulnerability to [codebluedev@gmail.com](mailto:codebluedev@gmail.com) instead.

In order to determine whether you are dealing with a security issue, ask yourself these two questions:
* Can I access something that's not mine, or something I shouldn't have access to?
* Can I disable something for other people?

> If the answer to either of those two questions are "yes", then you're probably dealing with a security issue. Note that even if you answer "no" to both questions, you may still be dealing with a security issue, so if you're unsure, just email us at [codebluedev@gmail.com](mailto:codebluedev@gmail.com).

The lead maintainer will acknowledge your email within 72 hours, and will send a more detailed response within 48 hours indicating the next steps in handling your report. After the initial reply to your report, the security team will endeavor to keep you informed of the progress towards a fix and full announcement, and may ask for additional information or guidance.

### Reporting Bugs

This section guides you through submitting a bug report. Following these guidelines helps maintainers and the community understand your report, reproduce the behavior, and find related reports.

Before submitting bug reports, please check [this list](#before-submitting-a-bug-report) as you may find out that you do not need to create one. When you are submitting a bug report, please [include as many details as possible](#how-do-i-submit-a-good-bug-report). Fill out the [required template](ISSUE_TEMPLATE.md), as the information it asks for will help resolve issues faster.

#### Before Submitting a Bug Report

* **Attempt to debug**. You might be able to find the cause of the problem and fix things yourself. Most importantly, check if you can reproduce the problem in the latest version.
* **Check the Wiki and Documentation** to see if the issue already has a resolution.
* **Determine [which repository the problem should be reported in](#project-purpose).**
* **Perform a [cursory search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/issues?q=is%3Aopen)** to see if the problem has already been reported. If it has, add a comment to the existing issue instead of opening a new one.

#### How Do I Submit A (Good) Bug Report?

Bugs are tracked as [GitHub Issues](https://guides.github.com/features/issues/). After you have determined [which repository](#project-purpose) your bug is related to, create an issue on that repository and provide the following information by filling in the template.

Explain the problem and include additional details to help maintainers reproduce the problem:

* **Use a clear and descriptive title** for the issue to identify the problem.
* **Describe the exact steps which reproduce the problem** in as many details as possible.
* **Provide specific examples to demonstrate the steps**. Include links to files or GitHub projects, or copy/pasteable snippets, which you use in those examples. If you're providing snippets in the issue, use [Markdown code blocks](https://help.github.com/articles/markdown-basics/#multiple-lines).
* **Describe the behavior you observed after following the steps** and point out what exactly is the problem with that behavior.
* **Explain which behavior you expected to see instead and why.**
* **Include screenshots and animated GIFs** which show you following the described steps and clearly demonstrate the problem. You can use [this tool](http://www.cockos.com/licecap/) to record GIFs on macOS and Windows, and [this tool](https://github.com/colinkeenan/silentcast) or [this tool](https://github.com/GNOME/byzanz) on Linux.
* **If the problem wasn't triggered by a specific action**, describe what you were doing before the problem happened and share more information using the guidelines below. 

Provide more context by answering these questions:

* **Did the problem start happening recently** (e.g. after updating to a new version) or was this always a problem?
* If the problem started happening recently, **can you reproduce the problem in an older version?** What's the most recent version in which the problem doesn't happen?
* **Can you reliably reproduce the issue?** If not, provide details about how often the problem happens and under which conditions it normally happens.
 
Include details about your configuration and environment:

* **Which version are you using?**
* **What's the name and version of the OS you are using**?
* **Are you running in a virtual machine?** If so, which VM software are you using and which operating system and versions are used for the host and the guest?
* **Which keyboard layout are you using?** Are you using a US layout or some other layout?

### Suggesting Enhancements

This section guides you through submitting an enhancement suggestion, including completely new features and minor improvements to existing functionality. Following these guidelines helps maintainers and the community understand your suggestion and find related suggestions.

Before submitting enhancement suggestions, please check [this list](#before-submitting-an-enhancement-request) as you may find out that you do not need to create one. When you are creating an enhancement suggestion, please [include as many details as possible](#how-do-i-submit-a-good-enhancement-request). Fill in [the template](ISSUE_TEMPLATE.md), including the steps that you imagine you would take if the feature you're requesting existed.

#### Before Submitting an Enhancement Request

* **Attempt to debug**. You might discover that the enhancement is already available. Most importantly, check if you are using the latest version and if you can get the desired behavior by upgrading.
* **Check if there is already a library which provides that enhancement.**
* **Determine [which repository the enhancement should be requested in](#project-purpose).**
* **Perform a [cursory search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/issues?q=is%3Aopen)** to see if the enhancement has already been suggested. If it has, add a comment to the existing issue instead of opening a new one.

#### How Do I Submit A (Good) Enhancement Request?

Enhancement suggestions are tracked as [GitHub Issues](https://guides.github.com/features/issues/). After you've determined [which repository](#project-purpose) your enhancement request is related to, create an issue on that repository and provide the following information:

* **Use a clear and descriptive title** for the issue to identify the suggestion.
* **Provide a step-by-step description of the suggested enhancement** in as many details as possible.
* **Provide specific examples to demonstrate the steps**. Include copy/pasteable snippets which you use in those examples, as [Markdown code blocks](https://help.github.com/articles/markdown-basics/#multiple-lines).
* **Describe the current behavior** and **explain which behavior you expected to see instead** and why.
* **Include screenshots and animated GIFs** which help you demonstrate the steps or point out the part of the project which the suggestion is related to. You can use [this tool](http://www.cockos.com/licecap/) to record GIFs on macOS and Windows, and [this tool](https://github.com/colinkeenan/silentcast) or [this tool](https://github.com/GNOME/byzanz) on Linux.
* **Explain why this enhancement would be useful** to most users and isn't something that can or should be implemented as a [community package](#project-purpose).
* **List some other text editors or applications where this enhancement exists.**
* **Specify which version you are using.**
* **Specify the name and version of the OS you're using.**

### Your First Code Contribution

Unsure where to begin contributing? You can start by looking through these `beginner` and `help-wanted` issues:

* [Beginner](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/beginner) - issues which should only require a few lines of code, and a test or two.
* [Help Wanted](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/help%20wanted) - issues which should be a bit more involved than `beginner` issues.

Both issue lists are sorted by total number of comments. While not perfect, number of comments is a reasonable proxy for impact a given change will have.

Not finding anything there? Be sure to check out other [open source libraries](#project-purpose) that consume this project.

### Pull Requests

Working on your first Pull Request? You can learn how from this *free* series, [How to Contribute to an Open Source Project on GitHub](https://egghead.io/series/how-to-contribute-to-an-open-source-project-on-github). Other potential resources you may be interested in are [MakeAPullRequest](http://makeapullrequest.com] and [FirstTimersOnly](http://www.firsttimersonly.com). 

At this point, you are ready to make your changes. Feel free to ask for help; everyone begins somewhere.

If a maintainer asks you to "rebase" your pull request, they are saying that a lot of code has changed, and that you need to update your branch so that it is easier to merge.

When submitting a pull request (PR) please make sure to follow the guidelines below as close as possible. This will help ensure your pull request is accepted.

* Fill in [the required template](PULL_REQUEST_TEMPLATE.md)
* Include screenshots and/or animated GIFs in your pull request whenever possible.
* Follow the [C# Style Guide](#c-style-guide).
* Include complete unit tests following the [Unit Test Style Guide](#unit-test-style-guide).  
* Document new code based on the [Documentation Style Guide](#documentation-style-guide)
* End files with a newline.
* Place `usings` in the following order inside the namespace:
    * .NET Framework libraries in alphabetical order.
    * Project libraries in alphabetical order.
    * NuGet/Third-Party/Other libraries in alphabetical order. 

```cs
    using Newtonsoft.Json;

    using NUnit.Framework;
```

* Place class properties in the following order:
    * `const` values starting with a capital letter.
    * `public`/`internal` `readonly`/`static` values starting with a capital letter.
    * `private` `readonly`/`static` values.
    * `public`/`internal` members or fields.
    * `private` members or fields.

Examples:

```cs
    public const int SampleConstantValue = 1;
```

```cs
    public static int SampleStaticValue;
```

```cs
    private readonly SampleReadOnlyValue;
```

* Place class methods in the following order:
    * `public` `static`
    * `internal` `static`
    * `private` `static`
    * `public` `member`
    * `internal` `member`
    * `private` `member`
* Avoid platform-dependent code when possible.

## Style Guides

### Git Commit Messages

This project follows the [Seven Rules of a Great Git Commit Message](https://chris.beams.io/posts/git-commit/#seven-rules)
1. Separate subject from body with a blank line.
2. Limit the subject line to 50 characters.
3. Capitalize the subject line.
4. Do not end the subject line with a period.
5. Use the imperative mood in the subject line.
6. Wrap the body at 72 characters.
7. Use the body to explain what and why vs. how.

### C# Style Guide

This project follows the [StyleCop Guidelines](https://github.com/StyleCop). This ensures the project is analyzed to enforce a set of style and consistency rules. A [ReSharper](https://www.jetbrains.com/resharper/) extension provides feedback when a file is breaking the recommended C# Style Guide.

### Unit Test Style Guide

This project uses the following pattern for unit tests:
1. An operation
2. The operation should or should not
3. Have this effect on the state

```cs
FullCourseJsonWithMultipleModulesShouldDeserializeIntoFullCourseModelWithMultipleCourseModules
```

1. FullCourseJsonWithMultipleModules
2. Should
3. DeserializeIntoFullCourseModelWithMultipleCourseModules

### Documentation Styleguide

* Use [Markdown](https://daringfireball.net/projects/markdown).
* Reference single value keywords with a single backtick such as `public`
* Reference code snippets using the triple backtick with the language immediately following afterwards.

```cs
public static void Main(string[] args)
{
    Console.WriteLine("Hello World!");
}
```

## Additional Notes

### Issue and Pull Request Labels

This section lists the labels we use to help us track and manage issues and pull requests. Ideally labels are used across all related repositories, but some may be specific to this project.

[GitHub search](https://help.github.com/articles/searching-issues/) makes it easy to use labels for finding groups of issues or pull requests you're interested in. For example, you may be interested in [open issues across `CodeBlueDev/CodeBlueDev.PluralSight.Core.Models` and all related packages which are labeled as bugs, but still need to be reliably reproduced](https://github.com/issues?utf8=%E2%9C%93&q=is%3Aopen+is%3Aissue+user%3ACodeBlueDev+label%3Abug+label%3Aneeds-reproduction). To help you find issues and pull requests, each label is listed with search links for finding open items with that label in `CodeBlueDev/CodeBlueDev.PluralSight.Core.Models` only. We encourage you to read about [other search filters](https://help.github.com/articles/searching-issues/) which will help you write more focused queries.

The labels are loosely grouped by their purpose, but it's not required that every issue have a label from every group or that an issue can't have more than one label from the same group.

Please open an issue on `CodeBlueDev/CodeBlueDev.PluralSight.Core.Models` if you have suggestions for new labels, and if you notice some labels are missing on some repositories, then please open an issue on that repository.

#### Type of Issue and Issue State

| Label Name | :mag_right: | Description |
| --- | --- | --- |
| `enhancement` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/enhancement) | Feature requests. |
| `bug` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/bug) | Confirmed bugs or reports that are very likely to be bugs. |
| `question` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/question) | Questions more than bug reports or feature requests (e.g. how do I do X). |
| `feedback` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/feedback) | General feedback more than bug reports or feature requests. |
| `help-wanted` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/help-wanted) | The CodeBlueDev.PluralSight.Core.Models team would appreciate help from the community in resolving these issues. |
| `beginner` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/beginner) | Less complex issues which would be good first issues to work on for users who want to contribute to CodeBlueDev.PluralSight.Core.Models. |
| `more-information-needed` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/more-information-needed) | More information needs to be collected about these problems or feature requests (e.g. steps to reproduce). |
| `needs-reproduction` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/needs-reproduction) | Likely bugs, but haven't been reliably reproduced. |
| `blocked` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/blocked) | Issues blocked on other issues. |
| `duplicate` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/duplicate) | Issues which are duplicates of other issues, i.e. they have been reported before. |
| `wontfix` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/wontfix) | The CodeBlueDev.PluralSight.Core.Models team has decided not to fix these issues for now, either because they're working as intended or for some other reason. |
| `invalid` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/invalid) | Issues which aren't valid (e.g. user errors). |
| `in-progress` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/in-progress) | Issues which are currently being worked on. 
| `regression` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/regression) | A bug has been re-introduced from a previous version. 
| `tracking` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/tracking) | Issues which have been reviewed and determined need to be resolved.
| `triaged` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/triaged) | Issues which have been reviewed and are being worked on.
| `package-idea` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/package-idea) | Feature request which might be good candidates for new packages, instead of extending CodeBlueDev.PluralSight.Core.Models. |
| `wrong-repository` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/wrong-repository) | Issues reported on the wrong repository (e.g. a bug related to the [CodeBlueDev.PluralSight.Net Library](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Net) was reported on [CodeBlueDev.PluralSight.Core.Models](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models)). |

#### Topic Categories

| Label name | :mag_right: | Description |
| --- | --- | --- |
| `windows` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/windows) | Related to CodeBlueDev.PluralSight.Core.Models running on Windows. |
| `linux` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/linux) | Related to CodeBlueDev.PluralSight.Core.Models running on Linux. |
| `mac` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/mac) | Related to CodeBlueDev.PluralSight.Core.Models running on macOS. |
| `documentation` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/documentation) | Related to any type of documentation (e.g. [API documentation](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/tree/master/Documentation) and the [Wiki](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/wiki)). |
| `performance` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/performance) | Related to performance. |
| `security` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/security) | Related to security. |
| `api` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/api) | Related to CodeBlueDev.PluralSight.Core.Models's public APIs. |
| `uncaught-exception` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/uncaught-exception) | Issues about uncaught exceptions. |
| `proposal` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/proposal) | Proposals for how to solve an architectural issue.
| `crash` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/crash) | Reports of CodeBlueDev.PluralSight.Core.Models completely crashing. |
| `data-loss` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/data-loss) | Reports of CodeBlueDev.PluralSight.Core.Models losing data.
| `network` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/network) | Related to network problems or working with remote files (e.g. on network drives). |
| `git` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/git) | Related to Git functionality (e.g. problems with gitignore files or with showing the correct file status). |

#### `CodeBlueDev/CodeBlueDev.PluralSight.Core.Models` Topic Categories

| Label name | :mag_right: | Description |
| --- | --- | --- |
| `build-error` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/build-error) | Related to problems with building CodeBlueDev.PluralSight.Core.Models from source. |
| `deprecation-help` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/deprecation-help) | Issues for helping package authors remove usage of deprecated APIs in packages. |

#### Pull Request Labels

| Label Name | :mag_right: | Description
| --- | --- | --- |
| `work-in-progress` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/work-in-progress) | Pull requests which are still being worked on, more changes will follow. |
| `needs-review` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/needs-review) | Pull requests which need code review, and approval from maintainers. |
| `under-review` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/under-review) | Pull requests being reviewed by maintainers. |
| `requires-changes` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/requires-changes) | Pull requests which need to be updated based on review comments and then reviewed again. |
| `needs-testing` | [search](https://github.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/labels/needs-testing) | Pull requests which need manual testing. |