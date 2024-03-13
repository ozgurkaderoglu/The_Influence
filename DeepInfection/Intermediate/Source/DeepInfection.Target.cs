using UnrealBuildTool;

public class DeepInfectionTarget : TargetRules
{
	public DeepInfectionTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DeepInfection");
	}
}
