﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("SqlClient")>]
[<assembly: AssemblyProductAttribute("FSharp.Data.SqlClient")>]
[<assembly: AssemblyDescriptionAttribute("SqlClient F# type providers")>]
[<assembly: AssemblyVersionAttribute("1.4.1")>]
[<assembly: AssemblyFileVersionAttribute("1.4.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.4.1"
