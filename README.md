# CodeBlueDev.PluralSight.Core.Models
[![License](https://img.shields.io/github/license/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models.svg?label=License)](https://raw.githubusercontent.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/master/LICENSE)

A .NET library containing PluralSight domain models that can be utilized by other .NET projects.

## Contents
- [TODO](#todo)
- PluralSight Core Models
    - [Author](#author)
        - Properties
        - Sample JSON
    - [Clip](#clip)
        - Properties
        - Sample JSON
    - [Course](#course)
        - Properties
        - Sample JSON
    - [Course Level](#course-level)
        - Properties
        - Sample JSON
    - [Course Rating](#course-rating)
        - Properties
        - Sample JSON
        
## TODO:
- [ ] Transcripts (Not returned in current JSON).
- [ ] Notes (Appears when watching a video clip).

## Author
An Author model will usually be created via deserialization of the Course JSON response. Multiple Author models can be included in the JSON response but the properties for each Author will remain the same.

### Author Properties
|Property |Description|
|:-------:|-----------|
|Handle   |The web friendly value that represents the PluralSight Author's name. Usually consists of the Author's first and last name separated by a '-'. The value is often used in PluralSight web requests (such as viewing all videos by an Author).|
|FirstName|The Author's first name.|
|LastName |The Author's last name. |

### Author Sample JSON
```json
{
    "handle":"mark-heath",
    "firstName":"Mark",
    "lastname":"Heath"
}
```

## Clip
A Clip model will be created via deserialization of the Modules JSON response. Multiple Clip models can be included in the JSON response but the properties for each Clip will remain the same.

### Clip Properties
|Property |Description|
|:-------:|-----------|
|Transcripts|Transcripts have not been completed yet. They may require a higher level PluralSight subscription.|
|ClipIndex|The index the clip is in the PluralSight Course's Module.|
|Title|The title of the clip.|
|HasBeenViewed|Determines whether the clip has been viewed.|
|Duration|The duration of the clip.|
|PlayerParameters|The clip's player parameters passed to the PluralSight video player.|
|UserMayViewClip|Indicates whether the clip can be watched by the user.|
|ClickActionDescription|The description displayed to the user when a clip can be launched in the PluralSight video player.|
|IsHighlighted|Indicates whether the clip is highlighted. This value is set when the user searches for a value that would highlight the clip.|
|Name|The internal PluralSight name of the clip.|
|IsBookmarked|Indicates whether the clip has been bookmarked by the user.|
|HasBeenViewedImageUrl|The image URL used to display an image when the clip has been viewed by the user already.|
|HasBeenViewedAltText|The text displayed in the alt tag when the clip has been viewed by the user already.|

### Clip Sample JSON
```json
{
    "transcripts":[

    ],
    "clipIndex":0,
    "title":"Module Introduction",
    "hasBeenViewed":true,
    "duration":"00:00:57",
    "playerParameters":"author=mark-heath&name=windows-forms-best-practices-m1&mode=live&clip=0&course=windows-forms-best-practices",
    "userMayViewClip":false,
    "clickActionDescription":"View with player",
    "isHighlighted":false,
    "name":"windows-forms-best-practices-m1-01",
    "isBookmarked":false,
    "hasBeenViewedImageUrl":"cs/has-been-viewed-checkmark-15-v1.png",
    "hasBeenViewedAltText":"You have watched this Clip."
}
```

## Course
A Course model will be created via deserialization. Only a single Course model should be contained in the JSON response.

### Course Properties
|Property |Description|
|:-------:|-----------|
|Title|The title of the course.|
|Level|The [Course Level](#course-level) for the Course.|
|Duration|The recorded length of the Course.|
|ReleaseDate|The date the Course was released.|
|Name|The internal PluralSight name of the course.|
|Authors|The [Author(s)](#author) for the Course.|
|HasTranscript|Indicates whether the Course has transcripts.|
|CourseRating|The [Course Rating](#course-rating) for the Course.|
|IsRetired|Indicates whether the Course has been retired.|
|ShortDescription|The short description of the course.|
|Description|The description of the course.|
|IsBookmarked|Indicates whether the user has bookmarked the course.|
|UserMaySaveCourse|Indicates whether the user may save the course.|
|ReplacementCourseName|The internal PluralSight Course name for the replacement Course if the Course has been retired.|
|RetiredReason|The reason the Course has been retired.|
|ReplacementCourseTitle|The Course title for the replacement Course if the Course has been retired.|
|IsValid|Indicates whether the Course is valid.|
|IsUserAuthorizedForTranscript|Indicates whether the User is authorized for transcripts for the Course.|

### Course Sample JSON
```json
{
    "title":"Windows Forms Best Practices",
    "level":"Intermediate",
    "duration":"04:35:57",
    "releaseDate":"2014-09-27T00:00:00Z",
    "name":"windows-forms-best-practices",
    "authors":[
    ],
    "hasTranscript":true,
    "courseRating":{

    },
    "isRetired":false,
    "shortDescription":"This course demonstrates several best practices for Windows Forms application development by gradually improving a demo application. Topics covered include resizing, layout, accessibility, maintainable code, localization, usability, testability, threading, exception handling, custom control creation, and interoperability.",
    "description":"This course demonstrates several best practices for Windows Forms development by taking a demo application and gradually improving it to improve the user experience and code quality. We'll see how you can improve the layout and resizing of your application, and how you can make it more accessible, usable, and navigable from the keyboard. We'll explore how to approach localization, exception handling, and threading. We'll also devote time to various patterns that will help you write more maintainable and testable code. Finally, we'll provide guidelines for creating your own custom controls, and see how you can interoperate other technologies such as hosting web and WPF content within a Windows Forms application.",
    "isBookmarked":false,
    "userMaySaveCourse":true,
    "replacementCourseName":"",
    "retiredReason":"",
    "replacementCourseTitle":"",
    "isValid":true,
    "isUserAuthorizedForTranscript":false
}
```

## Course Level
The Course Level enumeration will typically be used during the deserialization of the Course JSON response. It has three possible values of Beginner, Intermediate, and Advanced.

### Course Level Sample JSON
```json
{
    "level":"Intermediate"
}
```

## Course Rating
A Course Rating model will be created via deserialization of the Course JSON response. Only a single Course Rating should be contained in the Course JSON response.

### Course Rating Properties
|Property |Description|
|:-------:|-----------|
|CurrentUsersRating|The current user's rating for the course.|
|AverageRating|The average rating for the course.|
|Rating|The rating for the course.|
|CanRateThisCourse|Indicates whether the user can rate the course.|
|CourseName|The course name this rating is associated with.|
|NumberOfRaters|The number of users that have rated the course.|
|HasUserRatedCourse|Indicates whether the user has rated the course.|

### Course Rating JSON Sample
```json
{
    "currentUsersRating":0,
    "averageRating":4.6,
    "rating":4.6,
    "canRateThisCourse":false,
    "courseName":"windows-forms-best-practices",
    "numberOfRaters":290,
    "hasUserRatedCourse":false
}
```

## Copyright
CodeBlueDev.PluralSight.Core.Models is Copyright &copy; 2016 [CodeBlueDev](https://www.codebluedev.wordpress.com) and other contributors under the [MIT license](LICENSE).
