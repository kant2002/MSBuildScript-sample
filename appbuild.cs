bool AfterSdkPublishRun = false;
bool _CheckForUnsupportedTargetFrameworkRun = false;
bool _CheckForUnsupportedTargetPlatformIdentifierRun = false;
bool _CollectTargetFrameworkForTelemetryRun = false;
bool _CheckForUnsupportedNETCoreVersionRun = false;
bool _CheckForUnsupportedCppNETCoreVersionRun = false;
bool _CheckForUnsupportedNETStandardVersionRun = false;
bool _CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun = false;
bool _CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersionRun = false;
bool _NormalizeTargetPlatformVersionRun = false;
bool _CheckForInvalidTargetPlatformVersionRun = false;
bool _CheckForUnsupportedArtifactsPathRun = false;
bool _CheckBrowserWorkloadNeededButNotAvailableRun = false;
bool _ErrorWorkloadDisabledForTFMLessThan6Run = false;
bool _ErrorDualWasmThreadPropsOn7Run = false;
bool _SuggestWasmWorkloadForBlazorRun = false;
bool GetSuggestedWorkloadsRun = false;
bool _CheckForMissingWorkloadRun = false;
bool _GetRequiredWorkloadsRun = false;
bool _CheckForUnsupportedAppHostUsageRun = false;
bool _CheckForUnsupportedHostingUsageRun = false;
bool _CheckAndUnsetUnsupportedPrefer32BitRun = false;
bool _CheckForMismatchingPlatformRun = false;
bool _CheckForLanguageAndFeatureCombinationSupportRun = false;
bool _CheckForNETCoreSdkIsPreviewRun = false;
bool AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItemsRun = false;
bool _CheckForEolTargetFrameworksRun = false;
bool _CheckForEolWorkloadsRun = false;
bool GenerateTargetPlatformDefineConstantsRun = false;
bool GenerateNETCompatibleDefineConstantsRun = false;
bool GeneratePlatformCompatibleDefineConstantsRun = false;
bool _DisableDiagnosticTracingRun = false;
bool AddImplicitDefineConstantsRun = false;
bool CreateManifestResourceNamesRun = false;
bool ResolveCodeAnalysisRuleSetRun = false;
bool XamlPreCompileRun = false;
bool ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssembliesRun = false;
bool _BeforeVBCSCoreCompileRun = false;
bool _ComputeSkipAnalyzersRun = false;
bool _TouchLastBuildWithSkipAnalyzersRun = false;
bool GenerateMSBuildEditorConfigFileRun = false;
bool GenerateMSBuildEditorConfigFileShouldRunRun = false;
bool GenerateMSBuildEditorConfigFileCoreRun = false;
bool InitializeSourceRootMappedPathsRun = false;
bool _InitializeSourceRootMappedPathsFromSourceControlRun = false;
bool _SetPathMapFromSourceRootsRun = false;
bool CopyAdditionalFilesRun = false;
bool CreateCompilerGeneratedFilesOutputPathRun = false;
bool CoreCompileRun = false;
bool InitializeSourceControlInformationRun = false;
bool _AddOutputPathToGlobalPropertiesToRemoveRun = false;
bool _CheckForInvalidConfigurationAndPlatformRun = false;
bool BuildRun = false;
bool BeforeBuildRun = false;
bool AfterBuildRun = false;
bool CoreBuildRun = false;
bool RebuildRun = false;
bool BeforeRebuildRun = false;
bool AfterRebuildRun = false;
bool BuildGenerateSourcesRun = false;
bool BuildGenerateSourcesTraverseRun = false;
bool BuildCompileRun = false;
bool BuildCompileTraverseRun = false;
bool BuildLinkRun = false;
bool BuildLinkTraverseRun = false;
bool CopyRunEnvironmentFilesRun = false;
bool RunRun = false;
bool BuildOnlySettingsRun = false;
bool PrepareForBuildRun = false;
bool GetFrameworkPathsRun = false;
bool GetReferenceAssemblyPathsRun = false;
bool GetTargetFrameworkMonikerRun = false;
bool GetTargetFrameworkMonikerDisplayNameRun = false;
bool GetTargetFrameworkDirectoriesRun = false;
bool AssignLinkMetadataRun = false;
bool PreBuildEventRun = false;
bool UnmanagedUnregistrationRun = false;
bool GetTargetFrameworkVersionRun = false;
bool ResolveReferencesRun = false;
bool BeforeResolveReferencesRun = false;
bool AfterResolveReferencesRun = false;
bool IgnoreJavaScriptOutputAssemblyRun = false;
bool AssignProjectConfigurationRun = false;
bool _SplitProjectReferencesByFileExistenceRun = false;
bool _GetProjectReferencePlatformPropertiesRun = false;
bool _GetProjectReferenceTargetFrameworkPropertiesRun = false;
bool GetTargetFrameworksRun = false;
bool GetTargetFrameworksWithPlatformForSingleTargetFrameworkRun = false;
bool GetTargetFrameworkPropertiesRun = false;
bool PrepareProjectReferencesRun = false;
bool ResolveProjectReferencesRun = false;
bool ResolveProjectReferencesDesignTimeRun = false;
bool ExpandSDKReferencesDesignTimeRun = false;
bool GetTargetPathRun = false;
bool GetTargetPathWithTargetPlatformMonikerRun = false;
bool GetNativeManifestRun = false;
bool ResolveNativeReferencesRun = false;
bool ResolveAssemblyReferencesRun = false;
bool FindReferenceAssembliesForReferencesRun = false;
bool GenerateBindingRedirectsRun = false;
bool GenerateBindingRedirectsUpdateAppConfigRun = false;
bool GetInstalledSDKLocationsRun = false;
bool ResolveSDKReferencesRun = false;
bool ResolveSDKReferencesDesignTimeRun = false;
bool FindInvalidProjectReferencesRun = false;
bool GetReferenceTargetPlatformMonikersRun = false;
bool ExpandSDKReferencesRun = false;
bool ExportWindowsMDFileRun = false;
bool ResolveAssemblyReferencesDesignTimeRun = false;
bool DesignTimeResolveAssemblyReferencesRun = false;
bool ResolveComReferencesRun = false;
bool _GetAssembliesMetadataRun = false;
bool ResolveComReferencesDesignTimeRun = false;
bool ResolveFrameworkReferencesRun = false;
bool PrepareResourcesRun = false;
bool PrepareResourceNamesRun = false;
bool AssignTargetPathsRun = false;
bool GetItemTargetPathsRun = false;
bool SplitResourcesByCultureRun = false;
bool CreateCustomManifestResourceNamesRun = false;
bool ResGenRun = false;
bool BeforeResGenRun = false;
bool AfterResGenRun = false;
bool CoreResGenRun = false;
bool CompileLicxFilesRun = false;
bool ResolveKeySourceRun = false;
bool CompileRun = false;
bool _GenerateCompileInputsRun = false;
bool GenerateTargetFrameworkMonikerAttributeRun = false;
bool GenerateAdditionalSourcesRun = false;
bool BeforeCompileRun = false;
bool AfterCompileRun = false;
bool _TimeStampBeforeCompileRun = false;
bool _GenerateSuggestedBindingRedirectsCacheRun = false;
bool _GenerateCompileDependencyCacheRun = false;
bool _TimeStampAfterCompileRun = false;
bool _ComputeNonExistentFilePropertyRun = false;
bool GenerateSerializationAssembliesRun = false;
bool CreateSatelliteAssembliesRun = false;
bool _GenerateSatelliteAssemblyInputsRun = false;
bool GenerateSatelliteAssembliesRun = false;
bool ComputeIntermediateSatelliteAssembliesRun = false;
bool SetWin32ManifestPropertiesRun = false;
bool _SetExternalWin32ManifestPropertiesRun = false;
bool _SetEmbeddedWin32ManifestPropertiesRun = false;
bool _GenerateResolvedDeploymentManifestEntryPointRun = false;
bool GenerateManifestsRun = false;
bool GenerateApplicationManifestRun = false;
bool _DeploymentSetClickOnceVersionsRun = false;
bool _DeploymentGenerateLauncherRun = false;
bool _DeploymentComputeNativeManifestInfoRun = false;
bool _DeploymentComputeClickOnceManifestInfoRun = false;
bool _DeploymentGenerateTrustInfoRun = false;
bool GenerateDeploymentManifestRun = false;
bool PrepareForRunRun = false;
bool CopyFilesToOutputDirectoryRun = false;
bool _CopyFilesMarkedCopyLocalRun = false;
bool _CopySourceItemsToOutputDirectoryRun = false;
bool _PopulateCommonStateForGetCopyToOutputDirectoryItemsRun = false;
bool _GetCopyToOutputDirectoryItemsFromTransitiveProjectReferencesRun = false;
bool _GetCopyToOutputDirectoryItemsFromThisProjectRun = false;
bool GetCopyToOutputDirectoryItemsRun = false;
bool GetCopyToPublishDirectoryItemsRun = false;
bool _CopyOutOfDateSourceItemsToOutputDirectoryRun = false;
bool _CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun = false;
bool _CopyAppConfigFileRun = false;
bool _CopyManifestFilesRun = false;
bool _CheckForCompileOutputsRun = false;
bool _SGenCheckForOutputsRun = false;
bool UnmanagedRegistrationRun = false;
bool IncrementalCleanRun = false;
bool _CleanGetCurrentAndPriorFileWritesRun = false;
bool CleanRun = false;
bool BeforeCleanRun = false;
bool AfterCleanRun = false;
bool CleanReferencedProjectsRun = false;
bool CoreCleanRun = false;
bool _CleanRecordFileWritesRun = false;
bool CleanPublishFolderRun = false;
bool PostBuildEventRun = false;
bool PublishRun = false;
bool _DeploymentUnpublishableRun = false;
bool SetGenerateManifestsRun = false;
bool PublishOnlyRun = false;
bool BeforePublishRun = false;
bool AfterPublishRun = false;
bool PublishBuildRun = false;
bool _CopyFilesToPublishFolderRun = false;
bool _DeploymentGenerateBootstrapperRun = false;
bool _DeploymentSignClickOnceDeploymentRun = false;
bool AllProjectOutputGroupsRun = false;
bool BuiltProjectOutputGroupRun = false;
bool DebugSymbolsProjectOutputGroupRun = false;
bool DocumentationProjectOutputGroupRun = false;
bool SatelliteDllsProjectOutputGroupRun = false;
bool SourceFilesProjectOutputGroupRun = false;
bool GetCompileRun = false;
bool ContentFilesProjectOutputGroupRun = false;
bool SGenFilesOutputGroupRun = false;
bool GetResolvedSDKReferencesRun = false;
bool CollectReferencedNuGetPackagesRun = false;
bool GenerateSupportedTargetFrameworkAliasRun = false;
bool PriFilesOutputGroupRun = false;
bool SDKRedistOutputGroupRun = false;
bool AllProjectOutputGroupsDependenciesRun = false;
bool BuiltProjectOutputGroupDependenciesRun = false;
bool DebugSymbolsProjectOutputGroupDependenciesRun = false;
bool SatelliteDllsProjectOutputGroupDependenciesRun = false;
bool DocumentationProjectOutputGroupDependenciesRun = false;
bool SGenFilesOutputGroupDependenciesRun = false;
bool ReferenceCopyLocalPathsOutputGroupRun = false;
bool DesignerRuntimeImplementationProjectOutputGroupRun = false;
bool GetPotentialEditorConfigFilesRun = false;
bool CleanAppxPackageRun = false;
bool GetPackagingOutputsRun = false;
bool RestoreRun = false;
bool GenerateRestoreGraphFileRun = false;
bool CollectPackageReferencesRun = false;
bool CollectCentralPackageVersionsRun = false;
bool CollectPackageDownloadsRun = false;
bool CollectFrameworkReferencesRun = false;
bool _LoadRestoreGraphEntryPointsRun = false;
bool _FilterRestoreGraphProjectInputItemsRun = false;
bool _GenerateRestoreGraphRun = false;
bool _GenerateRestoreGraphProjectEntryRun = false;
bool _GenerateRestoreSpecsRun = false;
bool _GenerateDotnetCliToolReferenceSpecsRun = false;
bool _GetProjectJsonPathRun = false;
bool _GetRestoreProjectStyleRun = false;
bool EnableIntermediateOutputPathMismatchWarningRun = false;
bool _GetRestoreTargetFrameworksOutputRun = false;
bool _GetRestoreTargetFrameworksAsItemsRun = false;
bool _GetRestoreSettingsRun = false;
bool _GetRestoreSettingsCurrentProjectRun = false;
bool _GetRestoreSettingsAllFrameworksRun = false;
bool _GetRestoreSettingsPerFrameworkRun = false;
bool _GenerateRestoreProjectSpecRun = false;
bool _GenerateProjectRestoreGraphRun = false;
bool _GenerateRestoreDependenciesRun = false;
bool _GenerateProjectRestoreGraphAllFrameworksRun = false;
bool _GenerateProjectRestoreGraphCurrentProjectRun = false;
bool _GenerateProjectRestoreGraphPerFrameworkRun = false;
bool _GenerateRestoreProjectPathItemsCurrentProjectRun = false;
bool _GenerateRestoreProjectPathItemsPerFrameworkRun = false;
bool _GenerateRestoreProjectPathItemsRun = false;
bool _GenerateRestoreProjectPathItemsAllFrameworksRun = false;
bool _GenerateRestoreProjectPathWalkRun = false;
bool _GetAllRestoreProjectPathItemsRun = false;
bool _GetRestoreSettingsOverridesRun = false;
bool _GetRestorePackagesPathOverrideRun = false;
bool _GetRestoreRepositoryPathOverrideRun = false;
bool _GetRestoreSourcesOverrideRun = false;
bool _GetRestoreFallbackFoldersOverrideRun = false;
bool _GetRestoreTargetFrameworkOverrideRun = false;
bool _GetTargetFrameworkOverridesRun = false;
bool _IsProjectRestoreSupportedRun = false;
bool VSTestRun = false;
bool _VSTestMSBuildRun = false;
bool _VSTestConsoleRun = false;
bool ShowInfoMessageIfProjectHasNoIsTestProjectPropertyRun = false;
bool BuildProjectRun = false;
bool ShowMsbuildWithParameterRun = false;
bool ShowCallOfVSTestTaskWithParameterRun = false;
bool _SetTargetFrameworkMonikerAttributeRun = false;
bool ResolvePackageDependenciesForBuildRun = false;
bool RunResolvePackageDependenciesRun = false;
bool _ResolveCompilerVersionRun = false;
bool ResolvePackageAssetsRun = false;
bool ResolvePackageDependenciesDesignTimeRun = false;
bool CollectSDKReferencesDesignTimeRun = false;
bool CollectResolvedSDKReferencesDesignTimeRun = false;
bool RunProduceContentAssetsRun = false;
bool ResolveLockFileReferencesRun = false;
bool IncludeTransitiveProjectReferencesRun = false;
bool ResolveLockFileAnalyzersRun = false;
bool ResolveLockFileCopyLocalFilesRun = false;
bool EnsureNETCoreAppRuntimeRun = false;
bool UpdateAspNetToFrameworkReferenceRun = false;
bool ApplyImplicitVersionsRun = false;
bool CheckForImplicitPackageReferenceOverridesRun = false;
bool CheckForDuplicateItemsRun = false;
bool _CheckForTransitiveWindowsDesktopDependenciesRun = false;
bool WarnForExplicitVersionsRun = false;
bool _CheckForFailedSDKResolutionRun = false;
bool _WarnWhenUsingNET8AndVSPriorTo178Run = false;
bool _CheckForInvalidWindowsDesktopTargetingConfigurationRun = false;
bool _CheckForUnnecessaryWindowsDesktopSDKRun = false;
bool _VerifyPackReleaseConfigurationsRun = false;
bool AddWindowsSdkKnownFrameworkReferencesRun = false;
bool ProcessFrameworkReferencesRun = false;
bool AddTransitiveFrameworkReferencesRun = false;
bool ResolveTargetingPackAssetsRun = false;
bool ResolveOffByDefaultAnalyzersRun = false;
bool IncludeTargetingPackReferenceRun = false;
bool ResolveRuntimePackAssetsRun = false;
bool _GetUserSecretsAssemblyAttributeRun = false;
bool _ComputePackageReferencePublishRun = false;
bool _DefaultMicrosoftNETPlatformLibraryRun = false;
bool _AddMicrosoftNetCompilerToolsetFrameworkPackageRun = false;
bool _CheckForBuildWithNoBuildRun = false;
bool GenerateBuildDependencyFileRun = false;
bool _GenerateRuntimeConfigurationFilesInputCacheRun = false;
bool GenerateBuildRuntimeConfigurationFilesRun = false;
bool AddRuntimeConfigFileToBuiltProjectOutputGroupOutputRun = false;
bool AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun = false;
bool AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjectsRun = false;
bool _SdkBeforeCleanRun = false;
bool _SdkBeforeRebuildRun = false;
bool _CreateAppHostRun = false;
bool _ChooseAppHostRun = false;
bool _GetAppHostPathsRun = false;
bool _GenerateClsidMapRun = false;
bool _CreateComHostRun = false;
bool _GenerateRegFreeComManifestRun = false;
bool _GetComHostPathsRun = false;
bool _GetIjwHostPathsRun = false;
bool _ComputeNETCoreBuildOutputFilesRun = false;
bool _ComputeReferenceAssembliesRun = false;
bool _ComputeUserRuntimeAssembliesRun = false;
bool CoreGenerateSatelliteAssembliesRun = false;
bool _GetAssemblyInfoFromTemplateFileRun = false;
bool GetAllRuntimeIdentifiersRun = false;
bool _BlockWinMDsOnUnsupportedTFMsRun = false;
bool ValidateExecutableReferencesRun = false;
bool ValidateCommandLinePropertiesRun = false;
bool InitializeSourceControlInformationFromSourceControlManagerRun = false;
bool SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun = false;
bool _SourceLinkHasSingleProviderRun = false;
bool _InitializeSourceControlInformationFromSourceControlManagerRun = false;
bool SourceControlManagerPublishTranslatedUrlsRun = false;
bool _SetSourceLinkFilePathRun = false;
bool _SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun = false;
bool _InitializeSourceRootMappedPathsOptRun = false;
bool _GenerateSourceLinkFileRun = false;
bool GenerateSourceLinkFileRun = false;
bool _InitializeGitHubSourceLinkUrlRun = false;
bool TranslateGitHubUrlsInSourceControlInformationRun = false;
bool _InitializeGitLabSourceLinkUrlRun = false;
bool TranslateGitLabUrlsInSourceControlInformationRun = false;
bool _InitializeAzureReposGitSourceLinkUrlRun = false;
bool TranslateAzureReposGitUrlsInSourceControlInformationRun = false;
bool _InitializeBitbucketGitSourceLinkUrlRun = false;
bool TranslateBitbucketGitUrlsInSourceControlInformationRun = false;
bool _GenerateDesignerDepsFileRun = false;
bool _GenerateDesignerRuntimeConfigFileRun = false;
bool _GatherDesignerShadowCopyFilesRun = false;
bool GenerateAssemblyInfoRun = false;
bool AddSourceRevisionToInformationalVersionRun = false;
bool GetAssemblyAttributesRun = false;
bool CreateGeneratedAssemblyInfoInputsCacheFileRun = false;
bool CoreGenerateAssemblyInfoRun = false;
bool GetAssemblyVersionRun = false;
bool GenerateGlobalUsingsRun = false;
bool GenerateSupportedRuntimeRun = false;
bool _WriteAppConfigWithSupportedRuntimeRun = false;
bool ComposeStoreRun = false;
bool StoreWorkerMainRun = false;
bool StoreWorkerMapperRun = false;
bool StoreResolverRun = false;
bool StoreWorkerPerformWorkRun = false;
bool StoreFinalizerRun = false;
bool _CopyResolvedOptimizedFilesRun = false;
bool PrepareForComposeStoreRun = false;
bool PrepforRestoreForComposeStoreRun = false;
bool RestoreForComposeStoreRun = false;
bool ComputeAndCopyFilesToStoreDirectoryRun = false;
bool CopyFilesToStoreDirectoryRun = false;
bool _CopyResolvedUnOptimizedFilesRun = false;
bool _ComputeResolvedFilesToStoreTypesRun = false;
bool _SplitResolvedFilesRun = false;
bool _GetResolvedFilesToStoreRun = false;
bool ComputeFilesToStoreRun = false;
bool PrepRestoreForStoreProjectsRun = false;
bool PrepOptimizerRun = false;
bool _RunOptimizerRun = false;
bool RunCrossGenRun = false;
bool _InitializeBasicPropsRun = false;
bool _GetCrossgenPropsRun = false;
bool _SetupStageForCrossgenRun = false;
bool _RestoreCrossgenRun = false;
bool CreateReadyToRunImagesRun = false;
bool _PrepareForReadyToRunCompilationRun = false;
bool ResolveReadyToRunCompilersRun = false;
bool _CreateR2RImagesRun = false;
bool _CreateR2RSymbolsRun = false;
bool _CheckForObsoleteDotNetCliToolReferencesRun = false;
bool _ComputeToolPackInputsToProcessFrameworkReferencesRun = false;
bool _PublishBuildAlternativeRun = false;
bool _PublishNoBuildAlternativeRun = false;
bool _PreventProjectReferencesFromBuildingRun = false;
bool PrepareForPublishRun = false;
bool ComputeAndCopyFilesToPublishDirectoryRun = false;
bool CopyFilesToPublishDirectoryRun = false;
bool _IncrementalCleanPublishDirectoryRun = false;
bool _GetCurrentAndPriorPublishFileWritesRun = false;
bool _CopyResolvedFilesToPublishPreserveNewestRun = false;
bool _CopyResolvedFilesToPublishAlwaysRun = false;
bool _ComputeResolvedFilesToPublishTypesRun = false;
bool ComputeFilesToPublishRun = false;
bool ILLinkRun = false;
bool ComputeResolvedFilesToPublishListRun = false;
bool _ResolveCopyLocalAssetsForPublishRun = false;
bool _ParseTargetManifestFilesRun = false;
bool _FilterSatelliteResourcesForPublishRun = false;
bool _ComputeResolvedCopyLocalPublishAssetsRun = false;
bool _ComputeCopyToPublishDirectoryItemsRun = false;
bool DefaultCopyToPublishDirectoryMetadataRun = false;
bool _ComputeAssembliesToPostprocessOnPublishRun = false;
bool _ComputeManagedRuntimePackAssembliesRun = false;
bool _ComputeUseBuildDependencyFileRun = false;
bool _ComputeFilesToBundleRun = false;
bool PrepareForBundleRun = false;
bool _GenerateSingleFileBundleInputCacheRun = false;
bool GenerateSingleFileBundleRun = false;
bool _ComputeIntermediateDepsFilePathRun = false;
bool _GeneratePublishDependencyFileInputCacheRun = false;
bool GeneratePublishDependencyFileRun = false;
bool ComputeEmbeddedApphostPathsRun = false;
bool ComputeFilesCopiedToPublishDirRun = false;
bool PublishItemsOutputGroupRun = false;
bool RunResolvePublishAssembliesRun = false;
bool _CheckForLanguageAndPublishFeatureCombinationSupportRun = false;
bool PackToolRun = false;
bool _GenerateToolsSettingsFileInputCacheRun = false;
bool GenerateToolsSettingsFileFromBuildPropertyRun = false;
bool _PackToolValidationRun = false;
bool GenerateShimsAssetsRun = false;
bool _ComputeExpectedEmbeddedApphostPathsRun = false;
bool _GenerateShimInputCacheRun = false;
bool _PackProjectToolValidationRun = false;
bool ComputeDependencyFileCompilerOptionsRun = false;
bool ComputeRefAssembliesToPublishRun = false;
bool _CopyReferenceOnlyAssembliesForBuildRun = false;
bool _HandlePackageFileConflictsRun = false;
bool _HandlePackageFileConflictsForPublishRun = false;
bool _HandleFileConflictsForPublishRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun = false;
bool AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun = false;
bool _CodeAnalysisTreatWarningsAsErrorsRun = false;
bool _ReportUpgradeNetAnalyzersNuGetWarningRun = false;
bool CollectApiCompatInputsRun = false;
bool RunPackageValidationRun = false;
bool GetReferencesForApiCompatValidatePackageRun = false;
bool _GetReferencePathFromInnerProjectsRun = false;
bool _GetAbsoluteOutputPathsForPackRun = false;
bool _GetOutputItemsFromPackRun = false;
bool _GetTargetFrameworksOutputRun = false;
bool _PackAsBuildAfterTargetRun = false;
bool _CleanPackageFilesRun = false;
bool _CalculateInputsOutputsForPackRun = false;
bool PackRun = false;
bool _IntermediatePackRun = false;
bool GenerateNuspecRun = false;
bool _InitializeNuspecRepositoryInformationPropertiesRun = false;
bool _LoadPackInputItemsRun = false;
bool _GetProjectReferenceVersionsRun = false;
bool _GetProjectVersionRun = false;
bool _WalkEachTargetPerFrameworkRun = false;
bool _GetFrameworksWithSuppressedDependenciesRun = false;
bool _GetFrameworkAssemblyReferencesRun = false;
bool _GetBuildOutputFilesWithTfmRun = false;
bool _GetTfmSpecificContentForPackageRun = false;
bool _GetDebugSymbolsWithTfmRun = false;
bool _AddPriFileToPackBuildOutputRun = false;
bool _GetPackageFilesRun = false;
bool _ContainerVerifySDKVersionRun = false;
bool ComputeContainerBaseImageRun = false;
bool ComputeContainerConfigRun = false;
bool _CheckContainersPackageRun = false;
bool PublishContainerRun = false;
var OutputFile = "test.txt";
var _AfterSdkPublishDependsOn = "Publish";
var UsingMicrosoftNETSdk = "true";
var UsingNETSdkDefaults = "true";
var CustomAfterDirectoryBuildProps = ";C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\Sdk\\UseArtifactsOutputPath.props";
var ImportByWildcardBeforeMicrosoftCommonProps = "true";
var ImportByWildcardAfterMicrosoftCommonProps = "true";
var ImportUserLocationsByWildcardBeforeMicrosoftCommonProps = "true";
var ImportUserLocationsByWildcardAfterMicrosoftCommonProps = "true";
var ImportDirectoryBuildProps = "true";
var _DirectoryBuildPropsFile = "Directory.Build.props";
var _DirectoryBuildPropsBasePath = "";
var BaseIntermediateOutputPath = "obj\\";
var _InitialBaseIntermediateOutputPath = "obj\\";
var MSBuildProjectExtensionsPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\";
var ImportProjectExtensionProps = "true";
var _InitialMSBuildProjectExtensionsPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\";
var CustomBeforeMicrosoftCommonProps = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.Before.Microsoft.Common.props";
var CustomAfterMicrosoftCommonProps = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.After.Microsoft.Common.props";
var MicrosoftCommonPropsHasBeenImported = "true";
var WMSJSProject = "WJProject";
var WMSJSProjectDirectory = "JavaScript";
var MSBuildUseVisualStudioDirectoryLayout = "False";
var NuGetPropsFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\NuGet.props";
var ImportDirectoryPackagesProps = "true";
var _DirectoryPackagesPropsFile = "Directory.Packages.props";
var _DirectoryPackagesPropsBasePath = "";
var DisableLogTaskParameter_ConvertToAbsolutePath_Path = "true";
var DisableLogTaskParameter_FindUnderPath_OutOfPath = "true";
var DisableLogTaskParameter_RemoveDuplicates_Inputs = "true";
var DisableLogTaskParameterItemMetadata_ConvertToAbsolutePath_AbsolutePaths = "true";
var DisableLogTaskParameterItemMetadata_Copy_CopiedFiles = "true";
var DisableLogTaskParameterItemMetadata_Copy_DestinationFiles = "true";
var DisableLogTaskParameterItemMetadata_Copy_SourceFiles = "true";
var DisableLogTaskParameterItemMetadata_FindUnderPath_Files = "true";
var DisableLogTaskParameterItemMetadata_FindUnderPath_InPath = "true";
var DisableLogTaskParameterItemMetadata_GenerateResource_FilesWritten = "true";
var DisableLogTaskParameterItemMetadata_Hash_ItemsToHash = "true";
var DisableLogTaskParameterItemMetadata_RemoveDuplicates_Filtered = "true";
var DisableLogTaskParameterItemMetadata_WriteLinesToFile_Lines = "true";
var DisableHandlePackageFileConflicts = "true";
var Configurations = "Debug;Release";
var Platforms = "AnyCPU";
var Configuration = "Debug";
var Platform = "AnyCPU";
var PackRelease = "true";
var OutputType = "Exe";
var FileAlignment = "512";
var ErrorReport = "prompt";
var AssemblyName = "6 - targets";
var RootNamespace = "_6___targets";
var Deterministic = "true";
var DebugSymbols = "true";
var Optimize = "false";
var _PlatformWithoutConfigurationInference = "AnyCPU";
var AssemblySearchPaths = "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}";
var DebugType = "portable";
var ResolveNuGetPackages = "false";
var SkipImportNuGetProps = "true";
var SkipImportNuGetBuildTargets = "true";
var RestoreProjectStyle = "PackageReference";
var DesignTimeAssemblySearchPaths = "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}";
var AllowUnsafeBlocks = "false";
var TreatWarningsAsErrors = "false";
var Prefer32Bit = "false";
var SignAssembly = "false";
var DelaySign = "";
var GeneratePackageOnBuild = "false";
var PackageRequireLicenseAcceptance = "false";
var CheckForOverflowUnderflow = "false";
var AutomaticallyUseReferenceAssemblyPackages = "true";
var MicrosoftNETFrameworkReferenceAssembliesLatestPackageVersion = "1.0.3";
var CopyConflictingTransitiveContent = "false";
var MSBuildCopyContentTransitively = "true";
var ResolveAssemblyReferenceOutputUnresolvedAssemblyConflicts = "true";
var ToolDepsJsonGeneratorProject = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\GenerateDeps\\GenerateDeps.proj";
var NETCoreSdkBundledVersionsProps = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\..\\..\\Microsoft.NETCoreSdk.BundledVersions.props";
var NetCoreRoot = "C:\\Program Files\\dotnet\\";
var NetCoreTargetingPackRoot = "C:\\Program Files\\dotnet\\packs";
var _NetFrameworkHostedCompilersVersion = "4.9.0-3.23621.4";
var NETCoreAppMaximumVersion = "8.0";
var BundledNETCoreAppTargetFrameworkVersion = "8.0";
var BundledNETCoreAppPackageVersion = "8.0.0";
var BundledNETStandardTargetFrameworkVersion = "2.1";
var BundledNETStandardPackageVersion = "2.1.0";
var BundledNETCorePlatformsPackageVersion = "8.0.0-rtm.23531.3";
var BundledRuntimeIdentifierGraphFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\RuntimeIdentifierGraph.json";
var NETCoreSdkVersion = "8.0.200-preview.23624.5";
var NETCoreSdkRuntimeIdentifier = "win-x64";
var NETCoreSdkPortableRuntimeIdentifier = "win-x64";
var _NETCoreSdkIsPreview = "true";
var EnableWebSdkImplicitPackageVersions = "false";
var __WindowsAppSdkDefaultImageIncludes = "**/*.png;**/*.bmp;**/*.jpg;**/*.dds;**/*.tif;**/*.tga;**/*.gif";
var __DisableWorkloadResolverSentinelPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\DisableWorkloadResolver.sentinel";
var MSBuildEnableWorkloadResolver = "true";
var UnsupportedTargetFrameworkVersion = "9.0";
var MinimumVisualStudioVersionForUnsupportedTargetFrameworkVersion = "17.8";
var _SourceLinkPropsImported = "true";
var MicrosoftBuildTasksGitAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.Build.Tasks.Git\\build\\..\\tools\\core\\Microsoft.Build.Tasks.Git.dll";
var _MicrosoftSourceLinkCommonAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.SourceLink.Common\\build\\..\\tools\\core\\Microsoft.SourceLink.Common.dll";
var EnableSourceControlManagerQueries = "true";
var EnableSourceLink = "true";
var NoWarn = "1701;1702";
var WarningsAsErrors = ";NU1605;SYSLIB0011";
var DefineConstants = "TRACE;DEBUG;NET;NET8_0;NETCOREAPP";
var TargetsForTfmSpecificContentInPackage = ";PackTool;_PackProjectToolValidation";
var MicrosoftNETWindowsWorkloadInstalled = "true";
var _TargetFrameworkVersionValue = "0.0";
var _WindowsDesktopSdkTargetFrameworkVersionFloor = "3.0";
var TargetFramework = "net8.0";
var ImplicitUsings = "enable";
var Nullable = "enable";
var _IsExecutable = "true";
var HasRuntimeOutput = "true";
var _UsingDefaultForHasRuntimeOutput = "true";
var VersionPrefix = "1.0.0";
var Version = "1.0.0";
var Authors = "6 - targets";
var Company = "6 - targets";
var AssemblyTitle = "6 - targets";
var Product = "6 - targets";
var PlatformName = "AnyCPU";
var PublishProfileImported = "false";
var _PublishProfileDesignerFolder = "Properties";
var _PublishProfileRootFolder = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\Properties\\PublishProfiles\\";
var TargetFrameworkIdentifier = ".NETCoreApp";
var TargetFrameworkVersion = "v8.0";
var _TargetFrameworkVersionWithoutV = "8.0";
var TargetPlatformIdentifier = "";
var TargetPlatformVersion = "";
var _EnableDefaultWindowsPlatform = "false";
var UseOSWinMdReferences = "false";
var ProduceReferenceAssembly = "true";
var AppendTargetFrameworkToOutputPath = "true";
var AppendPlatformToOutputPath = "false";
var _DefaultArtifactsPathPropsImported = "true";
var BaseOutputPath = "bin\\";
var OutputPath = "bin\\Debug\\net8.0\\";
var IntermediateOutputPath = "obj\\Debug\\net8.0\\";
var PackageOutputPath = "bin\\Debug\\";
var DefaultItemExcludes = ";bin\\Debug\\/**;obj\\Debug\\/**;bin\\/**;obj\\/**;**/*.user;**/*.*proj;**/*.sln;**/*.vssscc;**/.DS_Store";
var ImportFrameworkWinFXTargets = "false";
var _RuntimePackInWorkloadVersionCurrent = "8.0.1";
var _RuntimePackInWorkloadVersion7 = "7.0.15";
var _RuntimePackInWorkloadVersion6 = "6.0.26";
var TargetsNet8 = "true";
var TargetsCurrent = "true";
var _UsingDefaultPlatformTarget = "true";
var SelfContained = "false";
var _RuntimeIdentifierUsesAppHost = "true";
var UseAppHost = "true";
var DefaultAppHostRuntimeIdentifier = "win-x64";
var AppendRuntimeIdentifierToOutputPath = "true";
var CheckEolTargetFramework = "true";
var CheckEolWorkloads = "true";
var _MinimumNonEolSupportedNetCoreTargetFramework = "net6.0";
var _IsNETCoreOrNETStandard = "true";
var DesignTimeAutoUnify = "true";
var AutoUnifyAssemblyReferences = "true";
var GenerateDependencyFile = "true";
var IncludeFileVersionsInDependencyFile = "true";
var TargetExt = ".dll";
var EnableFrameworkPathOverride = "false";
var PublishDirName = "publish";
var PublishDir = "bin\\Debug\\net8.0\\publish\\";
var _NugetFallbackFolder = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\..\\..\\..\\NuGetFallbackFolder";
var _WorkloadLibraryPacksFolder = "C:\\Program Files\\dotnet\\library-packs";
var RestoreAdditionalProjectFallbackFolders = ";C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\..\\..\\..\\NuGetFallbackFolder";
var AddAdditionalExplicitAssemblyReferences = "false";
var AssetTargetFallback = ";net461;net462;net47;net471;net472;net48;net481";
var _FrameworkIdentifierForImplicitDefine = "NET";
var VersionlessImplicitFrameworkDefine = "NET";
var _FrameworkVersionForImplicitDefine = "8_0";
var ImplicitFrameworkDefine = "NET8_0";
var BackwardsCompatFrameworkDefine = "NETCOREAPP";
var GenerateDocumentationFile = "false";
var DocumentationFile = "";
var PublishDocumentationFiles = "true";
var PublishDocumentationFile = "true";
var PublishReferencesDocumentationFiles = "true";
var IsNetCoreAppTargetingLatestTFM = "true";
var LanguageTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft.CSharp.targets";
var CSharpTargetsPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft.CSharp.CurrentVersion.targets";
var ImportByWildcardBeforeMicrosoftCSharpTargets = "true";
var ImportByWildcardAfterMicrosoftCSharpTargets = "true";
var ImportUserLocationsByWildcardBeforeMicrosoftCSharpTargets = "true";
var ImportUserLocationsByWildcardAfterMicrosoftCSharpTargets = "true";
var CustomBeforeMicrosoftCSharpTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.Before.Microsoft.CSharp.targets";
var CustomAfterMicrosoftCSharpTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.After.Microsoft.CSharp.targets";
var DefaultLanguageSourceExtension = ".cs";
var Language = "C#";
var TargetRuntime = "Managed";
var AlwaysUseNumericalSuffixInItemNames = "true";
var DefineCommonItemSchemas = "true";
var DefineCommonReferenceSchemas = "true";
var DefineCommonCapabilities = "true";
var DefaultProjectTypeGuid = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
var AppDesignerFolder = "Properties";
var CreateManifestResourceNamesDependsOn = "";
var UseHostCompilerIfAvailable = "true";
var CoreCompileDependsOn = ";_ComputeNonExistentFileProperty;ResolveCodeAnalysisRuleSet";
var CSharpCoreTargetsPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Roslyn\\Microsoft.CSharp.Core.targets";
var CompilerApiVersion = "roslyn4.9";
var SourceRootMappedPathsFeatureSupported = "true";
var EmitCompilerGeneratedFiles = "false";
var CompilerGeneratedFilesOutputPath = "";
var _MaxSupportedLangVersion = "12.0";
var MaxSupportedLangVersion = "12.0";
var LangVersion = "12.0";
var CommandLineArgsForDesignTimeEvaluation = "-langversion:12.0 -define:TRACE";
var CSharpDesignTimeTargetsPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\VisualStudio\\Managed\\Microsoft.CSharp.DesignTime.targets";
var CommonTargetsPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft.Common.CurrentVersion.targets";
var ImportByWildcardBeforeMicrosoftCommonTargets = "true";
var ImportByWildcardAfterMicrosoftCommonTargets = "true";
var ImportUserLocationsByWildcardBeforeMicrosoftCommonTargets = "true";
var ImportUserLocationsByWildcardAfterMicrosoftCommonTargets = "true";
var CustomBeforeMicrosoftCommonTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.Before.Microsoft.Common.targets";
var CustomAfterMicrosoftCommonTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vCurrent\\Custom.After.Microsoft.Common.targets";
var ReportingServicesTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\VisualStudio\\v17.0\\ReportingServices\\Microsoft.ReportingServices.targets";
var AvailablePlatforms = "Any CPU,x86,x64,ARM32,ARM64";
var TargetFrameworkSDKToolsDirectory = "";
var HighEntropyVA = "true";
var GenerateFullPaths = "true";
var YieldDuringToolExecution = "true";
var TargetFrameworkMoniker = ".NETCoreApp,Version=v8.0";
var TargetPlatformSdkPath = "";
var TargetPlatformDisplayName = " ";
var _OriginalPlatform = "AnyCPU";
var _OriginalConfiguration = "Debug";
var BaseOutputPathWasSpecified = "true";
var ConfigurationName = "Debug";
var _DebugSymbolsProduced = "true";
var _DocumentationFileProduced = "false";
var OutDir = "bin\\Debug\\net8.0\\";
var ProjectName = "6 - targets";
var TargetName = "6 - targets";
var ProjectFileName = "6 - targets.csproj";
var ProjectExt = ".csproj";
var TargetFileName = "6 - targets.dll";
var _DeploymentPublishableProjectDefault = "true";
var PublishableProject = "true";
var _DeploymentTargetApplicationManifestFileName = "6 - targets.dll.manifest";
var TargetDeployManifestFileName = "6 - targets.application";
var GenerateClickOnceManifests = "";
var _DeploymentApplicationManifestIdentity = "6 - targets.exe";
var _DeploymentDeployManifestIdentity = "6 - targets.application";
var _DeploymentFileMappingExtension = "";
var _DeploymentBuiltUpdateInterval = "0";
var _DeploymentBuiltUpdateIntervalUnits = "Days";
var _DeploymentLauncherBased = "true";
var MaxTargetPath = "100";
var TargetCulture = "*";
var TargetDir = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\";
var TargetPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll";
var TargetRefPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\ref\\6 - targets.dll";
var ProjectDir = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\";
var ProjectPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj";
var DevEnvDir = "*Undefined*";
var SolutionName = "*Undefined*";
var SolutionFileName = "*Undefined*";
var SolutionPath = "*Undefined*";
var SolutionDir = "*Undefined*";
var SolutionExt = "*Undefined*";
var GenerateBindingRedirectsOutputType = "true";
var CleanFile = "6 - targets.csproj.FileListAbsolute.txt";
var BuildProjectReferences = "true";
var BuildInParallel = "true";
var _ResolveReferenceDependencies = "false";
var _GetChildProjectCopyToOutputDirectoryItems = "true";
var OverwriteReadOnlyFiles = "false";
var ComReferenceNoClassMembers = "false";
var _GenerateBindingRedirectsIntermediateAppConfig = "obj\\Debug\\net8.0\\6 - targets.dll.config";
var MSBuildCopyMarkerName = "6 - targ.C1F7A3EE.Up2Date";
var _DeploymentUrl = "";
var ClickOncePublishDir = "bin\\Debug\\net8.0\\publish\\";
var ProcessorArchitecture = "msil";
var ConsiderPlatformAsProcessorArchitecture = "true";
var ProcessorArchitectureAsPlatform = "AnyCPU";
var ProjectFlavor = "Client";
var WebReference_EnableProperties = "true";
var WebReference_EnableSQLTypes = "true";
var WebReference_EnableLegacyEventingModel = "false";
var AssemblyFoldersSuffix = "AssemblyFoldersEx";
var FrameworkRegistryBase = "Software\\Microsoft\\.NETCoreApp";
var TargetPlatformRegistryBase = "Software\\Microsoft\\Microsoft SDKs\\";
var AssemblyFoldersConfigFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\AssemblyFolders.config";
var AllowedReferenceAssemblyFileExtensions = """
      .winmd;
      .dll;
      .exe
    """;
var AllowedReferenceRelatedFileExtensions = """
      .pdb;
      .xml;
      .pri;
      .dll.config;
      .exe.config
    """;
var FullReferenceAssemblyNames = "Full";
var ContinueOnError = "false";
var MSBuildWarningsAsMessages = "1701;1702";
var MSBuildWarningsAsErrors = ";NU1605";
var MSBuildWarningsNotAsErrors = "";
var CommonXamlResourcesDirectory = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\\\";
var SourceControlInformationFeatureSupported = "true";
var BuildDependsOn = """
      BeforeBuild;
      CoreBuild;
      AfterBuild
    """;
var CoreBuildDependsOn = """
      _CheckForBuildWithNoBuild;
      
      BuildOnlySettings;
      PrepareForBuild;
      PreBuildEvent;
      ResolveReferences;
      PrepareResources;
      ResolveKeySource;
      Compile;
      ExportWindowsMDFile;
      UnmanagedUnregistration;
      GenerateSerializationAssemblies;
      CreateSatelliteAssemblies;
      GenerateManifests;
      GetTargetPath;
      PrepareForRun;
      UnmanagedRegistration;
      IncrementalClean;
      PostBuildEvent
    ;
      GenerateBuildDependencyFile;
      GenerateBuildRuntimeConfigurationFiles
    """;
var _ProjectDefaultTargets = "Build";
var RebuildDependsOn = """
      _SdkBeforeRebuild;
      
      BeforeRebuild;
      Clean;
      Build;
      AfterRebuild;
    
    """;
var BuildGenerateSourcesAction = "Build";
var BuildCompileAction = "Build";
var BuildLinkAction = "Build";
var RunDependsOn = "";
var BuildingProject = "false";
var PrepareForBuildDependsOn = ";GetFrameworkPaths;GetReferenceAssemblyPaths;AssignLinkMetadata";
var Framework40Dir = "@(_TargetFramework40DirectoryItem)";
var Framework35Dir = "@(_TargetFramework35DirectoryItem)";
var Framework30Dir = "@(_TargetFramework30DirectoryItem)";
var Framework20Dir = "@(_TargetFramework20DirectoryItem)";
var FrameworkDir = "@(_TargetFramework40DirectoryItem)";
var TargetedFrameworkDir = "@(_TargetedFrameworkDirectoryItem)";
var FrameworkSDKDir = "@(_TargetFrameworkSDKDirectoryItem)";
var GetFrameworkPathsDependsOn = "";
var PreBuildEventDependsOn = "";
var UnmanagedUnregistrationDependsOn = "";
var ResolveReferencesDependsOn = """
      BeforeResolveReferences;
      AssignProjectConfiguration;
      ResolveProjectReferences;
      FindInvalidProjectReferences;
      ResolveNativeReferences;
      ResolveAssemblyReferences;
      GenerateBindingRedirects;
      GenerateBindingRedirectsUpdateAppConfig;
      ResolveComReferences;
      AfterResolveReferences
    """;
var UseDefaultPlatformLookupTables = "true";
var PrepareProjectReferencesDependsOn = """
      AssignProjectConfiguration;
      _SplitProjectReferencesByFileExistence;
      _GetProjectReferenceTargetFrameworkProperties;
      _GetProjectReferencePlatformProperties
    """;
var GetTargetPathDependsOn = "";
var GetTargetPathWithTargetPlatformMonikerDependsOn = "";
var ResolveAssemblyReferencesDependsOn = """
      
      
      ResolveProjectReferences;
      FindInvalidProjectReferences;
      GetFrameworkPaths;
      GetReferenceAssemblyPaths;
      PrepareForBuild;
      ResolveSDKReferences;
      ExpandSDKReferences;
    ;
      ResolvePackageDependenciesForBuild;
      _HandlePackageFileConflicts;
    ;
      ResolveTargetingPackAssets;
    """;
var SDKReferenceRegistryRoot = "Software\\Microsoft\\Microsoft SDKs";
var SDKReferenceDirectoryRoot = "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs";
var ResolveSDKReferencesDependsOn = """
      GetInstalledSDKLocations
    """;
var TargetedSDKConfiguration = "Debug";
var TargetedSDKArchitecture = "msil";
var ShouldMarkCertainSDKReferencesAsRuntimeOnly = "true";
var FindInvalidProjectReferencesDependsOn = """
      GetReferenceTargetPlatformMonikers
    """;
var ExpandSDKReferencesDependsOn = """
      ResolveSDKReferences
    """;
var ExpandSDKAllowedReferenceExtensions = """
      .winmd;
      .dll
    """;
var ProjectDesignTimeAssemblyResolutionSearchPaths = """
      {CandidateAssemblyFiles};
      ;
      {HintPathFromItem};
      {TargetFrameworkDirectory};
      {Registry:Software\\Microsoft\\.NETCoreApp,v8.0,AssemblyFoldersEx};
      {RawFileName};
      D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\
    """;
var DesignTimeResolveAssemblyReferencesDependsOn = """
      GetFrameworkPaths;
      GetReferenceAssemblyPaths;
      ResolveReferences
    """;
var ComReferenceExecuteAsTool = "false";
var PrepareResourcesDependsOn = """
      ResolvePackageDependenciesForBuild;
      _HandlePackageFileConflicts;
      
      ;
      PrepareResourceNames;
      ResGen;
      CompileLicxFiles
    
    """;
var PrepareResourceNamesDependsOn = """
      AssignTargetPaths;
      SplitResourcesByCulture;
      CreateManifestResourceNames;
      CreateCustomManifestResourceNames
    """;
var AssignTargetPathsDependsOn = "";
var CreateCustomManifestResourceNamesDependsOn = "";
var ResGenDependsOn = "ResolveAssemblyReferences;SplitResourcesByCulture;BeforeResGen;CoreResGen;AfterResGen";
var CoreResGenDependsOn = "FindReferenceAssembliesForReferences";
var UseSourcePath = "true";
var ResGenExecuteAsTool = "false";
var CompileLicxFilesDependsOn = "";
var CompileDependsOn = """
      
      ResolveReferences;
      ResolveKeySource;
      SetWin32ManifestProperties;
      FindReferenceAssembliesForReferences;
      _GenerateCompileInputs;
      BeforeCompile;
      _TimeStampBeforeCompile;
      _GenerateCompileDependencyCache;
      CoreCompile;
      _TimeStampAfterCompile;
      AfterCompile;
    ;
      _CreateAppHost;
      _CreateComHost;
      _GetIjwHostPaths;
    """;
var TargetFrameworkMonikerAssemblyAttributesPath = "obj\\Debug\\net8.0\\.NETCoreApp,Version=v8.0.AssemblyAttributes.cs";
var GenerateTargetFrameworkAttribute = "true";
var _SGenDllName = "6 - targets.XmlSerializers.dll";
var _SGenDllCreated = "false";
var _SGenGenerateSerializationAssembliesConfig = "Off";
var SGenUseProxyTypes = "true";
var SGenUseKeep = "false";
var SGenShouldGenerateSerializer = "true";
var CreateSatelliteAssembliesDependsOn = """
      
      _GenerateSatelliteAssemblyInputs;
      ComputeIntermediateSatelliteAssemblies;
      GenerateSatelliteAssemblies
    ;
      CoreGenerateSatelliteAssemblies
    """;
var ComputeIntermediateSatelliteAssembliesDependsOn = """
      CreateManifestResourceNames
    """;
var EmbeddedWin32Manifest = "";
var GenerateManifestsDependsOn = """
      SetWin32ManifestProperties;
      GenerateApplicationManifest;
      GenerateDeploymentManifest
    """;
var SkipCopyUnchangedFiles = "true";
var UseCommonOutputDirectory = "false";
var PrepareForRunDependsOn = """
      CopyFilesToOutputDirectory
    """;
var CreateHardLinksForCopyAdditionalFilesIfPossible = "false";
var CreateSymbolicLinksForCopyAdditionalFilesIfPossible = "false";
var _TargetsThatPrepareProjectReferences = """
      AssignProjectConfiguration;
      _SplitProjectReferencesByFileExistence
    """;
var GetCopyToOutputDirectoryItemsDependsOn = """
      AssignTargetPaths;
      
      AssignProjectConfiguration;
      _SplitProjectReferencesByFileExistence
    ;
      _GetProjectReferenceTargetFrameworkProperties;
      _PopulateCommonStateForGetCopyToOutputDirectoryItems
    """;
var _RecursiveTargetForContentCopying = "GetCopyToOutputDirectoryItems";
var UnmanagedRegistrationDependsOn = "";
var CleanDependsOn = """
      BeforeClean;
      UnmanagedUnregistration;
      CoreClean;
      CleanReferencedProjects;
      CleanPublishFolder;
      AfterClean
    """;
var CoreCleanDependsOn = """
      _SdkBeforeClean;
      
    """;
var PostBuildEventDependsOn = "";
var DeploymentComputeClickOnceManifestInfoDependsOn = """
      CleanPublishFolder;
      GetCopyToOutputDirectoryItems;
      _DeploymentGenerateTrustInfo
      
    """;
var PublishDependsOn = """
      SetGenerateManifests;
      Build;
      PublishOnly
    """;
var PublishOnlyDependsOn = """
      SetGenerateManifests;
      PublishBuild;
      BeforePublish;
      GenerateManifests;
      CopyFilesToOutputDirectory;
      _CopyFilesToPublishFolder;
      _DeploymentGenerateBootstrapper;
      ResolveKeySource;
      _DeploymentSignClickOnceDeployment;
      AfterPublish
    """;
var PublishBuildDependsOn = """
      BuildOnlySettings;
      PrepareForBuild;
      ResolveReferences;
      PrepareResources;
      ResolveKeySource;
      GenerateSerializationAssemblies;
      CreateSatelliteAssemblies;
    """;
var BuiltProjectOutputGroupDependsOn = "PrepareForBuild";
var AddAppConfigToBuildOutputs = "true";
var DebugSymbolsProjectOutputGroupDependsOn = "";
var DocumentationProjectOutputGroupDependsOn = "";
var SatelliteDllsProjectOutputGroupDependsOn = ";PrepareForBuild;PrepareResourceNames";
var SourceFilesProjectOutputGroupDependsOn = "PrepareForBuild;AssignTargetPaths";
var ContentFilesProjectOutputGroupDependsOn = "PrepareForBuild;AssignTargetPaths";
var SGenFilesOutputGroupDependsOn = "";
var SDKRedistOutputGroupDependsOn = "ResolveSDKReferences;ExpandSDKReferences";
var CommonOutputGroupsDependsOn = """
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    """;
var BuiltProjectOutputGroupDependenciesDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var DebugSymbolsProjectOutputGroupDependenciesDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var SatelliteDllsProjectOutputGroupDependenciesDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var DocumentationProjectOutputGroupDependenciesDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var SGenFilesOutputGroupDependenciesDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var ReferenceCopyLocalPathsOutputGroupDependsOn = """
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    """;
var DesignerRuntimeImplementationProjectOutputGroupDependsOn = """
      
      ;
      
      ;
      BuildOnlySettings;
      PrepareForBuild;
      AssignTargetPaths;
      ResolveReferences
    
    ;
      _GenerateDesignerDepsFile;
      _GenerateDesignerRuntimeConfigFile;
      GetCopyToOutputDirectoryItems;
      _GatherDesignerShadowCopyFiles;
    """;
var CodeAnalysisTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\VisualStudio\\v17.0\\CodeAnalysis\\Microsoft.CodeAnalysis.targets";
var MsTestToolsTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\VisualStudio\\v17.0\\TeamTest\\Microsoft.TeamTest.targets";
var UseMSBuildTestInfrastructure = "false";
var MsAppxPackageTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\VisualStudio\\v17.0\\AppxPackage\\Microsoft.AppXPackage.Targets";
var NuGetRestoreTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\NuGet.targets";
var IsRestoreTargetsFileLoaded = "true";
var RestoreTaskAssemblyFile = "NuGet.Build.Tasks.dll";
var HideWarningsAndErrors = "false";
var RestoreRecursive = "true";
var RestoreUseSkipNonexistentTargets = "true";
var ValidateRuntimeIdentifierCompatibility = "false";
var RestoreContinueOnError = "WarnAndContinue";
var RestoreBuildInParallel = "true";
var NuGetInteractive = "";
var PackageDownloadSupported = "true";
var GetReferenceNearestTargetFrameworkTaskSupportsTargetPlatformParameter = "true";
var NuGetAudit = "true";
var NuGetAuditLevel = "low";
var NuGetAuditMode = "direct";
var _GenerateRestoreGraphProjectEntryInputProperties = "ExcludeRestorePackageImports=true";
var MicrosoftNETBuildExtensionsTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\Microsoft.NET.Build.Extensions\\Microsoft.NET.Build.Extensions.targets";
var MicrosoftNETBuildExtensionsTasksAssembly = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft\\Microsoft.NET.Build.Extensions\\\\tools\\net8.0\\Microsoft.NET.Build.Extensions.Tasks.dll";
var VSTestTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Microsoft.TestPlatform.targets";
var VSTestTaskAssemblyFile = "Microsoft.TestPlatform.Build.dll";
var VSTestConsolePath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll";
var VSTestNoBuild = "False";
var VsTestUseMSBuildOutput = "False";
var ImportProjectExtensionTargets = "true";
var ImportDirectoryBuildTargets = "true";
var _DirectoryBuildTargetsFile = "Directory.Build.targets";
var _DirectoryBuildTargetsBasePath = "";
var Utf8Output = "true";
var NoCompilerStandardLib = "true";
var InnerBuildProperty = "TargetFramework";
var InnerBuildPropertyValues = "TargetFrameworks";
var MicrosoftNETBuildTasksDirectoryRoot = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\tools\\";
var MicrosoftNETBuildTasksTFM = "net8.0";
var MicrosoftNETBuildTasksDirectory = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\tools\\net8.0\\";
var MicrosoftNETBuildTasksAssembly = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\tools\\net8.0\\Microsoft.NET.Build.Tasks.dll";
var DefaultImplicitPackages = "Microsoft.NETCore.App;NETStandard.Library";
var DotnetCliToolTargetFramework = "netcoreapp2.2";
var ProjectAssetsFile = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json";
var ProjectAssetsCacheFile = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.assets.cache";
var CopyLocalLockFileAssemblies = "true";
var ContentPreprocessorOutputDirectory = "obj\\Debug\\net8.0\\NuGet\\";
var NuGetTargetMoniker = ".NETCoreApp,Version=v8.0";
var EmitAssetsLogMessages = "true";
var EmitLegacyAssetsFileItems = "false";
var SupportsRoslynComponentVersioning = "true";
var _NugetTargetMonikerAndRID = ".NETCoreApp,Version=v8.0";
var MarkPackageReferencesAsExternallyResolved = "true";
var ResolvePackageDependenciesForBuildDependsOn = """
      ResolveLockFileReferences;
      ResolveLockFileAnalyzers;
      ResolveLockFileCopyLocalFiles;
      ResolveRuntimePackAssets;
      RunProduceContentAssets;
      IncludeTransitiveProjectReferences
    """;
var EnableDefaultItems = "true";
var EnableDefaultCompileItems = "true";
var EnableDefaultEmbeddedResourceItems = "true";
var EnableDefaultNoneItems = "true";
var DefaultExcludesInProjectFolder = ";;**/.*/**";
var TargetLatestRuntimePatch = "false";
var _TargetLatestRuntimePatchIsDefault = "true";
var VerifyMatchingImplicitPackageVersion = "true";
var PublishRelease = "true";
var DisableStandardFrameworkResolution = "true";
var GenerateRuntimeConfigurationFiles = "true";
var AlwaysIncludeCoreFrameworkInRuntimeConfig = "true";
var UserRuntimeConfig = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets/runtimeconfig.template.json";
var GenerateSatelliteAssembliesForCore = "true";
var ComputeNETCoreBuildOutputFiles = "true";
var _GenerateRuntimeConfigurationPropertyInputsCache = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genruntimeconfig.cache";
var _GeneratePublishDependencyFilePropertyInputsCache = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genpublishdeps.cache";
var _GenerateSingleFileBundlePropertyInputsCache = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genbundle.cache";
var UseRidGraph = "false";
var RuntimeIdentifierGraphPath = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json";
var GenerateRuntimeConfigDevFile = "false";
var ProjectDepsFileName = "6 - targets.deps.json";
var ProjectDepsFilePath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.deps.json";
var ProjectRuntimeConfigFileName = "6 - targets.runtimeconfig.json";
var ProjectRuntimeConfigFilePath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.runtimeconfig.json";
var IncludeMainProjectInDepsFile = "true";
var GenerateResourceMSBuildArchitecture = "CurrentArchitecture";
var GenerateResourceMSBuildRuntime = "CurrentRuntime";
var _NativeLibraryPrefix = "lib";
var _NativeLibraryExtension = ".so";
var _NativeExecutableExtension = ".exe";
var _ComHostLibraryExtension = ".dll";
var _IjwHostLibraryExtension = ".dll";
var _DotNetHostExecutableName = "dotnet.exe";
var _DotNetAppHostExecutableNameWithoutExtension = "apphost";
var _DotNetAppHostExecutableName = "apphost.exe";
var _DotNetSingleFileHostExecutableNameWithoutExtension = "singlefilehost";
var _DotNetComHostLibraryNameWithoutExtension = "comhost";
var _DotNetComHostLibraryName = "comhost.dll";
var _DotNetIjwHostLibraryNameWithoutExtension = "Ijwhost";
var _DotNetIjwHostLibraryName = "Ijwhost.dll";
var _DotNetHostPolicyLibraryName = "libhostpolicy.so";
var _DotNetHostFxrLibraryName = "libhostfxr.so";
var _DefaultUserProfileRuntimeStorePath = "C:\\Users\\kant\\.dotnet\\store";
var UserProfileRuntimeStorePath = "C:\\Users\\kant\\.dotnet\\store";
var GenerateResourceWarnOnBinaryFormatterUse = "true";
var IsRidAgnostic = "false";
var GenerateResourceUsePreserializedResources = "true";
var EmbeddedResourceUseDependentUponConvention = "true";
var IncludeProjectsNotInAssetsFileInDepsFile = "true";
var _BinaryFormatterObsoleteAsError = "true";
var EnableUnsafeBinaryFormatterSerialization = "false";
var RunWorkingDirectory = "";
var RunCommand = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.exe";
var RunArguments = "";
var _UseAttributeForTargetFrameworkInfoPropertyNames = "true";
var _SourceLinkSdkSubDir = "build";
var EmbedUntrackedSources = "true";
var _GenerateSourceLinkFileBeforeTargets = "CoreCompile";
var _GenerateSourceLinkFileDependsOnTargets = "";
var _SourceLinkGitHubAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.SourceLink.GitHub\\build\\..\\tools\\core\\Microsoft.SourceLink.GitHub.dll";
var SourceLinkUrlInitializerTargets = ";_InitializeGitHubSourceLinkUrl;_InitializeGitLabSourceLinkUrl;_InitializeAzureReposGitSourceLinkUrl;_InitializeBitbucketGitSourceLinkUrl";
var SourceControlManagerUrlTranslationTargets = ";TranslateGitHubUrlsInSourceControlInformation;TranslateGitLabUrlsInSourceControlInformation;TranslateAzureReposGitUrlsInSourceControlInformation;TranslateBitbucketGitUrlsInSourceControlInformation";
var _SourceLinkGitLabAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.SourceLink.GitLab\\build\\..\\tools\\core\\Microsoft.SourceLink.GitLab.dll";
var _SourceLinkAzureReposGitAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.SourceLink.AzureRepos.Git\\build\\..\\tools\\core\\Microsoft.SourceLink.AzureRepos.Git.dll";
var _SourceLinkBitbucketAssemblyFile = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.SourceLink.Bitbucket.Git\\build\\..\\tools\\core\\Microsoft.SourceLink.Bitbucket.Git.dll";
var TargetFrameworkMonikerDisplayName = ".NET 8.0";
var _TargetFrameworkDirectories = "";
var FrameworkPathOverride = "";
var TargetFrameworkDirectory = "";
var NoStdLib = "true";
var _DesignerDepsFileName = "6 - targets.designer.deps.json";
var _DesignerRuntimeConfigFileName = "6 - targets.designer.runtimeconfig.json";
var _DesignerDepsFilePath = "obj\\Debug\\net8.0\\6 - targets.designer.deps.json";
var _DesignerRuntimeConfigFilePath = "obj\\Debug\\net8.0\\6 - targets.designer.runtimeconfig.json";
var GeneratedAssemblyInfoFile = "obj\\Debug\\net8.0\\6 - targets.AssemblyInfo.cs";
var GenerateAssemblyInfo = "true";
var GenerateAssemblyCompanyAttribute = "true";
var GenerateAssemblyConfigurationAttribute = "true";
var GenerateAssemblyCopyrightAttribute = "true";
var GenerateAssemblyDescriptionAttribute = "true";
var GenerateAssemblyFileVersionAttribute = "true";
var GenerateAssemblyInformationalVersionAttribute = "true";
var GenerateAssemblyTrademarkAttribute = "true";
var GenerateAssemblyProductAttribute = "true";
var GenerateAssemblyTitleAttribute = "true";
var GenerateAssemblyVersionAttribute = "true";
var GenerateRepositoryUrlAttribute = "true";
var GenerateNeutralResourcesLanguageAttribute = "true";
var GenerateAssemblyMetadataAttributes = "true";
var IncludeSourceRevisionInInformationalVersion = "true";
var GenerateInternalsVisibleToAttributes = "true";
var GenerateRequiresPreviewFeaturesAttribute = "true";
var GenerateTargetPlatformAttribute = "true";
var GenerateSupportedOSPlatformAttribute = "true";
var GenerateDisableRuntimeMarshallingAttribute = "true";
var GeneratedGlobalUsingsFile = "obj\\Debug\\net8.0\\6 - targets.GlobalUsings.g.cs";
var _GenerateSupportedRuntimeIntermediateAppConfig = "obj\\Debug\\net8.0\\6 - targets.dll.withSupportedRuntime.config";
var PublishReadyToRunUseCrossgen2 = "true";
var PublishReadyToRunComposite = "false";
var PublishReadyToRunUseRuntimePackOptimizationData = "true";
var PublishReadyToRunPerfmapFormatVersion = "1";
var MicrosoftNETCrossgenBuildTasksAssembly = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\tasks\\net7.0\\Microsoft.NET.Sdk.Crossgen.dll";
var NETCoreSdkBundledCliToolsProps = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\..\\..\\Microsoft.NETCoreSdk.BundledCliTools.props";
var DefaultCopyToPublishDirectoryMetadata = "true";
var _GetChildProjectCopyToPublishDirectoryItems = "true";
var IsPublishable = "true";
var _BeforePublishNoBuildTargets = """
      BuildOnlySettings;
      _PreventProjectReferencesFromBuilding;
      ResolveReferences;
      PrepareResourceNames;
      ComputeIntermediateSatelliteAssemblies;
      ComputeEmbeddedApphostPaths;
    """;
var _CorePublishTargets = """
      PrepareForPublish;
      ComputeAndCopyFilesToPublishDirectory;
      ;
      PublishItemsOutputGroup;
    """;
var _PublishNoBuildAlternativeDependsOn = """
      BuildOnlySettings;
      _PreventProjectReferencesFromBuilding;
      ResolveReferences;
      PrepareResourceNames;
      ComputeIntermediateSatelliteAssemblies;
      ComputeEmbeddedApphostPaths;
    ;
      PrepareForPublish;
      ComputeAndCopyFilesToPublishDirectory;
      ;
      PublishItemsOutputGroup;
    """;
var CopyBuildOutputToPublishDirectory = "true";
var CopyOutputSymbolsToPublishDirectory = "true";
var IncludeSymbolsInSingleFile = "false";
var PublishItemsOutputGroupDependsOn = """
      ;
      ResolveReferences;
      ComputeResolvedFilesToPublishList;
      _ComputeFilesToBundle;
    """;
var _ToolsSettingsFilePath = "obj\\DotnetToolSettings.xml";
var _PackToolPublishDependency = "_PublishBuildAlternative";
var ToolCommandName = "6 - targets";
var ToolEntryPoint = "6 - targets.dll";
var _GenerateToolsSettingsFileCacheFile = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.toolssettingsinput.cache";
var _ShimInputCacheFile = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shiminput.cache";
var _ShimCreatedSentinelFile = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shimcreated.sentinel";
var PackagedShimOutputRootDirectory = "bin\\Debug\\net8.0\\";
var RefAssembliesFolderName = "refs";
var PreserveCompilationReferences = "";
var ImplicitConfigurationDefine = "DEBUG";
var _NoneAnalysisLevel = "4.0";
var _LatestAnalysisLevel = "8.0";
var _PreviewAnalysisLevel = "9.0";
var AnalysisLevel = "latest";
var EffectiveAnalysisLevel = "8.0";
var WarningLevel = "8";
var EnableNETAnalyzers = "true";
var EnforceCodeStyleInBuild = "false";
var _NETAnalyzersSDKAssemblyVersion = "8.0.0";
var CodeAnalysisRuleIds = "CA1000;CA1001;CA1002;CA1003;CA1005;CA1008;CA1010;CA1012;CA1014;CA1016;CA1017;CA1018;CA1019;CA1021;CA1024;CA1027;CA1028;CA1030;CA1031;CA1032;CA1033;CA1034;CA1036;CA1040;CA1041;CA1043;CA1044;CA1045;CA1046;CA1047;CA1050;CA1051;CA1052;CA1054;CA1055;CA1056;CA1058;CA1060;CA1061;CA1062;CA1063;CA1064;CA1065;CA1066;CA1067;CA1068;CA1069;CA1070;CA1200;CA1303;CA1304;CA1305;CA1307;CA1308;CA1309;CA1310;CA1311;CA1401;CA1416;CA1417;CA1418;CA1419;CA1420;CA1421;CA1422;CA1501;CA1502;CA1505;CA1506;CA1507;CA1508;CA1509;CA1510;CA1511;CA1512;CA1513;CA1700;CA1707;CA1708;CA1710;CA1711;CA1712;CA1713;CA1715;CA1716;CA1720;CA1721;CA1724;CA1725;CA1727;CA1802;CA1805;CA1806;CA1810;CA1812;CA1813;CA1814;CA1815;CA1816;CA1819;CA1820;CA1821;CA1822;CA1823;CA1824;CA1825;CA1826;CA1827;CA1828;CA1829;CA1830;CA1831;CA1832;CA1833;CA1834;CA1835;CA1836;CA1837;CA1838;CA1839;CA1840;CA1841;CA1842;CA1843;CA1844;CA1845;CA1846;CA1847;CA1848;CA1849;CA1850;CA1851;CA1852;CA1853;CA1854;CA1855;CA1856;CA1857;CA1858;CA1859;CA1860;CA1861;CA1862;CA1863;CA1864;CA1865;CA1866;CA1867;CA1868;CA1869;CA1870;CA2000;CA2002;CA2007;CA2008;CA2009;CA2011;CA2012;CA2013;CA2014;CA2015;CA2016;CA2017;CA2018;CA2019;CA2020;CA2021;CA2100;CA2101;CA2119;CA2153;CA2200;CA2201;CA2207;CA2208;CA2211;CA2213;CA2214;CA2215;CA2216;CA2217;CA2218;CA2219;CA2224;CA2225;CA2226;CA2227;CA2231;CA2234;CA2235;CA2237;CA2241;CA2242;CA2243;CA2244;CA2245;CA2246;CA2247;CA2248;CA2249;CA2250;CA2251;CA2252;CA2253;CA2254;CA2255;CA2256;CA2257;CA2258;CA2259;CA2260;CA2261;CA2300;CA2301;CA2302;CA2305;CA2310;CA2311;CA2312;CA2315;CA2321;CA2322;CA2326;CA2327;CA2328;CA2329;CA2330;CA2350;CA2351;CA2352;CA2353;CA2354;CA2355;CA2356;CA2361;CA2362;CA3001;CA3002;CA3003;CA3004;CA3005;CA3006;CA3007;CA3008;CA3009;CA3010;CA3011;CA3012;CA3061;CA3075;CA3076;CA3077;CA3147;CA5350;CA5351;CA5358;CA5359;CA5360;CA5361;CA5362;CA5363;CA5364;CA5365;CA5366;CA5367;CA5368;CA5369;CA5370;CA5371;CA5372;CA5373;CA5374;CA5375;CA5376;CA5377;CA5378;CA5379;CA5380;CA5381;CA5382;CA5383;CA5384;CA5385;CA5386;CA5387;CA5388;CA5389;CA5390;CA5391;CA5392;CA5393;CA5394;CA5395;CA5396;CA5397;CA5398;CA5399;CA5400;CA5401;CA5402;CA5403;CA5404;CA5405";
var EffectiveCodeAnalysisTreatWarningsAsErrors = "";
var _SupportedPlatformList = "@(SupportedPlatform, ',')";
var SupportedOSPlatformVersion = "";
var DotNetApiCompatTaskAssembly = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\tools\\net8.0\\Microsoft.DotNet.ApiCompat.Task.dll";
var ApiCompatValidatePackageSemaphoreFile = "obj\\Debug\\net8.0\\Microsoft.NET.ApiCompat.ValidatePackage.semaphore";
var RunPackageValidationDependsOn = "CollectApiCompatInputs;_GetReferencePathFromInnerProjects;";
var NuGetBuildTasksPackTargets = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\Sdk\\..\\..\\NuGet.Build.Tasks.Pack\\build\\NuGet.Build.Tasks.Pack.targets";
var ImportNuGetBuildTasksPackTargetsFromSdk = "true";
var NuGetPackTaskAssemblyFile = "..\\CoreCLR\\NuGet.Build.Tasks.Pack.dll";
var PackageId = "6 - targets";
var PackageVersion = "1.0.0";
var IncludeContentInPack = "true";
var GenerateNuspecDependsOn = "Build;_LoadPackInputItems; _GetTargetFrameworksOutput; _WalkEachTargetPerFramework; _GetPackageFiles; ";
var PackageDescription = "Package Description";
var IsPackable = "true";
var IncludeBuildOutput = "true";
var BuildOutputTargetFolder = "lib";
var ContentTargetFolders = "content;contentFiles";
var PackDependsOn = "; _IntermediatePack; GenerateNuspec; ";
var SymbolPackageFormat = "symbols.nupkg";
var WarnOnPackingNonPackableProject = "false";
var DefaultAllowedOutputExtensionsInPackageBuildOutputFolder = ".dll; .exe; .winmd; .json; .pri; .xml";
var AllowedOutputExtensionsInPackageBuildOutputFolder = ".dll; .exe; .winmd; .json; .pri; .xml ;";
var AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder = ".pdb; .mdb; .dll; .exe; .winmd; .json; .pri; .xml ;; ";
var SuppressDependenciesWhenPacking = "false";
var RestoreOutputPath = "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\";
var NuspecOutputPath = "obj\\Debug\\";
var _ContainersTargetsDir = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\Sdk\\..\\..\\..\\Containers\\build\\";
var SDKContainerSupportEnabled = "true";
var ContainerTaskFolderName = "tasks";
var ContainerTaskFramework = "net8.0";
var ContainerizeFolderName = "containerize";
var ContainerCustomTasksFolder = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Containers\\build\\..\\tasks\\net8.0\\";
var ContainerizeFolder = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Containers\\build\\..\\containerize\\";
var ContainerCustomTasksAssembly = "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Containers\\build\\..\\tasks\\net8.0\\Microsoft.NET.Build.Containers.dll";
var _IsSDKContainerAllowedVersion = "true";
var _ContainerIsTargetingNet8TFM = "true";
var _ContainerIsSelfContained = "false";
var PublishContainerDependsOn = """
      _ContainerVerifySDKVersion;
      ComputeContainerConfig;
      _CheckContainersPackage
    """;

class ProjectReference
{
    public string Targets { get; set; } = "
    public string OutputItemType { get; set; } = "
    public string ReferenceSourceTarget { get; set; } = "ProjectReference
}

class TargetPathWithTargetPlatformMoniker
{
    public string TargetFrameworkIdentifier { get; set; } = ".NETCoreApp
    public string TargetFrameworkVersion { get; set; } = "8.0
}

class ResolvedFileToPublish
{
    public string CopyToPublishDirectory { get; set; } = "Always
}

class BuildOutputInPackage
{
    public string TargetFramework { get; set; } = "net8.0
}

void AfterSdkPublish()
{
    
    AfterSdkPublishRun = true;
}

void _CheckForUnsupportedTargetFramework()
{
    // if ('$(_UnsupportedTargetFrameworkError)' == 'true')
    if ('' == 'true') { _CheckForUnsupportedTargetFrameworkRun = true; return; }
    
    /*NETSdkError(ResourceName: "CannotInferTargetFrameworkIdentifierAndVersion", FormatArguments: "$([MSBuild]::Escape('$(TargetFramework)'))");*/
    /* if (!$(TargetFramework.Contains(';')))*/
    if (!False)
    {
        NETSdkError(ResourceName: "CannotInferTargetFrameworkIdentifierAndVersion", FormatArguments: "net8.0");
    }
    /*NETSdkError(ResourceName: "TargetFrameworkWithSemicolon", FormatArguments: "$([MSBuild]::Escape('$(TargetFramework)'))");*/
    /* if ($(TargetFramework.Contains(';')))*/
    if (False)
    {
        NETSdkError(ResourceName: "TargetFrameworkWithSemicolon", FormatArguments: "net8.0");
    }
    
    // AfterTargets;
    if (!_CollectTargetFrameworkForTelemetryRun) _CollectTargetFrameworkForTelemetry();
    _CheckForUnsupportedTargetFrameworkRun = true;
}

void _CheckForUnsupportedTargetPlatformIdentifier()
{
    // if ('$(TargetPlatformIdentifier)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) And ('$(DesignTimeBuild)' != 'true' Or '@(MissingWorkloadPack)' == ''))
    if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True And ('' != 'true' Or '' == '')) { _CheckForUnsupportedTargetPlatformIdentifierRun = true; return; }
    // BeforeTargets;
    if (!_CheckForMissingWorkloadRun) _CheckForMissingWorkload();
    
    /* if ('$(TargetPlatformIdentifier)' == 'Windows')*/
    if ('' == 'Windows')
    {
        TargetPlatformSupported = "true";
    }
    /* if (($(TargetPlatformIdentifier) == 'ios' or $(TargetPlatformIdentifier) == 'tvos' or $(TargetPlatformIdentifier) == 'maccatalyst' or $(TargetPlatformIdentifier) == 'android' or $(TargetPlatformIdentifier.StartsWith('browser'))) and '$(MSBuildEnableWorkloadResolver)' != 'true')*/
    if (( == 'ios' or  == 'tvos' or  == 'maccatalyst' or  == 'android' or False) and 'true' != 'true')
    {
        UseWorkloadsSpecificError = "true";
    }
    /*NETSdkError(ResourceName: "UnsupportedTargetPlatformIdentifier", FormatArguments: "$(TargetPlatformIdentifier)");*/
    /* if ('$(TargetPlatformSupported)' != 'true' and '$(UseWorkloadsSpecificError)' != 'true')*/
    if ('' != 'true' and '' != 'true')
    {
        NETSdkError(ResourceName: "UnsupportedTargetPlatformIdentifier", FormatArguments: "");
    }
    /*NETSdkError(ResourceName: "UnsupportedTargetPlatformIdentifierWithWorkloadsDisabled", FormatArguments: "$(TargetPlatformIdentifier)");*/
    /* if ('$(TargetPlatformSupported)' != 'true' and '$(UseWorkloadsSpecificError)' == 'true')*/
    if ('' != 'true' and '' == 'true')
    {
        NETSdkError(ResourceName: "UnsupportedTargetPlatformIdentifierWithWorkloadsDisabled", FormatArguments: "");
    }
    
    _CheckForUnsupportedTargetPlatformIdentifierRun = true;
}

void _CollectTargetFrameworkForTelemetry()
{
    
    /*AllowEmptyTelemetry(EventData: "@(TFTelemetry)", EventName: "targetframeworkeval");*/
    AllowEmptyTelemetry(EventData: "", EventName: "targetframeworkeval");
    
    _CollectTargetFrameworkForTelemetryRun = true;
}

void _CheckForUnsupportedNETCoreVersion()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(NETCoreAppMaximumVersion)' != '')
    if ('.NETCoreApp' == '.NETCoreApp' And '8.0' != '') { _CheckForUnsupportedNETCoreVersionRun = true; return; }
    
    /* if ($([MSBuild]::VersionLessThan($(MSBuildVersion), '$(MinimumVisualStudioVersionForUnsupportedTargetFrameworkVersion)')) and '$(BuildingInsideVisualStudio)' == 'true' and '$(_TargetFrameworkVersionWithoutV)' == '$(UnsupportedTargetFrameworkVersion)' and '$([MSBuild]::IsOSPlatform(`Windows`))' == 'true')*/
    if (False and '' == 'true' and '8.0' == '9.0' and 'True' == 'true')
    {
        DisplayVSMessage = "true";
    }
    /*NETSdkError(ResourceName: "UnsupportedTargetFrameworkVersion", FormatArguments: ".NET;$(_TargetFrameworkVersionWithoutV);$(NETCoreAppMaximumVersion)");*/
    /* if ('$(_TargetFrameworkVersionWithoutV)' > '$(NETCoreAppMaximumVersion)' and '$(DisplayVSMessage)' != 'true')*/
    if ('8.0' > '8.0' and '' != 'true')
    {
        NETSdkError(ResourceName: "UnsupportedTargetFrameworkVersion", FormatArguments: ".NET;8.0;8.0");
    }
    /*NETSdkError(ResourceName: "UnsupportedVisualStudioVersion", FormatArguments: ".NET;$(_TargetFrameworkVersionWithoutV);$(NETCoreAppMaximumVersion);$(MinimumVisualStudioVersionForUnsupportedTargetFrameworkVersion)");*/
    /* if ('$(DisplayVSMessage)' == 'true')*/
    if ('' == 'true')
    {
        NETSdkError(ResourceName: "UnsupportedVisualStudioVersion", FormatArguments: ".NET;8.0;8.0;17.8");
    }
    
    // AfterTargets;
    if (!_CheckForEolTargetFrameworksRun) _CheckForEolTargetFrameworks();
    if (!_CheckForEolWorkloadsRun) _CheckForEolWorkloads();
    _CheckForUnsupportedNETCoreVersionRun = true;
}

void _CheckForUnsupportedCppNETCoreVersion()
{
    
    /* if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and '$(_TargetFrameworkVersionWithoutV)' < '3.1' and ('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true'))*/
    if ('.NETCoreApp' == '.NETCoreApp' and '8.0' < '3.1' and ('C#' == 'C++' and '' != 'true'))
    {
        NETSdkError(ResourceName: "CppRequiresTFMVersion31");
    }
    
    _CheckForUnsupportedCppNETCoreVersionRun = true;
}

void _CheckForUnsupportedNETStandardVersion()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETStandard' And '$(NETStandardMaximumVersion)' != '')
    if ('.NETCoreApp' == '.NETStandard' And '' != '') { _CheckForUnsupportedNETStandardVersionRun = true; return; }
    
    /*NETSdkError(ResourceName: "UnsupportedTargetFrameworkVersion", FormatArguments: ".NET Standard;$(_TargetFrameworkVersionWithoutV);$(NETStandardMaximumVersion)");*/
    /* if ('$(_TargetFrameworkVersionWithoutV)' > '$(NETStandardMaximumVersion)')*/
    if ('8.0' > '')
    {
        NETSdkError(ResourceName: "UnsupportedTargetFrameworkVersion", FormatArguments: ".NET Standard;8.0;");
    }
    
    _CheckForUnsupportedNETStandardVersionRun = true;
}

void _CheckForUnsupportedTargetFrameworkAndFeatureCombination()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETFramework')
    if ('.NETCoreApp' == '.NETFramework') { _CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun = true; return; }
    
    /* if ('$(UsingNETSdkDefaults)' != 'true')*/
    if ('true' != 'true')
    {
        NETSdkError(ResourceName: "NETFrameworkWithoutUsingNETSdkDefaults");
    }
    
    _CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun = true;
}

void _CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersion()
{
    // if ('$(TargetPlatformVersion)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)))
    if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True) { _CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersionRun = true; return; }
    
    /*NETSdkError(ResourceName: "CannotHaveSupportedOSPlatformVersionHigherThanTargetPlatformVersion", FormatArguments: "$(SupportedOSPlatformVersion);$(TargetPlatformVersion)");*/
    /* if ('$(SupportedOSPlatformVersion)' != '' and $(TargetPlatformVersion) != '' and $([MSBuild]::VersionGreaterThan($(SupportedOSPlatformVersion), $(TargetPlatformVersion))))*/
    if ('$(SupportedOSPlatformVersion)' != '' and $(TargetPlatformVersion) != '' and $([MSBuild]::VersionGreaterThan($(SupportedOSPlatformVersion), $(TargetPlatformVersion))))
    {
        NETSdkError(ResourceName: "CannotHaveSupportedOSPlatformVersionHigherThanTargetPlatformVersion", FormatArguments: ";");
    }
    
    _CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersionRun = true;
}

void _NormalizeTargetPlatformVersion()
{
    // if ('$(TargetPlatformVersion)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) and ('$(Language)' != 'C++' or '$(_EnablePackageReferencesInVCProjects)' == 'true'))
    if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True and ('C#' != 'C++' or '' == 'true')) { _NormalizeTargetPlatformVersionRun = true; return; }
    
    /* if ('@(_ValidTargetPlatformVersion)' != '' and '@(_ValidTargetPlatformVersion->Distinct()->Count())' == '1' and '@(_ValidTargetPlatformVersion)' != '$(TargetPlatformVersion)')*/
    if ('' != '' and '0' == '1' and '' != '')
    {
        TargetPlatformVersion = "@(_ValidTargetPlatformVersion->Distinct())";
    }
    _NormalizeTargetPlatformVersionRun = true;
}

void _CheckForInvalidTargetPlatformVersion()
{
    // if ('$(TargetPlatformVersion)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) and ('$(Language)' != 'C++' or '$(_EnablePackageReferencesInVCProjects)' == 'true'))
    if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True and ('C#' != 'C++' or '' == 'true')) { _CheckForInvalidTargetPlatformVersionRun = true; return; }
    // DependsOnTargets;
    if (!_NormalizeTargetPlatformVersionRun) _NormalizeTargetPlatformVersion();
    
    /* if ('$(TargetPlatformVersionSupported)' == '' and '@(_ValidTargetPlatformVersion)' != '')*/
    if ('' == '' and '' != '')
    {
        TargetPlatformVersionSupported = "true";
    }
    /* if ('@(SdkSupportedTargetPlatformVersion)' != '')*/
    if ('' != '')
    {
        _ValidTargetPlatformVersions = "@(SdkSupportedTargetPlatformVersion, '%0a')";
    }
    /* if ('@(SdkSupportedTargetPlatformVersion)' == '')*/
    if ('' == '')
    {
        _ValidTargetPlatformVersions = "None";
    }
    /*NetSdkError(ResourceName: "InvalidTargetPlatformVersion", FormatArguments: "$(TargetPlatformVersion);$(TargetPlatformIdentifier);$(_ValidTargetPlatformVersions)");*/
    /* if ('$(TargetPlatformVersionSupported)' != 'true')*/
    if ('' != 'true')
    {
        NetSdkError(ResourceName: "InvalidTargetPlatformVersion", FormatArguments: ";;");
    }
    
    _CheckForInvalidTargetPlatformVersionRun = true;
}

void _CheckForUnsupportedArtifactsPath()
{
    
    /* if ('$(UseArtifactsOutput)' == 'true' and '$(_ArtifactsPathSetEarly)' != 'true')*/
    if ('' == 'true' and '' != 'true')
    {
        NetSdkError(ResourceName: "ArtifactsPathCannotBeSetInProject");
    }
    /* if ('$(_ArtifactsPathLocationType)' == 'ProjectFolder')*/
    if ('' == 'ProjectFolder')
    {
        NetSdkError(ResourceName: "UseArtifactsOutputRequiresDirectoryBuildProps");
    }
    
    _CheckForUnsupportedArtifactsPathRun = true;
}

void _CheckBrowserWorkloadNeededButNotAvailable()
{
    // if ('$(RuntimeIdentifier)' == 'browser-wasm' and '$(_BrowserWorkloadDisabled)' != 'true' and '$(WasmNativeWorkloadAvailable)' != 'true')
    if ('' == 'browser-wasm' and '' != 'true' and '' != 'true') { _CheckBrowserWorkloadNeededButNotAvailableRun = true; return; }
    
    /*Warning(Text: "%40(NativeFileReference) is not empty, but the native references won't be linked in, because neither %24(WasmBuildNative), nor %24(RunAOTCompilation) are 'true'. NativeFileReference=@(NativeFileReference)");*/
    /* if (@(NativeFileReference->Count()) > 0)*/
    if (0 > 0)
    {
        Warning(Text: "@(NativeFileReference) is not empty, but the native references won't be linked in, because neither $(WasmBuildNative), nor $(RunAOTCompilation) are 'true'. NativeFileReference=");
    }
    
    _CheckBrowserWorkloadNeededButNotAvailableRun = true;
}

void _ErrorWorkloadDisabledForTFMLessThan6()
{
    // if ('$(_BrowserWorkloadNotSupportedForTFM)' == 'true')
    if ('' == 'true') { _ErrorWorkloadDisabledForTFMLessThan6Run = true; return; }
    
    /*Error(Text: "WebAssembly workloads, required for AOT, are only supported for projects targeting net6.0+ . Set %24(RunAOTCompilation)=false to disable it.");*/
    /* if ('$(RunAOTCompilation)' == 'true')*/
    if ('' == 'true')
    {
        Error(Text: "WebAssembly workloads, required for AOT, are only supported for projects targeting net6.0+ . Set $(RunAOTCompilation)=false to disable it.");
    }
    /*Error(Text: "WebAssembly workloads, required for linking native files (from %40(NativeFileReference)), are only supported for projects targeting net6.0+ .");*/
    /* if (@(NativeFileReference->Count()) > 0)*/
    if (0 > 0)
    {
        Error(Text: "WebAssembly workloads, required for linking native files (from @(NativeFileReference)), are only supported for projects targeting net6.0+ .");
    }
    /*Error(Text: "WebAssembly workloads, required for native relinking, are only supported for projects targeting net6.0+ . Set %24(WasmBuildNative)=false to disable it.");*/
    /* if ('$(WasmBuildNative)' == 'true')*/
    if ('' == 'true')
    {
        Error(Text: "WebAssembly workloads, required for native relinking, are only supported for projects targeting net6.0+ . Set $(WasmBuildNative)=false to disable it.");
    }
    
    _ErrorWorkloadDisabledForTFMLessThan6Run = true;
}

void _ErrorDualWasmThreadPropsOn7()
{
    // if ('$(TargetsNet7)' == 'true' and '$(RuntimeIdentifier)' == 'browser-wasm' and
    '$(BrowserWorkloadDisabled)' != 'true' and '$(WasmEnableThreads)' == 'true' and '$(WasmEnablePerfTrace)' == 'true')
    if ('' == 'true' and '' == 'browser-wasm' and
    '' != 'true' and '' == 'true' and '' == 'true') { _ErrorDualWasmThreadPropsOn7Run = true; return; }
    
    Error(Text: "WebAssembly workloads can only support one active threading mode at a time. Either set WasmEnableThreads or WasmEnablePerfTracing to true, but not both.");
    
    _ErrorDualWasmThreadPropsOn7Run = true;
}

void _SuggestWasmWorkloadForBlazor()
{
    
    /* if ('$(_UsingBlazorOrWasmSdk)' == 'true' and '$(WasmNativeWorkloadAvailable)' != 'true')*/
    if ('' == 'true' and '' != 'true')
    {
        Message(Text: "Publishing without optimizations. Although it's optional for Blazor, we strongly recommend using `wasm-tools` workload! You can install it by running `dotnet workload install wasm-tools` from the command line.", Importance: "High");
    }
    
    _SuggestWasmWorkloadForBlazorRun = true;
}

void GetSuggestedWorkloads()
{
    // if (@(MissingWorkloadPack) != '')
    if ( != '') { GetSuggestedWorkloadsRun = true; return; }
    
    /*ShowMissingWorkloads(NetCoreRoot: "$(NetCoreRoot)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", MissingWorkloadPacks: "@(MissingWorkloadPack)", GenerateErrorsForMissingWorkloads: "false");*/
    ShowMissingWorkloads(NetCoreRoot: "C:\\Program Files\\dotnet\\", NETCoreSdkVersion: "8.0.200-preview.23624.5", MissingWorkloadPacks: "", GenerateErrorsForMissingWorkloads: "false");
    
    GetSuggestedWorkloadsRun = true;
}

void _CheckForMissingWorkload()
{
    // if ('@(MissingWorkloadPack)' != '' And '$(DesignTimeBuild)' != 'true')
    if ('' != '' And '' != 'true') { _CheckForMissingWorkloadRun = true; return; }
    
    /*ShowMissingWorkloads(NetCoreRoot: "$(NetCoreRoot)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", MissingWorkloadPacks: "@(MissingWorkloadPack)", GenerateErrorsForMissingWorkloads: "true");*/
    ShowMissingWorkloads(NetCoreRoot: "C:\\Program Files\\dotnet\\", NETCoreSdkVersion: "8.0.200-preview.23624.5", MissingWorkloadPacks: "", GenerateErrorsForMissingWorkloads: "true");
    
    _CheckForMissingWorkloadRun = true;
}

void _GetRequiredWorkloads()
{
    // DependsOnTargets;
    if (!GetSuggestedWorkloadsRun) GetSuggestedWorkloads();
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "_GetRequiredWorkloads", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences);TargetFramework;TargetFrameworks", Projects: "@(_MSBuildProjectReferenceExistent)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
    if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '')
    {
        MSBuild(BuildInParallel: "true", Targets: "_GetRequiredWorkloads", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;TargetFrameworks", Projects: "");
    }
    
    _GetRequiredWorkloadsRun = true;
}

void _CheckForUnsupportedAppHostUsage()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and '$(HasRuntimeOutput)' == 'true')
    if ('.NETCoreApp' == '.NETCoreApp' and 'true' == 'true') { _CheckForUnsupportedAppHostUsageRun = true; return; }
    
    /* if ('$(SelfContained)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(AllowSelfContainedWithoutRuntimeIdentifier)' != 'true')*/
    if ('false' == 'true' and '' == '' and '' != 'true')
    {
        NETSdkError(ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed", FormatArguments: "SelfContained");
    }
    /* if ('$(PublishReadyToRun)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true')*/
    if ('' == 'true' and '' == '' and '' == 'true')
    {
        NETSdkError(ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed", FormatArguments: "PublishReadyToRun");
    }
    /* if ('$(PublishSingleFile)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true')*/
    if ('' == 'true' and '' == '' and '' == 'true')
    {
        NETSdkError(ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed", FormatArguments: "PublishSingleFile");
    }
    /* if ('$(PublishAot)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true' and '$(AllowPublishAotWithoutRuntimeIdentifier)' != 'true')*/
    if ('' == 'true' and '' == '' and '' == 'true' and '' != 'true')
    {
        NETSdkError(ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed", FormatArguments: "PublishAot");
    }
    /*NETSdkError(ResourceName: "PublishSelfContainedMustBeBool", FormatArguments: "$(PublishSelfContained)");*/
    /* if ('$(PublishSelfContained)' != 'true' and '$(PublishSelfContained)' != 'false' and '$(PublishSelfContained)' != '')*/
    if ('' != 'true' and '' != 'false' and '' != '')
    {
        NETSdkError(ResourceName: "PublishSelfContainedMustBeBool", FormatArguments: "");
    }
    /* if ('$(SelfContained)' == 'true' and '$(UseAppHost)' != 'true' and '$(_RuntimeIdentifierUsesAppHost)' == 'true')*/
    if ('false' == 'true' and 'true' != 'true' and 'true' == 'true')
    {
        NETSdkError(ResourceName: "CannotUseSelfContainedWithoutAppHost");
    }
    /* if ('$(SelfContained)' != 'true' and '$(UseAppHost)' == 'true' and '$(_TargetFrameworkVersionWithoutV)' < '2.1')*/
    if ('false' != 'true' and 'true' == 'true' and '8.0' < '2.1')
    {
        NETSdkError(ResourceName: "FrameworkDependentAppHostRequiresVersion21");
    }
    /* if ('$(PublishSingleFile)' == 'true' and '$(_TargetFrameworkVersionWithoutV)' < '3.0')*/
    if ('' == 'true' and '8.0' < '3.0')
    {
        NETSdkError(ResourceName: "PublishSingleFileRequiresVersion30");
    }
    /* if ('$(PublishReadyToRun)' == 'true' and '$(_TargetFrameworkVersionWithoutV)' < '3.0')*/
    if ('' == 'true' and '8.0' < '3.0')
    {
        NETSdkWarning(ResourceName: "PublishReadyToRunRequiresVersion30");
    }
    /* if ('$(RuntimeIdentifier)' != '' and '$(_TargetFrameworkVersionWithoutV)' != '' and $([MSBuild]::VersionLessThan($(_TargetFrameworkVersionWithoutV), '8.0')) and '$(_SelfContainedWasSpecified)' != 'true')*/
    if ('' != '' and '8.0' != '' and False and '' != 'true')
    {
        NETSdkWarning(ResourceName: "RuntimeIdentifierWillNoLongerImplySelfContained");
    }
    /* if (('$(UseWindowsForms)' == 'true') and ('$(PublishTrimmed)' == 'true') and ('$(_SuppressWinFormsTrimError)' != 'true'))*/
    if (('' == 'true') and ('' == 'true') and ('' != 'true'))
    {
        NetSdkError(ResourceName: "TrimmingWindowsFormsIsNotSupported");
    }
    /* if (('$(UseWpf)' == 'true') and ('$(PublishTrimmed)' == 'true') and ('$(_SuppressWpfTrimError)' != 'true'))*/
    if (('' == 'true') and ('' == 'true') and ('' != 'true'))
    {
        NetSdkError(ResourceName: "TrimmingWpfIsNotSupported");
    }
    
    _CheckForUnsupportedAppHostUsageRun = true;
}

void _CheckForUnsupportedHostingUsage()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp')
    if ('.NETCoreApp' == '.NETCoreApp') { _CheckForUnsupportedHostingUsageRun = true; return; }
    
    /* if ('$(SelfContained)' == 'true' and '$(EnableComHosting)' == 'true')*/
    if ('false' == 'true' and '' == 'true')
    {
        NETSdkWarning(ResourceName: "NoSupportComSelfContained");
    }
    
    _CheckForUnsupportedHostingUsageRun = true;
}

void _CheckAndUnsetUnsupportedPrefer32Bit()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and '$(_TargetFrameworkVersionWithoutV)' >= '7.0')
    if ('.NETCoreApp' == '.NETCoreApp' and '8.0' >= '7.0') { _CheckAndUnsetUnsupportedPrefer32BitRun = true; return; }
    
    Prefer32Bit = "false";
    /* if ('$(Prefer32Bit)' == 'true')*/
    if ('false' == 'true')
    {
        NETSdkWarning(ResourceName: "Prefer32BitIgnoredForNetCoreApp");
    }
    
    _CheckAndUnsetUnsupportedPrefer32BitRun = true;
}

void _CheckForMismatchingPlatform()
{
    // if ('$(RuntimeIdentifier)' != '' and '$(PlatformTarget)' != '')
    if ('' != '' and '' != '') { _CheckForMismatchingPlatformRun = true; return; }
    
    /*NETSdkError(ResourceName: "CannotHaveRuntimeIdentifierPlatformMismatchPlatformTarget", FormatArguments: "$(RuntimeIdentifier);$(PlatformTarget)");*/
    /* if ('$(PlatformTarget)' != 'AnyCPU' and !$(RuntimeIdentifier.ToUpperInvariant().Contains($(PlatformTarget.ToUpperInvariant()))))*/
    if ('' != 'AnyCPU' and !True)
    {
        NETSdkError(ResourceName: "CannotHaveRuntimeIdentifierPlatformMismatchPlatformTarget", FormatArguments: ";");
    }
    
    _CheckForMismatchingPlatformRun = true;
}

void _CheckForLanguageAndFeatureCombinationSupport()
{
    
    /* if (('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true') and $(OutputType) != 'library' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp')*/
    if (('C#' == 'C++' and '' != 'true') and Exe != 'library' and '.NETCoreApp' == '.NETCoreApp')
    {
        NETSdkError(ResourceName: "NoSupportCppNonDynamicLibraryDotnetCore");
    }
    /* if (('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true') and $(EnableComHosting) == 'true')*/
    if (('C#' == 'C++' and '' != 'true') and  == 'true')
    {
        NETSdkError(ResourceName: "NoSupportCppEnableComHosting");
    }
    /* if (('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true') and $(SelfContained) == 'true')*/
    if (('C#' == 'C++' and '' != 'true') and false == 'true')
    {
        NETSdkError(ResourceName: "NoSupportCppSelfContained");
    }
    
    _CheckForLanguageAndFeatureCombinationSupportRun = true;
}

void _CheckForNETCoreSdkIsPreview()
{
    // if ( '$(_NETCoreSdkIsPreview)' == 'true' AND '$(SuppressNETCoreSdkPreviewMessage)' != 'true' )
    if ( 'true' == 'true' AND '' != 'true' ) { _CheckForNETCoreSdkIsPreviewRun = true; return; }
    
    ShowPreviewMessage();
    
    _CheckForNETCoreSdkIsPreviewRun = true;
}

void AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItems()
{
    // if ('$(_UsingDefaultPlatformTarget)' == 'true' and
                     '$(_UsingDefaultRuntimeIdentifier)' == 'true')
    if ('true' == 'true' and
                     '' == 'true') { AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItemsRun = true; return; }
    
    /*GetDefaultPlatformTargetForNetFramework(NativeCopyLocalItems: "@(NativeCopyLocalItems)", PackageDependencies: "@(PackageDependencies)");*/
    GetDefaultPlatformTargetForNetFramework(NativeCopyLocalItems: "", PackageDependencies: "");
    
    AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItemsRun = true;
}

void _CheckForEolTargetFrameworks()
{
    // if ('@(_EolNetCoreTargetFrameworkVersions->AnyHaveMetadataValue('Identity', '$(_TargetFrameworkVersionWithoutV)'))' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and '$(CheckEolTargetFramework)' == 'true')
    if ('false' and '.NETCoreApp' == '.NETCoreApp' and 'true' == 'true') { _CheckForEolTargetFrameworksRun = true; return; }
    
    /*NETSdkWarning(ResourceName: "TargetFrameworkIsEol", FormatArguments: "$(TargetFramework.ToLowerInvariant());https://aka.ms/dotnet-core-support");*/
    NETSdkWarning(ResourceName: "TargetFrameworkIsEol", FormatArguments: "net8.0;https://aka.ms/dotnet-core-support");
    
    _CheckForEolTargetFrameworksRun = true;
}

void _CheckForEolWorkloads()
{
    // if ('@(EolWorkload)' != '' and '$(CheckEolWorkloads)' == 'true')
    if ('' != '' and 'true' == 'true') { _CheckForEolWorkloadsRun = true; return; }
    
    /*NETSdkWarning(ResourceName: "WorkloadIsEol", FormatArguments: "%(EolWorkload.Identity);$([MSBuild]::ValueOrDefault('%(EolWorkload.Url)', 'https://aka.ms/dotnet-core-support'))");*/
    NETSdkWarning(ResourceName: "WorkloadIsEol", FormatArguments: "%(EolWorkload.Identity);%(EolWorkload.Url)");
    
    _CheckForEolWorkloadsRun = true;
}

void GenerateTargetPlatformDefineConstants()
{
    // if ( '$(DisableImplicitFrameworkDefines)' != 'true' and '$(TargetPlatformIdentifier)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) )
    if ( '' != 'true' and '' != '' and '.NETCoreApp' == '.NETCoreApp' and True ) { GenerateTargetPlatformDefineConstantsRun = true; return; }
    
    _PlatformIdentifierForImplicitDefine = "$(TargetPlatformIdentifier.ToUpperInvariant())";
    _PlatformVersionForImplicitDefine = "$(TargetPlatformVersion.Replace('.', '_'))";
    GenerateTargetPlatformDefineConstantsRun = true;
}

void GenerateNETCompatibleDefineConstants()
{
    // if ( '$(DisableImplicitFrameworkDefines)' != 'true' and ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' or '$(TargetFrameworkIdentifier)' == '.NETFramework' or '$(TargetFrameworkIdentifier)' == '.NETStandard'))
    if ( '' != 'true' and ('.NETCoreApp' == '.NETCoreApp' or '.NETCoreApp' == '.NETFramework' or '.NETCoreApp' == '.NETStandard')) { GenerateNETCompatibleDefineConstantsRun = true; return; }
    
    GenerateNETCompatibleDefineConstantsRun = true;
}

void GeneratePlatformCompatibleDefineConstants()
{
    // if ( '$(DisableImplicitFrameworkDefines)' != 'true' and '$(TargetPlatformIdentifier)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) )
    if ( '' != 'true' and '' != '' and '.NETCoreApp' == '.NETCoreApp' and True ) { GeneratePlatformCompatibleDefineConstantsRun = true; return; }
    
    GeneratePlatformCompatibleDefineConstantsRun = true;
}

void _DisableDiagnosticTracing()
{
    // if ('$(DisableDiagnosticTracing)' == 'true')
    if ('' == 'true') { _DisableDiagnosticTracingRun = true; return; }
    // DependsOnTargets;
    if (!GenerateTargetPlatformDefineConstantsRun) GenerateTargetPlatformDefineConstants();
    if (!GenerateNETCompatibleDefineConstantsRun) GenerateNETCompatibleDefineConstants();
    if (!GeneratePlatformCompatibleDefineConstantsRun) GeneratePlatformCompatibleDefineConstants();
    
    DefineConstants = "@(_DefineConstantsWithoutTrace)";
    _DisableDiagnosticTracingRun = true;
}

void AddImplicitDefineConstants()
{
    // if ( '$(DisableImplicitFrameworkDefines)' != 'true' )
    if ( '' != 'true' ) { AddImplicitDefineConstantsRun = true; return; }
    // DependsOnTargets;
    if (!GenerateTargetPlatformDefineConstantsRun) GenerateTargetPlatformDefineConstants();
    if (!GenerateNETCompatibleDefineConstantsRun) GenerateNETCompatibleDefineConstants();
    if (!GeneratePlatformCompatibleDefineConstantsRun) GeneratePlatformCompatibleDefineConstants();
    if (!_DisableDiagnosticTracingRun) _DisableDiagnosticTracing();
    
    /* if ( '@(_ImplicitDefineConstant)' != '' )*/
    if ( '' != '' )
    {
        DefineConstants = "$(DefineConstants);@(_ImplicitDefineConstant)";
    }
    /* if ( '@(_ImplicitDefineConstant)' != '' and '$(Language)' == 'VB' )*/
    if ( '' != '' and 'C#' == 'VB' )
    {
        FinalDefineConstants = "$(FinalDefineConstants),@(_ImplicitDefineConstant->'%(Identity)=-1', ',')";
    }
    AddImplicitDefineConstantsRun = true;
}

void CreateManifestResourceNames()
{
    // if ('@(EmbeddedResource)' != '')
    if ('' != '') { CreateManifestResourceNamesRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /*CreateCSharpManifestResourceName(UseDependentUponConvention: "$(EmbeddedResourceUseDependentUponConvention)", RootNamespace: "$(RootNamespace)", ResourceFiles: "@(EmbeddedResource)");*/
    /* if ('%(EmbeddedResource.ManifestResourceName)' == '' and ('%(EmbeddedResource.WithCulture)' == 'false' or '%(EmbeddedResource.Type)' == 'Resx'))*/
    if ('%(EmbeddedResource.ManifestResourceName)' == '' and ('%(EmbeddedResource.WithCulture)' == 'false' or '%(EmbeddedResource.Type)' == 'Resx'))
    {
        CreateCSharpManifestResourceName(UseDependentUponConvention: "true", RootNamespace: "_6___targets", ResourceFiles: "");
    }
    /*CreateCSharpManifestResourceName(UseDependentUponConvention: "$(EmbeddedResourceUseDependentUponConvention)", PrependCultureAsDirectory: "false", RootNamespace: "$(RootNamespace)", ResourceFiles: "@(EmbeddedResource)");*/
    /* if ('%(EmbeddedResource.ManifestResourceName)' == '' and '%(EmbeddedResource.WithCulture)' == 'true' and '%(EmbeddedResource.Type)' == 'Non-Resx')*/
    if ('%(EmbeddedResource.ManifestResourceName)' == '' and '%(EmbeddedResource.WithCulture)' == 'true' and '%(EmbeddedResource.Type)' == 'Non-Resx')
    {
        CreateCSharpManifestResourceName(UseDependentUponConvention: "true", PrependCultureAsDirectory: "false", RootNamespace: "_6___targets", ResourceFiles: "");
    }
    
    CreateManifestResourceNamesRun = true;
}

void ResolveCodeAnalysisRuleSet()
{
    // if ('$(CodeAnalysisRuleSet)' != '')
    if ('' != '') { ResolveCodeAnalysisRuleSetRun = true; return; }
    
    /*ResolveCodeAnalysisRuleSet(CodeAnalysisRuleSet: "$(CodeAnalysisRuleSet)", CodeAnalysisRuleSetDirectories: "$(CodeAnalysisRuleSetDirectories)", MSBuildProjectDirectory: "$(MSBuildProjectDirectory)");*/
    ResolveCodeAnalysisRuleSet(CodeAnalysisRuleSet: "", CodeAnalysisRuleSetDirectories: "", MSBuildProjectDirectory: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
    
    ResolveCodeAnalysisRuleSetRun = true;
}

void XamlPreCompile()
{
    // if ('@(Page)' != '' Or '@(ApplicationDefinition)' != '')
    if ('' != '' Or '' != '') { XamlPreCompileRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    if (!_ComputeNonExistentFilePropertyRun) _ComputeNonExistentFileProperty();
    if (!ResolveCodeAnalysisRuleSetRun) ResolveCodeAnalysisRuleSet();
    if (!GenerateMSBuildEditorConfigFileRun) GenerateMSBuildEditorConfigFile();
    
    /* if (('$(TargetFrameworkVersion)' != 'v1.0') and ('$(TargetFrameworkVersion)' != 'v1.1'))*/
    if (('v8.0' != 'v1.0') and ('v8.0' != 'v1.1'))
    {
        NoWarn = "$(NoWarn);1701;1702";
    }
    /* if ( '$(BuildingInsideVisualStudio)' == 'true' and '$(VisualStudioVersion)' != '' and '$(VisualStudioVersion)' > '10.0' )*/
    if ( '' == 'true' and '17.0' != '' and '17.0' > '10.0' )
    {
        NoWarn = "$(NoWarn);2008";
    }
    /* if ('$(AppConfigForCompiler)' == '' and '$(UseAppConfigForCompiler)' == 'true')*/
    if ('' == '' and '' == 'true')
    {
        AppConfigForCompiler = "$(AppConfig)";
    }
    /* if ('$(PdbFile)' == '' and '$(OutputType)' == 'winmdobj' and '$(_DebugSymbolsProduced)' == 'true')*/
    if ('' == '' and 'Exe' == 'winmdobj' and 'true' == 'true')
    {
        PdbFile = "$(IntermediateOutputPath)$(TargetName).compile.pdb";
    }
    /* if (('$(TargetFrameworkVersion)' == 'v4.0'))*/
    if (('v8.0' == 'v4.0'))
    {
        Prefer32Bit = "false";
    }
    /* if ('$(UseSharedCompilation)' == '')*/
    if ('' == '')
    {
        UseSharedCompilation = "true";
    }
    /*Csc(TargetType: "$(OutputType)", WarningsAsErrors: "$(WarningsAsErrors)", CheckForOverflowUnderflow: "$(CheckForOverflowUnderflow)", ErrorReport: "$(ErrorReport)", CodeAnalysisRuleSet: "$(ResolvedCodeAnalysisRuleSet)", AddModules: "@(AddModules)", ToolPath: "$(CscToolPath)", AllowUnsafeBlocks: "$(AllowUnsafeBlocks)", DelaySign: "$(DelaySign)", FileAlignment: "$(FileAlignment)", ToolExe: "$(CscToolExe)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", HighEntropyVA: "$(HighEntropyVA)", DebugType: "$(DebugType)", Platform: "$(PlatformTarget)", EmitDebugInformation: "$(DebugSymbols)", NoConfig: "true", Prefer32Bit: "$(Prefer32Bit)", AdditionalLibPaths: "$(AdditionalLibPaths)", DisabledWarnings: "$(NoWarn)", SubsystemVersion: "$(SubsystemVersion)", Optimize: "$(Optimize)", NoLogo: "$(NoLogo)", PreferredUILang: "$(PreferredUILang)", ResponseFiles: "$(CompilerResponseFile)", ModuleAssemblyName: "$(ModuleAssemblyName)", GenerateFullPaths: "$(GenerateFullPaths)", Resources: "@(_CoreCompileResourceInputs);@(CompiledLicenseFile)", KeyFile: "$(KeyOriginatorFile)", ErrorLog: "$(ErrorLog)", Analyzers: "@(Analyzer)", Nullable: "$(Nullable)", KeyContainer: "$(KeyContainerName)", UseSharedCompilation: "$(UseSharedCompilation)", ApplicationConfiguration: "$(AppConfigForCompiler)", MainEntryPoint: "$(StartupObject)", Utf8Output: "$(Utf8Output)", References: "@(ReferencePath)", Sources: "@(Compile)", NoStandardLib: "$(NoCompilerStandardLib)", WarningLevel: "$(WarningLevel)", Win32Manifest: "$(Win32Manifest)", LinkResources: "@(LinkResource)", AnalyzerConfigFiles: "@(EditorConfigFiles)", SkipAnalyzers: "true", CodePage: "$(CodePage)", BaseAddress: "$(BaseAddress)", ReportAnalyzer: "$(ReportAnalyzer)", Win32Icon: "$(ApplicationIcon)", VsSessionGuid: "$(VsSessionGuid)", EnvironmentVariables: "$(CscEnvironment)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", ErrorEndLocation: "$(ErrorEndLocation)", DefineConstants: "$(DefineConstants)", AdditionalFiles: "@(AdditionalFiles)", NoWin32Manifest: "$(NoWin32Manifest)", Win32Resource: "$(Win32Resource)", UseHostCompilerIfAvailable: "$(UseHostCompilerIfAvailable)", LangVersion: "$(LangVersion)", PdbFile: "$(PdbFile)", OutputAssembly: "@(XamlIntermediateAssembly)", DocumentationFile: "@(DocFileItem)");*/
    /* if ( '%(_CoreCompileResourceInputs.WithCulture)' != 'true' )*/
    if ( '%(_CoreCompileResourceInputs.WithCulture)' != 'true' )
    {
        Csc(TargetType: "Exe", WarningsAsErrors: ";NU1605;SYSLIB0011", CheckForOverflowUnderflow: "false", ErrorReport: "prompt", CodeAnalysisRuleSet: "", AddModules: "", ToolPath: "", AllowUnsafeBlocks: "false", DelaySign: "", FileAlignment: "512", ToolExe: "", WarningsNotAsErrors: "", HighEntropyVA: "true", DebugType: "portable", Platform: "", EmitDebugInformation: "true", NoConfig: "true", Prefer32Bit: "false", AdditionalLibPaths: "", DisabledWarnings: "1701;1702", SubsystemVersion: "", Optimize: "false", NoLogo: "", PreferredUILang: "", ResponseFiles: "", ModuleAssemblyName: "", GenerateFullPaths: "true", Resources: ";", KeyFile: "", ErrorLog: "", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", Nullable: "enable", KeyContainer: "", UseSharedCompilation: "", ApplicationConfiguration: "", MainEntryPoint: "", Utf8Output: "true", References: "", Sources: "Program.cs", NoStandardLib: "true", WarningLevel: "8", Win32Manifest: "", LinkResources: "", AnalyzerConfigFiles: "", SkipAnalyzers: "true", CodePage: "", BaseAddress: "", ReportAnalyzer: "", Win32Icon: "", VsSessionGuid: "", EnvironmentVariables: "", TreatWarningsAsErrors: "false", ErrorEndLocation: "", DefineConstants: "TRACE;DEBUG;NET;NET8_0;NETCOREAPP", AdditionalFiles: "", NoWin32Manifest: "", Win32Resource: "", UseHostCompilerIfAvailable: "true", LangVersion: "12.0", PdbFile: "", OutputAssembly: "", DocumentationFile: "");
    }
    
    XamlPreCompileRun = true;
}

void ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies()
{
    // if ('@(ReferencePathWithRefAssemblies)' == '')
    if ('' == '') { ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssembliesRun = true; return; }
    
    ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssembliesRun = true;
}

void _BeforeVBCSCoreCompile()
{
    // DependsOnTargets;
    if (!ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssembliesRun) ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies();
    
    /* if (('$(TargetFrameworkVersion)' == 'v4.0'))*/
    if (('v8.0' == 'v4.0'))
    {
        Prefer32Bit = "false";
    }
    /* if ('$(UseSharedCompilation)' == '')*/
    if ('' == '')
    {
        UseSharedCompilation = "true";
    }
    _BeforeVBCSCoreCompileRun = true;
}

void _ComputeSkipAnalyzers()
{
    
    _SkipAnalyzers = "";
    _ImplicitlySkipAnalyzers = "";
    /* if ('$(RunAnalyzers)' == 'false' or
                              ('$(RunAnalyzers)' == '' and '$(RunAnalyzersDuringBuild)' == 'false'))*/
    if ('' == 'false' or
                              ('' == '' and '' == 'false'))
    {
        _SkipAnalyzers = "true";
    }
    /* if ('$(_SkipAnalyzers)' == '' and
                              '$(IsImplicitlyTriggeredBuild)' == 'true' and
                              '$(UsingMicrosoftNETSdk)' == 'true' and
                              '$(OptimizeImplicitlyTriggeredBuild)' != 'false' and
                              ('$(TreatWarningsAsErrors)' != 'true' or '$(OptimizeImplicitlyTriggeredBuild)' == 'true'))*/
    if ('' == '' and
                              '' == 'true' and
                              'true' == 'true' and
                              '' != 'false' and
                              ('false' != 'true' or '' == 'true'))
    {
        _ImplicitlySkipAnalyzers = "true";
        _SkipAnalyzers = "true";
        Features = "run-nullable-analysis=never;$(Features)";
    }
    _LastBuildWithSkipAnalyzers = "$(IntermediateOutputPath)$(MSBuildProjectFile).BuildWithSkipAnalyzers";
    /* if ('$(_ImplicitlySkipAnalyzers)' == 'true')*/
    if ('' == 'true')
    {
        ShowMessageForImplicitlySkipAnalyzers();
    }
    
    _ComputeSkipAnalyzersRun = true;
}

void _TouchLastBuildWithSkipAnalyzers()
{
    // if ('$(_SkipAnalyzers)' == 'true')
    if ('' == 'true') { _TouchLastBuildWithSkipAnalyzersRun = true; return; }
    
    /*Touch(AlwaysCreate: "true", Files: "$(_LastBuildWithSkipAnalyzers)");*/
    Touch(AlwaysCreate: "true", Files: "");
    
    _TouchLastBuildWithSkipAnalyzersRun = true;
}

void GenerateMSBuildEditorConfigFile()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!GenerateMSBuildEditorConfigFileShouldRunRun) GenerateMSBuildEditorConfigFileShouldRun();
    if (!GenerateMSBuildEditorConfigFileCoreRun) GenerateMSBuildEditorConfigFileCore();
    
    GenerateMSBuildEditorConfigFileRun = true;
}

void GenerateMSBuildEditorConfigFileShouldRun()
{
    
    /* if ('$(GeneratedMSBuildEditorConfigFile)' == '')*/
    if ('' == '')
    {
        GeneratedMSBuildEditorConfigFile = "$(IntermediateOutputPath)$(MSBuildProjectName).GeneratedMSBuildEditorConfig.editorconfig";
    }
    /* if ('$(GenerateMSBuildEditorConfigFile)' == '')*/
    if ('' == '')
    {
        GenerateMSBuildEditorConfigFile = "true";
    }
    /* if ('@(CompilerVisibleItemMetadata->Count())' != '0')*/
    if ('0' != '0')
    {
        _GeneratedEditorConfigHasItems = "true";
    }
    /* if ('$(GenerateMSBuildEditorConfigFile)' == 'true' and ('$(_GeneratedEditorConfigHasItems)' == 'true' or '@(CompilerVisibleProperty->Count())' != '0'))*/
    if ('' == 'true' and ('' == 'true' or '12' != '0'))
    {
        _GeneratedEditorConfigShouldRun = "true";
    }
    GenerateMSBuildEditorConfigFileShouldRunRun = true;
}

void GenerateMSBuildEditorConfigFileCore()
{
    // if ('$(_GeneratedEditorConfigShouldRun)' == 'true')
    if ('' == 'true') { GenerateMSBuildEditorConfigFileCoreRun = true; return; }
    
    /*GenerateMSBuildEditorConfig(PropertyItems: "@(_GeneratedEditorConfigProperty)", FileName: "$(GeneratedMSBuildEditorConfigFile)", MetadataItems: "@(_GeneratedEditorConfigMetadata)");*/
    GenerateMSBuildEditorConfig(PropertyItems: "", FileName: "", MetadataItems: "");
    
    GenerateMSBuildEditorConfigFileCoreRun = true;
}

void InitializeSourceRootMappedPaths()
{
    // DependsOnTargets;
    if (!_InitializeSourceRootMappedPathsFromSourceControlRun) _InitializeSourceRootMappedPathsFromSourceControl();
    
    /*Microsoft.CodeAnalysis.BuildTasks.MapSourceRoots(Deterministic: "$(DeterministicSourcePaths)", SourceRoots: "@(SourceRoot)");*/
    Microsoft.CodeAnalysis.BuildTasks.MapSourceRoots(Deterministic: "", SourceRoots: "");
    
    InitializeSourceRootMappedPathsRun = true;
}

void _InitializeSourceRootMappedPathsFromSourceControl()
{
    // if ('$(SourceControlInformationFeatureSupported)' == 'true')
    if ('true' == 'true') { _InitializeSourceRootMappedPathsFromSourceControlRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceControlInformationRun) InitializeSourceControlInformation();
    
    _InitializeSourceRootMappedPathsFromSourceControlRun = true;
}

void _SetPathMapFromSourceRoots()
{
    // if ('$(DeterministicSourcePaths)' == 'true')
    if ('' == 'true') { _SetPathMapFromSourceRootsRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceRootMappedPathsRun) InitializeSourceRootMappedPaths();
    
    /* if ('@(_TopLevelSourceRoot)' != '')*/
    if ('' != '')
    {
        PathMap = "@(_TopLevelSourceRoot->'%(EscapedKey)=%(EscapedValue)', ','),$(PathMap)";
    }
    _SetPathMapFromSourceRootsRun = true;
}

void CopyAdditionalFiles()
{
    
    CopyAdditionalFilesRun = true;
}

void CreateCompilerGeneratedFilesOutputPath()
{
    // if ('$(EmitCompilerGeneratedFiles)' == 'true' and !('$(DesignTimeBuild)' == 'true' OR '$(BuildingProject)' != 'true'))
    if ('false' == 'true' and !('' == 'true' OR 'false' != 'true')) { CreateCompilerGeneratedFilesOutputPathRun = true; return; }
    
    /* if ('$(CompilerGeneratedFilesOutputPath)' == '')*/
    if ('' == '')
    {
        Warning(Text: "EmitCompilerGeneratedFiles was true, but no CompilerGeneratedFilesOutputPath was provided. CompilerGeneratedFilesOutputPath must be set in order to emit generated files.");
    }
    /*MakeDir(Directories: "$(CompilerGeneratedFilesOutputPath)");*/
    /* if ('$(CompilerGeneratedFilesOutputPath)' != '')*/
    if ('' != '')
    {
        MakeDir(Directories: "");
    }
    
    CreateCompilerGeneratedFilesOutputPathRun = true;
}

void CoreCompile()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!_ComputeNonExistentFilePropertyRun) _ComputeNonExistentFileProperty();
    if (!ResolveCodeAnalysisRuleSetRun) ResolveCodeAnalysisRuleSet();
    if (!_BeforeVBCSCoreCompileRun) _BeforeVBCSCoreCompile();
    // BeforeTargets;
    if (!AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItemsRun) AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItems();
    if (!_DisableDiagnosticTracingRun) _DisableDiagnosticTracing();
    if (!AddImplicitDefineConstantsRun) AddImplicitDefineConstants();
    if (!ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssembliesRun) ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies();
    if (!_ComputeSkipAnalyzersRun) _ComputeSkipAnalyzers();
    if (!GenerateMSBuildEditorConfigFileRun) GenerateMSBuildEditorConfigFile();
    if (!_SetPathMapFromSourceRootsRun) _SetPathMapFromSourceRoots();
    if (!CreateCompilerGeneratedFilesOutputPathRun) CreateCompilerGeneratedFilesOutputPath();
    if (!CheckForDuplicateItemsRun) CheckForDuplicateItems();
    if (!_SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun) _SetEmbeddedFilesFromSourceControlManagerUntrackedFiles();
    if (!GenerateSourceLinkFileRun) GenerateSourceLinkFile();
    if (!GenerateAssemblyInfoRun) GenerateAssemblyInfo();
    if (!GenerateGlobalUsingsRun) GenerateGlobalUsings();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzers();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesign();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentation();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalization();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNaming();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformance();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurity();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsage();
    if (!_CodeAnalysisTreatWarningsAsErrorsRun) _CodeAnalysisTreatWarningsAsErrors();
    if (!_ReportUpgradeNetAnalyzersNuGetWarningRun) _ReportUpgradeNetAnalyzersNuGetWarning();
    
    /* if (('$(TargetFrameworkVersion)' != 'v1.0') and ('$(TargetFrameworkVersion)' != 'v1.1'))*/
    if (('v8.0' != 'v1.0') and ('v8.0' != 'v1.1'))
    {
        NoWarn = "$(NoWarn);1701;1702";
    }
    /* if ('$(BuildingInsideVisualStudio)' == 'true' AND '$(VisualStudioVersion)' != '' AND '$(VisualStudioVersion)' > '10.0')*/
    if ('' == 'true' AND '17.0' != '' AND '17.0' > '10.0')
    {
        NoWarn = "$(NoWarn);2008";
    }
    /* if ('$(AppConfigForCompiler)' == '' AND '$(UseAppConfigForCompiler)' == 'true')*/
    if ('' == '' AND '' == 'true')
    {
        AppConfigForCompiler = "$(AppConfig)";
    }
    /* if ('$(PdbFile)' == '' AND '$(OutputType)' == 'winmdobj' AND '$(_DebugSymbolsProduced)' == 'true')*/
    if ('' == '' AND 'Exe' == 'winmdobj' AND 'true' == 'true')
    {
        PdbFile = "$(IntermediateOutputPath)$(TargetName).compile.pdb";
    }
    /*Csc(TargetType: "$(OutputType)", WarningsAsErrors: "$(WarningsAsErrors)", CheckForOverflowUnderflow: "$(CheckForOverflowUnderflow)", ErrorReport: "$(ErrorReport)", CodeAnalysisRuleSet: "$(ResolvedCodeAnalysisRuleSet)", AddModules: "@(AddModules)", ToolPath: "$(CscToolPath)", AllowUnsafeBlocks: "$(AllowUnsafeBlocks)", DelaySign: "$(DelaySign)", FileAlignment: "$(FileAlignment)", DisableSdkPath: "$(DisableSdkPath)", ToolExe: "$(CscToolExe)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ReportIVTs: "$(ReportIVTs)", PublicSign: "$(PublicSign)", HighEntropyVA: "$(HighEntropyVA)", OutputRefAssembly: "@(IntermediateRefAssembly)", DebugType: "$(DebugType)", Platform: "$(PlatformTarget)", PathMap: "$(PathMap)", EmitDebugInformation: "$(DebugSymbols)", EmbedAllSources: "$(EmbedAllSources)", SharedCompilationId: "$(SharedCompilationId)", NoConfig: "true", Prefer32Bit: "$(Prefer32Bit)", AdditionalLibPaths: "$(AdditionalLibPaths)", DisabledWarnings: "$(NoWarn)", SubsystemVersion: "$(SubsystemVersion)", Optimize: "$(Optimize)", NoLogo: "$(NoLogo)", PreferredUILang: "$(PreferredUILang)", Instrument: "$(Instrument)", Features: "$(Features)", ResponseFiles: "$(CompilerResponseFile)", ModuleAssemblyName: "$(ModuleAssemblyName)", GenerateFullPaths: "$(GenerateFullPaths)", Resources: "@(_CoreCompileResourceInputs);@(CompiledLicenseFile)", KeyFile: "$(KeyOriginatorFile)", ErrorLog: "$(ErrorLog)", Analyzers: "@(Analyzer)", Nullable: "$(Nullable)", KeyContainer: "$(KeyContainerName)", UseSharedCompilation: "$(UseSharedCompilation)", SourceLink: "$(SourceLink)", ApplicationConfiguration: "$(AppConfigForCompiler)", GeneratedFilesOutputPath: "$(CompilerGeneratedFilesOutputPath)", MainEntryPoint: "$(StartupObject)", Utf8Output: "$(Utf8Output)", References: "@(ReferencePathWithRefAssemblies)", Sources: "@(Compile)", NoStandardLib: "$(NoCompilerStandardLib)", WarningLevel: "$(WarningLevel)", Win32Manifest: "$(Win32Manifest)", LinkResources: "@(LinkResource)", AnalyzerConfigFiles: "@(EditorConfigFiles)", RefOnly: "$(ProduceOnlyReferenceAssembly)", SkipAnalyzers: "$(_SkipAnalyzers)", CodePage: "$(CodePage)", InterceptorsPreviewNamespaces: "$(InterceptorsPreviewNamespaces)", BaseAddress: "$(BaseAddress)", SkipCompilerExecution: "$(SkipCompilerExecution)", RuntimeMetadataVersion: "$(RuntimeMetadataVersion)", ReportAnalyzer: "$(ReportAnalyzer)", Deterministic: "$(Deterministic)", Win32Icon: "$(ApplicationIcon)", ChecksumAlgorithm: "$(ChecksumAlgorithm)", VsSessionGuid: "$(VsSessionGuid)", EnvironmentVariables: "$(CscEnvironment)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", ErrorEndLocation: "$(ErrorEndLocation)", DefineConstants: "$(DefineConstants)", AdditionalFiles: "@(AdditionalFiles)", NoWin32Manifest: "$(NoWin32Manifest)", Win32Resource: "$(Win32Resource)", ProvideCommandLineArgs: "$(ProvideCommandLineArgs)", UseHostCompilerIfAvailable: "$(UseHostCompilerIfAvailable)", EmbeddedFiles: "@(EmbeddedFiles)", LangVersion: "$(LangVersion)", PdbFile: "$(PdbFile)", OutputAssembly: "@(IntermediateAssembly)", DocumentationFile: "@(DocFileItem)");*/
    /* if ('%(_CoreCompileResourceInputs.WithCulture)' != 'true')*/
    if ('%(_CoreCompileResourceInputs.WithCulture)' != 'true')
    {
        Csc(TargetType: "Exe", WarningsAsErrors: ";NU1605;SYSLIB0011", CheckForOverflowUnderflow: "false", ErrorReport: "prompt", CodeAnalysisRuleSet: "", AddModules: "", ToolPath: "", AllowUnsafeBlocks: "false", DelaySign: "", FileAlignment: "512", DisableSdkPath: "", ToolExe: "", WarningsNotAsErrors: "", ReportIVTs: "", PublicSign: "", HighEntropyVA: "true", OutputRefAssembly: "obj\\Debug\\net8.0\\refint\\6 - targets.dll", DebugType: "portable", Platform: "", PathMap: "", EmitDebugInformation: "true", EmbedAllSources: "", SharedCompilationId: "", NoConfig: "true", Prefer32Bit: "false", AdditionalLibPaths: "", DisabledWarnings: "1701;1702", SubsystemVersion: "", Optimize: "false", NoLogo: "", PreferredUILang: "", Instrument: "", Features: "", ResponseFiles: "", ModuleAssemblyName: "", GenerateFullPaths: "true", Resources: ";", KeyFile: "", ErrorLog: "", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", Nullable: "enable", KeyContainer: "", UseSharedCompilation: "", SourceLink: "", ApplicationConfiguration: "", GeneratedFilesOutputPath: "", MainEntryPoint: "", Utf8Output: "true", References: "", Sources: "Program.cs", NoStandardLib: "true", WarningLevel: "8", Win32Manifest: "", LinkResources: "", AnalyzerConfigFiles: "", RefOnly: "", SkipAnalyzers: "", CodePage: "", InterceptorsPreviewNamespaces: "", BaseAddress: "", SkipCompilerExecution: "", RuntimeMetadataVersion: "", ReportAnalyzer: "", Deterministic: "true", Win32Icon: "", ChecksumAlgorithm: "", VsSessionGuid: "", EnvironmentVariables: "", TreatWarningsAsErrors: "false", ErrorEndLocation: "", DefineConstants: "TRACE;DEBUG;NET;NET8_0;NETCOREAPP", AdditionalFiles: "", NoWin32Manifest: "", Win32Resource: "", ProvideCommandLineArgs: "", UseHostCompilerIfAvailable: "true", EmbeddedFiles: "", LangVersion: "12.0", PdbFile: "", OutputAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", DocumentationFile: "");
    }
    /*CallTarget(Targets: "$(TargetsTriggeredByCompilation)");*/
    /* if ('$(TargetsTriggeredByCompilation)' != '')*/
    if ('' != '')
    {
        CallTarget(Targets: "");
    }
    
    // AfterTargets;
    if (!_TouchLastBuildWithSkipAnalyzersRun) _TouchLastBuildWithSkipAnalyzers();
    CoreCompileRun = true;
}

void InitializeSourceControlInformation()
{
    // BeforeTargets;
    if (!_InitializeSourceControlInformationFromSourceControlManagerRun) _InitializeSourceControlInformationFromSourceControlManager();
    
    InitializeSourceControlInformationRun = true;
}

void _AddOutputPathToGlobalPropertiesToRemove()
{
    
    /* if ('$(PassOutputPathToReferencedProjects)'=='false')*/
    if (''=='false')
    {
        _GlobalPropertiesToRemoveFromProjectReferences = "$(_GlobalPropertiesToRemoveFromProjectReferences);OutputPath";
    }
    _AddOutputPathToGlobalPropertiesToRemoveRun = true;
}

void _CheckForInvalidConfigurationAndPlatform()
{
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetFrameworkRun) _CheckForUnsupportedTargetFramework();
    if (!_CheckForUnsupportedTargetPlatformIdentifierRun) _CheckForUnsupportedTargetPlatformIdentifier();
    if (!_CheckForUnsupportedNETCoreVersionRun) _CheckForUnsupportedNETCoreVersion();
    if (!_CheckForUnsupportedCppNETCoreVersionRun) _CheckForUnsupportedCppNETCoreVersion();
    if (!_CheckForUnsupportedNETStandardVersionRun) _CheckForUnsupportedNETStandardVersion();
    if (!_CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun) _CheckForUnsupportedTargetFrameworkAndFeatureCombination();
    if (!_CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersionRun) _CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersion();
    if (!_CheckForInvalidTargetPlatformVersionRun) _CheckForInvalidTargetPlatformVersion();
    if (!_CheckForUnsupportedArtifactsPathRun) _CheckForUnsupportedArtifactsPath();
    if (!_CheckForMissingWorkloadRun) _CheckForMissingWorkload();
    if (!_CheckForUnsupportedAppHostUsageRun) _CheckForUnsupportedAppHostUsage();
    if (!_CheckForUnsupportedHostingUsageRun) _CheckForUnsupportedHostingUsage();
    if (!_CheckAndUnsetUnsupportedPrefer32BitRun) _CheckAndUnsetUnsupportedPrefer32Bit();
    if (!_CheckForMismatchingPlatformRun) _CheckForMismatchingPlatform();
    if (!_CheckForLanguageAndFeatureCombinationSupportRun) _CheckForLanguageAndFeatureCombinationSupport();
    if (!_CheckForNETCoreSdkIsPreviewRun) _CheckForNETCoreSdkIsPreview();
    if (!EnableIntermediateOutputPathMismatchWarningRun) EnableIntermediateOutputPathMismatchWarning();
    if (!ApplyImplicitVersionsRun) ApplyImplicitVersions();
    if (!CheckForImplicitPackageReferenceOverridesRun) CheckForImplicitPackageReferenceOverrides();
    if (!CheckForDuplicateItemsRun) CheckForDuplicateItems();
    if (!WarnForExplicitVersionsRun) WarnForExplicitVersions();
    if (!_CheckForFailedSDKResolutionRun) _CheckForFailedSDKResolution();
    if (!_WarnWhenUsingNET8AndVSPriorTo178Run) _WarnWhenUsingNET8AndVSPriorTo178();
    if (!_CheckForInvalidWindowsDesktopTargetingConfigurationRun) _CheckForInvalidWindowsDesktopTargetingConfiguration();
    if (!_CheckForUnnecessaryWindowsDesktopSDKRun) _CheckForUnnecessaryWindowsDesktopSDK();
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    if (!IncludeTargetingPackReferenceRun) IncludeTargetingPackReference();
    
    _InvalidConfigurationMessageText = "The BaseOutputPath/OutputPath property is not set for project '$(MSBuildProjectFile)'.  Please check to make sure that you have specified a valid combination of Configuration and Platform for this project.  Configuration='$(_OriginalConfiguration)'  Platform='$(_OriginalPlatform)'.";
    /* if ('$(BuildingInsideVisualStudio)' == 'true')*/
    if ('' == 'true')
    {
        _InvalidConfigurationMessageText = "$(_InvalidConfigurationMessageText)  This error may also appear if some other project is trying to follow a project-to-project reference to this project, this project has been unloaded or is not included in the solution, and the referencing project does not build using the same or an equivalent Configuration or Platform.";
    }
    /* if ('$(BuildingInsideVisualStudio)' != 'true')*/
    if ('' != 'true')
    {
        _InvalidConfigurationMessageText = "$(_InvalidConfigurationMessageText)  You may be seeing this message because you are trying to build a project without a solution file, and have specified a non-default Configuration or Platform that doesn't exist for this project.";
    }
    /* if ('$(Prefer32Bit)' == 'true' and ('$(PlatformTarget)' == 'AnyCPU' or '$(PlatformTarget)' == '') and '$(PlatformTargetAsMSBuildArchitectureExplicitlySet)' != 'true')*/
    if ('false' == 'true' and ('' == 'AnyCPU' or '' == '') and '' != 'true')
    {
        PlatformTargetAsMSBuildArchitecture = "x86";
    }
    /*Error(Text: "$(_InvalidConfigurationMessageText)");*/
    /* if ( '$(_InvalidConfigurationError)' == 'true' )*/
    if ( '' == 'true' )
    {
        Error(Text: "");
    }
    /*Warning(Text: "$(_InvalidConfigurationMessageText)");*/
    /* if ( '$(_InvalidConfigurationWarning)' == 'true' )*/
    if ( '' == 'true' )
    {
        Warning(Text: "");
    }
    /*Message(Text: "Configuration=$(Configuration)", Importance: "Low");*/
    /* if ('$(DesignTimeBuild)' != 'true')*/
    if ('' != 'true')
    {
        Message(Text: "Configuration=Debug", Importance: "Low");
    }
    /*Message(Text: "Platform=$(Platform)", Importance: "Low");*/
    /* if ('$(DesignTimeBuild)' != 'true')*/
    if ('' != 'true')
    {
        Message(Text: "Platform=AnyCPU", Importance: "Low");
    }
    /* if ('$(OutDir)' != '' and !HasTrailingSlash('$(OutDir)'))*/
    if ('bin\Debug\net8.0\' != '' and !HasTrailingSlash('bin\Debug\net8.0\'))
    {
        Error(Text: "The OutDir property must end with a trailing slash.");
    }
    /* if ('$(IntermediateOutputPath)' != '' and !HasTrailingSlash('$(IntermediateOutputPath)'))*/
    if ('obj\Debug\net8.0\' != '' and !HasTrailingSlash('obj\Debug\net8.0\'))
    {
        Error(Text: "The IntermediateOutputPath must end with a trailing slash.");
    }
    /* if ('$(BaseIntermediateOutputPath)' != '' and !HasTrailingSlash('$(BaseIntermediateOutputPath)'))*/
    if ('obj\' != '' and !HasTrailingSlash('obj\'))
    {
        Error(Text: "The BaseIntermediateOutputPath must end with a trailing slash.");
    }
    /* if ( '$(_InitialMSBuildProjectExtensionsPath)' != '' And '$(MSBuildProjectExtensionsPath)' != '$(_InitialMSBuildProjectExtensionsPath)' )*/
    if ( 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\' != '' And 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\' )
    {
        Error(Text: "The value of the property "MSBuildProjectExtensionsPath" was modified after it was used by MSBuild which can lead to unexpected build results.  To set this property, you must do so before Microsoft.Common.props is imported, for example by using Directory.Build.props.  For more information, please visit https://go.microsoft.com/fwlink/?linkid=869650", Code: "MSB3540");
    }
    /* if ( '$(EnableBaseIntermediateOutputPathMismatchWarning)' == 'true' And '$(_InitialBaseIntermediateOutputPath)' != '$(BaseIntermediateOutputPath)' And '$(BaseIntermediateOutputPath)' != '$(MSBuildProjectExtensionsPath)' )*/
    if ( '' == 'true' And 'obj\' != 'obj\' And 'obj\' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\' )
    {
        Warning(Text: "The value of the property "BaseIntermediateOutputPath" was modified after it was used by MSBuild which can lead to unexpected build results. Tools such as NuGet will write outputs to the path specified by the "MSBuildProjectExtensionsPath" instead. To set this property, you must do so before Microsoft.Common.props is imported, for example by using Directory.Build.props.  For more information, please visit https://go.microsoft.com/fwlink/?linkid=869650", Code: "MSB3539");
    }
    
    // AfterTargets;
    if (!ValidateCommandLinePropertiesRun) ValidateCommandLineProperties();
    _CheckForInvalidConfigurationAndPlatformRun = true;
}

void Build()
{
    // if ( '$(_InvalidConfigurationWarning)' != 'true' )
    if ( '' != 'true' ) { BuildRun = true; return; }
    // DependsOnTargets;
    if (!BeforeBuildRun) BeforeBuild();
    if (!CoreBuildRun) CoreBuild();
    if (!AfterBuildRun) AfterBuild();
    // BeforeTargets;
    if (!_CheckBrowserWorkloadNeededButNotAvailableRun) _CheckBrowserWorkloadNeededButNotAvailable();
    if (!_ErrorWorkloadDisabledForTFMLessThan6Run) _ErrorWorkloadDisabledForTFMLessThan6();
    if (!_ErrorDualWasmThreadPropsOn7Run) _ErrorDualWasmThreadPropsOn7();
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    // AfterTargets;
    if (!_PackAsBuildAfterTargetRun) _PackAsBuildAfterTarget();
    if (!_CheckContainersPackageRun) _CheckContainersPackage();
    BuildRun = true;
}

void BeforeBuild()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    BeforeBuildRun = true;
}

void AfterBuild()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    AfterBuildRun = true;
}

void CoreBuild()
{
    // DependsOnTargets;
    if (!_CheckForBuildWithNoBuildRun) _CheckForBuildWithNoBuild();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!PreBuildEventRun) PreBuildEvent();
    if (!ResolveReferencesRun) ResolveReferences();
    if (!PrepareResourcesRun) PrepareResources();
    if (!ResolveKeySourceRun) ResolveKeySource();
    if (!CompileRun) Compile();
    if (!ExportWindowsMDFileRun) ExportWindowsMDFile();
    if (!UnmanagedUnregistrationRun) UnmanagedUnregistration();
    if (!GenerateSerializationAssembliesRun) GenerateSerializationAssemblies();
    if (!CreateSatelliteAssembliesRun) CreateSatelliteAssemblies();
    if (!GenerateManifestsRun) GenerateManifests();
    if (!GetTargetPathRun) GetTargetPath();
    if (!PrepareForRunRun) PrepareForRun();
    if (!UnmanagedRegistrationRun) UnmanagedRegistration();
    if (!IncrementalCleanRun) IncrementalClean();
    if (!PostBuildEventRun) PostBuildEvent();
    if (!GenerateBuildDependencyFileRun) GenerateBuildDependencyFile();
    if (!GenerateBuildRuntimeConfigurationFilesRun) GenerateBuildRuntimeConfigurationFiles();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    CoreBuildRun = true;
}

void Rebuild()
{
    // if ( '$(_InvalidConfigurationWarning)' != 'true' )
    if ( '' != 'true' ) { RebuildRun = true; return; }
    // DependsOnTargets;
    if (!_SdkBeforeRebuildRun) _SdkBeforeRebuild();
    if (!BeforeRebuildRun) BeforeRebuild();
    if (!CleanRun) Clean();
    if (!BuildRun) Build();
    if (!AfterRebuildRun) AfterRebuild();
    if (!Run) ();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    RebuildRun = true;
}

void BeforeRebuild()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    BeforeRebuildRun = true;
}

void AfterRebuild()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    AfterRebuildRun = true;
}

void BuildGenerateSources()
{
    // DependsOnTargets;
    if (!BuildGenerateSourcesTraverseRun) BuildGenerateSourcesTraverse();
    if (!BuildRun) Build();
    
    BuildGenerateSourcesRun = true;
}

void BuildGenerateSourcesTraverse()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "BuildGenerateSources", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework);");*/
    /* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != '' and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
    if ('' == 'true' and '' != '' and '' != '' and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
    {
        MSBuild(BuildInParallel: "true", Targets: "BuildGenerateSources", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework);");
    }
    
    BuildGenerateSourcesTraverseRun = true;
}

void BuildCompile()
{
    // DependsOnTargets;
    if (!BuildCompileTraverseRun) BuildCompileTraverse();
    if (!BuildRun) Build();
    
    BuildCompileRun = true;
}

void BuildCompileTraverse()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "BuildCompile", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
    if ('' == 'true' and '' != '' and '' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
    {
        MSBuild(BuildInParallel: "true", Targets: "BuildCompile", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    
    BuildCompileTraverseRun = true;
}

void BuildLink()
{
    // DependsOnTargets;
    if (!BuildLinkTraverseRun) BuildLinkTraverse();
    if (!BuildRun) Build();
    
    BuildLinkRun = true;
}

void BuildLinkTraverse()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "BuildLink", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
    if ('' == 'true' and '' != '' and '' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
    {
        MSBuild(BuildInParallel: "true", Targets: "BuildLink", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    
    BuildLinkTraverseRun = true;
}

void CopyRunEnvironmentFiles()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!SetWin32ManifestPropertiesRun) SetWin32ManifestProperties();
    if (!_CopyAppConfigFileRun) _CopyAppConfigFile();
    if (!_CleanRecordFileWritesRun) _CleanRecordFileWrites();
    
    CopyRunEnvironmentFilesRun = true;
}

void Run()
{
    
    /*Exec(Command: "$(RunCommand) $(RunArguments)", WorkingDirectory: "$(RunWorkingDirectory)");*/
    Exec(Command: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.exe ", WorkingDirectory: "");
    
    RunRun = true;
}

void BuildOnlySettings()
{
    
    BuildingProject = "true";
    BuildOnlySettingsRun = true;
}

void PrepareForBuild()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    if (!AssignLinkMetadataRun) AssignLinkMetadata();
    // BeforeTargets;
    if (!_VerifyPackReleaseConfigurationsRun) _VerifyPackReleaseConfigurations();
    
    /*FindAppConfigFile(TargetPath: "$(TargetFileName).config", PrimaryList: "@(None)", SecondaryList: "@(Content)");*/
    /* if ('$(AppConfig)'=='')*/
    if (''=='')
    {
        FindAppConfigFile(TargetPath: "6 - targets.dll.config", PrimaryList: "", SecondaryList: "");
    }
    /*MakeDir(Directories: "$(OutDir);$(IntermediateOutputPath);@(DocFileItem->'%(RelativeDir)');@(CreateDirectory)");*/
    MakeDir(Directories: "bin\\Debug\\net8.0\\;obj\\Debug\\net8.0\\;;D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\refint\\;obj\\Debug\\net8.0\\ref");
    
    // AfterTargets;
    if (!GenerateGlobalUsingsRun) GenerateGlobalUsings();
    PrepareForBuildRun = true;
}

void GetFrameworkPaths()
{
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetFrameworkRun) _CheckForUnsupportedTargetFramework();
    if (!_CheckForUnsupportedTargetPlatformIdentifierRun) _CheckForUnsupportedTargetPlatformIdentifier();
    
    GetFrameworkPathsRun = true;
}

void GetReferenceAssemblyPaths()
{
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetFrameworkRun) _CheckForUnsupportedTargetFramework();
    if (!_CheckForUnsupportedTargetPlatformIdentifierRun) _CheckForUnsupportedTargetPlatformIdentifier();
    
    GetReferenceAssemblyPathsRun = true;
}

void GetTargetFrameworkMoniker()
{
    
    GetTargetFrameworkMonikerRun = true;
}

void GetTargetFrameworkMonikerDisplayName()
{
    // DependsOnTargets;
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    
    GetTargetFrameworkMonikerDisplayNameRun = true;
}

void GetTargetFrameworkDirectories()
{
    // DependsOnTargets;
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    
    GetTargetFrameworkDirectoriesRun = true;
}

void AssignLinkMetadata()
{
    // if ( '$(SynthesizeLinkMetadata)' == 'true' )
    if ( '' == 'true' ) { AssignLinkMetadataRun = true; return; }
    
    /*AssignLinkMetadata(Items: "@(None)");*/
    /* if ('@(None)' != '' and '%(None.DefiningProjectFullPath)' != '$(MSBuildProjectFullPath)')*/
    if ('' != '' and '%(None.DefiningProjectFullPath)' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\6 - targets.csproj')
    {
        AssignLinkMetadata(Items: "");
    }
    /*AssignLinkMetadata(Items: "@(Content)");*/
    /* if ('@(Content)' != '' and '%(Content.DefiningProjectFullPath)' != '$(MSBuildProjectFullPath)')*/
    if ('' != '' and '%(Content.DefiningProjectFullPath)' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\6 - targets.csproj')
    {
        AssignLinkMetadata(Items: "");
    }
    /*AssignLinkMetadata(Items: "@(Page)");*/
    /* if ('@(Page)' != '' and '%(Page.DefiningProjectFullPath)' != '$(MSBuildProjectFullPath)')*/
    if ('' != '' and '%(Page.DefiningProjectFullPath)' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\6 - targets.csproj')
    {
        AssignLinkMetadata(Items: "");
    }
    /*AssignLinkMetadata(Items: "@(ApplicationDefinition)");*/
    /* if ('@(ApplicationDefinition)' != '' and '%(ApplicationDefinition.DefiningProjectFullPath)' != '$(MSBuildProjectFullPath)')*/
    if ('' != '' and '%(ApplicationDefinition.DefiningProjectFullPath)' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\6 - targets.csproj')
    {
        AssignLinkMetadata(Items: "");
    }
    /*AssignLinkMetadata(Items: "@(EmbeddedResource)");*/
    /* if ('@(EmbeddedResource)' != '' and '%(EmbeddedResource.DefiningProjectFullPath)' != '$(MSBuildProjectFullPath)')*/
    if ('' != '' and '%(EmbeddedResource.DefiningProjectFullPath)' != 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\6 - targets.csproj')
    {
        AssignLinkMetadata(Items: "");
    }
    
    AssignLinkMetadataRun = true;
}

void PreBuildEvent()
{
    // if ('$(PreBuildEvent)'!='')
    if (''!='') { PreBuildEventRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /*Exec(Command: "$(PreBuildEvent)", WorkingDirectory: "$(OutDir)");*/
    Exec(Command: "", WorkingDirectory: "bin\\Debug\\net8.0\\");
    
    // AfterTargets;
    if (!_BlockWinMDsOnUnsupportedTFMsRun) _BlockWinMDsOnUnsupportedTFMs();
    PreBuildEventRun = true;
}

void UnmanagedUnregistration()
{
    // if ((('$(_AssemblyTimestampBeforeCompile)' != '$(_AssemblyTimestampAfterCompile)' or '$(RegisterForComInterop)' != 'true' or '$(OutputType)' != 'library') or
                    ('$(_AssemblyTimestampBeforeCompile)' == '')) and
                   Exists('@(_UnmanagedRegistrationCache)'))
    if ((('' != '' or '' != 'true' or 'Exe' != 'library') or
                    ('' == '')) and
                   Exists('obj\6 - targets.csproj.UnmanagedRegistration.cache')) { UnmanagedUnregistrationRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    /* if ('$(UnregisterAssemblyMSBuildArchitecture)' == '')*/
    if ('' == '')
    {
        UnregisterAssemblyMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /* if ('$(TargetFrameworkAsMSBuildRuntime)' != '' and '$(UnregisterAssemblyMSBuildArchitecture)' != '')*/
    if ('' != '' and '' != '')
    {
        /* if ('$(UnregisterAssemblyMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(UnregisterAssemblyMSBuildArchitecture)`)))*/
        if ('$(UnregisterAssemblyMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(UnregisterAssemblyMSBuildArchitecture)`)))
        {
            UnregisterAssemblyMSBuildRuntime = "$(TargetFrameworkAsMSBuildRuntime)";
        }
        /* if ('$(UnregisterAssemblyMSBuildRuntime)' == '')*/
        if ('' == '')
        {
            UnregisterAssemblyMSBuildRuntime = "CurrentRuntime";
        }
    }
    /*UnregisterAssembly(AssemblyListFile: "@(_UnmanagedRegistrationCache)");*/
    UnregisterAssembly(AssemblyListFile: "obj\\6 - targets.csproj.UnmanagedRegistration.cache");
    
    UnmanagedUnregistrationRun = true;
}

void GetTargetFrameworkVersion()
{
    
    GetTargetFrameworkVersionRun = true;
}

void ResolveReferences()
{
    // DependsOnTargets;
    if (!BeforeResolveReferencesRun) BeforeResolveReferences();
    if (!AssignProjectConfigurationRun) AssignProjectConfiguration();
    if (!ResolveProjectReferencesRun) ResolveProjectReferences();
    if (!FindInvalidProjectReferencesRun) FindInvalidProjectReferences();
    if (!ResolveNativeReferencesRun) ResolveNativeReferences();
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    if (!GenerateBindingRedirectsRun) GenerateBindingRedirects();
    if (!GenerateBindingRedirectsUpdateAppConfigRun) GenerateBindingRedirectsUpdateAppConfig();
    if (!ResolveComReferencesRun) ResolveComReferences();
    if (!AfterResolveReferencesRun) AfterResolveReferences();
    
    ResolveReferencesRun = true;
}

void BeforeResolveReferences()
{
    
    BeforeResolveReferencesRun = true;
}

void AfterResolveReferences()
{
    
    AfterResolveReferencesRun = true;
}

void IgnoreJavaScriptOutputAssembly()
{
    // if ($([MSBuild]::AreFeaturesEnabled('17.8')))
    if (True) { IgnoreJavaScriptOutputAssemblyRun = true; return; }
    
    IgnoreJavaScriptOutputAssemblyRun = true;
}

void AssignProjectConfiguration()
{
    // if ('$(CurrentSolutionConfigurationContents)' != '' or '@(ProjectReference)'!='')
    if ('' != '' or ''!='') { AssignProjectConfigurationRun = true; return; }
    // BeforeTargets;
    if (!IgnoreJavaScriptOutputAssemblyRun) IgnoreJavaScriptOutputAssembly();
    if (!ResolvePackageDependenciesForBuildRun) ResolvePackageDependenciesForBuild();
    
    /* if ('$(OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration)' == '')*/
    if ('' == '')
    {
        OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration = "true";
    }
    /* if ('$(ShouldUnsetParentConfigurationAndPlatform)' == '' and ('$(BuildingInsideVisualStudio)' == 'true' or '$(BuildingSolutionFile)' == 'true'))*/
    if ('' == '' and ('' == 'true' or '' == 'true'))
    {
        ShouldUnsetParentConfigurationAndPlatform = "true";
    }
    /* if ('$(ShouldUnsetParentConfigurationAndPlatform)' == '')*/
    if ('' == '')
    {
        ShouldUnsetParentConfigurationAndPlatform = "false";
    }
    /* if ('$(AddSyntheticProjectReferencesForSolutionDependencies)' == '' and '$(TargetFrameworkIdentifier)' == 'Silverlight')*/
    if ('' == '' and '.NETCoreApp' == 'Silverlight')
    {
        AddSyntheticProjectReferencesForSolutionDependencies = "false";
    }
    /* if ('$(AddSyntheticProjectReferencesForSolutionDependencies)' == '' and '$(BuildingInsideVisualStudio)' != 'true')*/
    if ('' == '' and '' != 'true')
    {
        AddSyntheticProjectReferencesForSolutionDependencies = "true";
    }
    /*AssignProjectConfiguration(CurrentProjectPlatform: "$(Platform)", CurrentProject: "$(MSBuildProjectFullPath)", OutputType: "$(OutputType)", ResolveConfigurationPlatformUsingMappings: "false", AddSyntheticProjectReferencesForSolutionDependencies: "$(AddSyntheticProjectReferencesForSolutionDependencies)", VcxToDefaultPlatformMapping: "$(VcxToDefaultPlatformMapping)", OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration: "$(OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration)", ShouldUnsetParentConfigurationAndPlatform: "$(ShouldUnsetParentConfigurationAndPlatform)", CurrentProjectConfiguration: "$(Configuration)", ProjectReferences: "@(ProjectReference)", SolutionConfigurationContents: "$(CurrentSolutionConfigurationContents)", DefaultToVcxPlatformMapping: "$(DefaultToVcxPlatformMapping)");*/
    AssignProjectConfiguration(CurrentProjectPlatform: "AnyCPU", CurrentProject: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", OutputType: "Exe", ResolveConfigurationPlatformUsingMappings: "false", AddSyntheticProjectReferencesForSolutionDependencies: "", VcxToDefaultPlatformMapping: "", OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration: "", ShouldUnsetParentConfigurationAndPlatform: "", CurrentProjectConfiguration: "Debug", ProjectReferences: "", SolutionConfigurationContents: "", DefaultToVcxPlatformMapping: "");
    
    AssignProjectConfigurationRun = true;
}

void _SplitProjectReferencesByFileExistence()
{
    
    /*ResolveNonMSBuildProjectOutput(PreresolvedProjectOutputs: "$(VSIDEResolvedNonMSBuildProjectOutputs)", ProjectReferences: "@(ProjectReferenceWithConfiguration)");*/
    /* if ('$(BuildingInsideVisualStudio)'=='true' and '@(ProjectReferenceWithConfiguration)'!='')*/
    if (''=='true' and ''!='')
    {
        ResolveNonMSBuildProjectOutput(PreresolvedProjectOutputs: "", ProjectReferences: "");
    }
    
    _SplitProjectReferencesByFileExistenceRun = true;
}

void _GetProjectReferencePlatformProperties()
{
    // if ('$(EnableDynamicPlatformResolution)' == 'true'
                     and '@(_MSBuildProjectReferenceExistent)' != '')
    if ('' == 'true'
                     and '' != '') { _GetProjectReferencePlatformPropertiesRun = true; return; }
    
    /*GetCompatiblePlatform(AnnotatedProjects: "@(_ProjectReferencePlatformPossibilities)", CurrentProjectPlatform: "$(Platform)", PlatformLookupTable: "$(PlatformLookupTable)");*/
    /* if ('@(_ProjectReferencePlatformPossibilities)' != '')*/
    if ('' != '')
    {
        GetCompatiblePlatform(AnnotatedProjects: "", CurrentProjectPlatform: "AnyCPU", PlatformLookupTable: "");
    }
    
    _GetProjectReferencePlatformPropertiesRun = true;
}

void _GetProjectReferenceTargetFrameworkProperties()
{
    // DependsOnTargets;
    if (!_AddOutputPathToGlobalPropertiesToRemoveRun) _AddOutputPathToGlobalPropertiesToRemove();
    
    /* if ('$(ReferringTargetFrameworkForProjectReferences)' == '')*/
    if ('' == '')
    {
        /* if ('$(NuGetTargetMoniker)' != '' and !$(NuGetTargetMoniker.Contains(';')))*/
        if ('.NETCoreApp,Version=v8.0' != '' and !False)
        {
            ReferringTargetFrameworkForProjectReferences = "$(NuGetTargetMoniker)";
        }
        /* if ('$(NuGetTargetMoniker)' == '')*/
        if ('.NETCoreApp,Version=v8.0' == '')
        {
            ReferringTargetFrameworkForProjectReferences = "$(TargetFrameworkMoniker)";
        }
    }
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", SkipNonexistentTargets: "true", Targets: "GetTargetFrameworks", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '$(EnableDynamicPlatformResolution)' != 'true')*/
    if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '' != 'true')
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "GetTargetFrameworks", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform)");
    }
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", SkipNonexistentTargets: "true", Targets: "GetTargetFrameworks", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;Platform;Configuration;$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '$(EnableDynamicPlatformResolution)' == 'true')*/
    if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '' == 'true')
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "GetTargetFrameworks", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;Platform;Configuration;", Projects: "");
    }
    /*GetReferenceNearestTargetFrameworkTask(CurrentProjectTargetPlatform: "$(TargetPlatformMoniker)", CurrentProjectName: "$(MSBuildProjectName)", CurrentProjectTargetFramework: "$(ReferringTargetFrameworkForProjectReferences)", AnnotatedProjectReferences: "@(_ProjectReferenceTargetFrameworkPossibilities)", FallbackTargetFrameworks: "$(AssetTargetFallback)");*/
    /* if ('@(_ProjectReferenceTargetFrameworkPossibilities)' != '' and '$(ReferringTargetFrameworkForProjectReferences)' != ''
                                                        And '$(GetReferenceNearestTargetFrameworkTaskSupportsTargetPlatformParameter)' == 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')*/
    if ('' != '' and '' != ''
                                                        And 'true' == 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')
    {
        GetReferenceNearestTargetFrameworkTask(CurrentProjectTargetPlatform: "", CurrentProjectName: "6 - targets", CurrentProjectTargetFramework: "", AnnotatedProjectReferences: "", FallbackTargetFrameworks: ";net461;net462;net47;net471;net472;net48;net481");
    }
    /*GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "$(MSBuildProjectName)", CurrentProjectTargetFramework: "$(ReferringTargetFrameworkForProjectReferences)", AnnotatedProjectReferences: "@(_ProjectReferenceTargetFrameworkPossibilities)", FallbackTargetFrameworks: "$(AssetTargetFallback)");*/
    /* if ('@(_ProjectReferenceTargetFrameworkPossibilities)' != '' and '$(ReferringTargetFrameworkForProjectReferences)' != ''
                                                        And '$(GetReferenceNearestTargetFrameworkTaskSupportsTargetPlatformParameter)' != 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')*/
    if ('' != '' and '' != ''
                                                        And 'true' != 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')
    {
        GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "6 - targets", CurrentProjectTargetFramework: "", AnnotatedProjectReferences: "", FallbackTargetFrameworks: ";net461;net462;net47;net471;net472;net48;net481");
    }
    /*SetRidAgnosticValueForProjects(Projects: "@(AnnotatedProjects)");*/
    SetRidAgnosticValueForProjects(Projects: "");
    
    // AfterTargets;
    if (!ValidateExecutableReferencesRun) ValidateExecutableReferences();
    _GetProjectReferenceTargetFrameworkPropertiesRun = true;
}

void GetTargetFrameworks()
{
    // DependsOnTargets;
    if (!GetTargetFrameworksWithPlatformForSingleTargetFrameworkRun) GetTargetFrameworksWithPlatformForSingleTargetFramework();
    
    /* if ('$(IsCrossTargetingBuild)' == 'true')*/
    if ('' == 'true')
    {
        Error(Text: "Internal MSBuild error: Non-CrossTargeting GetTargetFrameworks target should not be used in cross targeting (outer) build");
    }
    /*CombineXmlElements(XmlElements: "@(_TargetFrameworkInfo->'%(AdditionalPropertiesFromProject)')", RootElementName: "AdditionalProjectProperties");*/
    CombineXmlElements(XmlElements: "", RootElementName: "AdditionalProjectProperties");
    
    GetTargetFrameworksRun = true;
}

void GetTargetFrameworksWithPlatformForSingleTargetFramework()
{
    
    /* if ('$(_UseAttributeForTargetFrameworkInfoPropertyNames)' == '')*/
    if ('true' == '')
    {
        _UseAttributeForTargetFrameworkInfoPropertyNames = "false";
    }
    /*CombineTargetFrameworkInfoProperties(UseAttributeForTargetFrameworkInfoPropertyNames: "$(_UseAttributeForTargetFrameworkInfoPropertyNames)", RootElementName: "$(TargetFramework)", PropertiesAndValues: "@(_AdditionalTargetFrameworkInfoPropertyWithValue)");*/
    CombineTargetFrameworkInfoProperties(UseAttributeForTargetFrameworkInfoPropertyNames: "true", RootElementName: "net8.0", PropertiesAndValues: "");
    
    GetTargetFrameworksWithPlatformForSingleTargetFrameworkRun = true;
}

void GetTargetFrameworkProperties()
{
    
    GetTargetFrameworkPropertiesRun = true;
}

void PrepareProjectReferences()
{
    // DependsOnTargets;
    if (!AssignProjectConfigurationRun) AssignProjectConfiguration();
    if (!_SplitProjectReferencesByFileExistenceRun) _SplitProjectReferencesByFileExistence();
    if (!_GetProjectReferenceTargetFrameworkPropertiesRun) _GetProjectReferenceTargetFrameworkProperties();
    if (!_GetProjectReferencePlatformPropertiesRun) _GetProjectReferencePlatformProperties();
    
    PrepareProjectReferencesRun = true;
}

void ResolveProjectReferences()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "GetTargetPath", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and ('$(BuildingInsideVisualStudio)' == 'true' or '$(BuildProjectReferences)' != 'true') and '$(VisualStudioVersion)' != '10.0' and '@(_MSBuildProjectReferenceExistent)' != '')*/
    if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and ('' == 'true' or 'true' != 'true') and '17.0' != '10.0' and '' != '')
    {
        MSBuild(BuildInParallel: "true", Targets: "GetTargetPath", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "%(_MSBuildProjectReferenceExistent.Targets)", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform);  %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '$(BuildingInsideVisualStudio)' != 'true' and '$(BuildProjectReferences)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
    if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and '' != 'true' and 'true' == 'true' and '' != '')
    {
        MSBuild(BuildInParallel: "true", Targets: "%(_MSBuildProjectReferenceExistent.Targets)", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform);  %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", SkipNonexistentTargets: "true", Targets: "GetNativeManifest", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '$(BuildingProject)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
    if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and 'false' == 'true' and '' != '')
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "GetNativeManifest", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    /* if ('@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceNonexistent)' != '')*/
    if ('' != '' and '' != '')
    {
        Warning(Text: "The referenced project '%(_MSBuildProjectReferenceNonexistent.Identity)' does not exist.");
    }
    
    ResolveProjectReferencesRun = true;
}

void ResolveProjectReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ResolveProjectReferencesRun) ResolveProjectReferences();
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    ResolveProjectReferencesDesignTimeRun = true;
}

void ExpandSDKReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ExpandSDKReferencesRun) ExpandSDKReferences();
    
    ExpandSDKReferencesDesignTimeRun = true;
}

void GetTargetPath()
{
    // DependsOnTargets;
    if (!Run) ();
    // BeforeTargets;
    if (!GetTargetPathWithTargetPlatformMonikerRun) GetTargetPathWithTargetPlatformMoniker();
    
    GetTargetPathRun = true;
}

void GetTargetPathWithTargetPlatformMoniker()
{
    // DependsOnTargets;
    if (!Run) ();
    
    GetTargetPathWithTargetPlatformMonikerRun = true;
}

void GetNativeManifest()
{
    
    GetNativeManifestRun = true;
}

void ResolveNativeReferences()
{
    // if ('@(NativeReference)'!='')
    if (''!='') { ResolveNativeReferencesRun = true; return; }
    // DependsOnTargets;
    if (!ResolveProjectReferencesRun) ResolveProjectReferences();
    
    /*ResolveNativeReference(AdditionalSearchPaths: "$(ReferencePath);$(OutDir)", NativeReferences: "@(NativeReference)");*/
    ResolveNativeReference(AdditionalSearchPaths: ";bin\\Debug\\net8.0\\", NativeReferences: "");
    
    ResolveNativeReferencesRun = true;
}

void ResolveAssemblyReferences()
{
    // DependsOnTargets;
    if (!ResolveProjectReferencesRun) ResolveProjectReferences();
    if (!FindInvalidProjectReferencesRun) FindInvalidProjectReferences();
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!ResolveSDKReferencesRun) ResolveSDKReferences();
    if (!ExpandSDKReferencesRun) ExpandSDKReferences();
    if (!Run) ();
    if (!ResolvePackageDependenciesForBuildRun) ResolvePackageDependenciesForBuild();
    if (!_HandlePackageFileConflictsRun) _HandlePackageFileConflicts();
    if (!Run) ();
    if (!ResolveTargetingPackAssetsRun) ResolveTargetingPackAssets();
    if (!Run) ();
    
    /* if ('$(DisableRarCache)'!='true' and '$(ResolveAssemblyReferencesStateFile)' == '')*/
    if (''!='true' and '' == '')
    {
        ResolveAssemblyReferencesStateFile = "$(IntermediateOutputPath)$(MSBuildProjectFile).AssemblyReference.cache";
    }
    /* if ('$(BuildingProject)' != 'true' and '$(_ResolveReferenceDependencies)' != 'true')*/
    if ('false' != 'true' and 'false' != 'true')
    {
        _FindDependencies = "false";
    }
    /* if ('$(ResolveAssemblyReferencesSilent)' == '' and '$(TraceDesignTime)' != 'true' and '$(BuildingProject)' == 'false')*/
    if ('' == '' and '' != 'true' and 'false' == 'false')
    {
        ResolveAssemblyReferencesSilent = "true";
    }
    /* if ('$(ResolveAssemblyReferencesSilent)' == '')*/
    if ('' == '')
    {
        ResolveAssemblyReferencesSilent = "false";
    }
    /* if ('$(ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch)' == '')*/
    if ('' == '')
    {
        ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch = "Warning";
    }
    /* if ('$(ResolveAssemblyReferencesFindRelatedSatellites)' == '')*/
    if ('' == '')
    {
        ResolveAssemblyReferencesFindRelatedSatellites = "$(BuildingProject)";
    }
    /* if ('$(ResolveAssemblyReferencesFindSerializationAssemblies)' == '')*/
    if ('' == '')
    {
        ResolveAssemblyReferencesFindSerializationAssemblies = "$(BuildingProject)";
    }
    /* if ('$(ResolveAssemblyReferencesFindRelatedFiles)' == '')*/
    if ('' == '')
    {
        ResolveAssemblyReferencesFindRelatedFiles = "$(BuildingProject)";
    }
    /* if ('$(ResolveAssemblyReferenceOutputUnresolvedAssemblyConflicts)' == '')*/
    if ('true' == '')
    {
        ResolveAssemblyReferenceOutputUnresolvedAssemblyConflicts = "false";
    }
    /* if ('$(FindDependenciesOfExternallyResolvedReferences)' == '')*/
    if ('' == '')
    {
        FindDependenciesOfExternallyResolvedReferences = "false";
        /* if ('$(AutoGenerateBindingRedirects)' == 'true')*/
        if ('' == 'true')
        {
            FindDependenciesOfExternallyResolvedReferences = "true";
        }
    }
    /*ResolveAssemblyReference(SearchPaths: "$(AssemblySearchPaths)", ResolvedSDKReferences: "@(ResolvedSDKReference)", IgnoreDefaultInstalledAssemblySubsetTables: "$(IgnoreInstalledAssemblySubsetTables)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", FullTargetFrameworkSubsetNames: "$(FullReferenceAssemblyNames)", CopyLocalDependenciesWhenParentReferenceInGac: "$(CopyLocalDependenciesWhenParentReferenceInGac)", InstalledAssemblySubsetTables: "@(InstalledAssemblySubsetTables)", StateFile: "$(ResolveAssemblyReferencesStateFile)", AssemblyInformationCacheOutputPath: "$(AssemblyInformationCacheOutputPath)", TargetFrameworkDirectories: "@(_ReferenceInstalledAssemblyDirectory)", TargetedRuntimeVersion: "$(TargetedRuntimeVersion)", LatestTargetFrameworkDirectories: "@(LatestTargetFrameworkDirectories)", IgnoreDefaultInstalledAssemblyTables: "$(IgnoreDefaultInstalledAssemblyTables)", FindDependencies: "$(_FindDependencies)", OutputUnresolvedAssemblyConflicts: "$(ResolveAssemblyReferenceOutputUnresolvedAssemblyConflicts)", WarnOrErrorOnTargetArchitectureMismatch: "$(ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch)", AutoUnify: "$(AutoUnifyAssemblyReferences)", InstalledAssemblyTables: "@(InstalledAssemblyTables);@(RedistList)", IgnoreTargetFrameworkAttributeVersionMismatch: "$(ResolveAssemblyReferenceIgnoreTargetFrameworkAttributeVersionMismatch)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", AssemblyInformationCachePaths: "$(AssemblyInformationCachePaths)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", DoNotCopyLocalIfInGac: "$(DoNotCopyLocalIfInGac)", Silent: "$(ResolveAssemblyReferencesSilent)", AppConfigFile: "@(_ResolveAssemblyReferencesApplicationConfigFileForExes)", SupportsBindingRedirectGeneration: "$(GenerateBindingRedirectsOutputType)", FindDependenciesOfExternallyResolvedReferences: "$(FindDependenciesOfExternallyResolvedReferences)", IgnoreVersionForFrameworkReferences: "$(IgnoreVersionForFrameworkReferences)", AllowedAssemblyExtensions: "$(AllowedReferenceAssemblyFileExtensions)", FullFrameworkFolders: "$(_FullFrameworkReferenceAssemblyPaths)", TargetFrameworkMonikerDisplayName: "$(TargetFrameworkMonikerDisplayName)", TargetFrameworkSubsets: "@(_ReferenceInstalledAssemblySubsets)", AssemblyFiles: "@(_ResolvedProjectReferencePaths);@(_ExplicitReference)", FindSerializationAssemblies: "$(ResolveAssemblyReferencesFindSerializationAssemblies)", FindRelatedFiles: "$(ResolveAssemblyReferencesFindRelatedFiles)", Assemblies: "@(Reference)", FindSatellites: "$(ResolveAssemblyReferencesFindRelatedSatellites)", ProfileName: "$(TargetFrameworkProfile)", AllowedRelatedFileExtensions: "$(AllowedReferenceRelatedFileExtensions)", CandidateAssemblyFiles: "@(Content);@(None)", FullFrameworkAssemblyTables: "@(FullFrameworkAssemblyTables)");*/
    /* if ('@(Reference)'!='' or '@(_ResolvedProjectReferencePaths)'!='' or '@(_ExplicitReference)' != '')*/
    if (''!='' or ''!='' or '' != '')
    {
        ResolveAssemblyReference(SearchPaths: "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}", ResolvedSDKReferences: "", IgnoreDefaultInstalledAssemblySubsetTables: "", TargetFrameworkVersion: "v8.0", FullTargetFrameworkSubsetNames: "Full", CopyLocalDependenciesWhenParentReferenceInGac: "", InstalledAssemblySubsetTables: "", StateFile: "", AssemblyInformationCacheOutputPath: "", TargetFrameworkDirectories: "", TargetedRuntimeVersion: "", LatestTargetFrameworkDirectories: "", IgnoreDefaultInstalledAssemblyTables: "", FindDependencies: "", OutputUnresolvedAssemblyConflicts: "true", WarnOrErrorOnTargetArchitectureMismatch: "", AutoUnify: "true", InstalledAssemblyTables: ";", IgnoreTargetFrameworkAttributeVersionMismatch: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", AssemblyInformationCachePaths: "", TargetProcessorArchitecture: "msil", DoNotCopyLocalIfInGac: "", Silent: "", AppConfigFile: "", SupportsBindingRedirectGeneration: "true", FindDependenciesOfExternallyResolvedReferences: "", IgnoreVersionForFrameworkReferences: "", AllowedAssemblyExtensions: """
      .winmd;
      .dll;
      .exe
    """, FullFrameworkFolders: "", TargetFrameworkMonikerDisplayName: ".NET 8.0", TargetFrameworkSubsets: "", AssemblyFiles: ";", FindSerializationAssemblies: "", FindRelatedFiles: "", Assemblies: "", FindSatellites: "", ProfileName: "", AllowedRelatedFileExtensions: """
      .pdb;
      .xml;
      .pri;
      .dll.config;
      .exe.config
    """, CandidateAssemblyFiles: ";", FullFrameworkAssemblyTables: "");
    }
    
    ResolveAssemblyReferencesRun = true;
}

void FindReferenceAssembliesForReferences()
{
    // DependsOnTargets;
    if (!ResolveReferencesRun) ResolveReferences();
    
    FindReferenceAssembliesForReferencesRun = true;
}

void GenerateBindingRedirects()
{
    // if ('$(AutoGenerateBindingRedirects)' == 'true' and '$(GenerateBindingRedirectsOutputType)' == 'true' and '@(SuggestedBindingRedirects)' != '' and '$(DesignTimeBuild)' != 'true' and '$(BuildingProject)' == 'true')
    if ('' == 'true' and 'true' == 'true' and '' != '' and '' != 'true' and 'false' == 'true') { GenerateBindingRedirectsRun = true; return; }
    // DependsOnTargets;
    if (!_GenerateSuggestedBindingRedirectsCacheRun) _GenerateSuggestedBindingRedirectsCache();
    // BeforeTargets;
    if (!GenerateSupportedRuntimeRun) GenerateSupportedRuntime();
    
    /*GenerateBindingRedirects(TargetName: "$(TargetFileName).config", OutputAppConfigFile: "$(_GenerateBindingRedirectsIntermediateAppConfig)", AppConfigFile: "@(AppConfigWithTargetPath)", SuggestedRedirects: "@(SuggestedBindingRedirects)");*/
    GenerateBindingRedirects(TargetName: "6 - targets.dll.config", OutputAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.config", AppConfigFile: "", SuggestedRedirects: "");
    
    GenerateBindingRedirectsRun = true;
}

void GenerateBindingRedirectsUpdateAppConfig()
{
    // if ('$(AutoGenerateBindingRedirects)' == 'true' and '$(GenerateBindingRedirectsOutputType)' == 'true')
    if ('' == 'true' and 'true' == 'true') { GenerateBindingRedirectsUpdateAppConfigRun = true; return; }
    
    /* if (Exists('$(_GenerateBindingRedirectsIntermediateAppConfig)'))*/
    if (Exists('obj\Debug\net8.0\6 - targets.dll.config'))
    {
        _NewGenerateBindingRedirectsIntermediateAppConfig = "true";
    }
    /* if ($(_NewGenerateBindingRedirectsIntermediateAppConfig) == 'true')*/
    if ( == 'true')
    {
        AppConfig = "$(_GenerateBindingRedirectsIntermediateAppConfig)";
    }
    GenerateBindingRedirectsUpdateAppConfigRun = true;
}

void GetInstalledSDKLocations()
{
    // if ('@(SDKReference)' != '')
    if ('' != '') { GetInstalledSDKLocationsRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /*GetInstalledSDKLocations(SDKRegistryRoot: "$(SDKReferenceRegistryRoot)", SDKExtensionDirectoryRoots: "$(SDKExtensionDirectoryRoot)", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)");*/
    GetInstalledSDKLocations(SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "");
    /*GetInstalledSDKLocations(SDKRegistryRoot: "$(SDKReferenceRegistryRoot)", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifierWindows81)", TargetPlatformVersion: "$(TargetPlatformVersionWindows81)", WarnWhenNoSDKsFound: "false");*/
    /* if ('$(SupportWindows81SDKs)' == 'true' and '$(TargetPlatformIdentifierWindows81)' != '' and '$(TargetPlatformVersionWindows81)' != '')*/
    if ('' == 'true' and '' != '' and '' != '')
    {
        GetInstalledSDKLocations(SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "", WarnWhenNoSDKsFound: "false");
    }
    /*GetInstalledSDKLocations(SDKRegistryRoot: "$(SDKReferenceRegistryRoot)", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifierWindowsPhone81)", TargetPlatformVersion: "$(TargetPlatformVersionWindowsPhone81)", WarnWhenNoSDKsFound: "false");*/
    /* if ('$(SupportWindowsPhone81SDKs)' == 'true' and '$(TargetPlatformIdentifierWindowsPhone81)' != '' and '$(TargetPlatformVersionWindowsPhone81)' != '')*/
    if ('' == 'true' and '' != '' and '' != '')
    {
        GetInstalledSDKLocations(SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "", WarnWhenNoSDKsFound: "false");
    }
    
    GetInstalledSDKLocationsRun = true;
}

void ResolveSDKReferences()
{
    // DependsOnTargets;
    if (!GetInstalledSDKLocationsRun) GetInstalledSDKLocations();
    
    /*ResolveSDKReference(ProjectName: "$(MSBuildProjectName)", SDKReferences: "@(SDKReference)", InstalledSDKs: "@(InstalledSDKLocations)", TargetedSDKArchitecture: "$(TargetedSDKArchitecture)", Prefer32Bit: "$(Prefer32Bit)", RuntimeReferenceOnlySDKDependencies: "@(RuntimeReferenceOnlySDKDependencies)", LogResolutionErrorsAsWarnings: "$(LogSDKReferenceResolutionErrorsAsWarnings)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", References: "@(Reference)", TargetedSDKConfiguration: "$(TargetedSDKConfiguration)", WarnOnMissingPlatformVersion: "$(SDKReferenceWarnOnMissingMaxPlatformVersion)");*/
    /* if ('@(SDKReference)'!='')*/
    if (''!='')
    {
        ResolveSDKReference(ProjectName: "6 - targets", SDKReferences: "", InstalledSDKs: "", TargetedSDKArchitecture: "msil", Prefer32Bit: "false", RuntimeReferenceOnlySDKDependencies: "", LogResolutionErrorsAsWarnings: "", TargetPlatformIdentifier: "", TargetPlatformVersion: "", References: "", TargetedSDKConfiguration: "Debug", WarnOnMissingPlatformVersion: "");
    }
    
    ResolveSDKReferencesRun = true;
}

void ResolveSDKReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ResolveSDKReferencesRun) ResolveSDKReferences();
    
    ResolveSDKReferencesDesignTimeRun = true;
}

void FindInvalidProjectReferences()
{
    // if ('$(FindInvalidProjectReferences)' == 'true')
    if ('' == 'true') { FindInvalidProjectReferencesRun = true; return; }
    // DependsOnTargets;
    if (!GetReferenceTargetPlatformMonikersRun) GetReferenceTargetPlatformMonikers();
    
    /*FindInvalidProjectReferences(TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", ProjectReferences: "@(TargetPathWithTargetPlatformMoniker)");*/
    FindInvalidProjectReferences(TargetPlatformIdentifier: "", TargetPlatformVersion: "", ProjectReferences: "");
    
    FindInvalidProjectReferencesRun = true;
}

void GetReferenceTargetPlatformMonikers()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "GetTargetPathWithTargetPlatformMoniker", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    MSBuild(BuildInParallel: "true", Targets: "GetTargetPathWithTargetPlatformMoniker", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    
    GetReferenceTargetPlatformMonikersRun = true;
}

void ExpandSDKReferences()
{
    // DependsOnTargets;
    if (!ResolveSDKReferencesRun) ResolveSDKReferences();
    
    /*GetSDKReferenceFiles(ResolvedSDKReferences: "@(ResolvedSDKReference)", LogRedistConflictWithinSDKAsWarning: "$(GetSDKReferenceFilesLogRedistConflictsWithinSDKAsWarning)", LogReferenceConflictBetweenSDKsAsWarning: "$(GetSDKReferenceFilesLogReferenceConflictsBetweenSDKsAsWarning)", LogRedistFilesList: "$(GetSDKReferenceFilesLogRedistFilesList)", LogReferencesList: "$(GetSDKReferenceFilesLogReferencesList)", TargetSDKVersion: "$(SDKVersion)", LogReferenceConflictWithinSDKAsWarning: "$(GetSDKReferenceFilesLogReferenceConflictsWithinSDKAsWarning)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", LogRedistConflictBetweenSDKsAsWarning: "$(GetSDKReferenceFilesLogRedistConflictsBetweenSDKsAsWarning)", CacheFileFolderPath: "$(GetSDKReferenceFilesCacheFolder)", LogCacheFileExceptions: "$(GetSDKReferenceFilesLogCacheFileExceptions)", TargetSDKIdentifier: "$(SDKIdentifier)", ReferenceExtensions: "$(ExpandSDKAllowedReferenceExtensions)");*/
    /* if ('@(ResolvedSDKReference)'!='')*/
    if (''!='')
    {
        GetSDKReferenceFiles(ResolvedSDKReferences: "", LogRedistConflictWithinSDKAsWarning: "", LogReferenceConflictBetweenSDKsAsWarning: "", LogRedistFilesList: "", LogReferencesList: "", TargetSDKVersion: "", LogReferenceConflictWithinSDKAsWarning: "", TargetPlatformIdentifier: "", TargetPlatformVersion: "", LogRedistConflictBetweenSDKsAsWarning: "", CacheFileFolderPath: "", LogCacheFileExceptions: "", TargetSDKIdentifier: "", ReferenceExtensions: """
      .winmd;
      .dll
    """);
    }
    
    ExpandSDKReferencesRun = true;
}

void ExportWindowsMDFile()
{
    // if ('$(ExportWinMDFile)' == 'true')
    if ('' == 'true') { ExportWindowsMDFileRun = true; return; }
    // DependsOnTargets;
    if (!CompileRun) Compile();
    
    CopyBuildOutputToOutputDirectory = "false";
    CopyOutputSymbolsToOutputDirectory = "false";
    CopyDocumentationFileToOutputDirectory = "false";
    /* if ('$(WinMdExpToolPath)' == '')*/
    if ('' == '')
    {
        WinMdExpToolPath = "$(TargetFrameworkSDKToolsDirectory)";
    }
    /* if ('$(WinMdExpUTF8Ouput)' == '')*/
    if ('' == '')
    {
        WinMdExpUTF8Ouput = "true";
    }
    /*WinMDExp(WinMDModule: "@(IntermediateAssembly)", InputDocumentationFile: "@(DocFileItem)", AssemblyUnificationPolicy: "$(WinMDExpAssemblyUnificationPolicy)", DisabledWarnings: "$(WinMdExpNoWarn)", SdkToolsPath: "$(WinMdExpToolPath)", InputPDBFile: "@(_DebugSymbolsIntermediatePath)", OutputWindowsMetadataFile: "$(_IntermediateWindowsMetadataPath)", OutputDocumentationFile: "$(WinMDOutputDocumentationFile)", UTF8Output: "$(WinMdExpUTF8Ouput)", References: "@(ReferencePathWithRefAssemblies)", OutputPDBFile: "$(WinMDExpOutputPdb)", EnvironmentVariables: "$(WinMDExpEnvironment)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
    WinMDExp(WinMDModule: "obj\\Debug\\net8.0\\6 - targets.dll", InputDocumentationFile: "", AssemblyUnificationPolicy: "", DisabledWarnings: "", SdkToolsPath: "", InputPDBFile: "obj\\Debug\\net8.0\\6 - targets.pdb", OutputWindowsMetadataFile: "", OutputDocumentationFile: "", UTF8Output: "", References: "", OutputPDBFile: "", EnvironmentVariables: "", TreatWarningsAsErrors: "false");
    
    ExportWindowsMDFileRun = true;
}

void ResolveAssemblyReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ResolveProjectReferencesRun) ResolveProjectReferences();
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    ResolveAssemblyReferencesDesignTimeRun = true;
}

void DesignTimeResolveAssemblyReferences()
{
    // if ('$(DesignTimeReference)'!='')
    if (''!='') { DesignTimeResolveAssemblyReferencesRun = true; return; }
    // DependsOnTargets;
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    /* if ('$(DisableRarCache)'!='true')*/
    if (''!='true')
    {
        DesignTimeResolveAssemblyReferencesStateFile = "$(IntermediateOutputPath)$(MSBuildProjectFile)DesignTimeResolveAssemblyReferences.cache";
    }
    /* if ( '$(DesignTimeAssemblySearchPaths)' == '' )*/
    if ( '{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}' == '' )
    {
        DesignTimeAssemblySearchPaths = """
        {CandidateAssemblyFiles};
        $(ReferencePath);
        {HintPathFromItem};
        {TargetFrameworkDirectory};
        {Registry:$(FrameworkRegistryBase),$(TargetFrameworkVersion),$(AssemblyFoldersSuffix)$(AssemblyFoldersExConditions)};
        {RawFileName};
        $(OutDir)
      """;
    }
    /* if ( '$(DesignTimeFindDependencies)' == '' )*/
    if ( '' == '' )
    {
        DesignTimeFindDependencies = "false";
    }
    /* if ( '$(DesignTimeIgnoreVersionForFrameworkReferences)' == '' )*/
    if ( '' == '' )
    {
        DesignTimeIgnoreVersionForFrameworkReferences = "false";
    }
    /* if ( '$(DesignTimeFindSatellites)' == '' )*/
    if ( '' == '' )
    {
        DesignTimeFindSatellites = "false";
    }
    /* if ( '$(DesignTimeFindSerializationAssemblies)' == '' )*/
    if ( '' == '' )
    {
        DesignTimeFindSerializationAssemblies = "false";
    }
    /* if ( '$(DesignTimeFindRelatedFiles)' == '' )*/
    if ( '' == '' )
    {
        DesignTimeFindRelatedFiles = "false";
    }
    /* if ( '$(DesignTimeSilentResolution)' == '' and '$(TraceDesignTime)' != 'true')*/
    if ( '' == '' and '' != 'true')
    {
        DesignTimeSilentResolution = "true";
    }
    /* if ('$(DesignTimeAutoUnify)' == '')*/
    if ('true' == '')
    {
        DesignTimeAutoUnify = "false";
    }
    /*ResolveAssemblyReference(SearchPaths: "$(DesignTimeAssemblySearchPaths)", ResolvedSDKReferences: "@(ResolvedSDKReference)", IgnoreDefaultInstalledAssemblySubsetTables: "$(IgnoreInstalledAssemblySubsetTables)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", FullTargetFrameworkSubsetNames: "$(FullReferenceAssemblyNames)", InstalledAssemblySubsetTables: "@(InstalledAssemblySubsetTables)", StateFile: "$(DesignTimeResolveAssemblyReferencesStateFile)", TargetFrameworkDirectories: "@(_DesignTimeReferenceInstalledAssemblyDirectory)", TargetedRuntimeVersion: "$(TargetedRuntimeVersion)", FindDependencies: "$(DesignTimeFindDependencies)", AutoUnify: "$(DesignTimeAutoUnify)", IgnoreTargetFrameworkAttributeVersionMismatch: "$(DesignTimeIgnoreTargetFrameworkAttributeVersionMismatch)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", Silent: "$(DesignTimeSilentResolution)", IgnoreVersionForFrameworkReferences: "$(DesignTimeIgnoreVersionForFrameworkReferences)", AllowedAssemblyExtensions: "$(AllowedReferenceAssemblyFileExtensions)", FullFrameworkFolders: "$(_FullFrameworkReferenceAssemblyPaths)", TargetFrameworkMonikerDisplayName: "$(TargetFrameworkMonikerDisplayName)", TargetFrameworkSubsets: "@(_ReferenceInstalledAssemblySubsets)", FindSerializationAssemblies: "$(DesignTimeFindSerializationAssemblies)", FindRelatedFiles: "$(DesignTimeFindRelatedFiles)", Assemblies: "@(_DesignTimeReferenceAssemblies)", FindSatellites: "$(DesignTimeFindSatellites)", ProfileName: "$(TargetFrameworkProfile)", CandidateAssemblyFiles: "@(Content);@(None);@(_RARResolvedReferencePath)", FullFrameworkAssemblyTables: "@(FullFrameworkAssemblyTables)");*/
    ResolveAssemblyReference(SearchPaths: "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}", ResolvedSDKReferences: "", IgnoreDefaultInstalledAssemblySubsetTables: "", TargetFrameworkVersion: "v8.0", FullTargetFrameworkSubsetNames: "Full", InstalledAssemblySubsetTables: "", StateFile: "", TargetFrameworkDirectories: "", TargetedRuntimeVersion: "", FindDependencies: "", AutoUnify: "true", IgnoreTargetFrameworkAttributeVersionMismatch: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", TargetProcessorArchitecture: "msil", Silent: "", IgnoreVersionForFrameworkReferences: "", AllowedAssemblyExtensions: """
      .winmd;
      .dll;
      .exe
    """, FullFrameworkFolders: "", TargetFrameworkMonikerDisplayName: ".NET 8.0", TargetFrameworkSubsets: "", FindSerializationAssemblies: "", FindRelatedFiles: "", Assemblies: "", FindSatellites: "", ProfileName: "", CandidateAssemblyFiles: ";;", FullFrameworkAssemblyTables: "");
    
    DesignTimeResolveAssemblyReferencesRun = true;
}

void ResolveComReferences()
{
    // if ('@(COMReference)'!='' or '@(COMFileReference)'!='')
    if (''!='' or ''!='') { ResolveComReferencesRun = true; return; }
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!ResolveKeySourceRun) ResolveKeySource();
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    /* if ( '$(InteropOutputPath)' == '' )*/
    if ( '' == '' )
    {
        InteropOutputPath = "$(IntermediateOutputPath)";
    }
    /* if ('$(ResolveComReferenceMSBuildArchitecture)' == '')*/
    if ('' == '')
    {
        ResolveComReferenceMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /* if ('$(ResolveComReferenceToolPath)' == '')*/
    if ('' == '')
    {
        ResolveComReferenceToolPath = "$(TargetFrameworkSDKToolsDirectory)";
    }
    /* if ('$(ResolveComReferenceSilent)' == '')*/
    if ('' == '')
    {
        ResolveComReferenceSilent = "false";
    }
    /*MakeDir(Directories: "$(InteropOutputPath)");*/
    MakeDir(Directories: "");
    /*ResolveComReference(NoClassMembers: "$(ComReferenceNoClassMembers)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", DelaySign: "$(DelaySign)", StateFile: "@(_ResolveComReferenceCache)", TypeLibNames: "@(COMReference)", ResolvedAssemblyReferences: "@(ReferencePath)", SdkToolsPath: "$(ResolveComReferenceToolPath)", TypeLibFiles: "@(COMFileReference)", KeyFile: "$(KeyOriginatorFile)", KeyContainer: "$(KeyContainerName)", ExecuteAsTool: "$(ComReferenceExecuteAsTool)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", Silent: "$(ResolveComReferenceSilent)", IncludeVersionInInteropName: "$(IncludeVersionInInteropName)", WrapperOutputDirectory: "$(InteropOutputPath)", EnvironmentVariables: "$(ResolveComReferenceEnvironment)");*/
    ResolveComReference(NoClassMembers: "false", TargetFrameworkVersion: "v8.0", DelaySign: "", StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.ResolveComReference.cache", TypeLibNames: "", ResolvedAssemblyReferences: "", SdkToolsPath: "", TypeLibFiles: "", KeyFile: "", KeyContainer: "", ExecuteAsTool: "false", TargetProcessorArchitecture: "msil", Silent: "", IncludeVersionInInteropName: "", WrapperOutputDirectory: "", EnvironmentVariables: "");
    
    ResolveComReferencesRun = true;
}

void _GetAssembliesMetadata()
{
    // if ('@(ReferencePath)'!=''and '$(DesignTimeBuild)' == 'true' )
    if (''!=''and '' == 'true' ) { _GetAssembliesMetadataRun = true; return; }
    // DependsOnTargets;
    if (!ResolveComReferencesRun) ResolveComReferences();
    
    /*GetAssembliesMetadata(AssemblyPaths: "@(ReferencePath)");*/
    GetAssembliesMetadata(AssemblyPaths: "");
    
    _GetAssembliesMetadataRun = true;
}

void ResolveComReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ResolveComReferencesRun) ResolveComReferences();
    
    ResolveComReferencesDesignTimeRun = true;
}

void ResolveFrameworkReferences()
{
    // if ('@(FrameworkReference)' != '')
    if ('Microsoft.NETCore.App' != '') { ResolveFrameworkReferencesRun = true; return; }
    // DependsOnTargets;
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    
    /* if ('@(ResolvedAppHostPack)' != '' And '$(AppHostSourcePath)' == '')*/
    if ('' != '' And '' == '')
    {
        AppHostSourcePath = "@(ResolvedAppHostPack->'%(Path)')";
    }
    /* if ('@(ResolvedSingleFileHostPack)' != '' And '$(SingleFileHostSourcePath)' == '')*/
    if ('' != '' And '' == '')
    {
        SingleFileHostSourcePath = "@(ResolvedSingleFileHostPack->'%(Path)')";
    }
    /* if ('@(ResolvedComHostPack)' != '' And '$(ComHostSourcePath)' == '')*/
    if ('' != '' And '' == '')
    {
        ComHostSourcePath = "@(ResolvedComHostPack->'%(Path)')";
    }
    /* if ('@(ResolvedIjwHostPack)' != '' And '$(IjwHostSourcePath)' == '')*/
    if ('' != '' And '' == '')
    {
        IjwHostSourcePath = "@(ResolvedIjwHostPack->'%(Path)')";
    }
    /*GetPackageDirectory(Items: "@(TargetingPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(AppHostPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(SingleFileHostPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(Crossgen2Pack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(HostILCompilerPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(TargetILCompilerPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(PackAsToolShimAppHostPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(ComHostPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(IjwHostPack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*GetPackageDirectory(Items: "@(RuntimePack)", PackageFolders: "@(AssetsFilePackageFolder)");*/
    GetPackageDirectory(Items: "", PackageFolders: "");
    /*ResolveFrameworkReferences(ResolvedRuntimePacks: "@(ResolvedRuntimePack)", FrameworkReferences: "@(FrameworkReference)", ResolvedTargetingPacks: "@(ResolvedTargetingPack)");*/
    ResolveFrameworkReferences(ResolvedRuntimePacks: "", FrameworkReferences: "Microsoft.NETCore.App", ResolvedTargetingPacks: "");
    
    ResolveFrameworkReferencesRun = true;
}

void PrepareResources()
{
    // DependsOnTargets;
    if (!ResolvePackageDependenciesForBuildRun) ResolvePackageDependenciesForBuild();
    if (!_HandlePackageFileConflictsRun) _HandlePackageFileConflicts();
    if (!Run) ();
    if (!PrepareResourceNamesRun) PrepareResourceNames();
    if (!ResGenRun) ResGen();
    if (!CompileLicxFilesRun) CompileLicxFiles();
    
    PrepareResourcesRun = true;
}

void PrepareResourceNames()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!SplitResourcesByCultureRun) SplitResourcesByCulture();
    if (!CreateManifestResourceNamesRun) CreateManifestResourceNames();
    if (!CreateCustomManifestResourceNamesRun) CreateCustomManifestResourceNames();
    
    PrepareResourceNamesRun = true;
}

void AssignTargetPaths()
{
    // DependsOnTargets;
    if (!Run) ();
    // BeforeTargets;
    if (!CopyAdditionalFilesRun) CopyAdditionalFiles();
    if (!_ComputeNETCoreBuildOutputFilesRun) _ComputeNETCoreBuildOutputFiles();
    
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(EmbeddedResource)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(Content)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(None)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(BaseApplicationManifest)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(None)");*/
    /* if ('@(_DeploymentBaseManifestWithTargetPath)'=='' and '%(None.Extension)'=='.manifest')*/
    if (''=='' and '%(None.Extension)'=='.manifest')
    {
        AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    }
    
    AssignTargetPathsRun = true;
}

void GetItemTargetPaths()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    
    GetItemTargetPathsRun = true;
}

void SplitResourcesByCulture()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    
    /* if ('@(ResxWithNoCulture)'!='')*/
    if (''!='')
    {
        Warning(Text: "ResxWithNoCulture item type is deprecated. Use EmbeddedResource items instead.", Code: "MSB9000");
    }
    /* if ('@(ResxWithCulture)'!='')*/
    if (''!='')
    {
        Warning(Text: "ResxWithCulture item type is deprecated. Use EmbeddedResource items instead.", Code: "MSB9001");
    }
    /* if ('@(NonResxWithCulture)'!='')*/
    if (''!='')
    {
        Warning(Text: "NonResxWithCulture item type is deprecated. Use EmbeddedResource items instead.", Code: "MSB9002");
    }
    /* if ('@(NonResxWithNoCulture)'!='')*/
    if (''!='')
    {
        Warning(Text: "NonResxWithNoCulture item type is deprecated. Use EmbeddedResource items instead.", Code: "MSB9003");
    }
    /*AssignCulture(Files: "@(EmbeddedResource)");*/
    /* if ('%(Extension)'!='.licx')*/
    if ('%(Extension)'!='.licx')
    {
        AssignCulture(Files: "");
    }
    
    SplitResourcesByCultureRun = true;
}

void CreateCustomManifestResourceNames()
{
    // DependsOnTargets;
    if (!Run) ();
    
    CreateCustomManifestResourceNamesRun = true;
}

void ResGen()
{
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    if (!SplitResourcesByCultureRun) SplitResourcesByCulture();
    if (!BeforeResGenRun) BeforeResGen();
    if (!CoreResGenRun) CoreResGen();
    if (!AfterResGenRun) AfterResGen();
    
    ResGenRun = true;
}

void BeforeResGen()
{
    
    BeforeResGenRun = true;
}

void AfterResGen()
{
    
    AfterResGenRun = true;
}

void CoreResGen()
{
    // DependsOnTargets;
    if (!FindReferenceAssembliesForReferencesRun) FindReferenceAssembliesForReferences();
    
    /* if ('$(GenerateResourceMSBuildArchitecture)' == '')*/
    if ('CurrentArchitecture' == '')
    {
        GenerateResourceMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /* if ('$(ResgenToolPath)' == '')*/
    if ('' == '')
    {
        ResgenToolPath = "$(TargetFrameworkSDKToolsDirectory)";
    }
    /* if ('$(TargetFrameworkAsMSBuildRuntime)' != '' and '$(GenerateResourceMSBuildArchitecture)' != '')*/
    if ('' != '' and 'CurrentArchitecture' != '')
    {
        /* if ('$(GenerateResourceMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(GenerateResourceMSBuildArchitecture)`)))*/
        if ('$(GenerateResourceMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(GenerateResourceMSBuildArchitecture)`)))
        {
            GenerateResourceMSBuildRuntime = "$(TargetFrameworkAsMSBuildRuntime)";
        }
        /* if ('$(GenerateResourceMSBuildRuntime)' == '')*/
        if ('CurrentRuntime' == '')
        {
            GenerateResourceMSBuildRuntime = "CurrentRuntime";
        }
    }
    /*GenerateResource(WarnOnBinaryFormatterUse: "$(GenerateResourceWarnOnBinaryFormatterUse)", PublicClass: "%(EmbeddedResource.PublicClass)", StateFile: "$(IntermediateOutputPath)$(MSBuildProjectFile).GenerateResource.cache", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", AdditionalInputs: "$(MSBuildAllProjects)", UsePreserializedResources: "$(GenerateResourceUsePreserializedResources)", SdkToolsPath: "$(ResgenToolPath)", OutputResources: "@(EmbeddedResource->'$(IntermediateOutputPath)%(ManifestResourceName).resources')", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", ExecuteAsTool: "$(ResGenExecuteAsTool)", References: "@(ReferencePathWithRefAssemblies)", Sources: "@(EmbeddedResource)", NeverLockTypeAssemblies: "$(GenerateResourceNeverLockTypeAssemblies)", EnvironmentVariables: "$(ResGenEnvironment)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", UseSourcePath: "$(UseSourcePath)", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)");*/
    /* if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and '$(GenerateResourceMSBuildRuntime)' != 'CLR2')*/
    if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and 'CurrentRuntime' != 'CLR2')
    {
        GenerateResource(WarnOnBinaryFormatterUse: "true", PublicClass: "%(EmbeddedResource.PublicClass)", StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.GenerateResource.cache", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", AdditionalInputs: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Current\\Microsoft.Common.targets\\ImportAfter\\Microsoft.TestPlatform.ImportAfter.targets", UsePreserializedResources: "true", SdkToolsPath: "", OutputResources: "", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", ExecuteAsTool: "false", References: "", Sources: "", NeverLockTypeAssemblies: "", EnvironmentVariables: "", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", UseSourcePath: "true", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)");
    }
    /*GenerateResource(PublicClass: "%(EmbeddedResource.PublicClass)", StateFile: "$(IntermediateOutputPath)$(MSBuildProjectFile).GenerateResource.cache", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", AdditionalInputs: "$(MSBuildAllProjects)", OutputResources: "@(EmbeddedResource->'$(IntermediateOutputPath)%(ManifestResourceName).resources')", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", References: "@(ReferencePath)", Sources: "@(EmbeddedResource)", NeverLockTypeAssemblies: "$(GenerateResourceNeverLockTypeAssemblies)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", UseSourcePath: "$(UseSourcePath)", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)");*/
    /* if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and '$(GenerateResourceMSBuildRuntime)' == 'CLR2')*/
    if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and 'CurrentRuntime' == 'CLR2')
    {
        GenerateResource(PublicClass: "%(EmbeddedResource.PublicClass)", StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.GenerateResource.cache", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", AdditionalInputs: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Current\\Microsoft.Common.targets\\ImportAfter\\Microsoft.TestPlatform.ImportAfter.targets", OutputResources: "", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", References: "", Sources: "", NeverLockTypeAssemblies: "", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", UseSourcePath: "true", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)");
    }
    
    CoreResGenRun = true;
}

void CompileLicxFiles()
{
    // if ('@(_LicxFile)'!='')
    if (''!='') { CompileLicxFilesRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /* if ('$(LCMSBuildArchitecture)' == '')*/
    if ('' == '')
    {
        LCMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /*LC(ToolPath: "$(LCToolPath)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", OutputLicense: "$(IntermediateOutputPath)$(TargetFileName).licenses", NoLogo: "$(NoLogo)", SdkToolsPath: "$(TargetFrameworkSDKToolsDirectory)", Sources: "@(_LicxFile)", OutputDirectory: "$(IntermediateOutputPath)", EnvironmentVariables: "$(LCEnvironment)", LicenseTarget: "$(TargetFileName)", ReferencedAssemblies: "@(ReferencePathWithRefAssemblies);@(ReferenceDependencyPaths)");*/
    LC(ToolPath: "", TargetFrameworkVersion: "v8.0", OutputLicense: "obj\\Debug\\net8.0\\6 - targets.dll.licenses", NoLogo: "", SdkToolsPath: "", Sources: "", OutputDirectory: "obj\\Debug\\net8.0\\", EnvironmentVariables: "", LicenseTarget: "6 - targets.dll", ReferencedAssemblies: ";");
    
    CompileLicxFilesRun = true;
}

void ResolveKeySource()
{
    // if ($(SignManifests) == 'true' or $(SignAssembly) == 'true')
    if ( == 'true' or false == 'true') { ResolveKeySourceRun = true; return; }
    
    /*ResolveKeySource(CertificateThumbprint: "$(ManifestCertificateThumbprint)", CertificateFile: "$(ManifestKeyFile)", SuppressAutoClosePasswordPrompt: "$(BuildingInsideVisualStudio)", KeyFile: "$(AssemblyOriginatorKeyFile)", ShowImportDialogDespitePreviousFailures: "$(BuildingProject)");*/
    ResolveKeySource(CertificateThumbprint: "", CertificateFile: "", SuppressAutoClosePasswordPrompt: "", KeyFile: "", ShowImportDialogDespitePreviousFailures: "false");
    
    ResolveKeySourceRun = true;
}

void Compile()
{
    // DependsOnTargets;
    if (!ResolveReferencesRun) ResolveReferences();
    if (!ResolveKeySourceRun) ResolveKeySource();
    if (!SetWin32ManifestPropertiesRun) SetWin32ManifestProperties();
    if (!FindReferenceAssembliesForReferencesRun) FindReferenceAssembliesForReferences();
    if (!_GenerateCompileInputsRun) _GenerateCompileInputs();
    if (!BeforeCompileRun) BeforeCompile();
    if (!_TimeStampBeforeCompileRun) _TimeStampBeforeCompile();
    if (!_GenerateCompileDependencyCacheRun) _GenerateCompileDependencyCache();
    if (!CoreCompileRun) CoreCompile();
    if (!_TimeStampAfterCompileRun) _TimeStampAfterCompile();
    if (!AfterCompileRun) AfterCompile();
    if (!Run) ();
    if (!_CreateAppHostRun) _CreateAppHost();
    if (!_CreateComHostRun) _CreateComHost();
    if (!_GetIjwHostPathsRun) _GetIjwHostPaths();
    if (!Run) ();
    
    CompileRun = true;
}

void _GenerateCompileInputs()
{
    
    /* if ('@(ManifestResourceWithNoCulture)'!='' and '%(ManifestResourceWithNoCulture.EmittedForCompatibilityOnly)'=='')*/
    if (''!='' and '%(ManifestResourceWithNoCulture.EmittedForCompatibilityOnly)'=='')
    {
        Warning(Text: "ManifestResourceWithNoCulture item type is deprecated. Emit EmbeddedResource items instead, with metadata WithCulture='false', Type='Resx', and optional LogicalName.", Code: "MSB9004");
    }
    /* if ('@(ManifestNonResxWithNoCultureOnDisk)'!='' and '%(ManifestNonResxWithNoCultureOnDisk.EmittedForCompatibilityOnly)'=='')*/
    if (''!='' and '%(ManifestNonResxWithNoCultureOnDisk.EmittedForCompatibilityOnly)'=='')
    {
        Warning(Text: "ManifestNonResxWithNoCultureOnDisk item type is deprecated. Emit EmbeddedResource items instead, with metadata WithCulture='false', Type='Non-Resx', and optional LogicalName.", Code: "MSB9005");
    }
    
    _GenerateCompileInputsRun = true;
}

void GenerateTargetFrameworkMonikerAttribute()
{
    // if ('@(Compile)' != '' and '$(GenerateTargetFrameworkAttribute)' == 'true')
    if ('Program.cs' != '' and 'true' == 'true') { GenerateTargetFrameworkMonikerAttributeRun = true; return; }
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    // BeforeTargets;
    if (!_SetTargetFrameworkMonikerAttributeRun) _SetTargetFrameworkMonikerAttribute();
    
    /*WriteLinesToFile(File: "$(TargetFrameworkMonikerAssemblyAttributesPath)", Overwrite: "true", Lines: "$(TargetFrameworkMonikerAssemblyAttributeText)");*/
    /* if ('@(Compile)' != '' and '$(TargetFrameworkMonikerAssemblyAttributeText)' != '')*/
    if ('Program.cs' != '' and '' != '')
    {
        WriteLinesToFile(File: "obj\\Debug\\net8.0\\.NETCoreApp,Version=v8.0.AssemblyAttributes.cs", Overwrite: "true", Lines: "");
    }
    
    GenerateTargetFrameworkMonikerAttributeRun = true;
}

void GenerateAdditionalSources()
{
    // if ('@(AssemblyAttributes)' != '' and '$(GenerateAdditionalSources)' == 'true')
    if ('' != '' and '' == 'true') { GenerateAdditionalSourcesRun = true; return; }
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    
    /*WriteCodeFragment(AssemblyAttributes: "@(AssemblyAttributes)", Language: "$(Language)", OutputFile: "$(AssemblyAttributesPath)");*/
    WriteCodeFragment(AssemblyAttributes: "", Language: "C#", OutputFile: "");
    
    GenerateAdditionalSourcesRun = true;
}

void BeforeCompile()
{
    // BeforeTargets;
    if (!GenerateMSBuildEditorConfigFileRun) GenerateMSBuildEditorConfigFile();
    if (!GenerateTargetFrameworkMonikerAttributeRun) GenerateTargetFrameworkMonikerAttribute();
    if (!GenerateAdditionalSourcesRun) GenerateAdditionalSources();
    if (!GenerateAssemblyInfoRun) GenerateAssemblyInfo();
    if (!GenerateGlobalUsingsRun) GenerateGlobalUsings();
    
    BeforeCompileRun = true;
}

void AfterCompile()
{
    
    AfterCompileRun = true;
}

void _TimeStampBeforeCompile()
{
    // if ('$(RunPostBuildEvent)'=='OnOutputUpdated' or ('$(RegisterForComInterop)'=='true' and '$(OutputType)'=='library'))
    if (''=='OnOutputUpdated' or (''=='true' and 'Exe'=='library')) { _TimeStampBeforeCompileRun = true; return; }
    
    _AssemblyTimestampBeforeCompile = "%(IntermediateAssembly.ModifiedTime)";
    _TimeStampBeforeCompileRun = true;
}

void _GenerateSuggestedBindingRedirectsCache()
{
    // if ('$(DesignTimeBuild)' != 'true' and '$(BuildingProject)' == 'true')
    if ('' != 'true' and 'false' == 'true') { _GenerateSuggestedBindingRedirectsCacheRun = true; return; }
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    SuggestedBindingRedirectsCacheFile = "$(IntermediateOutputPath)$(MSBuildProjectFile).SuggestedBindingRedirects.cache";
    /*Hash(ItemsToHash: "@(SuggestedBindingRedirects)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(SuggestedBindingRedirectsCacheFile)", Overwrite: "true", Lines: "$(SuggestedBindingRedirectsHash)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    _GenerateSuggestedBindingRedirectsCacheRun = true;
}

void _GenerateCompileDependencyCache()
{
    // if ('$(DesignTimeBuild)' != 'true' and '$(BuildingProject)' == 'true')
    if ('' != 'true' and 'false' == 'true') { _GenerateCompileDependencyCacheRun = true; return; }
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    /*Hash(IgnoreCase: "$([MSBuild]::ValueOrDefault(`$(CoreCompileCacheIgnoreCase)`, `true`))", ItemsToHash: "@(CoreCompileCache)");*/
    Hash(IgnoreCase: "true", ItemsToHash: "");
    /*WriteLinesToFile(File: "$(IntermediateOutputPath)$(MSBuildProjectFile).CoreCompileInputs.cache", Overwrite: "true", Lines: "$(CoreCompileDependencyHash)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.CoreCompileInputs.cache", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    _GenerateCompileDependencyCacheRun = true;
}

void _TimeStampAfterCompile()
{
    // if ('$(RunPostBuildEvent)'=='OnOutputUpdated' or ('$(RegisterForComInterop)'=='true' and '$(OutputType)'=='library'))
    if (''=='OnOutputUpdated' or (''=='true' and 'Exe'=='library')) { _TimeStampAfterCompileRun = true; return; }
    
    _AssemblyTimestampAfterCompile = "%(IntermediateAssembly.ModifiedTime)";
    _TimeStampAfterCompileRun = true;
}

void _ComputeNonExistentFileProperty()
{
    // if (('$(BuildingInsideVisualStudio)' == 'true') and ('$(BuildingOutOfProcess)' != 'true') and (('$(BuildingProject)' == 'false') or ('$(UseHostCompilerIfAvailable)' == 'true')))
    if (('' == 'true') and ('' != 'true') and (('false' == 'false') or ('true' == 'true'))) { _ComputeNonExistentFilePropertyRun = true; return; }
    
    NonExistentFile = "__NonExistentSubDir__\\__NonExistentFile__";
    _ComputeNonExistentFilePropertyRun = true;
}

void GenerateSerializationAssemblies()
{
    // if ('$(_SGenGenerateSerializationAssembliesConfig)' == 'On' or ('@(WebReferenceUrl)'!='' and '$(_SGenGenerateSerializationAssembliesConfig)' == 'Auto'))
    if ('Off' == 'On' or (''!='' and 'Off' == 'Auto')) { GenerateSerializationAssembliesRun = true; return; }
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!CompileRun) Compile();
    if (!ResolveKeySourceRun) ResolveKeySource();
    
    /* if ('$(SGenMSBuildArchitecture)' == '')*/
    if ('' == '')
    {
        SGenMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /*SGen(UseKeep: "$(SGenUseKeep)", ToolPath: "$(SGenToolPath)", DelaySign: "$(DelaySign)", BuildAssemblyPath: "$(IntermediateOutputPath)", Platform: "$(SGenPlatformTarget)", ShouldGenerateSerializer: "$(SGenShouldGenerateSerializer)", SdkToolsPath: "$(TargetFrameworkSDKToolsDirectory)", SerializationAssembly: "$(IntermediateOutputPath)$(_SGenDllName)", KeyFile: "$(KeyOriginatorFile)", KeyContainer: "$(KeyContainerName)", BuildAssemblyName: "$(TargetFileName)", References: "@(ReferencePath)", Types: "$(SGenSerializationTypes)", EnvironmentVariables: "$(SGenEnvironment)", UseProxyTypes: "$(SGenUseProxyTypes)");*/
    SGen(UseKeep: "false", ToolPath: "", DelaySign: "", BuildAssemblyPath: "obj\\Debug\\net8.0\\", Platform: "", ShouldGenerateSerializer: "true", SdkToolsPath: "", SerializationAssembly: "obj\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", KeyFile: "", KeyContainer: "", BuildAssemblyName: "6 - targets.dll", References: "", Types: "", EnvironmentVariables: "", UseProxyTypes: "true");
    
    GenerateSerializationAssembliesRun = true;
}

void CreateSatelliteAssemblies()
{
    // DependsOnTargets;
    if (!_GenerateSatelliteAssemblyInputsRun) _GenerateSatelliteAssemblyInputs();
    if (!ComputeIntermediateSatelliteAssembliesRun) ComputeIntermediateSatelliteAssemblies();
    if (!GenerateSatelliteAssembliesRun) GenerateSatelliteAssemblies();
    if (!CoreGenerateSatelliteAssembliesRun) CoreGenerateSatelliteAssemblies();
    
    CreateSatelliteAssembliesRun = true;
}

void _GenerateSatelliteAssemblyInputs()
{
    
    /* if ('@(ManifestResourceWithCulture)'!='' and '%(ManifestResourceWithCulture.EmittedForCompatibilityOnly)'=='')*/
    if (''!='' and '%(ManifestResourceWithCulture.EmittedForCompatibilityOnly)'=='')
    {
        Warning(Text: "ManifestResourceWithCulture item type is deprecated. Emit EmbeddedResource items instead, with metadata WithCulture='true', Type='Resx', and optional LogicalName.", Code: "MSB9006");
    }
    /* if ('@(ManifestNonResxWithCultureOnDisk)'!='' and '%(ManifestNonResxWithCultureOnDisk.EmittedForCompatibilityOnly)'=='')*/
    if (''!='' and '%(ManifestNonResxWithCultureOnDisk.EmittedForCompatibilityOnly)'=='')
    {
        Warning(Text: "ManifestNonResxWithCultureOnDisk item type is deprecated. Emit EmbeddedResource items instead, with metadata WithCulture='true', Type='Non-Resx', and optional LogicalName.", Code: "MSB9007");
    }
    
    _GenerateSatelliteAssemblyInputsRun = true;
}

void GenerateSatelliteAssemblies()
{
    // if ('@(_SatelliteAssemblyResourceInputs)' != '' and '$(GenerateSatelliteAssembliesForCore)' != 'true')
    if ('' != '' and 'true' != 'true') { GenerateSatelliteAssembliesRun = true; return; }
    
    /* if ('$(_ALExeToolPath)' == '')*/
    if ('' == '')
    {
        _ALExeToolPath = "$(TargetFrameworkSDKToolsDirectory)";
    }
    /*MakeDir(Directories: "@(EmbeddedResource->'$(IntermediateOutputPath)%(Culture)')");*/
    MakeDir(Directories: "");
    /*AL(Description: "$(Satellite_Description)", TargetType: "$(Satellite_TargetType)", ToolPath: "$(AlToolPath)", DelaySign: "$(DelaySign)", SourceModules: "@(Satellite_SourceModule)", ToolExe: "$(AlToolExe)", Platform: "$(PlatformTarget)", Trademark: "$(Satellite_Trademark)", ProductVersion: "$(Satellite_ProductVersion)", CompanyName: "$(Satellite_CompanyName)", Flags: "$(Satellite_Flags)", Copyright: "$(Satellite_Copyright)", AlgorithmId: "$(Satellite_AlgorithmId)", SdkToolsPath: "$(_ALExeToolPath)", Title: "$(Satellite_Title)", Configuration: "$(Satellite_Configuration)", ResponseFiles: "@(AlResponseFile)", GenerateFullPaths: "$(Satellite_GenerateFullPaths)", FileVersion: "$(Satellite_FileVersion)", EmbedResources: "@(_SatelliteAssemblyResourceInputs)", KeyFile: "$(KeyOriginatorFile)", KeyContainer: "$(KeyContainerName)", MainEntryPoint: "$(Satellite_MainEntryPoint)", TemplateFile: "$(IntermediateOutputPath)$(TargetName)$(TargetExt)", LinkResources: "@(Satellite_LinkResource)", EvidenceFile: "$(Satellite_EvidenceFile)", Version: "$(Satellite_Version)", BaseAddress: "$(Satellite_BaseAddress)", Win32Icon: "$(Satellite_Win32Icon)", EnvironmentVariables: "$(AlEnvironment)", ProductName: "$(Satellite_ProductName)", Win32Resource: "$(Satellite_Win32Resource)", Culture: "%(Culture)", OutputAssembly: "$(IntermediateOutputPath)%(Culture)\\$(TargetName).resources.dll");*/
    AL(Description: "", TargetType: "", ToolPath: "", DelaySign: "", SourceModules: "", ToolExe: "", Platform: "", Trademark: "", ProductVersion: "", CompanyName: "", Flags: "", Copyright: "", AlgorithmId: "", SdkToolsPath: "", Title: "", Configuration: "", ResponseFiles: "", GenerateFullPaths: "", FileVersion: "", EmbedResources: "", KeyFile: "", KeyContainer: "", MainEntryPoint: "", TemplateFile: "obj\\Debug\\net8.0\\6 - targets.dll", LinkResources: "", EvidenceFile: "", Version: "", BaseAddress: "", Win32Icon: "", EnvironmentVariables: "", ProductName: "", Win32Resource: "", Culture: "%(Culture)", OutputAssembly: "obj\\Debug\\net8.0\\%(Culture)\\6 - targets.resources.dll");
    
    GenerateSatelliteAssembliesRun = true;
}

void ComputeIntermediateSatelliteAssemblies()
{
    // if (@(EmbeddedResource->'%(WithCulture)') != '')
    if ( != '') { ComputeIntermediateSatelliteAssembliesRun = true; return; }
    // DependsOnTargets;
    if (!CreateManifestResourceNamesRun) CreateManifestResourceNames();
    
    ComputeIntermediateSatelliteAssembliesRun = true;
}

void SetWin32ManifestProperties()
{
    // if ('$(Win32Manifest)'=='')
    if (''=='') { SetWin32ManifestPropertiesRun = true; return; }
    // DependsOnTargets;
    if (!ResolveComReferencesRun) ResolveComReferences();
    if (!ResolveNativeReferencesRun) ResolveNativeReferences();
    if (!_SetExternalWin32ManifestPropertiesRun) _SetExternalWin32ManifestProperties();
    if (!_SetEmbeddedWin32ManifestPropertiesRun) _SetEmbeddedWin32ManifestProperties();
    
    SetWin32ManifestPropertiesRun = true;
}

void _SetExternalWin32ManifestProperties()
{
    // if ('$(GenerateClickOnceManifests)'=='true' or '@(NativeReference)'!='' or '@(ResolvedIsolatedComModules)'!='')
    if (''=='true' or ''!='' or ''!='') { _SetExternalWin32ManifestPropertiesRun = true; return; }
    
    _DeploymentBaseManifest = "$(ApplicationManifest)";
    /* if ('$(_DeploymentBaseManifest)'=='')*/
    if (''=='')
    {
        _DeploymentBaseManifest = "@(_DeploymentBaseManifestWithTargetPath)";
    }
    /* if ('$(NoWin32Manifest)'=='')*/
    if (''=='')
    {
        NoWin32Manifest = "true";
    }
    _SetExternalWin32ManifestPropertiesRun = true;
}

void _SetEmbeddedWin32ManifestProperties()
{
    // if ('$(GenerateClickOnceManifests)'!='true' and '@(NativeReference)'=='' and '@(ResolvedIsolatedComModules)'=='')
    if (''!='true' and ''=='' and ''=='') { _SetEmbeddedWin32ManifestPropertiesRun = true; return; }
    
    EmbeddedWin32Manifest = "$(ApplicationManifest)";
    Win32Manifest = "$(ApplicationManifest)";
    /* if ('$(ApplicationManifest)'=='' and '$(NoWin32Manifest)'!='true' and Exists('$(_FrameworkVersion40Path)\default.win32manifest'))*/
    if (''=='' and ''!='true' and Exists('\default.win32manifest'))
    {
        EmbeddedWin32Manifest = "$(_FrameworkVersion40Path)\\default.win32manifest";
    }
    /* if ('$(ApplicationManifest)'=='' and '$(NoWin32Manifest)'!='true')*/
    if (''=='' and ''!='true')
    {
        GetFrameworkPath();
    }
    
    _SetEmbeddedWin32ManifestPropertiesRun = true;
}

void _GenerateResolvedDeploymentManifestEntryPoint()
{
    
    /*ResolveManifestFiles(TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningManifests: "$(SignManifests)", PublishFiles: "@(_DeploymentPublishFileOfTypeManifestEntryPoint)", DeploymentManifestEntryPoint: "@(ApplicationManifest)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)");*/
    ResolveManifestFiles(TargetFrameworkVersion: "v8.0", SigningManifests: "", PublishFiles: "", DeploymentManifestEntryPoint: "obj\\Debug\\net8.0\\6 - targets.dll.manifest", TargetFrameworkIdentifier: ".NETCoreApp");
    
    _GenerateResolvedDeploymentManifestEntryPointRun = true;
}

void GenerateManifests()
{
    // if ('$(GenerateClickOnceManifests)'=='true' or '@(NativeReference)'!='' or '@(ResolvedIsolatedComModules)'!='' or '$(GenerateAppxManifest)' == 'true')
    if (''=='true' or ''!='' or ''!='' or '' == 'true') { GenerateManifestsRun = true; return; }
    // DependsOnTargets;
    if (!SetWin32ManifestPropertiesRun) SetWin32ManifestProperties();
    if (!GenerateApplicationManifestRun) GenerateApplicationManifest();
    if (!GenerateDeploymentManifestRun) GenerateDeploymentManifest();
    
    GenerateManifestsRun = true;
}

void GenerateApplicationManifest()
{
    // DependsOnTargets;
    if (!_DeploymentSetClickOnceVersionsRun) _DeploymentSetClickOnceVersions();
    if (!_DeploymentGenerateLauncherRun) _DeploymentGenerateLauncher();
    if (!_DeploymentComputeNativeManifestInfoRun) _DeploymentComputeNativeManifestInfo();
    if (!_DeploymentComputeClickOnceManifestInfoRun) _DeploymentComputeClickOnceManifestInfo();
    if (!ResolveComReferencesRun) ResolveComReferences();
    if (!ResolveNativeReferencesRun) ResolveNativeReferences();
    if (!_GenerateResolvedDeploymentManifestEntryPointRun) _GenerateResolvedDeploymentManifestEntryPoint();
    
    _DeploymentCopyApplicationManifest = "true";
    /*RequiresFramework35SP1Assembly(TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningManifests: "$(SignManifests)", EntryPoint: "@(_DeploymentResolvedManifestEntryPoint)", CreateDesktopShortcut: "$(CreateDesktopShortcut)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", DeploymentManifestEntryPoint: "@(_DeploymentResolvedDeploymentManifestEntryPoint)", SuiteName: "$(SuiteName)", Files: "@(_DeploymentManifestFiles)", Assemblies: "@(_DeploymentManifestDependencies)", ReferencedAssemblies: "@(Reference)");*/
    RequiresFramework35SP1Assembly(TargetFrameworkVersion: "v8.0", SigningManifests: "", EntryPoint: "", CreateDesktopShortcut: "", ErrorReportUrl: "", DeploymentManifestEntryPoint: "", SuiteName: "", Files: "", Assemblies: "", ReferencedAssemblies: "");
    /*GenerateApplicationManifest(Description: "$(Description)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", ConfigFile: "@(AppConfigWithTargetPath)", HostInBrowser: "$(HostInBrowser)", Product: "$(ProductName)", OSVersion: "$(OSVersion)", Platform: "$(_DeploymentPlatformTarget)", EntryPoint: "@(_DeploymentResolvedManifestEntryPoint)", SupportUrl: "$(_DeploymentFormattedSupportUrl)", IsolatedComReferences: "@(ResolvedIsolatedComModules)", ManifestType: "$(_DeploymentManifestType)", TrustInfoFile: "@(_DeploymentIntermediateTrustInfoFile)", FileAssociations: "@(FileAssociation)", UseApplicationTrust: "$(UseApplicationTrust)", Dependencies: "@(_DeploymentManifestDependencies)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", IconFile: "@(_DeploymentManifestIconFile)", SuiteName: "$(SuiteName)", TargetFrameworkProfile: "$(TargetFrameworkProfile)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)", OutputManifest: "@(ApplicationManifest)", Files: "@(_DeploymentManifestFiles)", MaxTargetPath: "$(MaxTargetPath)", Publisher: "$(PublisherName)", TargetFrameworkSubset: "$(TargetFrameworkSubset)", AssemblyVersion: "$(_DeploymentManifestVersion)", RequiresMinimumFramework35SP1: "$(_DeploymentRequiresMinimumFramework35SP1)", ClrVersion: "$(ClrVersion)", InputManifest: "$(_DeploymentBaseManifest)", TargetCulture: "$(TargetCulture)");*/
    GenerateApplicationManifest(Description: "", TargetFrameworkVersion: "", ConfigFile: "", HostInBrowser: "", Product: "", OSVersion: "", Platform: "", EntryPoint: "", SupportUrl: "", IsolatedComReferences: "", ManifestType: "", TrustInfoFile: "", FileAssociations: "", UseApplicationTrust: "", Dependencies: "", LauncherBasedDeployment: "true", ErrorReportUrl: "", IconFile: "", SuiteName: "", TargetFrameworkProfile: "", AssemblyName: "6 - targets.exe", OutputManifest: "obj\\Debug\\net8.0\\6 - targets.dll.manifest", Files: "", MaxTargetPath: "100", Publisher: "", TargetFrameworkSubset: "", AssemblyVersion: "", RequiresMinimumFramework35SP1: "", ClrVersion: "", InputManifest: "", TargetCulture: "*");
    
    GenerateApplicationManifestRun = true;
}

void _DeploymentSetClickOnceVersions()
{
    // if ('$(GenerateClickOnceManifests)'=='true')
    if (''=='true') { _DeploymentSetClickOnceVersionsRun = true; return; }
    
    _DeploymentManifestTargetFrameworkMoniker = "$(TargetFrameworkMoniker)";
    _DeploymentManifestTargetFrameworkVersion = "$(TargetFrameworkVersion)";
    _DeploymentSetClickOnceVersionsRun = true;
}

void _DeploymentGenerateLauncher()
{
    // if ('$(GenerateClickOnceManifests)'=='true' and '$(_DeploymentLauncherBased)' == 'true')
    if (''=='true' and 'true' == 'true') { _DeploymentGenerateLauncherRun = true; return; }
    
    /* if ('$(DeploymentManifestTargetFrameworkVersionOverride)' == '')*/
    if ('' == '')
    {
        _DeploymentManifestTargetFrameworkVersion = "v4.5";
    }
    /* if ('$(DeploymentManifestTargetFrameworkVersionOverride)' != '')*/
    if ('' != '')
    {
        _DeploymentManifestTargetFrameworkVersion = "$(DeploymentManifestTargetFrameworkVersionOverride)";
    }
    _DeploymentManifestTargetFrameworkMoniker = ".NETFramework,Version=$(_DeploymentManifestTargetFrameworkVersion)";
    /*GenerateLauncher(EntryPoint: "@(EntryPointForLauncher)", VisualStudioVersion: "$(VisualStudioVersion)", OutputPath: "$(IntermediateOutputPath)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)");*/
    GenerateLauncher(EntryPoint: "", VisualStudioVersion: "17.0", OutputPath: "obj\\Debug\\net8.0\\", AssemblyName: "6 - targets.exe");
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningTarget: "@(_DeploymentManifestLauncherEntryPoint)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", SigningTarget: "", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningTarget: "@(_DeploymentManifestEntryPoint)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", SigningTarget: "obj\\Debug\\net8.0\\6 - targets.dll", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningTarget: "$(AppHostIntermediatePath)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true' and '$(UseAppHost)' == 'true' and '$(PublishSingleFile)' != 'true' and '$(_IsExecutable)' == 'true' and exists('$(AppHostIntermediatePath)'))*/
    if (''=='true' and 'true' == 'true' and '' != 'true' and 'true' == 'true' and exists(''))
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", SigningTarget: "", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    
    _DeploymentGenerateLauncherRun = true;
}

void _DeploymentComputeNativeManifestInfo()
{
    // if ('$(GenerateClickOnceManifests)'!='true')
    if (''!='true') { _DeploymentComputeNativeManifestInfoRun = true; return; }
    
    _DeploymentManifestType = "Native";
    _DeploymentManifestVersion = "@(_IntermediateAssemblyIdentity->'%(Version)')";
    /*ResolveManifestFiles(NativeAssemblies: "@(NativeReferenceFile);@(_DeploymentNativePrerequisite)");*/
    ResolveManifestFiles(NativeAssemblies: ";");
    /*GetAssemblyIdentity(AssemblyFiles: "@(IntermediateAssembly)");*/
    GetAssemblyIdentity(AssemblyFiles: "obj\\Debug\\net8.0\\6 - targets.dll");
    
    _DeploymentComputeNativeManifestInfoRun = true;
}

void _DeploymentComputeClickOnceManifestInfo()
{
    // if ('$(GenerateClickOnceManifests)'=='true')
    if (''=='true') { _DeploymentComputeClickOnceManifestInfoRun = true; return; }
    // DependsOnTargets;
    if (!CleanPublishFolderRun) CleanPublishFolder();
    if (!GetCopyToOutputDirectoryItemsRun) GetCopyToOutputDirectoryItems();
    if (!_DeploymentGenerateTrustInfoRun) _DeploymentGenerateTrustInfo();
    
    _DeploymentManifestType = "ClickOnce";
    /* if ('$(_DeploymentLauncherBased)' != 'true')*/
    if ('true' != 'true')
    {
        _DeploymentPlatformTarget = "$(PlatformTarget)";
    }
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningTarget: "$(PublishedSingleFilePath)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true' and '$(_DeploymentLauncherBased)' == 'true' and '$(PublishSingleFile)' == 'true')*/
    if (''=='true' and 'true' == 'true' and '' == 'true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", SigningTarget: "", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningTarget: "@(_ClickOnceTargetFile)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)' == 'true' and '$(PublishReadyToRun)' == 'true' and '$(PublishSingleFile)' != 'true')*/
    if ('' == 'true' and '' == 'true' and '' != 'true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", SigningTarget: "", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*Copy(SourceFiles: "@(_DeploymentManifestEntryPoint)", DestinationFolder: "$(ClickOncePublishDir)");*/
    Copy(SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll", DestinationFolder: "bin\\Debug\\net8.0\\publish\\");
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", SigningTarget: "@(_DeploymentClickOnceApplicationExecutable)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentResolvedManifestCertificateThumbprint)'!='' and '$(_DeploymentSignClickOnceManifests)'=='true' and '$(TargetExt)' == '.exe')*/
    if (''!='' and ''=='true' and '.dll' == '.exe')
    {
        SignFile(CertificateThumbprint: "", SigningTarget: "", TimestampUrl: "");
    }
    /*ResolveManifestFiles(TargetFrameworkVersion: "$(TargetFrameworkVersion)", ExtraFiles: "@(_DebugSymbolsIntermediatePath);$(IntermediateOutputPath)$(TargetName).xml;@(_ReferenceRelatedPaths)", SigningManifests: "$(SignManifests)", EntryPoint: "@(_DeploymentClickOnceApplicationExecutable)", PublishFiles: "@(PublishFile)", IsSingleFilePublish: "$(PublishSingleFile)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", SatelliteAssemblies: "@(_ClickOnceSatelliteAssemblies)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", Files: "@(_ClickOnceFiles)", IsSelfContainedPublish: "$(SelfContained)", ManagedAssemblies: "@(_ManifestManagedReferences)", NativeAssemblies: "@(NativeReferenceFile);@(_DeploymentNativePrerequisite)", RuntimePackAssets: "@(RuntimePackAsset)", TargetCulture: "$(TargetCulture)");*/
    ResolveManifestFiles(TargetFrameworkVersion: "v8.0", ExtraFiles: "obj\\Debug\\net8.0\\6 - targets.pdb;obj\\Debug\\net8.0\\6 - targets.xml;", SigningManifests: "", EntryPoint: "", PublishFiles: "", IsSingleFilePublish: "", LauncherBasedDeployment: "true", SatelliteAssemblies: "", AssemblyName: "6 - targets.exe", TargetFrameworkIdentifier: ".NETCoreApp", Files: "", IsSelfContainedPublish: "false", ManagedAssemblies: "", NativeAssemblies: ";", RuntimePackAssets: "", TargetCulture: "*");
    /*FormatVersion(Version: "$(ApplicationVersion)", Revision: "$(ApplicationRevision)");*/
    FormatVersion(Version: "", Revision: "");
    /*FormatUrl(InputUrl: "$(_DeploymentUrl)");*/
    FormatUrl(InputUrl: "");
    /*FormatUrl(InputUrl: "$(SupportUrl)");*/
    FormatUrl(InputUrl: "");
    /*FormatUrl(InputUrl: "$(ErrorReportUrl)");*/
    FormatUrl(InputUrl: "");
    
    _DeploymentComputeClickOnceManifestInfoRun = true;
}

void _DeploymentGenerateTrustInfo()
{
    // if ('$(TargetZone)'!='')
    if (''!='') { _DeploymentGenerateTrustInfoRun = true; return; }
    
    /*GenerateTrustInfo(TargetZone: "$(TargetZone)", BaseManifest: "$(_DeploymentBaseManifest)", ExcludedPermissions: "$(ExcludedPermissions)", TrustInfoFile: "@(_DeploymentIntermediateTrustInfoFile)", ApplicationDependencies: "@(ReferencePath);@(ReferenceDependencyPaths)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
    GenerateTrustInfo(TargetZone: "", BaseManifest: "", ExcludedPermissions: "", TrustInfoFile: "", ApplicationDependencies: ";", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");
    
    _DeploymentGenerateTrustInfoRun = true;
}

void GenerateDeploymentManifest()
{
    // DependsOnTargets;
    if (!GenerateApplicationManifestRun) GenerateApplicationManifest();
    
    /*GenerateDeploymentManifest(Description: "$(Description)", Install: "$(Install)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", UpdateMode: "$(UpdateMode)", Product: "$(ProductName)", Platform: "$(_DeploymentPlatformTarget)", EntryPoint: "@(_DeploymentResolvedDeploymentManifestEntryPoint)", CreateDesktopShortcut: "$(CreateDesktopShortcut)", SupportUrl: "$(_DeploymentFormattedSupportUrl)", UpdateEnabled: "$(UpdateEnabled)", DisallowUrlActivation: "$(DisallowUrlActivation)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", MinimumRequiredVersion: "$(_DeploymentBuiltMinimumRequiredVersion)", MapFileExtensions: "$(MapFileExtensions)", TargetFrameworkMoniker: "$(_DeploymentManifestTargetFrameworkMoniker)", SuiteName: "$(SuiteName)", UpdateInterval: "$(_DeploymentBuiltUpdateInterval)", AssemblyName: "$(_DeploymentDeployManifestIdentity)", OutputManifest: "@(DeployManifest)", UpdateUnit: "$(_DeploymentBuiltUpdateIntervalUnits)", MaxTargetPath: "$(MaxTargetPath)", DeploymentUrl: "$(_DeploymentFormattedDeploymentUrl)", Publisher: "$(PublisherName)", AssemblyVersion: "$(_DeploymentManifestVersion)", TrustUrlParameters: "$(TrustUrlParameters)", TargetCulture: "$(TargetCulture)");*/
    /* if ('$(GenerateClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        GenerateDeploymentManifest(Description: "", Install: "", TargetFrameworkVersion: "", UpdateMode: "", Product: "", Platform: "", EntryPoint: "", CreateDesktopShortcut: "", SupportUrl: "", UpdateEnabled: "", DisallowUrlActivation: "", LauncherBasedDeployment: "true", ErrorReportUrl: "", MinimumRequiredVersion: "", MapFileExtensions: "", TargetFrameworkMoniker: "", SuiteName: "", UpdateInterval: "0", AssemblyName: "6 - targets.application", OutputManifest: "obj\\Debug\\net8.0\\6 - targets.application", UpdateUnit: "Days", MaxTargetPath: "100", DeploymentUrl: "", Publisher: "", AssemblyVersion: "", TrustUrlParameters: "", TargetCulture: "*");
    }
    
    GenerateDeploymentManifestRun = true;
}

void PrepareForRun()
{
    // DependsOnTargets;
    if (!CopyFilesToOutputDirectoryRun) CopyFilesToOutputDirectory();
    
    PrepareForRunRun = true;
}

void CopyFilesToOutputDirectory()
{
    // DependsOnTargets;
    if (!ComputeIntermediateSatelliteAssembliesRun) ComputeIntermediateSatelliteAssemblies();
    if (!_CopyFilesMarkedCopyLocalRun) _CopyFilesMarkedCopyLocal();
    if (!_CopySourceItemsToOutputDirectoryRun) _CopySourceItemsToOutputDirectory();
    if (!_CopyAppConfigFileRun) _CopyAppConfigFile();
    if (!_CopyManifestFilesRun) _CopyManifestFiles();
    if (!_CheckForCompileOutputsRun) _CheckForCompileOutputs();
    if (!_SGenCheckForOutputsRun) _SGenCheckForOutputs();
    // BeforeTargets;
    if (!GenerateBuildDependencyFileRun) GenerateBuildDependencyFile();
    if (!GenerateBuildRuntimeConfigurationFilesRun) GenerateBuildRuntimeConfigurationFiles();
    if (!GenerateShimsAssetsRun) GenerateShimsAssets();
    
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateHardLinksForCopyFilesToOutputDirectoryIfPossible = "false";
    }
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible = "false";
    }
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)' == '')*/
    if ('' == 'true' or '' == '')
    {
        ErrorIfLinkFailsForCopyFilesToOutputDirectory = "false";
    }
    /* if ('$(CopyBuildOutputToOutputDirectory)'=='')*/
    if (''=='')
    {
        CopyBuildOutputToOutputDirectory = "true";
    }
    /* if ('$(CopyOutputSymbolsToOutputDirectory)'=='')*/
    if (''=='')
    {
        CopyOutputSymbolsToOutputDirectory = "true";
    }
    /* if ('$(CopyDocumentationFileToOutputDirectory)'=='')*/
    if (''=='')
    {
        CopyDocumentationFileToOutputDirectory = "true";
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(IntermediateAssembly)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", DestinationFolder: "$(OutDir)");*/
    /* if ('$(CopyBuildOutputToOutputDirectory)' == 'true' and '$(SkipCopyBuildProduct)' != 'true')*/
    if ('' == 'true' and '' != 'true')
    {
        Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll", ErrorIfLinkFails: "", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /*CopyRefAssembly(DestinationPath: "$(TargetRefPath)", SourcePath: "@(IntermediateRefAssembly)");*/
    /* if ('$(ProduceReferenceAssembly)' == 'true' and '$(CopyBuildOutputToOutputDirectory)' == 'true' and '$(SkipCopyBuildProduct)' != 'true')*/
    if ('true' == 'true' and '' == 'true' and '' != 'true')
    {
        CopyRefAssembly(DestinationPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\ref\\6 - targets.dll", SourcePath: "obj\\Debug\\net8.0\\refint\\6 - targets.dll");
    }
    /*Message(Text: "$(MSBuildProjectName) -> @(MainAssembly->'%(FullPath)')", Importance: "High");*/
    /* if ('$(CopyBuildOutputToOutputDirectory)' == 'true' and '$(SkipCopyBuildProduct)'!='true')*/
    if ('' == 'true' and ''!='true')
    {
        Message(Text: "6 - targets -> ", Importance: "High");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyAdditionalFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(AddModules)", DestinationFolder: "$(OutDir)");*/
    /* if ('@(AddModules)' != '')*/
    if ('' != '')
    {
        Copy(UseHardlinksIfPossible: "false", UseSymboliclinksIfPossible: "false", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", DestinationFiles: "$(OutDir)$(_SGenDllName)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "$(IntermediateOutputPath)$(_SGenDllName)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)");*/
    /* if ('$(_SGenDllCreated)'=='true')*/
    if ('false'=='true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "bin\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", ErrorIfLinkFails: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", DestinationFiles: "@(_DebugSymbolsOutputPath)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_DebugSymbolsIntermediatePath)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)");*/
    /* if ('$(_DebugSymbolsProduced)'=='true' and '$(SkipCopyingSymbolsToOutputDirectory)' != 'true' and '$(CopyOutputSymbolsToOutputDirectory)'=='true')*/
    if ('true'=='true' and '' != 'true' and ''=='true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "bin\\Debug\\net8.0\\6 - targets.pdb", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.pdb", ErrorIfLinkFails: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", DestinationFiles: "@(FinalDocFile)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(DocFileItem)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)");*/
    /* if ('$(_DocumentationFileProduced)'=='true' and '$(CopyDocumentationFileToOutputDirectory)'=='true')*/
    if ('false'=='true' and ''=='true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", ErrorIfLinkFails: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", DestinationFiles: "@(IntermediateSatelliteAssembliesWithTargetPath->'$(OutDir)%(Culture)\\$(TargetName).resources.dll')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(IntermediateSatelliteAssembliesWithTargetPath)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)");*/
    /* if ('@(IntermediateSatelliteAssembliesWithTargetPath)' != '')*/
    if ('' != '')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", ErrorIfLinkFails: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyAdditionalFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(ReferenceComWrappersToCopyLocal); @(ResolvedIsolatedComModules); @(_DeploymentLooseManifestFile); @(NativeReferenceFile)", DestinationFolder: "$(OutDir)");*/
    /* if ('@(ReferenceComWrappersToCopyLocal)' != '' or '@(ResolvedIsolatedComModules)' != '' or '@(_DeploymentLooseManifestFile)' != '' or '@(NativeReferenceFile)' != '' )*/
    if ('' != '' or '' != '' or '' != '' or '' != '' )
    {
        Copy(UseHardlinksIfPossible: "false", UseSymboliclinksIfPossible: "false", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "; ; ; ", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(WinMDExpArtifacts)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", DestinationFolder: "$(OutDir)");*/
    /* if ('$(SkipCopyWinMDArtifact)' != 'true' and '@(WinMDExpArtifacts)' != '')*/
    if ('' != 'true' and '' != '')
    {
        Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", ErrorIfLinkFails: "", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /* if ('$(SkipCopyWinMDArtifact)' != 'true' and '$(_WindowsMetadataOutputPath)' != '')*/
    if ('' != 'true' and '' != '')
    {
        Message(Text: "$(MSBuildProjectName) -> $([System.IO.Path]::GetFullPath('$(_WindowsMetadataOutputPath)'))", Importance: "High");
    }
    
    // AfterTargets;
    if (!_CopyReferenceOnlyAssembliesForBuildRun) _CopyReferenceOnlyAssembliesForBuild();
    CopyFilesToOutputDirectoryRun = true;
}

void _CopyFilesMarkedCopyLocal()
{
    // if ('@(ReferenceCopyLocalPaths)' != '')
    if ('' != '') { _CopyFilesMarkedCopyLocalRun = true; return; }
    
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateHardLinksForCopyLocalIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateHardLinksForCopyLocalIfPossible = "false";
    }
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateSymbolicLinksForCopyLocalIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateSymbolicLinksForCopyLocalIfPossible = "false";
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyLocalIfPossible)", DestinationFiles: "@(ReferenceCopyLocalPaths->'$(OutDir)%(DestinationSubDirectory)%(Filename)%(Extension)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyLocalIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(ReferenceCopyLocalPaths)");*/
    /* if ('$(UseCommonOutputDirectory)' != 'true')*/
    if ('false' != 'true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    }
    /*Touch(AlwaysCreate: "true", Files: "@(CopyUpToDateMarker)");*/
    /* if ('@(ReferencesCopiedInThisBuild)' != '' and '$(WroteAtLeastOneFile)' == 'true')*/
    if ('' != '' and '' == 'true')
    {
        Touch(AlwaysCreate: "true", Files: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targ.C1F7A3EE.Up2Date");
    }
    
    _CopyFilesMarkedCopyLocalRun = true;
}

void _CopySourceItemsToOutputDirectory()
{
    // DependsOnTargets;
    if (!GetCopyToOutputDirectoryItemsRun) GetCopyToOutputDirectoryItems();
    if (!_CopyOutOfDateSourceItemsToOutputDirectoryRun) _CopyOutOfDateSourceItemsToOutputDirectory();
    if (!_CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun) _CopyOutOfDateSourceItemsToOutputDirectoryAlways();
    
    _CopySourceItemsToOutputDirectoryRun = true;
}

void _PopulateCommonStateForGetCopyToOutputDirectoryItems()
{
    
    /* if ( '$(MSBuildDisableGetCopyToOutputDirectoryItemsOptimization)' == '' )*/
    if ( '' == '' )
    {
        _GCTODIKeepDuplicates = "false";
        _GCTODIKeepMetadata = "CopyToOutputDirectory;TargetPath";
    }
    _PopulateCommonStateForGetCopyToOutputDirectoryItemsRun = true;
}

void _GetCopyToOutputDirectoryItemsFromTransitiveProjectReferences()
{
    // DependsOnTargets;
    if (!_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun) _PopulateCommonStateForGetCopyToOutputDirectoryItems();
    if (!_AddOutputPathToGlobalPropertiesToRemoveRun) _AddOutputPathToGlobalPropertiesToRemove();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", SkipNonexistentTargets: "true", Targets: "$(_RecursiveTargetForContentCopying)", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('@(_MSBuildProjectReferenceExistent)' != '' and '$(_GetChildProjectCopyToOutputDirectoryItems)' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false' and '$(UseCommonOutputDirectory)' != 'true')*/
    if ('' != '' and 'true' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false' and 'false' != 'true')
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "GetCopyToOutputDirectoryItems", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(_CompileItemsToCopy)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    
    _GetCopyToOutputDirectoryItemsFromTransitiveProjectReferencesRun = true;
}

void _GetCopyToOutputDirectoryItemsFromThisProject()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun) _PopulateCommonStateForGetCopyToOutputDirectoryItems();
    // BeforeTargets;
    if (!AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun) AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjects();
    
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(_CompileItemsToCopy)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    
    _GetCopyToOutputDirectoryItemsFromThisProjectRun = true;
}

void GetCopyToOutputDirectoryItems()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!AssignProjectConfigurationRun) AssignProjectConfiguration();
    if (!_SplitProjectReferencesByFileExistenceRun) _SplitProjectReferencesByFileExistence();
    if (!_GetProjectReferenceTargetFrameworkPropertiesRun) _GetProjectReferenceTargetFrameworkProperties();
    if (!_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun) _PopulateCommonStateForGetCopyToOutputDirectoryItems();
    // BeforeTargets;
    if (!AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun) AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjects();
    
    CallTarget(Targets: "_GetCopyToOutputDirectoryItemsFromTransitiveProjectReferences");
    CallTarget(Targets: "_GetCopyToOutputDirectoryItemsFromThisProject");
    
    GetCopyToOutputDirectoryItemsRun = true;
}

void GetCopyToPublishDirectoryItems()
{
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!DefaultCopyToPublishDirectoryMetadataRun) DefaultCopyToPublishDirectoryMetadata();
    if (!_SplitProjectReferencesByFileExistenceRun) _SplitProjectReferencesByFileExistence();
    if (!_GetProjectReferenceTargetFrameworkPropertiesRun) _GetProjectReferenceTargetFrameworkProperties();
    // BeforeTargets;
    if (!AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjectsRun) AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjects();
    
    /* if ( '$(MSBuildDisableGetCopyToPublishDirectoryItemsOptimization)' == '' )*/
    if ( '' == '' )
    {
        _GCTPDIKeepDuplicates = "false";
        _GCTPDIKeepMetadata = "CopyToPublishDirectory;ExcludeFromSingleFile;TargetPath";
    }
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "GetCopyToPublishDirectoryItems", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('@(_MSBuildProjectReferenceExistent)' != '' and '$(_GetChildProjectCopyToPublishDirectoryItems)' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false')*/
    if ('' != '' and 'true' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false')
    {
        MSBuild(BuildInParallel: "true", Targets: "GetCopyToPublishDirectoryItems", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(_CompileItemsToPublish)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "");
    
    GetCopyToPublishDirectoryItemsRun = true;
}

void _CopyOutOfDateSourceItemsToOutputDirectory()
{
    // if ( '@(_SourceItemsToCopyToOutputDirectory)' != '' )
    if ( '' != '' ) { _CopyOutOfDateSourceItemsToOutputDirectoryRun = true; return; }
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", DestinationFiles: "@(_SourceItemsToCopyToOutputDirectory->'$(OutDir)%(TargetPath)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_SourceItemsToCopyToOutputDirectory)");*/
    Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyOutOfDateSourceItemsToOutputDirectoryRun = true;
}

void _CopyOutOfDateSourceItemsToOutputDirectoryAlways()
{
    // if ( '@(_SourceItemsToCopyToOutputDirectoryAlways)' != '' )
    if ( '' != '' ) { _CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun = true; return; }
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", DestinationFiles: "@(_SourceItemsToCopyToOutputDirectoryAlways->'$(OutDir)%(TargetPath)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_SourceItemsToCopyToOutputDirectoryAlways)");*/
    Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun = true;
}

void _CopyAppConfigFile()
{
    // if ( '@(AppConfigWithTargetPath)' != '' )
    if ( '' != '' ) { _CopyAppConfigFileRun = true; return; }
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", DestinationFiles: "@(AppConfigWithTargetPath->'$(OutDir)%(TargetPath)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(AppConfigWithTargetPath)");*/
    Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyAppConfigFileRun = true;
}

void _CopyManifestFiles()
{
    // if ( '$(_DeploymentCopyApplicationManifest)'=='true' or '$(GenerateClickOnceManifests)'=='true' )
    if ( ''=='true' or ''=='true' ) { _CopyManifestFilesRun = true; return; }
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(ApplicationManifest)", DestinationFolder: "$(OutDir)");*/
    /* if ('$(GenerateClickOnceManifests)'=='true' or '$(_DeploymentCopyApplicationManifest)'=='true')*/
    if (''=='true' or ''=='true')
    {
        Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll.manifest", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /*Message(Text: "$(MSBuildProjectName) -> @(_DeploymentMainApplicationManifest->'%(FullPath)')", Importance: "Normal");*/
    /* if ('$(_DeploymentCopyApplicationManifest)'=='true')*/
    if (''=='true')
    {
        Message(Text: "6 - targets -> ", Importance: "Normal");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(DeployManifest)", DestinationFolder: "$(OutDir)");*/
    /* if ('$(GenerateClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.application", DestinationFolder: "bin\\Debug\\net8.0\\");
    }
    /*Message(Text: "$(MSBuildProjectName) -> @(_DeploymentMainDeployManifest->'%(FullPath)')", Importance: "Normal");*/
    /* if ('$(GenerateClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        Message(Text: "6 - targets -> ", Importance: "Normal");
    }
    
    _CopyManifestFilesRun = true;
}

void _CheckForCompileOutputs()
{
    
    /* if (!Exists('@(DocFileItem)'))*/
    if (!Exists(''))
    {
        _DocumentationFileProduced = "false";
    }
    /* if (!Exists('@(_DebugSymbolsIntermediatePath)'))*/
    if (!Exists('obj\Debug\net8.0\6 - targets.pdb'))
    {
        _DebugSymbolsProduced = "false";
    }
    _CheckForCompileOutputsRun = true;
}

void _SGenCheckForOutputs()
{
    // if ('$(_SGenGenerateSerializationAssembliesConfig)' == 'On' or ('@(WebReferenceUrl)'!='' and '$(_SGenGenerateSerializationAssembliesConfig)' == 'Auto'))
    if ('Off' == 'On' or (''!='' and 'Off' == 'Auto')) { _SGenCheckForOutputsRun = true; return; }
    
    /* if (Exists('$(IntermediateOutputPath)$(_SGenDllName)'))*/
    if (Exists('obj\Debug\net8.0\6 - targets.XmlSerializers.dll'))
    {
        _SGenDllCreated = "true";
    }
    _SGenCheckForOutputsRun = true;
}

void UnmanagedRegistration()
{
    // if ('$(RegisterForComInterop)'=='true' and '$(OutputType)'=='library')
    if (''=='true' and 'Exe'=='library') { UnmanagedRegistrationRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /* if ('$(RegisterAssemblyMSBuildArchitecture)' == '')*/
    if ('' == '')
    {
        RegisterAssemblyMSBuildArchitecture = "$(PlatformTargetAsMSBuildArchitecture)";
    }
    /* if ('$(TargetFrameworkAsMSBuildRuntime)' != '' and '$(RegisterAssemblyMSBuildArchitecture)' != '')*/
    if ('' != '' and '' != '')
    {
        /* if ('$(RegisterAssemblyMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(RegisterAssemblyMSBuildArchitecture)`)))*/
        if ('$(RegisterAssemblyMSBuildRuntime)' == '' and
                     $([MSBuild]::DoesTaskHostExist(`$(TargetFrameworkAsMSBuildRuntime)`, `$(RegisterAssemblyMSBuildArchitecture)`)))
        {
            RegisterAssemblyMSBuildRuntime = "$(TargetFrameworkAsMSBuildRuntime)";
        }
        /* if ('$(RegisterAssemblyMSBuildRuntime)' == '')*/
        if ('' == '')
        {
            RegisterAssemblyMSBuildRuntime = "CurrentRuntime";
        }
    }
    /*RegisterAssembly(TypeLibFiles: "@(_OutputPathItem->'%(FullPath)$(TargetName).tlb')", Assemblies: "@(_OutputPathItem->'%(FullPath)$(TargetFileName)')", CreateCodeBase: "true", AssemblyListFile: "@(_UnmanagedRegistrationCache)");*/
    /* if (!Exists('@(_UnmanagedRegistrationCache)'))*/
    if (!Exists('obj\6 - targets.csproj.UnmanagedRegistration.cache'))
    {
        RegisterAssembly(TypeLibFiles: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.tlb", Assemblies: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", CreateCodeBase: "true", AssemblyListFile: "obj\\6 - targets.csproj.UnmanagedRegistration.cache");
    }
    
    UnmanagedRegistrationRun = true;
}

void IncrementalClean()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!_CleanGetCurrentAndPriorFileWritesRun) _CleanGetCurrentAndPriorFileWrites();
    
    /*FindUnderPath(Files: "@(_CleanOrphanFileWrites)", Path: "$(OutDir)");*/
    FindUnderPath(Files: "", Path: "bin\\Debug\\net8.0\\");
    /*FindUnderPath(Files: "@(_CleanOrphanFileWrites)", Path: "$(IntermediateOutputPath)");*/
    FindUnderPath(Files: "", Path: "obj\\Debug\\net8.0\\");
    /*Delete(TreatErrorsAsWarnings: "true", Files: "@(_CleanOrphanFileWritesInIntermediate);@(_CleanOrphanFileWritesInOutput)");*/
    Delete(TreatErrorsAsWarnings: "true", Files: ";");
    /*RemoveDuplicates(Inputs: "@(_CleanRemainingFileWritesAfterIncrementalClean)");*/
    RemoveDuplicates(Inputs: "");
    /*WriteLinesToFile(File: "$(IntermediateOutputPath)$(CleanFile)", Overwrite: "true", Lines: "@(_CleanUniqueRemainingFileWritesAfterIncrementalClean)");*/
    /* if ('@(_CleanUnfilteredPriorFileWrites)'!='@(_CleanUniqueRemainingFileWritesAfterIncrementalClean)')*/
    if (''!='')
    {
        WriteLinesToFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt", Overwrite: "true", Lines: "");
    }
    
    IncrementalCleanRun = true;
}

void _CleanGetCurrentAndPriorFileWrites()
{
    // DependsOnTargets;
    if (!_CheckForCompileOutputsRun) _CheckForCompileOutputs();
    if (!_SGenCheckForOutputsRun) _SGenCheckForOutputs();
    
    /*ReadLinesFromFile(File: "$(IntermediateOutputPath)$(CleanFile)");*/
    ReadLinesFromFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");
    /*ConvertToAbsolutePath(Paths: "@(_ResolveAssemblyReferenceResolvedFiles)");*/
    ConvertToAbsolutePath(Paths: "");
    /*FindUnderPath(UpdateToAbsolutePaths: "true", Files: "@(FileWritesShareable)", Path: "$(MSBuildProjectDirectory)");*/
    FindUnderPath(UpdateToAbsolutePaths: "true", Files: "", Path: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
    /*FindUnderPath(UpdateToAbsolutePaths: "true", Files: "@(FileWrites)", Path: "$(OutDir)");*/
    FindUnderPath(UpdateToAbsolutePaths: "true", Files: "", Path: "bin\\Debug\\net8.0\\");
    /*FindUnderPath(UpdateToAbsolutePaths: "true", Files: "@(FileWrites)", Path: "$(IntermediateOutputPath)");*/
    FindUnderPath(UpdateToAbsolutePaths: "true", Files: "", Path: "obj\\Debug\\net8.0\\");
    /*RemoveDuplicates(Inputs: "@(_CleanCurrentFileWritesWithNoReferences)");*/
    RemoveDuplicates(Inputs: "");
    
    _CleanGetCurrentAndPriorFileWritesRun = true;
}

void Clean()
{
    // if ( '$(_InvalidConfigurationWarning)' != 'true' )
    if ( '' != 'true' ) { CleanRun = true; return; }
    // DependsOnTargets;
    if (!BeforeCleanRun) BeforeClean();
    if (!UnmanagedUnregistrationRun) UnmanagedUnregistration();
    if (!CoreCleanRun) CoreClean();
    if (!CleanReferencedProjectsRun) CleanReferencedProjects();
    if (!CleanPublishFolderRun) CleanPublishFolder();
    if (!AfterCleanRun) AfterClean();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    // AfterTargets;
    if (!_CleanPackageFilesRun) _CleanPackageFiles();
    CleanRun = true;
}

void BeforeClean()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    BeforeCleanRun = true;
}

void AfterClean()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    AfterCleanRun = true;
}

void CleanReferencedProjects()
{
    // DependsOnTargets;
    if (!PrepareProjectReferencesRun) PrepareProjectReferences();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "Clean", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
    /* if ('$(BuildingInsideVisualStudio)' != 'true' and '$(BuildProjectReferences)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
    if ('' != 'true' and 'true' == 'true' and '' != '')
    {
        MSBuild(BuildInParallel: "true", Targets: "Clean", RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
    }
    
    CleanReferencedProjectsRun = true;
}

void CoreClean()
{
    // DependsOnTargets;
    if (!_SdkBeforeCleanRun) _SdkBeforeClean();
    if (!Run) ();
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    /*Delete(TreatErrorsAsWarnings: "true", Files: "@(Clean)");*/
    Delete(TreatErrorsAsWarnings: "true", Files: "");
    /*ReadLinesFromFile(File: "$(IntermediateOutputPath)$(CleanFile)");*/
    ReadLinesFromFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");
    /*FindUnderPath(Files: "@(_CleanPriorFileWrites)", Path: "$(OutDir)");*/
    FindUnderPath(Files: "", Path: "bin\\Debug\\net8.0\\");
    /*FindUnderPath(Files: "@(_CleanPriorFileWrites)", Path: "$(IntermediateOutputPath)");*/
    FindUnderPath(Files: "", Path: "obj\\Debug\\net8.0\\");
    /*Delete(TreatErrorsAsWarnings: "true", Files: "@(_CleanPriorFileWritesInOutput);@(_CleanPriorFileWritesInIntermediate)");*/
    Delete(TreatErrorsAsWarnings: "true", Files: ";");
    /*RemoveDuplicates(Inputs: "@(_CleanRemainingFileWritesAfterClean)");*/
    RemoveDuplicates(Inputs: "");
    /*MakeDir(Directories: "$(IntermediateOutputPath)");*/
    MakeDir(Directories: "obj\\Debug\\net8.0\\");
    /*WriteLinesToFile(File: "$(IntermediateOutputPath)$(CleanFile)", Overwrite: "true", Lines: "@(_CleanUniqueRemainingFileWrites)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    CoreCleanRun = true;
}

void _CleanRecordFileWrites()
{
    // DependsOnTargets;
    if (!_CleanGetCurrentAndPriorFileWritesRun) _CleanGetCurrentAndPriorFileWrites();
    
    /*RemoveDuplicates(Inputs: "@(_CleanPriorFileWrites);@(_CleanCurrentFileWrites)");*/
    RemoveDuplicates(Inputs: ";");
    /*MakeDir(Directories: "$(IntermediateOutputPath)");*/
    MakeDir(Directories: "obj\\Debug\\net8.0\\");
    /*WriteLinesToFile(File: "$(IntermediateOutputPath)$(CleanFile)", Overwrite: "true", Lines: "@(_CleanUniqueFileWrites)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    _CleanRecordFileWritesRun = true;
}

void CleanPublishFolder()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    /*RemoveDir(Directories: "$(ClickOncePublishDir)");*/
    /* if ('$(ClickOncePublishDir)'=='$(OutputPath)app.publish\' and Exists('$(ClickOncePublishDir)'))*/
    if ('bin\Debug\net8.0\publish\'=='bin\Debug\net8.0\app.publish\' and Exists('bin\Debug\net8.0\publish\'))
    {
        RemoveDir(Directories: "bin\\Debug\\net8.0\\publish\\");
    }
    
    CleanPublishFolderRun = true;
}

void PostBuildEvent()
{
    // if ('$(PostBuildEvent)' != '' and ('$(RunPostBuildEvent)' != 'OnOutputUpdated' or '$(_AssemblyTimestampBeforeCompile)' != '$(_AssemblyTimestampAfterCompile)'))
    if ('' != '' and ('' != 'OnOutputUpdated' or '' != '')) { PostBuildEventRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    
    /*Exec(Command: "$(PostBuildEvent)", WorkingDirectory: "$(OutDir)");*/
    Exec(Command: "", WorkingDirectory: "bin\\Debug\\net8.0\\");
    
    PostBuildEventRun = true;
}

void Publish()
{
    // if ($(IsPublishable) == 'true')
    if (true == 'true') { PublishRun = true; return; }
    // DependsOnTargets;
    if (!_PublishBuildAlternativeRun) _PublishBuildAlternative();
    if (!_PublishNoBuildAlternativeRun) _PublishNoBuildAlternative();
    // BeforeTargets;
    if (!_SuggestWasmWorkloadForBlazorRun) _SuggestWasmWorkloadForBlazor();
    if (!_CheckForLanguageAndPublishFeatureCombinationSupportRun) _CheckForLanguageAndPublishFeatureCombinationSupport();
    
    /*Message(Text: "$(MSBuildProjectName) -> $([System.IO.Path]::GetFullPath('$(PublishDir)'))", Importance: "High");*/
    Message(Text: "6 - targets -> D:\\d\\kant\\GitHub\\msbuildtranslator\\msbuildtranslator\\bin\\Debug\\net8.0\\bin\\Debug\\net8.0\\publish\\", Importance: "High");
    /*AllowEmptyTelemetry(EventData: "@(PublishTelemetry)", EventName: "PublishProperties");*/
    AllowEmptyTelemetry(EventData: "", EventName: "PublishProperties");
    
    // AfterTargets;
    if (!AfterSdkPublishRun) AfterSdkPublish();
    PublishRun = true;
}

void _DeploymentUnpublishable()
{
    
    Message(Text: "Skipping unpublishable project.");
    
    _DeploymentUnpublishableRun = true;
}

void SetGenerateManifests()
{
    
    GenerateClickOnceManifests = "true";
    /* if ('$(OutputType)'!='winexe' and '$(OutputType)'!='exe' and '$(OutputType)'!='appcontainerexe')*/
    if ('Exe'!='winexe' and 'Exe'!='exe' and 'Exe'!='appcontainerexe')
    {
        Error(Text: "Publish is only valid for 'Windows Application' or 'Console Application' project types.");
    }
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true' and '$(ManifestCertificateThumbprint)'=='' and '$(ManifestKeyFile)'=='')*/
    if (''=='true' and ''=='' and ''=='')
    {
        Error(Text: "A signing key is required in order to publish this project. Please specify a ManifestKeyFile or ManifestCertificateThumbprint value. Publishing from Visual Studio will automatically configure a signing key for this project.");
    }
    
    SetGenerateManifestsRun = true;
}

void PublishOnly()
{
    // DependsOnTargets;
    if (!SetGenerateManifestsRun) SetGenerateManifests();
    if (!PublishBuildRun) PublishBuild();
    if (!BeforePublishRun) BeforePublish();
    if (!GenerateManifestsRun) GenerateManifests();
    if (!CopyFilesToOutputDirectoryRun) CopyFilesToOutputDirectory();
    if (!_CopyFilesToPublishFolderRun) _CopyFilesToPublishFolder();
    if (!_DeploymentGenerateBootstrapperRun) _DeploymentGenerateBootstrapper();
    if (!ResolveKeySourceRun) ResolveKeySource();
    if (!_DeploymentSignClickOnceDeploymentRun) _DeploymentSignClickOnceDeployment();
    if (!AfterPublishRun) AfterPublish();
    
    PublishOnlyRun = true;
}

void BeforePublish()
{
    
    BeforePublishRun = true;
}

void AfterPublish()
{
    // BeforeTargets;
    if (!_ContainerVerifySDKVersionRun) _ContainerVerifySDKVersion();
    
    AfterPublishRun = true;
}

void PublishBuild()
{
    // DependsOnTargets;
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!ResolveReferencesRun) ResolveReferences();
    if (!PrepareResourcesRun) PrepareResources();
    if (!ResolveKeySourceRun) ResolveKeySource();
    if (!GenerateSerializationAssembliesRun) GenerateSerializationAssemblies();
    if (!CreateSatelliteAssembliesRun) CreateSatelliteAssemblies();
    if (!Run) ();
    
    PublishBuildRun = true;
}

void _CopyFilesToPublishFolder()
{
    
    _DeploymentApplicationFolderName = "Application Files\\$(AssemblyName)_$(_DeploymentApplicationVersionFragment)";
    _DeploymentApplicationDir = "$(ClickOncePublishDir)$(_DeploymentApplicationFolderName)\\";
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateHardLinksForPublishFilesIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateHardLinksForPublishFilesIfPossible = "false";
    }
    /* if ('$(BuildingInsideVisualStudio)' == 'true' or '$(CreateSymbolicLinksForPublishFilesIfPossible)' == '')*/
    if ('' == 'true' or '' == '')
    {
        CreateSymbolicLinksForPublishFilesIfPossible = "false";
    }
    /*FormatVersion(FormatType: "Path", Version: "$(ApplicationVersion)", Revision: "$(ApplicationRevision)");*/
    FormatVersion(FormatType: "Path", Version: "", Revision: "");
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: """@(_ApplicationManifestFinal->'$(_DeploymentApplicationDir)%(TargetPath)');
                @(_DeploymentManifestEntryPoint->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                @(_DeploymentManifestFiles->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                @(ReferenceComWrappersToCopyLocal->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)');
                @(ResolvedIsolatedComModules->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)');
                @(_DeploymentLooseManifestFile->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)')""", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: """@(_ApplicationManifestFinal);
                @(_DeploymentResolvedManifestEntryPoint);
                @(_DeploymentManifestFiles);
                @(ReferenceComWrappersToCopyLocal);
                @(ResolvedIsolatedComModules);
                @(_DeploymentLooseManifestFile)""");*/
    /* if ('$(PublishSingleFile)' != 'true')*/
    if ('' != 'true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: """6 - targets.dll.manifest;
                6 - targets.dll;
                ;
                ;
                ;
                """, UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: """bin\\Debug\\net8.0\\6 - targets.dll.manifest;
                ;
                ;
                ;
                ;
                """);
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: "@(_DeploymentManifestDependencies->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_DeploymentManifestDependencies)");*/
    /* if ('$(PublishSingleFile)' != 'true' and '%(_DeploymentManifestDependencies.DependencyType)'=='Install')*/
    if ('' != 'true' and '%(_DeploymentManifestDependencies.DependencyType)'=='Install')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: "@(_ReferenceScatterPaths->'$(_DeploymentApplicationDir)%(Filename)%(Extension)$(_DeploymentFileMappingExtension)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ReferenceScatterPaths)");*/
    /* if ('$(PublishSingleFile)' != 'true')*/
    if ('' != 'true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: """@(_ApplicationManifestFinal->'$(_DeploymentApplicationDir)%(TargetPath)');
                 @(_DeploymentManifestEntryPoint->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                 @(PublishedSingleFileToBeCopied->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)')""", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: """@(_ApplicationManifestFinal);
                 @(_DeploymentResolvedManifestEntryPoint);
                 @(PublishedSingleFileToBeCopied);""");*/
    /* if ('$(PublishSingleFile)' == 'true')*/
    if ('' == 'true')
    {
        Copy(UseHardlinksIfPossible: "", DestinationFiles: """6 - targets.dll.manifest;
                 6 - targets.dll;
                 """, UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: """bin\\Debug\\net8.0\\6 - targets.dll.manifest;
                 ;
                 ;""");
    }
    /*FormatUrl(InputUrl: "$(_DeploymentApplicationUrl)");*/
    FormatUrl(InputUrl: "");
    /*FormatUrl(InputUrl: "$(_DeploymentComponentsUrl)");*/
    FormatUrl(InputUrl: "");
    
    _CopyFilesToPublishFolderRun = true;
}

void _DeploymentGenerateBootstrapper()
{
    
    /*GenerateBootstrapper(ApplicationName: "$(AssemblyName)", SupportUrl: "$(_DeploymentFormattedSupportUrl)", VisualStudioVersion: "$(VisualStudioVersion)", OutputPath: "$(ClickOncePublishDir)", ComponentsLocation: "$(BootstrapperComponentsLocation)", ComponentsUrl: "$(_DeploymentFormattedComponentsUrl)", ApplicationUrl: "$(_DeploymentFormattedApplicationUrl)", BootstrapperItems: "@(BootstrapperPackage)", FallbackCulture: "$(FallbackCulture)", ApplicationFile: "$(TargetDeployManifestFileName)", Culture: "$(TargetCulture)", Path: "$(GenerateBootstrapperSdkPath)");*/
    /* if ('$(BootstrapperEnabled)'=='true')*/
    if (''=='true')
    {
        GenerateBootstrapper(ApplicationName: "6 - targets", SupportUrl: "", VisualStudioVersion: "17.0", OutputPath: "bin\\Debug\\net8.0\\publish\\", ComponentsLocation: "", ComponentsUrl: "", ApplicationUrl: "", BootstrapperItems: "", FallbackCulture: "", ApplicationFile: "6 - targets.application", Culture: "*", Path: "");
    }
    
    _DeploymentGenerateBootstrapperRun = true;
}

void _DeploymentSignClickOnceDeployment()
{
    
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", DisallowMansignTimestampFallback: "$(DisallowMansignTimestampFallback)", SigningTarget: "$(_DeploymentApplicationDir)$(_DeploymentTargetApplicationManifestFileName)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", DisallowMansignTimestampFallback: "", SigningTarget: "6 - targets.dll.manifest", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*UpdateManifest(ApplicationPath: "$(_DeploymentApplicationFolderName)\\$(_DeploymentTargetApplicationManifestFileName)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", ApplicationManifest: "$(_DeploymentApplicationDir)$(_DeploymentTargetApplicationManifestFileName)", OutputManifest: "$(ClickOncePublishDir)$(TargetDeployManifestFileName)", InputManifest: "$(OutDir)$(TargetDeployManifestFileName)");*/
    UpdateManifest(ApplicationPath: "\\6 - targets.dll.manifest", TargetFrameworkVersion: "", ApplicationManifest: "6 - targets.dll.manifest", OutputManifest: "bin\\Debug\\net8.0\\publish\\6 - targets.application", InputManifest: "bin\\Debug\\net8.0\\6 - targets.application");
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", DisallowMansignTimestampFallback: "$(DisallowMansignTimestampFallback)", SigningTarget: "$(ClickOncePublishDir)$(TargetDeployManifestFileName)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
    if (''=='true')
    {
        SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", DisallowMansignTimestampFallback: "", SigningTarget: "bin\\Debug\\net8.0\\publish\\6 - targets.application", TargetFrameworkIdentifier: ".NETCoreApp", TimestampUrl: "");
    }
    /*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", SigningTarget: "$(ClickOncePublishDir)setup.exe", TimestampUrl: "$(ManifestTimestampUrl)");*/
    /* if ('$(BootstrapperEnabled)'=='true' and '$(_DeploymentSignClickOnceManifests)'=='true')*/
    if (''=='true' and ''=='true')
    {
        SignFile(CertificateThumbprint: "", SigningTarget: "bin\\Debug\\net8.0\\publish\\setup.exe", TimestampUrl: "");
    }
    
    _DeploymentSignClickOnceDeploymentRun = true;
}

void AllProjectOutputGroups()
{
    // DependsOnTargets;
    if (!BuiltProjectOutputGroupRun) BuiltProjectOutputGroup();
    if (!DebugSymbolsProjectOutputGroupRun) DebugSymbolsProjectOutputGroup();
    if (!DocumentationProjectOutputGroupRun) DocumentationProjectOutputGroup();
    if (!SatelliteDllsProjectOutputGroupRun) SatelliteDllsProjectOutputGroup();
    if (!SourceFilesProjectOutputGroupRun) SourceFilesProjectOutputGroup();
    if (!ContentFilesProjectOutputGroupRun) ContentFilesProjectOutputGroup();
    if (!SGenFilesOutputGroupRun) SGenFilesOutputGroup();
    
    AllProjectOutputGroupsRun = true;
}

void BuiltProjectOutputGroup()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    // BeforeTargets;
    if (!AddRuntimeConfigFileToBuiltProjectOutputGroupOutputRun) AddRuntimeConfigFileToBuiltProjectOutputGroupOutput();
    
    BuiltProjectOutputGroupRun = true;
}

void DebugSymbolsProjectOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    
    DebugSymbolsProjectOutputGroupRun = true;
}

void DocumentationProjectOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    
    DocumentationProjectOutputGroupRun = true;
}

void SatelliteDllsProjectOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!PrepareResourceNamesRun) PrepareResourceNames();
    
    SatelliteDllsProjectOutputGroupRun = true;
}

void SourceFilesProjectOutputGroup()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    
    /*AssignTargetPath(RootFolder: "$(MSBuildProjectDirectory)", Files: "@(Compile)");*/
    AssignTargetPath(RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", Files: "Program.cs");
    
    SourceFilesProjectOutputGroupRun = true;
}

void GetCompile()
{
    
    GetCompileRun = true;
}

void ContentFilesProjectOutputGroup()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    
    ContentFilesProjectOutputGroupRun = true;
}

void SGenFilesOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    
    SGenFilesOutputGroupRun = true;
}

void GetResolvedSDKReferences()
{
    // DependsOnTargets;
    if (!ResolveSDKReferencesRun) ResolveSDKReferences();
    
    GetResolvedSDKReferencesRun = true;
}

void CollectReferencedNuGetPackages()
{
    
    CollectReferencedNuGetPackagesRun = true;
}

void GenerateSupportedTargetFrameworkAlias()
{
    
    /*GenerateSupportedTargetFrameworkAlias(UseWindowsForms: "$(UseWindowsForms)", SupportedTargetFramework: "@(SupportedTargetFramework)", UseWpf: "$(UseWpf)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", TargetPlatformMoniker: "$(TargetPlatformMoniker)");*/
    GenerateSupportedTargetFrameworkAlias(UseWindowsForms: "", SupportedTargetFramework: ".NETCoreApp,Version=v1.0;.NETCoreApp,Version=v1.1;.NETCoreApp,Version=v2.0;.NETCoreApp,Version=v2.1;.NETCoreApp,Version=v2.2;.NETCoreApp,Version=v3.0;.NETCoreApp,Version=v3.1;.NETCoreApp,Version=v5.0;.NETCoreApp,Version=v6.0;.NETCoreApp,Version=v7.0;.NETCoreApp,Version=v8.0;.NETStandard,Version=v1.0;.NETStandard,Version=v1.1;.NETStandard,Version=v1.2;.NETStandard,Version=v1.3;.NETStandard,Version=v1.4;.NETStandard,Version=v1.5;.NETStandard,Version=v1.6;.NETStandard,Version=v2.0;.NETStandard,Version=v2.1;.NETFramework,Version=v2.0;.NETFramework,Version=v3.0;.NETFramework,Version=v3.5;.NETFramework,Version=v4.0;.NETFramework,Version=v4.5;.NETFramework,Version=v4.5.1;.NETFramework,Version=v4.5.2;.NETFramework,Version=v4.6;.NETFramework,Version=v4.6.1;.NETFramework,Version=v4.6.2;.NETFramework,Version=v4.7;.NETFramework,Version=v4.7.1;.NETFramework,Version=v4.7.2;.NETFramework,Version=v4.8;.NETFramework,Version=v4.8.1", UseWpf: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", TargetPlatformMoniker: "");
    
    GenerateSupportedTargetFrameworkAliasRun = true;
}

void PriFilesOutputGroup()
{
    // if ('@(_ReferenceRelatedPaths)' != '')
    if ('' != '') { PriFilesOutputGroupRun = true; return; }
    // DependsOnTargets;
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    PriFilesOutputGroupRun = true;
}

void SDKRedistOutputGroup()
{
    // DependsOnTargets;
    if (!ResolveSDKReferencesRun) ResolveSDKReferences();
    if (!ExpandSDKReferencesRun) ExpandSDKReferences();
    
    SDKRedistOutputGroupRun = true;
}

void AllProjectOutputGroupsDependencies()
{
    // DependsOnTargets;
    if (!BuiltProjectOutputGroupDependenciesRun) BuiltProjectOutputGroupDependencies();
    if (!DebugSymbolsProjectOutputGroupDependenciesRun) DebugSymbolsProjectOutputGroupDependencies();
    if (!SatelliteDllsProjectOutputGroupDependenciesRun) SatelliteDllsProjectOutputGroupDependencies();
    if (!DocumentationProjectOutputGroupDependenciesRun) DocumentationProjectOutputGroupDependencies();
    if (!SGenFilesOutputGroupDependenciesRun) SGenFilesOutputGroupDependencies();
    
    AllProjectOutputGroupsDependenciesRun = true;
}

void BuiltProjectOutputGroupDependencies()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    BuiltProjectOutputGroupDependenciesRun = true;
}

void DebugSymbolsProjectOutputGroupDependencies()
{
    // if ('$(DebugSymbols)'!='false')
    if ('true'!='false') { DebugSymbolsProjectOutputGroupDependenciesRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    DebugSymbolsProjectOutputGroupDependenciesRun = true;
}

void SatelliteDllsProjectOutputGroupDependencies()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    SatelliteDllsProjectOutputGroupDependenciesRun = true;
}

void DocumentationProjectOutputGroupDependencies()
{
    // if ('$(DocumentationFile)'!='')
    if (''!='') { DocumentationProjectOutputGroupDependenciesRun = true; return; }
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    DocumentationProjectOutputGroupDependenciesRun = true;
}

void SGenFilesOutputGroupDependencies()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    SGenFilesOutputGroupDependenciesRun = true;
}

void ReferenceCopyLocalPathsOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    
    ReferenceCopyLocalPathsOutputGroupRun = true;
}

void DesignerRuntimeImplementationProjectOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!Run) ();
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!AssignTargetPathsRun) AssignTargetPaths();
    if (!ResolveReferencesRun) ResolveReferences();
    if (!_GenerateDesignerDepsFileRun) _GenerateDesignerDepsFile();
    if (!_GenerateDesignerRuntimeConfigFileRun) _GenerateDesignerRuntimeConfigFile();
    if (!GetCopyToOutputDirectoryItemsRun) GetCopyToOutputDirectoryItems();
    if (!_GatherDesignerShadowCopyFilesRun) _GatherDesignerShadowCopyFiles();
    if (!Run) ();
    
    DesignerRuntimeImplementationProjectOutputGroupRun = true;
}

void GetPotentialEditorConfigFiles()
{
    
    GetPotentialEditorConfigFilesRun = true;
}

void CleanAppxPackage()
{
    
    CleanAppxPackageRun = true;
}

void GetPackagingOutputs()
{
    
    GetPackagingOutputsRun = true;
}

void Restore()
{
    // DependsOnTargets;
    if (!_GenerateRestoreGraphRun) _GenerateRestoreGraph();
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetFrameworkRun) _CheckForUnsupportedTargetFramework();
    if (!_CheckForUnsupportedNETCoreVersionRun) _CheckForUnsupportedNETCoreVersion();
    if (!_CheckForUnsupportedCppNETCoreVersionRun) _CheckForUnsupportedCppNETCoreVersion();
    if (!_CheckForUnsupportedNETStandardVersionRun) _CheckForUnsupportedNETStandardVersion();
    if (!_CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun) _CheckForUnsupportedTargetFrameworkAndFeatureCombination();
    
    /*RemoveDuplicates(Inputs: "@(_RestoreGraphEntry)");*/
    RemoveDuplicates(Inputs: "");
    /*RestoreTask(RestoreNoHttpCache: "$(RestoreNoHttpCache)", HideWarningsAndErrors: "$(HideWarningsAndErrors)", RestorePackagesConfig: "$(RestorePackagesConfig)", RestoreForce: "$(RestoreForce)", EmbedFilesInBinlog: "$(RestoreEmbedFilesInBinlog)", Interactive: "$(NuGetInteractive)", RestoreNoCache: "$(RestoreNoCache)", RestoreIgnoreFailedSources: "$(RestoreIgnoreFailedSources)", RestoreGraphItems: "@(_RestoreGraphEntryFiltered)", RestoreForceEvaluate: "$(RestoreForceEvaluate)", RestoreDisableParallel: "$(RestoreDisableParallel)", RestoreRecursive: "$(RestoreRecursive)");*/
    RestoreTask(RestoreNoHttpCache: "", HideWarningsAndErrors: "false", RestorePackagesConfig: "", RestoreForce: "", EmbedFilesInBinlog: "", Interactive: "", RestoreNoCache: "", RestoreIgnoreFailedSources: "", RestoreGraphItems: "", RestoreForceEvaluate: "", RestoreDisableParallel: "", RestoreRecursive: "true");
    
    RestoreRun = true;
}

void GenerateRestoreGraphFile()
{
    // DependsOnTargets;
    if (!_GenerateRestoreGraphRun) _GenerateRestoreGraph();
    
    /* if ($(RestoreGraphOutputPath) == '')*/
    if ( == '')
    {
        Error(Text: "Missing RestoreGraphOutputPath property!");
    }
    /*RemoveDuplicates(Inputs: "@(_RestoreGraphEntry)");*/
    RemoveDuplicates(Inputs: "");
    /*WriteRestoreGraphTask(RestoreGraphOutputPath: "$(RestoreGraphOutputPath)", RestoreGraphItems: "@(_RestoreGraphEntryFiltered)", RestoreRecursive: "$(RestoreRecursive)");*/
    WriteRestoreGraphTask(RestoreGraphOutputPath: "", RestoreGraphItems: "", RestoreRecursive: "true");
    
    GenerateRestoreGraphFileRun = true;
}

void CollectPackageReferences()
{
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetPlatformIdentifierRun) _CheckForUnsupportedTargetPlatformIdentifier();
    if (!_CheckForUnsupportedNETCoreVersionRun) _CheckForUnsupportedNETCoreVersion();
    if (!_CheckForUnsupportedCppNETCoreVersionRun) _CheckForUnsupportedCppNETCoreVersion();
    if (!_CheckForUnsupportedNETStandardVersionRun) _CheckForUnsupportedNETStandardVersion();
    if (!_CheckForUnsupportedTargetFrameworkAndFeatureCombinationRun) _CheckForUnsupportedTargetFrameworkAndFeatureCombination();
    if (!ApplyImplicitVersionsRun) ApplyImplicitVersions();
    if (!CheckForImplicitPackageReferenceOverridesRun) CheckForImplicitPackageReferenceOverrides();
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    if (!IncludeTargetingPackReferenceRun) IncludeTargetingPackReference();
    if (!_AddMicrosoftNetCompilerToolsetFrameworkPackageRun) _AddMicrosoftNetCompilerToolsetFrameworkPackage();
    if (!_CheckForObsoleteDotNetCliToolReferencesRun) _CheckForObsoleteDotNetCliToolReferences();
    
    CollectPackageReferencesContinueOnError = "$(ContinueOnError)";
    /* if ('$(ContinueOnError)' == '' )*/
    if ('false' == '' )
    {
        CollectPackageReferencesContinueOnError = "false";
    }
    /*CheckForDuplicateNuGetItemsTask(WarningsAsErrors: "$(WarningsAsErrors)", Items: "@(PackageReference)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ItemName: "PackageReference", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", NoWarn: "$(NoWarn)", LogCode: "NU1504", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
    /* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
    if ('' != 'true' )
    {
        CheckForDuplicateNuGetItemsTask(WarningsAsErrors: ";NU1605;SYSLIB0011", Items: "", WarningsNotAsErrors: "", ItemName: "PackageReference", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", NoWarn: "1701;1702", LogCode: "NU1504", TreatWarningsAsErrors: "false");
    }
    
    CollectPackageReferencesRun = true;
}

void CollectCentralPackageVersions()
{
    
    CollectCentralPackageVersionsContinueOnError = "$(ContinueOnError)";
    /* if ('$(ContinueOnError)' == '' )*/
    if ('false' == '' )
    {
        CollectCentralPackageVersionsContinueOnError = "false";
    }
    /*CheckForDuplicateNuGetItemsTask(WarningsAsErrors: "$(WarningsAsErrors)", Items: "@(PackageVersion)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ItemName: "PackageVersion", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", NoWarn: "$(NoWarn)", LogCode: "NU1506", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
    /* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
    if ('' != 'true' )
    {
        CheckForDuplicateNuGetItemsTask(WarningsAsErrors: ";NU1605;SYSLIB0011", Items: "", WarningsNotAsErrors: "", ItemName: "PackageVersion", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", NoWarn: "1701;1702", LogCode: "NU1506", TreatWarningsAsErrors: "false");
    }
    
    CollectCentralPackageVersionsRun = true;
}

void CollectPackageDownloads()
{
    // BeforeTargets;
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    
    CollectPackageDownloadsContinueOnError = "$(ContinueOnError)";
    /* if ('$(ContinueOnError)' == '' )*/
    if ('false' == '' )
    {
        CollectPackageDownloadsContinueOnError = "false";
    }
    /*CheckForDuplicateNuGetItemsTask(WarningsAsErrors: "$(WarningsAsErrors)", Items: "@(PackageDownload)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ItemName: "PackageDownload", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", NoWarn: "$(NoWarn)", LogCode: "NU1505", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
    /* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
    if ('' != 'true' )
    {
        CheckForDuplicateNuGetItemsTask(WarningsAsErrors: ";NU1605;SYSLIB0011", Items: "", WarningsNotAsErrors: "", ItemName: "PackageDownload", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", NoWarn: "1701;1702", LogCode: "NU1505", TreatWarningsAsErrors: "false");
    }
    
    CollectPackageDownloadsRun = true;
}

void CollectFrameworkReferences()
{
    
    CollectFrameworkReferencesRun = true;
}

void _LoadRestoreGraphEntryPoints()
{
    
    /*GetRestoreSolutionProjectsTask(SolutionFilePath: "$(MSBuildProjectFullPath)", ProjectReferences: "@(ProjectReference)");*/
    /* if ( $(MSBuildProjectFullPath.EndsWith('.metaproj')) == 'true' AND @(RestoreGraphProjectInputItems) == '' )*/
    if ( False == 'true' AND  == '' )
    {
        GetRestoreSolutionProjectsTask(SolutionFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ProjectReferences: "");
    }
    
    _LoadRestoreGraphEntryPointsRun = true;
}

void _FilterRestoreGraphProjectInputItems()
{
    // DependsOnTargets;
    if (!_LoadRestoreGraphEntryPointsRun) _LoadRestoreGraphEntryPoints();
    
    /* if ( '$(RestoreProjectFilterMode)' == '' )*/
    if ( '' == '' )
    {
        RestoreProjectFilterMode = "exclusionlist";
    }
    /*RemoveDuplicates(Inputs: "@(_FilteredRestoreGraphProjectInputItemsTmp)");*/
    RemoveDuplicates(Inputs: "");
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentTargets: "true", Targets: "_IsProjectRestoreSupported", Projects: "@(FilteredRestoreGraphProjectInputItemsWithoutDuplicates)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
    if ( 'true' == 'true' )
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "_IsProjectRestoreSupported", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    }
    /*MSBuild(Targets: "_IsProjectRestoreSupported", Projects: "@(FilteredRestoreGraphProjectInputItemsWithoutDuplicates)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
    if ( 'true' != 'true' )
    {
        MSBuild(Targets: "_IsProjectRestoreSupported", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    }
    /*WarnForInvalidProjectsTask(AllProjects: "@(FilteredRestoreGraphProjectInputItemsWithoutDuplicates)", ValidProjects: "@(FilteredRestoreGraphProjectInputItems)");*/
    /* if ( '$(DisableWarnForInvalidRestoreProjects)' != 'true' AND '$(HideWarningsAndErrors)' != 'true' )*/
    if ( '' != 'true' AND 'false' != 'true' )
    {
        WarnForInvalidProjectsTask(AllProjects: "", ValidProjects: "");
    }
    
    _FilterRestoreGraphProjectInputItemsRun = true;
}

void _GenerateRestoreGraph()
{
    // DependsOnTargets;
    if (!_FilterRestoreGraphProjectInputItemsRun) _FilterRestoreGraphProjectInputItems();
    if (!_GetAllRestoreProjectPathItemsRun) _GetAllRestoreProjectPathItems();
    
    Message(Text: "Generating dg file", Importance: "low");
    Message(Text: "%(_RestoreProjectPathItems.Identity)", Importance: "low");
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GenerateRestoreGraphProjectEntry", Projects: "@(_GenerateRestoreGraphProjectEntryInput)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    MSBuild(BuildInParallel: "true", Targets: "_GenerateRestoreGraphProjectEntry", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GenerateProjectRestoreGraph", Projects: "@(_RestoreProjectPathItems)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    MSBuild(BuildInParallel: "true", Targets: "_GenerateProjectRestoreGraph", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    
    _GenerateRestoreGraphRun = true;
}

void _GenerateRestoreGraphProjectEntry()
{
    // DependsOnTargets;
    if (!_GenerateRestoreSpecsRun) _GenerateRestoreSpecs();
    if (!_GenerateDotnetCliToolReferenceSpecsRun) _GenerateDotnetCliToolReferenceSpecs();
    
    _GenerateRestoreGraphProjectEntryRun = true;
}

void _GenerateRestoreSpecs()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    
    /*Message(Text: "Restore entry point $(MSBuildProjectFullPath)", Importance: "low");*/
    Message(Text: "Restore entry point D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Importance: "low");
    
    _GenerateRestoreSpecsRun = true;
}

void _GenerateDotnetCliToolReferenceSpecs()
{
    // DependsOnTargets;
    if (!_GetRestoreSettingsRun) _GetRestoreSettings();
    
    /* if ( '$(DotnetCliToolTargetFramework)' == '' )*/
    if ( 'netcoreapp2.2' == '' )
    {
        DotnetCliToolTargetFramework = "netcoreapp1.0";
    }
    /*GetRestoreDotnetCliToolsTask(ToolFramework: "$(DotnetCliToolTargetFramework)", RestoreSources: "$(_OutputSources)", DotnetCliToolReferences: "@(DotnetCliToolReference)", RestoreConfigFilePaths: "$(_OutputConfigFilePaths)", RestoreFallbackFolders: "$(_OutputFallbackFolders)", RestorePackagesPath: "$(_OutputPackagesPath)", ProjectPath: "$(MSBuildProjectFullPath)");*/
    /* if ( '$(RestoreDotnetCliToolReferences)' == '' OR '$(RestoreDotnetCliToolReferences)' == 'true' )*/
    if ( '' == '' OR '' == 'true' )
    {
        GetRestoreDotnetCliToolsTask(ToolFramework: "netcoreapp2.2", RestoreSources: "", DotnetCliToolReferences: "", RestoreConfigFilePaths: "", RestoreFallbackFolders: "", RestorePackagesPath: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    
    _GenerateDotnetCliToolReferenceSpecsRun = true;
}

void _GetProjectJsonPath()
{
    
    /*GetRestoreProjectJsonPathTask(ProjectPath: "$(MSBuildProjectFullPath)");*/
    /* if ( '$(RestoreProjectStyle)' == 'ProjectJson' OR '$(RestoreProjectStyle)' == '' )*/
    if ( 'PackageReference' == 'ProjectJson' OR 'PackageReference' == '' )
    {
        GetRestoreProjectJsonPathTask(ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    
    _GetProjectJsonPathRun = true;
}

void _GetRestoreProjectStyle()
{
    // DependsOnTargets;
    if (!_GetProjectJsonPathRun) _GetProjectJsonPath();
    if (!CollectPackageReferencesRun) CollectPackageReferences();
    
    /* if ('$(MSBuildAssemblyVersion)' < '15.0')*/
    if ('17.0' < '15.0')
    {
        /* if ('@(PackageReference)' != '')*/
        if ('' != '')
        {
            _HasPackageReferenceItems = "true";
        }
    }
    /* if ('$(MSBuildAssemblyVersion)' >= '15.0')*/
    if ('17.0' >= '15.0')
    {
        /* if (@(PackageReference->Count()) > 0)*/
        if (0 > 0)
        {
            _HasPackageReferenceItems = "true";
        }
    }
    _HasPackageReferenceItems = "";
    /*GetRestoreProjectStyleTask(MSBuildProjectName: "$(MSBuildProjectName)", MSBuildProjectDirectory: "$(MSBuildProjectDirectory)", HasPackageReferenceItems: "$(_HasPackageReferenceItems)", RestoreProjectStyle: "$(RestoreProjectStyle)", ProjectJsonPath: "$(_CurrentProjectJsonPath)");*/
    GetRestoreProjectStyleTask(MSBuildProjectName: "6 - targets", MSBuildProjectDirectory: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", HasPackageReferenceItems: "", RestoreProjectStyle: "PackageReference", ProjectJsonPath: "");
    
    _GetRestoreProjectStyleRun = true;
}

void EnableIntermediateOutputPathMismatchWarning()
{
    // if ('$(RestoreProjectStyle)' == 'PackageReference')
    if ('PackageReference' == 'PackageReference') { EnableIntermediateOutputPathMismatchWarningRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    
    /* if ('$(EnableBaseIntermediateOutputPathMismatchWarning)' == '')*/
    if ('' == '')
    {
        EnableBaseIntermediateOutputPathMismatchWarning = "true";
    }
    EnableIntermediateOutputPathMismatchWarningRun = true;
}

void _GetRestoreTargetFrameworksOutput()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    if (!_GetRestoreTargetFrameworkOverrideRun) _GetRestoreTargetFrameworkOverride();
    
    _RestoreProjectFramework = "";
    /* if ( '$(_TargetFrameworkOverride)' == '' )*/
    if ( '' == '' )
    {
        _TargetFrameworkToBeUsed = "$(TargetFrameworks)";
    }
    /*GetProjectTargetFrameworksTask(TargetPlatformMinVersion: "$(TargetPlatformMinVersion)", TargetFramework: "$(TargetFramework)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", TargetFrameworks: "$(_TargetFrameworkToBeUsed)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", ProjectPath: "$(MSBuildProjectFullPath)");*/
    /* if ( '$(RestoreProjectStyle)' != 'ProjectJson')*/
    if ( 'PackageReference' != 'ProjectJson')
    {
        GetProjectTargetFrameworksTask(TargetPlatformMinVersion: "", TargetFramework: "net8.0", TargetPlatformIdentifier: "", TargetPlatformVersion: "", TargetFrameworks: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    
    _GetRestoreTargetFrameworksOutputRun = true;
}

void _GetRestoreTargetFrameworksAsItems()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    if (!_GetRestoreTargetFrameworkOverrideRun) _GetRestoreTargetFrameworkOverride();
    
    _GetRestoreTargetFrameworksAsItemsRun = true;
}

void _GetRestoreSettings()
{
    // if ( '$(RestoreProjectStyle)' == 'PackageReference' OR '$(RestoreProjectStyle)' == 'ProjectJson' OR '$(RestoreProjectStyle)' == 'DotnetToolReference' OR '$(RestoreProjectStyle)' == 'PackagesConfig')
    if ( 'PackageReference' == 'PackageReference' OR 'PackageReference' == 'ProjectJson' OR 'PackageReference' == 'DotnetToolReference' OR 'PackageReference' == 'PackagesConfig') { _GetRestoreSettingsRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreSettingsOverridesRun) _GetRestoreSettingsOverrides();
    if (!_GetRestoreSettingsCurrentProjectRun) _GetRestoreSettingsCurrentProject();
    if (!_GetRestoreSettingsAllFrameworksRun) _GetRestoreSettingsAllFrameworks();
    
    /* if ( '$(RestoreSolutionDirectory)' == '' AND '$(RestoreProjectStyle)' == 'PackagesConfig' AND '$(SolutionDir)' != '*Undefined*')*/
    if ( '' == '' AND 'PackageReference' == 'PackagesConfig' AND '*Undefined*' != '*Undefined*')
    {
        RestoreSolutionDirectory = "$(SolutionDir)";
    }
    /*GetRestoreSettingsTask(MSBuildStartupDirectory: "$(MSBuildStartupDirectory)", RestorePackagesPathOverride: "$(_RestorePackagesPathOverride)", RestoreRepositoryPathOverride: "$(_RestoreRepositoryPathOverride)", RestoreFallbackFoldersOverride: "$(_RestoreFallbackFoldersOverride)", RestoreSources: "$(RestoreSources)", RestoreConfigFile: "$(RestoreConfigFile)", RestoreSourcesOverride: "$(_RestoreSourcesOverride)", ProjectUniqueName: "$(MSBuildProjectFullPath)", RestoreFallbackFolders: "$(RestoreFallbackFolders)", RestoreRootConfigDirectory: "$(RestoreRootConfigDirectory)", RestoreSettingsPerFramework: "@(_RestoreSettingsPerFramework)", RestoreProjectStyle: "$(RestoreProjectStyle)", RestorePackagesPath: "$(RestorePackagesPath)", RestoreRepositoryPath: "$(RestoreRepositoryPath)", RestoreSolutionDirectory: "$(RestoreSolutionDirectory)");*/
    GetRestoreSettingsTask(MSBuildStartupDirectory: "D:\\d\\kant\\GitHub\\msbuildtranslator\\msbuildtranslator\\bin\\Debug\\net8.0", RestorePackagesPathOverride: "", RestoreRepositoryPathOverride: "", RestoreFallbackFoldersOverride: "", RestoreSources: "", RestoreConfigFile: "", RestoreSourcesOverride: "", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", RestoreFallbackFolders: "", RestoreRootConfigDirectory: "", RestoreSettingsPerFramework: "", RestoreProjectStyle: "PackageReference", RestorePackagesPath: "", RestoreRepositoryPath: "", RestoreSolutionDirectory: "");
    
    _GetRestoreSettingsRun = true;
}

void _GetRestoreSettingsCurrentProject()
{
    // if ( '$(TargetFrameworks)' == '' AND '$(PackageReferenceCompatibleProjectStyle)' == 'true' )
    if ( '' == '' AND '' == 'true' ) { _GetRestoreSettingsCurrentProjectRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreSettingsPerFrameworkRun) _GetRestoreSettingsPerFramework();
    
    _GetRestoreSettingsCurrentProjectRun = true;
}

void _GetRestoreSettingsAllFrameworks()
{
    // if ( '$(TargetFrameworks)' != '' AND '$(PackageReferenceCompatibleProjectStyle)' == 'true' )
    if ( '' != '' AND '' == 'true' ) { _GetRestoreSettingsAllFrameworksRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreTargetFrameworksAsItemsRun) _GetRestoreTargetFrameworksAsItems();
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GetRestoreSettingsPerFramework", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
    MSBuild(BuildInParallel: "true", Targets: "_GetRestoreSettingsPerFramework", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""");
    
    _GetRestoreSettingsAllFrameworksRun = true;
}

void _GetRestoreSettingsPerFramework()
{
    
    _GetRestoreSettingsPerFrameworkRun = true;
}

void _GenerateRestoreProjectSpec()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    if (!_GetRestoreTargetFrameworksOutputRun) _GetRestoreTargetFrameworksOutput();
    if (!_GetRestoreSettingsRun) _GetRestoreSettings();
    
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' OR '$(RestoreProjectStyle)' == 'ProjectJson' )*/
    if ( '' == 'true' OR 'PackageReference' == 'ProjectJson' )
    {
        /* if ( '$(RestoreOutputPath)' == '' )*/
        if ( 'D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\' == '' )
        {
            RestoreOutputPath = "$(MSBuildProjectExtensionsPath)";
        }
    }
    _RestoreProjectName = "$(MSBuildProjectName)";
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(AssemblyName)' != '' )*/
    if ( '' == 'true' AND '6 - targets' != '' )
    {
        _RestoreProjectName = "$(AssemblyName)";
    }
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(PackageId)' != '' )*/
    if ( '' == 'true' AND '6 - targets' != '' )
    {
        _RestoreProjectName = "$(PackageId)";
    }
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
    if ( '' == 'true' )
    {
        _RestoreProjectVersion = "1.0.0";
        /* if ( '$(Version)' != '' )*/
        if ( '1.0.0' != '' )
        {
            _RestoreProjectVersion = "$(Version)";
        }
        /* if ( '$(PackageVersion)' != '' )*/
        if ( '1.0.0' != '' )
        {
            _RestoreProjectVersion = "$(PackageVersion)";
        }
    }
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(TargetFrameworks)' != '' )*/
    if ( '' == 'true' AND '' != '' )
    {
        _RestoreCrossTargeting = "true";
    }
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(_RestoreSkipContentFileWrite)' == '' )*/
    if ( '' == 'true' AND '' == '' )
    {
        /* if ( '$(TargetFrameworks)' == '' AND '$(TargetFramework)' == '' )*/
        if ( '' == '' AND 'net8.0' == '' )
        {
            _RestoreSkipContentFileWrite = "true";
        }
    }
    /*ConvertToAbsolutePath(Paths: "$(RestoreOutputPath)");*/
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' OR '$(RestoreProjectStyle)' == 'ProjectJson')*/
    if ( '' == 'true' OR 'PackageReference' == 'ProjectJson')
    {
        ConvertToAbsolutePath(Paths: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\");
    }
    
    _GenerateRestoreProjectSpecRun = true;
}

void _GenerateProjectRestoreGraph()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    if (!_GenerateRestoreProjectSpecRun) _GenerateRestoreProjectSpec();
    if (!_GenerateRestoreDependenciesRun) _GenerateRestoreDependencies();
    
    _GenerateProjectRestoreGraphRun = true;
}

void _GenerateRestoreDependencies()
{
    // DependsOnTargets;
    if (!_GenerateProjectRestoreGraphAllFrameworksRun) _GenerateProjectRestoreGraphAllFrameworks();
    if (!_GenerateProjectRestoreGraphCurrentProjectRun) _GenerateProjectRestoreGraphCurrentProject();
    
    _GenerateRestoreDependenciesRun = true;
}

void _GenerateProjectRestoreGraphAllFrameworks()
{
    // if ( '$(TargetFrameworks)' != '' )
    if ( '' != '' ) { _GenerateProjectRestoreGraphAllFrameworksRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreTargetFrameworksAsItemsRun) _GetRestoreTargetFrameworksAsItems();
    
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GenerateProjectRestoreGraphPerFramework", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
    MSBuild(BuildInParallel: "true", Targets: "_GenerateProjectRestoreGraphPerFramework", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""");
    
    _GenerateProjectRestoreGraphAllFrameworksRun = true;
}

void _GenerateProjectRestoreGraphCurrentProject()
{
    // if ( '$(TargetFrameworks)' == '' )
    if ( '' == '' ) { _GenerateProjectRestoreGraphCurrentProjectRun = true; return; }
    // DependsOnTargets;
    if (!_GenerateProjectRestoreGraphPerFrameworkRun) _GenerateProjectRestoreGraphPerFramework();
    
    _GenerateProjectRestoreGraphCurrentProjectRun = true;
}

void _GenerateProjectRestoreGraphPerFramework()
{
    // DependsOnTargets;
    if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
    if (!CollectPackageReferencesRun) CollectPackageReferences();
    if (!CollectPackageDownloadsRun) CollectPackageDownloads();
    if (!CollectFrameworkReferencesRun) CollectFrameworkReferences();
    if (!CollectCentralPackageVersionsRun) CollectCentralPackageVersions();
    // BeforeTargets;
    if (!PrepRestoreForStoreProjectsRun) PrepRestoreForStoreProjects();
    
    /*GetRestoreProjectReferencesTask(ProjectUniqueName: "$(MSBuildProjectFullPath)", TargetFrameworks: "$(TargetFramework)", ParentProjectPath: "$(MSBuildProjectFullPath)", ProjectReferences: "@(ProjectReference)");*/
    GetRestoreProjectReferencesTask(ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetFrameworks: "net8.0", ParentProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ProjectReferences: "");
    /*GetRestorePackageReferencesTask(ProjectUniqueName: "$(MSBuildProjectFullPath)", PackageReferences: "@(PackageReference)", TargetFrameworks: "$(TargetFramework)");*/
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
    if ( '' == 'true' )
    {
        GetRestorePackageReferencesTask(ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", PackageReferences: "", TargetFrameworks: "net8.0");
    }
    /*GetCentralPackageVersionsTask(ProjectUniqueName: "$(MSBuildProjectFullPath)", TargetFrameworks: "$(TargetFramework)", CentralPackageVersions: "@(PackageVersion)");*/
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(_CentralPackageVersionsEnabled)' == 'true' )*/
    if ( '' == 'true' AND '' == 'true' )
    {
        GetCentralPackageVersionsTask(ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetFrameworks: "net8.0", CentralPackageVersions: "");
    }
    /*GetRestorePackageDownloadsTask(ProjectUniqueName: "$(MSBuildProjectFullPath)", TargetFrameworks: "$(TargetFramework)", PackageDownloads: "@(PackageDownload)");*/
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
    if ( '' == 'true' )
    {
        GetRestorePackageDownloadsTask(ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetFrameworks: "net8.0", PackageDownloads: "");
    }
    /*GetRestoreFrameworkReferencesTask(FrameworkReferences: "@(FrameworkReference)", ProjectUniqueName: "$(MSBuildProjectFullPath)", TargetFrameworks: "$(TargetFramework)");*/
    /* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
    if ( '' == 'true' )
    {
        GetRestoreFrameworkReferencesTask(FrameworkReferences: "Microsoft.NETCore.App", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetFrameworks: "net8.0");
    }
    
    _GenerateProjectRestoreGraphPerFrameworkRun = true;
}

void _GenerateRestoreProjectPathItemsCurrentProject()
{
    // if ( '$(TargetFrameworks)' == '' )
    if ( '' == '' ) { _GenerateRestoreProjectPathItemsCurrentProjectRun = true; return; }
    // DependsOnTargets;
    if (!_GenerateRestoreProjectPathItemsPerFrameworkRun) _GenerateRestoreProjectPathItemsPerFramework();
    
    _GenerateRestoreProjectPathItemsCurrentProjectRun = true;
}

void _GenerateRestoreProjectPathItemsPerFramework()
{
    
    /*ConvertToAbsolutePath(Paths: "@(ProjectReference)");*/
    ConvertToAbsolutePath(Paths: "");
    
    _GenerateRestoreProjectPathItemsPerFrameworkRun = true;
}

void _GenerateRestoreProjectPathItems()
{
    // DependsOnTargets;
    if (!_GenerateRestoreProjectPathItemsAllFrameworksRun) _GenerateRestoreProjectPathItemsAllFrameworks();
    if (!_GenerateRestoreProjectPathItemsCurrentProjectRun) _GenerateRestoreProjectPathItemsCurrentProject();
    
    /*RemoveDuplicates(Inputs: "@(_RestoreProjectPathItems)");*/
    RemoveDuplicates(Inputs: "");
    
    _GenerateRestoreProjectPathItemsRun = true;
}

void _GenerateRestoreProjectPathItemsAllFrameworks()
{
    // if ( '$(TargetFrameworks)' != '' )
    if ( '' != '' ) { _GenerateRestoreProjectPathItemsAllFrameworksRun = true; return; }
    // DependsOnTargets;
    if (!_GetRestoreTargetFrameworksAsItemsRun) _GetRestoreTargetFrameworksAsItems();
    
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathItemsPerFramework", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""", SkipNonexistentProjects: "true");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
    if ( 'true' == 'true' )
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathItemsPerFramework", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""", SkipNonexistentProjects: "true");
    }
    /*MSBuild(Targets: "_GenerateRestoreProjectPathItemsPerFramework", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
    if ( 'true' != 'true' )
    {
        MSBuild(Targets: "_GenerateRestoreProjectPathItemsPerFramework", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""");
    }
    
    _GenerateRestoreProjectPathItemsAllFrameworksRun = true;
}

void _GenerateRestoreProjectPathWalk()
{
    // DependsOnTargets;
    if (!_GenerateRestoreProjectPathItemsRun) _GenerateRestoreProjectPathItems();
    
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathWalk", Projects: "@(_CurrentRestoreProjectPathItems)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)", SkipNonexistentProjects: "true");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
    if ( 'true' == 'true' )
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathWalk", Projects: "", Properties: "ExcludeRestorePackageImports=true", SkipNonexistentProjects: "true");
    }
    /*MSBuild(Targets: "_GenerateRestoreProjectPathWalk", Projects: "@(_CurrentRestoreProjectPathItems)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
    if ( 'true' != 'true' )
    {
        MSBuild(Targets: "_GenerateRestoreProjectPathWalk", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    }
    /*RemoveDuplicates(Inputs: "@(_GenerateRestoreProjectPathWalkOutputs)");*/
    RemoveDuplicates(Inputs: "");
    
    _GenerateRestoreProjectPathWalkRun = true;
}

void _GetAllRestoreProjectPathItems()
{
    // DependsOnTargets;
    if (!_FilterRestoreGraphProjectInputItemsRun) _FilterRestoreGraphProjectInputItems();
    
    NuGetMessageTask(Name: "DeterminingProjectsToRestore", Importance: "High");
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathWalk", Projects: "@(FilteredRestoreGraphProjectInputItems)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)", SkipNonexistentProjects: "true");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
    if ( 'true' == 'true' )
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "_GenerateRestoreProjectPathWalk", Projects: "", Properties: "ExcludeRestorePackageImports=true", SkipNonexistentProjects: "true");
    }
    /*MSBuild(Targets: "_GenerateRestoreProjectPathWalk", Projects: "@(FilteredRestoreGraphProjectInputItems)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
    if ( 'true' != 'true' )
    {
        MSBuild(Targets: "_GenerateRestoreProjectPathWalk", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    }
    /*RemoveDuplicates(Inputs: "@(_RestoreProjectPathItemsOutputs)");*/
    RemoveDuplicates(Inputs: "");
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentTargets: "true", Targets: "_IsProjectRestoreSupported", Projects: "@(_RestoreProjectPathItemsWithoutDupes)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)", SkipNonexistentProjects: "true");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
    if ( 'true' == 'true' )
    {
        MSBuild(BuildInParallel: "true", SkipNonexistentTargets: "true", Targets: "_IsProjectRestoreSupported", Projects: "", Properties: "ExcludeRestorePackageImports=true", SkipNonexistentProjects: "true");
    }
    /*MSBuild(Targets: "_IsProjectRestoreSupported", Projects: "@(_RestoreProjectPathItemsWithoutDupes)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
    /* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
    if ( 'true' != 'true' )
    {
        MSBuild(Targets: "_IsProjectRestoreSupported", Projects: "", Properties: "ExcludeRestorePackageImports=true");
    }
    
    _GetAllRestoreProjectPathItemsRun = true;
}

void _GetRestoreSettingsOverrides()
{
    
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GetRestorePackagesPathOverride", Projects: "$(MSBuildThisFileFullPath)");*/
    /* if ( '$(RestorePackagesPath)' != '' )*/
    if ( '' != '' )
    {
        MSBuild(BuildInParallel: "true", Targets: "_GetRestorePackagesPathOverride", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GetRestoreRepositoryPathOverride", Projects: "$(MSBuildThisFileFullPath)");*/
    /* if ( '$(RestoreRepositoryPathOverride)' != '' )*/
    if ( '' != '' )
    {
        MSBuild(BuildInParallel: "true", Targets: "_GetRestoreRepositoryPathOverride", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GetRestoreSourcesOverride", Projects: "$(MSBuildThisFileFullPath)");*/
    /* if ( '$(RestoreSources)' != '' )*/
    if ( '' != '' )
    {
        MSBuild(BuildInParallel: "true", Targets: "_GetRestoreSourcesOverride", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    /*MSBuild(BuildInParallel: "$(RestoreBuildInParallel)", Targets: "_GetRestoreFallbackFoldersOverride", Projects: "$(MSBuildThisFileFullPath)");*/
    /* if ( '$(RestoreFallbackFolders)' != '' )*/
    if ( '' != '' )
    {
        MSBuild(BuildInParallel: "true", Targets: "_GetRestoreFallbackFoldersOverride", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    
    _GetRestoreSettingsOverridesRun = true;
}

void _GetRestorePackagesPathOverride()
{
    
    _RestorePackagesPathOverride = "$(RestorePackagesPath)";
    _GetRestorePackagesPathOverrideRun = true;
}

void _GetRestoreRepositoryPathOverride()
{
    
    _RestorePackagesPathOverride = "$(RestoreRepositoryPath)";
    _GetRestoreRepositoryPathOverrideRun = true;
}

void _GetRestoreSourcesOverride()
{
    
    _RestoreSourcesOverride = "$(RestoreSources)";
    _GetRestoreSourcesOverrideRun = true;
}

void _GetRestoreFallbackFoldersOverride()
{
    
    _RestoreFallbackFoldersOverride = "$(RestoreFallbackFolders)";
    _GetRestoreFallbackFoldersOverrideRun = true;
}

void _GetRestoreTargetFrameworkOverride()
{
    // if ( '$(_DisableNuGetRestoreTargetFrameworksOverride)' != 'true' )
    if ( '' != 'true' ) { _GetRestoreTargetFrameworkOverrideRun = true; return; }
    
    /* if ( '$(TargetFrameworks)' != '' )*/
    if ( '' != '' )
    {
        GetGlobalPropertyValueTask(PropertyName: "TargetFramework");
    }
    
    _GetRestoreTargetFrameworkOverrideRun = true;
}

void _GetTargetFrameworkOverrides()
{
    
    /* if ( '$(TargetFrameworks)' == '' )*/
    if ( '' == '' )
    {
        _TargetFrameworkOverride = "$(TargetFramework)";
    }
    _GetTargetFrameworkOverridesRun = true;
}

void _IsProjectRestoreSupported()
{
    
    _IsProjectRestoreSupportedRun = true;
}

void VSTest()
{
    // DependsOnTargets;
    if (!ShowInfoMessageIfProjectHasNoIsTestProjectPropertyRun) ShowInfoMessageIfProjectHasNoIsTestProjectProperty();
    
    /* if (!$(VsTestUseMSBuildOutput))*/
    if (!False)
    {
        CallTarget(Targets: "_VSTestConsole");
    }
    /* if ($(VsTestUseMSBuildOutput))*/
    if (False)
    {
        CallTarget(Targets: "_VSTestMSBuild");
    }
    
    VSTestRun = true;
}

void _VSTestMSBuild()
{
    // if ('$(IsTestProject)' == 'true')
    if ('' == 'true') { _VSTestMSBuildRun = true; return; }
    
    /* if (!$(VSTestNoBuild))*/
    if (!False)
    {
        CallTarget(Targets: "BuildProject");
    }
    /*VSTestTask2(VSTestSessionCorrelationId: "$(VSTestSessionCorrelationId)", VSTestBlameCrashDumpType: "$(VSTestBlameCrashDumpType)", VSTestTestAdapterPath: "$(VSTestTestAdapterPath)", VSTestTraceDataCollectorDirectoryPath: "$(TraceDataCollectorDirectoryPath)", VSTestBlame: "$(VSTestBlame)", VSTestBlameCrashCollectAlways: "$(VSTestBlameCrashCollectAlways)", VSTestBlameHangDumpType: "$(VSTestBlameHangDumpType)", VSTestBlameHangTimeout: "$(VSTestBlameHangTimeout)", VSTestResultsDirectory: "$(VSTestResultsDirectory)", VSTestListTests: "$(VSTestListTests)", VSTestBlameHang: "$(VSTestBlameHang)", VSTestCLIRunSettings: "$(VSTestCLIRunSettings)", VSTestFramework: "$(TargetFrameworkMoniker)", VSTestSetting: "$([MSBuild]::ValueOrDefault($(VSTestSetting), '$(RunSettingsFilePath)'))", VSTestArtifactsProcessingMode: "$(VSTestArtifactsProcessingMode)", VSTestTestCaseFilter: "$(VSTestTestCaseFilter)", VSTestDiag: "$(VSTestDiag)", VSTestLogger: "$(VSTestLogger)", VSTestPlatform: "$(PlatformTarget)", VSTestNoLogo: "$(VSTestNoLogo)", VSTestBlameCrash: "$(VSTestBlameCrash)", VSTestCollect: "$(VSTestCollect)", VSTestVerbosity: "$(VSTestVerbosity)", TestFileFullPath: "$(TargetPath)", VSTestConsolePath: "$(VSTestConsolePath)");*/
    VSTestTask2(VSTestSessionCorrelationId: "", VSTestBlameCrashDumpType: "", VSTestTestAdapterPath: "", VSTestTraceDataCollectorDirectoryPath: "", VSTestBlame: "", VSTestBlameCrashCollectAlways: "", VSTestBlameHangDumpType: "", VSTestBlameHangTimeout: "", VSTestResultsDirectory: "", VSTestListTests: "", VSTestBlameHang: "", VSTestCLIRunSettings: "", VSTestFramework: ".NETCoreApp,Version=v8.0", VSTestSetting: "", VSTestArtifactsProcessingMode: "", VSTestTestCaseFilter: "", VSTestDiag: "", VSTestLogger: "", VSTestPlatform: "", VSTestNoLogo: "", VSTestBlameCrash: "", VSTestCollect: "", VSTestVerbosity: "", TestFileFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", VSTestConsolePath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll");
    
    _VSTestMSBuildRun = true;
}

void _VSTestConsole()
{
    
    /* if ('$(VSTestNoBuild)' != 'true' AND '$(IsTestProject)' == 'true')*/
    if ('False' != 'true' AND '' == 'true')
    {
        CallTarget(Targets: "BuildProject");
    }
    CallTarget(Targets: "ShowCallOfVSTestTaskWithParameter");
    /*VSTestTask(VSTestSessionCorrelationId: "$(VSTestSessionCorrelationId)", VSTestBlameCrashDumpType: "$(VSTestBlameCrashDumpType)", VSTestTestAdapterPath: "$(VSTestTestAdapterPath)", VSTestTraceDataCollectorDirectoryPath: "$(TraceDataCollectorDirectoryPath)", VSTestBlame: "$(VSTestBlame)", VSTestBlameCrashCollectAlways: "$(VSTestBlameCrashCollectAlways)", VSTestBlameHangDumpType: "$(VSTestBlameHangDumpType)", VSTestBlameHangTimeout: "$(VSTestBlameHangTimeout)", VSTestResultsDirectory: "$(VSTestResultsDirectory)", VSTestListTests: "$(VSTestListTests)", VSTestBlameHang: "$(VSTestBlameHang)", VSTestCLIRunSettings: "$(VSTestCLIRunSettings)", VSTestFramework: "$(TargetFrameworkMoniker)", VSTestSetting: "$([MSBuild]::ValueOrDefault($(VSTestSetting), '$(RunSettingsFilePath)'))", VSTestArtifactsProcessingMode: "$(VSTestArtifactsProcessingMode)", VSTestTestCaseFilter: "$(VSTestTestCaseFilter)", VSTestDiag: "$(VSTestDiag)", VSTestLogger: "$(VSTestLogger)", VSTestPlatform: "$(PlatformTarget)", VSTestNoLogo: "$(VSTestNoLogo)", VSTestBlameCrash: "$(VSTestBlameCrash)", VSTestCollect: "$(VSTestCollect)", VSTestVerbosity: "$(VSTestVerbosity)", TestFileFullPath: "$(TargetPath)", VSTestConsolePath: "$(VSTestConsolePath)");*/
    /* if ('$(IsTestProject)' == 'true')*/
    if ('' == 'true')
    {
        VSTestTask(VSTestSessionCorrelationId: "", VSTestBlameCrashDumpType: "", VSTestTestAdapterPath: "", VSTestTraceDataCollectorDirectoryPath: "", VSTestBlame: "", VSTestBlameCrashCollectAlways: "", VSTestBlameHangDumpType: "", VSTestBlameHangTimeout: "", VSTestResultsDirectory: "", VSTestListTests: "", VSTestBlameHang: "", VSTestCLIRunSettings: "", VSTestFramework: ".NETCoreApp,Version=v8.0", VSTestSetting: "", VSTestArtifactsProcessingMode: "", VSTestTestCaseFilter: "", VSTestDiag: "", VSTestLogger: "", VSTestPlatform: "", VSTestNoLogo: "", VSTestBlameCrash: "", VSTestCollect: "", VSTestVerbosity: "", TestFileFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", VSTestConsolePath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll");
    }
    
    _VSTestConsoleRun = true;
}

void ShowInfoMessageIfProjectHasNoIsTestProjectProperty()
{
    // if ('$(IsTestProject)' == '')
    if ('' == '') { ShowInfoMessageIfProjectHasNoIsTestProjectPropertyRun = true; return; }
    
    /*VSTestLogsTask(ProjectFilePath: "$(MSBuildProjectFullPath)", LogType: "NoIsTestProjectProperty");*/
    VSTestLogsTask(ProjectFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", LogType: "NoIsTestProjectProperty");
    
    ShowInfoMessageIfProjectHasNoIsTestProjectPropertyRun = true;
}

void BuildProject()
{
    
    CallTarget(Targets: "ShowMsbuildWithParameter");
    VSTestLogsTask(LogType: "BuildStarted");
    /*MSBuild(Projects: "$(MSBuildProjectFullPath)");*/
    MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    VSTestLogsTask(LogType: "BuildCompleted");
    /*Message(Text: "Done Building project $(MSBuildProjectFullPath) for TargetFramework=$(TargetFramework)", Importance: "Low");*/
    Message(Text: "Done Building project D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj for TargetFramework=net8.0", Importance: "Low");
    
    BuildProjectRun = true;
}

void ShowMsbuildWithParameter()
{
    
    /*Message(Text: "Building project $(MSBuildProjectFullPath) for TargetFramework=$(TargetFramework)", Importance: "Low");*/
    Message(Text: "Building project D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj for TargetFramework=net8.0", Importance: "Low");
    Message(Text: "Value passed to msbuild are...", Importance: "Low");
    /*Message(Text: "Configuration = $(Configuration)", Importance: "Low");*/
    Message(Text: "Configuration = Debug", Importance: "Low");
    /*Message(Text: "TargetFramework = $(TargetFramework)", Importance: "Low");*/
    Message(Text: "TargetFramework = net8.0", Importance: "Low");
    /*Message(Text: "Platform = $(PlatformTarget)", Importance: "Low");*/
    Message(Text: "Platform = ", Importance: "Low");
    /*Message(Text: "OutputPath = $(OutputPath)", Importance: "Low");*/
    Message(Text: "OutputPath = bin\\Debug\\net8.0\\", Importance: "Low");
    
    ShowMsbuildWithParameterRun = true;
}

void ShowCallOfVSTestTaskWithParameter()
{
    
    Message(Text: "Calling task Microsoft.TestPlatform.Build.Tasks.VSTestTask with following parameter...", Importance: "Low");
    /*Message(Text: "TestFileFullPath = $(TargetPath)", Importance: "Low");*/
    Message(Text: "TestFileFullPath = D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", Importance: "Low");
    /*Message(Text: "VSTestSetting = $(VSTestSetting)", Importance: "Low");*/
    Message(Text: "VSTestSetting = ", Importance: "Low");
    /*Message(Text: "VSTestTestAdapterPath = $(VSTestTestAdapterPath)", Importance: "Low");*/
    Message(Text: "VSTestTestAdapterPath = ", Importance: "Low");
    /*Message(Text: "VSTestFramework = $(TargetFrameworkMoniker)", Importance: "Low");*/
    Message(Text: "VSTestFramework = .NETCoreApp,Version=v8.0", Importance: "Low");
    /*Message(Text: "VSTestPlatform = $(PlatformTarget)", Importance: "Low");*/
    Message(Text: "VSTestPlatform = ", Importance: "Low");
    /*Message(Text: "VSTestTestCaseFilter = $(VSTestTestCaseFilter)", Importance: "Low");*/
    Message(Text: "VSTestTestCaseFilter = ", Importance: "Low");
    /*Message(Text: "VSTestLogger = $(VSTestLogger)", Importance: "Low");*/
    Message(Text: "VSTestLogger = ", Importance: "Low");
    /*Message(Text: "VSTestListTests = $(VSTestListTests)", Importance: "Low");*/
    Message(Text: "VSTestListTests = ", Importance: "Low");
    /*Message(Text: "VSTestDiag = $(VSTestDiag)", Importance: "Low");*/
    Message(Text: "VSTestDiag = ", Importance: "Low");
    /*Message(Text: "VSTestCLIRunSettings = $(VSTestCLIRunSettings)", Importance: "Low");*/
    Message(Text: "VSTestCLIRunSettings = ", Importance: "Low");
    /*Message(Text: "VSTestResultsDirectory = $(VSTestResultsDirectory)", Importance: "Low");*/
    Message(Text: "VSTestResultsDirectory = ", Importance: "Low");
    /*Message(Text: "VSTestConsolePath = $(VSTestConsolePath)", Importance: "Low");*/
    Message(Text: "VSTestConsolePath = C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll", Importance: "Low");
    /*Message(Text: "VSTestVerbosity = $(VSTestVerbosity)", Importance: "Low");*/
    Message(Text: "VSTestVerbosity = ", Importance: "Low");
    /*Message(Text: "VSTestCollect = $(VSTestCollect)", Importance: "Low");*/
    Message(Text: "VSTestCollect = ", Importance: "Low");
    /*Message(Text: "VSTestBlame = $(VSTestBlame)", Importance: "Low");*/
    Message(Text: "VSTestBlame = ", Importance: "Low");
    /*Message(Text: "VSTestTraceDataCollectorDirectoryPath = $(TraceDataCollectorDirectoryPath)", Importance: "Low");*/
    Message(Text: "VSTestTraceDataCollectorDirectoryPath = ", Importance: "Low");
    /*Message(Text: "VSTestNoLogo = $(VSTestNoLogo)", Importance: "Low");*/
    Message(Text: "VSTestNoLogo = ", Importance: "Low");
    
    ShowCallOfVSTestTaskWithParameterRun = true;
}

void _SetTargetFrameworkMonikerAttribute()
{
    
    /* if ('$(TargetFrameworkMoniker)' != '' and '$(TargetingClr2Framework)' != 'true')*/
    if ('.NETCoreApp,Version=v8.0' != '' and '' != 'true')
    {
        TargetFrameworkMonikerAssemblyAttributeText = """
// <autogenerated />
using System%3b
using System.Reflection%3b
[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute("$(TargetFrameworkMoniker)", FrameworkDisplayName = "$(TargetFrameworkMonikerDisplayName)")]
        """;
    }
    _SetTargetFrameworkMonikerAttributeRun = true;
}

void ResolvePackageDependenciesForBuild()
{
    // if ( ('$(DesignTimeBuild)' != 'true' and '$(_CleaningWithoutRebuilding)' != 'true')
                      Or Exists('$(ProjectAssetsFile)'))
    if ( ('' != 'true' and '' != 'true')
                      Or Exists('D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\project.assets.json')) { ResolvePackageDependenciesForBuildRun = true; return; }
    // DependsOnTargets;
    if (!ResolveLockFileReferencesRun) ResolveLockFileReferences();
    if (!ResolveLockFileAnalyzersRun) ResolveLockFileAnalyzers();
    if (!ResolveLockFileCopyLocalFilesRun) ResolveLockFileCopyLocalFiles();
    if (!ResolveRuntimePackAssetsRun) ResolveRuntimePackAssets();
    if (!RunProduceContentAssetsRun) RunProduceContentAssets();
    if (!IncludeTransitiveProjectReferencesRun) IncludeTransitiveProjectReferences();
    
    ResolvePackageDependenciesForBuildRun = true;
}

void RunResolvePackageDependencies()
{
    // if ( '$(DesignTimeBuild)' != 'true' Or Exists('$(ProjectAssetsFile)'))
    if ( '' != 'true' Or Exists('D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\project.assets.json')) { RunResolvePackageDependenciesRun = true; return; }
    // BeforeTargets;
    if (!_CheckForUnsupportedTargetFrameworkRun) _CheckForUnsupportedTargetFramework();
    if (!_CheckForUnsupportedTargetPlatformIdentifierRun) _CheckForUnsupportedTargetPlatformIdentifier();
    
    /*CheckForTargetInAssetsFile(RuntimeIdentifier: "$(RuntimeIdentifier)", TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)");*/
    /* if ( '$(DesignTimeBuild)' != 'true')*/
    if ( '' != 'true')
    {
        CheckForTargetInAssetsFile(RuntimeIdentifier: "", TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json");
    }
    /*ResolvePackageDependencies(ProjectAssetsFile: "$(ProjectAssetsFile)", TargetFramework: "$(TargetFramework)", ProjectLanguage: "$(Language)", ProjectPath: "$(MSBuildProjectFullPath)");*/
    /* if ('$(EmitLegacyAssetsFileItems)' == 'true')*/
    if ('false' == 'true')
    {
        ResolvePackageDependencies(ProjectAssetsFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", TargetFramework: "net8.0", ProjectLanguage: "C#", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    }
    
    RunResolvePackageDependenciesRun = true;
}

void _ResolveCompilerVersion()
{
    // if ('$(CompilerApiVersion)' == '' And
                     ('$(Language)' == 'C#' Or '$(Language)' == 'VB') And
                     Exists('$(RoslynTargetsPath)\Microsoft.Build.Tasks.CodeAnalysis.dll'))
    if ('roslyn4.9' == '' And
                     ('C#' == 'C#' Or 'C#' == 'VB') And
                     Exists('C:\Program Files\dotnet\sdk\8.0.200-preview.23624.5\Roslyn\Microsoft.Build.Tasks.CodeAnalysis.dll')) { _ResolveCompilerVersionRun = true; return; }
    
    _RoslynApiVersion = "$([System.Version]::Parse(%(_CodeAnalysisIdentity.Version)).Major).$([System.Version]::Parse(%(_CodeAnalysisIdentity.Version)).Minor)";
    CompilerApiVersion = "roslyn$(_RoslynApiVersion)";
    /*GetAssemblyIdentity(AssemblyFiles: "$(RoslynTargetsPath)\\Microsoft.Build.Tasks.CodeAnalysis.dll");*/
    GetAssemblyIdentity(AssemblyFiles: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Roslyn\\Microsoft.Build.Tasks.CodeAnalysis.dll");
    
    _ResolveCompilerVersionRun = true;
}

void ResolvePackageAssets()
{
    // if (('$(DesignTimeBuild)' != 'true' Or Exists('$(ProjectAssetsFile)')) And '$(SkipResolvePackageAssets)' != 'true')
    if (('' != 'true' Or Exists('D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\project.assets.json')) And '' != 'true') { ResolvePackageAssetsRun = true; return; }
    // DependsOnTargets;
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    if (!_ResolveCompilerVersionRun) _ResolveCompilerVersion();
    
    /* if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp'
                          and '$(_TargetFrameworkVersionWithoutV)' >= '3.0'
                          and '$(UseAppHostFromAssetsFile)' == '')*/
    if ('.NETCoreApp' == '.NETCoreApp'
                          and '8.0' >= '3.0'
                          and '' == '')
    {
        UseAppHostFromAssetsFile = "false";
    }
    /* if ('$(UseAppHostFromAssetsFile)' == '')*/
    if ('' == '')
    {
        UseAppHostFromAssetsFile = "true";
    }
    /* if ('$(EnsureRuntimePackageDependencies)' == ''
                          and '$(TargetFrameworkIdentifier)' == '.NETCoreApp'
                          and '$(_TargetFrameworkVersionWithoutV)' < '3.0'
                          and '$(EnsureNETCoreAppRuntime)' != 'false')*/
    if ('' == ''
                          and '.NETCoreApp' == '.NETCoreApp'
                          and '8.0' < '3.0'
                          and '' != 'false')
    {
        EnsureRuntimePackageDependencies = "true";
    }
    /* if ('$(CopyLocalRuntimeTargetAssets)' == '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp')*/
    if ('' == '' and '.NETCoreApp' == '.NETCoreApp')
    {
        CopyLocalRuntimeTargetAssets = "true";
    }
    /*ResolvePackageAssets(DesignTimeBuild: "$(DesignTimeBuild)", EnsureRuntimePackageDependencies: "$(EnsureRuntimePackageDependencies)", ProjectAssetsCacheFile: "$(ProjectAssetsCacheFile)", DisablePackageAssetsCache: "$(DisablePackageAssetsCache)", RuntimeFrameworks: "@(RuntimeFramework)", ProjectAssetsFile: "$(ProjectAssetsFile)", RuntimeIdentifier: "$(RuntimeIdentifier)", CopyLocalRuntimeTargetAssets: "$(CopyLocalRuntimeTargetAssets)", ExpectedPlatformPackages: "@(ExpectedPlatformPackages)", TargetFramework: "$(TargetFramework)", PackageReferences: "@(PackageReference)", ProjectLanguage: "$(Language)", EmitAssetsLogMessages: "$(EmitAssetsLogMessages)", IsSelfContained: "$(SelfContained)", VerifyMatchingImplicitPackageVersion: "$(VerifyMatchingImplicitPackageVersion)", DefaultImplicitPackages: "$(DefaultImplicitPackages)", DisableTransitiveProjectReferences: "$(DisableTransitiveProjectReferences)", MarkPackageReferencesAsExternallyResolved: "$(MarkPackageReferencesAsExternallyResolved)", ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", DisableTransitiveFrameworkReferences: "$(DisableTransitiveFrameworkReferences)", DotNetAppHostExecutableNameWithoutExtension: "$(_DotNetAppHostExecutableNameWithoutExtension)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", DisableFrameworkAssemblies: "$(DisableLockFileFrameworks)", ProjectPath: "$(MSBuildProjectFullPath)", CompilerApiVersion: "$(CompilerApiVersion)", SatelliteResourceLanguages: "$(SatelliteResourceLanguages)");*/
    ResolvePackageAssets(DesignTimeBuild: "", EnsureRuntimePackageDependencies: "", ProjectAssetsCacheFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.assets.cache", DisablePackageAssetsCache: "", RuntimeFrameworks: "", ProjectAssetsFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", RuntimeIdentifier: "", CopyLocalRuntimeTargetAssets: "", ExpectedPlatformPackages: "", TargetFramework: "net8.0", PackageReferences: "", ProjectLanguage: "C#", EmitAssetsLogMessages: "true", IsSelfContained: "false", VerifyMatchingImplicitPackageVersion: "true", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library", DisableTransitiveProjectReferences: "", MarkPackageReferencesAsExternallyResolved: "true", ShimRuntimeIdentifiers: "", DisableTransitiveFrameworkReferences: "", DotNetAppHostExecutableNameWithoutExtension: "apphost", PlatformLibraryName: "", DisableFrameworkAssemblies: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", CompilerApiVersion: "roslyn4.9", SatelliteResourceLanguages: "");
    
    // AfterTargets;
    if (!AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItemsRun) AdjustDefaultPlatformTargetForNetFrameworkExeWithNoNativeCopyLocalItems();
    if (!_CheckForTransitiveWindowsDesktopDependenciesRun) _CheckForTransitiveWindowsDesktopDependencies();
    if (!AddTransitiveFrameworkReferencesRun) AddTransitiveFrameworkReferences();
    ResolvePackageAssetsRun = true;
}

void ResolvePackageDependenciesDesignTime()
{
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!RunResolvePackageDependenciesRun) RunResolvePackageDependencies();
    if (!ResolveAssemblyReferencesDesignTimeRun) ResolveAssemblyReferencesDesignTime();
    
    ResolvePackageDependenciesDesignTimeRun = true;
}

void CollectSDKReferencesDesignTime()
{
    // DependsOnTargets;
    if (!CollectPackageReferencesRun) CollectPackageReferences();
    
    /*CollectSDKReferencesDesignTime(SdkReferences: "@(SdkReference)", PackageReferences: "@(PackageReference)", DefaultImplicitPackages: "$(DefaultImplicitPackages)");*/
    CollectSDKReferencesDesignTime(SdkReferences: "", PackageReferences: "", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library");
    
    CollectSDKReferencesDesignTimeRun = true;
}

void CollectResolvedSDKReferencesDesignTime()
{
    // DependsOnTargets;
    if (!ResolveSDKReferencesDesignTimeRun) ResolveSDKReferencesDesignTime();
    if (!CollectPackageReferencesRun) CollectPackageReferences();
    
    /*CollectSDKReferencesDesignTime(SdkReferences: "@(ResolvedSdkReference)", PackageReferences: "@(PackageReference)", DefaultImplicitPackages: "$(DefaultImplicitPackages)");*/
    CollectSDKReferencesDesignTime(SdkReferences: "", PackageReferences: "", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library");
    
    CollectResolvedSDKReferencesDesignTimeRun = true;
}

void RunProduceContentAssets()
{
    // if ('@(_ContentFilesToPreprocess)' != '' and '$(_CleaningWithoutRebuilding)' != 'true')
    if ('' != '' and '' != 'true') { RunProduceContentAssetsRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    
    /*ProduceContentAssets(ContentPreprocessorValues: "@(PreprocessorValue)", ProduceOnlyPreprocessorFiles: "true", ProjectLanguage: "$(Language)", ContentPreprocessorOutputDirectory: "$(ContentPreprocessorOutputDirectory)", ContentFileDependencies: "@(_ContentFilesToPreprocess)");*/
    ProduceContentAssets(ContentPreprocessorValues: "rootnamespace;assemblyname;fullpath;outputfilename;filename", ProduceOnlyPreprocessorFiles: "true", ProjectLanguage: "C#", ContentPreprocessorOutputDirectory: "obj\\Debug\\net8.0\\NuGet\\", ContentFileDependencies: "");
    /*CreateItem(Include: "@(_ProcessedContentItems)");*/
    /* if ('@(_ProcessedContentItems)' != '')*/
    if ('' != '')
    {
        CreateItem(Include: "");
    }
    
    RunProduceContentAssetsRun = true;
}

void ResolveLockFileReferences()
{
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    
    /*JoinItems(Right: "@(Reference)", LeftKey: "FileName", RightMetadata: "*", RightKey: "", Left: "@(ResolvedCompileFileDefinitions)", LeftMetadata: "*");*/
    JoinItems(Right: "", LeftKey: "FileName", RightMetadata: "*", RightKey: "", Left: "", LeftMetadata: "*");
    
    ResolveLockFileReferencesRun = true;
}

void IncludeTransitiveProjectReferences()
{
    // if ('$(DisableTransitiveProjectReferences)' != 'true')
    if ('' != 'true') { IncludeTransitiveProjectReferencesRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    
    IncludeTransitiveProjectReferencesRun = true;
}

void ResolveLockFileAnalyzers()
{
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    
    ResolveLockFileAnalyzersRun = true;
}

void ResolveLockFileCopyLocalFiles()
{
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!RunProduceContentAssetsRun) RunProduceContentAssets();
    
    ResolveLockFileCopyLocalFilesRun = true;
}

void EnsureNETCoreAppRuntime()
{
    
    EnsureNETCoreAppRuntimeRun = true;
}

void UpdateAspNetToFrameworkReference()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(_TargetFrameworkVersionWithoutV)' >= '3.0')
    if ('.NETCoreApp' == '.NETCoreApp' And '8.0' >= '3.0') { UpdateAspNetToFrameworkReferenceRun = true; return; }
    
    /*CheckIfPackageReferenceShouldBeFrameworkReference(FrameworkReferenceToUse: "Microsoft.AspNetCore.App", FrameworkReferences: "@(FrameworkReference)", PackageReferenceToReplace: "Microsoft.AspNetCore.All", PackageReferences: "@(PackageReference)");*/
    CheckIfPackageReferenceShouldBeFrameworkReference(FrameworkReferenceToUse: "Microsoft.AspNetCore.App", FrameworkReferences: "Microsoft.NETCore.App", PackageReferenceToReplace: "Microsoft.AspNetCore.All", PackageReferences: "");
    /* if ('$(_ShouldRemoveAspNetCoreAll)' == 'true')*/
    if ('' == 'true')
    {
        NETSdkError(ResourceName: "AspNetCoreAllNotSupported");
    }
    /*CheckIfPackageReferenceShouldBeFrameworkReference(FrameworkReferenceToUse: "Microsoft.AspNetCore.App", FrameworkReferences: "@(FrameworkReference)", PackageReferenceToReplace: "Microsoft.AspNetCore.App", PackageReferences: "@(PackageReference)");*/
    CheckIfPackageReferenceShouldBeFrameworkReference(FrameworkReferenceToUse: "Microsoft.AspNetCore.App", FrameworkReferences: "Microsoft.NETCore.App", PackageReferenceToReplace: "Microsoft.AspNetCore.App", PackageReferences: "");
    /* if ('$(_ShouldRemoveAspNetCoreApp)' == 'true')*/
    if ('' == 'true')
    {
        NETSdkWarning(ResourceName: "AspNetCoreUsesFrameworkReference");
    }
    
    UpdateAspNetToFrameworkReferenceRun = true;
}

void ApplyImplicitVersions()
{
    // if ('@(PackageReference)' != '')
    if ('' != '') { ApplyImplicitVersionsRun = true; return; }
    // DependsOnTargets;
    if (!UpdateAspNetToFrameworkReferenceRun) UpdateAspNetToFrameworkReference();
    if (!CheckForImplicitPackageReferenceOverridesRun) CheckForImplicitPackageReferenceOverrides();
    
    /*ApplyImplicitVersions(ImplicitPackageReferenceVersions: "@(ImplicitPackageReferenceVersion)", TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", PackageReferences: "@(PackageReference)", TargetLatestRuntimePatch: "$(TargetLatestRuntimePatch)");*/
    ApplyImplicitVersions(ImplicitPackageReferenceVersions: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.AspNetCore.App;Microsoft.AspNetCore.All;Microsoft.AspNetCore.App;Microsoft.AspNetCore.All", TargetFrameworkVersion: "8.0", PackageReferences: "", TargetLatestRuntimePatch: "false");
    
    ApplyImplicitVersionsRun = true;
}

void CheckForImplicitPackageReferenceOverrides()
{
    // BeforeTargets;
    if (!IncludeTargetingPackReferenceRun) IncludeTargetingPackReference();
    
    ImplicitPackageReferenceInformationLink = "https://aka.ms/sdkimplicitrefs";
    /* if ('@(_PackageReferenceToRemove)' != '')*/
    if ('' != '')
    {
        VerifyMatchingImplicitPackageVersion = "false";
    }
    /*CheckForImplicitPackageReferenceOverrides(MoreInformationLink: "$(ImplicitPackageReferenceInformationLink)", PackageReferenceItems: "@(PackageReference)");*/
    CheckForImplicitPackageReferenceOverrides(MoreInformationLink: "", PackageReferenceItems: "");
    
    CheckForImplicitPackageReferenceOverridesRun = true;
}

void CheckForDuplicateItems()
{
    
    DefaultItemsMoreInformationLink = "https://aka.ms/sdkimplicititems";
    /*CheckForDuplicateItems(Items: "@(Compile)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", PropertyNameToDisableDefaultItems: "EnableDefaultCompileItems", ItemName: "Compile", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultCompileItems)", DefaultItemsEnabled: "$(EnableDefaultItems)");*/
    CheckForDuplicateItems(Items: "Program.cs", MoreInformationLink: "", PropertyNameToDisableDefaultItems: "EnableDefaultCompileItems", ItemName: "Compile", DefaultItemsOfThisTypeEnabled: "true", DefaultItemsEnabled: "true");
    /*CheckForDuplicateItems(Items: "@(EmbeddedResource)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", PropertyNameToDisableDefaultItems: "EnableDefaultEmbeddedResourceItems", ItemName: "EmbeddedResource", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultEmbeddedResourceItems)", DefaultItemsEnabled: "$(EnableDefaultItems)");*/
    CheckForDuplicateItems(Items: "", MoreInformationLink: "", PropertyNameToDisableDefaultItems: "EnableDefaultEmbeddedResourceItems", ItemName: "EmbeddedResource", DefaultItemsOfThisTypeEnabled: "true", DefaultItemsEnabled: "true");
    /*CheckForDuplicateItems(Items: "@(Content)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", PropertyNameToDisableDefaultItems: "EnableDefaultContentItems", ItemName: "Content", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultContentItems)", DefaultItemsEnabled: "$(EnableDefaultItems)");*/
    CheckForDuplicateItems(Items: "", MoreInformationLink: "", PropertyNameToDisableDefaultItems: "EnableDefaultContentItems", ItemName: "Content", DefaultItemsOfThisTypeEnabled: "", DefaultItemsEnabled: "true");
    
    CheckForDuplicateItemsRun = true;
}

void _CheckForTransitiveWindowsDesktopDependencies()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(_TargetFrameworkVersionWithoutV), '5.0')) and '$(TargetPlatformIdentifier)' != 'Windows' and '@(TransitiveFrameworkReference)' != '')
    if ('.NETCoreApp' == '.NETCoreApp' and True and '' != 'Windows' and '' != '') { _CheckForTransitiveWindowsDesktopDependenciesRun = true; return; }
    
    /* if ('@(_WindowsDesktopTransitiveFrameworkReference)' != '')*/
    if ('' != '')
    {
        NetSdkError(ResourceName: "WindowsDesktopTargetPlatformMustBeWindows");
    }
    
    _CheckForTransitiveWindowsDesktopDependenciesRun = true;
}

void WarnForExplicitVersions()
{
    // if ('@(SdkBuildWarning)' != '')
    if ('' != '') { WarnForExplicitVersionsRun = true; return; }
    // DependsOnTargets;
    if (!ApplyImplicitVersionsRun) ApplyImplicitVersions();
    
    NetSdkWarning(FormattedText: "%(SdkBuildWarning.Identity)");
    
    WarnForExplicitVersionsRun = true;
}

void _CheckForFailedSDKResolution()
{
    // if ('$(SdkResolverHonoredGlobalJson)' == 'false')
    if ('' == 'false') { _CheckForFailedSDKResolutionRun = true; return; }
    
    /*NetSdkError(ResourceName: "GlobalJsonSDKResolutionFailed", FormatArguments: "$(SdkResolverGlobalJsonPath)");*/
    NetSdkError(ResourceName: "GlobalJsonSDKResolutionFailed", FormatArguments: "");
    
    _CheckForFailedSDKResolutionRun = true;
}

void _WarnWhenUsingNET8AndVSPriorTo178()
{
    // if ($([MSBuild]::VersionLessThan($(MSBuildVersion), '17.8.0')) and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(_TargetFrameworkVersionWithoutV), '8.0')))
    if (False and '.NETCoreApp' == '.NETCoreApp' and True) { _WarnWhenUsingNET8AndVSPriorTo178Run = true; return; }
    
    NetSdkWarning(ResourceName: "Net8NotCompatibleWithDev177");
    
    _WarnWhenUsingNET8AndVSPriorTo178Run = true;
}

void _CheckForInvalidWindowsDesktopTargetingConfiguration()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(_TargetFrameworkVersionWithoutV), '5.0')) and ('$(UseWindowsForms)' == 'true' or '$(UseWPF)' == 'true'))
    if ('.NETCoreApp' == '.NETCoreApp' and True and ('' == 'true' or '' == 'true')) { _CheckForInvalidWindowsDesktopTargetingConfigurationRun = true; return; }
    
    /* if ('$(TargetPlatformIdentifier)' != 'Windows')*/
    if ('' != 'Windows')
    {
        NETSdkError(ResourceName: "WindowsDesktopTargetPlatformMustBeWindows");
    }
    
    _CheckForInvalidWindowsDesktopTargetingConfigurationRun = true;
}

void _CheckForUnnecessaryWindowsDesktopSDK()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(_TargetFrameworkVersionWithoutV), '5.0')) and '$(_MicrosoftWindowsDesktopSdkImported)' == 'true' and '$(TargetFrameworks)' == '')
    if ('.NETCoreApp' == '.NETCoreApp' and True and '' == 'true' and '' == '') { _CheckForUnnecessaryWindowsDesktopSDKRun = true; return; }
    
    NETSdkWarning(ResourceName: "UnnecessaryWindowsDesktopSDK");
    
    _CheckForUnnecessaryWindowsDesktopSDKRun = true;
}

void _VerifyPackReleaseConfigurations()
{
    // if ('$(_IsPacking)' == 'true' and '$(DOTNET_CLI_DISABLE_PUBLISH_AND_PACK_RELEASE)' != 'true' and '$(DOTNET_CLI_LAZY_PUBLISH_AND_PACK_RELEASE_FOR_SOLUTIONS)' == 'true')
    if ('' == 'true' and '' != 'true' and '' == 'true') { _VerifyPackReleaseConfigurationsRun = true; return; }
    
    /*NETSdkError(ResourceName: "SolutionProjectConfigurationsConflict", FormatArguments: "PackRelease;$(ProjectName)");*/
    /* if ('$(SolutionExt)' == '.sln' and
                            '$(_SolutionLevelPackRelease)' != '$(PackRelease)')*/
    if ('*Undefined*' == '.sln' and
                            '' != 'true')
    {
        NETSdkError(ResourceName: "SolutionProjectConfigurationsConflict", FormatArguments: "PackRelease;6 - targets");
    }
    
    _VerifyPackReleaseConfigurationsRun = true;
}

void AddWindowsSdkKnownFrameworkReferences()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(TargetPlatformIdentifier)' == 'Windows')
    if ('.NETCoreApp' == '.NETCoreApp' And '' == 'Windows') { AddWindowsSdkKnownFrameworkReferencesRun = true; return; }
    
    /*CreateWindowsSdkKnownFrameworkReferences(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", UseWindowsSDKPreview: "$(UseWindowsSDKPreview)", WindowsSdkSupportedTargetPlatformVersions: "@(WindowsSdkSupportedTargetPlatformVersion)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", WindowsSdkPackageVersion: "$(WindowsSdkPackageVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)");*/
    CreateWindowsSdkKnownFrameworkReferences(TargetFrameworkVersion: "8.0", UseWindowsSDKPreview: "", WindowsSdkSupportedTargetPlatformVersions: "10.0.22621.0;10.0.22000.0;10.0.20348.0;10.0.19041.0;10.0.18362.0;10.0.17763.0;10.0.22000.0;10.0.20348.0;10.0.19041.0;10.0.18362.0;10.0.17763.0;8.0;7.0", TargetPlatformIdentifier: "", TargetPlatformVersion: "", WindowsSdkPackageVersion: "", TargetFrameworkIdentifier: ".NETCoreApp");
    
    AddWindowsSdkKnownFrameworkReferencesRun = true;
}

void ProcessFrameworkReferences()
{
    // if ('@(FrameworkReference)' != '' Or '$(_RequiresILLinkPack)' == 'true')
    if ('Microsoft.NETCore.App' != '' Or '' == 'true') { ProcessFrameworkReferencesRun = true; return; }
    // DependsOnTargets;
    if (!AddWindowsSdkKnownFrameworkReferencesRun) AddWindowsSdkKnownFrameworkReferences();
    // BeforeTargets;
    if (!_NormalizeTargetPlatformVersionRun) _NormalizeTargetPlatformVersion();
    if (!_CheckForLanguageAndFeatureCombinationSupportRun) _CheckForLanguageAndFeatureCombinationSupport();
    if (!ApplyImplicitVersionsRun) ApplyImplicitVersions();
    if (!_ComputeToolPackInputsToProcessFrameworkReferencesRun) _ComputeToolPackInputsToProcessFrameworkReferences();
    
    /* if ('$(EnableTargetingPackDownload)' == '')*/
    if ('' == '')
    {
        EnableTargetingPackDownload = "true";
    }
    /* if ('$(EnableRuntimePackDownload)' == '')*/
    if ('' == '')
    {
        EnableRuntimePackDownload = "true";
    }
    /* if (('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true'))*/
    if (('C#' == 'C++' and '' != 'true'))
    {
        _NuGetRestoreSupported = "false";
    }
    /* if ('$(AppHostRuntimeIdentifier)' == '' And
                              ('$(UseAppHost)' == 'true' Or '$(EnableComHosting)' == 'true' Or '$(UseIJWHost)' == 'true'))*/
    if ('' == '' And
                              ('true' == 'true' Or '' == 'true' Or '' == 'true'))
    {
        AppHostRuntimeIdentifier = "$(RuntimeIdentifier)";
        /* if ('$(AppHostRuntimeIdentifier)' == '')*/
        if ('' == '')
        {
            AppHostRuntimeIdentifier = "$(DefaultAppHostRuntimeIdentifier)";
        }
    }
    /* if ('$(UsePackageDownload)' == '')*/
    if ('' == '')
    {
        /* if ('$(MSBuildRuntimeType)' == 'Core')*/
        if ('Core' == 'Core')
        {
            UsePackageDownload = "true";
        }
        /* if ('$(PackageDownloadSupported)' == 'true')*/
        if ('true' == 'true')
        {
            UsePackageDownload = "true";
        }
        /* if ('$(UsePackageDownload)' == '')*/
        if ('' == '')
        {
            UsePackageDownload = "false";
        }
    }
    /*CheckForDuplicateFrameworkReferences(MoreInformationLink: "https://aka.ms/sdkimplicitrefs", FrameworkReferences: "@(FrameworkReference)");*/
    CheckForDuplicateFrameworkReferences(MoreInformationLink: "https://aka.ms/sdkimplicitrefs", FrameworkReferences: "Microsoft.NETCore.App");
    /*ProcessFrameworkReferences(MinNonEolTargetFrameworkForSingleFile: "$(_MinNonEolTargetFrameworkForSingleFile)", IsAotCompatible: "$(IsAotCompatible)", KnownRuntimePacks: "@(KnownRuntimePack)", TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", NETCoreSdkRuntimeIdentifier: "$(NETCoreSdkRuntimeIdentifier)", KnownILLinkPacks: "@(KnownILLinkPack)", NetCoreRoot: "$(NetCoreRoot)", RuntimeIdentifiers: "$(RuntimeIdentifiers)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", SilenceIsTrimmableUnsupportedWarning: "$(_SilenceIsTrimmableUnsupportedWarning)", KnownCrossgen2Packs: "@(KnownCrossgen2Pack)", RuntimeFrameworkVersion: "$(RuntimeFrameworkVersion)", FrameworkReferences: "@(FrameworkReference)", RuntimeIdentifier: "$(RuntimeIdentifier)", TargetingPackRoot: "$(NetCoreTargetingPackRoot)", KnownWebAssemblySdkPacks: "@(KnownWebAssemblySdkPack)", IsTrimmable: "$(IsTrimmable)", KnownILCompilerPacks: "@(KnownILCompilerPack)", KnownFrameworkReferences: "@(KnownFrameworkReference)", EnableTargetingPackDownload: "$(EnableTargetingPackDownload)", PublishAot: "$(PublishAot)", MinNonEolTargetFrameworkForAot: "$(_MinNonEolTargetFrameworkForAot)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", EnableAotAnalyzer: "$(EnableAotAnalyzer)", SilenceEnableSingleFileAnalyzerUnsupportedWarning: "$(_SilenceEnableSingleFileAnalyzerUnsupportedWarning)", EnableRuntimePackDownload: "$(EnableRuntimePackDownload)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", AotUseKnownRuntimePackForTarget: "$(PublishAotUsingRuntimePack)", EnableTrimAnalyzer: "$(EnableTrimAnalyzer)", RequiresILLinkPack: "$(_RequiresILLinkPack)", SelfContained: "$(SelfContained)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SilenceIsAotCompatibleUnsupportedWarning: "$(_SilenceIsAotCompatibleUnsupportedWarning)", TargetLatestRuntimePatch: "$(TargetLatestRuntimePatch)", UsingMicrosoftNETSdkWebAssembly: "$(UsingMicrosoftNETSdkWebAssembly)", TargetLatestRuntimePatchIsDefault: "$(_TargetLatestRuntimePatchIsDefault)", EnableWindowsTargeting: "$(EnableWindowsTargeting)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", PublishTrimmed: "$(PublishTrimmed)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", EnableSingleFileAnalyzer: "$(EnableSingleFileAnalyzer)", MinNonEolTargetFrameworkForTrimming: "$(_MinNonEolTargetFrameworkForTrimming)", ReadyToRunEnabled: "$(PublishReadyToRun)");*/
    ProcessFrameworkReferences(MinNonEolTargetFrameworkForSingleFile: "", IsAotCompatible: "", KnownRuntimePacks: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App", TargetFrameworkVersion: "8.0", NETCoreSdkRuntimeIdentifier: "win-x64", KnownILLinkPacks: "Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks", NetCoreRoot: "C:\\Program Files\\dotnet\\", RuntimeIdentifiers: "", NETCoreSdkVersion: "8.0.200-preview.23624.5", SilenceIsTrimmableUnsupportedWarning: "", KnownCrossgen2Packs: "Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2", RuntimeFrameworkVersion: "", FrameworkReferences: "Microsoft.NETCore.App", RuntimeIdentifier: "", TargetingPackRoot: "C:\\Program Files\\dotnet\\packs", KnownWebAssemblySdkPacks: "Microsoft.NET.Sdk.WebAssembly.Pack;Microsoft.NET.Sdk.WebAssembly.Pack;Microsoft.NET.Sdk.WebAssembly.Pack", IsTrimmable: "", KnownILCompilerPacks: "Microsoft.DotNet.ILCompiler;Microsoft.DotNet.ILCompiler", KnownFrameworkReferences: "Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;NETStandard.Library", EnableTargetingPackDownload: "", PublishAot: "", MinNonEolTargetFrameworkForAot: "", ReadyToRunUseCrossgen2: "true", EnableAotAnalyzer: "", SilenceEnableSingleFileAnalyzerUnsupportedWarning: "", EnableRuntimePackDownload: "", TargetPlatformIdentifier: "", TargetPlatformVersion: "", AotUseKnownRuntimePackForTarget: "", EnableTrimAnalyzer: "", RequiresILLinkPack: "", SelfContained: "false", TargetFrameworkIdentifier: ".NETCoreApp", SilenceIsAotCompatibleUnsupportedWarning: "", TargetLatestRuntimePatch: "false", UsingMicrosoftNETSdkWebAssembly: "", TargetLatestRuntimePatchIsDefault: "true", EnableWindowsTargeting: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", PublishTrimmed: "", DisableTransitiveFrameworkReferenceDownloads: "", EnableSingleFileAnalyzer: "", MinNonEolTargetFrameworkForTrimming: "", ReadyToRunEnabled: "");
    /*ResolveAppHosts(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", EnableAppHostPackDownload: "$(EnableAppHostPackDownload)", NuGetRestoreSupported: "$(_NuGetRestoreSupported)", RuntimeFrameworkVersion: "$(RuntimeFrameworkVersion)", NetCoreTargetingPackRoot: "$(NetCoreTargetingPackRoot)", DotNetIjwHostLibraryNameWithoutExtension: "$(_DotNetIjwHostLibraryNameWithoutExtension)", TargetingPackRoot: "$(NetCoreTargetingPackRoot)", AppHostRuntimeIdentifier: "$(AppHostRuntimeIdentifier)", KnownAppHostPacks: "@(KnownAppHostPack)", PackAsToolShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", OtherRuntimeIdentifiers: "$(RuntimeIdentifiers)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", DotNetSingleFileHostExecutableNameWithoutExtension: "$(_DotNetSingleFileHostExecutableNameWithoutExtension)", DotNetAppHostExecutableNameWithoutExtension: "$(_DotNetAppHostExecutableNameWithoutExtension)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", DotNetComHostLibraryNameWithoutExtension: "$(_DotNetComHostLibraryNameWithoutExtension)");*/
    ResolveAppHosts(TargetFrameworkVersion: "8.0", EnableAppHostPackDownload: "", NuGetRestoreSupported: "", RuntimeFrameworkVersion: "", NetCoreTargetingPackRoot: "C:\\Program Files\\dotnet\\packs", DotNetIjwHostLibraryNameWithoutExtension: "Ijwhost", TargetingPackRoot: "C:\\Program Files\\dotnet\\packs", AppHostRuntimeIdentifier: "", KnownAppHostPacks: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App", PackAsToolShimRuntimeIdentifiers: "", OtherRuntimeIdentifiers: "", TargetFrameworkIdentifier: ".NETCoreApp", DotNetSingleFileHostExecutableNameWithoutExtension: "singlefilehost", DotNetAppHostExecutableNameWithoutExtension: "apphost", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", DotNetComHostLibraryNameWithoutExtension: "comhost");
    
    ProcessFrameworkReferencesRun = true;
}

void AddTransitiveFrameworkReferences()
{
    // if ('@(TransitiveFrameworkReference)' != '')
    if ('' != '') { AddTransitiveFrameworkReferencesRun = true; return; }
    
    AddTransitiveFrameworkReferencesRun = true;
}

void ResolveTargetingPackAssets()
{
    // if ('@(FrameworkReference)' != '')
    if ('Microsoft.NETCore.App' != '') { ResolveTargetingPackAssetsRun = true; return; }
    // DependsOnTargets;
    if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();
    
    /* if ('$(GenerateErrorForMissingTargetingPacks)' == '')*/
    if ('' == '')
    {
        GenerateErrorForMissingTargetingPacks = "true";
        /* if ('$(DesignTimeBuild)' == 'true')*/
        if ('' == 'true')
        {
            GenerateErrorForMissingTargetingPacks = "false";
        }
    }
    PackageConflictPreferredPackages = "$([MSBuild]::Unescape($(PackageConflictPreferredPackages)))";
    /*ResolveTargetingPackAssets(NuGetRestoreSupported: "$(_NuGetRestoreSupported)", RuntimeFrameworks: "@(RuntimeFramework)", FrameworkReferences: "@(FrameworkReference)", NetCoreTargetingPackRoot: "$(NetCoreTargetingPackRoot)", GenerateErrorForMissingTargetingPacks: "$(GenerateErrorForMissingTargetingPacks)", ProjectLanguage: "$(Language)", ResolvedTargetingPacks: "@(ResolvedTargetingPack)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)");*/
    ResolveTargetingPackAssets(NuGetRestoreSupported: "", RuntimeFrameworks: "", FrameworkReferences: "Microsoft.NETCore.App", NetCoreTargetingPackRoot: "C:\\Program Files\\dotnet\\packs", GenerateErrorForMissingTargetingPacks: "", ProjectLanguage: "C#", ResolvedTargetingPacks: "", DisableTransitiveFrameworkReferenceDownloads: "");
    
    // AfterTargets;
    if (!ResolveOffByDefaultAnalyzersRun) ResolveOffByDefaultAnalyzers();
    ResolveTargetingPackAssetsRun = true;
}

void ResolveOffByDefaultAnalyzers()
{
    // if ('@(FrameworkReference)' != '')
    if ('Microsoft.NETCore.App' != '') { ResolveOffByDefaultAnalyzersRun = true; return; }
    
    ResolveOffByDefaultAnalyzersRun = true;
}

void IncludeTargetingPackReference()
{
    // if ('$(TargetFrameworkMoniker)' != '' and '$(TargetFrameworkIdentifier)' == '.NETFramework' and '$(AutomaticallyUseReferenceAssemblyPackages)' == 'true')
    if ('.NETCoreApp,Version=v8.0' != '' and '.NETCoreApp' == '.NETFramework' and 'true' == 'true') { IncludeTargetingPackReferenceRun = true; return; }
    
    /*GetReferenceAssemblyPaths(RootPath: "$(TargetFrameworkRootPath)", TargetFrameworkFallbackSearchPaths: "$(TargetFrameworkFallbackSearchPaths)", BypassFrameworkInstallChecks: "true", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", SuppressNotFoundError: "true");*/
    GetReferenceAssemblyPaths(RootPath: "", TargetFrameworkFallbackSearchPaths: "", BypassFrameworkInstallChecks: "true", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", SuppressNotFoundError: "true");
    
    IncludeTargetingPackReferenceRun = true;
}

void ResolveRuntimePackAssets()
{
    // if ('@(RuntimePack)' != '')
    if ('' != '') { ResolveRuntimePackAssetsRun = true; return; }
    // DependsOnTargets;
    if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();
    
    /*ResolveRuntimePackAssets(DesignTimeBuild: "$(DesignTimeBuild)", ResolvedRuntimePacks: "@(ResolvedRuntimePack)", FrameworkReferences: "@(FrameworkReference)", UnavailableRuntimePacks: "@(UnavailableRuntimePack)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", SatelliteResourceLanguages: "$(SatelliteResourceLanguages)");*/
    ResolveRuntimePackAssets(DesignTimeBuild: "", ResolvedRuntimePacks: "", FrameworkReferences: "Microsoft.NETCore.App", UnavailableRuntimePacks: "", DisableTransitiveFrameworkReferenceDownloads: "", SatelliteResourceLanguages: "");
    
    ResolveRuntimePackAssetsRun = true;
}

void _GetUserSecretsAssemblyAttribute()
{
    // if ( '$(UserSecretsId)' != '' AND '$(GenerateUserSecretsAttribute)' != 'false' AND '$(GeneratedUserSecretsAttributeFile)' == '' )
    if ( '' != '' AND '' != 'false' AND '' == '' ) { _GetUserSecretsAssemblyAttributeRun = true; return; }
    
    _GetUserSecretsAssemblyAttributeRun = true;
}

void _ComputePackageReferencePublish()
{
    
    _ComputePackageReferencePublishRun = true;
}

void _DefaultMicrosoftNETPlatformLibrary()
{
    
    /* if ('$(MicrosoftNETPlatformLibrary)' == '')*/
    if ('' == '')
    {
        /* if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(_TargetFrameworkVersionWithoutV)' < '3.0')*/
        if ('.NETCoreApp' == '.NETCoreApp' And '8.0' < '3.0')
        {
            MicrosoftNETPlatformLibrary = "Microsoft.NETCore.App";
        }
    }
    _DefaultMicrosoftNETPlatformLibraryRun = true;
}

void _AddMicrosoftNetCompilerToolsetFrameworkPackage()
{
    
    /* if ('@(PackageReference->AnyHaveMetadataValue('Identity', 'Microsoft.Net.Compilers.Toolset.Framework'))' == 'true')*/
    if ('false' == 'true')
    {
        NETSdkWarning(ResourceName: "CannotDirectlyReferenceMicrosoftNetCompilersToolsetFramework");
    }
    
    _AddMicrosoftNetCompilerToolsetFrameworkPackageRun = true;
}

void _CheckForBuildWithNoBuild()
{
    // if ('$(NoBuild)' == 'true' and '$(GeneratePackageOnBuild)' != 'true')
    if ('' == 'true' and 'false' != 'true') { _CheckForBuildWithNoBuildRun = true; return; }
    
    NETSdkError(ResourceName: "NoBuildRequested");
    
    _CheckForBuildWithNoBuildRun = true;
}

void GenerateBuildDependencyFile()
{
    // if ('$(GenerateDependencyFile)' == 'true')
    if ('true' == 'true') { GenerateBuildDependencyFileRun = true; return; }
    // DependsOnTargets;
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    if (!_HandlePackageFileConflictsRun) _HandlePackageFileConflicts();
    if (!_ComputeReferenceAssembliesRun) _ComputeReferenceAssemblies();
    if (!_ComputeUserRuntimeAssembliesRun) _ComputeUserRuntimeAssemblies();
    if (!ResolveRuntimePackAssetsRun) ResolveRuntimePackAssets();
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    // BeforeTargets;
    if (!ComputeDependencyFileCompilerOptionsRun) ComputeDependencyFileCompilerOptions();
    
    /* if ('$(UsingNETSdkDefaults)' != 'true')*/
    if ('true' != 'true')
    {
        /* if ('$(Version)' == '')*/
        if ('1.0.0' == '')
        {
            Version = "1.0.0";
        }
    }
    /*GenerateDepsFile(CompileReferences: "@(ResolvedCompileFileDefinitions)", CompilerOptions: "@(DependencyFileCompilerOptions)", RuntimeFrameworks: "@(RuntimeFramework)", DepsFilePath: "$(ProjectDepsFilePath)", AssemblyExtension: "$(TargetExt)", RuntimeIdentifier: "$(RuntimeIdentifier)", ReferencePaths: "@(ReferencePath)", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", ReferenceSatellitePaths: "@(ReferenceSatellitePaths)", TargetFramework: "$(TargetFramework)", AssemblySatelliteAssemblies: "@(IntermediateSatelliteAssembliesWithTargetPath)", ResolvedNuGetFiles: "@(NativeCopyLocalItems);@(ResourceCopyLocalItems);@(RuntimeCopyLocalItems)", IsSelfContained: "$(SelfContained)", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", ReferenceAssemblies: "@(_ReferenceAssemblies)", ValidRuntimeIdentifierPlatformsForAssets: "@(_ValidRuntimeIdentifierPlatformsForAssets)", AssemblyName: "$(AssemblyName)", UserRuntimeAssemblies: "@(UserRuntimeAssembly)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssetsFilePath: "$(ProjectAssetsFile)", IncludeMainProject: "$(IncludeMainProjectInDepsFile)", RuntimePackAssets: "@(RuntimePackAsset)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", AssemblyVersion: "$(Version)", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", ProjectPath: "$(MSBuildProjectFullPath)", ReferenceDependencyPaths: "@(ReferenceDependencyPaths)");*/
    GenerateDepsFile(CompileReferences: "", CompilerOptions: "", RuntimeFrameworks: "", DepsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.deps.json", AssemblyExtension: ".dll", RuntimeIdentifier: "", ReferencePaths: "", IncludeProjectsNotInAssetsFile: "true", ReferenceSatellitePaths: "", TargetFramework: "net8.0", AssemblySatelliteAssemblies: "", ResolvedNuGetFiles: ";;", IsSelfContained: "false", IncludeRuntimeFileVersions: "true", ReferenceAssemblies: "", ValidRuntimeIdentifierPlatformsForAssets: "", AssemblyName: "6 - targets", UserRuntimeAssemblies: "", PlatformLibraryName: "", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", IncludeMainProject: "true", RuntimePackAssets: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", AssemblyVersion: "1.0.0", ResolvedRuntimeTargetsFiles: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ReferenceDependencyPaths: "");
    
    GenerateBuildDependencyFileRun = true;
}

void _GenerateRuntimeConfigurationFilesInputCache()
{
    // DependsOnTargets;
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    
    /*Hash(ItemsToHash: "@(_GenerateRuntimeConfigurationPropertyInputsCacheToHash)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(_GenerateRuntimeConfigurationPropertyInputsCache)", Overwrite: "True", Lines: "$(_GenerateRuntimeConfigurationPropertyInputsCacheHash)", WriteOnlyWhenDifferent: "True");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genruntimeconfig.cache", Overwrite: "True", Lines: "", WriteOnlyWhenDifferent: "True");
    
    _GenerateRuntimeConfigurationFilesInputCacheRun = true;
}

void GenerateBuildRuntimeConfigurationFiles()
{
    // if ( '$(GenerateRuntimeConfigurationFiles)' == 'true')
    if ( 'true' == 'true') { GenerateBuildRuntimeConfigurationFilesRun = true; return; }
    // DependsOnTargets;
    if (!_GenerateRuntimeConfigurationFilesInputCacheRun) _GenerateRuntimeConfigurationFilesInputCache();
    
    /* if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0')*/
    if ('8.0' >= '3.0')
    {
        _IsRollForwardSupported = "true";
    }
    /* if ('$(RollForward)' == '' and '$(EnableDynamicLoading)' == 'true' and '$(_IsRollForwardSupported)' == 'true')*/
    if ('' == '' and '' == 'true' and '' == 'true')
    {
        RollForward = "LatestMinor";
    }
    /* if ('$(SelfContained)' == 'true' and '$(_TargetFrameworkVersionWithoutV)' >= '3.1')*/
    if ('false' == 'true' and '8.0' >= '3.1')
    {
        _WriteIncludedFrameworks = "true";
    }
    /* if ('$(RollForward)' != '' and '$(RollForward)' != 'Major' and '$(RollForward)' != 'LatestMajor' and '$(_IsRollForwardSupported)' != 'true')*/
    if ('' != '' and '' != 'Major' and '' != 'LatestMajor' and '' != 'true')
    {
        NETSdkError(ResourceName: "RollForwardRequiresVersion30");
    }
    /*GenerateRuntimeConfigurationFiles(RollForward: "$(RollForward)", RuntimeFrameworks: "@(RuntimeFramework)", RuntimeIdentifier: "$(RuntimeIdentifier)", RuntimeConfigDevPath: "$(ProjectRuntimeConfigDevFilePath)", TargetFramework: "$(TargetFramework)", IsSelfContained: "$(SelfContained)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AdditionalProbingPaths: "@(AdditionalProbingPath)", GenerateRuntimeConfigDevFile: "$(GenerateRuntimeConfigDevFile)", WriteIncludedFrameworks: "$(_WriteIncludedFrameworks)", AlwaysIncludeCoreFramework: "$(AlwaysIncludeCoreFrameworkInRuntimeConfig)", AssetsFilePath: "$(ProjectAssetsFile)", UserRuntimeConfig: "$(UserRuntimeConfig)", HostConfigurationOptions: "@(RuntimeHostConfigurationOption)", RuntimeConfigPath: "$(ProjectRuntimeConfigFilePath)");*/
    GenerateRuntimeConfigurationFiles(RollForward: "", RuntimeFrameworks: "", RuntimeIdentifier: "", RuntimeConfigDevPath: "", TargetFramework: "net8.0", IsSelfContained: "false", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", PlatformLibraryName: "", AdditionalProbingPaths: "C:\\Users\\kant\\.dotnet\\store\\|arch|\\|tfm|", GenerateRuntimeConfigDevFile: "false", WriteIncludedFrameworks: "", AlwaysIncludeCoreFramework: "true", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", UserRuntimeConfig: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets/runtimeconfig.template.json", HostConfigurationOptions: "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization", RuntimeConfigPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.runtimeconfig.json");
    
    GenerateBuildRuntimeConfigurationFilesRun = true;
}

void AddRuntimeConfigFileToBuiltProjectOutputGroupOutput()
{
    // if ( '$(GenerateRuntimeConfigurationFiles)' == 'true')
    if ( 'true' == 'true') { AddRuntimeConfigFileToBuiltProjectOutputGroupOutputRun = true; return; }
    
    AddRuntimeConfigFileToBuiltProjectOutputGroupOutputRun = true;
}

void AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjects()
{
    // if ('$(HasRuntimeOutput)' == 'true')
    if ('true' == 'true') { AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun = true; return; }
    
    AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun = true;
}

void AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjects()
{
    // if ('$(HasRuntimeOutput)' == 'true')
    if ('true' == 'true') { AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjectsRun = true; return; }
    // DependsOnTargets;
    if (!_ComputeUseBuildDependencyFileRun) _ComputeUseBuildDependencyFile();
    
    AddDepsJsonAndRuntimeConfigToPublishItemsForReferencingProjectsRun = true;
}

void _SdkBeforeClean()
{
    
    /* if ('$(_CleaningWithoutRebuilding)' == '')*/
    if ('' == '')
    {
        _CleaningWithoutRebuilding = "true";
        EmitAssetsLogMessages = "false";
    }
    _SdkBeforeCleanRun = true;
}

void _SdkBeforeRebuild()
{
    // BeforeTargets;
    if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();
    
    _CleaningWithoutRebuilding = "false";
    _SdkBeforeRebuildRun = true;
}

void _CreateAppHost()
{
    // if ('$(ComputeNETCoreBuildOutputFiles)' == 'true' and
                     '$(AppHostSourcePath)' != '' and
                     Exists('@(IntermediateAssembly)') and
                     Exists('$(AppHostSourcePath)'))
    if ('true' == 'true' and
                     '' != '' and
                     Exists('obj\Debug\net8.0\6 - targets.dll') and
                     Exists('')) { _CreateAppHostRun = true; return; }
    // DependsOnTargets;
    if (!_ChooseAppHostRun) _ChooseAppHost();
    if (!CoreCompileRun) CoreCompile();
    
    /* if (($(RuntimeIdentifier.StartsWith('win')) or $(DefaultAppHostRuntimeIdentifier.StartsWith('win'))) and '$(OutputType)'=='WinExe')*/
    if ((False or True) and 'Exe'=='WinExe')
    {
        _UseWindowsGraphicalUserInterface = "true";
    }
    /* if ('$(_EnableMacOSCodeSign)' == '' and $([MSBuild]::IsOSPlatform(`OSX`)) and Exists('/usr/bin/codesign') and
                                      ($(RuntimeIdentifier.StartsWith('osx')) or $(AppHostRuntimeIdentifier.StartsWith('osx'))))*/
    if ('' == '' and False and Exists('/usr/bin/codesign') and
                                      (False or False))
    {
        _EnableMacOSCodeSign = "true";
    }
    /*CreateAppHost(AppHostDestinationPath: "$(AppHostIntermediatePath)", EnableMacOSCodeSign: "$(_EnableMacOSCodeSign)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", IntermediateAssembly: "@(IntermediateAssembly->'%(FullPath)')", WindowsGraphicalUserInterface: "$(_UseWindowsGraphicalUserInterface)", Retries: "$(CopyRetryCount)", AppBinaryName: "$(AssemblyName)$(TargetExt)", AppHostSourcePath: "$(AppHostSourcePath)");*/
    CreateAppHost(AppHostDestinationPath: "", EnableMacOSCodeSign: "", RetryDelayMilliseconds: "", IntermediateAssembly: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.dll", WindowsGraphicalUserInterface: "", Retries: "", AppBinaryName: "6 - targets.dll", AppHostSourcePath: "");
    
    _CreateAppHostRun = true;
}

void _ChooseAppHost()
{
    // if ('$(UseAppHost)' == 'true' and '$(_IsExecutable)' == 'true')
    if ('true' == 'true' and 'true' == 'true') { _ChooseAppHostRun = true; return; }
    // DependsOnTargets;
    if (!_GetAppHostPathsRun) _GetAppHostPaths();
    
    /* if ('$(PublishSingleFile)' == 'true' and
                              '$(SelfContained)' == 'true' and
                              '$(_TargetFrameworkVersionWithoutV)' >= '5.0' and
                              '$(SingleFileHostSourcePath)' != '')*/
    if ('' == 'true' and
                              'false' == 'true' and
                              '8.0' >= '5.0' and
                              '' != '')
    {
        AppHostSourcePath = "$(SingleFileHostSourcePath)";
        AppHostIntermediatePath = "$([System.IO.Path]::GetFullPath('$(IntermediateOutputPath)singlefilehost$(_NativeExecutableExtension)'))";
    }
    _ChooseAppHostRun = true;
}

void _GetAppHostPaths()
{
    // if ('$(UseAppHost)' == 'true' and '$(_IsExecutable)' == 'true')
    if ('true' == 'true' and 'true' == 'true') { _GetAppHostPathsRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();
    
    /* if ('$(UseAppHostFromAssetsFile)' == 'true')*/
    if ('' == 'true')
    {
        AppHostSourcePath = "@(_NativeRestoredAppHostNETCore)";
    }
    /* if ('$(UseAppHostFromAssetsFile)' == 'false' Or '@(_NativeRestoredAppHostNETCore)' != '')*/
    if ('' == 'false' Or '' != '')
    {
        AppHostIntermediatePath = "$([System.IO.Path]::GetFullPath('$(IntermediateOutputPath)apphost$(_NativeExecutableExtension)'))";
    }
    /*NETSdkError(ResourceName: "MultipleFilesResolved", FormatArguments: "$(_DotNetAppHostExecutableName)");*/
    /* if ('@(_NativeRestoredAppHostNETCore->Count())' > 1)*/
    if ('0' > 1)
    {
        NETSdkError(ResourceName: "MultipleFilesResolved", FormatArguments: "apphost.exe");
    }
    
    _GetAppHostPathsRun = true;
}

void _GenerateClsidMap()
{
    // if ('$(ComputeNETCoreBuildOutputFiles)' == 'true' and
                     '$(EnableComHosting)' == 'true')
    if ('true' == 'true' and
                     '' == 'true') { _GenerateClsidMapRun = true; return; }
    // DependsOnTargets;
    if (!CoreCompileRun) CoreCompile();
    
    /*GenerateClsidMap(IntermediateAssembly: "@(IntermediateAssembly->'%(FullPath)')", CLsidMapDestinationPath: "@(ClsidMap->'%(FullPath)')");*/
    GenerateClsidMap(IntermediateAssembly: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.dll", CLsidMapDestinationPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.clsidmap");
    
    _GenerateClsidMapRun = true;
}

void _CreateComHost()
{
    // if ('$(ComputeNETCoreBuildOutputFiles)' == 'true' and
                     '$(ComHostIntermediatePath)' != '' and
                     Exists('@(IntermediateAssembly)') and
                     Exists('$(ComHostSourcePath)'))
    if ('true' == 'true' and
                     '' != '' and
                     Exists('obj\Debug\net8.0\6 - targets.dll') and
                     Exists('')) { _CreateComHostRun = true; return; }
    // DependsOnTargets;
    if (!_GetComHostPathsRun) _GetComHostPaths();
    if (!CoreCompileRun) CoreCompile();
    if (!_GenerateClsidMapRun) _GenerateClsidMap();
    if (!_GenerateRegFreeComManifestRun) _GenerateRegFreeComManifest();
    
    /*CreateComHost(ClsidMapPath: "@(ClsidMap)", ComHostDestinationPath: "$(ComHostIntermediatePath)", ComHostSourcePath: "$(ComHostSourcePath)", TypeLibraries: "@(ComHostTypeLibrary)");*/
    CreateComHost(ClsidMapPath: "obj\\Debug\\net8.0\\6 - targets.clsidmap", ComHostDestinationPath: "", ComHostSourcePath: "", TypeLibraries: "");
    
    _CreateComHostRun = true;
}

void _GenerateRegFreeComManifest()
{
    // if ('$(ComputeNETCoreBuildOutputFiles)' == 'true' and
                     '$(EnableComHosting)' == 'true' and
                     '$(EnableRegFreeCom)' == 'true')
    if ('true' == 'true' and
                     '' == 'true' and
                     '' == 'true') { _GenerateRegFreeComManifestRun = true; return; }
    // DependsOnTargets;
    if (!_GenerateClsidMapRun) _GenerateClsidMap();
    if (!_GetComHostPathsRun) _GetComHostPaths();
    
    /*GenerateRegFreeComManifest(ComHostName: "$(ComHostFileName)", ClsidMapPath: "@(ClsidMap)", ComManifestPath: "@(RegFreeComManifest)", IntermediateAssembly: "@(IntermediateAssembly)", TypeLibraries: "@(ComHostTypeLibrary)");*/
    GenerateRegFreeComManifest(ComHostName: "", ClsidMapPath: "obj\\Debug\\net8.0\\6 - targets.clsidmap", ComManifestPath: "obj\\Debug\\net8.0\\6 - targets.X.manifest", IntermediateAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", TypeLibraries: "");
    
    _GenerateRegFreeComManifestRun = true;
}

void _GetComHostPaths()
{
    // if ('$(EnableComHosting)' == 'true' and '$(_IsExecutable)' != 'true')
    if ('' == 'true' and 'true' != 'true') { _GetComHostPathsRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();
    
    ComHostFileName = "$(AssemblyName).comhost$(_ComHostLibraryExtension)";
    ComHostIntermediatePath = "$([System.IO.Path]::GetFullPath('$(IntermediateOutputPath)$(ComHostFileName)'))";
    /* if ('$(ComHostSourcePath)' == '' or !Exists('$(ComHostSourcePath)'))*/
    if ('' == '' or !Exists(''))
    {
        NETSdkError(ResourceName: "CannotFindComhost");
    }
    
    _GetComHostPathsRun = true;
}

void _GetIjwHostPaths()
{
    // if ('$(UseIJWHost)' == 'true')
    if ('' == 'true') { _GetIjwHostPathsRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();
    
    /* if ('$(IjwHostSourcePath)' == '' or !Exists('$(IjwHostSourcePath)'))*/
    if ('' == '' or !Exists(''))
    {
        NETSdkError(ResourceName: "CannotFindIjwhost");
    }
    
    _GetIjwHostPathsRun = true;
}

void _ComputeNETCoreBuildOutputFiles()
{
    // if ('$(ComputeNETCoreBuildOutputFiles)' == 'true')
    if ('true' == 'true') { _ComputeNETCoreBuildOutputFilesRun = true; return; }
    // DependsOnTargets;
    if (!_ChooseAppHostRun) _ChooseAppHost();
    if (!_GetComHostPathsRun) _GetComHostPaths();
    if (!_GetIjwHostPathsRun) _GetIjwHostPaths();
    
    /* if ('$(AppHostIntermediatePath)' == '' and '$(SelfContained)' == 'true')*/
    if ('' == '' and 'false' == 'true')
    {
        /* if ('$(_CopyAndRenameDotnetHost)' == '')*/
        if ('' == '')
        {
            _CopyAndRenameDotnetHost = "true";
        }
    }
    _ComputeNETCoreBuildOutputFilesRun = true;
}

void _ComputeReferenceAssemblies()
{
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    _ComputeReferenceAssembliesRun = true;
}

void _ComputeUserRuntimeAssemblies()
{
    
    _ComputeUserRuntimeAssembliesRun = true;
}

void CoreGenerateSatelliteAssemblies()
{
    // if ('@(_SatelliteAssemblyResourceInputs)' != ''  and '$(GenerateSatelliteAssembliesForCore)' == 'true' )
    if ('' != ''  and 'true' == 'true' ) { CoreGenerateSatelliteAssembliesRun = true; return; }
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    if (!_GetAssemblyInfoFromTemplateFileRun) _GetAssemblyInfoFromTemplateFile();
    
    _AssemblyInfoFile = "$(IntermediateOutputPath)%(_SatelliteAssemblyResourceInputs.Culture)\\$(TargetName).resources.cs";
    _OutputAssembly = "$(IntermediateOutputPath)%(_SatelliteAssemblyResourceInputs.Culture)\\$(TargetName).resources.dll";
    /* if ('$(UseSharedCompilation)' == '')*/
    if ('' == '')
    {
        UseSharedCompilation = "true";
    }
    /*MakeDir(Directories: "@(_SatelliteAssemblyResourceInputs->'$(IntermediateOutputPath)%(Culture)')");*/
    MakeDir(Directories: "");
    /*WriteCodeFragment(AssemblyAttributes: "@(SatelliteAssemblyAttribute)", Language: "C#", OutputFile: "$(_AssemblyInfoFile)");*/
    WriteCodeFragment(AssemblyAttributes: "", Language: "C#", OutputFile: "");
    /*Csc(TargetType: "Library", WarningsAsErrors: "$(WarningsAsErrors)", ToolPath: "$(CscToolPath)", DelaySign: "$(DelaySign)", ToolExe: "$(CscToolExe)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", PublicSign: "$(PublicSign)", NoConfig: "true", DisabledWarnings: "$(DisabledWarnings)", Optimize: "$(Optimize)", NoLogo: "$(NoLogo)", Resources: "@(_SatelliteAssemblyResourceInputs)", KeyFile: "$(KeyOriginatorFile)", KeyContainer: "$(KeyContainerName)", UseSharedCompilation: "$(UseSharedCompilation)", References: "@(ReferencePath)", Sources: "$(_AssemblyInfoFile)", NoStandardLib: "$(NoCompilerStandardLib)", WarningLevel: "$(WarningLevel)", Deterministic: "$(Deterministic)", OutputAssembly: "$(_OutputAssembly)");*/
    Csc(TargetType: "Library", WarningsAsErrors: ";NU1605;SYSLIB0011", ToolPath: "", DelaySign: "", ToolExe: "", WarningsNotAsErrors: "", PublicSign: "", NoConfig: "true", DisabledWarnings: "", Optimize: "false", NoLogo: "", Resources: "", KeyFile: "", KeyContainer: "", UseSharedCompilation: "", References: "", Sources: "", NoStandardLib: "true", WarningLevel: "8", Deterministic: "true", OutputAssembly: "");
    
    CoreGenerateSatelliteAssembliesRun = true;
}

void _GetAssemblyInfoFromTemplateFile()
{
    
    /*GetAssemblyAttributes(PathToTemplateFile: "$(IntermediateOutputPath)$(TargetName)$(TargetExt)");*/
    GetAssemblyAttributes(PathToTemplateFile: "obj\\Debug\\net8.0\\6 - targets.dll");
    
    _GetAssemblyInfoFromTemplateFileRun = true;
}

void GetAllRuntimeIdentifiers()
{
    
    GetAllRuntimeIdentifiersRun = true;
}

void _BlockWinMDsOnUnsupportedTFMs()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), '5.0')))
    if ('.NETCoreApp' == '.NETCoreApp' and True) { _BlockWinMDsOnUnsupportedTFMsRun = true; return; }
    // DependsOnTargets;
    if (!ResolveReferencesRun) ResolveReferences();
    
    /*CheckForUnsupportedWinMDReferences(ReferencePaths: "@(ReferencePath)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
    CheckForUnsupportedWinMDReferences(ReferencePaths: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");
    /*NETSdkError(ResourceName: "WinMDObjNotSupportedOnTargetFramework", FormatArguments: "$(TargetFrameworkMoniker)");*/
    /* if ('$(OutputType)' == 'winmdobj')*/
    if ('Exe' == 'winmdobj')
    {
        NETSdkError(ResourceName: "WinMDObjNotSupportedOnTargetFramework", FormatArguments: ".NETCoreApp,Version=v8.0");
    }
    
    _BlockWinMDsOnUnsupportedTFMsRun = true;
}

void ValidateExecutableReferences()
{
    // if ('$(ValidateExecutableReferencesMatchSelfContained)' != 'false')
    if ('' != 'false') { ValidateExecutableReferencesRun = true; return; }
    
    /*ValidateExecutableReferences(ReferencedProjects: "@(_MSBuildProjectReferenceExistent)", UseAttributeForTargetFrameworkInfoPropertyNames: "$(_UseAttributeForTargetFrameworkInfoPropertyNames)", SelfContained: "$(SelfContained)", IsExecutable: "$(_IsExecutable)");*/
    ValidateExecutableReferences(ReferencedProjects: "", UseAttributeForTargetFrameworkInfoPropertyNames: "true", SelfContained: "false", IsExecutable: "true");
    
    ValidateExecutableReferencesRun = true;
}

void ValidateCommandLineProperties()
{
    
    ValidateCommandLinePropertiesRun = true;
}

void InitializeSourceControlInformationFromSourceControlManager()
{
    
    /* if ('$(RepositoryType)' == '')*/
    if ('' == '')
    {
        RepositoryType = "git";
    }
    /*Microsoft.Build.Tasks.Git.LocateRepository(NoWarnOnMissingInfo: "$(PkgMicrosoft_Build_Tasks_Git.Equals(''))", RemoteName: "$(GitRepositoryRemoteName)", ConfigurationScope: "$(GitRepositoryConfigurationScope)", Path: "$(MSBuildProjectDirectory)");*/
    Microsoft.Build.Tasks.Git.LocateRepository(NoWarnOnMissingInfo: "True", RemoteName: "", ConfigurationScope: "", Path: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
    
    InitializeSourceControlInformationFromSourceControlManagerRun = true;
}

void SetEmbeddedFilesFromSourceControlManagerUntrackedFiles()
{
    // DependsOnTargets;
    if (!InitializeSourceControlInformationFromSourceControlManagerRun) InitializeSourceControlInformationFromSourceControlManager();
    
    /*Microsoft.Build.Tasks.Git.GetUntrackedFiles(ProjectDirectory: "$(MSBuildProjectDirectory)", RepositoryId: "$(_GitRepositoryId)", ConfigurationScope: "$(GitRepositoryConfigurationScope)", Files: "@(Compile)");*/
    /* if ('$(_GitRepositoryId)' != '')*/
    if ('' != '')
    {
        Microsoft.Build.Tasks.Git.GetUntrackedFiles(ProjectDirectory: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", RepositoryId: "", ConfigurationScope: "", Files: "Program.cs");
    }
    
    SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun = true;
}

void _SourceLinkHasSingleProvider()
{
    
    /*Microsoft.SourceLink.Common.SourceLinkHasSingleProvider(ProviderTargets: "$(SourceLinkUrlInitializerTargets)");*/
    Microsoft.SourceLink.Common.SourceLinkHasSingleProvider(ProviderTargets: ";_InitializeGitHubSourceLinkUrl;_InitializeGitLabSourceLinkUrl;_InitializeAzureReposGitSourceLinkUrl;_InitializeBitbucketGitSourceLinkUrl");
    
    _SourceLinkHasSingleProviderRun = true;
}

void _InitializeSourceControlInformationFromSourceControlManager()
{
    // if ('$(EnableSourceControlManagerQueries)' == 'true')
    if ('true' == 'true') { _InitializeSourceControlInformationFromSourceControlManagerRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceControlInformationFromSourceControlManagerRun) InitializeSourceControlInformationFromSourceControlManager();
    if (!_SourceLinkHasSingleProviderRun) _SourceLinkHasSingleProvider();
    if (!Run) ();
    if (!TranslateGitHubUrlsInSourceControlInformationRun) TranslateGitHubUrlsInSourceControlInformation();
    if (!TranslateGitLabUrlsInSourceControlInformationRun) TranslateGitLabUrlsInSourceControlInformation();
    if (!TranslateAzureReposGitUrlsInSourceControlInformationRun) TranslateAzureReposGitUrlsInSourceControlInformation();
    if (!TranslateBitbucketGitUrlsInSourceControlInformationRun) TranslateBitbucketGitUrlsInSourceControlInformation();
    if (!SourceControlManagerPublishTranslatedUrlsRun) SourceControlManagerPublishTranslatedUrls();
    
    _InitializeSourceControlInformationFromSourceControlManagerRun = true;
}

void SourceControlManagerPublishTranslatedUrls()
{
    
    /* if ('$(PrivateRepositoryUrl)' == '')*/
    if ('' == '')
    {
        PrivateRepositoryUrl = "$(RepositoryUrl)";
    }
    /* if ('$(PrivateRepositoryUrl)' == '')*/
    if ('' == '')
    {
        PrivateRepositoryUrl = "$(ScmRepositoryUrl)";
    }
    SourceControlManagerPublishTranslatedUrlsRun = true;
}

void _SetSourceLinkFilePath()
{
    
    _SourceLinkFilePath = "$(IntermediateOutputPath)$(MSBuildProjectName).sourcelink.json";
    _SetSourceLinkFilePathRun = true;
}

void _SetEmbeddedFilesFromSourceControlManagerUntrackedFiles()
{
    // if ('$(EmbedUntrackedSources)' == 'true' and '$(EmbedAllSources)' != 'true' and '$(DebugType)' != 'none' and '$(EnableSourceControlManagerQueries)' == 'true' and '$(DesignTimeBuild)' != 'true')
    if ('true' == 'true' and '' != 'true' and 'portable' != 'none' and 'true' == 'true' and '' != 'true') { _SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun = true; return; }
    // DependsOnTargets;
    if (!BeforeCompileRun) BeforeCompile();
    if (!SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun) SetEmbeddedFilesFromSourceControlManagerUntrackedFiles();
    
    _SetEmbeddedFilesFromSourceControlManagerUntrackedFilesRun = true;
}

void _InitializeSourceRootMappedPathsOpt()
{
    // if ('$(SourceRootMappedPathsFeatureSupported)' == 'true')
    if ('true' == 'true') { _InitializeSourceRootMappedPathsOptRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceRootMappedPathsRun) InitializeSourceRootMappedPaths();
    
    _InitializeSourceRootMappedPathsOptRun = true;
}

void _GenerateSourceLinkFile()
{
    // if ('$(EnableSourceLink)' == 'true' and '$(DebugType)' != 'none')
    if ('true' == 'true' and 'portable' != 'none') { _GenerateSourceLinkFileRun = true; return; }
    // DependsOnTargets;
    if (!_SetSourceLinkFilePathRun) _SetSourceLinkFilePath();
    if (!Run) ();
    if (!_InitializeSourceRootMappedPathsOptRun) _InitializeSourceRootMappedPathsOpt();
    if (!Run) ();
    if (!_InitializeGitHubSourceLinkUrlRun) _InitializeGitHubSourceLinkUrl();
    if (!_InitializeGitLabSourceLinkUrlRun) _InitializeGitLabSourceLinkUrl();
    if (!_InitializeAzureReposGitSourceLinkUrlRun) _InitializeAzureReposGitSourceLinkUrl();
    if (!_InitializeBitbucketGitSourceLinkUrlRun) _InitializeBitbucketGitSourceLinkUrl();
    
    /*Microsoft.SourceLink.Common.GenerateSourceLinkFile(NoWarnOnMissingSourceControlInformation: "$(PkgMicrosoft_SourceLink_Common.Equals(''))", SourceRoots: "@(SourceRoot)", OutputFile: "$(_SourceLinkFilePath)");*/
    Microsoft.SourceLink.Common.GenerateSourceLinkFile(NoWarnOnMissingSourceControlInformation: "True", SourceRoots: "", OutputFile: "");
    
    _GenerateSourceLinkFileRun = true;
}

void GenerateSourceLinkFile()
{
    // if ('$(SourceControlInformationFeatureSupported)' == 'true')
    if ('true' == 'true') { GenerateSourceLinkFileRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceControlInformationRun) InitializeSourceControlInformation();
    if (!_GenerateSourceLinkFileRun) _GenerateSourceLinkFile();
    
    GenerateSourceLinkFileRun = true;
}

void _InitializeGitHubSourceLinkUrl()
{
    
    /*Microsoft.SourceLink.GitHub.GetSourceLinkUrl(SourceRoot: "@(SourceRoot)", Hosts: "@(SourceLinkGitHubHost)", RepositoryUrl: "$(PrivateRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
    Microsoft.SourceLink.GitHub.GetSourceLinkUrl(SourceRoot: "", Hosts: "github.com", RepositoryUrl: "", IsSingleProvider: "");
    
    _InitializeGitHubSourceLinkUrlRun = true;
}

void TranslateGitHubUrlsInSourceControlInformation()
{
    
    /*Microsoft.SourceLink.GitHub.TranslateRepositoryUrls(Hosts: "@(SourceLinkGitHubHost)", RepositoryUrl: "$(ScmRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoots: "@(SourceRoot)");*/
    Microsoft.SourceLink.GitHub.TranslateRepositoryUrls(Hosts: "github.com", RepositoryUrl: "", IsSingleProvider: "", SourceRoots: "");
    
    TranslateGitHubUrlsInSourceControlInformationRun = true;
}

void _InitializeGitLabSourceLinkUrl()
{
    
    /*Microsoft.SourceLink.GitLab.GetSourceLinkUrl(SourceRoot: "@(SourceRoot)", Hosts: "@(SourceLinkGitLabHost)", RepositoryUrl: "$(PrivateRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
    Microsoft.SourceLink.GitLab.GetSourceLinkUrl(SourceRoot: "", Hosts: "gitlab.com", RepositoryUrl: "", IsSingleProvider: "");
    
    _InitializeGitLabSourceLinkUrlRun = true;
}

void TranslateGitLabUrlsInSourceControlInformation()
{
    
    /*Microsoft.SourceLink.GitLab.TranslateRepositoryUrls(Hosts: "@(SourceLinkGitLabHost)", RepositoryUrl: "$(ScmRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoots: "@(SourceRoot)");*/
    Microsoft.SourceLink.GitLab.TranslateRepositoryUrls(Hosts: "gitlab.com", RepositoryUrl: "", IsSingleProvider: "", SourceRoots: "");
    
    TranslateGitLabUrlsInSourceControlInformationRun = true;
}

void _InitializeAzureReposGitSourceLinkUrl()
{
    
    /*Microsoft.SourceLink.AzureRepos.Git.GetSourceLinkUrl(SourceRoot: "@(SourceRoot)", Hosts: "@(SourceLinkAzureReposGitHost)", RepositoryUrl: "$(PrivateRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
    Microsoft.SourceLink.AzureRepos.Git.GetSourceLinkUrl(SourceRoot: "", Hosts: "visualstudio.com;vsts.me;dev.azure.com", RepositoryUrl: "", IsSingleProvider: "");
    
    _InitializeAzureReposGitSourceLinkUrlRun = true;
}

void TranslateAzureReposGitUrlsInSourceControlInformation()
{
    
    /*Microsoft.SourceLink.AzureRepos.Git.TranslateRepositoryUrls(Hosts: "@(SourceLinkAzureReposGitHost)", RepositoryUrl: "$(ScmRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoots: "@(SourceRoot)");*/
    Microsoft.SourceLink.AzureRepos.Git.TranslateRepositoryUrls(Hosts: "visualstudio.com;vsts.me;dev.azure.com", RepositoryUrl: "", IsSingleProvider: "", SourceRoots: "");
    
    TranslateAzureReposGitUrlsInSourceControlInformationRun = true;
}

void _InitializeBitbucketGitSourceLinkUrl()
{
    
    /*Microsoft.SourceLink.Bitbucket.Git.GetSourceLinkUrl(SourceRoot: "@(SourceRoot)", Hosts: "@(SourceLinkBitbucketGitHost)", RepositoryUrl: "$(PrivateRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
    Microsoft.SourceLink.Bitbucket.Git.GetSourceLinkUrl(SourceRoot: "", Hosts: "bitbucket.org", RepositoryUrl: "", IsSingleProvider: "");
    
    _InitializeBitbucketGitSourceLinkUrlRun = true;
}

void TranslateBitbucketGitUrlsInSourceControlInformation()
{
    
    /*Microsoft.SourceLink.Bitbucket.Git.TranslateRepositoryUrls(Hosts: "@(SourceLinkBitbucketGitHost)", RepositoryUrl: "$(ScmRepositoryUrl)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoots: "@(SourceRoot)");*/
    Microsoft.SourceLink.Bitbucket.Git.TranslateRepositoryUrls(Hosts: "bitbucket.org", RepositoryUrl: "", IsSingleProvider: "", SourceRoots: "");
    
    TranslateBitbucketGitUrlsInSourceControlInformationRun = true;
}

void _GenerateDesignerDepsFile()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp')
    if ('.NETCoreApp' == '.NETCoreApp') { _GenerateDesignerDepsFileRun = true; return; }
    
    /*GenerateDepsFile(CompileReferences: "@(ResolvedCompileFileDefinitions)", RuntimeFrameworks: "@(RuntimeFramework)", DepsFilePath: "$(_DesignerDepsFilePath)", AssemblyExtension: "_", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", TargetFramework: "$(TargetFramework)", ResolvedNuGetFiles: "@(NativeCopyLocalItems);@(ResourceCopyLocalItems);@(RuntimeCopyLocalItems)", IsSelfContained: "false", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", AssemblyName: "_", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssetsFilePath: "$(ProjectAssetsFile)", IncludeMainProject: "false", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", AssemblyVersion: "_", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", ProjectPath: "$(MSBuildProjectFullPath)");*/
    GenerateDepsFile(CompileReferences: "", RuntimeFrameworks: "", DepsFilePath: "obj\\Debug\\net8.0\\6 - targets.designer.deps.json", AssemblyExtension: "_", IncludeProjectsNotInAssetsFile: "true", TargetFramework: "net8.0", ResolvedNuGetFiles: ";;", IsSelfContained: "false", IncludeRuntimeFileVersions: "true", AssemblyName: "_", PlatformLibraryName: "", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", IncludeMainProject: "false", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", AssemblyVersion: "_", ResolvedRuntimeTargetsFiles: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    
    _GenerateDesignerDepsFileRun = true;
}

void _GenerateDesignerRuntimeConfigFile()
{
    // if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp')
    if ('.NETCoreApp' == '.NETCoreApp') { _GenerateDesignerRuntimeConfigFileRun = true; return; }
    
    /*GenerateRuntimeConfigurationFiles(RuntimeFrameworks: "@(RuntimeFramework)", WriteAdditionalProbingPathsToMainConfig: "true", TargetFramework: "$(TargetFramework)", IsSelfContained: "false", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AdditionalProbingPaths: "@(AdditionalProbingPath)", AlwaysIncludeCoreFramework: "$(AlwaysIncludeCoreFrameworkInRuntimeConfig)", AssetsFilePath: "$(ProjectAssetsFile)", UserRuntimeConfig: "$(UserRuntimeConfig)", HostConfigurationOptions: "@(RuntimeHostConfigurationOption);@(_DesignerHostConfigurationOption)", RuntimeConfigPath: "$(_DesignerRuntimeConfigFilePath)");*/
    GenerateRuntimeConfigurationFiles(RuntimeFrameworks: "", WriteAdditionalProbingPathsToMainConfig: "true", TargetFramework: "net8.0", IsSelfContained: "false", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", PlatformLibraryName: "", AdditionalProbingPaths: "C:\\Users\\kant\\.dotnet\\store\\|arch|\\|tfm|", AlwaysIncludeCoreFramework: "true", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", UserRuntimeConfig: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets/runtimeconfig.template.json", HostConfigurationOptions: "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization;", RuntimeConfigPath: "obj\\Debug\\net8.0\\6 - targets.designer.runtimeconfig.json");
    
    _GenerateDesignerRuntimeConfigFileRun = true;
}

void _GatherDesignerShadowCopyFiles()
{
    
    _GatherDesignerShadowCopyFilesRun = true;
}

void GenerateAssemblyInfo()
{
    // if ('$(GenerateAssemblyInfo)' == 'true')
    if ('true' == 'true') { GenerateAssemblyInfoRun = true; return; }
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    if (!CoreGenerateAssemblyInfoRun) CoreGenerateAssemblyInfo();
    
    GenerateAssemblyInfoRun = true;
}

void AddSourceRevisionToInformationalVersion()
{
    // if ('$(SourceControlInformationFeatureSupported)' == 'true' and '$(IncludeSourceRevisionInInformationalVersion)' == 'true')
    if ('true' == 'true' and 'true' == 'true') { AddSourceRevisionToInformationalVersionRun = true; return; }
    // DependsOnTargets;
    if (!GetAssemblyVersionRun) GetAssemblyVersion();
    if (!InitializeSourceControlInformationRun) InitializeSourceControlInformation();
    
    /* if ('$(SourceRevisionId)' != '')*/
    if ('' != '')
    {
        _InformationalVersionContainsPlus = "false";
        /* if ($(InformationalVersion.Contains('+')))*/
        if (False)
        {
            _InformationalVersionContainsPlus = "true";
        }
        /* if (!$(_InformationalVersionContainsPlus))*/
        if (!)
        {
            InformationalVersion = "$(InformationalVersion)+$(SourceRevisionId)";
        }
        /* if ($(_InformationalVersionContainsPlus))*/
        if ()
        {
            InformationalVersion = "$(InformationalVersion).$(SourceRevisionId)";
        }
    }
    AddSourceRevisionToInformationalVersionRun = true;
}

void GetAssemblyAttributes()
{
    // DependsOnTargets;
    if (!GetAssemblyVersionRun) GetAssemblyVersion();
    if (!AddSourceRevisionToInformationalVersionRun) AddSourceRevisionToInformationalVersion();
    // BeforeTargets;
    if (!_GetUserSecretsAssemblyAttributeRun) _GetUserSecretsAssemblyAttribute();
    
    GetAssemblyAttributesRun = true;
}

void CreateGeneratedAssemblyInfoInputsCacheFile()
{
    // DependsOnTargets;
    if (!GetAssemblyAttributesRun) GetAssemblyAttributes();
    
    GeneratedAssemblyInfoInputsCacheFile = "$(IntermediateOutputPath)$(MSBuildProjectName).AssemblyInfoInputs.cache";
    /*Hash(ItemsToHash: "@(AssemblyAttribute->'%(Identity)%(_Parameter1)%(_Parameter2)%(_Parameter3)%(_Parameter4)%(_Parameter5)%(_Parameter6)%(_Parameter7)%(_Parameter8)')");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(GeneratedAssemblyInfoInputsCacheFile)", Overwrite: "True", Lines: "$(_AssemblyAttributesHash)", WriteOnlyWhenDifferent: "True");*/
    WriteLinesToFile(File: "", Overwrite: "True", Lines: "", WriteOnlyWhenDifferent: "True");
    
    CreateGeneratedAssemblyInfoInputsCacheFileRun = true;
}

void CoreGenerateAssemblyInfo()
{
    // if ('$(Language)'=='VB' or '$(Language)'=='C#')
    if ('C#'=='VB' or 'C#'=='C#') { CoreGenerateAssemblyInfoRun = true; return; }
    // DependsOnTargets;
    if (!CreateGeneratedAssemblyInfoInputsCacheFileRun) CreateGeneratedAssemblyInfoInputsCacheFile();
    
    /*WriteCodeFragment(AssemblyAttributes: "@(AssemblyAttribute)", Language: "$(Language)", OutputFile: "$(GeneratedAssemblyInfoFile)");*/
    WriteCodeFragment(AssemblyAttributes: "", Language: "C#", OutputFile: "obj\\Debug\\net8.0\\6 - targets.AssemblyInfo.cs");
    
    CoreGenerateAssemblyInfoRun = true;
}

void GetAssemblyVersion()
{
    
    /* if ('$(FileVersion)' == '')*/
    if ('' == '')
    {
        FileVersion = "$(AssemblyVersion)";
    }
    /* if ('$(InformationalVersion)' == '')*/
    if ('' == '')
    {
        InformationalVersion = "$(Version)";
    }
    /*GetAssemblyVersion(NuGetVersion: "$(Version)");*/
    /* if ('$(AssemblyVersion)' == '')*/
    if ('' == '')
    {
        GetAssemblyVersion(NuGetVersion: "1.0.0");
    }
    
    GetAssemblyVersionRun = true;
}

void GenerateGlobalUsings()
{
    // if (@(Using->Count()) != 0)
    if (7 != 0) { GenerateGlobalUsingsRun = true; return; }
    
    /*GenerateGlobalUsings(Usings: "@(Using)");*/
    GenerateGlobalUsings(Usings: "System;System.Collections.Generic;System.IO;System.Linq;System.Net.Http;System.Threading;System.Threading.Tasks");
    /*WriteLinesToFile(File: "$(GeneratedGlobalUsingsFile)", Overwrite: "true", Lines: "@(_GlobalUsingLines)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "obj\\Debug\\net8.0\\6 - targets.GlobalUsings.g.cs", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    GenerateGlobalUsingsRun = true;
}

void GenerateSupportedRuntime()
{
    // if ('$(GenerateSupportedRuntime)' != 'false' and '$(TargetFrameworkIdentifier)' == '.NETFramework' and '$(HasRuntimeOutput)' == 'true')
    if ('' != 'false' and '.NETCoreApp' == '.NETFramework' and 'true' == 'true') { GenerateSupportedRuntimeRun = true; return; }
    // DependsOnTargets;
    if (!_WriteAppConfigWithSupportedRuntimeRun) _WriteAppConfigWithSupportedRuntime();
    
    /*SetGeneratedAppConfigMetadata(TargetName: "$(TargetFileName).config", AppConfigFile: "@(AppConfigWithTargetPath)", GeneratedAppConfigFile: "$(_GenerateSupportedRuntimeIntermediateAppConfig)");*/
    SetGeneratedAppConfigMetadata(TargetName: "6 - targets.dll.config", AppConfigFile: "", GeneratedAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.withSupportedRuntime.config");
    
    GenerateSupportedRuntimeRun = true;
}

void _WriteAppConfigWithSupportedRuntime()
{
    // DependsOnTargets;
    if (!PrepareForBuildRun) PrepareForBuild();
    
    /*WriteAppConfigWithSupportedRuntime(TargetFrameworkVersion: "$(TargetFrameworkVersion)", OutputAppConfigFile: "$(_GenerateSupportedRuntimeIntermediateAppConfig)", TargetFrameworkProfile: "$(TargetFrameworkProfile)", AppConfigFile: "@(AppConfigWithTargetPath)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)");*/
    WriteAppConfigWithSupportedRuntime(TargetFrameworkVersion: "v8.0", OutputAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.withSupportedRuntime.config", TargetFrameworkProfile: "", AppConfigFile: "", TargetFrameworkIdentifier: ".NETCoreApp");
    
    _WriteAppConfigWithSupportedRuntimeRun = true;
}

void ComposeStore()
{
    // DependsOnTargets;
    if (!PrepareForComposeStoreRun) PrepareForComposeStore();
    if (!PrepOptimizerRun) PrepOptimizer();
    if (!StoreWorkerMainRun) StoreWorkerMain();
    if (!_CopyResolvedUnOptimizedFilesRun) _CopyResolvedUnOptimizedFiles();
    if (!StoreFinalizerRun) StoreFinalizer();
    if (!Run) ();
    
    ComposeStoreRun = true;
}

void StoreWorkerMain()
{
    
    /*MSBuild(BuildinParallel: "$(BuildinParallel)", Targets: "StoreWorkerMapper", Projects: "%(_AllProjects.Identity)", Properties: """ComposeWorkingDir=$(ComposeWorkingDir);
                             PublishDir=$(PublishDir);
                             StoreStagingDir=$(StoreStagingDir);
                             TargetFramework=$(_TFM);
                             JitPath=$(JitPath);
                             Crossgen=$(Crossgen);
                             DisableImplicitFrameworkReferences=true;
                             SkipUnchangedFiles=$(SkipUnchangedFiles);
                             PreserveStoreLayout=$(PreserveStoreLayout);
                             CreateProfilingSymbols=$(CreateProfilingSymbols);
                             StoreSymbolsStagingDir=$(StoreSymbolsStagingDir)""");*/
    MSBuild(BuildinParallel: "true", Targets: "StoreWorkerMapper", Projects: "%(_AllProjects.Identity)", Properties: """ComposeWorkingDir=;
                             PublishDir=bin\\Debug\\net8.0\\publish\\;
                             StoreStagingDir=;
                             TargetFramework=;
                             JitPath=;
                             Crossgen=;
                             DisableImplicitFrameworkReferences=true;
                             SkipUnchangedFiles=;
                             PreserveStoreLayout=;
                             CreateProfilingSymbols=;
                             StoreSymbolsStagingDir=""");
    
    StoreWorkerMainRun = true;
}

void StoreWorkerMapper()
{
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "RestoreForComposeStore", Projects: "@(PackageReferencesToStore)");*/
    MSBuild(BuildInParallel: "true", Targets: "RestoreForComposeStore", Projects: "");
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "StoreResolver", Projects: "@(PackageReferencesToStore)", Properties: "SelfContained=false;UseAppHost=false;MSBuildProjectExtensionsPath=$(ComposeWorkingDir)\\%(PackageReferencesToStore.PackageName)_$([System.String]::Copy('%(PackageReferencesToStore.PackageVersion)').Replace('*','-'))\\;");*/
    MSBuild(BuildInParallel: "true", Targets: "StoreResolver", Projects: "", Properties: "SelfContained=false;UseAppHost=false;MSBuildProjectExtensionsPath=\\%(PackageReferencesToStore.PackageName)_%(PackageReferencesToStore.PackageVersion)\\;");
    
    StoreWorkerMapperRun = true;
}

void StoreResolver()
{
    // DependsOnTargets;
    if (!PrepforRestoreForComposeStoreRun) PrepforRestoreForComposeStore();
    if (!StoreWorkerPerformWorkRun) StoreWorkerPerformWork();
    
    StoreResolverRun = true;
}

void StoreWorkerPerformWork()
{
    // if (Exists($(StoreWorkerWorkingDir)))
    if (Exists()) { StoreWorkerPerformWorkRun = true; return; }
    // DependsOnTargets;
    if (!ComputeAndCopyFilesToStoreDirectoryRun) ComputeAndCopyFilesToStoreDirectory();
    if (!Run) ();
    
    StoreWorkerPerformWorkRun = true;
}

void StoreFinalizer()
{
    // DependsOnTargets;
    if (!StoreWorkerMainRun) StoreWorkerMain();
    if (!_CopyResolvedOptimizedFilesRun) _CopyResolvedOptimizedFiles();
    
    _StoreArtifactContent = """
<StoreArtifacts>
@(ListOfPackageReference)
</StoreArtifacts>
""";
    /*RemoveDuplicatePackageReferences(InputPackageReferences: "@(AllResolvedPackagesPublished)");*/
    RemoveDuplicatePackageReferences(InputPackageReferences: "");
    /*WriteLinesToFile(File: "$(StoreArtifactXml)", Overwrite: "true", Lines: "$(_StoreArtifactContent)");*/
    WriteLinesToFile(File: "", Overwrite: "true", Lines: "");
    /*Message(Text: "Files were composed in $(PublishDir)", Importance: "high");*/
    Message(Text: "Files were composed in bin\\Debug\\net8.0\\publish\\", Importance: "high");
    /*Message(Text: "The list of packages stored is in $(StoreArtifactXml) ", Importance: "high");*/
    Message(Text: "The list of packages stored is in  ", Importance: "high");
    /*RemoveDir(Directories: "$(ComposeWorkingDir)");*/
    /* if ('$(PreserveComposeWorkingDir)' != 'true')*/
    if ('' != 'true')
    {
        RemoveDir(Directories: "");
    }
    
    StoreFinalizerRun = true;
}

void _CopyResolvedOptimizedFiles()
{
    // DependsOnTargets;
    if (!StoreWorkerMainRun) StoreWorkerMain();
    if (!Run) ();
    
    /*Copy(RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_OptimizedResolvedFileToPublish)", DestinationFolder: "$(PublishDir)%(_OptimizedResolvedFileToPublish.RecursiveDir)");*/
    /* if ('@(_OptimizedResolvedFileToPublish)' != '')*/
    if ('' != '')
    {
        Copy(RetryDelayMilliseconds: "", SkipUnchangedFiles: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "bin\\Debug\\net8.0\\publish\\%(_OptimizedResolvedFileToPublish.RecursiveDir)");
    }
    /*Copy(RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_OptimizedSymbolFileToPublish)", DestinationFolder: "$(ProfilingSymbolsDir)%(_OptimizedSymbolFileToPublish.RecursiveDir)");*/
    /* if ('@(_OptimizedSymbolFileToPublish)' != '')*/
    if ('' != '')
    {
        Copy(RetryDelayMilliseconds: "", SkipUnchangedFiles: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "%(_OptimizedSymbolFileToPublish.RecursiveDir)");
    }
    
    _CopyResolvedOptimizedFilesRun = true;
}

void PrepareForComposeStore()
{
    
    /* if ('$(PreserveStoreLayout)' == '')*/
    if ('' == '')
    {
        PreserveStoreLayout = "true";
    }
    /* if ('$(RuntimeIdentifier)' == '')*/
    if ('' == '')
    {
        SkipOptimization = "true";
    }
    /* if ('$(_TFM)' == '')*/
    if ('' == '')
    {
        _TFM = "$(TargetFramework)";
    }
    /* if ('$(SkipUnchangedFiles)' == '')*/
    if ('' == '')
    {
        SkipUnchangedFiles = "true";
    }
    DefaultComposeDir = "$(UserProfileRuntimeStorePath)";
    _ProfilingSymbolsDirectoryName = "symbols";
    DefaultProfilingSymbolsDir = "$([System.IO.Path]::Combine($(DefaultComposeDir), $(_ProfilingSymbolsDirectoryName)))";
    /* if ('$(ProfilingSymbolsDir)' == '' and '$(ComposeDir)' != '')*/
    if ('' == '' and '' != '')
    {
        ProfilingSymbolsDir = "$([System.IO.Path]::Combine($(ComposeDir), $(_ProfilingSymbolsDirectoryName)))";
    }
    /* if ('$(ProfilingSymbolsDir)' != '' and '$(DoNotDecorateComposeDir)' != 'true')*/
    if ('' != '' and '' != 'true')
    {
        ProfilingSymbolsDir = "$([System.IO.Path]::Combine($(ProfilingSymbolsDir), $(PlatformTarget)))";
    }
    /* if ('$(ProfilingSymbolsDir)' == '')*/
    if ('' == '')
    {
        ProfilingSymbolsDir = "$(DefaultProfilingSymbolsDir)";
    }
    /* if ('$(DoNotDecorateComposeDir)' != 'true')*/
    if ('' != 'true')
    {
        ProfilingSymbolsDir = "$([System.IO.Path]::Combine($(ProfilingSymbolsDir), $(_TFM)))";
    }
    /* if (!HasTrailingSlash('$(ProfilingSymbolsDir)'))*/
    if (!HasTrailingSlash(''))
    {
        ProfilingSymbolsDir = "$(ProfilingSymbolsDir)\\";
    }
    /* if ('$(ComposeDir)' == '')*/
    if ('' == '')
    {
        ComposeDir = "$(DefaultComposeDir)";
    }
    /* if ('$(DoNotDecorateComposeDir)' != 'true')*/
    if ('' != 'true')
    {
        ComposeDir = "$([System.IO.Path]::Combine($(ComposeDir), $(PlatformTarget)))";
    }
    /* if ('$(DoNotDecorateComposeDir)' != 'true')*/
    if ('' != 'true')
    {
        ComposeDir = "$([System.IO.Path]::Combine($(ComposeDir), $(_TFM)))";
    }
    StoreArtifactXml = "$([System.IO.Path]::Combine($(ComposeDir),"artifact.xml"))";
    PublishDir = "$([System.IO.Path]::GetFullPath($(ComposeDir)))";
    _RandomFileName = "$([System.IO.Path]::GetRandomFileName())";
    /* if ('$(TEMP)' == '')*/
    if ('C:\Users\kant\AppData\Local\Temp' == '')
    {
        TEMP = "$([System.IO.Path]::GetTempPath())";
    }
    /* if ('$(ComposeWorkingDir)' == '')*/
    if ('' == '')
    {
        ComposeWorkingDir = "$([System.IO.Path]::Combine($(TEMP), $(_RandomFileName)))";
    }
    ComposeWorkingDir = "$([System.IO.Path]::GetFullPath($(ComposeWorkingDir)))";
    StoreStagingDir = "$([System.IO.Path]::Combine($(ComposeWorkingDir),"StagingDir"))";
    StoreSymbolsStagingDir = "$([System.IO.Path]::Combine($(ComposeWorkingDir),"SymbolsStagingDir"))";
    /* if (!HasTrailingSlash('$(PublishDir)'))*/
    if (!HasTrailingSlash('bin\Debug\net8.0\publish\'))
    {
        PublishDir = "$(PublishDir)\\";
    }
    /* if ('$(CreateProfilingSymbols)' == '')*/
    if ('' == '')
    {
        /* if ($(RuntimeIdentifier.StartsWith('osx')))*/
        if (False)
        {
            CreateProfilingSymbols = "false";
        }
        /* if ('$(CreateProfilingSymbols)' == '')*/
        if ('' == '')
        {
            CreateProfilingSymbols = "true";
        }
    }
    /*NETSdkError(ResourceName: "UnuspportedFramework", FormatArguments: "$(TargetFrameworkMoniker)");*/
    /* if ('2.0' > '$(_TargetFrameworkVersionWithoutV)')*/
    if ('2.0' > '8.0')
    {
        NETSdkError(ResourceName: "UnuspportedFramework", FormatArguments: ".NETCoreApp,Version=v8.0");
    }
    /* if ('$(RuntimeIdentifier)' =='' and '$(_PureManagedAssets)' == '')*/
    if ('' =='' and '' == '')
    {
        NETSdkError(ResourceName: "RuntimeIdentifierWasNotSpecified");
    }
    /* if ('$(_TFM)' =='')*/
    if ('' =='')
    {
        NETSdkError(ResourceName: "AtLeastOneTargetFrameworkMustBeSpecified");
    }
    /*NETSdkError(ResourceName: "FolderAlreadyExists", FormatArguments: "$(ComposeWorkingDir)");*/
    /* if (Exists($(ComposeWorkingDir)))*/
    if (Exists())
    {
        NETSdkError(ResourceName: "FolderAlreadyExists", FormatArguments: "");
    }
    /*MakeDir(Directories: "$(PublishDir)");*/
    MakeDir(Directories: "bin\\Debug\\net8.0\\publish\\");
    /*MakeDir(Directories: "$(StoreStagingDir)");*/
    MakeDir(Directories: "");
    
    PrepareForComposeStoreRun = true;
}

void PrepforRestoreForComposeStore()
{
    // DependsOnTargets;
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    
    StorePackageVersionForFolderName = "$(StorePackageVersion.Replace('*','-'))";
    StoreWorkerWorkingDir = "$([System.IO.Path]::Combine($(ComposeWorkingDir),"$(StorePackageName)_$(StorePackageVersionForFolderName)"))";
    _PackageProjFile = "$([System.IO.Path]::Combine($(StoreWorkerWorkingDir), "Restore.csproj"))";
    BaseIntermediateOutputPath = "$(StoreWorkerWorkingDir)\\";
    ProjectAssetsFile = "$(BaseIntermediateOutputPath)\\project.assets.json";
    PackagesToPrune = "$(MicrosoftNETPlatformLibrary)";
    /* if ('$(SelfContained)' == '')*/
    if ('false' == '')
    {
        SelfContained = "true";
    }
    PrepforRestoreForComposeStoreRun = true;
}

void RestoreForComposeStore()
{
    // if (!Exists($(StoreWorkerWorkingDir)))
    if (!Exists()) { RestoreForComposeStoreRun = true; return; }
    // DependsOnTargets;
    if (!PrepforRestoreForComposeStoreRun) PrepforRestoreForComposeStore();
    if (!Run) ();
    
    /*MakeDir(Directories: "$(StoreWorkerWorkingDir)");*/
    MakeDir(Directories: "");
    /*MSBuild(Targets: "Restore", Projects: "$(MSBuildProjectFullPath)", Properties: """RestoreGraphProjectInput=$(MSBuildProjectFullPath);
                             RestoreOutputPath=$(BaseIntermediateOutputPath);
                             StorePackageName=$(StorePackageName);
                             StorePackageVersion=$(StorePackageVersion);
                             RuntimeIdentifier=$(RuntimeIdentifier);
                             TargetFramework=$(TargetFramework);""");*/
    MSBuild(Targets: "Restore", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """RestoreGraphProjectInput=D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;
                             RestoreOutputPath=obj\\;
                             StorePackageName=;
                             StorePackageVersion=;
                             RuntimeIdentifier=;
                             TargetFramework=net8.0;""");
    
    RestoreForComposeStoreRun = true;
}

void ComputeAndCopyFilesToStoreDirectory()
{
    // DependsOnTargets;
    if (!ComputeFilesToStoreRun) ComputeFilesToStore();
    if (!CopyFilesToStoreDirectoryRun) CopyFilesToStoreDirectory();
    
    ComputeAndCopyFilesToStoreDirectoryRun = true;
}

void CopyFilesToStoreDirectory()
{
    // DependsOnTargets;
    if (!_CopyResolvedUnOptimizedFilesRun) _CopyResolvedUnOptimizedFiles();
    
    CopyFilesToStoreDirectoryRun = true;
}

void _CopyResolvedUnOptimizedFiles()
{
    // DependsOnTargets;
    if (!_ComputeResolvedFilesToStoreTypesRun) _ComputeResolvedFilesToStoreTypes();
    if (!_RunOptimizerRun) _RunOptimizer();
    
    /*Copy(DestinationFiles: "$(PublishDir)%(_UnOptimizedResolvedFileToPublish.DestinationSubPath)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_UnOptimizedResolvedFileToPublish)");*/
    Copy(DestinationFiles: "bin\\Debug\\net8.0\\publish\\%(_UnOptimizedResolvedFileToPublish.DestinationSubPath)", RetryDelayMilliseconds: "", SkipUnchangedFiles: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyResolvedUnOptimizedFilesRun = true;
}

void _ComputeResolvedFilesToStoreTypes()
{
    // DependsOnTargets;
    if (!_GetResolvedFilesToStoreRun) _GetResolvedFilesToStore();
    if (!_SplitResolvedFilesRun) _SplitResolvedFiles();
    if (!Run) ();
    
    _ComputeResolvedFilesToStoreTypesRun = true;
}

void _SplitResolvedFiles()
{
    // if ($(SkipOptimization) !='true' )
    if ( !='true' ) { _SplitResolvedFilesRun = true; return; }
    // DependsOnTargets;
    if (!_GetResolvedFilesToStoreRun) _GetResolvedFilesToStore();
    
    /* if ('@(_ManagedResolvedFileToPublishCandidates)'=='')*/
    if (''=='')
    {
        SkipOptimization = "true";
    }
    _SplitResolvedFilesRun = true;
}

void _GetResolvedFilesToStore()
{
    // if ($(SkipOptimization) == 'true' )
    if ( == 'true' ) { _GetResolvedFilesToStoreRun = true; return; }
    
    _GetResolvedFilesToStoreRun = true;
}

void ComputeFilesToStore()
{
    // DependsOnTargets;
    if (!_ComputeResolvedCopyLocalPublishAssetsRun) _ComputeResolvedCopyLocalPublishAssets();
    if (!_ComputeCopyToPublishDirectoryItemsRun) _ComputeCopyToPublishDirectoryItems();
    
    /* if ('$(CopyBuildOutputToPublishDirectory)'=='')*/
    if ('true'=='')
    {
        CopyBuildOutputToPublishDirectory = "true";
    }
    /* if ('$(CopyOutputSymbolsToPublishDirectory)'=='')*/
    if ('true'=='')
    {
        CopyOutputSymbolsToPublishDirectory = "true";
    }
    /*FilterResolvedFiles(ResolvedFiles: "@(_ResolvedCopyLocalPublishAssets)", RuntimeIdentifier: "$(RuntimeIdentifier)", PackagesToPrune: "$(PackagesToPrune)", TargetFramework: "$(TargetFramework)", IsSelfContained: "$(SelfContained)", AssetsFilePath: "$(ProjectAssetsFile)");*/
    FilterResolvedFiles(ResolvedFiles: "", RuntimeIdentifier: "", PackagesToPrune: "", TargetFramework: "net8.0", IsSelfContained: "false", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json");
    
    ComputeFilesToStoreRun = true;
}

void PrepRestoreForStoreProjects()
{
    // if ('$(StorePackageName)' != '')
    if ('' != '') { PrepRestoreForStoreProjectsRun = true; return; }
    
    PrepRestoreForStoreProjectsRun = true;
}

void PrepOptimizer()
{
    // if ($(SkipOptimization) != 'true' )
    if ( != 'true' ) { PrepOptimizerRun = true; return; }
    // DependsOnTargets;
    if (!_RestoreCrossgenRun) _RestoreCrossgen();
    if (!Run) ();
    
    _CoreclrPath = "@(_CoreclrResolvedPath)";
    JitPath = "@(_JitResolvedPath)";
    _CoreclrDir = "$([System.IO.Path]::GetDirectoryName($(_CoreclrPath)))";
    _CoreclrPkgDir = "$([System.IO.Path]::Combine($(_CoreclrDir),"..\\..\\..\\"))";
    CrossgenDir = "$([System.IO.Path]::Combine($(_CoreclrPkgDir),"tools"))";
    Crossgen = "$([System.IO.Path]::Combine($(CrossgenDir),"crossgen"))";
    /* if ($([MSBuild]::IsOSPlatform(`Windows`)))*/
    if (True)
    {
        Crossgen = "$([System.IO.Path]::Combine($(CrossgenDir),"crossgen.exe"))";
    }
    Crossgen = "$([System.IO.Path]::GetFullPath($([System.IO.Path]::Combine($(_NetCoreRefDir), $([System.IO.Path]::GetFileName($(Crossgen)))))))";
    /* if ('@(_CoreclrResolvedPath->Count())' > 1)*/
    if ('0' > 1)
    {
        NETSdkError(ResourceName: "MultipleFilesResolved", FormatArguments: "coreclr");
    }
    /* if ('@(_CoreclrResolvedPath)'== '')*/
    if (''== '')
    {
        NETSdkError(ResourceName: "UnableToFindResolvedPath", FormatArguments: "coreclr");
    }
    /* if ('@(_JitResolvedPath->Count())' > 1)*/
    if ('0' > 1)
    {
        NETSdkError(ResourceName: "MultipleFilesResolved", FormatArguments: "jit");
    }
    /* if ('@(_JitResolvedPath)'== '')*/
    if (''== '')
    {
        NETSdkError(ResourceName: "UnableToFindResolvedPath", FormatArguments: "jit");
    }
    /*NETSdkError(ResourceName: "UnableToFindResolvedPath", FormatArguments: "$(Crossgen)");*/
    /* if (!Exists($(Crossgen)))*/
    if (!Exists())
    {
        NETSdkError(ResourceName: "UnableToFindResolvedPath", FormatArguments: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "$(Crossgen)", DestinationFolder: "$(_NetCoreRefDir)");*/
    Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "");
    
    PrepOptimizerRun = true;
}

void _RunOptimizer()
{
    // if ($(SkipOptimization) != 'true' )
    if ( != 'true' ) { _RunOptimizerRun = true; return; }
    // DependsOnTargets;
    if (!_InitializeBasicPropsRun) _InitializeBasicProps();
    if (!_ComputeResolvedFilesToStoreTypesRun) _ComputeResolvedFilesToStoreTypes();
    if (!_SetupStageForCrossgenRun) _SetupStageForCrossgen();
    
    /*MSBuild(BuildInParallel: "$(BuildInParallel)", Targets: "RunCrossGen", Projects: "@(AssembliestoCrossgen)");*/
    /* if ('@(_ManagedResolvedFilesToOptimize)' != '')*/
    if ('' != '')
    {
        MSBuild(BuildInParallel: "true", Targets: "RunCrossGen", Projects: "");
    }
    
    _RunOptimizerRun = true;
}

void RunCrossGen()
{
    // DependsOnTargets;
    if (!_InitializeBasicPropsRun) _InitializeBasicProps();
    if (!Run) ();
    
    CrossgenProfilingSymbolsOutputDirectory = "$([System.IO.Path]::GetDirectoryName($(_RuntimeSymbolsDir)\\$(CrossgenSubOutputPath)))";
    CrossgenSymbolsStagingDirectory = "$([System.IO.Path]::GetDirectoryName($(StoreSymbolsStagingDir)\\$(CrossgenSubOutputPath)))";
    CrossgenCommandline = "$(CrossgenExe) -nologo -readytorun -in "$(CrossgenInputAssembly)" -out "$(CrossgenOutputAssembly)" -jitpath "$(CrossgenJit)" -platform_assemblies_paths "$(CrossgenPlatformAssembliesPath)"";
    /* if ($([MSBuild]::IsOSPlatform(`Windows`)))*/
    if (True)
    {
        CreateProfilingSymbolsOptionName = "CreatePDB";
    }
    /* if ('$(CreateProfilingSymbolsOptionName)' == '')*/
    if ('' == '')
    {
        CreateProfilingSymbolsOptionName = "CreatePerfMap";
    }
    /*Message(Text: "CrossgenCommandline: $(CrossgenCommandline)");*/
    Message(Text: "CrossgenCommandline: ");
    /*Exec(Command: "$(CrossgenCommandline)", IgnoreStandardErrorWarningFormat: "true");*/
    /* if (!Exists($([System.IO.Path]::Combine($(PublishDir),$(CrossgenSubOutputPath)))))*/
    if (!Exists(bin\Debug\net8.0\publish\))
    {
        Exec(Command: "", IgnoreStandardErrorWarningFormat: "true");
    }
    /*Copy(DestinationFiles: "$(PublishDir)\\$(CrossgenSubOutputPath)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "$(CrossgenOutputAssembly)");*/
    /* if (!Exists($([System.IO.Path]::Combine($(PublishDir),$(CrossgenSubOutputPath)))))*/
    if (!Exists(bin\Debug\net8.0\publish\))
    {
        Copy(DestinationFiles: "bin\\Debug\\net8.0\\publish\\\\", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    }
    /*MakeDir(Directories: "$(CrossgenProfilingSymbolsOutputDirectory)");*/
    /* if ('$(CreateProfilingSymbols)' == 'true' and Exists($(CrossgenOutputAssembly)))*/
    if ('' == 'true' and Exists())
    {
        MakeDir(Directories: "");
    }
    /*Exec(Command: "$(CrossgenExe) -nologo -readytorun -platform_assemblies_paths $(CrossgenPlatformAssembliesPath) -$(CreateProfilingSymbolsOptionName) $(CrossgenProfilingSymbolsOutputDirectory) $(CrossgenOutputAssembly)", IgnoreStandardErrorWarningFormat: "true");*/
    /* if ('$(CreateProfilingSymbols)' == 'true' and Exists($(CrossgenOutputAssembly)))*/
    if ('' == 'true' and Exists())
    {
        Exec(Command: " -nologo -readytorun -platform_assemblies_paths  -  ", IgnoreStandardErrorWarningFormat: "true");
    }
    /*Copy(RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ProfilingSymbols)", DestinationFolder: "$(CrossgenSymbolsStagingDirectory)");*/
    /* if ('$(CreateProfilingSymbols)' == 'true')*/
    if ('' == 'true')
    {
        Copy(RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "");
    }
    
    RunCrossGenRun = true;
}

void _InitializeBasicProps()
{
    
    PathSeparator = "$([System.IO.Path]::PathSeparator)";
    DirectorySeparatorChar = "$([System.IO.Path]::DirectorySeparatorChar)";
    _InitializeBasicPropsRun = true;
}

void _GetCrossgenProps()
{
    // if ($(SkipOptimization) != 'true' )
    if ( != 'true' ) { _GetCrossgenPropsRun = true; return; }
    
    _CrossProjFileDir = "$([System.IO.Path]::Combine($(ComposeWorkingDir),"Optimize"))";
    _NetCoreRefDir = "$([System.IO.Path]::Combine($(_CrossProjFileDir), "netcoreapp"))";
    _CrossProjAssetsFile = "$([System.IO.Path]::Combine($(_CrossProjFileDir),  project.assets.json))";
    /*MakeDir(Directories: "$(_CrossProjFileDir)");*/
    MakeDir(Directories: "");
    
    _GetCrossgenPropsRun = true;
}

void _SetupStageForCrossgen()
{
    // DependsOnTargets;
    if (!_GetCrossgenPropsRun) _GetCrossgenProps();
    if (!Run) ();
    
    _RuntimeRefDir = "$([System.IO.Path]::Combine($(StoreWorkerWorkingDir), "runtimeref"))";
    _RuntimeOptimizedDir = "$([System.IO.Path]::Combine($(StoreWorkerWorkingDir), "runtimopt"))";
    _RuntimeSymbolsDir = "$([System.IO.Path]::Combine($(StoreWorkerWorkingDir), "runtimesymbols"))";
    /*MakeDir(Directories: "$(_RuntimeOptimizedDir)");*/
    MakeDir(Directories: "");
    /*MakeDir(Directories: "$(_RuntimeSymbolsDir)");*/
    /* if ('$(CreateProfilingSymbols)' == 'true')*/
    if ('' == 'true')
    {
        MakeDir(Directories: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ManagedResolvedFilesToOptimize)", DestinationFolder: "$(_RuntimeRefDir)");*/
    Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "");
    
    _SetupStageForCrossgenRun = true;
}

void _RestoreCrossgen()
{
    // if ($(SkipOptimization) != 'true' )
    if ( != 'true' ) { _RestoreCrossgenRun = true; return; }
    // DependsOnTargets;
    if (!PrepforRestoreForComposeStoreRun) PrepforRestoreForComposeStore();
    if (!_SetupStageForCrossgenRun) _SetupStageForCrossgen();
    if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();
    if (!ApplyImplicitVersionsRun) ApplyImplicitVersions();
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    
    /*MSBuild(Targets: "Restore", Projects: "$(MSBuildProjectFullPath)", Properties: """RuntimeIdentifiers=$(RuntimeIdentifier);
                             RestoreGraphProjectInput=$(MSBuildProjectFullPath);
                             RestoreOutputPath=$(_CrossProjFileDir);
                             StorePackageName=$(MicrosoftNETPlatformLibrary);
                             StorePackageVersion=%(PackageReferenceForCrossGen.Version);""");*/
    MSBuild(Targets: "Restore", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """RuntimeIdentifiers=;
                             RestoreGraphProjectInput=D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;
                             RestoreOutputPath=;
                             StorePackageName=;
                             StorePackageVersion=%(PackageReferenceForCrossGen.Version);""");
    /*ResolveCopyLocalAssets(ExcludedPackageReferences: "@(_ExcludeFromPublishPackageReference)", RuntimeFrameworks: "@(RuntimeFramework)", RuntimeIdentifier: "$(RuntimeIdentifier)", TargetFramework: "$(_TFM)", IsSelfContained: "$(SelfContained)", PreserveStoreLayout: "false", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssetsFilePath: "$(_CrossProjAssetsFile)");*/
    /* if ('$(_TargetFrameworkVersionWithoutV)' < '3.0')*/
    if ('8.0' < '3.0')
    {
        ResolveCopyLocalAssets(ExcludedPackageReferences: "", RuntimeFrameworks: "", RuntimeIdentifier: "", TargetFramework: "", IsSelfContained: "false", PreserveStoreLayout: "false", PlatformLibraryName: "", AssetsFilePath: "");
    }
    /*GetPackageDirectory(Items: "@(RuntimePack)", AssetsFileWithAdditionalPackageFolders: "$(_CrossProjAssetsFile)");*/
    /* if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0')*/
    if ('8.0' >= '3.0')
    {
        GetPackageDirectory(Items: "", AssetsFileWithAdditionalPackageFolders: "");
    }
    /*ResolveRuntimePackAssets(ResolvedRuntimePacks: "@(_CrossgenRuntimePack)", FrameworkReferences: "@(FrameworkReference)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)");*/
    /* if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0')*/
    if ('8.0' >= '3.0')
    {
        ResolveRuntimePackAssets(ResolvedRuntimePacks: "", FrameworkReferences: "Microsoft.NETCore.App", DisableTransitiveFrameworkReferenceDownloads: "");
    }
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(CrossgenResolvedAssembliesToPublish)", DestinationFolder: "$(_NetCoreRefDir)");*/
    Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "");
    
    _RestoreCrossgenRun = true;
}

void CreateReadyToRunImages()
{
    // if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0' And '$(PublishReadyToRun)' == 'true' And '$(TargetFrameworkIdentifier)' == '.NETCoreApp')
    if ('8.0' >= '3.0' And '' == 'true' And '.NETCoreApp' == '.NETCoreApp') { CreateReadyToRunImagesRun = true; return; }
    // DependsOnTargets;
    if (!_PrepareForReadyToRunCompilationRun) _PrepareForReadyToRunCompilation();
    if (!_CreateR2RImagesRun) _CreateR2RImages();
    if (!_CreateR2RSymbolsRun) _CreateR2RSymbols();
    
    /*AllowEmptyTelemetry(EventData: "@(R2RTelemetry)", EventName: "ReadyToRun");*/
    AllowEmptyTelemetry(EventData: "", EventName: "ReadyToRun");
    /* if ('@(_ReadyToRunCompilationFailures)' != '')*/
    if ('' != '')
    {
        NETSdkError(ResourceName: "ReadyToRunCompilationFailed");
    }
    /* if ('$(_ReadyToRunCompilerHasWarnings)' != '')*/
    if ('' != '')
    {
        NETSdkInformation(ResourceName: "ReadyToRunCompilationHasWarnings_Info");
    }
    
    CreateReadyToRunImagesRun = true;
}

void _PrepareForReadyToRunCompilation()
{
    // DependsOnTargets;
    if (!ResolveReadyToRunCompilersRun) ResolveReadyToRunCompilers();
    if (!_ComputeManagedRuntimePackAssembliesRun) _ComputeManagedRuntimePackAssemblies();
    if (!_ComputeAssembliesToPostprocessOnPublishRun) _ComputeAssembliesToPostprocessOnPublish();
    
    _ReadyToRunOutputPath = "$(IntermediateOutputPath)R2R";
    /*MakeDir(Directories: "$(_ReadyToRunOutputPath)");*/
    MakeDir(Directories: "");
    /*ResolvePackageFileConflicts(ReferenceCopyLocalPaths: "@(_ReadyToRunImplementationAssemblies)");*/
    /* if ('$(SelfContained)' != 'true')*/
    if ('false' != 'true')
    {
        ResolvePackageFileConflicts(ReferenceCopyLocalPaths: "");
    }
    /*PrepareForReadyToRunCompilation(Crossgen2Tool: "@(Crossgen2Tool)", Crossgen2Composite: "$(PublishReadyToRunComposite)", OutputPath: "$(_ReadyToRunOutputPath)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", MainAssembly: "@(IntermediateAssembly)", PublishReadyToRunCompositeExclusions: "@(PublishReadyToRunCompositeExclusions)", EmitSymbols: "$(PublishReadyToRunEmitSymbols)", ExcludeList: "@(PublishReadyToRunExclude)", Assemblies: "@(_ReadyToRunImplementationAssemblies)", CrossgenTool: "@(CrossgenTool)", IncludeSymbolsInSingleFile: "$(IncludeSymbolsInSingleFile)");*/
    PrepareForReadyToRunCompilation(Crossgen2Tool: "", Crossgen2Composite: "false", OutputPath: "", ReadyToRunUseCrossgen2: "true", MainAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", PublishReadyToRunCompositeExclusions: "", EmitSymbols: "", ExcludeList: "", Assemblies: "", CrossgenTool: "", IncludeSymbolsInSingleFile: "false");
    
    _PrepareForReadyToRunCompilationRun = true;
}

void ResolveReadyToRunCompilers()
{
    
    /*ResolveReadyToRunCompilers(NETCoreSdkRuntimeIdentifier: "$(NETCoreSdkRuntimeIdentifier)", PerfmapFormatVersion: "$(PublishReadyToRunPerfmapFormatVersion)", TargetingPacks: "@(ResolvedTargetingPack)", RuntimePacks: "@(ResolvedRuntimePack)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", Crossgen2Packs: "@(ResolvedCrossgen2Pack)", EmitSymbols: "$(PublishReadyToRunEmitSymbols)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)");*/
    ResolveReadyToRunCompilers(NETCoreSdkRuntimeIdentifier: "win-x64", PerfmapFormatVersion: "1", TargetingPacks: "", RuntimePacks: "", ReadyToRunUseCrossgen2: "true", Crossgen2Packs: "", EmitSymbols: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json");
    
    ResolveReadyToRunCompilersRun = true;
}

void _CreateR2RImages()
{
    
    /* if ('$(_ReadyToRunWarningsDetected)' == 'true')*/
    if ('' == 'true')
    {
        _ReadyToRunCompilerHasWarnings = "true";
    }
    /*RunReadyToRunCompiler(Crossgen2Tool: "@(Crossgen2Tool)", ImplementationAssemblyReferences: "@(_ReadyToRunAssembliesToReference)", Crossgen2PgoFiles: "@(_ReadyToRunPgoFiles)", Crossgen2ExtraCommandLineArgs: "$(PublishReadyToRunCrossgen2ExtraArgs)", UseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", ReadyToRunCompositeBuildInput: "@(_ReadyToRunCompositeBuildInput)", ReadyToRunCompositeBuildReferences: "@(_ReadyToRunCompositeBuildReferences)", CompilationEntry: "@(_ReadyToRunCompileList)", CrossgenTool: "@(CrossgenTool)", ShowCompilerWarnings: "$(PublishReadyToRunShowWarnings)");*/
    RunReadyToRunCompiler(Crossgen2Tool: "", ImplementationAssemblyReferences: "", Crossgen2PgoFiles: "", Crossgen2ExtraCommandLineArgs: "", UseCrossgen2: "true", ReadyToRunCompositeBuildInput: "", ReadyToRunCompositeBuildReferences: "", CompilationEntry: "", CrossgenTool: "", ShowCompilerWarnings: "");
    
    _CreateR2RImagesRun = true;
}

void _CreateR2RSymbols()
{
    // if ('$(PublishReadyToRunUseCrossgen2)' != 'true' or '@(Crossgen2Tool -> '%(IsVersion5)')' == 'true')
    if ('true' != 'true' or '' == 'true') { _CreateR2RSymbolsRun = true; return; }
    
    /* if ('$(_ReadyToRunWarningsDetected)' == 'true')*/
    if ('' == 'true')
    {
        _ReadyToRunCompilerHasWarnings = "true";
    }
    /*RunReadyToRunCompiler(Crossgen2Tool: "@(Crossgen2Tool)", ImplementationAssemblyReferences: "@(_ReadyToRunAssembliesToReference)", Crossgen2ExtraCommandLineArgs: "$(PublishReadyToRunCrossgen2ExtraArgs)", UseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", CompilationEntry: "@(_ReadyToRunSymbolsCompileList)", CrossgenTool: "@(CrossgenTool)", ShowCompilerWarnings: "$(PublishReadyToRunShowWarnings)");*/
    RunReadyToRunCompiler(Crossgen2Tool: "", ImplementationAssemblyReferences: "", Crossgen2ExtraCommandLineArgs: "", UseCrossgen2: "true", CompilationEntry: "", CrossgenTool: "", ShowCompilerWarnings: "");
    
    _CreateR2RSymbolsRun = true;
}

void _CheckForObsoleteDotNetCliToolReferences()
{
    // if ( '$(SuppressObsoleteDotNetCliToolWarning)' != 'true' )
    if ( '' != 'true' ) { _CheckForObsoleteDotNetCliToolReferencesRun = true; return; }
    
    /* if ( '%(_ReferenceToObsoleteDotNetCliTool.Identity)' != '' )*/
    if ( '%(_ReferenceToObsoleteDotNetCliTool.Identity)' != '' )
    {
        NETSdkWarning(ResourceName: "ProjectContainsObsoleteDotNetCliTool", FormatArguments: "%(_ReferenceToObsoleteDotNetCliTool.Identity)");
    }
    
    _CheckForObsoleteDotNetCliToolReferencesRun = true;
}

void _ComputeToolPackInputsToProcessFrameworkReferences()
{
    
    /* if ('$(_RequiresILLinkPack)' == '' And (
          '$(PublishAot)' == 'true' Or
          '$(IsAotCompatible)' == 'true' Or '$(EnableAotAnalyzer)' == 'true' Or
          '$(PublishTrimmed)' == 'true' Or
          '$(IsTrimmable)' == 'true' Or '$(EnableTrimAnalyzer)' == 'true' Or
          '$(EnableSingleFileAnalyzer)' == 'true'))*/
    if ('' == '' And (
          '' == 'true' Or
          '' == 'true' Or '' == 'true' Or
          '' == 'true' Or
          '' == 'true' Or '' == 'true' Or
          '' == 'true'))
    {
        _RequiresILLinkPack = "true";
    }
    /* if ('$(_RequiresILLinkPack)' == '')*/
    if ('' == '')
    {
        _RequiresILLinkPack = "false";
    }
    _FirstTargetFrameworkToSupportTrimming = "net6.0";
    _FirstTargetFrameworkToSupportAot = "net7.0";
    _FirstTargetFrameworkToSupportSingleFile = "net6.0";
    _MinNonEolTargetFrameworkForTrimming = "$(_MinimumNonEolSupportedNetCoreTargetFramework)";
    _MinNonEolTargetFrameworkForSingleFile = "$(_MinimumNonEolSupportedNetCoreTargetFramework)";
    _MinNonEolTargetFrameworkForAot = "$(_MinimumNonEolSupportedNetCoreTargetFramework)";
    /* if ($([MSBuild]::IsTargetFrameworkCompatible('$(_FirstTargetFrameworkToSupportAot)', '$(_MinimumNonEolSupportedNetCoreTargetFramework)')))*/
    if (False)
    {
        _MinNonEolTargetFrameworkForAot = "$(_FirstTargetFrameworkToSupportAot)";
    }
    /* if ('$(_SilenceIsTrimmableUnsupportedWarning)' == '' And
                                                        @(_TargetFrameworkToSilenceIsTrimmableUnsupportedWarning->Count()) > 0)*/
    if ('' == '' And
                                                        0 > 0)
    {
        _SilenceIsTrimmableUnsupportedWarning = "true";
    }
    /* if ('$(_SilenceIsAotCompatibleUnsupportedWarning)' == '' And 
                                                            @(_TargetFrameworkToSilenceIsAotCompatibleUnsupportedWarning->Count()) > 0)*/
    if ('' == '' And 
                                                            0 > 0)
    {
        _SilenceIsAotCompatibleUnsupportedWarning = "true";
    }
    /* if ('$(_SilenceEnableSingleFileAnalyzerUnsupportedWarning)' == '' And
                                                          @(_TargetFrameworkToSilenceEnableSingleFileAnalyzerUnsupportedWarning->Count()) > 0)*/
    if ('' == '' And
                                                          0 > 0)
    {
        _SilenceEnableSingleFileAnalyzerUnsupportedWarning = "true";
    }
    _ComputeToolPackInputsToProcessFrameworkReferencesRun = true;
}

void _PublishBuildAlternative()
{
    // if ('$(NoBuild)' != 'true')
    if ('' != 'true') { _PublishBuildAlternativeRun = true; return; }
    // DependsOnTargets;
    if (!BuildRun) Build();
    if (!PrepareForPublishRun) PrepareForPublish();
    if (!ComputeAndCopyFilesToPublishDirectoryRun) ComputeAndCopyFilesToPublishDirectory();
    if (!Run) ();
    if (!PublishItemsOutputGroupRun) PublishItemsOutputGroup();
    if (!Run) ();
    
    _PublishBuildAlternativeRun = true;
}

void _PublishNoBuildAlternative()
{
    // if ('$(NoBuild)' == 'true')
    if ('' == 'true') { _PublishNoBuildAlternativeRun = true; return; }
    // DependsOnTargets;
    if (!BuildOnlySettingsRun) BuildOnlySettings();
    if (!_PreventProjectReferencesFromBuildingRun) _PreventProjectReferencesFromBuilding();
    if (!ResolveReferencesRun) ResolveReferences();
    if (!PrepareResourceNamesRun) PrepareResourceNames();
    if (!ComputeIntermediateSatelliteAssembliesRun) ComputeIntermediateSatelliteAssemblies();
    if (!ComputeEmbeddedApphostPathsRun) ComputeEmbeddedApphostPaths();
    if (!Run) ();
    if (!PrepareForPublishRun) PrepareForPublish();
    if (!ComputeAndCopyFilesToPublishDirectoryRun) ComputeAndCopyFilesToPublishDirectory();
    if (!Run) ();
    if (!PublishItemsOutputGroupRun) PublishItemsOutputGroup();
    if (!Run) ();
    
    _PublishNoBuildAlternativeRun = true;
}

void _PreventProjectReferencesFromBuilding()
{
    
    BuildProjectReferences = "false";
    _PreventProjectReferencesFromBuildingRun = true;
}

void PrepareForPublish()
{
    // BeforeTargets;
    if (!_CheckForLanguageAndPublishFeatureCombinationSupportRun) _CheckForLanguageAndPublishFeatureCombinationSupport();
    
    /* if (!HasTrailingSlash('$(PublishDir)'))*/
    if (!HasTrailingSlash('bin\Debug\net8.0\publish\'))
    {
        PublishDir = "$(PublishDir)\\";
    }
    /* if ('$(PublishSingleFile)' == 'true' And '$(_IsExecutable)' != 'true')*/
    if ('' == 'true' And 'true' != 'true')
    {
        NETSdkError(ResourceName: "CannotHaveSingleFileWithoutExecutable");
    }
    /* if ('$(PublishSingleFile)' == 'true' And '$(_IsExecutable)' == 'true' And '$(TargetFrameworkIdentifier)' != '.NETCoreApp')*/
    if ('' == 'true' And 'true' == 'true' And '.NETCoreApp' != '.NETCoreApp')
    {
        NETSdkError(ResourceName: "CanOnlyHaveSingleFileWithNetCoreApp");
    }
    /* if ('$(PublishSingleFile)' == 'true' And
                            '$(IncludeSymbolsInSingleFile)' == 'true' And
                            '$(_TargetFrameworkVersionWithoutV)' >= '5.0' And '$(TargetFrameworkIdentifier)' == '.NETCoreApp')*/
    if ('' == 'true' And
                            'false' == 'true' And
                            '8.0' >= '5.0' And '.NETCoreApp' == '.NETCoreApp')
    {
        NETSdkError(ResourceName: "CannotIncludeSymbolsInSingleFile");
    }
    /* if ('$(PublishSingleFile)' == 'true' and '$(RuntimeIdentifier)' == '')*/
    if ('' == 'true' and '' == '')
    {
        NETSdkError(ResourceName: "CannotHaveSingleFileWithoutRuntimeIdentifier");
    }
    /* if ('$(PublishSingleFile)' == 'true' and '$(UseAppHost)' != 'true')*/
    if ('' == 'true' and 'true' != 'true')
    {
        NETSdkError(ResourceName: "CannotHaveSingleFileWithoutAppHost");
    }
    /* if ('$(PublishSingleFile)' == 'true' And
                            '$(EnableCompressionInSingleFile)' == 'true' And
                            '$(_TargetFrameworkVersionWithoutV)' < '6.0')*/
    if ('' == 'true' And
                            '' == 'true' And
                            '8.0' < '6.0')
    {
        NETSdkError(ResourceName: "CompressionInSingleFileRequires60");
    }
    /* if ('$(PublishSingleFile)' == 'true' And
                            '$(EnableCompressionInSingleFile)' == 'true' And
                            '$(SelfContained)' != 'true')*/
    if ('' == 'true' And
                            '' == 'true' And
                            'false' != 'true')
    {
        NETSdkError(ResourceName: "CompressionInSingleFileRequiresSelfContained");
    }
    /*NETSdkWarning(ResourceName: "PublishProfileNotPresent", FormatArguments: "$(PublishProfile)");*/
    /* if ('$(PublishProfileImported)' != 'true' and '$(PublishProfile)' != '')*/
    if ('false' != 'true' and '' != '')
    {
        NETSdkWarning(ResourceName: "PublishProfileNotPresent", FormatArguments: "");
    }
    /*NETSdkError(ResourceName: "SolutionProjectConfigurationsConflict", FormatArguments: "PublishRelease;$(ProjectName)");*/
    /* if ('$(_IsPublishing)' == 'true' and
                            '$(DOTNET_CLI_DISABLE_PUBLISH_AND_PACK_RELEASE)' != 'true' and
                            '$(DOTNET_CLI_LAZY_PUBLISH_AND_PACK_RELEASE_FOR_SOLUTIONS)' == 'true' and
                            '$(SolutionExt)' == '.sln' and
                            '$(_SolutionLevelPublishRelease)' != '$(PublishRelease)')*/
    if ('' == 'true' and
                            '' != 'true' and
                            '' == 'true' and
                            '*Undefined*' == '.sln' and
                            '' != 'true')
    {
        NETSdkError(ResourceName: "SolutionProjectConfigurationsConflict", FormatArguments: "PublishRelease;6 - targets");
    }
    /*MakeDir(Directories: "$(PublishDir)");*/
    MakeDir(Directories: "bin\\Debug\\net8.0\\publish\\");
    
    PrepareForPublishRun = true;
}

void ComputeAndCopyFilesToPublishDirectory()
{
    // DependsOnTargets;
    if (!ComputeFilesToPublishRun) ComputeFilesToPublish();
    if (!CopyFilesToPublishDirectoryRun) CopyFilesToPublishDirectory();
    
    ComputeAndCopyFilesToPublishDirectoryRun = true;
}

void CopyFilesToPublishDirectory()
{
    // DependsOnTargets;
    if (!_IncrementalCleanPublishDirectoryRun) _IncrementalCleanPublishDirectory();
    if (!_CopyResolvedFilesToPublishPreserveNewestRun) _CopyResolvedFilesToPublishPreserveNewest();
    if (!_CopyResolvedFilesToPublishAlwaysRun) _CopyResolvedFilesToPublishAlways();
    if (!_HandleFileConflictsForPublishRun) _HandleFileConflictsForPublish();
    
    CopyFilesToPublishDirectoryRun = true;
}

void _IncrementalCleanPublishDirectory()
{
    // DependsOnTargets;
    if (!_GetCurrentAndPriorPublishFileWritesRun) _GetCurrentAndPriorPublishFileWrites();
    
    /*Delete(TreatErrorsAsWarnings: "true", Files: "@(_OrphanPublishFileWrites)");*/
    Delete(TreatErrorsAsWarnings: "true", Files: "");
    /*WriteLinesToFile(File: "$(IntermediateOutputPath)$(_PublishCleanFile)", Overwrite: "true", Lines: "@(_CurrentPublishFileWrites)");*/
    WriteLinesToFile(File: "obj\\Debug\\net8.0\\", Overwrite: "true", Lines: "");
    
    _IncrementalCleanPublishDirectoryRun = true;
}

void _GetCurrentAndPriorPublishFileWrites()
{
    
    _NormalizedPublishDir = "$([MSBuild]::NormalizeDirectory($(PublishDir)))";
    /* if ('$(PublishCleanFile)'=='')*/
    if (''=='')
    {
        _PublishCleanFile = "PublishOutputs.$(_NormalizedPublishDirHash.Substring(0, 10)).txt";
    }
    /*Hash(ItemstoHash: "$(_NormalizedPublishDir)");*/
    Hash(ItemstoHash: "");
    /*ReadLinesFromFile(File: "$(IntermediateOutputPath)$(_PublishCleanFile)");*/
    ReadLinesFromFile(File: "obj\\Debug\\net8.0\\");
    /*ConvertToAbsolutePath(Paths: "@(_UnfilteredPriorPublishFileWrites)");*/
    ConvertToAbsolutePath(Paths: "");
    /*FindUnderPath(UpdateToAbsolutePaths: "true", Files: "@(_UnfilteredAbsolutePriorPublishFileWrites)", Path: "$(_NormalizedPublishDir)");*/
    FindUnderPath(UpdateToAbsolutePaths: "true", Files: "", Path: "");
    /*RemoveDuplicates(Inputs: "@(_PriorPublishFileWritesInOuput)");*/
    RemoveDuplicates(Inputs: "");
    /*ConvertToAbsolutePath(Paths: "@(_CurrentPublishFileWritesUnfiltered)");*/
    ConvertToAbsolutePath(Paths: "");
    /*RemoveDuplicates(Inputs: "@(_CurrentAbsolutePublishFileWritesUnfiltered)");*/
    RemoveDuplicates(Inputs: "");
    
    _GetCurrentAndPriorPublishFileWritesRun = true;
}

void _CopyResolvedFilesToPublishPreserveNewest()
{
    // DependsOnTargets;
    if (!_ComputeResolvedFilesToPublishTypesRun) _ComputeResolvedFilesToPublishTypes();
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: "@(_ResolvedFileToPublishPreserveNewest->'$(PublishDir)%(RelativePath)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ResolvedFileToPublishPreserveNewest)");*/
    Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyResolvedFilesToPublishPreserveNewestRun = true;
}

void _CopyResolvedFilesToPublishAlways()
{
    // DependsOnTargets;
    if (!_ComputeResolvedFilesToPublishTypesRun) _ComputeResolvedFilesToPublishTypes();
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", DestinationFiles: "@(_ResolvedFileToPublishAlways->'$(PublishDir)%(RelativePath)')", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ResolvedFileToPublishAlways)");*/
    Copy(UseHardlinksIfPossible: "", DestinationFiles: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "");
    
    _CopyResolvedFilesToPublishAlwaysRun = true;
}

void _ComputeResolvedFilesToPublishTypes()
{
    
    _ComputeResolvedFilesToPublishTypesRun = true;
}

void ComputeFilesToPublish()
{
    // DependsOnTargets;
    if (!PrepareForPublishRun) PrepareForPublish();
    if (!ComputeResolvedFilesToPublishListRun) ComputeResolvedFilesToPublishList();
    if (!ILLinkRun) ILLink();
    if (!CreateReadyToRunImagesRun) CreateReadyToRunImages();
    if (!GeneratePublishDependencyFileRun) GeneratePublishDependencyFile();
    if (!GenerateSingleFileBundleRun) GenerateSingleFileBundle();
    
    // AfterTargets;
    if (!_HandleFileConflictsForPublishRun) _HandleFileConflictsForPublish();
    ComputeFilesToPublishRun = true;
}

void ILLink()
{
    
    ILLinkRun = true;
}

void ComputeResolvedFilesToPublishList()
{
    // DependsOnTargets;
    if (!_ComputeResolvedCopyLocalPublishAssetsRun) _ComputeResolvedCopyLocalPublishAssets();
    if (!_ComputeCopyToPublishDirectoryItemsRun) _ComputeCopyToPublishDirectoryItems();
    if (!ComputeRefAssembliesToPublishRun) ComputeRefAssembliesToPublish();
    
    /*ResolveOverlappingItemGroupConflicts(PreferredPackages: "$(PackageConflictPreferredPackages)", ItemGroup1: "@(_ResolvedCopyLocalPublishAssets->Distinct())", ItemGroup2: "@(ResolvedFileToPublish->Distinct())");*/
    ResolveOverlappingItemGroupConflicts(PreferredPackages: "", ItemGroup1: "", ItemGroup2: "");
    
    ComputeResolvedFilesToPublishListRun = true;
}

void _ResolveCopyLocalAssetsForPublish()
{
    // DependsOnTargets;
    if (!ResolveLockFileCopyLocalFilesRun) ResolveLockFileCopyLocalFiles();
    if (!_ComputeUseBuildDependencyFileRun) _ComputeUseBuildDependencyFile();
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    if (!ResolveRuntimePackAssetsRun) ResolveRuntimePackAssets();
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    
    /*ResolveCopyLocalAssets(ExcludedPackageReferences: "@(_ExcludeFromPublishPackageReference)", RuntimeFrameworks: "@(RuntimeFramework)", ResolveRuntimeTargets: "$(CopyLocalRuntimeTargetAssets)", RuntimeStorePackages: "@(RuntimeStorePackages)", RuntimeIdentifier: "$(RuntimeIdentifier)", TargetFramework: "$(TargetFramework)", IsSelfContained: "$(SelfContained)", PreserveStoreLayout: "$(PreserveStoreLayout)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssetsFilePath: "$(ProjectAssetsFile)");*/
    /* if ('$(PreserveStoreLayout)' == 'true' Or '@(RuntimeStorePackages)' != '')*/
    if ('' == 'true' Or '' != '')
    {
        ResolveCopyLocalAssets(ExcludedPackageReferences: "", RuntimeFrameworks: "", ResolveRuntimeTargets: "", RuntimeStorePackages: "", RuntimeIdentifier: "", TargetFramework: "net8.0", IsSelfContained: "false", PreserveStoreLayout: "", PlatformLibraryName: "", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json");
    }
    
    // AfterTargets;
    if (!_HandlePackageFileConflictsForPublishRun) _HandlePackageFileConflictsForPublish();
    _ResolveCopyLocalAssetsForPublishRun = true;
}

void _ParseTargetManifestFiles()
{
    // if ('$(TargetManifestFiles)' != '')
    if ('' != '') { _ParseTargetManifestFilesRun = true; return; }
    
    /*ParseTargetManifests(TargetManifestFiles: "$(TargetManifestFiles)");*/
    ParseTargetManifests(TargetManifestFiles: "");
    
    _ParseTargetManifestFilesRun = true;
}

void _FilterSatelliteResourcesForPublish()
{
    // if ('$(SatelliteResourceLanguages)' != '')
    if ('' != '') { _FilterSatelliteResourcesForPublishRun = true; return; }
    
    /*JoinItems(Right: "$(SatelliteResourceLanguages)", LeftKey: "Culture", RightMetadata: "", RightKey: "", Left: "@(_PublishSatelliteResources)", ItemSpecToUse: "Left", LeftMetadata: "*");*/
    JoinItems(Right: "", LeftKey: "Culture", RightMetadata: "", RightKey: "", Left: "", ItemSpecToUse: "Left", LeftMetadata: "*");
    
    // AfterTargets;
    if (!_HandlePackageFileConflictsForPublishRun) _HandlePackageFileConflictsForPublish();
    _FilterSatelliteResourcesForPublishRun = true;
}

void _ComputeResolvedCopyLocalPublishAssets()
{
    // DependsOnTargets;
    if (!_ResolveCopyLocalAssetsForPublishRun) _ResolveCopyLocalAssetsForPublish();
    if (!_FilterSatelliteResourcesForPublishRun) _FilterSatelliteResourcesForPublish();
    
    _ComputeResolvedCopyLocalPublishAssetsRun = true;
}

void _ComputeCopyToPublishDirectoryItems()
{
    // DependsOnTargets;
    if (!GetCopyToPublishDirectoryItemsRun) GetCopyToPublishDirectoryItems();
    
    _ComputeCopyToPublishDirectoryItemsRun = true;
}

void DefaultCopyToPublishDirectoryMetadata()
{
    // if ( '$(DefaultCopyToPublishDirectoryMetadata)' == 'true' )
    if ( 'true' == 'true' ) { DefaultCopyToPublishDirectoryMetadataRun = true; return; }
    // DependsOnTargets;
    if (!AssignTargetPathsRun) AssignTargetPaths();
    
    DefaultCopyToPublishDirectoryMetadataRun = true;
}

void _ComputeAssembliesToPostprocessOnPublish()
{
    // DependsOnTargets;
    if (!_ComputeUserRuntimeAssembliesRun) _ComputeUserRuntimeAssemblies();
    if (!Run) ();
    
    /*JoinItems(Right: "@(ResolvedFileToPublish)", RightMetadata: "*", Left: "@(_ManagedRuntimeAssembly)");*/
    JoinItems(Right: "", RightMetadata: "*", Left: "");
    
    _ComputeAssembliesToPostprocessOnPublishRun = true;
}

void _ComputeManagedRuntimePackAssemblies()
{
    
    _ComputeManagedRuntimePackAssembliesRun = true;
}

void _ComputeUseBuildDependencyFile()
{
    // DependsOnTargets;
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    if (!_ParseTargetManifestFilesRun) _ParseTargetManifestFiles();
    
    /* if ('$(PublishSingleFile)' == 'true' and '$(SelfContained)' == 'true')*/
    if ('' == 'true' and 'false' == 'true')
    {
        _TrimRuntimeAssets = "true";
    }
    /* if ('@(_ExcludeFromPublishPackageReference)' == '' and
                                          '@(RuntimeStorePackages)' == '' and
                                          '$(PreserveStoreLayout)' != 'true' and
                                          '$(PublishTrimmed)' != 'true' and
                                          '$(_TrimRuntimeAssets)' != 'true')*/
    if ('' == '' and
                                          '' == '' and
                                          '' != 'true' and
                                          '' != 'true' and
                                          '' != 'true')
    {
        _UseBuildDependencyFile = "true";
    }
    _ComputeUseBuildDependencyFileRun = true;
}

void _ComputeFilesToBundle()
{
    // if ('$(PublishSingleFile)' == 'true')
    if ('' == 'true') { _ComputeFilesToBundleRun = true; return; }
    // DependsOnTargets;
    if (!_HandleFileConflictsForPublishRun) _HandleFileConflictsForPublish();
    
    PublishedSingleFileName = "$(AssemblyName)$(_NativeExecutableExtension)";
    PublishedSingleFilePath = "$(PublishDir)$(PublishedSingleFileName)";
    _ComputeFilesToBundleRun = true;
}

void PrepareForBundle()
{
    // if ('$(PublishSingleFile)' == 'true')
    if ('' == 'true') { PrepareForBundleRun = true; return; }
    // DependsOnTargets;
    if (!_ComputeFilesToBundleRun) _ComputeFilesToBundle();
    
    AppHostFile = "$(PublishedSingleFileName)";
    PrepareForBundleRun = true;
}

void _GenerateSingleFileBundleInputCache()
{
    
    /*Hash(ItemsToHash: "@(_GenerateSingleFileBundlePropertyInputsCacheToHash)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(_GenerateSingleFileBundlePropertyInputsCache)", Overwrite: "true", Lines: "$(_GenerateSingleFileBundlePropertyInputsCacheHash)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genbundle.cache", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    _GenerateSingleFileBundleInputCacheRun = true;
}

void GenerateSingleFileBundle()
{
    // if ('$(PublishSingleFile)' == 'true')
    if ('' == 'true') { GenerateSingleFileBundleRun = true; return; }
    // DependsOnTargets;
    if (!_ComputeFilesToBundleRun) _ComputeFilesToBundle();
    if (!PrepareForBundleRun) PrepareForBundle();
    if (!_GenerateSingleFileBundleInputCacheRun) _GenerateSingleFileBundleInputCache();
    
    /* if ('$(TraceSingleFileBundler)' == '')*/
    if ('' == '')
    {
        TraceSingleFileBundler = "false";
    }
    /* if ('$(IncludeSymbolsInSingleFile)' == '')*/
    if ('false' == '')
    {
        IncludeSymbolsInSingleFile = "false";
    }
    /* if ('$(IncludeAllContentForSelfExtract)' == '')*/
    if ('' == '')
    {
        IncludeAllContentForSelfExtract = "false";
    }
    /* if ('$(IncludeNativeLibrariesForSelfExtract)' == '')*/
    if ('' == '')
    {
        IncludeNativeLibrariesForSelfExtract = "$(IncludeAllContentForSelfExtract)";
    }
    /* if ('$(EnableCompressionInSingleFile)' == '')*/
    if ('' == '')
    {
        EnableCompressionInSingleFile = "false";
    }
    /* if ('$(IncludeAllContentForSelfExtract)' == 'true' And '$(IncludeNativeLibrariesForSelfExtract)' != 'true')*/
    if ('' == 'true' And '' != 'true')
    {
        NETSdkError(ResourceName: "CannotIncludeAllContentButNotNativeLibrariesInSingleFile");
    }
    /*GenerateBundle(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", ShowDiagnosticOutput: "$(TraceSingleFileBundler)", RuntimeIdentifier: "$(RuntimeIdentifier)", OutputDir: "$(PublishDir)", IncludeSymbols: "$(IncludeSymbolsInSingleFile)", IncludeNativeLibraries: "$(IncludeNativeLibrariesForSelfExtract)", IncludeAllContent: "$(IncludeAllContentForSelfExtract)", FilesToBundle: "@(FilesToBundle)", EnableCompressionInSingleFile: "$(EnableCompressionInSingleFile)", AppHostName: "$(PublishedSingleFileName)");*/
    GenerateBundle(TargetFrameworkVersion: "8.0", ShowDiagnosticOutput: "", RuntimeIdentifier: "", OutputDir: "bin\\Debug\\net8.0\\publish\\", IncludeSymbols: "false", IncludeNativeLibraries: "", IncludeAllContent: "", FilesToBundle: "", EnableCompressionInSingleFile: "", AppHostName: "");
    
    GenerateSingleFileBundleRun = true;
}

void _ComputeIntermediateDepsFilePath()
{
    
    /* if ( '$(PublishDepsFilePath)' != '')*/
    if ( '' != '')
    {
        IntermediateDepsFilePath = "$(PublishDepsFilePath)";
    }
    /* if ( '$(PublishDepsFilePath)' == '')*/
    if ( '' == '')
    {
        IntermediateDepsFilePath = "$(IntermediateOutputPath)$(ProjectDepsFileName)";
    }
    _ComputeIntermediateDepsFilePathRun = true;
}

void _GeneratePublishDependencyFileInputCache()
{
    // DependsOnTargets;
    if (!_ComputeIntermediateDepsFilePathRun) _ComputeIntermediateDepsFilePath();
    
    /*Hash(ItemsToHash: "@(_GeneratePublishDependencyFilePropertyInputsCacheToHash)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(_GeneratePublishDependencyFilePropertyInputsCache)", Overwrite: "True", Lines: "$(_GeneratePublishDependencyFilePropertyInputsCacheHash)", WriteOnlyWhenDifferent: "True");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genpublishdeps.cache", Overwrite: "True", Lines: "", WriteOnlyWhenDifferent: "True");
    
    _GeneratePublishDependencyFileInputCacheRun = true;
}

void GeneratePublishDependencyFile()
{
    // if ('$(GenerateDependencyFile)' == 'true' and '$(_UseBuildDependencyFile)' != 'true' and '$(PublishAot)' != 'true')
    if ('true' == 'true' and '' != 'true' and '' != 'true') { GeneratePublishDependencyFileRun = true; return; }
    // DependsOnTargets;
    if (!_ComputeUseBuildDependencyFileRun) _ComputeUseBuildDependencyFile();
    if (!_ComputeIntermediateDepsFilePathRun) _ComputeIntermediateDepsFilePath();
    if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();
    if (!_HandlePackageFileConflictsRun) _HandlePackageFileConflicts();
    if (!_HandlePackageFileConflictsForPublishRun) _HandlePackageFileConflictsForPublish();
    if (!_ComputeReferenceAssembliesRun) _ComputeReferenceAssemblies();
    if (!_ComputeUserRuntimeAssembliesRun) _ComputeUserRuntimeAssemblies();
    if (!ResolveRuntimePackAssetsRun) ResolveRuntimePackAssets();
    if (!_ComputePackageReferencePublishRun) _ComputePackageReferencePublish();
    if (!_GeneratePublishDependencyFileInputCacheRun) _GeneratePublishDependencyFileInputCache();
    // BeforeTargets;
    if (!ComputeDependencyFileCompilerOptionsRun) ComputeDependencyFileCompilerOptions();
    
    /* if ( '$(PublishDepsFilePath)' == '' And '$(PublishSingleFile)' != 'true')*/
    if ( '' == '' And '' != 'true')
    {
        PublishDepsFilePath = "$(PublishDir)$(ProjectDepsFileName)";
    }
    /* if ('$(PublishSingleFile)' == '')*/
    if ('' == '')
    {
        _IsSingleFilePublish = "false";
    }
    /* if ('$(PublishSingleFile)' != '')*/
    if ('' != '')
    {
        _IsSingleFilePublish = "$(PublishSingleFile)";
    }
    /*GenerateDepsFile(CompileReferences: "@(ResolvedCompileFileDefinitions)", CompilerOptions: "@(DependencyFileCompilerOptions)", IsSingleFile: "$(_IsSingleFilePublish)", RuntimeFrameworks: "@(RuntimeFramework)", DepsFilePath: "$(IntermediateDepsFilePath)", RuntimeStorePackages: "@(RuntimeStorePackages)", AssemblyExtension: "$(TargetExt)", RuntimeIdentifier: "$(RuntimeIdentifier)", ReferencePaths: "@(ReferencePath)", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", ReferenceSatellitePaths: "@(ReferenceSatellitePaths)", TargetFramework: "$(TargetFramework)", AssemblySatelliteAssemblies: "@(IntermediateSatelliteAssembliesWithTargetPath)", ResolvedNuGetFiles: "@(_ResolvedNuGetFilesForPublish)", IsSelfContained: "$(SelfContained)", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", ReferenceAssemblies: "@(_ReferenceAssemblies)", AssemblyName: "$(AssemblyName)", UserRuntimeAssemblies: "@(UserRuntimeAssembly)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssetsFilePath: "$(ProjectAssetsFile)", IncludeMainProject: "$(IncludeMainProjectInDepsFile)", RuntimePackAssets: "@(RuntimePackAsset)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", AssemblyVersion: "$(Version)", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", ProjectPath: "$(MSBuildProjectFullPath)", ReferenceDependencyPaths: "@(ReferenceDependencyPaths)");*/
    GenerateDepsFile(CompileReferences: "", CompilerOptions: "", IsSingleFile: "", RuntimeFrameworks: "", DepsFilePath: "", RuntimeStorePackages: "", AssemblyExtension: ".dll", RuntimeIdentifier: "", ReferencePaths: "", IncludeProjectsNotInAssetsFile: "true", ReferenceSatellitePaths: "", TargetFramework: "net8.0", AssemblySatelliteAssemblies: "", ResolvedNuGetFiles: "", IsSelfContained: "false", IncludeRuntimeFileVersions: "true", ReferenceAssemblies: "", AssemblyName: "6 - targets", UserRuntimeAssemblies: "", PlatformLibraryName: "", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", IncludeMainProject: "true", RuntimePackAssets: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", AssemblyVersion: "1.0.0", ResolvedRuntimeTargetsFiles: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ReferenceDependencyPaths: "");
    
    GeneratePublishDependencyFileRun = true;
}

void ComputeEmbeddedApphostPaths()
{
    
    /*GetEmbeddedApphostPaths(ToolCommandName: "$(ToolCommandName)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(TargetFramework)", ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)");*/
    GetEmbeddedApphostPaths(ToolCommandName: "6 - targets", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/net8.0", ShimRuntimeIdentifiers: "");
    
    ComputeEmbeddedApphostPathsRun = true;
}

void ComputeFilesCopiedToPublishDir()
{
    // DependsOnTargets;
    if (!ComputeResolvedFilesToPublishListRun) ComputeResolvedFilesToPublishList();
    if (!_ComputeFilesToBundleRun) _ComputeFilesToBundle();
    
    ComputeFilesCopiedToPublishDirRun = true;
}

void PublishItemsOutputGroup()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!ResolveReferencesRun) ResolveReferences();
    if (!ComputeResolvedFilesToPublishListRun) ComputeResolvedFilesToPublishList();
    if (!_ComputeFilesToBundleRun) _ComputeFilesToBundle();
    if (!Run) ();
    
    /*GetPublishItemsOutputGroupOutputs(PublishDir: "$(PublishDir)", ResolvedFileToPublish: "@(ResolvedFileToPublish)");*/
    GetPublishItemsOutputGroupOutputs(PublishDir: "bin\\Debug\\net8.0\\publish\\", ResolvedFileToPublish: "");
    
    PublishItemsOutputGroupRun = true;
}

void RunResolvePublishAssemblies()
{
    
    RunResolvePublishAssembliesRun = true;
}

void _CheckForLanguageAndPublishFeatureCombinationSupport()
{
    // if ($(IsPublishable) == 'true')
    if (true == 'true') { _CheckForLanguageAndPublishFeatureCombinationSupportRun = true; return; }
    
    /* if (('$(Language)' == 'C++' and '$(_EnablePackageReferencesInVCProjects)' != 'true') and '$(TargetFrameworkIdentifier)' == '.NETCoreApp')*/
    if (('C#' == 'C++' and '' != 'true') and '.NETCoreApp' == '.NETCoreApp')
    {
        NETSdkError(ResourceName: "NoSupportCppPublishDotnetCore");
    }
    
    _CheckForLanguageAndPublishFeatureCombinationSupportRun = true;
}

void PackTool()
{
    // if ( '$(PackAsTool)' == 'true' )
    if ( '' == 'true' ) { PackToolRun = true; return; }
    // DependsOnTargets;
    if (!GenerateToolsSettingsFileFromBuildPropertyRun) GenerateToolsSettingsFileFromBuildProperty();
    if (!_PublishBuildAlternativeRun) _PublishBuildAlternative();
    if (!_PackToolValidationRun) _PackToolValidation();
    
    /*ResolveToolPackagePaths(AppHostIntermediatePath: "$(AppHostIntermediatePath)", PublishDir: "$(PublishDir)", ResolvedFileToPublish: "@(ResolvedFileToPublish)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", TargetPlatformMoniker: "$(TargetPlatformMoniker)");*/
    ResolveToolPackagePaths(AppHostIntermediatePath: "", PublishDir: "bin\\Debug\\net8.0\\publish\\", ResolvedFileToPublish: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", TargetPlatformMoniker: "");
    
    PackToolRun = true;
}

void _GenerateToolsSettingsFileInputCache()
{
    
    /*Hash(ItemsToHash: "@(_GenerateToolsSettingsFileInputCacheToHash)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(_GenerateToolsSettingsFileCacheFile)", Overwrite: "true", Lines: "$(_GenerateToolsSettingsFileInputCacheHash)", WriteOnlyWhenDifferent: "true");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.toolssettingsinput.cache", Overwrite: "true", Lines: "", WriteOnlyWhenDifferent: "true");
    
    _GenerateToolsSettingsFileInputCacheRun = true;
}

void GenerateToolsSettingsFileFromBuildProperty()
{
    // DependsOnTargets;
    if (!_GenerateToolsSettingsFileInputCacheRun) _GenerateToolsSettingsFileInputCache();
    
    /*GenerateToolsSettingsFile(CommandName: "$(ToolCommandName)", EntryPointRelativePath: "$(ToolEntryPoint)", ToolsSettingsFilePath: "$(_ToolsSettingsFilePath)");*/
    GenerateToolsSettingsFile(CommandName: "6 - targets", EntryPointRelativePath: "6 - targets.dll", ToolsSettingsFilePath: "obj\\DotnetToolSettings.xml");
    
    GenerateToolsSettingsFileFromBuildPropertyRun = true;
}

void _PackToolValidation()
{
    // if ( '$(PackAsTool)' == 'true' )
    if ( '' == 'true' ) { _PackToolValidationRun = true; return; }
    
    /*GetNuGetShortFolderName(TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", TargetPlatformMoniker: "$(TargetPlatformMoniker)");*/
    GetNuGetShortFolderName(TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", TargetPlatformMoniker: "");
    /* if ( '$(SelfContained)' == 'true' )*/
    if ( 'false' == 'true' )
    {
        NETSdkError(ResourceName: "PackAsToolCannotSupportSelfContained");
    }
    /* if ( '$(TargetFrameworkIdentifier)' != '.NETCoreApp' )*/
    if ( '.NETCoreApp' != '.NETCoreApp' )
    {
        NETSdkError(ResourceName: "DotnetToolOnlySupportNetcoreapp");
    }
    /* if ( '$(_TargetFrameworkVersionWithoutV)' < '2.1' )*/
    if ( '8.0' < '2.1' )
    {
        NETSdkError(ResourceName: "DotnetToolDoesNotSupportTFMLowerThanNetcoreapp21");
    }
    /* if ( '$(TargetPlatformIdentifier)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)))*/
    if ( '' != '' and '.NETCoreApp' == '.NETCoreApp' and True)
    {
        NETSdkError(ResourceName: "PackAsToolCannotSupportTargetPlatformIdentifier");
    }
    
    _PackToolValidationRun = true;
}

void GenerateShimsAssets()
{
    // if ('$(PackAsTool)' == 'true' and $(PackAsToolShimRuntimeIdentifiers) != '' )
    if ('' == 'true' and  != '' ) { GenerateShimsAssetsRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!_PackToolValidationRun) _PackToolValidation();
    if (!_GenerateShimInputCacheRun) _GenerateShimInputCache();
    if (!_ComputeExpectedEmbeddedApphostPathsRun) _ComputeExpectedEmbeddedApphostPaths();
    
    /*GenerateShims(ToolCommandName: "$(ToolCommandName)", ApphostsForShimRuntimeIdentifiers: "@(_ApphostsForShimRuntimeIdentifiers)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(_NuGetShortFolderName)", OutputType: "$(OutputType)", PackageVersion: "$(PackageVersion)", TargetFrameworkMoniker: "$(NuGetTargetMoniker)", IntermediateAssembly: "@(IntermediateAssembly->'%(FullPath)')", ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", PackageId: "$(PackageId)", ToolEntryPoint: "$(ToolEntryPoint)");*/
    GenerateShims(ToolCommandName: "6 - targets", ApphostsForShimRuntimeIdentifiers: "", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/", OutputType: "Exe", PackageVersion: "1.0.0", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", IntermediateAssembly: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.dll", ShimRuntimeIdentifiers: "", PackageId: "6 - targets", ToolEntryPoint: "6 - targets.dll");
    /*WriteLinesToFile(File: "$(_ShimCreatedSentinelFile)", Overwrite: "True", Lines: "This file's LastWriteTime is used in incremental build");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shimcreated.sentinel", Overwrite: "True", Lines: "This file's LastWriteTime is used in incremental build");
    
    GenerateShimsAssetsRun = true;
}

void _ComputeExpectedEmbeddedApphostPaths()
{
    
    /*GetEmbeddedApphostPaths(ToolCommandName: "$(ToolCommandName)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(_NuGetShortFolderName)", ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)");*/
    GetEmbeddedApphostPaths(ToolCommandName: "6 - targets", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/", ShimRuntimeIdentifiers: "");
    
    _ComputeExpectedEmbeddedApphostPathsRun = true;
}

void _GenerateShimInputCache()
{
    // DependsOnTargets;
    if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();
    
    /*Hash(ItemsToHash: "@(_GenerateShimsAssetsInputCacheToHash)");*/
    Hash(ItemsToHash: "");
    /*WriteLinesToFile(File: "$(_ShimInputCacheFile)", Overwrite: "True", Lines: "$(_GenerateShimsAssetsInputCacheHash)", WriteOnlyWhenDifferent: "True");*/
    WriteLinesToFile(File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shiminput.cache", Overwrite: "True", Lines: "", WriteOnlyWhenDifferent: "True");
    
    _GenerateShimInputCacheRun = true;
}

void _PackProjectToolValidation()
{
    // if ( '$(PackageType)' == 'DotnetCliTool')
    if ( '' == 'DotnetCliTool') { _PackProjectToolValidationRun = true; return; }
    
    /* if ( '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and '$(_TargetFrameworkVersionWithoutV)' > '2.2' )*/
    if ( '.NETCoreApp' == '.NETCoreApp' and '8.0' > '2.2' )
    {
        NETSdkError(ResourceName: "ProjectToolOnlySupportTFMLowerThanNetcoreapp22");
    }
    
    _PackProjectToolValidationRun = true;
}

void ComputeDependencyFileCompilerOptions()
{
    // if ('$(PreserveCompilationContext)' == 'true')
    if ('' == 'true') { ComputeDependencyFileCompilerOptionsRun = true; return; }
    
    ComputeDependencyFileCompilerOptionsRun = true;
}

void ComputeRefAssembliesToPublish()
{
    // if ('$(PreserveCompilationReferences)' == 'true')
    if ('' == 'true') { ComputeRefAssembliesToPublishRun = true; return; }
    // DependsOnTargets;
    if (!ResolvePackageAssetsRun) ResolvePackageAssets();
    if (!_ParseTargetManifestFilesRun) _ParseTargetManifestFiles();
    
    /*FindItemsFromPackages(Items: "@(RuntimeCopyLocalItems)", Packages: "@(RuntimeStorePackages)");*/
    FindItemsFromPackages(Items: "", Packages: "");
    
    ComputeRefAssembliesToPublishRun = true;
}

void _CopyReferenceOnlyAssembliesForBuild()
{
    // if ('$(PreserveCompilationReferences)' == 'true')
    if ('' == 'true') { _CopyReferenceOnlyAssembliesForBuildRun = true; return; }
    // DependsOnTargets;
    if (!_ComputeReferenceAssembliesRun) _ComputeReferenceAssemblies();
    
    /*Copy(UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", Retries: "$(CopyRetryCount)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", SourceFiles: "@(_ReferenceOnlyAssemblies)", DestinationFolder: "$(OutDir)$(RefAssembliesFolderName)");*/
    Copy(UseHardlinksIfPossible: "", UseSymboliclinksIfPossible: "", RetryDelayMilliseconds: "", SkipUnchangedFiles: "true", Retries: "", OverwriteReadOnlyFiles: "false", SourceFiles: "", DestinationFolder: "bin\\Debug\\net8.0\\refs");
    
    _CopyReferenceOnlyAssembliesForBuildRun = true;
}

void _HandlePackageFileConflicts()
{
    // DependsOnTargets;
    if (!GetFrameworkPathsRun) GetFrameworkPaths();
    if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
    if (!ResolveTargetingPackAssetsRun) ResolveTargetingPackAssets();
    
    /*ResolvePackageFileConflicts(PlatformManifests: "@(PackageConflictPlatformManifests)", OtherRuntimeItems: "@(_RuntimeAssetsForConflictResolution)", PackageOverrides: "@(PackageConflictOverrides)", PreferredPackages: "$(PackageConflictPreferredPackages)", TargetFrameworkDirectories: "$(TargetFrameworkDirectory)", ReferenceCopyLocalPaths: "@(ReferenceCopyLocalPaths)", Analyzers: "@(Analyzer)", References: "@(Reference)");*/
    ResolvePackageFileConflicts(PlatformManifests: "", OtherRuntimeItems: "", PackageOverrides: "NETStandard.Library", PreferredPackages: "", TargetFrameworkDirectories: "", ReferenceCopyLocalPaths: "", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", References: "");
    
    _HandlePackageFileConflictsRun = true;
}

void _HandlePackageFileConflictsForPublish()
{
    
    /*ResolvePackageFileConflicts(PlatformManifests: "@(PackageConflictPlatformManifests)", PreferredPackages: "$(PackageConflictPreferredPackages)", TargetFrameworkDirectories: "$(TargetFrameworkDirectory)", ReferenceCopyLocalPaths: "@(_ResolvedCopyLocalPublishAssets)");*/
    ResolvePackageFileConflicts(PlatformManifests: "", PreferredPackages: "", TargetFrameworkDirectories: "", ReferenceCopyLocalPaths: "");
    
    _HandlePackageFileConflictsForPublishRun = true;
}

void _HandleFileConflictsForPublish()
{
    // if ('$(ErrorOnDuplicatePublishOutputFiles)' != 'false')
    if ('' != 'false') { _HandleFileConflictsForPublishRun = true; return; }
    
    /*CheckForDuplicateItemMetadata(Items: "@(ResolvedFileToPublish->Distinct())", MetadataName: "RelativePath");*/
    CheckForDuplicateItemMetadata(Items: "", MetadataName: "RelativePath");
    /*NETSdkError(ResourceName: "DuplicatePublishOutputFiles", FormatArguments: "@(_ResolvedFileToPublishDuplicatedItems, ', ')");*/
    /* if ('$(_ResolvedFileToPublishContainsDuplicates)' == 'true')*/
    if ('' == 'true')
    {
        NETSdkError(ResourceName: "DuplicatePublishOutputFiles", FormatArguments: "");
    }
    
    _HandleFileConflictsForPublishRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzers()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true')
    if ('' != 'true') { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersRun = true; return; }
    
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersRulesVersion)' == '' and $(EffectiveAnalysisLevel) != '')*/
    if ('' == '' and 8.0 != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevel), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers = "$(AnalysisLevelSuffix)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers = "$(AnalysisMode)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers = "AnalysisLevel_$(MicrosoftCodeAnalysisNetAnalyzersRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzers)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzers)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzers = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzers = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzers)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzers)";
    }
    // AfterTargets;
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesign();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentation();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalization();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNaming();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformance();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliability();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurity();
    if (!AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun) AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsage();
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesign()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelDesign)' != '' or '$(AnalysisModeDesign)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun = true; return; }
    
    /* if ('$(AnalysisLevelDesign)' == '')*/
    if ('' == '')
    {
        AnalysisLevelDesign = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelDesign.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixDesign = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelDesign), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixDesign)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixDesign = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelDesign), '$(AnalysisLevelPrefixDesign)-', ''))";
    }
    /* if ('$(AnalysisLevelDesign)' == 'none' or '$(AnalysisLevelPrefixDesign)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelDesign = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelDesign)' == 'latest' or '$(AnalysisLevelPrefixDesign)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelDesign = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelDesign)' == 'preview' or '$(AnalysisLevelPrefixDesign)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelDesign = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelDesign)' == '' And
                                         '$(AnalysisLevelPrefixDesign)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelDesign = "$(AnalysisLevelPrefixDesign)";
    }
    /* if ('$(EffectiveAnalysisLevelDesign)' == '' And
                                         '$(AnalysisLevelDesign)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelDesign = "$(AnalysisLevelDesign)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersDesignRulesVersion)' == '' and $(EffectiveAnalysisLevelDesign) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersDesignRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelDesign), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign = "$(AnalysisLevelSuffixDesign)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign = "$(AnalysisModeDesign)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersDesignRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign = "AnalysisLevelDesign_$(MicrosoftCodeAnalysisNetAnalyzersDesignRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDesign)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDesign)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDesign = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersDesign = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDesign)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDesign)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentation()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelDocumentation)' != '' or '$(AnalysisModeDocumentation)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun = true; return; }
    
    /* if ('$(AnalysisLevelDocumentation)' == '')*/
    if ('' == '')
    {
        AnalysisLevelDocumentation = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelDocumentation.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixDocumentation = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelDocumentation), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixDocumentation)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixDocumentation = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelDocumentation), '$(AnalysisLevelPrefixDocumentation)-', ''))";
    }
    /* if ('$(AnalysisLevelDocumentation)' == 'none' or '$(AnalysisLevelPrefixDocumentation)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelDocumentation = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelDocumentation)' == 'latest' or '$(AnalysisLevelPrefixDocumentation)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelDocumentation = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelDocumentation)' == 'preview' or '$(AnalysisLevelPrefixDocumentation)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelDocumentation = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelDocumentation)' == '' And
                                         '$(AnalysisLevelPrefixDocumentation)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelDocumentation = "$(AnalysisLevelPrefixDocumentation)";
    }
    /* if ('$(EffectiveAnalysisLevelDocumentation)' == '' And
                                         '$(AnalysisLevelDocumentation)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelDocumentation = "$(AnalysisLevelDocumentation)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersDocumentationRulesVersion)' == '' and $(EffectiveAnalysisLevelDocumentation) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersDocumentationRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelDocumentation), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "$(AnalysisLevelSuffixDocumentation)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "$(AnalysisModeDocumentation)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersDocumentationRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "AnalysisLevelDocumentation_$(MicrosoftCodeAnalysisNetAnalyzersDocumentationRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersDocumentation)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersDocumentation = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersDocumentation)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersDocumentation)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalization()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelGlobalization)' != '' or '$(AnalysisModeGlobalization)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun = true; return; }
    
    /* if ('$(AnalysisLevelGlobalization)' == '')*/
    if ('' == '')
    {
        AnalysisLevelGlobalization = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelGlobalization.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixGlobalization = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelGlobalization), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixGlobalization)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixGlobalization = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelGlobalization), '$(AnalysisLevelPrefixGlobalization)-', ''))";
    }
    /* if ('$(AnalysisLevelGlobalization)' == 'none' or '$(AnalysisLevelPrefixGlobalization)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelGlobalization = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelGlobalization)' == 'latest' or '$(AnalysisLevelPrefixGlobalization)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelGlobalization = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelGlobalization)' == 'preview' or '$(AnalysisLevelPrefixGlobalization)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelGlobalization = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelGlobalization)' == '' And
                                         '$(AnalysisLevelPrefixGlobalization)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelGlobalization = "$(AnalysisLevelPrefixGlobalization)";
    }
    /* if ('$(EffectiveAnalysisLevelGlobalization)' == '' And
                                         '$(AnalysisLevelGlobalization)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelGlobalization = "$(AnalysisLevelGlobalization)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersGlobalizationRulesVersion)' == '' and $(EffectiveAnalysisLevelGlobalization) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersGlobalizationRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelGlobalization), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "$(AnalysisLevelSuffixGlobalization)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "$(AnalysisModeGlobalization)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersGlobalizationRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "AnalysisLevelGlobalization_$(MicrosoftCodeAnalysisNetAnalyzersGlobalizationRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersGlobalization)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersGlobalization = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersGlobalization)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersGlobalization)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperability()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelInteroperability)' != '' or '$(AnalysisModeInteroperability)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun = true; return; }
    
    /* if ('$(AnalysisLevelInteroperability)' == '')*/
    if ('' == '')
    {
        AnalysisLevelInteroperability = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelInteroperability.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixInteroperability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelInteroperability), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixInteroperability)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixInteroperability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelInteroperability), '$(AnalysisLevelPrefixInteroperability)-', ''))";
    }
    /* if ('$(AnalysisLevelInteroperability)' == 'none' or '$(AnalysisLevelPrefixInteroperability)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelInteroperability = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelInteroperability)' == 'latest' or '$(AnalysisLevelPrefixInteroperability)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelInteroperability = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelInteroperability)' == 'preview' or '$(AnalysisLevelPrefixInteroperability)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelInteroperability = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelInteroperability)' == '' And
                                         '$(AnalysisLevelPrefixInteroperability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelInteroperability = "$(AnalysisLevelPrefixInteroperability)";
    }
    /* if ('$(EffectiveAnalysisLevelInteroperability)' == '' And
                                         '$(AnalysisLevelInteroperability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelInteroperability = "$(AnalysisLevelInteroperability)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRulesVersion)' == '' and $(EffectiveAnalysisLevelInteroperability) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelInteroperability), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "$(AnalysisLevelSuffixInteroperability)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "$(AnalysisModeInteroperability)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "AnalysisLevelInteroperability_$(MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersInteroperability)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersInteroperability = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersInteroperability)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersInteroperability)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainability()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelMaintainability)' != '' or '$(AnalysisModeMaintainability)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun = true; return; }
    
    /* if ('$(AnalysisLevelMaintainability)' == '')*/
    if ('' == '')
    {
        AnalysisLevelMaintainability = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelMaintainability.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixMaintainability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelMaintainability), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixMaintainability)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixMaintainability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelMaintainability), '$(AnalysisLevelPrefixMaintainability)-', ''))";
    }
    /* if ('$(AnalysisLevelMaintainability)' == 'none' or '$(AnalysisLevelPrefixMaintainability)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelMaintainability = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelMaintainability)' == 'latest' or '$(AnalysisLevelPrefixMaintainability)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelMaintainability = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelMaintainability)' == 'preview' or '$(AnalysisLevelPrefixMaintainability)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelMaintainability = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelMaintainability)' == '' And
                                         '$(AnalysisLevelPrefixMaintainability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelMaintainability = "$(AnalysisLevelPrefixMaintainability)";
    }
    /* if ('$(EffectiveAnalysisLevelMaintainability)' == '' And
                                         '$(AnalysisLevelMaintainability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelMaintainability = "$(AnalysisLevelMaintainability)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRulesVersion)' == '' and $(EffectiveAnalysisLevelMaintainability) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelMaintainability), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "$(AnalysisLevelSuffixMaintainability)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "$(AnalysisModeMaintainability)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "AnalysisLevelMaintainability_$(MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersMaintainability)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersMaintainability = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersMaintainability)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersMaintainability)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNaming()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelNaming)' != '' or '$(AnalysisModeNaming)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun = true; return; }
    
    /* if ('$(AnalysisLevelNaming)' == '')*/
    if ('' == '')
    {
        AnalysisLevelNaming = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelNaming.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixNaming = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelNaming), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixNaming)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixNaming = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelNaming), '$(AnalysisLevelPrefixNaming)-', ''))";
    }
    /* if ('$(AnalysisLevelNaming)' == 'none' or '$(AnalysisLevelPrefixNaming)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelNaming = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelNaming)' == 'latest' or '$(AnalysisLevelPrefixNaming)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelNaming = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelNaming)' == 'preview' or '$(AnalysisLevelPrefixNaming)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelNaming = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelNaming)' == '' And
                                         '$(AnalysisLevelPrefixNaming)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelNaming = "$(AnalysisLevelPrefixNaming)";
    }
    /* if ('$(EffectiveAnalysisLevelNaming)' == '' And
                                         '$(AnalysisLevelNaming)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelNaming = "$(AnalysisLevelNaming)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersNamingRulesVersion)' == '' and $(EffectiveAnalysisLevelNaming) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersNamingRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelNaming), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming = "$(AnalysisLevelSuffixNaming)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming = "$(AnalysisModeNaming)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersNamingRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming = "AnalysisLevelNaming_$(MicrosoftCodeAnalysisNetAnalyzersNamingRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersNaming)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersNaming)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersNaming = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersNaming = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersNaming)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersNaming)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformance()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelPerformance)' != '' or '$(AnalysisModePerformance)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun = true; return; }
    
    /* if ('$(AnalysisLevelPerformance)' == '')*/
    if ('' == '')
    {
        AnalysisLevelPerformance = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelPerformance.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixPerformance = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelPerformance), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixPerformance)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixPerformance = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelPerformance), '$(AnalysisLevelPrefixPerformance)-', ''))";
    }
    /* if ('$(AnalysisLevelPerformance)' == 'none' or '$(AnalysisLevelPrefixPerformance)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelPerformance = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelPerformance)' == 'latest' or '$(AnalysisLevelPrefixPerformance)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelPerformance = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelPerformance)' == 'preview' or '$(AnalysisLevelPrefixPerformance)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelPerformance = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelPerformance)' == '' And
                                         '$(AnalysisLevelPrefixPerformance)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelPerformance = "$(AnalysisLevelPrefixPerformance)";
    }
    /* if ('$(EffectiveAnalysisLevelPerformance)' == '' And
                                         '$(AnalysisLevelPerformance)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelPerformance = "$(AnalysisLevelPerformance)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersPerformanceRulesVersion)' == '' and $(EffectiveAnalysisLevelPerformance) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersPerformanceRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelPerformance), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance = "$(AnalysisLevelSuffixPerformance)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance = "$(AnalysisModePerformance)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersPerformanceRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance = "AnalysisLevelPerformance_$(MicrosoftCodeAnalysisNetAnalyzersPerformanceRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersPerformance)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersPerformance)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersPerformance = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersPerformance = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersPerformance)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersPerformance)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliability()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelReliability)' != '' or '$(AnalysisModeReliability)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun = true; return; }
    
    /* if ('$(AnalysisLevelReliability)' == '')*/
    if ('' == '')
    {
        AnalysisLevelReliability = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelReliability.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixReliability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelReliability), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixReliability)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixReliability = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelReliability), '$(AnalysisLevelPrefixReliability)-', ''))";
    }
    /* if ('$(AnalysisLevelReliability)' == 'none' or '$(AnalysisLevelPrefixReliability)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelReliability = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelReliability)' == 'latest' or '$(AnalysisLevelPrefixReliability)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelReliability = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelReliability)' == 'preview' or '$(AnalysisLevelPrefixReliability)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelReliability = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelReliability)' == '' And
                                         '$(AnalysisLevelPrefixReliability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelReliability = "$(AnalysisLevelPrefixReliability)";
    }
    /* if ('$(EffectiveAnalysisLevelReliability)' == '' And
                                         '$(AnalysisLevelReliability)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelReliability = "$(AnalysisLevelReliability)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersReliabilityRulesVersion)' == '' and $(EffectiveAnalysisLevelReliability) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersReliabilityRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelReliability), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability = "$(AnalysisLevelSuffixReliability)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability = "$(AnalysisModeReliability)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersReliabilityRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability = "AnalysisLevelReliability_$(MicrosoftCodeAnalysisNetAnalyzersReliabilityRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersReliability)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersReliability)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersReliability = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersReliability = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersReliability)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersReliability)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurity()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelSecurity)' != '' or '$(AnalysisModeSecurity)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun = true; return; }
    
    /* if ('$(AnalysisLevelSecurity)' == '')*/
    if ('' == '')
    {
        AnalysisLevelSecurity = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelSecurity.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixSecurity = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelSecurity), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixSecurity)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixSecurity = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelSecurity), '$(AnalysisLevelPrefixSecurity)-', ''))";
    }
    /* if ('$(AnalysisLevelSecurity)' == 'none' or '$(AnalysisLevelPrefixSecurity)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelSecurity = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelSecurity)' == 'latest' or '$(AnalysisLevelPrefixSecurity)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelSecurity = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelSecurity)' == 'preview' or '$(AnalysisLevelPrefixSecurity)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelSecurity = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelSecurity)' == '' And
                                         '$(AnalysisLevelPrefixSecurity)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelSecurity = "$(AnalysisLevelPrefixSecurity)";
    }
    /* if ('$(EffectiveAnalysisLevelSecurity)' == '' And
                                         '$(AnalysisLevelSecurity)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelSecurity = "$(AnalysisLevelSecurity)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersSecurityRulesVersion)' == '' and $(EffectiveAnalysisLevelSecurity) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersSecurityRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelSecurity), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity = "$(AnalysisLevelSuffixSecurity)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity = "$(AnalysisModeSecurity)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersSecurityRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity = "AnalysisLevelSecurity_$(MicrosoftCodeAnalysisNetAnalyzersSecurityRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersSecurity)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersSecurity)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersSecurity = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersSecurity = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersSecurity)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersSecurity)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsage()
{
    // if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelUsage)' != '' or '$(AnalysisModeUsage)' != ''))
    if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun = true; return; }
    
    /* if ('$(AnalysisLevelUsage)' == '')*/
    if ('' == '')
    {
        AnalysisLevelUsage = "$(AnalysisLevel)";
    }
    /* if ($(AnalysisLevelUsage.Contains('-')))*/
    if (False)
    {
        AnalysisLevelPrefixUsage = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelUsage), '-(.)*', ''))";
    }
    /* if ('$(AnalysisLevelPrefixUsage)' != '')*/
    if ('' != '')
    {
        AnalysisLevelSuffixUsage = "$([System.Text.RegularExpressions.Regex]::Replace($(AnalysisLevelUsage), '$(AnalysisLevelPrefixUsage)-', ''))";
    }
    /* if ('$(AnalysisLevelUsage)' == 'none' or '$(AnalysisLevelPrefixUsage)' == 'none')*/
    if ('' == 'none' or '' == 'none')
    {
        EffectiveAnalysisLevelUsage = "$(_NoneAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelUsage)' == 'latest' or '$(AnalysisLevelPrefixUsage)' == 'latest')*/
    if ('' == 'latest' or '' == 'latest')
    {
        EffectiveAnalysisLevelUsage = "$(_LatestAnalysisLevel)";
    }
    /* if ('$(AnalysisLevelUsage)' == 'preview' or '$(AnalysisLevelPrefixUsage)' == 'preview')*/
    if ('' == 'preview' or '' == 'preview')
    {
        EffectiveAnalysisLevelUsage = "$(_PreviewAnalysisLevel)";
    }
    /* if ('$(EffectiveAnalysisLevelUsage)' == '' And
                                         '$(AnalysisLevelPrefixUsage)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelUsage = "$(AnalysisLevelPrefixUsage)";
    }
    /* if ('$(EffectiveAnalysisLevelUsage)' == '' And
                                         '$(AnalysisLevelUsage)' != '')*/
    if ('' == '' And
                                         '' != '')
    {
        EffectiveAnalysisLevelUsage = "$(AnalysisLevelUsage)";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersUsageRulesVersion)' == '' and $(EffectiveAnalysisLevelUsage) != '')*/
    if ('' == '' and  != '')
    {
        MicrosoftCodeAnalysisNetAnalyzersUsageRulesVersion = "$([System.Text.RegularExpressions.Regex]::Replace($(EffectiveAnalysisLevelUsage), '(.0)*$', ''))";
    }
    _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage = "$(AnalysisLevelSuffixUsage)";
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage = "$(AnalysisModeUsage)";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage)' == 'AllEnabledByDefault')*/
    if ('' == 'AllEnabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage = "All";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage)' == 'AllDisabledByDefault')*/
    if ('' == 'AllDisabledByDefault')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage = "None";
    }
    /* if ('$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage = "Default";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'true')*/
    if ('' == 'true')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage_WarnAsErrorSuffix = "_warnaserror";
    }
    /* if ('$(MicrosoftCodeAnalysisNetAnalyzersUsageRulesVersion)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage = "AnalysisLevelUsage_$(MicrosoftCodeAnalysisNetAnalyzersUsageRulesVersion.Replace(".","_"))_$(_GlobalAnalyzerConfigAnalysisMode_MicrosoftCodeAnalysisNetAnalyzersUsage)$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage_WarnAsErrorSuffix).globalconfig";
    }
    _GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage = "$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage.ToLowerInvariant())";
    /* if ('$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersUsage)' == '')*/
    if ('' == '')
    {
        _GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersUsage = "$(MSBuildThisFileDirectory)config";
    }
    /* if ('$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage)' != '')*/
    if ('' != '')
    {
        _GlobalAnalyzerConfigFile_MicrosoftCodeAnalysisNetAnalyzersUsage = "$(_GlobalAnalyzerConfigDir_MicrosoftCodeAnalysisNetAnalyzersUsage)\\$(_GlobalAnalyzerConfigFileName_MicrosoftCodeAnalysisNetAnalyzersUsage)";
    }
    AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun = true;
}

void _CodeAnalysisTreatWarningsAsErrors()
{
    // if ('$(DesignTimeBuild)' == 'true' OR '$(BuildingProject)' != 'true')
    if ('' == 'true' OR 'false' != 'true') { _CodeAnalysisTreatWarningsAsErrorsRun = true; return; }
    
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == '')*/
    if ('' == '')
    {
        EffectiveCodeAnalysisTreatWarningsAsErrors = "$(CodeAnalysisTreatWarningsAsErrors)";
    }
    /* if ('$(EffectiveCodeAnalysisTreatWarningsAsErrors)' == 'false' and '$(TreatWarningsAsErrors)' == 'true')*/
    if ('' == 'false' and 'false' == 'true')
    {
        WarningsNotAsErrors = "$(WarningsNotAsErrors);$(CodeAnalysisRuleIds)";
    }
    _CodeAnalysisTreatWarningsAsErrorsRun = true;
}

void _ReportUpgradeNetAnalyzersNuGetWarning()
{
    // if ('$(_SkipUpgradeNetAnalyzersNuGetWarning)' != 'true' )
    if ('' != 'true' ) { _ReportUpgradeNetAnalyzersNuGetWarningRun = true; return; }
    
    /*Warning(Text: "The .NET SDK has newer analyzers with version '$(_NETAnalyzersSDKAssemblyVersion)' than what version '$(_NETAnalyzersNuGetAssemblyVersion)' of 'Microsoft.CodeAnalysis.NetAnalyzers' package provides. Update or remove this package reference. You can suppress this warning by setting the MSBuild property '_SkipUpgradeNetAnalyzersNuGetWarning' to 'true'.");*/
    /* if ('$(_NETAnalyzersNuGetAssemblyVersion)' != '' AND
                         '$(_NETAnalyzersSDKAssemblyVersion)' != '' AND
                          $(_NETAnalyzersNuGetAssemblyVersion) < $(_NETAnalyzersSDKAssemblyVersion))*/
    if ('' != '' AND
                         '8.0.0' != '' AND
                           < 8.0.0)
    {
        Warning(Text: "The .NET SDK has newer analyzers with version '8.0.0' than what version '' of 'Microsoft.CodeAnalysis.NetAnalyzers' package provides. Update or remove this package reference. You can suppress this warning by setting the MSBuild property '_SkipUpgradeNetAnalyzersNuGetWarning' to 'true'.");
    }
    
    _ReportUpgradeNetAnalyzersNuGetWarningRun = true;
}

void CollectApiCompatInputs()
{
    
    /* if ('$(RoslynAssembliesPath)' == '')*/
    if ('' == '')
    {
        RoslynAssembliesPath = "$(RoslynTargetsPath)";
        _packageReferenceList = "@(PackageReference)";
        /* if ($(_packageReferenceList.Contains('Microsoft.Net.Compilers.Toolset')))*/
        if (False)
        {
            RoslynAssembliesPath = "$([System.IO.Path]::GetDirectoryName($(CSharpCoreTargetsPath)))";
        }
        /* if ('$(MSBuildRuntimeType)' == 'Core')*/
        if ('Core' == 'Core')
        {
            RoslynAssembliesPath = "$([System.IO.Path]::Combine('$(RoslynAssembliesPath)', bincore))";
        }
    }
    /* if ('$(ApiCompatGenerateSuppressionFile)' == '')*/
    if ('' == '')
    {
        ApiCompatGenerateSuppressionFile = "$(GenerateCompatibilitySuppressionFile)";
    }
    _apiCompatDefaultProjectSuppressionFile = "$([MSBuild]::NormalizePath('$(MSBuildProjectDirectory)', 'CompatibilitySuppressions.xml'))";
    /* if ('$(ApiCompatSuppressionOutputFile)' == '' and '$(ApiCompatGenerateSuppressionFile)' == 'true')*/
    if ('' == '' and '' == 'true')
    {
        ApiCompatSuppressionOutputFile = "$(_apiCompatDefaultProjectSuppressionFile)";
    }
    CollectApiCompatInputsRun = true;
}

void RunPackageValidation()
{
    // if ('$(EnablePackageValidation)' == 'true' and '$(IsPackable)' == 'true')
    if ('' == 'true' and 'true' == 'true') { RunPackageValidationRun = true; return; }
    // DependsOnTargets;
    if (!CollectApiCompatInputsRun) CollectApiCompatInputs();
    if (!_GetReferencePathFromInnerProjectsRun) _GetReferencePathFromInnerProjects();
    if (!Run) ();
    
    /* if ('$(PackageValidationBaselineName)' == '')*/
    if ('' == '')
    {
        PackageValidationBaselineName = "$(PackageId)";
    }
    /* if ('$(PackageValidationBaselinePath)' == '' and '$(PackageValidationBaselineVersion)' != '')*/
    if ('' == '' and '' != '')
    {
        PackageValidationBaselinePath = "$([MSBuild]::NormalizePath('$(NuGetPackageRoot)', '$(PackageValidationBaselineName.ToLower())', '$(PackageValidationBaselineVersion)', '$(PackageValidationBaselineName.ToLower()).$(PackageValidationBaselineVersion).nupkg'))";
    }
    /* if ('$(DisablePackageBaselineValidation)' != 'true')*/
    if ('' != 'true')
    {
        _packageValidationBaselinePath = "$(PackageValidationBaselinePath)";
    }
    /*Microsoft.DotNet.ApiCompat.Task.ValidatePackageTask(ExcludeAttributesFiles: "@(ApiCompatExcludeAttributesFile)", EnableStrictModeForBaselineValidation: "$(EnableStrictModeForBaselineValidation)", PackageTargetPath: "@(_PackageTargetPath)", PreserveUnnecessarySuppressions: "$(ApiCompatPreserveUnnecessarySuppressions)", EnableRuleAttributesMustMatch: "$(ApiCompatEnableRuleAttributesMustMatch)", SuppressionOutputFile: "$(ApiCompatSuppressionOutputFile)", GenerateSuppressionFile: "$(ApiCompatGenerateSuppressionFile)", EnableStrictModeForCompatibleFrameworksInPackage: "$(EnableStrictModeForCompatibleFrameworksInPackage)", RespectInternals: "$(ApiCompatRespectInternals)", PackageAssemblyReferences: "@(PackageValidationReferencePath)", NoWarn: "$(NoWarn)", BaselinePackageTargetPath: "$(_packageValidationBaselinePath)", SuppressionFiles: "@(ApiCompatSuppressionFile)", PermitUnnecessarySuppressions: "$(ApiCompatPermitUnnecessarySuppressions)", EnableRuleCannotChangeParameterName: "$(ApiCompatEnableRuleCannotChangeParameterName)", RunApiCompat: "$(RunApiCompat)", RoslynAssembliesPath: "$(RoslynAssembliesPath)", RuntimeGraph: "$(RuntimeIdentifierGraphPath)", EnableStrictModeForCompatibleTfms: "$(EnableStrictModeForCompatibleTfms)");*/
    Microsoft.DotNet.ApiCompat.Task.ValidatePackageTask(ExcludeAttributesFiles: "", EnableStrictModeForBaselineValidation: "", PackageTargetPath: "", PreserveUnnecessarySuppressions: "", EnableRuleAttributesMustMatch: "", SuppressionOutputFile: "", GenerateSuppressionFile: "", EnableStrictModeForCompatibleFrameworksInPackage: "", RespectInternals: "", PackageAssemblyReferences: "", NoWarn: "1701;1702", BaselinePackageTargetPath: "", SuppressionFiles: "", PermitUnnecessarySuppressions: "", EnableRuleCannotChangeParameterName: "", RunApiCompat: "", RoslynAssembliesPath: "", RuntimeGraph: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", EnableStrictModeForCompatibleTfms: "");
    /*MakeDir(Directories: "$([System.IO.Path]::GetDirectoryName('$(ApiCompatValidatePackageSemaphoreFile)'))");*/
    MakeDir(Directories: "obj\\Debug\\net8.0");
    /*Touch(AlwaysCreate: "true", Files: "$(ApiCompatValidatePackageSemaphoreFile)");*/
    Touch(AlwaysCreate: "true", Files: "obj\\Debug\\net8.0\\Microsoft.NET.ApiCompat.ValidatePackage.semaphore");
    
    RunPackageValidationRun = true;
}

void GetReferencesForApiCompatValidatePackage()
{
    // DependsOnTargets;
    if (!FindReferenceAssembliesForReferencesRun) FindReferenceAssembliesForReferences();
    
    GetReferencesForApiCompatValidatePackageRun = true;
}

void _GetReferencePathFromInnerProjects()
{
    // if ('$(RunPackageValidationWithoutReferences)' != 'true')
    if ('' != 'true') { _GetReferencePathFromInnerProjectsRun = true; return; }
    // DependsOnTargets;
    if (!_GetTargetFrameworksOutputRun) _GetTargetFrameworksOutput();
    
    /*MSBuild(Targets: "GetReferencesForApiCompatValidatePackage", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                         BuildProjectReferences=false""");*/
    MSBuild(Targets: "GetReferencesForApiCompatValidatePackage", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                         BuildProjectReferences=false""");
    
    _GetReferencePathFromInnerProjectsRun = true;
}

void _GetAbsoluteOutputPathsForPack()
{
    
    /*ConvertToAbsolutePath(Paths: "$(RestoreOutputPath)");*/
    ConvertToAbsolutePath(Paths: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\");
    /*ConvertToAbsolutePath(Paths: "$(PackageOutputPath)");*/
    ConvertToAbsolutePath(Paths: "bin\\Debug\\");
    /*ConvertToAbsolutePath(Paths: "$(NuspecOutputPath)");*/
    ConvertToAbsolutePath(Paths: "obj\\Debug\\");
    
    _GetAbsoluteOutputPathsForPackRun = true;
}

void _GetOutputItemsFromPack()
{
    // DependsOnTargets;
    if (!_GetAbsoluteOutputPathsForPackRun) _GetAbsoluteOutputPathsForPack();
    
    /*GetPackOutputItemsTask(PackageOutputPath: "$(PackageOutputAbsolutePath)", IncludeSymbols: "$(IncludeSymbols)", PackageVersion: "$(PackageVersion)", NuspecOutputPath: "$(NuspecOutputAbsolutePath)", IncludeSource: "$(IncludeSource)", PackageId: "$(PackageId)", SymbolPackageFormat: "$(SymbolPackageFormat)");*/
    GetPackOutputItemsTask(PackageOutputPath: "", IncludeSymbols: "", PackageVersion: "1.0.0", NuspecOutputPath: "", IncludeSource: "", PackageId: "6 - targets", SymbolPackageFormat: "symbols.nupkg");
    
    _GetOutputItemsFromPackRun = true;
}

void _GetTargetFrameworksOutput()
{
    
    _ProjectFrameworks = "";
    /*GetProjectTargetFrameworksTask(TargetPlatformMinVersion: "$(TargetPlatformMinVersion)", TargetFramework: "$(TargetFramework)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", TargetFrameworks: "$(TargetFrameworks)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", ProjectPath: "$(MSBuildProjectFullPath)");*/
    GetProjectTargetFrameworksTask(TargetPlatformMinVersion: "", TargetFramework: "net8.0", TargetPlatformIdentifier: "", TargetPlatformVersion: "", TargetFrameworks: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
    
    _GetTargetFrameworksOutputRun = true;
}

void _PackAsBuildAfterTarget()
{
    // if ('$(GeneratePackageOnBuild)' == 'true' AND '$(IsInnerBuild)' != 'true')
    if ('false' == 'true' AND '' != 'true') { _PackAsBuildAfterTargetRun = true; return; }
    // DependsOnTargets;
    if (!PackRun) Pack();
    
    _PackAsBuildAfterTargetRun = true;
}

void _CleanPackageFiles()
{
    // if ('$(GeneratePackageOnBuild)' == 'true' AND '$(IsInnerBuild)' != 'true')
    if ('false' == 'true' AND '' != 'true') { _CleanPackageFilesRun = true; return; }
    // DependsOnTargets;
    if (!_GetOutputItemsFromPackRun) _GetOutputItemsFromPack();
    
    /*Delete(Files: "@(_PackageFilesToDelete)");*/
    Delete(Files: "");
    
    _CleanPackageFilesRun = true;
}

void _CalculateInputsOutputsForPack()
{
    // DependsOnTargets;
    if (!_GetOutputItemsFromPackRun) _GetOutputItemsFromPack();
    
    /* if ($(ContinuePackingAfterGeneratingNuspec) == '' )*/
    if ( == '' )
    {
        ContinuePackingAfterGeneratingNuspec = "false";
    }
    _CalculateInputsOutputsForPackRun = true;
}

void Pack()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!_IntermediatePackRun) _IntermediatePack();
    if (!GenerateNuspecRun) GenerateNuspec();
    if (!Run) ();
    
    /* if ('$(IsPackable)' == 'false' AND '$(WarnOnPackingNonPackableProject)' == 'true')*/
    if ('true' == 'false' AND 'false' == 'true')
    {
        IsPackableFalseWarningTask();
    }
    
    // AfterTargets;
    if (!RunPackageValidationRun) RunPackageValidation();
    PackRun = true;
}

void _IntermediatePack()
{
    
    ContinuePackingAfterGeneratingNuspec = "true";
    _IntermediatePackRun = true;
}

void GenerateNuspec()
{
    // if ('$(IsPackable)' == 'true')
    if ('true' == 'true') { GenerateNuspecRun = true; return; }
    // DependsOnTargets;
    if (!BuildRun) Build();
    if (!_LoadPackInputItemsRun) _LoadPackInputItems();
    if (!_GetTargetFrameworksOutputRun) _GetTargetFrameworksOutput();
    if (!_WalkEachTargetPerFrameworkRun) _WalkEachTargetPerFramework();
    if (!_GetPackageFilesRun) _GetPackageFiles();
    if (!Run) ();
    if (!_CalculateInputsOutputsForPackRun) _CalculateInputsOutputsForPack();
    if (!_GetProjectReferenceVersionsRun) _GetProjectReferenceVersions();
    if (!_InitializeNuspecRepositoryInformationPropertiesRun) _InitializeNuspecRepositoryInformationProperties();
    
    /*ConvertToAbsolutePath(Paths: "$(NuspecFile)");*/
    /* if ($(NuspecFile) != '')*/
    if ( != '')
    {
        ConvertToAbsolutePath(Paths: "");
    }
    /*PackTask(Description: "$(PackageDescription)", OutputFileNamesWithoutVersion: "$(OutputFileNamesWithoutVersion)", PackageLicenseExpressionVersion: "$(PackageLicenseExpressionVersion)", RequireLicenseAcceptance: "$(PackageRequireLicenseAcceptance)", WarningsAsErrors: "$(WarningsAsErrors)", IconUrl: "$(PackageIconUrl)", PackageOutputPath: "$(PackageOutputAbsolutePath)", NoDefaultExcludes: "$(NoDefaultExcludes)", NuspecBasePath: "$(NuspecBasePath)", NuspecProperties: "$(NuspecProperties)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", InstallPackageToOutputPath: "$(InstallPackageToOutputPath)", NuspecFile: "$(NuspecFileAbsolutePath)", PackageLicenseFile: "$(PackageLicenseFile)", NoPackageAnalysis: "$(NoPackageAnalysis)", RepositoryBranch: "$(RepositoryBranch)", ProjectReferencesWithVersions: "@(_ProjectReferencesWithVersions)", RepositoryType: "$(RepositoryType)", LicenseUrl: "$(PackageLicenseUrl)", Authors: "$(Authors)", IncludeSymbols: "$(IncludeSymbols)", ContentTargetFolders: "$(ContentTargetFolders)", ReleaseNotes: "$(PackageReleaseNotes)", FrameworkAssemblyReferences: "@(_FrameworkAssemblyReferences)", PackageTypes: "$(PackageType)", Copyright: "$(Copyright)", Title: "$(Title)", PackageIcon: "$(PackageIcon)", PackageVersion: "$(PackageVersion)", RepositoryCommit: "$(RepositoryCommit)", NuspecOutputPath: "$(NuspecOutputAbsolutePath)", ProjectUrl: "$(PackageProjectUrl)", PackageFiles: "@(_PackageFiles)", PackageLicenseExpression: "$(PackageLicenseExpression)", IncludeSource: "$(IncludeSource)", AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder: "$(AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder)", PackItem: "$(PackProjectInputFile)", TargetFrameworks: "@(_TargetFrameworks)", BuildOutputInPackage: "@(_BuildOutputInPackage)", RepositoryUrl: "$(RepositoryUrl)", BuildOutputFolders: "$(BuildOutputTargetFolder)", RestoreOutputPath: "$(RestoreOutputAbsolutePath)", AllowedOutputExtensionsInPackageBuildOutputFolder: "$(AllowedOutputExtensionsInPackageBuildOutputFolder)", AssemblyName: "$(AssemblyName)", NoWarn: "$(NoWarn)", PackageId: "$(PackageId)", IsTool: "$(IsTool)", SymbolPackageFormat: "$(SymbolPackageFormat)", Readme: "$(PackageReadmeFile)", SourceFiles: "@(_SourceFiles->Distinct())", ContinuePackingAfterGeneratingNuspec: "$(ContinuePackingAfterGeneratingNuspec)", DevelopmentDependency: "$(DevelopmentDependency)", Deterministic: "$(Deterministic)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", PackageFilesToExclude: "@(_PackageFilesToExclude)", Serviceable: "$(Serviceable)", FrameworksWithSuppressedDependencies: "@(_FrameworksWithSuppressedDependencies)", MinClientVersion: "$(MinClientVersion)", IncludeBuildOutput: "$(IncludeBuildOutput)", Tags: "$(PackageTags)", TargetPathsToSymbols: "@(_TargetPathsToSymbols)");*/
    PackTask(Description: "Package Description", OutputFileNamesWithoutVersion: "", PackageLicenseExpressionVersion: "", RequireLicenseAcceptance: "false", WarningsAsErrors: ";NU1605;SYSLIB0011", IconUrl: "", PackageOutputPath: "", NoDefaultExcludes: "", NuspecBasePath: "", NuspecProperties: "", WarningsNotAsErrors: "", InstallPackageToOutputPath: "", NuspecFile: "", PackageLicenseFile: "", NoPackageAnalysis: "", RepositoryBranch: "", ProjectReferencesWithVersions: "", RepositoryType: "", LicenseUrl: "", Authors: "6 - targets", IncludeSymbols: "", ContentTargetFolders: "content;contentFiles", ReleaseNotes: "", FrameworkAssemblyReferences: "", PackageTypes: "", Copyright: "", Title: "", PackageIcon: "", PackageVersion: "1.0.0", RepositoryCommit: "", NuspecOutputPath: "", ProjectUrl: "", PackageFiles: "", PackageLicenseExpression: "", IncludeSource: "", AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder: ".pdb; .mdb; .dll; .exe; .winmd; .json; .pri; .xml ;; ", PackItem: "", TargetFrameworks: "", BuildOutputInPackage: "", RepositoryUrl: "", BuildOutputFolders: "lib", RestoreOutputPath: "", AllowedOutputExtensionsInPackageBuildOutputFolder: ".dll; .exe; .winmd; .json; .pri; .xml ;", AssemblyName: "6 - targets", NoWarn: "1701;1702", PackageId: "6 - targets", IsTool: "", SymbolPackageFormat: "symbols.nupkg", Readme: "", SourceFiles: "", ContinuePackingAfterGeneratingNuspec: "", DevelopmentDependency: "", Deterministic: "true", TreatWarningsAsErrors: "false", PackageFilesToExclude: "", Serviceable: "", FrameworksWithSuppressedDependencies: "", MinClientVersion: "", IncludeBuildOutput: "true", Tags: "", TargetPathsToSymbols: "");
    
    GenerateNuspecRun = true;
}

void _InitializeNuspecRepositoryInformationProperties()
{
    // if ('$(SourceControlInformationFeatureSupported)' == 'true')
    if ('true' == 'true') { _InitializeNuspecRepositoryInformationPropertiesRun = true; return; }
    // DependsOnTargets;
    if (!InitializeSourceControlInformationRun) InitializeSourceControlInformation();
    
    /* if ('$(RepositoryUrl)' == '' and '$(PublishRepositoryUrl)' == 'true')*/
    if ('' == '' and '' == 'true')
    {
        RepositoryUrl = "$(PrivateRepositoryUrl)";
    }
    /* if ('$(RepositoryCommit)' == '')*/
    if ('' == '')
    {
        RepositoryCommit = "$(SourceRevisionId)";
    }
    _InitializeNuspecRepositoryInformationPropertiesRun = true;
}

void _LoadPackInputItems()
{
    
    /* if ('$(PackProjectInputFile)' == '')*/
    if ('' == '')
    {
        PackProjectInputFile = "$(MSBuildProjectFullPath)";
    }
    _LoadPackInputItemsRun = true;
}

void _GetProjectReferenceVersions()
{
    // if ('$(NuspecFile)' == '')
    if ('' == '') { _GetProjectReferenceVersionsRun = true; return; }
    // DependsOnTargets;
    if (!_GetAbsoluteOutputPathsForPackRun) _GetAbsoluteOutputPathsForPack();
    if (!Run) ();
    
    /*ConvertToAbsolutePath(Paths: "$(ProjectAssetsFile)");*/
    /* if ('$(ProjectAssetsFile)' != '')*/
    if ('D:\d\kant\GitHub\msbuild-as-programming-language\6 - targets\obj\project.assets.json' != '')
    {
        ConvertToAbsolutePath(Paths: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json");
    }
    /*GetProjectReferencesFromAssetsFileTask(RestoreOutputAbsolutePath: "$(RestoreOutputAbsolutePath)", ProjectAssetsFileAbsolutePath: "$(ProjectAssetsFileAbsolutePath)");*/
    GetProjectReferencesFromAssetsFileTask(RestoreOutputAbsolutePath: "", ProjectAssetsFileAbsolutePath: "");
    /*MSBuild(SkipNonexistentTargets: "true", Targets: "_GetProjectVersion", Projects: "@(_ProjectReferencesFromAssetsFile)", Properties: "BuildProjectReferences=false;", SkipNonexistentProjects: "true");*/
    MSBuild(SkipNonexistentTargets: "true", Targets: "_GetProjectVersion", Projects: "", Properties: "BuildProjectReferences=false;", SkipNonexistentProjects: "true");
    
    _GetProjectReferenceVersionsRun = true;
}

void _GetProjectVersion()
{
    // DependsOnTargets;
    if (!Run) ();
    
    _GetProjectVersionRun = true;
}

void _WalkEachTargetPerFramework()
{
    
    /*MSBuild(Targets: "_GetBuildOutputFilesWithTfm", Projects: "$(MSBuildProjectFullPath)", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
    /* if ('$(IncludeBuildOutput)' == 'true')*/
    if ('true' == 'true')
    {
        MSBuild(Targets: "_GetBuildOutputFilesWithTfm", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
    }
    /*MSBuild(Targets: "_GetTfmSpecificContentForPackage", Projects: "$(MSBuildProjectFullPath)", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
    /* if ('$(TargetsForTfmSpecificContentInPackage)' != '')*/
    if (';PackTool;_PackProjectToolValidation' != '')
    {
        MSBuild(Targets: "_GetTfmSpecificContentForPackage", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
    }
    /*MSBuild(Targets: "_GetDebugSymbolsWithTfm", Projects: "$(MSBuildProjectFullPath)", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
    /* if ('$(IncludeBuildOutput)' == 'true')*/
    if ('true' == 'true')
    {
        MSBuild(Targets: "_GetDebugSymbolsWithTfm", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
    }
    /*MSBuild(Targets: "SourceFilesProjectOutputGroup", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
    /* if ('$(IncludeSource)' == 'true')*/
    if ('' == 'true')
    {
        MSBuild(Targets: "SourceFilesProjectOutputGroup", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");
    }
    /*MSBuild(Targets: "_GetFrameworkAssemblyReferences", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
    MSBuild(Targets: "_GetFrameworkAssemblyReferences", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");
    /*MSBuild(Targets: "_GetFrameworksWithSuppressedDependencies", Projects: "$(MSBuildProjectFullPath)", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
    MSBuild(Targets: "_GetFrameworksWithSuppressedDependencies", Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");
    
    _WalkEachTargetPerFrameworkRun = true;
}

void _GetFrameworksWithSuppressedDependencies()
{
    
    _GetFrameworksWithSuppressedDependenciesRun = true;
}

void _GetFrameworkAssemblyReferences()
{
    // DependsOnTargets;
    if (!ResolveReferencesRun) ResolveReferences();
    
    _GetFrameworkAssemblyReferencesRun = true;
}

void _GetBuildOutputFilesWithTfm()
{
    // DependsOnTargets;
    if (!BuiltProjectOutputGroupRun) BuiltProjectOutputGroup();
    if (!DocumentationProjectOutputGroupRun) DocumentationProjectOutputGroup();
    if (!SatelliteDllsProjectOutputGroupRun) SatelliteDllsProjectOutputGroup();
    if (!_AddPriFileToPackBuildOutputRun) _AddPriFileToPackBuildOutput();
    if (!Run) ();
    
    _GetBuildOutputFilesWithTfmRun = true;
}

void _GetTfmSpecificContentForPackage()
{
    // DependsOnTargets;
    if (!Run) ();
    if (!PackToolRun) PackTool();
    if (!_PackProjectToolValidationRun) _PackProjectToolValidation();
    
    _GetTfmSpecificContentForPackageRun = true;
}

void _GetDebugSymbolsWithTfm()
{
    // DependsOnTargets;
    if (!DebugSymbolsProjectOutputGroupRun) DebugSymbolsProjectOutputGroup();
    if (!Run) ();
    
    _GetDebugSymbolsWithTfmRun = true;
}

void _AddPriFileToPackBuildOutput()
{
    // DependsOnTargets;
    if (!Run) ();
    
    _AddPriFileToPackBuildOutputRun = true;
}

void _GetPackageFiles()
{
    // if ($(IncludeContentInPack) == 'true')
    if (true == 'true') { _GetPackageFilesRun = true; return; }
    
    _GetPackageFilesRun = true;
}

void _ContainerVerifySDKVersion()
{
    // if ('$(WebPublishMethod)' == 'Container' or '$(PublishProfile)' == 'DefaultContainer')
    if ('' == 'Container' or '' == 'DefaultContainer') { _ContainerVerifySDKVersionRun = true; return; }
    
    /*Error(Text: "The current .NET SDK ($(NETCoreSdkVersion)) doesn't support containerization. Please use version 7.0.100 or higher to enable containerization.", Code: "CONTAINER002");*/
    /* if ('$(_IsSDKContainerAllowedVersion)' != 'true')*/
    if ('true' != 'true')
    {
        Error(Text: "The current .NET SDK (8.0.200-preview.23624.5) doesn't support containerization. Please use version 7.0.100 or higher to enable containerization.", Code: "CONTAINER002");
    }
    
    _ContainerVerifySDKVersionRun = true;
}

void ComputeContainerBaseImage()
{
    
    /* if ('$(ContainerRuntimeIdentifier)' == '' and '$(IsRidAgnostic)' != 'true')*/
    if ('' == '' and 'false' != 'true')
    {
        ContainerRuntimeIdentifier = "$(RuntimeIdentifier)";
    }
    /* if ('$(ContainerRuntimeIdentifier)' == '')*/
    if ('' == '')
    {
        ContainerRuntimeIdentifier = "linux-$(NETCoreSdkPortableRuntimeIdentifier.Split('-')[1])";
    }
    /* if ('$(ContainerBaseImage)' == '')*/
    if ('' == '')
    {
        _ContainerIsUsingMicrosoftDefaultImages = "true";
    }
    /* if ('$(ContainerBaseImage)' != '')*/
    if ('' != '')
    {
        _ContainerIsUsingMicrosoftDefaultImages = "false";
    }
    /*ComputeDotnetBaseImageAndTag(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV).0", UsesInvariantGlobalization: "$(InvariantGlobalization)", IsAotPublished: "$(PublishAot)", FrameworkReferences: "@(FrameworkReference)", SdkVersion: "$(NetCoreSdkVersion)", ContainerFamily: "$(ContainerFamily)", IsSelfContained: "$(_ContainerIsSelfContained)", TargetRuntimeIdentifier: "$(ContainerRuntimeIdentifier)");*/
    /* if ($(_ContainerIsUsingMicrosoftDefaultImages))*/
    if ()
    {
        ComputeDotnetBaseImageAndTag(TargetFrameworkVersion: "8.0.0", UsesInvariantGlobalization: "", IsAotPublished: "", FrameworkReferences: "Microsoft.NETCore.App", SdkVersion: "8.0.200-preview.23624.5", ContainerFamily: "", IsSelfContained: "false", TargetRuntimeIdentifier: "");
    }
    
    ComputeContainerBaseImageRun = true;
}

void ComputeContainerConfig()
{
    // DependsOnTargets;
    if (!ComputeContainerBaseImageRun) ComputeContainerBaseImage();
    
    /* if ('$(RegistryUrl)' != '')*/
    if ('' != '')
    {
        ContainerRegistry = "$(RegistryUrl)";
    }
    /* if ('$(PublishImageTag)' != '')*/
    if ('' != '')
    {
        ContainerImageTag = "$(PublishImageTag)";
    }
    /* if ('$(AutoGenerateImageTag)' == 'true')*/
    if ('' == 'true')
    {
        ContainerImageTag = "$([System.DateTime]::UtcNow.ToString('yyyyMMddhhmmss'))";
    }
    /* if ('$(ContainerImageName)' != '')*/
    if ('' != '')
    {
        ContainerRepository = "$(ContainerImageName)";
    }
    /* if ('$(ContainerRepository)' == '')*/
    if ('' == '')
    {
        ContainerRepository = "$(AssemblyName)";
    }
    /* if ('$(ContainerImageTag)' == '' and '$(ContainerImageTags)' == '')*/
    if ('' == '' and '' == '')
    {
        ContainerImageTag = "latest";
    }
    /* if ('$(AutoGenerateImageTag)' == 'true' and '$(ContainerImageTags)' == '')*/
    if ('' == 'true' and '' == '')
    {
        ContainerImageTag = "$([System.DateTime]::UtcNow.ToString('yyyyMMddhhmmss'))";
    }
    _ContainerIsTargetingWindows = "false";
    /* if ($(ContainerRuntimeIdentifier.StartsWith('win')))*/
    if (False)
    {
        _ContainerIsTargetingWindows = "true";
    }
    /* if ('$(ContainerWorkingDirectory)' == '' and !$(_ContainerIsTargetingWindows) )*/
    if ('' == '' and ! )
    {
        ContainerWorkingDirectory = "/app";
    }
    /* if ('$(ContainerWorkingDirectory)' == '' and $(_ContainerIsTargetingWindows) )*/
    if ('' == '' and  )
    {
        ContainerWorkingDirectory = "C:\\app";
    }
    /* if ($(_ContainerIsUsingMicrosoftDefaultImages) and $(_ContainerIsTargetingNet8TFM) and '$(ContainerUser)' == '')*/
    if ( and true and '' == '')
    {
        /* if ($(_ContainerIsTargetingWindows))*/
        if ()
        {
            ContainerUser = "ContainerUser";
        }
    }
    /* if ('$(ContainerGenerateLabels)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabels = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageCreated)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageCreated = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageDescription)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageDescription = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageAuthors)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageAuthors = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageUrl)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageUrl = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageDocumentation)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageDocumentation = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageSource)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageSource = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageVersion)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageVersion = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageRevision)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageRevision = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageVendor)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageVendor = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageLicenses)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageLicenses = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageTitle)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageTitle = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageBaseDigest)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageBaseDigest = "true";
    }
    /* if ('$(ContainerGenerateLabelsImageBaseName)' == '')*/
    if ('' == '')
    {
        ContainerGenerateLabelsImageBaseName = "true";
    }
    /* if ('$(ContainerDescription)' == '' and '$(Description)' != '')*/
    if ('' == '' and '' != '')
    {
        ContainerDescription = "$(Description)";
    }
    /* if ('$(ContainerAuthors)' == '' and '$(Authors)' != '')*/
    if ('' == '' and '6 - targets' != '')
    {
        ContainerAuthors = "$(Authors)";
    }
    /* if ('$(ContainerInformationUrl)' == '' and '$(PackageProjectUrl)' != '')*/
    if ('' == '' and '' != '')
    {
        ContainerInformationUrl = "$(PackageProjectUrl)";
    }
    /* if ('$(ContainerDocumentationUrl)' == '' and '$(PackageProjectUrl)' != '')*/
    if ('' == '' and '' != '')
    {
        ContainerDocumentationUrl = "$(PackageProjectUrl)";
    }
    /* if ('$(ContainerVersion)' == '' and '$(PackageVersion)' != '')*/
    if ('' == '' and '1.0.0' != '')
    {
        ContainerVersion = "$(PackageVersion)";
    }
    /* if ('$(ContainerLicenseExpression)' == '' and '$(PackageLicenseExpression)' != '')*/
    if ('' == '' and '' != '')
    {
        ContainerLicenseExpression = "$(PackageLicenseExpression)";
    }
    /* if ('$(ContainerTitle)' == '' and '$(Title)' != '')*/
    if ('' == '' and '' != '')
    {
        ContainerTitle = "$(Title)";
    }
    /* if ('$(ContainerImageName)' != '')*/
    if ('' != '')
    {
        Warning(Text: "The property 'ContainerImageName' was set but is obsolete - please use 'ContainerRepository' instead.", Code: "CONTAINER003");
    }
    /*ParseContainerProperties(ContainerRepository: "$(ContainerRepository)", ContainerEnvironmentVariables: "@(ContainerEnvironmentVariable)", ContainerImageTags: "$(ContainerImageTags)", ContainerImageTag: "$(ContainerImageTag)", FullyQualifiedBaseImageName: "$(ContainerBaseImage)", ContainerRegistry: "$(ContainerRegistry)");*/
    ParseContainerProperties(ContainerRepository: "", ContainerEnvironmentVariables: "", ContainerImageTags: "", ContainerImageTag: "", FullyQualifiedBaseImageName: "", ContainerRegistry: "");
    
    ComputeContainerConfigRun = true;
}

void _CheckContainersPackage()
{
    
    ContainersPackageIdentity = "Microsoft.NET.Build.Containers";
    /* if ('@(ContainersPackage)' != '')*/
    if ('' != '')
    {
        EnableSdkContainerSupport = "true";
    }
    /* if ('@(ContainersPackage)' != '')*/
    if ('' != '')
    {
        Warning(Text: "Microsoft.NET.Build.Containers NuGet package is explicitly referenced. Consider removing the package reference to Microsoft.NET.Build.Containers as it is now part of .NET SDK.");
    }
    
    _CheckContainersPackageRun = true;
}

void PublishContainer()
{
    // if ('$(IsPublishable)' == 'true' AND '$(EnableSdkContainerSupport)' == 'true')
    if ('true' == 'true' AND '' == 'true') { PublishContainerRun = true; return; }
    // DependsOnTargets;
    if (!_ContainerVerifySDKVersionRun) _ContainerVerifySDKVersion();
    if (!ComputeContainerConfigRun) ComputeContainerConfig();
    if (!_CheckContainersPackageRun) _CheckContainersPackage();
    
    /* if ('$(DOTNET_HOST_PATH)' == '')*/
    if ('C:\Program Files\dotnet\dotnet.exe' == '')
    {
        DotNetHostDirectory = "$(NetCoreRoot)";
        DotNetHostFileName = "dotnet";
        /* if ('$(OS)' == 'Windows_NT')*/
        if ('Windows_NT' == 'Windows_NT')
        {
            DotNetHostFileName = "dotnet.exe";
        }
    }
    /*CreateNewImage(ToolPath: "$(DotNetHostDirectory)", Labels: "@(ContainerLabel)", DefaultArgs: "@(ContainerDefaultArgs)", ToolExe: "$(DotNetHostFileName)", AppCommand: "@(ContainerAppCommand)", ContainerRuntimeIdentifier: "$(ContainerRuntimeIdentifier)", Entrypoint: "@(ContainerEntrypoint)", RuntimeIdentifierGraphPath: "$(RuntimeIdentifierGraphPath)", ContainerUser: "$(ContainerUser)", EntrypointArgs: "@(ContainerEntrypointArgs)", BaseRegistry: "$(ContainerBaseRegistry)", ContainerEnvironmentVariables: "@(ContainerEnvironmentVariables)", ArchiveOutputPath: "$(ContainerArchiveOutputPath)", AppCommandArgs: "@(ContainerAppCommandArgs)", ExposedPorts: "@(ContainerPort)", PublishDirectory: "$(PublishDir)", BaseImageName: "$(ContainerBaseName)", ContainerizeDirectory: "$(ContainerizeFolder)", AppCommandInstruction: "$(ContainerAppCommandInstruction)", LocalRegistry: "$(LocalRegistry)", BaseImageTag: "$(ContainerBaseTag)", WorkingDirectory: "$(ContainerWorkingDirectory)", ImageTags: "@(ContainerImageTags)", Repository: "$(ContainerRepository)", OutputRegistry: "$(ContainerRegistry)");*/
    CreateNewImage(ToolPath: "", Labels: "", DefaultArgs: "", ToolExe: "", AppCommand: "", ContainerRuntimeIdentifier: "", Entrypoint: "", RuntimeIdentifierGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", ContainerUser: "", EntrypointArgs: "", BaseRegistry: "", ContainerEnvironmentVariables: "", ArchiveOutputPath: "", AppCommandArgs: "", ExposedPorts: "", PublishDirectory: "bin\\Debug\\net8.0\\publish\\", BaseImageName: "", ContainerizeDirectory: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Containers\\build\\..\\containerize\\", AppCommandInstruction: "", LocalRegistry: "", BaseImageTag: "", WorkingDirectory: "", ImageTags: "", Repository: "", OutputRegistry: "");
    
    PublishContainerRun = true;
}

Build();
