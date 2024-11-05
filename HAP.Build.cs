// Copyright 2023 CGVR (zach@cs.uni-bremen.de). All Rights Reserved.

using System.IO;
using System;
using UnrealBuildTool;

public class HAP : ModuleRules
{
    public HAP(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;

        PublicDefinitions.Add("_CRT_SECURE_NO_WARNINGS=1");
        bUseRTTI = true;
        bEnableExceptions = true;

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/audio"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/collisions"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/devices"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/display"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/effects"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/files"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/forces"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/graphics"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/lighting"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/materials"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/math"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/resources"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/shaders"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/system"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/timers"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/tools"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/widgets"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Chai/include/world"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "tdLeap/external/LeapSDK/include"));
        //PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "tdLeap/src"));

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "glew/include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Eigen/eigen3"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "virtuose/src"));

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            // Add the import library
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Chai/lib/Win64/chai3d.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "virtuose/lib/Win64/virtuoseDLL.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "virtuose/lib/Win64/virtuoseDLL_md.lib"));

            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "tdLeap/external/LeapSDK/lib/win-x64/Leap.lib"));

            // Ensure that the DLL is staged along with the executable
            RuntimeDependencies.Add("$(BinaryOutputDir)/hdPhantom64.dll", Path.Combine("$(ModuleDir)", "Chai/bin/Win64/hdPhantom64.dll"));
            RuntimeDependencies.Add("$(BinaryOutputDir)/virtuoseAPI.dll", Path.Combine("$(ModuleDir)", "virtuose/bin/Win64/virtuoseAPI.dll"));
            RuntimeDependencies.Add("$(BinaryOutputDir)/Leap.dll", Path.Combine("$(ModuleDir)", "tdLeap/external/LeapSDK/lib/win-x64/Leap.dll"));
        }

        else if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            // TODO
        }
        else if (Target.Platform == UnrealTargetPlatform.Linux)
        {
            // TODO
        }

    }
}