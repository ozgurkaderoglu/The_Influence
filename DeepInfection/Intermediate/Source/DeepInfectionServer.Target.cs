using UnrealBuildTool;

public class DeepInfectionServerTarget : TargetRules
{
	public DeepInfectionServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DeepInfection");
	}
}
