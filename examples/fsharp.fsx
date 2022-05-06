#I __SOURCE_DIRECTORY__
#r "../src/NavToType/bin/Debug/netstandard2.0/publish/NavToType.dll"

open NavToType

// implementation
let SomeFunction (_:int) = ""

// many miles away...

// 1. annotate an alias
// signature is NOT checked so be careful
type [<Nav(nameof SomeFunction)>] FuncSig = int -> string

let DoStuff (fs:FuncSig) = ()

// 2. annotate a parameter directly
let DoMoreStuff
    ([<Nav(nameof SomeFunction)>]fs) =
    ()
