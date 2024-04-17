/**
*	This source code is part of ContrabandPolice_DevConsole project,
*	ContrabandPolice_DevConsole is a mod for Contraband Police which enables the game's built in DevConsole.
*
*	Project Repository:
*		https://github.com/TIRTAGT/ContrabandPolice_DevConsole
*
*	This project is open source and are released under the MIT License,
*	for more information, please read the LICENSE file in the project repository.
*
*	Copyright (c) 2024 Matthew Tirtawidjaja <matthew@tirtagt.xyz>
**/

using System.Reflection;
using System.Runtime.InteropServices;
using ContrabandPolice_DevConsole;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(Plugin.PLUGIN_NAME)]
[assembly: AssemblyDescription(Plugin.PLUGIN_NAME + " is a mod for Contraband Police which enables the game's built in DevConsole.")]
[assembly: AssemblyConfiguration(Plugin.PLUGIN_COMPILE_CONFIG)]
[assembly: AssemblyCompany("Matthew Tirtawidjaja")]
[assembly: AssemblyProduct(Plugin.PLUGIN_NAME)]
[assembly: AssemblyCopyright("Copyright © 2024 Matthew Tirtawidjaja")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(Plugin.PLUGIN_ASSEMBLY_VERSION)]
[assembly: AssemblyFileVersion(Plugin.PLUGIN_ASSEMBLY_VERSION)]
[assembly: AssemblyInformationalVersion(Plugin.PLUGIN_VERSION)]
[assembly: AssemblyTrademark("Matthew Tirtawidjaja")]