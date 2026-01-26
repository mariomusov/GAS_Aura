// Your Grandma's Kite

using UnrealBuildTool;
using System.Collections.Generic;

public class auraEditorTarget : TargetRules
{
	public auraEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;

		ExtraModuleNames.AddRange( new string[] { "aura" } );
	}
}
