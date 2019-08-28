# Re-str
```lua
&>
re-str(
   name: "Re-str"
   version: "1.0"
   releaseDate: "28.08.2019"
)

example(
   Test: "hello"
)
<
```

Usage:
```csharp
RestrFile restrFile = RestrFile.LoadFromFile("filePath");
string name = restFile.RestrObjects["re-str"].Aliases["name"];
```
