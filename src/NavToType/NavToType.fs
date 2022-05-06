module NavToType

open System

/// Annotate anything with type information that isn't obvious from usage.
[<AttributeUsage (AttributeTargets.All, AllowMultiple=true)>]
type Nav (typename:string, detail:string) =
    inherit Attribute ()
    let _ = typename, detail // prevents FS1182 warning

    new (typename:string) =
        Nav (typename, "")

    new (type':Type, detail:string) =
        Nav (type'.Name, detail)

    new (type':Type) =
        Nav (type', "")
