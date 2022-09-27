# Recruit OpenAPI

This Project contains an Package for Umbraco, that creates a Partial View.


## Dependencies 



### Linux Users:
**.NET SDK 6+**: 

Linux:  https://docs.microsoft.com/en-us/dotnet/core/install/linux

Debian: https://docs.microsoft.com/en-us/dotnet/core/install/linux-debian

Ubuntu: https://docs.microsoft.com/en-us/dotnet/core/install/linux-ubuntu  

Check Debian / Ubuntu Version using this command:
	```
	lsb_release -a
	```


**Nuget**
```
	<update linux system>
	sudo apt-get update -y
	<install Nuget>
	sudo apt-get install -y nuget
	<Verification>
	nuget
```


### Windows Users:
Visual Studio -> .Net SDK. (Installed with the program)

### All: Umbraco Install

In CLI type: dotnet new -i Umbraco.Templates

## Control
	- Type "dotnet" into the CLI and check if SDK is installed.
	- Type "dotnet --list-sdks" to check the SDK version. 
	- Type "dotnet nuget --version" or "nuget --version" to check if Nuget is installed.

# Setup
## Clone the project
	```
	cd <Existing Repostiory>
	HTTPS:
	git clone https://gitlab.com/hr-on/recruit/recruit-umbraco-package.git
	SSH:
	git clone git@gitlab.com:hr-on/recruit/recruit-umbraco-package.git
	```

## Pack the project as an .nupkg file



### Using Visual Studio
	- Open the .csproj file in visual studio.
	- Right Click .csproj file
	- Press properties 
	- Press Package
	- Check -> Generate Nuget Package on Build is checked
	- Build Project
	- Check your bin/Debug folder to check if the .nupkg file is there

### Check if the project itself creates a .nupkg file
	```
	Run "Dotnet build inside the cloned folder" in a terminal
	Check if it succesfully created a .nupkg package for you
	Remember the location of the .nupkg file for later
	```

### Using Dotnet

	- cd the cloned repository
	- Type "dotnet pack"
	- Check your bin/Debug folder to check if the .nupkg file is there
	- Remember the location of the .nupkg file.

## Create an umbraco project from a template.
	- Cd out of the cloned repository
	- Open Commandprompt or some other terminal in a folder where you want it.
	- Type "dotnet new Umbraco -n {Name you want of the project}" 

## Add the Package as a Nuget Package source in your umbraco project

### Visual Studio
	- Go into your umbraco project with visual studio.
	- RightClick your .csproj file -> press manage nuget packages
	- Press the gear in the top right corner
	- Press the + icon to create a new Folder that nuget looks after.
	- Add the folder where the .nupkg file is as the source and a custom name as name of the new nuget source.
	- Press ok.
	- Change nuget source to your custom name.
	- Install the package from there.

### Using CLI
	- Use the following command, where the .nupkg files folder is the <PACKAGE_SOURCE_PATH>
	dotnet nuget add source <PACKAGE_SOURCE_PATH>

	- Add a reference to the package in your umbraco project .csproj near your other references	using following command
	
	<itemgroup>
		<PackageReference Include="HRONPackage" Version="<Version>" />
	</itemgroup>
	

### Others
 Change the Config file

	- Locate your file nuget.config

	Windows: %appdata%\NuGet\NuGet.Config
	Mac/Linux: ~/.config/NuGet/NuGet.Config
	
	- Open the file.
	- Add a new PackageSource using following

		<add key="{Custom Name}" value="{Folder with .nupkg file}" />

	- Open your umbraco project .csproj file
	- Add a reference to the package in your umbraco project .csproj near your other references	using following command

	<itemgroup>
		<PackageReference Include="HRONPackage" Version="<Version>" />
	</itemgroup>
	

## Control

 - Build your project using dotnet build in the cloned folder.
 - Check if you have a new Partial View under Views/Partial called HR-ON.cshtml
 - Run Your project with dotnet run in the folder with the Umbraco Project.
 - Check on your Umbraco site under Settings -> PartialViews, that you have a view called HR-ON.cshtml	

### SSH Users
	To View the newly run Umbraco site, use following command:
	```
		ssh -i {Path to your ssh key} -N -L {your local host port, you want to map}:{The SSH IP (FX: localhost:4404)} username@example.com
	```

## Congratulations
You have now install the Package


## Known Errors

### The repository '{Package} stretch Release' does no longer have a Release file.

Just run the sudo apt-get install instead. If you dont want to remove / update the file / program.


### Problems with Nuget - Note

There is generelly a problem with nuget in the way that there aren't a method to uninstall nuget packages.

Maybe create a script to create the file.



