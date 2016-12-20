$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\csharp\Windows\Facebook.Yoga\bin\Release\Facebook.Yoga.dll").GetName().Version
$versionStr = "{0}.{1}.{2}-pre" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\Facebook.Yoga.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\Facebook.Yoga.compiled.nuspec

& $root\NuGet\NuGet.exe pack $root\nuget\Facebook.Yoga.compiled.nuspec
