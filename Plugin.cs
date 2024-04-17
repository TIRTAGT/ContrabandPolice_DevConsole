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

using BepInEx;
using HarmonyLib;

namespace ContrabandPolice_DevConsole {
	[BepInPlugin(Plugin.PLUGIN_GUID, Plugin.PLUGIN_NAME, Plugin.PLUGIN_VERSION)]
	public class Plugin : BaseUnityPlugin
	{
		public const string PLUGIN_GUID = "TIRTAGT.ContrabandPolice_DevConsole";
		public const string PLUGIN_NAME = "ContrabandPolice_DevConsole";
		public const string PLUGIN_VERSION  = "1.0.0";
		public const string PLUGIN_ASSEMBLY_VERSION  = PLUGIN_VERSION + ".00000";
#if DEBUG
		public const string PLUGIN_COMPILE_CONFIG = "Debug";
#else
		public const string PLUGIN_COMPILE_CONFIG = "Release";
#endif
		private readonly Harmony HarmonyLib = new Harmony(PLUGIN_GUID);
		private static Plugin Instance;
		private static bool IsAlreadyAwake = false;

		public Plugin()
		{
			if (Plugin.Instance != null)
			{
				this.Logger.LogWarning($"{Plugin.PLUGIN_GUID} is already loaded.");
				return;
			}

			Plugin.Instance = this;
		}

		/// <summary>
		/// Called after the plugin/mod class is initialized on BepInEx (usually before the game starts)
		/// </summary>
		private void Awake()
		{
			if (IsAlreadyAwake)
			{
				this.Logger.LogWarning($"{Plugin.PLUGIN_GUID} is already woken up.");
				return;
			}
			IsAlreadyAwake = true;

			HarmonyLib.PatchAll(typeof(Patches.DevMode));

			this.Logger.LogInfo($"{Plugin.PLUGIN_NAME} is loaded");
		}

		/// <summary>
		/// Send a log to the exposed BepInEx Logging system
		/// </summary>
		/// <param name="level">The BepInEx LogLevel</param>
		/// <param name="data">The log data</param>
		public static void Log(BepInEx.Logging.LogLevel level, object data)
		{
			Plugin.Instance.Logger.Log(level, data);
		}
	}
}