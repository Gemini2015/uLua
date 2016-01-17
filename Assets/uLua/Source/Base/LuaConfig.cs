using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class LuaConfig {
    public const bool UsePbc = true;                           //PBC
    public const bool UseLpeg = true;                          //LPEG
    public const bool UsePbLua = true;                         //Protobuff-lua-gen
    public const bool UseCJson = true;                         //CJson
    public const bool UseSproto = true;                        //Sproto
    public const bool AutoWrapMode = true;                     //自动Wrap模式（自动写入Wrap.lua文件）

	// ReadOnly path
	/*
	 *  Application.dataPath
	 * 
	 * 	Unity Editor: <path to project folder>/Assets
	 * 	Mac player: <path to player app bundle>/Contents
	 * 	iOS player: <path to player app bundle>/<AppName.app>/Data (this folder is read only, use Application.persistentDataPath to save data).
	 * 	Win/Linux player: <path to executablename_Data folder> (note that most Linux installations will be case-sensitive!)
	 * 	Web player: The absolute url to the player data file folder (without the actual data file name)
	 * 	WebGL: The absolute url to the player data file folder (without the actual data file name)
	 * 	Android: Normally it would point directly to the APK. The exception is if you are running a split binary build in which case it points to the the OBB instead.
	 * 
	 */
    public static string uLuaPath {
        get {
            return Application.dataPath + "/uLua/";
        }
    }
}
