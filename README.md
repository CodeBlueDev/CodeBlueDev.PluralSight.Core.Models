# CodeBlueDev.PluralSight.Core.Models
[![License](https://img.shields.io/github/license/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models.svg?label=License)](https://raw.githubusercontent.com/CodeBlueDev/CodeBlueDev.PluralSight.Core.Models/master/LICENSE)

A .NET library containing PluralSight domain models that can be utilized by other .NET projects.

## Contents
- [TODO](#todo)
- PluralSight Core Models
    - [Author](#author)
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


## Copyright
CodeBlueDev.PluralSight.Core.Models is Copyright &copy; 2016 [CodeBlueDev](https://www.codebluedev.wordpress.com) and other contributors under the [MIT license](LICENSE).
