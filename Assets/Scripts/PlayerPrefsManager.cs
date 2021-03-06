﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

const string MASTER_VOLUME_KEY = "master_volume";
const string DIFFICULTY_KEY = "difficulty";
const string LEVEL_KEY = "level_unlocked_"; // e.g. level_unlucked_01

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master Volume out of range.");
		}
	}
	
	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	
	public static void UnlockLevel (int level) {
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // Use 1 for true, since we don't have bool in PlayerPrefs
		} else {
			Debug.LogError ("Trying to unlock level not in build order.");
		}
	}
	
	public static bool IsLevelUnlocked (int level) {
		if (level <= Application.levelCount - 1) {
			if (PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == 1) {
				return true;
			} else 
				return false;
		} else {
			Debug.LogError ("Trying to access level not in build order.");
			return false;
		}
	}

	public static void SetDifficulty (float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("Difficulty out of range.");
		}
	}
	
	public static float GetDifficulty () {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
	
}
