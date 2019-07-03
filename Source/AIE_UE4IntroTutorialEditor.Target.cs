

using UnrealBuildTool;
using System.Collections.Generic;

public class AIE_UE4IntroTutorialEditorTarget : TargetRules
{
	public AIE_UE4IntroTutorialEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AIE_UE4IntroTutorial" } );
	}
}
