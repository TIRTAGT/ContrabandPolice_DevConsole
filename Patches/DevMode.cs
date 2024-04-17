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

using HarmonyLib;

namespace ContrabandPolice_DevConsole.Patches {
	[HarmonyPatch(typeof(Manager))]
	public class DevMode {
		[HarmonyPatch("Awake")]
		[HarmonyPrefix]
		public static void Prefix_Awake() {
			Manager.devConsole = true;

			Plugin.Log(BepInEx.Logging.LogLevel.Info, "DevMode enabled by " + Plugin.PLUGIN_NAME);
		}
	}
}