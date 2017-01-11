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

## Copyright
CodeBlueDev.PluralSight.Core.Models is Copyright &copy; 2016 [CodeBlueDev](https://www.codebluedev.wordpress.com) and other contributors under the [MIT license](LICENSE).
