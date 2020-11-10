# todo

## publish razor pages

[publish-the-views-with-asp-net-core](https://stackoverflow.com/questions/46255990/publish-the-views-with-asp-net-core)

```xml 

<PropertyGroup>
	<TargetFramework>netcoreapp3.1</TargetFramework>
	<PreserveCompilationContext>true</PreserveCompilationContext>
	<RazorCompileOnPublish>false</RazorCompileOnPublish>
</PropertyGroup>

```