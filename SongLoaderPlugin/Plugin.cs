﻿using System;
using IllusionPlugin;
using UnityEngine;

namespace SongLoaderPlugin
{
	public class Plugin : IPlugin
	{
		public string Name
		{
			get { return "Song Loader Plugin"; }
		}

		public string Version
		{
			get { return "0.0.3"; }
		}
		
		public void OnApplicationStart()
		{
			
		}

		public void OnApplicationQuit()
		{
			PlayerPrefs.DeleteKey("lbPatched");
		}

		public void OnLevelWasLoaded(int level)
		{
			
		}

		public void OnLevelWasInitialized(int level) {
			if (level != SongLoader.MenuIndex) return;
			SongLoader.OnLoad();
			SongLoaderUI.OnLoad();
		}

		public void OnUpdate()
		{
			
		}

		public void OnFixedUpdate()
		{
			
		}
	}
}