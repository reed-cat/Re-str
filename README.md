
```csharp
#region WRITE FILE ---------------------------------
RestrFile restrFile = new RestrFile();
RestrObject user1 = new RestrObject("user1");
user1.Aliases.Add("username", "Jack251");
user1.Aliases.Add("xpLevel", "15");
RestrObject user2 = new RestrObject("user2");
user2.Aliases.Add("username", "Yayo");
user2.Aliases.Add("xpLevel", "25");
restrFile.RestrObjects.Add(user1.Name, user1);
restrFile.RestrObjects.Add(user1.Name, user2);
restrFile.Save("example.rs");
#endregion

#region READ FILE ---------------------------------
RestrFile restr = RestrFile.LoadFromFile("filePath"); // or LoadFromURL
string name = restr.RestrObjects["re-str"].Aliases["name"];
#endregion
```
