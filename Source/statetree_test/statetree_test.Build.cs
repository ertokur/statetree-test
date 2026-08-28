// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class statetree_test : ModuleRules
{
	public statetree_test(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"statetree_test",
			"statetree_test/Variant_Combat",
			"statetree_test/Variant_Combat/AI",
			"statetree_test/Variant_Combat/Animation",
			"statetree_test/Variant_Combat/Gameplay",
			"statetree_test/Variant_Combat/Interfaces",
			"statetree_test/Variant_Combat/UI",
			"statetree_test/Variant_SideScrolling",
			"statetree_test/Variant_SideScrolling/AI",
			"statetree_test/Variant_SideScrolling/Gameplay",
			"statetree_test/Variant_SideScrolling/Interfaces",
			"statetree_test/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
