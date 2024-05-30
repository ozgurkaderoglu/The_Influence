using UnrealBuildTool;

public class DeepInfectionClientTarget : TargetRules
{
	public DeepInfectionClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DeepInfection");
	}
}
