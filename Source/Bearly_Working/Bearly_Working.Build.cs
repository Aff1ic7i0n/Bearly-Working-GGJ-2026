// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Bearly_Working : ModuleRules
{
	public Bearly_Working(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Bearly_Working",
			"Bearly_Working/Variant_Strategy",
			"Bearly_Working/Variant_Strategy/UI",
			"Bearly_Working/Variant_TwinStick",
			"Bearly_Working/Variant_TwinStick/AI",
			"Bearly_Working/Variant_TwinStick/Gameplay",
			"Bearly_Working/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
