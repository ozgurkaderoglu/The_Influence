using UnrealBuildTool;

public class DeepInfectionEditorTarget : TargetRules
{
	public DeepInfectionEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DeepInfection");
	}
}
