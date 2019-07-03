

using UnrealBuildTool;
using System.Collections.Generic;

public class AIE_UE4IntroTutorialTarget : TargetRules
{
	public AIE_UE4IntroTutorialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "AIE_UE4IntroTutorial" } );
	}
}
