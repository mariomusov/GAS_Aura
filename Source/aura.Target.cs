// Your Grandma's Kite

using UnrealBuildTool;
using System.Collections.Generic;

public class auraTarget : TargetRules
{
	public auraTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "aura" } );
	}
}
