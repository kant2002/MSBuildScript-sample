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

void AfterSdkPublish()
{

	AfterSdkPublishRun = true;
}

void _CheckForUnsupportedTargetFramework()
{
	// if ('$(_UnsupportedTargetFrameworkError)' == 'true')
	if ('' == 'true') { _CheckForUnsupportedTargetFrameworkRun = true; return; }

	/*NETSdkError(FormatArguments: "$([MSBuild]::Escape('$(TargetFramework)'))", ResourceName: "CannotInferTargetFrameworkIdentifierAndVersion");*/
	/* if (!$(TargetFramework.Contains(';')))*/
	if (!False)
	{
		NETSdkError(FormatArguments: "net8.0", ResourceName: "CannotInferTargetFrameworkIdentifierAndVersion");
	}
	/*NETSdkError(FormatArguments: "$([MSBuild]::Escape('$(TargetFramework)'))", ResourceName: "TargetFrameworkWithSemicolon");*/
	/* if ($(TargetFramework.Contains(';')))*/
	if (False)
	{
		NETSdkError(FormatArguments: "net8.0", ResourceName: "TargetFrameworkWithSemicolon");
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

	/*NETSdkError(FormatArguments: "$(TargetPlatformIdentifier)", ResourceName: "UnsupportedTargetPlatformIdentifier");*/
	/* if ('$(TargetPlatformSupported)' != 'true' and '$(UseWorkloadsSpecificError)' != 'true')*/
	if ('' != 'true' and '' != 'true')
	{
		NETSdkError(FormatArguments: "", ResourceName: "UnsupportedTargetPlatformIdentifier");
	}
	/*NETSdkError(FormatArguments: "$(TargetPlatformIdentifier)", ResourceName: "UnsupportedTargetPlatformIdentifierWithWorkloadsDisabled");*/
	/* if ('$(TargetPlatformSupported)' != 'true' and '$(UseWorkloadsSpecificError)' == 'true')*/
	if ('' != 'true' and '' == 'true')
	{
		NETSdkError(FormatArguments: "", ResourceName: "UnsupportedTargetPlatformIdentifierWithWorkloadsDisabled");
	}

	_CheckForUnsupportedTargetPlatformIdentifierRun = true;
}

void _CollectTargetFrameworkForTelemetry()
{

	/*AllowEmptyTelemetry(EventName: "targetframeworkeval", EventData: "@(TFTelemetry)");*/
	AllowEmptyTelemetry(EventName: "targetframeworkeval", EventData: "");

	_CollectTargetFrameworkForTelemetryRun = true;
}

void _CheckForUnsupportedNETCoreVersion()
{
	// if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(NETCoreAppMaximumVersion)' != '')
	if ('.NETCoreApp' == '.NETCoreApp' And '8.0' != '') { _CheckForUnsupportedNETCoreVersionRun = true; return; }

	/*NETSdkError(FormatArguments: ".NET;$(_TargetFrameworkVersionWithoutV);$(NETCoreAppMaximumVersion)", ResourceName: "UnsupportedTargetFrameworkVersion");*/
	/* if ('$(_TargetFrameworkVersionWithoutV)' > '$(NETCoreAppMaximumVersion)' and '$(DisplayVSMessage)' != 'true')*/
	if ('8.0' > '8.0' and '' != 'true')
	{
		NETSdkError(FormatArguments: ".NET;8.0;8.0", ResourceName: "UnsupportedTargetFrameworkVersion");
	}
	/*NETSdkError(FormatArguments: ".NET;$(_TargetFrameworkVersionWithoutV);$(NETCoreAppMaximumVersion);$(MinimumVisualStudioVersionForUnsupportedTargetFrameworkVersion)", ResourceName: "UnsupportedVisualStudioVersion");*/
	/* if ('$(DisplayVSMessage)' == 'true')*/
	if ('' == 'true')
	{
		NETSdkError(FormatArguments: ".NET;8.0;8.0;17.8", ResourceName: "UnsupportedVisualStudioVersion");
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

	/*NETSdkError(FormatArguments: ".NET Standard;$(_TargetFrameworkVersionWithoutV);$(NETStandardMaximumVersion)", ResourceName: "UnsupportedTargetFrameworkVersion");*/
	/* if ('$(_TargetFrameworkVersionWithoutV)' > '$(NETStandardMaximumVersion)')*/
	if ('8.0' > '')
	{
		NETSdkError(FormatArguments: ".NET Standard;8.0;", ResourceName: "UnsupportedTargetFrameworkVersion");
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

	/*NETSdkError(FormatArguments: "$(SupportedOSPlatformVersion);$(TargetPlatformVersion)", ResourceName: "CannotHaveSupportedOSPlatformVersionHigherThanTargetPlatformVersion");*/
	/* if ('$(SupportedOSPlatformVersion)' != '' and $(TargetPlatformVersion) != '' and $([MSBuild]::VersionGreaterThan($(SupportedOSPlatformVersion), $(TargetPlatformVersion))))*/
	if ('$(SupportedOSPlatformVersion)' != '' and $(TargetPlatformVersion) != '' and $([MSBuild]::VersionGreaterThan($(SupportedOSPlatformVersion), $(TargetPlatformVersion))))
	{
		NETSdkError(FormatArguments: ";", ResourceName: "CannotHaveSupportedOSPlatformVersionHigherThanTargetPlatformVersion");
	}

	_CheckForSupportedOSPlatformVersionHigherThanTargetPlatformVersionRun = true;
}

void _NormalizeTargetPlatformVersion()
{
	// if ('$(TargetPlatformVersion)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) and ('$(Language)' != 'C++' or '$(_EnablePackageReferencesInVCProjects)' == 'true'))
	if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True and ('C#' != 'C++' or '' == 'true')) { _NormalizeTargetPlatformVersionRun = true; return; }

	_NormalizeTargetPlatformVersionRun = true;
}

void _CheckForInvalidTargetPlatformVersion()
{
	// if ('$(TargetPlatformVersion)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) and ('$(Language)' != 'C++' or '$(_EnablePackageReferencesInVCProjects)' == 'true'))
	if ('' != '' and '.NETCoreApp' == '.NETCoreApp' and True and ('C#' != 'C++' or '' == 'true')) { _CheckForInvalidTargetPlatformVersionRun = true; return; }
	// DependsOnTargets;
	if (!_NormalizeTargetPlatformVersionRun) _NormalizeTargetPlatformVersion();

	/*NetSdkError(FormatArguments: "$(TargetPlatformVersion);$(TargetPlatformIdentifier);$(_ValidTargetPlatformVersions)", ResourceName: "InvalidTargetPlatformVersion");*/
	/* if ('$(TargetPlatformVersionSupported)' != 'true')*/
	if ('' != 'true')
	{
		NetSdkError(FormatArguments: ";;", ResourceName: "InvalidTargetPlatformVersion");
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

	/*ShowMissingWorkloads(MissingWorkloadPacks: "@(MissingWorkloadPack)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", NetCoreRoot: "$(NetCoreRoot)", GenerateErrorsForMissingWorkloads: "false");*/
	ShowMissingWorkloads(MissingWorkloadPacks: "", NETCoreSdkVersion: "8.0.200-preview.23624.5", NetCoreRoot: "C:\\Program Files\\dotnet\\", GenerateErrorsForMissingWorkloads: "false");

	GetSuggestedWorkloadsRun = true;
}

void _CheckForMissingWorkload()
{
	// if ('@(MissingWorkloadPack)' != '' And '$(DesignTimeBuild)' != 'true')
	if ('' != '' And '' != 'true') { _CheckForMissingWorkloadRun = true; return; }

	/*ShowMissingWorkloads(MissingWorkloadPacks: "@(MissingWorkloadPack)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", NetCoreRoot: "$(NetCoreRoot)", GenerateErrorsForMissingWorkloads: "true");*/
	ShowMissingWorkloads(MissingWorkloadPacks: "", NETCoreSdkVersion: "8.0.200-preview.23624.5", NetCoreRoot: "C:\\Program Files\\dotnet\\", GenerateErrorsForMissingWorkloads: "true");

	_CheckForMissingWorkloadRun = true;
}

void _GetRequiredWorkloads()
{
	// DependsOnTargets;
	if (!GetSuggestedWorkloadsRun) GetSuggestedWorkloads();
	if (!PrepareProjectReferencesRun) PrepareProjectReferences();

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences);TargetFramework;TargetFrameworks", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "_GetRequiredWorkloads", BuildInParallel: "$(BuildInParallel)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
	if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;TargetFrameworks", Projects: "", Targets: "_GetRequiredWorkloads", BuildInParallel: "true");
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
		NETSdkError(FormatArguments: "SelfContained", ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed");
	}
	/* if ('$(PublishReadyToRun)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true')*/
	if ('' == 'true' and '' == '' and '' == 'true')
	{
		NETSdkError(FormatArguments: "PublishReadyToRun", ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed");
	}
	/* if ('$(PublishSingleFile)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true')*/
	if ('' == 'true' and '' == '' and '' == 'true')
	{
		NETSdkError(FormatArguments: "PublishSingleFile", ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed");
	}
	/* if ('$(PublishAot)' == 'true' and '$(RuntimeIdentifier)' == '' and '$(_IsPublishing)' == 'true' and '$(AllowPublishAotWithoutRuntimeIdentifier)' != 'true')*/
	if ('' == 'true' and '' == '' and '' == 'true' and '' != 'true')
	{
		NETSdkError(FormatArguments: "PublishAot", ResourceName: "ImplicitRuntimeIdentifierResolutionForPublishPropertyFailed");
	}
	/*NETSdkError(FormatArguments: "$(PublishSelfContained)", ResourceName: "PublishSelfContainedMustBeBool");*/
	/* if ('$(PublishSelfContained)' != 'true' and '$(PublishSelfContained)' != 'false' and '$(PublishSelfContained)' != '')*/
	if ('' != 'true' and '' != 'false' and '' != '')
	{
		NETSdkError(FormatArguments: "", ResourceName: "PublishSelfContainedMustBeBool");
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

	/*NETSdkError(FormatArguments: "$(RuntimeIdentifier);$(PlatformTarget)", ResourceName: "CannotHaveRuntimeIdentifierPlatformMismatchPlatformTarget");*/
	/* if ('$(PlatformTarget)' != 'AnyCPU' and !$(RuntimeIdentifier.ToUpperInvariant().Contains($(PlatformTarget.ToUpperInvariant()))))*/
	if ('' != 'AnyCPU' and !True)
	{
		NETSdkError(FormatArguments: ";", ResourceName: "CannotHaveRuntimeIdentifierPlatformMismatchPlatformTarget");
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

	/*NETSdkWarning(FormatArguments: "$(TargetFramework.ToLowerInvariant());https://aka.ms/dotnet-core-support", ResourceName: "TargetFrameworkIsEol");*/
	NETSdkWarning(FormatArguments: "net8.0;https://aka.ms/dotnet-core-support", ResourceName: "TargetFrameworkIsEol");

	_CheckForEolTargetFrameworksRun = true;
}

void _CheckForEolWorkloads()
{
	// if ('@(EolWorkload)' != '' and '$(CheckEolWorkloads)' == 'true')
	if ('' != '' and 'true' == 'true') { _CheckForEolWorkloadsRun = true; return; }

	/*NETSdkWarning(FormatArguments: "%(EolWorkload.Identity);$([MSBuild]::ValueOrDefault('%(EolWorkload.Url)', 'https://aka.ms/dotnet-core-support'))", ResourceName: "WorkloadIsEol");*/
	NETSdkWarning(FormatArguments: "%(EolWorkload.Identity);%(EolWorkload.Url)", ResourceName: "WorkloadIsEol");

	_CheckForEolWorkloadsRun = true;
}

void GenerateTargetPlatformDefineConstants()
{
	// if ( '$(DisableImplicitFrameworkDefines)' != 'true' and '$(TargetPlatformIdentifier)' != '' and '$(TargetFrameworkIdentifier)' == '.NETCoreApp' and $([MSBuild]::VersionGreaterThanOrEquals($(TargetFrameworkVersion), 5.0)) )
	if ( '' != 'true' and '' != '' and '.NETCoreApp' == '.NETCoreApp' and True ) { GenerateTargetPlatformDefineConstantsRun = true; return; }

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

	AddImplicitDefineConstantsRun = true;
}

void CreateManifestResourceNames()
{
	// if ('@(EmbeddedResource)' != '')
	if ('' != '') { CreateManifestResourceNamesRun = true; return; }
	// DependsOnTargets;
	if (!Run) ();

	/*CreateCSharpManifestResourceName(UseDependentUponConvention: "$(EmbeddedResourceUseDependentUponConvention)", ResourceFiles: "@(EmbeddedResource)", RootNamespace: "$(RootNamespace)");*/
	/* if ('%(EmbeddedResource.ManifestResourceName)' == '' and ('%(EmbeddedResource.WithCulture)' == 'false' or '%(EmbeddedResource.Type)' == 'Resx'))*/
	if ('%(EmbeddedResource.ManifestResourceName)' == '' and ('%(EmbeddedResource.WithCulture)' == 'false' or '%(EmbeddedResource.Type)' == 'Resx'))
	{
		CreateCSharpManifestResourceName(UseDependentUponConvention: "true", ResourceFiles: "", RootNamespace: "_6___targets");
	}
	/*CreateCSharpManifestResourceName(UseDependentUponConvention: "$(EmbeddedResourceUseDependentUponConvention)", PrependCultureAsDirectory: "false", ResourceFiles: "@(EmbeddedResource)", RootNamespace: "$(RootNamespace)");*/
	/* if ('%(EmbeddedResource.ManifestResourceName)' == '' and '%(EmbeddedResource.WithCulture)' == 'true' and '%(EmbeddedResource.Type)' == 'Non-Resx')*/
	if ('%(EmbeddedResource.ManifestResourceName)' == '' and '%(EmbeddedResource.WithCulture)' == 'true' and '%(EmbeddedResource.Type)' == 'Non-Resx')
	{
		CreateCSharpManifestResourceName(UseDependentUponConvention: "true", PrependCultureAsDirectory: "false", ResourceFiles: "", RootNamespace: "_6___targets");
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

	/*Csc(DefineConstants: "$(DefineConstants)", LangVersion: "$(LangVersion)", Prefer32Bit: "$(Prefer32Bit)", Nullable: "$(Nullable)", OutputAssembly: "@(XamlIntermediateAssembly)", ResponseFiles: "$(CompilerResponseFile)", FileAlignment: "$(FileAlignment)", Win32Resource: "$(Win32Resource)", EmitDebugInformation: "$(DebugSymbols)", ToolPath: "$(CscToolPath)", VsSessionGuid: "$(VsSessionGuid)", ReportAnalyzer: "$(ReportAnalyzer)", PreferredUILang: "$(PreferredUILang)", ErrorEndLocation: "$(ErrorEndLocation)", AdditionalLibPaths: "$(AdditionalLibPaths)", GenerateFullPaths: "$(GenerateFullPaths)", CodeAnalysisRuleSet: "$(ResolvedCodeAnalysisRuleSet)", NoConfig: "true", TargetType: "$(OutputType)", KeyFile: "$(KeyOriginatorFile)", NoStandardLib: "$(NoCompilerStandardLib)", AdditionalFiles: "@(AdditionalFiles)", Win32Icon: "$(ApplicationIcon)", MainEntryPoint: "$(StartupObject)", NoWin32Manifest: "$(NoWin32Manifest)", BaseAddress: "$(BaseAddress)", KeyContainer: "$(KeyContainerName)", DisabledWarnings: "$(NoWarn)", Resources: "@(_CoreCompileResourceInputs);@(CompiledLicenseFile)", AddModules: "@(AddModules)", ToolExe: "$(CscToolExe)", ErrorLog: "$(ErrorLog)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ModuleAssemblyName: "$(ModuleAssemblyName)", Platform: "$(PlatformTarget)", DebugType: "$(DebugType)", Analyzers: "@(Analyzer)", Utf8Output: "$(Utf8Output)", Optimize: "$(Optimize)", CheckForOverflowUnderflow: "$(CheckForOverflowUnderflow)", DelaySign: "$(DelaySign)", NoLogo: "$(NoLogo)", AllowUnsafeBlocks: "$(AllowUnsafeBlocks)", LinkResources: "@(LinkResource)", PdbFile: "$(PdbFile)", UseHostCompilerIfAvailable: "$(UseHostCompilerIfAvailable)", WarningsAsErrors: "$(WarningsAsErrors)", HighEntropyVA: "$(HighEntropyVA)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", SubsystemVersion: "$(SubsystemVersion)", UseSharedCompilation: "$(UseSharedCompilation)", Win32Manifest: "$(Win32Manifest)", WarningLevel: "$(WarningLevel)", ErrorReport: "$(ErrorReport)", EnvironmentVariables: "$(CscEnvironment)", DocumentationFile: "@(DocFileItem)", ApplicationConfiguration: "$(AppConfigForCompiler)", Sources: "@(Compile)", AnalyzerConfigFiles: "@(EditorConfigFiles)", References: "@(ReferencePath)", CodePage: "$(CodePage)", SkipAnalyzers: "true");*/
	/* if ( '%(_CoreCompileResourceInputs.WithCulture)' != 'true' )*/
	if ( '%(_CoreCompileResourceInputs.WithCulture)' != 'true' )
	{
		Csc(DefineConstants: "TRACE;DEBUG;NET;NET8_0;NETCOREAPP", LangVersion: "12.0", Prefer32Bit: "false", Nullable: "enable", OutputAssembly: "", ResponseFiles: "", FileAlignment: "512", Win32Resource: "", EmitDebugInformation: "true", ToolPath: "", VsSessionGuid: "", ReportAnalyzer: "", PreferredUILang: "", ErrorEndLocation: "", AdditionalLibPaths: "", GenerateFullPaths: "true", CodeAnalysisRuleSet: "", NoConfig: "true", TargetType: "Exe", KeyFile: "", NoStandardLib: "true", AdditionalFiles: "", Win32Icon: "", MainEntryPoint: "", NoWin32Manifest: "", BaseAddress: "", KeyContainer: "", DisabledWarnings: "1701;1702", Resources: ";", AddModules: "", ToolExe: "", ErrorLog: "", WarningsNotAsErrors: "", ModuleAssemblyName: "", Platform: "", DebugType: "portable", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", Utf8Output: "true", Optimize: "false", CheckForOverflowUnderflow: "false", DelaySign: "", NoLogo: "", AllowUnsafeBlocks: "false", LinkResources: "", PdbFile: "", UseHostCompilerIfAvailable: "true", WarningsAsErrors: ";NU1605;SYSLIB0011", HighEntropyVA: "true", TreatWarningsAsErrors: "false", SubsystemVersion: "", UseSharedCompilation: "", Win32Manifest: "", WarningLevel: "8", ErrorReport: "prompt", EnvironmentVariables: "", DocumentationFile: "", ApplicationConfiguration: "", Sources: "Program.cs", AnalyzerConfigFiles: "", References: "", CodePage: "", SkipAnalyzers: "true");
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

	_BeforeVBCSCoreCompileRun = true;
}

void _ComputeSkipAnalyzers()
{

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

	/*Touch(Files: "$(_LastBuildWithSkipAnalyzers)", AlwaysCreate: "true");*/
	Touch(Files: "", AlwaysCreate: "true");

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

	GenerateMSBuildEditorConfigFileShouldRunRun = true;
}

void GenerateMSBuildEditorConfigFileCore()
{
	// if ('$(_GeneratedEditorConfigShouldRun)' == 'true')
	if ('' == 'true') { GenerateMSBuildEditorConfigFileCoreRun = true; return; }

	/*GenerateMSBuildEditorConfig(MetadataItems: "@(_GeneratedEditorConfigMetadata)", PropertyItems: "@(_GeneratedEditorConfigProperty)", FileName: "$(GeneratedMSBuildEditorConfigFile)");*/
	GenerateMSBuildEditorConfig(MetadataItems: "", PropertyItems: "", FileName: "");

	GenerateMSBuildEditorConfigFileCoreRun = true;
}

void InitializeSourceRootMappedPaths()
{
	// DependsOnTargets;
	if (!_InitializeSourceRootMappedPathsFromSourceControlRun) _InitializeSourceRootMappedPathsFromSourceControl();

	/*Microsoft.CodeAnalysis.BuildTasks.MapSourceRoots(SourceRoots: "@(SourceRoot)", Deterministic: "$(DeterministicSourcePaths)");*/
	Microsoft.CodeAnalysis.BuildTasks.MapSourceRoots(SourceRoots: "", Deterministic: "");

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

	/*Csc(DefineConstants: "$(DefineConstants)", LangVersion: "$(LangVersion)", EmbedAllSources: "$(EmbedAllSources)", Prefer32Bit: "$(Prefer32Bit)", Nullable: "$(Nullable)", OutputAssembly: "@(IntermediateAssembly)", SourceLink: "$(SourceLink)", ResponseFiles: "$(CompilerResponseFile)", FileAlignment: "$(FileAlignment)", Win32Resource: "$(Win32Resource)", EmitDebugInformation: "$(DebugSymbols)", ToolPath: "$(CscToolPath)", VsSessionGuid: "$(VsSessionGuid)", ReportAnalyzer: "$(ReportAnalyzer)", PreferredUILang: "$(PreferredUILang)", ProvideCommandLineArgs: "$(ProvideCommandLineArgs)", RefOnly: "$(ProduceOnlyReferenceAssembly)", ErrorEndLocation: "$(ErrorEndLocation)", AdditionalLibPaths: "$(AdditionalLibPaths)", GenerateFullPaths: "$(GenerateFullPaths)", CodeAnalysisRuleSet: "$(ResolvedCodeAnalysisRuleSet)", NoConfig: "true", Features: "$(Features)", TargetType: "$(OutputType)", KeyFile: "$(KeyOriginatorFile)", NoStandardLib: "$(NoCompilerStandardLib)", RuntimeMetadataVersion: "$(RuntimeMetadataVersion)", OutputRefAssembly: "@(IntermediateRefAssembly)", AdditionalFiles: "@(AdditionalFiles)", Win32Icon: "$(ApplicationIcon)", MainEntryPoint: "$(StartupObject)", NoWin32Manifest: "$(NoWin32Manifest)", GeneratedFilesOutputPath: "$(CompilerGeneratedFilesOutputPath)", BaseAddress: "$(BaseAddress)", KeyContainer: "$(KeyContainerName)", DisabledWarnings: "$(NoWarn)", DisableSdkPath: "$(DisableSdkPath)", Resources: "@(_CoreCompileResourceInputs);@(CompiledLicenseFile)", AddModules: "@(AddModules)", ToolExe: "$(CscToolExe)", ErrorLog: "$(ErrorLog)", EmbeddedFiles: "@(EmbeddedFiles)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", ModuleAssemblyName: "$(ModuleAssemblyName)", Platform: "$(PlatformTarget)", Deterministic: "$(Deterministic)", DebugType: "$(DebugType)", Analyzers: "@(Analyzer)", Utf8Output: "$(Utf8Output)", Optimize: "$(Optimize)", InterceptorsPreviewNamespaces: "$(InterceptorsPreviewNamespaces)", CheckForOverflowUnderflow: "$(CheckForOverflowUnderflow)", DelaySign: "$(DelaySign)", ChecksumAlgorithm: "$(ChecksumAlgorithm)", PublicSign: "$(PublicSign)", NoLogo: "$(NoLogo)", ReportIVTs: "$(ReportIVTs)", AllowUnsafeBlocks: "$(AllowUnsafeBlocks)", PathMap: "$(PathMap)", LinkResources: "@(LinkResource)", SkipCompilerExecution: "$(SkipCompilerExecution)", PdbFile: "$(PdbFile)", UseHostCompilerIfAvailable: "$(UseHostCompilerIfAvailable)", WarningsAsErrors: "$(WarningsAsErrors)", HighEntropyVA: "$(HighEntropyVA)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", SubsystemVersion: "$(SubsystemVersion)", UseSharedCompilation: "$(UseSharedCompilation)", Win32Manifest: "$(Win32Manifest)", Instrument: "$(Instrument)", WarningLevel: "$(WarningLevel)", ErrorReport: "$(ErrorReport)", EnvironmentVariables: "$(CscEnvironment)", SharedCompilationId: "$(SharedCompilationId)", DocumentationFile: "@(DocFileItem)", ApplicationConfiguration: "$(AppConfigForCompiler)", Sources: "@(Compile)", AnalyzerConfigFiles: "@(EditorConfigFiles)", References: "@(ReferencePathWithRefAssemblies)", CodePage: "$(CodePage)", SkipAnalyzers: "$(_SkipAnalyzers)");*/
	/* if ('%(_CoreCompileResourceInputs.WithCulture)' != 'true')*/
	if ('%(_CoreCompileResourceInputs.WithCulture)' != 'true')
	{
		Csc(DefineConstants: "TRACE;DEBUG;NET;NET8_0;NETCOREAPP", LangVersion: "12.0", EmbedAllSources: "", Prefer32Bit: "false", Nullable: "enable", OutputAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", SourceLink: "", ResponseFiles: "", FileAlignment: "512", Win32Resource: "", EmitDebugInformation: "true", ToolPath: "", VsSessionGuid: "", ReportAnalyzer: "", PreferredUILang: "", ProvideCommandLineArgs: "", RefOnly: "", ErrorEndLocation: "", AdditionalLibPaths: "", GenerateFullPaths: "true", CodeAnalysisRuleSet: "", NoConfig: "true", Features: "", TargetType: "Exe", KeyFile: "", NoStandardLib: "true", RuntimeMetadataVersion: "", OutputRefAssembly: "obj\\Debug\\net8.0\\refint\\6 - targets.dll", AdditionalFiles: "", Win32Icon: "", MainEntryPoint: "", NoWin32Manifest: "", GeneratedFilesOutputPath: "", BaseAddress: "", KeyContainer: "", DisabledWarnings: "1701;1702", DisableSdkPath: "", Resources: ";", AddModules: "", ToolExe: "", ErrorLog: "", EmbeddedFiles: "", WarningsNotAsErrors: "", ModuleAssemblyName: "", Platform: "", Deterministic: "true", DebugType: "portable", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", Utf8Output: "true", Optimize: "false", InterceptorsPreviewNamespaces: "", CheckForOverflowUnderflow: "false", DelaySign: "", ChecksumAlgorithm: "", PublicSign: "", NoLogo: "", ReportIVTs: "", AllowUnsafeBlocks: "false", PathMap: "", LinkResources: "", SkipCompilerExecution: "", PdbFile: "", UseHostCompilerIfAvailable: "true", WarningsAsErrors: ";NU1605;SYSLIB0011", HighEntropyVA: "true", TreatWarningsAsErrors: "false", SubsystemVersion: "", UseSharedCompilation: "", Win32Manifest: "", Instrument: "", WarningLevel: "8", ErrorReport: "prompt", EnvironmentVariables: "", SharedCompilationId: "", DocumentationFile: "", ApplicationConfiguration: "", Sources: "Program.cs", AnalyzerConfigFiles: "", References: "", CodePage: "", SkipAnalyzers: "");
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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "BuildGenerateSources", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework);");*/
	/* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != '' and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
	if ('' == 'true' and '' != '' and '' != '' and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "BuildGenerateSources", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework);");
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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "BuildCompile", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
	if ('' == 'true' and '' != '' and '' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "BuildCompile", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "BuildLink", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('$(BuildPassReferences)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '@(_MSBuildProjectReferenceExistent)' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')*/
	if ('' == 'true' and '' != '' and '' != ''  and '%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "BuildLink", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
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

	/*Exec(WorkingDirectory: "$(RunWorkingDirectory)", Command: "$(RunCommand) $(RunArguments)");*/
	Exec(WorkingDirectory: "", Command: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.exe ");

	RunRun = true;
}

void BuildOnlySettings()
{

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

	/*FindAppConfigFile(PrimaryList: "@(None)", TargetPath: "$(TargetFileName).config", SecondaryList: "@(Content)");*/
	/* if ('$(AppConfig)'=='')*/
	if (''=='')
	{
		FindAppConfigFile(PrimaryList: "", TargetPath: "6 - targets.dll.config", SecondaryList: "");
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

	/*Exec(WorkingDirectory: "$(OutDir)", Command: "$(PreBuildEvent)");*/
	Exec(WorkingDirectory: "bin\\Debug\\net8.0\\", Command: "");

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

	/*AssignProjectConfiguration(OutputType: "$(OutputType)", AddSyntheticProjectReferencesForSolutionDependencies: "$(AddSyntheticProjectReferencesForSolutionDependencies)", CurrentProjectPlatform: "$(Platform)", SolutionConfigurationContents: "$(CurrentSolutionConfigurationContents)", OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration: "$(OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration)", DefaultToVcxPlatformMapping: "$(DefaultToVcxPlatformMapping)", ResolveConfigurationPlatformUsingMappings: "false", ShouldUnsetParentConfigurationAndPlatform: "$(ShouldUnsetParentConfigurationAndPlatform)", ProjectReferences: "@(ProjectReference)", CurrentProjectConfiguration: "$(Configuration)", CurrentProject: "$(MSBuildProjectFullPath)", VcxToDefaultPlatformMapping: "$(VcxToDefaultPlatformMapping)");*/
	AssignProjectConfiguration(OutputType: "Exe", AddSyntheticProjectReferencesForSolutionDependencies: "", CurrentProjectPlatform: "AnyCPU", SolutionConfigurationContents: "", OnlyReferenceAndBuildProjectsEnabledInSolutionConfiguration: "", DefaultToVcxPlatformMapping: "", ResolveConfigurationPlatformUsingMappings: "false", ShouldUnsetParentConfigurationAndPlatform: "", ProjectReferences: "", CurrentProjectConfiguration: "Debug", CurrentProject: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", VcxToDefaultPlatformMapping: "");

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

	/*GetCompatiblePlatform(CurrentProjectPlatform: "$(Platform)", PlatformLookupTable: "$(PlatformLookupTable)", AnnotatedProjects: "@(_ProjectReferencePlatformPossibilities)");*/
	/* if ('@(_ProjectReferencePlatformPossibilities)' != '')*/
	if ('' != '')
	{
		GetCompatiblePlatform(CurrentProjectPlatform: "AnyCPU", PlatformLookupTable: "", AnnotatedProjects: "");
	}

	_GetProjectReferencePlatformPropertiesRun = true;
}

void _GetProjectReferenceTargetFrameworkProperties()
{
	// DependsOnTargets;
	if (!_AddOutputPathToGlobalPropertiesToRemoveRun) _AddOutputPathToGlobalPropertiesToRemove();

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetTargetFrameworks", SkipNonexistentTargets: "true", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '$(EnableDynamicPlatformResolution)' != 'true')*/
	if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '' != 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;", Projects: "", Targets: "GetTargetFrameworks", SkipNonexistentTargets: "true", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform)");
	}
	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;Platform;Configuration;$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetTargetFrameworks", SkipNonexistentTargets: "true", BuildInParallel: "$(BuildInParallel)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '$(EnableDynamicPlatformResolution)' == 'true')*/
	if ('%(_MSBuildProjectReferenceExistent.SkipGetTargetFrameworkProperties)' != 'true' and '' == 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove);TargetFramework;RuntimeIdentifier;SelfContained;Platform;Configuration;", Projects: "", Targets: "GetTargetFrameworks", SkipNonexistentTargets: "true", BuildInParallel: "true");
	}
	/*GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "$(MSBuildProjectName)", FallbackTargetFrameworks: "$(AssetTargetFallback)", CurrentProjectTargetFramework: "$(ReferringTargetFrameworkForProjectReferences)", AnnotatedProjectReferences: "@(_ProjectReferenceTargetFrameworkPossibilities)", CurrentProjectTargetPlatform: "$(TargetPlatformMoniker)");*/
	/* if ('@(_ProjectReferenceTargetFrameworkPossibilities)' != '' and '$(ReferringTargetFrameworkForProjectReferences)' != ''
                                                        And '$(GetReferenceNearestTargetFrameworkTaskSupportsTargetPlatformParameter)' == 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')*/
	if ('' != '' and '' != ''
                                                        And 'true' == 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')
	{
		GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "6 - targets", FallbackTargetFrameworks: ";net461;net462;net47;net471;net472;net48;net481", CurrentProjectTargetFramework: "", AnnotatedProjectReferences: "", CurrentProjectTargetPlatform: "");
	}
	/*GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "$(MSBuildProjectName)", FallbackTargetFrameworks: "$(AssetTargetFallback)", CurrentProjectTargetFramework: "$(ReferringTargetFrameworkForProjectReferences)", AnnotatedProjectReferences: "@(_ProjectReferenceTargetFrameworkPossibilities)");*/
	/* if ('@(_ProjectReferenceTargetFrameworkPossibilities)' != '' and '$(ReferringTargetFrameworkForProjectReferences)' != ''
                                                        And '$(GetReferenceNearestTargetFrameworkTaskSupportsTargetPlatformParameter)' != 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')*/
	if ('' != '' and '' != ''
                                                        And 'true' != 'true' and '%(_ProjectReferenceTargetFrameworkPossibilities.IsVcxOrNativeProj)' != 'true')
	{
		GetReferenceNearestTargetFrameworkTask(CurrentProjectName: "6 - targets", FallbackTargetFrameworks: ";net461;net462;net47;net471;net472;net48;net481", CurrentProjectTargetFramework: "", AnnotatedProjectReferences: "");
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

	/*CombineTargetFrameworkInfoProperties(PropertiesAndValues: "@(_AdditionalTargetFrameworkInfoPropertyWithValue)", UseAttributeForTargetFrameworkInfoPropertyNames: "$(_UseAttributeForTargetFrameworkInfoPropertyNames)", RootElementName: "$(TargetFramework)");*/
	CombineTargetFrameworkInfoProperties(PropertiesAndValues: "", UseAttributeForTargetFrameworkInfoPropertyNames: "true", RootElementName: "net8.0");

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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetTargetPath", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and ('$(BuildingInsideVisualStudio)' == 'true' or '$(BuildProjectReferences)' != 'true') and '$(VisualStudioVersion)' != '10.0' and '@(_MSBuildProjectReferenceExistent)' != '')*/
	if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and ('' == 'true' or 'true' != 'true') and '17.0' != '10.0' and '' != '')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "GetTargetPath", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
	}
	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "%(_MSBuildProjectReferenceExistent.Targets)", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform);  %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '$(BuildingInsideVisualStudio)' != 'true' and '$(BuildProjectReferences)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
	if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and '' != 'true' and 'true' == 'true' and '' != '')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "%(_MSBuildProjectReferenceExistent.Targets)", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform);  %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
	}
	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetNativeManifest", SkipNonexistentTargets: "true", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '@(ProjectReferenceWithConfiguration)' != '' and '$(BuildingProject)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
	if ('%(_MSBuildProjectReferenceExistent.BuildReference)' == 'true' and '' != '' and 'false' == 'true' and '' != '')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "GetNativeManifest", SkipNonexistentTargets: "true", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
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

	/*ResolveAssemblyReference(StateFile: "$(ResolveAssemblyReferencesStateFile)", TargetFrameworkDirectories: "@(_ReferenceInstalledAssemblyDirectory)", AllowedRelatedFileExtensions: "$(AllowedReferenceRelatedFileExtensions)", AssemblyInformationCacheOutputPath: "$(AssemblyInformationCacheOutputPath)", AppConfigFile: "@(_ResolveAssemblyReferencesApplicationConfigFileForExes)", FullTargetFrameworkSubsetNames: "$(FullReferenceAssemblyNames)", OutputUnresolvedAssemblyConflicts: "$(ResolveAssemblyReferenceOutputUnresolvedAssemblyConflicts)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", ResolvedSDKReferences: "@(ResolvedSDKReference)", AssemblyInformationCachePaths: "$(AssemblyInformationCachePaths)", Silent: "$(ResolveAssemblyReferencesSilent)", WarnOrErrorOnTargetArchitectureMismatch: "$(ResolveAssemblyWarnOrErrorOnTargetArchitectureMismatch)", IgnoreTargetFrameworkAttributeVersionMismatch: "$(ResolveAssemblyReferenceIgnoreTargetFrameworkAttributeVersionMismatch)", IgnoreDefaultInstalledAssemblyTables: "$(IgnoreDefaultInstalledAssemblyTables)", IgnoreVersionForFrameworkReferences: "$(IgnoreVersionForFrameworkReferences)", TargetFrameworkMonikerDisplayName: "$(TargetFrameworkMonikerDisplayName)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", FindSatellites: "$(ResolveAssemblyReferencesFindRelatedSatellites)", CopyLocalDependenciesWhenParentReferenceInGac: "$(CopyLocalDependenciesWhenParentReferenceInGac)", InstalledAssemblySubsetTables: "@(InstalledAssemblySubsetTables)", Assemblies: "@(Reference)", TargetFrameworkSubsets: "@(_ReferenceInstalledAssemblySubsets)", AutoUnify: "$(AutoUnifyAssemblyReferences)", FindDependenciesOfExternallyResolvedReferences: "$(FindDependenciesOfExternallyResolvedReferences)", FullFrameworkFolders: "$(_FullFrameworkReferenceAssemblyPaths)", DoNotCopyLocalIfInGac: "$(DoNotCopyLocalIfInGac)", FindDependencies: "$(_FindDependencies)", AllowedAssemblyExtensions: "$(AllowedReferenceAssemblyFileExtensions)", AssemblyFiles: "@(_ResolvedProjectReferencePaths);@(_ExplicitReference)", CandidateAssemblyFiles: "@(Content);@(None)", FullFrameworkAssemblyTables: "@(FullFrameworkAssemblyTables)", SupportsBindingRedirectGeneration: "$(GenerateBindingRedirectsOutputType)", IgnoreDefaultInstalledAssemblySubsetTables: "$(IgnoreInstalledAssemblySubsetTables)", TargetedRuntimeVersion: "$(TargetedRuntimeVersion)", FindSerializationAssemblies: "$(ResolveAssemblyReferencesFindSerializationAssemblies)", ProfileName: "$(TargetFrameworkProfile)", SearchPaths: "$(AssemblySearchPaths)", InstalledAssemblyTables: "@(InstalledAssemblyTables);@(RedistList)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", LatestTargetFrameworkDirectories: "@(LatestTargetFrameworkDirectories)", FindRelatedFiles: "$(ResolveAssemblyReferencesFindRelatedFiles)");*/
	/* if ('@(Reference)'!='' or '@(_ResolvedProjectReferencePaths)'!='' or '@(_ExplicitReference)' != '')*/
	if (''!='' or ''!='' or '' != '')
	{
		ResolveAssemblyReference(StateFile: "", TargetFrameworkDirectories: "", AllowedRelatedFileExtensions: """
      .pdb;
      .xml;
      .pri;
      .dll.config;
      .exe.config
    """, AssemblyInformationCacheOutputPath: "", AppConfigFile: "", FullTargetFrameworkSubsetNames: "Full", OutputUnresolvedAssemblyConflicts: "true", TargetFrameworkVersion: "v8.0", ResolvedSDKReferences: "", AssemblyInformationCachePaths: "", Silent: "", WarnOrErrorOnTargetArchitectureMismatch: "", IgnoreTargetFrameworkAttributeVersionMismatch: "", IgnoreDefaultInstalledAssemblyTables: "", IgnoreVersionForFrameworkReferences: "", TargetFrameworkMonikerDisplayName: ".NET 8.0", TargetProcessorArchitecture: "msil", FindSatellites: "", CopyLocalDependenciesWhenParentReferenceInGac: "", InstalledAssemblySubsetTables: "", Assemblies: "", TargetFrameworkSubsets: "", AutoUnify: "true", FindDependenciesOfExternallyResolvedReferences: "", FullFrameworkFolders: "", DoNotCopyLocalIfInGac: "", FindDependencies: "", AllowedAssemblyExtensions: """
      .winmd;
      .dll;
      .exe
    """, AssemblyFiles: ";", CandidateAssemblyFiles: ";", FullFrameworkAssemblyTables: "", SupportsBindingRedirectGeneration: "true", IgnoreDefaultInstalledAssemblySubsetTables: "", TargetedRuntimeVersion: "", FindSerializationAssemblies: "", ProfileName: "", SearchPaths: "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}", InstalledAssemblyTables: ";", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", LatestTargetFrameworkDirectories: "", FindRelatedFiles: "");
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

	/*GenerateBindingRedirects(OutputAppConfigFile: "$(_GenerateBindingRedirectsIntermediateAppConfig)", AppConfigFile: "@(AppConfigWithTargetPath)", SuggestedRedirects: "@(SuggestedBindingRedirects)", TargetName: "$(TargetFileName).config");*/
	GenerateBindingRedirects(OutputAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.config", AppConfigFile: "", SuggestedRedirects: "", TargetName: "6 - targets.dll.config");

	GenerateBindingRedirectsRun = true;
}

void GenerateBindingRedirectsUpdateAppConfig()
{
	// if ('$(AutoGenerateBindingRedirects)' == 'true' and '$(GenerateBindingRedirectsOutputType)' == 'true')
	if ('' == 'true' and 'true' == 'true') { GenerateBindingRedirectsUpdateAppConfigRun = true; return; }

	GenerateBindingRedirectsUpdateAppConfigRun = true;
}

void GetInstalledSDKLocations()
{
	// if ('@(SDKReference)' != '')
	if ('' != '') { GetInstalledSDKLocationsRun = true; return; }
	// DependsOnTargets;
	if (!Run) ();

	/*GetInstalledSDKLocations(SDKExtensionDirectoryRoots: "$(SDKExtensionDirectoryRoot)", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetPlatformVersion: "$(TargetPlatformVersion)", SDKRegistryRoot: "$(SDKReferenceRegistryRoot)");*/
	GetInstalledSDKLocations(SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "", SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs");
	/*GetInstalledSDKLocations(WarnWhenNoSDKsFound: "false", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifierWindows81)", TargetPlatformVersion: "$(TargetPlatformVersionWindows81)", SDKRegistryRoot: "$(SDKReferenceRegistryRoot)");*/
	/* if ('$(SupportWindows81SDKs)' == 'true' and '$(TargetPlatformIdentifierWindows81)' != '' and '$(TargetPlatformVersionWindows81)' != '')*/
	if ('' == 'true' and '' != '' and '' != '')
	{
		GetInstalledSDKLocations(WarnWhenNoSDKsFound: "false", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "", SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs");
	}
	/*GetInstalledSDKLocations(WarnWhenNoSDKsFound: "false", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "$(SDKReferenceDirectoryRoot)", TargetPlatformIdentifier: "$(TargetPlatformIdentifierWindowsPhone81)", TargetPlatformVersion: "$(TargetPlatformVersionWindowsPhone81)", SDKRegistryRoot: "$(SDKReferenceRegistryRoot)");*/
	/* if ('$(SupportWindowsPhone81SDKs)' == 'true' and '$(TargetPlatformIdentifierWindowsPhone81)' != '' and '$(TargetPlatformVersionWindowsPhone81)' != '')*/
	if ('' == 'true' and '' != '' and '' != '')
	{
		GetInstalledSDKLocations(WarnWhenNoSDKsFound: "false", SDKExtensionDirectoryRoots: "", SDKDirectoryRoots: "C:\\Users\\kant\\AppData\\Local\\Microsoft SDKs;C:\\Program Files (x86)\\Microsoft SDKs", TargetPlatformIdentifier: "", TargetPlatformVersion: "", SDKRegistryRoot: "Software\\Microsoft\\Microsoft SDKs");
	}

	GetInstalledSDKLocationsRun = true;
}

void ResolveSDKReferences()
{
	// DependsOnTargets;
	if (!GetInstalledSDKLocationsRun) GetInstalledSDKLocations();

	/*ResolveSDKReference(RuntimeReferenceOnlySDKDependencies: "@(RuntimeReferenceOnlySDKDependencies)", Prefer32Bit: "$(Prefer32Bit)", ProjectName: "$(MSBuildProjectName)", TargetedSDKConfiguration: "$(TargetedSDKConfiguration)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetedSDKArchitecture: "$(TargetedSDKArchitecture)", LogResolutionErrorsAsWarnings: "$(LogSDKReferenceResolutionErrorsAsWarnings)", SDKReferences: "@(SDKReference)", WarnOnMissingPlatformVersion: "$(SDKReferenceWarnOnMissingMaxPlatformVersion)", InstalledSDKs: "@(InstalledSDKLocations)", TargetPlatformVersion: "$(TargetPlatformVersion)", References: "@(Reference)");*/
	/* if ('@(SDKReference)'!='')*/
	if (''!='')
	{
		ResolveSDKReference(RuntimeReferenceOnlySDKDependencies: "", Prefer32Bit: "false", ProjectName: "6 - targets", TargetedSDKConfiguration: "Debug", TargetPlatformIdentifier: "", TargetedSDKArchitecture: "msil", LogResolutionErrorsAsWarnings: "", SDKReferences: "", WarnOnMissingPlatformVersion: "", InstalledSDKs: "", TargetPlatformVersion: "", References: "");
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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetTargetPathWithTargetPlatformMoniker", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "GetTargetPathWithTargetPlatformMoniker", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");

	GetReferenceTargetPlatformMonikersRun = true;
}

void ExpandSDKReferences()
{
	// DependsOnTargets;
	if (!ResolveSDKReferencesRun) ResolveSDKReferences();

	/*GetSDKReferenceFiles(LogReferencesList: "$(GetSDKReferenceFilesLogReferencesList)", TargetSDKIdentifier: "$(SDKIdentifier)", ResolvedSDKReferences: "@(ResolvedSDKReference)", LogRedistConflictBetweenSDKsAsWarning: "$(GetSDKReferenceFilesLogRedistConflictsBetweenSDKsAsWarning)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetSDKVersion: "$(SDKVersion)", ReferenceExtensions: "$(ExpandSDKAllowedReferenceExtensions)", LogReferenceConflictWithinSDKAsWarning: "$(GetSDKReferenceFilesLogReferenceConflictsWithinSDKAsWarning)", LogRedistFilesList: "$(GetSDKReferenceFilesLogRedistFilesList)", TargetPlatformVersion: "$(TargetPlatformVersion)", LogReferenceConflictBetweenSDKsAsWarning: "$(GetSDKReferenceFilesLogReferenceConflictsBetweenSDKsAsWarning)", CacheFileFolderPath: "$(GetSDKReferenceFilesCacheFolder)", LogCacheFileExceptions: "$(GetSDKReferenceFilesLogCacheFileExceptions)", LogRedistConflictWithinSDKAsWarning: "$(GetSDKReferenceFilesLogRedistConflictsWithinSDKAsWarning)");*/
	/* if ('@(ResolvedSDKReference)'!='')*/
	if (''!='')
	{
		GetSDKReferenceFiles(LogReferencesList: "", TargetSDKIdentifier: "", ResolvedSDKReferences: "", LogRedistConflictBetweenSDKsAsWarning: "", TargetPlatformIdentifier: "", TargetSDKVersion: "", ReferenceExtensions: """
      .winmd;
      .dll
    """, LogReferenceConflictWithinSDKAsWarning: "", LogRedistFilesList: "", TargetPlatformVersion: "", LogReferenceConflictBetweenSDKsAsWarning: "", CacheFileFolderPath: "", LogCacheFileExceptions: "", LogRedistConflictWithinSDKAsWarning: "");
	}

	ExpandSDKReferencesRun = true;
}

void ExportWindowsMDFile()
{
	// if ('$(ExportWinMDFile)' == 'true')
	if ('' == 'true') { ExportWindowsMDFileRun = true; return; }
	// DependsOnTargets;
	if (!CompileRun) Compile();

	/*WinMDExp(OutputDocumentationFile: "$(WinMDOutputDocumentationFile)", AssemblyUnificationPolicy: "$(WinMDExpAssemblyUnificationPolicy)", DisabledWarnings: "$(WinMdExpNoWarn)", OutputWindowsMetadataFile: "$(_IntermediateWindowsMetadataPath)", UTF8Output: "$(WinMdExpUTF8Ouput)", InputDocumentationFile: "@(DocFileItem)", OutputPDBFile: "$(WinMDExpOutputPdb)", InputPDBFile: "@(_DebugSymbolsIntermediatePath)", WinMDModule: "@(IntermediateAssembly)", SdkToolsPath: "$(WinMdExpToolPath)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", EnvironmentVariables: "$(WinMDExpEnvironment)", References: "@(ReferencePathWithRefAssemblies)");*/
	WinMDExp(OutputDocumentationFile: "", AssemblyUnificationPolicy: "", DisabledWarnings: "", OutputWindowsMetadataFile: "", UTF8Output: "", InputDocumentationFile: "", OutputPDBFile: "", InputPDBFile: "obj\\Debug\\net8.0\\6 - targets.pdb", WinMDModule: "obj\\Debug\\net8.0\\6 - targets.dll", SdkToolsPath: "", TreatWarningsAsErrors: "false", EnvironmentVariables: "", References: "");

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

	/*ResolveAssemblyReference(StateFile: "$(DesignTimeResolveAssemblyReferencesStateFile)", TargetFrameworkDirectories: "@(_DesignTimeReferenceInstalledAssemblyDirectory)", FullTargetFrameworkSubsetNames: "$(FullReferenceAssemblyNames)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", ResolvedSDKReferences: "@(ResolvedSDKReference)", Silent: "$(DesignTimeSilentResolution)", IgnoreTargetFrameworkAttributeVersionMismatch: "$(DesignTimeIgnoreTargetFrameworkAttributeVersionMismatch)", IgnoreVersionForFrameworkReferences: "$(DesignTimeIgnoreVersionForFrameworkReferences)", TargetFrameworkMonikerDisplayName: "$(TargetFrameworkMonikerDisplayName)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", FindSatellites: "$(DesignTimeFindSatellites)", InstalledAssemblySubsetTables: "@(InstalledAssemblySubsetTables)", Assemblies: "@(_DesignTimeReferenceAssemblies)", TargetFrameworkSubsets: "@(_ReferenceInstalledAssemblySubsets)", AutoUnify: "$(DesignTimeAutoUnify)", FullFrameworkFolders: "$(_FullFrameworkReferenceAssemblyPaths)", FindDependencies: "$(DesignTimeFindDependencies)", AllowedAssemblyExtensions: "$(AllowedReferenceAssemblyFileExtensions)", CandidateAssemblyFiles: "@(Content);@(None);@(_RARResolvedReferencePath)", FullFrameworkAssemblyTables: "@(FullFrameworkAssemblyTables)", IgnoreDefaultInstalledAssemblySubsetTables: "$(IgnoreInstalledAssemblySubsetTables)", TargetedRuntimeVersion: "$(TargetedRuntimeVersion)", FindSerializationAssemblies: "$(DesignTimeFindSerializationAssemblies)", ProfileName: "$(TargetFrameworkProfile)", SearchPaths: "$(DesignTimeAssemblySearchPaths)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", FindRelatedFiles: "$(DesignTimeFindRelatedFiles)");*/
	ResolveAssemblyReference(StateFile: "", TargetFrameworkDirectories: "", FullTargetFrameworkSubsetNames: "Full", TargetFrameworkVersion: "v8.0", ResolvedSDKReferences: "", Silent: "", IgnoreTargetFrameworkAttributeVersionMismatch: "", IgnoreVersionForFrameworkReferences: "", TargetFrameworkMonikerDisplayName: ".NET 8.0", TargetProcessorArchitecture: "msil", FindSatellites: "", InstalledAssemblySubsetTables: "", Assemblies: "", TargetFrameworkSubsets: "", AutoUnify: "true", FullFrameworkFolders: "", FindDependencies: "", AllowedAssemblyExtensions: """
      .winmd;
      .dll;
      .exe
    """, CandidateAssemblyFiles: ";;", FullFrameworkAssemblyTables: "", IgnoreDefaultInstalledAssemblySubsetTables: "", TargetedRuntimeVersion: "", FindSerializationAssemblies: "", ProfileName: "", SearchPaths: "{CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", FindRelatedFiles: "");

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

	/*MakeDir(Directories: "$(InteropOutputPath)");*/
	MakeDir(Directories: "");
	/*ResolveComReference(ExecuteAsTool: "$(ComReferenceExecuteAsTool)", StateFile: "@(_ResolveComReferenceCache)", IncludeVersionInInteropName: "$(IncludeVersionInInteropName)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TypeLibNames: "@(COMReference)", TypeLibFiles: "@(COMFileReference)", KeyFile: "$(KeyOriginatorFile)", Silent: "$(ResolveComReferenceSilent)", TargetProcessorArchitecture: "$(ProcessorArchitecture)", NoClassMembers: "$(ComReferenceNoClassMembers)", KeyContainer: "$(KeyContainerName)", WrapperOutputDirectory: "$(InteropOutputPath)", ResolvedAssemblyReferences: "@(ReferencePath)", DelaySign: "$(DelaySign)", SdkToolsPath: "$(ResolveComReferenceToolPath)", EnvironmentVariables: "$(ResolveComReferenceEnvironment)");*/
	ResolveComReference(ExecuteAsTool: "false", StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.ResolveComReference.cache", IncludeVersionInInteropName: "", TargetFrameworkVersion: "v8.0", TypeLibNames: "", TypeLibFiles: "", KeyFile: "", Silent: "", TargetProcessorArchitecture: "msil", NoClassMembers: "false", KeyContainer: "", WrapperOutputDirectory: "", ResolvedAssemblyReferences: "", DelaySign: "", SdkToolsPath: "", EnvironmentVariables: "");

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
	/*ResolveFrameworkReferences(FrameworkReferences: "@(FrameworkReference)", ResolvedRuntimePacks: "@(ResolvedRuntimePack)", ResolvedTargetingPacks: "@(ResolvedTargetingPack)");*/
	ResolveFrameworkReferences(FrameworkReferences: "Microsoft.NETCore.App", ResolvedRuntimePacks: "", ResolvedTargetingPacks: "");

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

	/*AssignTargetPath(Files: "@(EmbeddedResource)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
	/*AssignTargetPath(Files: "@(Content)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
	/*AssignTargetPath(Files: "@(None)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
	/*AssignTargetPath(Files: "@(BaseApplicationManifest)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
	/*AssignTargetPath(Files: "@(None)", RootFolder: "$(MSBuildProjectDirectory)");*/
	/* if ('@(_DeploymentBaseManifestWithTargetPath)'=='' and '%(None.Extension)'=='.manifest')*/
	if (''=='' and '%(None.Extension)'=='.manifest')
	{
		AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");
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

	/*GenerateResource(ExecuteAsTool: "$(ResGenExecuteAsTool)", StateFile: "$(IntermediateOutputPath)$(MSBuildProjectFile).GenerateResource.cache", AdditionalInputs: "$(MSBuildAllProjects)", OutputResources: "@(EmbeddedResource->'$(IntermediateOutputPath)%(ManifestResourceName).resources')", PublicClass: "%(EmbeddedResource.PublicClass)", UseSourcePath: "$(UseSourcePath)", UsePreserializedResources: "$(GenerateResourceUsePreserializedResources)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", WarnOnBinaryFormatterUse: "$(GenerateResourceWarnOnBinaryFormatterUse)", SdkToolsPath: "$(ResgenToolPath)", NeverLockTypeAssemblies: "$(GenerateResourceNeverLockTypeAssemblies)", EnvironmentVariables: "$(ResGenEnvironment)", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", Sources: "@(EmbeddedResource)", References: "@(ReferencePathWithRefAssemblies)");*/
	/* if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and '$(GenerateResourceMSBuildRuntime)' != 'CLR2')*/
	if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and 'CurrentRuntime' != 'CLR2')
	{
		GenerateResource(ExecuteAsTool: "false", StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.GenerateResource.cache", AdditionalInputs: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Current\\Microsoft.Common.targets\\ImportAfter\\Microsoft.TestPlatform.ImportAfter.targets", OutputResources: "", PublicClass: "%(EmbeddedResource.PublicClass)", UseSourcePath: "true", UsePreserializedResources: "true", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", WarnOnBinaryFormatterUse: "true", SdkToolsPath: "", NeverLockTypeAssemblies: "", EnvironmentVariables: "", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", Sources: "", References: "");
	}
	/*GenerateResource(StateFile: "$(IntermediateOutputPath)$(MSBuildProjectFile).GenerateResource.cache", AdditionalInputs: "$(MSBuildAllProjects)", OutputResources: "@(EmbeddedResource->'$(IntermediateOutputPath)%(ManifestResourceName).resources')", PublicClass: "%(EmbeddedResource.PublicClass)", UseSourcePath: "$(UseSourcePath)", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", NeverLockTypeAssemblies: "$(GenerateResourceNeverLockTypeAssemblies)", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", Sources: "@(EmbeddedResource)", References: "@(ReferencePath)");*/
	/* if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and '$(GenerateResourceMSBuildRuntime)' == 'CLR2')*/
	if ('%(EmbeddedResource.Type)' == 'Resx' and '%(EmbeddedResource.GenerateResource)' != 'false' and 'CurrentRuntime' == 'CLR2')
	{
		GenerateResource(StateFile: "obj\\Debug\\net8.0\\6 - targets.csproj.GenerateResource.cache", AdditionalInputs: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Current\\Microsoft.Common.targets\\ImportAfter\\Microsoft.TestPlatform.ImportAfter.targets", OutputResources: "", PublicClass: "%(EmbeddedResource.PublicClass)", UseSourcePath: "true", StronglyTypedNamespace: "%(EmbeddedResource.StronglyTypedNamespace)", StronglyTypedFileName: "%(EmbeddedResource.StronglyTypedFileName)", StronglyTypedLanguage: "%(EmbeddedResource.StronglyTypedLanguage)", NeverLockTypeAssemblies: "", StronglyTypedManifestPrefix: "%(EmbeddedResource.StronglyTypedManifestPrefix)", StronglyTypedClassName: "%(EmbeddedResource.StronglyTypedClassName)", Sources: "", References: "");
	}

	CoreResGenRun = true;
}

void CompileLicxFiles()
{
	// if ('@(_LicxFile)'!='')
	if (''!='') { CompileLicxFilesRun = true; return; }
	// DependsOnTargets;
	if (!Run) ();

	/*LC(ReferencedAssemblies: "@(ReferencePathWithRefAssemblies);@(ReferenceDependencyPaths)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", ToolPath: "$(LCToolPath)", NoLogo: "$(NoLogo)", LicenseTarget: "$(TargetFileName)", SdkToolsPath: "$(TargetFrameworkSDKToolsDirectory)", EnvironmentVariables: "$(LCEnvironment)", OutputDirectory: "$(IntermediateOutputPath)", OutputLicense: "$(IntermediateOutputPath)$(TargetFileName).licenses", Sources: "@(_LicxFile)");*/
	LC(ReferencedAssemblies: ";", TargetFrameworkVersion: "v8.0", ToolPath: "", NoLogo: "", LicenseTarget: "6 - targets.dll", SdkToolsPath: "", EnvironmentVariables: "", OutputDirectory: "obj\\Debug\\net8.0\\", OutputLicense: "obj\\Debug\\net8.0\\6 - targets.dll.licenses", Sources: "");

	CompileLicxFilesRun = true;
}

void ResolveKeySource()
{
	// if ($(SignManifests) == 'true' or $(SignAssembly) == 'true')
	if ( == 'true' or false == 'true') { ResolveKeySourceRun = true; return; }

	/*ResolveKeySource(CertificateThumbprint: "$(ManifestCertificateThumbprint)", ShowImportDialogDespitePreviousFailures: "$(BuildingProject)", KeyFile: "$(AssemblyOriginatorKeyFile)", CertificateFile: "$(ManifestKeyFile)", SuppressAutoClosePasswordPrompt: "$(BuildingInsideVisualStudio)");*/
	ResolveKeySource(CertificateThumbprint: "", ShowImportDialogDespitePreviousFailures: "false", KeyFile: "", CertificateFile: "", SuppressAutoClosePasswordPrompt: "");

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

	/*WriteLinesToFile(Overwrite: "true", Lines: "$(TargetFrameworkMonikerAssemblyAttributeText)", File: "$(TargetFrameworkMonikerAssemblyAttributesPath)");*/
	/* if ('@(Compile)' != '' and '$(TargetFrameworkMonikerAssemblyAttributeText)' != '')*/
	if ('Program.cs' != '' and '' != '')
	{
		WriteLinesToFile(Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\.NETCoreApp,Version=v8.0.AssemblyAttributes.cs");
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

	_TimeStampBeforeCompileRun = true;
}

void _GenerateSuggestedBindingRedirectsCache()
{
	// if ('$(DesignTimeBuild)' != 'true' and '$(BuildingProject)' == 'true')
	if ('' != 'true' and 'false' == 'true') { _GenerateSuggestedBindingRedirectsCacheRun = true; return; }
	// DependsOnTargets;
	if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();

	/*Hash(ItemsToHash: "@(SuggestedBindingRedirects)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "$(SuggestedBindingRedirectsHash)", File: "$(SuggestedBindingRedirectsCacheFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "");

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
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "$(CoreCompileDependencyHash)", File: "$(IntermediateOutputPath)$(MSBuildProjectFile).CoreCompileInputs.cache");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\6 - targets.csproj.CoreCompileInputs.cache");

	_GenerateCompileDependencyCacheRun = true;
}

void _TimeStampAfterCompile()
{
	// if ('$(RunPostBuildEvent)'=='OnOutputUpdated' or ('$(RegisterForComInterop)'=='true' and '$(OutputType)'=='library'))
	if (''=='OnOutputUpdated' or (''=='true' and 'Exe'=='library')) { _TimeStampAfterCompileRun = true; return; }

	_TimeStampAfterCompileRun = true;
}

void _ComputeNonExistentFileProperty()
{
	// if (('$(BuildingInsideVisualStudio)' == 'true') and ('$(BuildingOutOfProcess)' != 'true') and (('$(BuildingProject)' == 'false') or ('$(UseHostCompilerIfAvailable)' == 'true')))
	if (('' == 'true') and ('' != 'true') and (('false' == 'false') or ('true' == 'true'))) { _ComputeNonExistentFilePropertyRun = true; return; }

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

	/*SGen(BuildAssemblyPath: "$(IntermediateOutputPath)", UseProxyTypes: "$(SGenUseProxyTypes)", Types: "$(SGenSerializationTypes)", ToolPath: "$(SGenToolPath)", SerializationAssembly: "$(IntermediateOutputPath)$(_SGenDllName)", ShouldGenerateSerializer: "$(SGenShouldGenerateSerializer)", KeyFile: "$(KeyOriginatorFile)", KeyContainer: "$(KeyContainerName)", Platform: "$(SGenPlatformTarget)", DelaySign: "$(DelaySign)", BuildAssemblyName: "$(TargetFileName)", UseKeep: "$(SGenUseKeep)", SdkToolsPath: "$(TargetFrameworkSDKToolsDirectory)", EnvironmentVariables: "$(SGenEnvironment)", References: "@(ReferencePath)");*/
	SGen(BuildAssemblyPath: "obj\\Debug\\net8.0\\", UseProxyTypes: "true", Types: "", ToolPath: "", SerializationAssembly: "obj\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", ShouldGenerateSerializer: "true", KeyFile: "", KeyContainer: "", Platform: "", DelaySign: "", BuildAssemblyName: "6 - targets.dll", UseKeep: "false", SdkToolsPath: "", EnvironmentVariables: "", References: "");

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

	/*MakeDir(Directories: "@(EmbeddedResource->'$(IntermediateOutputPath)%(Culture)')");*/
	MakeDir(Directories: "");
	/*AL(Trademark: "$(Satellite_Trademark)", Version: "$(Satellite_Version)", OutputAssembly: "$(IntermediateOutputPath)%(Culture)\\$(TargetName).resources.dll", ResponseFiles: "@(AlResponseFile)", Win32Resource: "$(Satellite_Win32Resource)", ToolPath: "$(AlToolPath)", ProductName: "$(Satellite_ProductName)", GenerateFullPaths: "$(Satellite_GenerateFullPaths)", EmbedResources: "@(_SatelliteAssemblyResourceInputs)", Configuration: "$(Satellite_Configuration)", TargetType: "$(Satellite_TargetType)", KeyFile: "$(KeyOriginatorFile)", AlgorithmId: "$(Satellite_AlgorithmId)", EvidenceFile: "$(Satellite_EvidenceFile)", ProductVersion: "$(Satellite_ProductVersion)", Description: "$(Satellite_Description)", Win32Icon: "$(Satellite_Win32Icon)", MainEntryPoint: "$(Satellite_MainEntryPoint)", BaseAddress: "$(Satellite_BaseAddress)", KeyContainer: "$(KeyContainerName)", ToolExe: "$(AlToolExe)", TemplateFile: "$(IntermediateOutputPath)$(TargetName)$(TargetExt)", Flags: "$(Satellite_Flags)", Platform: "$(PlatformTarget)", DelaySign: "$(DelaySign)", CompanyName: "$(Satellite_CompanyName)", LinkResources: "@(Satellite_LinkResource)", Copyright: "$(Satellite_Copyright)", SdkToolsPath: "$(_ALExeToolPath)", EnvironmentVariables: "$(AlEnvironment)", FileVersion: "$(Satellite_FileVersion)", SourceModules: "@(Satellite_SourceModule)", Culture: "%(Culture)", Title: "$(Satellite_Title)");*/
	AL(Trademark: "", Version: "", OutputAssembly: "obj\\Debug\\net8.0\\%(Culture)\\6 - targets.resources.dll", ResponseFiles: "", Win32Resource: "", ToolPath: "", ProductName: "", GenerateFullPaths: "", EmbedResources: "", Configuration: "", TargetType: "", KeyFile: "", AlgorithmId: "", EvidenceFile: "", ProductVersion: "", Description: "", Win32Icon: "", MainEntryPoint: "", BaseAddress: "", KeyContainer: "", ToolExe: "", TemplateFile: "obj\\Debug\\net8.0\\6 - targets.dll", Flags: "", Platform: "", DelaySign: "", CompanyName: "", LinkResources: "", Copyright: "", SdkToolsPath: "", EnvironmentVariables: "", FileVersion: "", SourceModules: "", Culture: "%(Culture)", Title: "");

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

	_SetExternalWin32ManifestPropertiesRun = true;
}

void _SetEmbeddedWin32ManifestProperties()
{
	// if ('$(GenerateClickOnceManifests)'!='true' and '@(NativeReference)'=='' and '@(ResolvedIsolatedComModules)'=='')
	if (''!='true' and ''=='' and ''=='') { _SetEmbeddedWin32ManifestPropertiesRun = true; return; }

	/* if ('$(ApplicationManifest)'=='' and '$(NoWin32Manifest)'!='true')*/
	if (''=='' and ''!='true')
	{
		GetFrameworkPath();
	}

	_SetEmbeddedWin32ManifestPropertiesRun = true;
}

void _GenerateResolvedDeploymentManifestEntryPoint()
{

	/*ResolveManifestFiles(TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningManifests: "$(SignManifests)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", PublishFiles: "@(_DeploymentPublishFileOfTypeManifestEntryPoint)", DeploymentManifestEntryPoint: "@(ApplicationManifest)");*/
	ResolveManifestFiles(TargetFrameworkVersion: "v8.0", SigningManifests: "", TargetFrameworkIdentifier: ".NETCoreApp", PublishFiles: "", DeploymentManifestEntryPoint: "obj\\Debug\\net8.0\\6 - targets.dll.manifest");

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

	/*RequiresFramework35SP1Assembly(Files: "@(_DeploymentManifestFiles)", ReferencedAssemblies: "@(Reference)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningManifests: "$(SignManifests)", Assemblies: "@(_DeploymentManifestDependencies)", EntryPoint: "@(_DeploymentResolvedManifestEntryPoint)", CreateDesktopShortcut: "$(CreateDesktopShortcut)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", DeploymentManifestEntryPoint: "@(_DeploymentResolvedDeploymentManifestEntryPoint)", SuiteName: "$(SuiteName)");*/
	RequiresFramework35SP1Assembly(Files: "", ReferencedAssemblies: "", TargetFrameworkVersion: "v8.0", SigningManifests: "", Assemblies: "", EntryPoint: "", CreateDesktopShortcut: "", ErrorReportUrl: "", DeploymentManifestEntryPoint: "", SuiteName: "");
	/*GenerateApplicationManifest(SupportUrl: "$(_DeploymentFormattedSupportUrl)", Files: "@(_DeploymentManifestFiles)", TargetFrameworkSubset: "$(TargetFrameworkSubset)", TrustInfoFile: "@(_DeploymentIntermediateTrustInfoFile)", OSVersion: "$(OSVersion)", ClrVersion: "$(ClrVersion)", InputManifest: "$(_DeploymentBaseManifest)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", TargetCulture: "$(TargetCulture)", OutputManifest: "@(ApplicationManifest)", TargetFrameworkProfile: "$(TargetFrameworkProfile)", UseApplicationTrust: "$(UseApplicationTrust)", Description: "$(Description)", Dependencies: "@(_DeploymentManifestDependencies)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)", AssemblyVersion: "$(_DeploymentManifestVersion)", ManifestType: "$(_DeploymentManifestType)", Platform: "$(_DeploymentPlatformTarget)", EntryPoint: "@(_DeploymentResolvedManifestEntryPoint)", HostInBrowser: "$(HostInBrowser)", ConfigFile: "@(AppConfigWithTargetPath)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", IconFile: "@(_DeploymentManifestIconFile)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", IsolatedComReferences: "@(ResolvedIsolatedComModules)", Publisher: "$(PublisherName)", MaxTargetPath: "$(MaxTargetPath)", FileAssociations: "@(FileAssociation)", Product: "$(ProductName)", SuiteName: "$(SuiteName)", RequiresMinimumFramework35SP1: "$(_DeploymentRequiresMinimumFramework35SP1)");*/
	GenerateApplicationManifest(SupportUrl: "", Files: "", TargetFrameworkSubset: "", TrustInfoFile: "", OSVersion: "", ClrVersion: "", InputManifest: "", TargetFrameworkVersion: "", TargetCulture: "*", OutputManifest: "obj\\Debug\\net8.0\\6 - targets.dll.manifest", TargetFrameworkProfile: "", UseApplicationTrust: "", Description: "", Dependencies: "", AssemblyName: "6 - targets.exe", AssemblyVersion: "", ManifestType: "", Platform: "", EntryPoint: "", HostInBrowser: "", ConfigFile: "", LauncherBasedDeployment: "true", IconFile: "", ErrorReportUrl: "", IsolatedComReferences: "", Publisher: "", MaxTargetPath: "100", FileAssociations: "", Product: "", SuiteName: "", RequiresMinimumFramework35SP1: "");

	GenerateApplicationManifestRun = true;
}

void _DeploymentSetClickOnceVersions()
{
	// if ('$(GenerateClickOnceManifests)'=='true')
	if (''=='true') { _DeploymentSetClickOnceVersionsRun = true; return; }

	_DeploymentSetClickOnceVersionsRun = true;
}

void _DeploymentGenerateLauncher()
{
	// if ('$(GenerateClickOnceManifests)'=='true' and '$(_DeploymentLauncherBased)' == 'true')
	if (''=='true' and 'true' == 'true') { _DeploymentGenerateLauncherRun = true; return; }

	/*GenerateLauncher(OutputPath: "$(IntermediateOutputPath)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)", EntryPoint: "@(EntryPointForLauncher)", VisualStudioVersion: "$(VisualStudioVersion)");*/
	GenerateLauncher(OutputPath: "obj\\Debug\\net8.0\\", AssemblyName: "6 - targets.exe", EntryPoint: "", VisualStudioVersion: "17.0");
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "@(_DeploymentManifestLauncherEntryPoint)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "", TimestampUrl: "");
	}
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "@(_DeploymentManifestEntryPoint)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "obj\\Debug\\net8.0\\6 - targets.dll", TimestampUrl: "");
	}
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "$(AppHostIntermediatePath)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true' and '$(UseAppHost)' == 'true' and '$(PublishSingleFile)' != 'true' and '$(_IsExecutable)' == 'true' and exists('$(AppHostIntermediatePath)'))*/
	if (''=='true' and 'true' == 'true' and '' != 'true' and 'true' == 'true' and exists(''))
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "", TimestampUrl: "");
	}

	_DeploymentGenerateLauncherRun = true;
}

void _DeploymentComputeNativeManifestInfo()
{
	// if ('$(GenerateClickOnceManifests)'!='true')
	if (''!='true') { _DeploymentComputeNativeManifestInfoRun = true; return; }

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

	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "$(PublishedSingleFilePath)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true' and '$(_DeploymentLauncherBased)' == 'true' and '$(PublishSingleFile)' == 'true')*/
	if (''=='true' and 'true' == 'true' and '' == 'true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "", TimestampUrl: "");
	}
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "@(_ClickOnceTargetFile)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)' == 'true' and '$(PublishReadyToRun)' == 'true' and '$(PublishSingleFile)' != 'true')*/
	if ('' == 'true' and '' == 'true' and '' != 'true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "", TimestampUrl: "");
	}
	/*Copy(DestinationFolder: "$(ClickOncePublishDir)", SourceFiles: "@(_DeploymentManifestEntryPoint)");*/
	Copy(DestinationFolder: "bin\\Debug\\net8.0\\publish\\", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll");
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", SigningTarget: "@(_DeploymentClickOnceApplicationExecutable)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentResolvedManifestCertificateThumbprint)'!='' and '$(_DeploymentSignClickOnceManifests)'=='true' and '$(TargetExt)' == '.exe')*/
	if (''!='' and ''=='true' and '.dll' == '.exe')
	{
		SignFile(CertificateThumbprint: "", SigningTarget: "", TimestampUrl: "");
	}
	/*ResolveManifestFiles(Files: "@(_ClickOnceFiles)", IsSelfContainedPublish: "$(SelfContained)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", SigningManifests: "$(SignManifests)", ExtraFiles: "@(_DebugSymbolsIntermediatePath);$(IntermediateOutputPath)$(TargetName).xml;@(_ReferenceRelatedPaths)", IsSingleFilePublish: "$(PublishSingleFile)", TargetCulture: "$(TargetCulture)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SatelliteAssemblies: "@(_ClickOnceSatelliteAssemblies)", ManagedAssemblies: "@(_ManifestManagedReferences)", RuntimePackAssets: "@(RuntimePackAsset)", AssemblyName: "$(_DeploymentApplicationManifestIdentity)", EntryPoint: "@(_DeploymentClickOnceApplicationExecutable)", NativeAssemblies: "@(NativeReferenceFile);@(_DeploymentNativePrerequisite)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", PublishFiles: "@(PublishFile)");*/
	ResolveManifestFiles(Files: "", IsSelfContainedPublish: "false", TargetFrameworkVersion: "v8.0", SigningManifests: "", ExtraFiles: "obj\\Debug\\net8.0\\6 - targets.pdb;obj\\Debug\\net8.0\\6 - targets.xml;", IsSingleFilePublish: "", TargetCulture: "*", TargetFrameworkIdentifier: ".NETCoreApp", SatelliteAssemblies: "", ManagedAssemblies: "", RuntimePackAssets: "", AssemblyName: "6 - targets.exe", EntryPoint: "", NativeAssemblies: ";", LauncherBasedDeployment: "true", PublishFiles: "");
	/*FormatVersion(Revision: "$(ApplicationRevision)", Version: "$(ApplicationVersion)");*/
	FormatVersion(Revision: "", Version: "");
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

	/*GenerateTrustInfo(TrustInfoFile: "@(_DeploymentIntermediateTrustInfoFile)", TargetZone: "$(TargetZone)", ApplicationDependencies: "@(ReferencePath);@(ReferenceDependencyPaths)", ExcludedPermissions: "$(ExcludedPermissions)", BaseManifest: "$(_DeploymentBaseManifest)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	GenerateTrustInfo(TrustInfoFile: "", TargetZone: "", ApplicationDependencies: ";", ExcludedPermissions: "", BaseManifest: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");

	_DeploymentGenerateTrustInfoRun = true;
}

void GenerateDeploymentManifest()
{
	// DependsOnTargets;
	if (!GenerateApplicationManifestRun) GenerateApplicationManifest();

	/*GenerateDeploymentManifest(SupportUrl: "$(_DeploymentFormattedSupportUrl)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", UpdateInterval: "$(_DeploymentBuiltUpdateInterval)", TargetCulture: "$(TargetCulture)", MinimumRequiredVersion: "$(_DeploymentBuiltMinimumRequiredVersion)", OutputManifest: "@(DeployManifest)", Description: "$(Description)", AssemblyName: "$(_DeploymentDeployManifestIdentity)", AssemblyVersion: "$(_DeploymentManifestVersion)", UpdateUnit: "$(_DeploymentBuiltUpdateIntervalUnits)", UpdateMode: "$(UpdateMode)", Platform: "$(_DeploymentPlatformTarget)", DisallowUrlActivation: "$(DisallowUrlActivation)", EntryPoint: "@(_DeploymentResolvedDeploymentManifestEntryPoint)", CreateDesktopShortcut: "$(CreateDesktopShortcut)", DeploymentUrl: "$(_DeploymentFormattedDeploymentUrl)", LauncherBasedDeployment: "$(_DeploymentLauncherBased)", MapFileExtensions: "$(MapFileExtensions)", ErrorReportUrl: "$(_DeploymentFormattedErrorReportUrl)", TrustUrlParameters: "$(TrustUrlParameters)", UpdateEnabled: "$(UpdateEnabled)", Install: "$(Install)", Publisher: "$(PublisherName)", MaxTargetPath: "$(MaxTargetPath)", Product: "$(ProductName)", SuiteName: "$(SuiteName)", TargetFrameworkMoniker: "$(_DeploymentManifestTargetFrameworkMoniker)");*/
	/* if ('$(GenerateClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		GenerateDeploymentManifest(SupportUrl: "", TargetFrameworkVersion: "", UpdateInterval: "0", TargetCulture: "*", MinimumRequiredVersion: "", OutputManifest: "obj\\Debug\\net8.0\\6 - targets.application", Description: "", AssemblyName: "6 - targets.application", AssemblyVersion: "", UpdateUnit: "Days", UpdateMode: "", Platform: "", DisallowUrlActivation: "", EntryPoint: "", CreateDesktopShortcut: "", DeploymentUrl: "", LauncherBasedDeployment: "true", MapFileExtensions: "", ErrorReportUrl: "", TrustUrlParameters: "", UpdateEnabled: "", Install: "", Publisher: "", MaxTargetPath: "100", Product: "", SuiteName: "", TargetFrameworkMoniker: "");
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

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(IntermediateAssembly)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('$(CopyBuildOutputToOutputDirectory)' == 'true' and '$(SkipCopyBuildProduct)' != 'true')*/
	if ('' == 'true' and '' != 'true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
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
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(AddModules)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyAdditionalFilesIfPossible)");*/
	/* if ('@(AddModules)' != '')*/
	if ('' != '')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "false", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "false");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "$(OutDir)$(_SGenDllName)", SourceFiles: "$(IntermediateOutputPath)$(_SGenDllName)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('$(_SGenDllCreated)'=='true')*/
	if ('false'=='true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "bin\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.XmlSerializers.dll", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_DebugSymbolsOutputPath)", SourceFiles: "@(_DebugSymbolsIntermediatePath)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('$(_DebugSymbolsProduced)'=='true' and '$(SkipCopyingSymbolsToOutputDirectory)' != 'true' and '$(CopyOutputSymbolsToOutputDirectory)'=='true')*/
	if ('true'=='true' and '' != 'true' and ''=='true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "bin\\Debug\\net8.0\\6 - targets.pdb", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.pdb", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(FinalDocFile)", SourceFiles: "@(DocFileItem)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('$(_DocumentationFileProduced)'=='true' and '$(CopyDocumentationFileToOutputDirectory)'=='true')*/
	if ('false'=='true' and ''=='true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(IntermediateSatelliteAssembliesWithTargetPath->'$(OutDir)%(Culture)\\$(TargetName).resources.dll')", SourceFiles: "@(IntermediateSatelliteAssembliesWithTargetPath)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('@(IntermediateSatelliteAssembliesWithTargetPath)' != '')*/
	if ('' != '')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(ReferenceComWrappersToCopyLocal); @(ResolvedIsolatedComModules); @(_DeploymentLooseManifestFile); @(NativeReferenceFile)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyAdditionalFilesIfPossible)");*/
	/* if ('@(ReferenceComWrappersToCopyLocal)' != '' or '@(ResolvedIsolatedComModules)' != '' or '@(_DeploymentLooseManifestFile)' != '' or '@(NativeReferenceFile)' != '' )*/
	if ('' != '' or '' != '' or '' != '' or '' != '' )
	{
		Copy(Retries: "", UseHardlinksIfPossible: "false", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "; ; ; ", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "false");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(WinMDExpArtifacts)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", ErrorIfLinkFails: "$(ErrorIfLinkFailsForCopyFilesToOutputDirectory)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	/* if ('$(SkipCopyWinMDArtifact)' != 'true' and '@(WinMDExpArtifacts)' != '')*/
	if ('' != 'true' and '' != '')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", ErrorIfLinkFails: "", UseSymboliclinksIfPossible: "");
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

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyLocalIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(ReferenceCopyLocalPaths->'$(OutDir)%(DestinationSubDirectory)%(Filename)%(Extension)')", SourceFiles: "@(ReferenceCopyLocalPaths)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyLocalIfPossible)");*/
	/* if ('$(UseCommonOutputDirectory)' != 'true')*/
	if ('false' != 'true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*Touch(Files: "@(CopyUpToDateMarker)", AlwaysCreate: "true");*/
	/* if ('@(ReferencesCopiedInThisBuild)' != '' and '$(WroteAtLeastOneFile)' == 'true')*/
	if ('' != '' and '' == 'true')
	{
		Touch(Files: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targ.C1F7A3EE.Up2Date", AlwaysCreate: "true");
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

	_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun = true;
}

void _GetCopyToOutputDirectoryItemsFromTransitiveProjectReferences()
{
	// DependsOnTargets;
	if (!_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun) _PopulateCommonStateForGetCopyToOutputDirectoryItems();
	if (!_AddOutputPathToGlobalPropertiesToRemoveRun) _AddOutputPathToGlobalPropertiesToRemove();

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "$(_RecursiveTargetForContentCopying)", SkipNonexistentTargets: "true", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('@(_MSBuildProjectReferenceExistent)' != '' and '$(_GetChildProjectCopyToOutputDirectoryItems)' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false' and '$(UseCommonOutputDirectory)' != 'true')*/
	if ('' != '' and 'true' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false' and 'false' != 'true')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "GetCopyToOutputDirectoryItems", SkipNonexistentTargets: "true", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
	}
	/*AssignTargetPath(Files: "@(_CompileItemsToCopy)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");

	_GetCopyToOutputDirectoryItemsFromTransitiveProjectReferencesRun = true;
}

void _GetCopyToOutputDirectoryItemsFromThisProject()
{
	// DependsOnTargets;
	if (!AssignTargetPathsRun) AssignTargetPaths();
	if (!_PopulateCommonStateForGetCopyToOutputDirectoryItemsRun) _PopulateCommonStateForGetCopyToOutputDirectoryItems();
	// BeforeTargets;
	if (!AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjectsRun) AddDepsJsonAndRuntimeConfigToCopyItemsForReferencingProjects();

	/*AssignTargetPath(Files: "@(_CompileItemsToCopy)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");

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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "GetCopyToPublishDirectoryItems", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('@(_MSBuildProjectReferenceExistent)' != '' and '$(_GetChildProjectCopyToPublishDirectoryItems)' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false')*/
	if ('' != '' and 'true' == 'true' and '%(_MSBuildProjectReferenceExistent.Private)' != 'false')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "GetCopyToPublishDirectoryItems", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
	}
	/*AssignTargetPath(Files: "@(_CompileItemsToPublish)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");

	GetCopyToPublishDirectoryItemsRun = true;
}

void _CopyOutOfDateSourceItemsToOutputDirectory()
{
	// if ( '@(_SourceItemsToCopyToOutputDirectory)' != '' )
	if ( '' != '' ) { _CopyOutOfDateSourceItemsToOutputDirectoryRun = true; return; }

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_SourceItemsToCopyToOutputDirectory->'$(OutDir)%(TargetPath)')", SourceFiles: "@(_SourceItemsToCopyToOutputDirectory)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

	_CopyOutOfDateSourceItemsToOutputDirectoryRun = true;
}

void _CopyOutOfDateSourceItemsToOutputDirectoryAlways()
{
	// if ( '@(_SourceItemsToCopyToOutputDirectoryAlways)' != '' )
	if ( '' != '' ) { _CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun = true; return; }

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_SourceItemsToCopyToOutputDirectoryAlways->'$(OutDir)%(TargetPath)')", SourceFiles: "@(_SourceItemsToCopyToOutputDirectoryAlways)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

	_CopyOutOfDateSourceItemsToOutputDirectoryAlwaysRun = true;
}

void _CopyAppConfigFile()
{
	// if ( '@(AppConfigWithTargetPath)' != '' )
	if ( '' != '' ) { _CopyAppConfigFileRun = true; return; }

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(AppConfigWithTargetPath->'$(OutDir)%(TargetPath)')", SourceFiles: "@(AppConfigWithTargetPath)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

	_CopyAppConfigFileRun = true;
}

void _CopyManifestFiles()
{
	// if ( '$(_DeploymentCopyApplicationManifest)'=='true' or '$(GenerateClickOnceManifests)'=='true' )
	if ( ''=='true' or ''=='true' ) { _CopyManifestFilesRun = true; return; }
	// DependsOnTargets;
	if (!PrepareForBuildRun) PrepareForBuild();

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(ApplicationManifest)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)");*/
	/* if ('$(GenerateClickOnceManifests)'=='true' or '$(_DeploymentCopyApplicationManifest)'=='true')*/
	if (''=='true' or ''=='true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.dll.manifest", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*Message(Text: "$(MSBuildProjectName) -> @(_DeploymentMainApplicationManifest->'%(FullPath)')", Importance: "Normal");*/
	/* if ('$(_DeploymentCopyApplicationManifest)'=='true')*/
	if (''=='true')
	{
		Message(Text: "6 - targets -> ", Importance: "Normal");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForAdditionalFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)", SourceFiles: "@(DeployManifest)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForAdditionalFilesIfPossible)");*/
	/* if ('$(GenerateClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\", SourceFiles: "obj\\Debug\\net8.0\\6 - targets.application", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
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

	_CheckForCompileOutputsRun = true;
}

void _SGenCheckForOutputs()
{
	// if ('$(_SGenGenerateSerializationAssembliesConfig)' == 'On' or ('@(WebReferenceUrl)'!='' and '$(_SGenGenerateSerializationAssembliesConfig)' == 'Auto'))
	if ('Off' == 'On' or (''!='' and 'Off' == 'Auto')) { _SGenCheckForOutputsRun = true; return; }

	_SGenCheckForOutputsRun = true;
}

void UnmanagedRegistration()
{
	// if ('$(RegisterForComInterop)'=='true' and '$(OutputType)'=='library')
	if (''=='true' and 'Exe'=='library') { UnmanagedRegistrationRun = true; return; }
	// DependsOnTargets;
	if (!Run) ();

	/*RegisterAssembly(AssemblyListFile: "@(_UnmanagedRegistrationCache)", TypeLibFiles: "@(_OutputPathItem->'%(FullPath)$(TargetName).tlb')", Assemblies: "@(_OutputPathItem->'%(FullPath)$(TargetFileName)')", CreateCodeBase: "true");*/
	/* if (!Exists('@(_UnmanagedRegistrationCache)'))*/
	if (!Exists('obj\6 - targets.csproj.UnmanagedRegistration.cache'))
	{
		RegisterAssembly(AssemblyListFile: "obj\\6 - targets.csproj.UnmanagedRegistration.cache", TypeLibFiles: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.tlb", Assemblies: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", CreateCodeBase: "true");
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
	/*Delete(Files: "@(_CleanOrphanFileWritesInIntermediate);@(_CleanOrphanFileWritesInOutput)", TreatErrorsAsWarnings: "true");*/
	Delete(Files: ";", TreatErrorsAsWarnings: "true");
	/*RemoveDuplicates(Inputs: "@(_CleanRemainingFileWritesAfterIncrementalClean)");*/
	RemoveDuplicates(Inputs: "");
	/*WriteLinesToFile(Overwrite: "true", Lines: "@(_CleanUniqueRemainingFileWritesAfterIncrementalClean)", File: "$(IntermediateOutputPath)$(CleanFile)");*/
	/* if ('@(_CleanUnfilteredPriorFileWrites)'!='@(_CleanUniqueRemainingFileWritesAfterIncrementalClean)')*/
	if (''!='')
	{
		WriteLinesToFile(Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");
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
	/*FindUnderPath(Files: "@(FileWritesShareable)", Path: "$(MSBuildProjectDirectory)", UpdateToAbsolutePaths: "true");*/
	FindUnderPath(Files: "", Path: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", UpdateToAbsolutePaths: "true");
	/*FindUnderPath(Files: "@(FileWrites)", Path: "$(OutDir)", UpdateToAbsolutePaths: "true");*/
	FindUnderPath(Files: "", Path: "bin\\Debug\\net8.0\\", UpdateToAbsolutePaths: "true");
	/*FindUnderPath(Files: "@(FileWrites)", Path: "$(IntermediateOutputPath)", UpdateToAbsolutePaths: "true");*/
	FindUnderPath(Files: "", Path: "obj\\Debug\\net8.0\\", UpdateToAbsolutePaths: "true");
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

	/*MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)$(_GlobalPropertiesToRemoveFromProjectReferences)", Projects: "@(_MSBuildProjectReferenceExistent)", Targets: "Clean", BuildInParallel: "$(BuildInParallel)", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");*/
	/* if ('$(BuildingInsideVisualStudio)' != 'true' and '$(BuildProjectReferences)' == 'true' and '@(_MSBuildProjectReferenceExistent)' != '')*/
	if ('' != 'true' and 'true' == 'true' and '' != '')
	{
		MSBuild(RemoveProperties: "%(_MSBuildProjectReferenceExistent.GlobalPropertiesToRemove)", Projects: "", Targets: "Clean", BuildInParallel: "true", Properties: "%(_MSBuildProjectReferenceExistent.SetConfiguration); %(_MSBuildProjectReferenceExistent.SetPlatform); %(_MSBuildProjectReferenceExistent.SetTargetFramework)");
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

	/*Delete(Files: "@(Clean)", TreatErrorsAsWarnings: "true");*/
	Delete(Files: "", TreatErrorsAsWarnings: "true");
	/*ReadLinesFromFile(File: "$(IntermediateOutputPath)$(CleanFile)");*/
	ReadLinesFromFile(File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");
	/*FindUnderPath(Files: "@(_CleanPriorFileWrites)", Path: "$(OutDir)");*/
	FindUnderPath(Files: "", Path: "bin\\Debug\\net8.0\\");
	/*FindUnderPath(Files: "@(_CleanPriorFileWrites)", Path: "$(IntermediateOutputPath)");*/
	FindUnderPath(Files: "", Path: "obj\\Debug\\net8.0\\");
	/*Delete(Files: "@(_CleanPriorFileWritesInOutput);@(_CleanPriorFileWritesInIntermediate)", TreatErrorsAsWarnings: "true");*/
	Delete(Files: ";", TreatErrorsAsWarnings: "true");
	/*RemoveDuplicates(Inputs: "@(_CleanRemainingFileWritesAfterClean)");*/
	RemoveDuplicates(Inputs: "");
	/*MakeDir(Directories: "$(IntermediateOutputPath)");*/
	MakeDir(Directories: "obj\\Debug\\net8.0\\");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "@(_CleanUniqueRemainingFileWrites)", File: "$(IntermediateOutputPath)$(CleanFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");

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
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "@(_CleanUniqueFileWrites)", File: "$(IntermediateOutputPath)$(CleanFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\6 - targets.csproj.FileListAbsolute.txt");

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

	/*Exec(WorkingDirectory: "$(OutDir)", Command: "$(PostBuildEvent)");*/
	Exec(WorkingDirectory: "bin\\Debug\\net8.0\\", Command: "");

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
	/*AllowEmptyTelemetry(EventName: "PublishProperties", EventData: "@(PublishTelemetry)");*/
	AllowEmptyTelemetry(EventName: "PublishProperties", EventData: "");

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

	/*FormatVersion(Revision: "$(ApplicationRevision)", Version: "$(ApplicationVersion)", FormatType: "Path");*/
	FormatVersion(Revision: "", Version: "", FormatType: "Path");
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: """@(_ApplicationManifestFinal->'$(_DeploymentApplicationDir)%(TargetPath)');
                @(_DeploymentManifestEntryPoint->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                @(_DeploymentManifestFiles->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                @(ReferenceComWrappersToCopyLocal->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)');
                @(ResolvedIsolatedComModules->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)');
                @(_DeploymentLooseManifestFile->'$(_DeploymentApplicationDir)%(FileName)%(Extension)$(_DeploymentFileMappingExtension)')""", SourceFiles: """@(_ApplicationManifestFinal);
                @(_DeploymentResolvedManifestEntryPoint);
                @(_DeploymentManifestFiles);
                @(ReferenceComWrappersToCopyLocal);
                @(ResolvedIsolatedComModules);
                @(_DeploymentLooseManifestFile)""", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	/* if ('$(PublishSingleFile)' != 'true')*/
	if ('' != 'true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: """6 - targets.dll.manifest;
                6 - targets.dll;
                ;
                ;
                ;
                """, SourceFiles: """bin\\Debug\\net8.0\\6 - targets.dll.manifest;
                ;
                ;
                ;
                ;
                """, SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_DeploymentManifestDependencies->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)')", SourceFiles: "@(_DeploymentManifestDependencies)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	/* if ('$(PublishSingleFile)' != 'true' and '%(_DeploymentManifestDependencies.DependencyType)'=='Install')*/
	if ('' != 'true' and '%(_DeploymentManifestDependencies.DependencyType)'=='Install')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_ReferenceScatterPaths->'$(_DeploymentApplicationDir)%(Filename)%(Extension)$(_DeploymentFileMappingExtension)')", SourceFiles: "@(_ReferenceScatterPaths)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	/* if ('$(PublishSingleFile)' != 'true')*/
	if ('' != 'true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: """@(_ApplicationManifestFinal->'$(_DeploymentApplicationDir)%(TargetPath)');
                 @(_DeploymentManifestEntryPoint->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)');
                 @(PublishedSingleFileToBeCopied->'$(_DeploymentApplicationDir)%(TargetPath)$(_DeploymentFileMappingExtension)')""", SourceFiles: """@(_ApplicationManifestFinal);
                 @(_DeploymentResolvedManifestEntryPoint);
                 @(PublishedSingleFileToBeCopied);""", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	/* if ('$(PublishSingleFile)' == 'true')*/
	if ('' == 'true')
	{
		Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: """6 - targets.dll.manifest;
                 6 - targets.dll;
                 """, SourceFiles: """bin\\Debug\\net8.0\\6 - targets.dll.manifest;
                 ;
                 ;""", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");
	}
	/*FormatUrl(InputUrl: "$(_DeploymentApplicationUrl)");*/
	FormatUrl(InputUrl: "");
	/*FormatUrl(InputUrl: "$(_DeploymentComponentsUrl)");*/
	FormatUrl(InputUrl: "");

	_CopyFilesToPublishFolderRun = true;
}

void _DeploymentGenerateBootstrapper()
{

	/*GenerateBootstrapper(SupportUrl: "$(_DeploymentFormattedSupportUrl)", FallbackCulture: "$(FallbackCulture)", OutputPath: "$(ClickOncePublishDir)", BootstrapperItems: "@(BootstrapperPackage)", ApplicationUrl: "$(_DeploymentFormattedApplicationUrl)", ComponentsLocation: "$(BootstrapperComponentsLocation)", Path: "$(GenerateBootstrapperSdkPath)", ApplicationFile: "$(TargetDeployManifestFileName)", ComponentsUrl: "$(_DeploymentFormattedComponentsUrl)", VisualStudioVersion: "$(VisualStudioVersion)", ApplicationName: "$(AssemblyName)", Culture: "$(TargetCulture)");*/
	/* if ('$(BootstrapperEnabled)'=='true')*/
	if (''=='true')
	{
		GenerateBootstrapper(SupportUrl: "", FallbackCulture: "", OutputPath: "bin\\Debug\\net8.0\\publish\\", BootstrapperItems: "", ApplicationUrl: "", ComponentsLocation: "", Path: "", ApplicationFile: "6 - targets.application", ComponentsUrl: "", VisualStudioVersion: "17.0", ApplicationName: "6 - targets", Culture: "*");
	}

	_DeploymentGenerateBootstrapperRun = true;
}

void _DeploymentSignClickOnceDeployment()
{

	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", DisallowMansignTimestampFallback: "$(DisallowMansignTimestampFallback)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "$(_DeploymentApplicationDir)$(_DeploymentTargetApplicationManifestFileName)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", DisallowMansignTimestampFallback: "", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "6 - targets.dll.manifest", TimestampUrl: "");
	}
	/*UpdateManifest(ApplicationManifest: "$(_DeploymentApplicationDir)$(_DeploymentTargetApplicationManifestFileName)", InputManifest: "$(OutDir)$(TargetDeployManifestFileName)", TargetFrameworkVersion: "$(_DeploymentManifestTargetFrameworkVersion)", OutputManifest: "$(ClickOncePublishDir)$(TargetDeployManifestFileName)", ApplicationPath: "$(_DeploymentApplicationFolderName)\\$(_DeploymentTargetApplicationManifestFileName)");*/
	UpdateManifest(ApplicationManifest: "6 - targets.dll.manifest", InputManifest: "bin\\Debug\\net8.0\\6 - targets.application", TargetFrameworkVersion: "", OutputManifest: "bin\\Debug\\net8.0\\publish\\6 - targets.application", ApplicationPath: "\\6 - targets.dll.manifest");
	/*SignFile(CertificateThumbprint: "$(_DeploymentResolvedManifestCertificateThumbprint)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", DisallowMansignTimestampFallback: "$(DisallowMansignTimestampFallback)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", SigningTarget: "$(ClickOncePublishDir)$(TargetDeployManifestFileName)", TimestampUrl: "$(ManifestTimestampUrl)");*/
	/* if ('$(_DeploymentSignClickOnceManifests)'=='true')*/
	if (''=='true')
	{
		SignFile(CertificateThumbprint: "", TargetFrameworkVersion: "v8.0", DisallowMansignTimestampFallback: "", TargetFrameworkIdentifier: ".NETCoreApp", SigningTarget: "bin\\Debug\\net8.0\\publish\\6 - targets.application", TimestampUrl: "");
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

	/*AssignTargetPath(Files: "@(Compile)", RootFolder: "$(MSBuildProjectDirectory)");*/
	AssignTargetPath(Files: "Program.cs", RootFolder: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");

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

	/*GenerateSupportedTargetFrameworkAlias(TargetPlatformMoniker: "$(TargetPlatformMoniker)", SupportedTargetFramework: "@(SupportedTargetFramework)", UseWpf: "$(UseWpf)", UseWindowsForms: "$(UseWindowsForms)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	GenerateSupportedTargetFrameworkAlias(TargetPlatformMoniker: "", SupportedTargetFramework: ".NETCoreApp,Version=v1.0;.NETCoreApp,Version=v1.1;.NETCoreApp,Version=v2.0;.NETCoreApp,Version=v2.1;.NETCoreApp,Version=v2.2;.NETCoreApp,Version=v3.0;.NETCoreApp,Version=v3.1;.NETCoreApp,Version=v5.0;.NETCoreApp,Version=v6.0;.NETCoreApp,Version=v7.0;.NETCoreApp,Version=v8.0;.NETStandard,Version=v1.0;.NETStandard,Version=v1.1;.NETStandard,Version=v1.2;.NETStandard,Version=v1.3;.NETStandard,Version=v1.4;.NETStandard,Version=v1.5;.NETStandard,Version=v1.6;.NETStandard,Version=v2.0;.NETStandard,Version=v2.1;.NETFramework,Version=v2.0;.NETFramework,Version=v3.0;.NETFramework,Version=v3.5;.NETFramework,Version=v4.0;.NETFramework,Version=v4.5;.NETFramework,Version=v4.5.1;.NETFramework,Version=v4.5.2;.NETFramework,Version=v4.6;.NETFramework,Version=v4.6.1;.NETFramework,Version=v4.6.2;.NETFramework,Version=v4.7;.NETFramework,Version=v4.7.1;.NETFramework,Version=v4.7.2;.NETFramework,Version=v4.8;.NETFramework,Version=v4.8.1", UseWpf: "", UseWindowsForms: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");

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
	/*RestoreTask(RestoreRecursive: "$(RestoreRecursive)", RestoreForce: "$(RestoreForce)", RestoreNoCache: "$(RestoreNoCache)", RestoreGraphItems: "@(_RestoreGraphEntryFiltered)", RestoreIgnoreFailedSources: "$(RestoreIgnoreFailedSources)", EmbedFilesInBinlog: "$(RestoreEmbedFilesInBinlog)", Interactive: "$(NuGetInteractive)", RestoreForceEvaluate: "$(RestoreForceEvaluate)", HideWarningsAndErrors: "$(HideWarningsAndErrors)", RestoreNoHttpCache: "$(RestoreNoHttpCache)", RestoreDisableParallel: "$(RestoreDisableParallel)", RestorePackagesConfig: "$(RestorePackagesConfig)");*/
	RestoreTask(RestoreRecursive: "true", RestoreForce: "", RestoreNoCache: "", RestoreGraphItems: "", RestoreIgnoreFailedSources: "", EmbedFilesInBinlog: "", Interactive: "", RestoreForceEvaluate: "", HideWarningsAndErrors: "false", RestoreNoHttpCache: "", RestoreDisableParallel: "", RestorePackagesConfig: "");

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
	/*WriteRestoreGraphTask(RestoreRecursive: "$(RestoreRecursive)", RestoreGraphItems: "@(_RestoreGraphEntryFiltered)", RestoreGraphOutputPath: "$(RestoreGraphOutputPath)");*/
	WriteRestoreGraphTask(RestoreRecursive: "true", RestoreGraphItems: "", RestoreGraphOutputPath: "");

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

	/*CheckForDuplicateNuGetItemsTask(LogCode: "NU1504", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", Items: "@(PackageReference)", ItemName: "PackageReference", WarningsNotAsErrors: "$(WarningsNotAsErrors)", NoWarn: "$(NoWarn)", WarningsAsErrors: "$(WarningsAsErrors)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
	/* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
	if ('' != 'true' )
	{
		CheckForDuplicateNuGetItemsTask(LogCode: "NU1504", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Items: "", ItemName: "PackageReference", WarningsNotAsErrors: "", NoWarn: "1701;1702", WarningsAsErrors: ";NU1605;SYSLIB0011", TreatWarningsAsErrors: "false");
	}

	CollectPackageReferencesRun = true;
}

void CollectCentralPackageVersions()
{

	/*CheckForDuplicateNuGetItemsTask(LogCode: "NU1506", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", Items: "@(PackageVersion)", ItemName: "PackageVersion", WarningsNotAsErrors: "$(WarningsNotAsErrors)", NoWarn: "$(NoWarn)", WarningsAsErrors: "$(WarningsAsErrors)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
	/* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
	if ('' != 'true' )
	{
		CheckForDuplicateNuGetItemsTask(LogCode: "NU1506", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Items: "", ItemName: "PackageVersion", WarningsNotAsErrors: "", NoWarn: "1701;1702", WarningsAsErrors: ";NU1605;SYSLIB0011", TreatWarningsAsErrors: "false");
	}

	CollectCentralPackageVersionsRun = true;
}

void CollectPackageDownloads()
{
	// BeforeTargets;
	if (!ProcessFrameworkReferencesRun) ProcessFrameworkReferences();

	/*CheckForDuplicateNuGetItemsTask(LogCode: "NU1505", MSBuildProjectFullPath: "$(MSBuildProjectFullPath)", Items: "@(PackageDownload)", ItemName: "PackageDownload", WarningsNotAsErrors: "$(WarningsNotAsErrors)", NoWarn: "$(NoWarn)", WarningsAsErrors: "$(WarningsAsErrors)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)");*/
	/* if ('$(DisableCheckingDuplicateNuGetItems)' != 'true' )*/
	if ('' != 'true' )
	{
		CheckForDuplicateNuGetItemsTask(LogCode: "NU1505", MSBuildProjectFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Items: "", ItemName: "PackageDownload", WarningsNotAsErrors: "", NoWarn: "1701;1702", WarningsAsErrors: ";NU1605;SYSLIB0011", TreatWarningsAsErrors: "false");
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

	/*RemoveDuplicates(Inputs: "@(_FilteredRestoreGraphProjectInputItemsTmp)");*/
	RemoveDuplicates(Inputs: "");
	/*MSBuild(Projects: "@(FilteredRestoreGraphProjectInputItemsWithoutDuplicates)", Targets: "_IsProjectRestoreSupported", SkipNonexistentTargets: "true", BuildInParallel: "$(RestoreBuildInParallel)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
	if ( 'true' == 'true' )
	{
		MSBuild(Projects: "", Targets: "_IsProjectRestoreSupported", SkipNonexistentTargets: "true", BuildInParallel: "true", Properties: "ExcludeRestorePackageImports=true");
	}
	/*MSBuild(Projects: "@(FilteredRestoreGraphProjectInputItemsWithoutDuplicates)", Targets: "_IsProjectRestoreSupported", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
	if ( 'true' != 'true' )
	{
		MSBuild(Projects: "", Targets: "_IsProjectRestoreSupported", Properties: "ExcludeRestorePackageImports=true");
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
	/*MSBuild(Projects: "@(_GenerateRestoreGraphProjectEntryInput)", Targets: "_GenerateRestoreGraphProjectEntry", BuildInParallel: "$(RestoreBuildInParallel)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	MSBuild(Projects: "", Targets: "_GenerateRestoreGraphProjectEntry", BuildInParallel: "true", Properties: "ExcludeRestorePackageImports=true");
	/*MSBuild(Projects: "@(_RestoreProjectPathItems)", Targets: "_GenerateProjectRestoreGraph", BuildInParallel: "$(RestoreBuildInParallel)", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	MSBuild(Projects: "", Targets: "_GenerateProjectRestoreGraph", BuildInParallel: "true", Properties: "ExcludeRestorePackageImports=true");

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

	/*GetRestoreDotnetCliToolsTask(DotnetCliToolReferences: "@(DotnetCliToolReference)", ProjectPath: "$(MSBuildProjectFullPath)", RestoreFallbackFolders: "$(_OutputFallbackFolders)", RestorePackagesPath: "$(_OutputPackagesPath)", RestoreConfigFilePaths: "$(_OutputConfigFilePaths)", RestoreSources: "$(_OutputSources)", ToolFramework: "$(DotnetCliToolTargetFramework)");*/
	/* if ( '$(RestoreDotnetCliToolReferences)' == '' OR '$(RestoreDotnetCliToolReferences)' == 'true' )*/
	if ( '' == '' OR '' == 'true' )
	{
		GetRestoreDotnetCliToolsTask(DotnetCliToolReferences: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", RestoreFallbackFolders: "", RestorePackagesPath: "", RestoreConfigFilePaths: "", RestoreSources: "", ToolFramework: "netcoreapp2.2");
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

	/*GetRestoreProjectStyleTask(RestoreProjectStyle: "$(RestoreProjectStyle)", MSBuildProjectName: "$(MSBuildProjectName)", ProjectJsonPath: "$(_CurrentProjectJsonPath)", HasPackageReferenceItems: "$(_HasPackageReferenceItems)", MSBuildProjectDirectory: "$(MSBuildProjectDirectory)");*/
	GetRestoreProjectStyleTask(RestoreProjectStyle: "PackageReference", MSBuildProjectName: "6 - targets", ProjectJsonPath: "", HasPackageReferenceItems: "", MSBuildProjectDirectory: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets");

	_GetRestoreProjectStyleRun = true;
}

void EnableIntermediateOutputPathMismatchWarning()
{
	// if ('$(RestoreProjectStyle)' == 'PackageReference')
	if ('PackageReference' == 'PackageReference') { EnableIntermediateOutputPathMismatchWarningRun = true; return; }
	// DependsOnTargets;
	if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();

	EnableIntermediateOutputPathMismatchWarningRun = true;
}

void _GetRestoreTargetFrameworksOutput()
{
	// DependsOnTargets;
	if (!_GetRestoreProjectStyleRun) _GetRestoreProjectStyle();
	if (!_GetRestoreTargetFrameworkOverrideRun) _GetRestoreTargetFrameworkOverride();

	/*GetProjectTargetFrameworksTask(TargetFramework: "$(TargetFramework)", TargetFrameworks: "$(_TargetFrameworkToBeUsed)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", ProjectPath: "$(MSBuildProjectFullPath)", TargetPlatformMinVersion: "$(TargetPlatformMinVersion)", TargetPlatformVersion: "$(TargetPlatformVersion)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	/* if ( '$(RestoreProjectStyle)' != 'ProjectJson')*/
	if ( 'PackageReference' != 'ProjectJson')
	{
		GetProjectTargetFrameworksTask(TargetFramework: "net8.0", TargetFrameworks: "", TargetPlatformIdentifier: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetPlatformMinVersion: "", TargetPlatformVersion: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");
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

	/*GetRestoreSettingsTask(RestoreProjectStyle: "$(RestoreProjectStyle)", RestoreRootConfigDirectory: "$(RestoreRootConfigDirectory)", RestoreConfigFile: "$(RestoreConfigFile)", RestoreRepositoryPath: "$(RestoreRepositoryPath)", MSBuildStartupDirectory: "$(MSBuildStartupDirectory)", RestoreFallbackFolders: "$(RestoreFallbackFolders)", RestoreSettingsPerFramework: "@(_RestoreSettingsPerFramework)", RestorePackagesPath: "$(RestorePackagesPath)", RestoreFallbackFoldersOverride: "$(_RestoreFallbackFoldersOverride)", ProjectUniqueName: "$(MSBuildProjectFullPath)", RestoreSourcesOverride: "$(_RestoreSourcesOverride)", RestoreRepositoryPathOverride: "$(_RestoreRepositoryPathOverride)", RestorePackagesPathOverride: "$(_RestorePackagesPathOverride)", RestoreSources: "$(RestoreSources)", RestoreSolutionDirectory: "$(RestoreSolutionDirectory)");*/
	GetRestoreSettingsTask(RestoreProjectStyle: "PackageReference", RestoreRootConfigDirectory: "", RestoreConfigFile: "", RestoreRepositoryPath: "", MSBuildStartupDirectory: "D:\\d\\kant\\GitHub\\msbuildtranslator\\msbuildtranslator\\bin\\Debug\\net8.0", RestoreFallbackFolders: "", RestoreSettingsPerFramework: "", RestorePackagesPath: "", RestoreFallbackFoldersOverride: "", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", RestoreSourcesOverride: "", RestoreRepositoryPathOverride: "", RestorePackagesPathOverride: "", RestoreSources: "", RestoreSolutionDirectory: "");

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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetRestoreSettingsPerFramework", BuildInParallel: "$(RestoreBuildInParallel)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetRestoreSettingsPerFramework", BuildInParallel: "true", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GenerateProjectRestoreGraphPerFramework", BuildInParallel: "$(RestoreBuildInParallel)", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GenerateProjectRestoreGraphPerFramework", BuildInParallel: "true", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
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

	/*GetRestoreProjectReferencesTask(ParentProjectPath: "$(MSBuildProjectFullPath)", TargetFrameworks: "$(TargetFramework)", ProjectUniqueName: "$(MSBuildProjectFullPath)", ProjectReferences: "@(ProjectReference)");*/
	GetRestoreProjectReferencesTask(ParentProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetFrameworks: "net8.0", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ProjectReferences: "");
	/*GetRestorePackageReferencesTask(TargetFrameworks: "$(TargetFramework)", PackageReferences: "@(PackageReference)", ProjectUniqueName: "$(MSBuildProjectFullPath)");*/
	/* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
	if ( '' == 'true' )
	{
		GetRestorePackageReferencesTask(TargetFrameworks: "net8.0", PackageReferences: "", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
	}
	/*GetCentralPackageVersionsTask(CentralPackageVersions: "@(PackageVersion)", TargetFrameworks: "$(TargetFramework)", ProjectUniqueName: "$(MSBuildProjectFullPath)");*/
	/* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' AND '$(_CentralPackageVersionsEnabled)' == 'true' )*/
	if ( '' == 'true' AND '' == 'true' )
	{
		GetCentralPackageVersionsTask(CentralPackageVersions: "", TargetFrameworks: "net8.0", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
	}
	/*GetRestorePackageDownloadsTask(TargetFrameworks: "$(TargetFramework)", PackageDownloads: "@(PackageDownload)", ProjectUniqueName: "$(MSBuildProjectFullPath)");*/
	/* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
	if ( '' == 'true' )
	{
		GetRestorePackageDownloadsTask(TargetFrameworks: "net8.0", PackageDownloads: "", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
	}
	/*GetRestoreFrameworkReferencesTask(TargetFrameworks: "$(TargetFramework)", FrameworkReferences: "@(FrameworkReference)", ProjectUniqueName: "$(MSBuildProjectFullPath)");*/
	/* if ( '$(PackageReferenceCompatibleProjectStyle)' == 'true' )*/
	if ( '' == 'true' )
	{
		GetRestoreFrameworkReferencesTask(TargetFrameworks: "net8.0", FrameworkReferences: "Microsoft.NETCore.App", ProjectUniqueName: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");
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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GenerateRestoreProjectPathItemsPerFramework", SkipNonexistentTargets: "true", BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentProjects: "true", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
	if ( 'true' == 'true' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GenerateRestoreProjectPathItemsPerFramework", SkipNonexistentTargets: "true", BuildInParallel: "true", SkipNonexistentProjects: "true", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""");
	}
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GenerateRestoreProjectPathItemsPerFramework", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  $(_GenerateRestoreGraphProjectEntryInputProperties)""");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
	if ( 'true' != 'true' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GenerateRestoreProjectPathItemsPerFramework", Properties: """TargetFramework=%(_RestoreTargetFrameworkItems.Identity);
                  ExcludeRestorePackageImports=true""");
	}

	_GenerateRestoreProjectPathItemsAllFrameworksRun = true;
}

void _GenerateRestoreProjectPathWalk()
{
	// DependsOnTargets;
	if (!_GenerateRestoreProjectPathItemsRun) _GenerateRestoreProjectPathItems();

	/*MSBuild(Projects: "@(_CurrentRestoreProjectPathItems)", Targets: "_GenerateRestoreProjectPathWalk", SkipNonexistentTargets: "true", BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentProjects: "true", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
	if ( 'true' == 'true' )
	{
		MSBuild(Projects: "", Targets: "_GenerateRestoreProjectPathWalk", SkipNonexistentTargets: "true", BuildInParallel: "true", SkipNonexistentProjects: "true", Properties: "ExcludeRestorePackageImports=true");
	}
	/*MSBuild(Projects: "@(_CurrentRestoreProjectPathItems)", Targets: "_GenerateRestoreProjectPathWalk", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
	if ( 'true' != 'true' )
	{
		MSBuild(Projects: "", Targets: "_GenerateRestoreProjectPathWalk", Properties: "ExcludeRestorePackageImports=true");
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
	/*MSBuild(Projects: "@(FilteredRestoreGraphProjectInputItems)", Targets: "_GenerateRestoreProjectPathWalk", SkipNonexistentTargets: "true", BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentProjects: "true", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
	if ( 'true' == 'true' )
	{
		MSBuild(Projects: "", Targets: "_GenerateRestoreProjectPathWalk", SkipNonexistentTargets: "true", BuildInParallel: "true", SkipNonexistentProjects: "true", Properties: "ExcludeRestorePackageImports=true");
	}
	/*MSBuild(Projects: "@(FilteredRestoreGraphProjectInputItems)", Targets: "_GenerateRestoreProjectPathWalk", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
	if ( 'true' != 'true' )
	{
		MSBuild(Projects: "", Targets: "_GenerateRestoreProjectPathWalk", Properties: "ExcludeRestorePackageImports=true");
	}
	/*RemoveDuplicates(Inputs: "@(_RestoreProjectPathItemsOutputs)");*/
	RemoveDuplicates(Inputs: "");
	/*MSBuild(Projects: "@(_RestoreProjectPathItemsWithoutDupes)", Targets: "_IsProjectRestoreSupported", SkipNonexistentTargets: "true", BuildInParallel: "$(RestoreBuildInParallel)", SkipNonexistentProjects: "true", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' == 'true' )*/
	if ( 'true' == 'true' )
	{
		MSBuild(Projects: "", Targets: "_IsProjectRestoreSupported", SkipNonexistentTargets: "true", BuildInParallel: "true", SkipNonexistentProjects: "true", Properties: "ExcludeRestorePackageImports=true");
	}
	/*MSBuild(Projects: "@(_RestoreProjectPathItemsWithoutDupes)", Targets: "_IsProjectRestoreSupported", Properties: "$(_GenerateRestoreGraphProjectEntryInputProperties)");*/
	/* if ( '$(RestoreUseSkipNonexistentTargets)' != 'true' )*/
	if ( 'true' != 'true' )
	{
		MSBuild(Projects: "", Targets: "_IsProjectRestoreSupported", Properties: "ExcludeRestorePackageImports=true");
	}

	_GetAllRestoreProjectPathItemsRun = true;
}

void _GetRestoreSettingsOverrides()
{

	/*MSBuild(Projects: "$(MSBuildThisFileFullPath)", Targets: "_GetRestorePackagesPathOverride", BuildInParallel: "$(RestoreBuildInParallel)");*/
	/* if ( '$(RestorePackagesPath)' != '' )*/
	if ( '' != '' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetRestorePackagesPathOverride", BuildInParallel: "true");
	}
	/*MSBuild(Projects: "$(MSBuildThisFileFullPath)", Targets: "_GetRestoreRepositoryPathOverride", BuildInParallel: "$(RestoreBuildInParallel)");*/
	/* if ( '$(RestoreRepositoryPathOverride)' != '' )*/
	if ( '' != '' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetRestoreRepositoryPathOverride", BuildInParallel: "true");
	}
	/*MSBuild(Projects: "$(MSBuildThisFileFullPath)", Targets: "_GetRestoreSourcesOverride", BuildInParallel: "$(RestoreBuildInParallel)");*/
	/* if ( '$(RestoreSources)' != '' )*/
	if ( '' != '' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetRestoreSourcesOverride", BuildInParallel: "true");
	}
	/*MSBuild(Projects: "$(MSBuildThisFileFullPath)", Targets: "_GetRestoreFallbackFoldersOverride", BuildInParallel: "$(RestoreBuildInParallel)");*/
	/* if ( '$(RestoreFallbackFolders)' != '' )*/
	if ( '' != '' )
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetRestoreFallbackFoldersOverride", BuildInParallel: "true");
	}

	_GetRestoreSettingsOverridesRun = true;
}

void _GetRestorePackagesPathOverride()
{

	_GetRestorePackagesPathOverrideRun = true;
}

void _GetRestoreRepositoryPathOverride()
{

	_GetRestoreRepositoryPathOverrideRun = true;
}

void _GetRestoreSourcesOverride()
{

	_GetRestoreSourcesOverrideRun = true;
}

void _GetRestoreFallbackFoldersOverride()
{

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
	/*VSTestTask2(VSTestBlameHangDumpType: "$(VSTestBlameHangDumpType)", VSTestSetting: "$([MSBuild]::ValueOrDefault($(VSTestSetting), '$(RunSettingsFilePath)'))", VSTestSessionCorrelationId: "$(VSTestSessionCorrelationId)", VSTestArtifactsProcessingMode: "$(VSTestArtifactsProcessingMode)", VSTestCollect: "$(VSTestCollect)", VSTestListTests: "$(VSTestListTests)", VSTestFramework: "$(TargetFrameworkMoniker)", VSTestConsolePath: "$(VSTestConsolePath)", VSTestNoLogo: "$(VSTestNoLogo)", VSTestPlatform: "$(PlatformTarget)", VSTestCLIRunSettings: "$(VSTestCLIRunSettings)", VSTestBlameHang: "$(VSTestBlameHang)", VSTestBlameCrash: "$(VSTestBlameCrash)", VSTestResultsDirectory: "$(VSTestResultsDirectory)", VSTestBlame: "$(VSTestBlame)", TestFileFullPath: "$(TargetPath)", VSTestBlameHangTimeout: "$(VSTestBlameHangTimeout)", VSTestTestAdapterPath: "$(VSTestTestAdapterPath)", VSTestTestCaseFilter: "$(VSTestTestCaseFilter)", VSTestDiag: "$(VSTestDiag)", VSTestBlameCrashDumpType: "$(VSTestBlameCrashDumpType)", VSTestBlameCrashCollectAlways: "$(VSTestBlameCrashCollectAlways)", VSTestTraceDataCollectorDirectoryPath: "$(TraceDataCollectorDirectoryPath)", VSTestLogger: "$(VSTestLogger)", VSTestVerbosity: "$(VSTestVerbosity)");*/
	VSTestTask2(VSTestBlameHangDumpType: "", VSTestSetting: "", VSTestSessionCorrelationId: "", VSTestArtifactsProcessingMode: "", VSTestCollect: "", VSTestListTests: "", VSTestFramework: ".NETCoreApp,Version=v8.0", VSTestConsolePath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll", VSTestNoLogo: "", VSTestPlatform: "", VSTestCLIRunSettings: "", VSTestBlameHang: "", VSTestBlameCrash: "", VSTestResultsDirectory: "", VSTestBlame: "", TestFileFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", VSTestBlameHangTimeout: "", VSTestTestAdapterPath: "", VSTestTestCaseFilter: "", VSTestDiag: "", VSTestBlameCrashDumpType: "", VSTestBlameCrashCollectAlways: "", VSTestTraceDataCollectorDirectoryPath: "", VSTestLogger: "", VSTestVerbosity: "");

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
	/*VSTestTask(VSTestBlameHangDumpType: "$(VSTestBlameHangDumpType)", VSTestSetting: "$([MSBuild]::ValueOrDefault($(VSTestSetting), '$(RunSettingsFilePath)'))", VSTestSessionCorrelationId: "$(VSTestSessionCorrelationId)", VSTestArtifactsProcessingMode: "$(VSTestArtifactsProcessingMode)", VSTestCollect: "$(VSTestCollect)", VSTestListTests: "$(VSTestListTests)", VSTestFramework: "$(TargetFrameworkMoniker)", VSTestConsolePath: "$(VSTestConsolePath)", VSTestNoLogo: "$(VSTestNoLogo)", VSTestPlatform: "$(PlatformTarget)", VSTestCLIRunSettings: "$(VSTestCLIRunSettings)", VSTestBlameHang: "$(VSTestBlameHang)", VSTestBlameCrash: "$(VSTestBlameCrash)", VSTestResultsDirectory: "$(VSTestResultsDirectory)", VSTestBlame: "$(VSTestBlame)", TestFileFullPath: "$(TargetPath)", VSTestBlameHangTimeout: "$(VSTestBlameHangTimeout)", VSTestTestAdapterPath: "$(VSTestTestAdapterPath)", VSTestTestCaseFilter: "$(VSTestTestCaseFilter)", VSTestDiag: "$(VSTestDiag)", VSTestBlameCrashDumpType: "$(VSTestBlameCrashDumpType)", VSTestBlameCrashCollectAlways: "$(VSTestBlameCrashCollectAlways)", VSTestTraceDataCollectorDirectoryPath: "$(TraceDataCollectorDirectoryPath)", VSTestLogger: "$(VSTestLogger)", VSTestVerbosity: "$(VSTestVerbosity)");*/
	/* if ('$(IsTestProject)' == 'true')*/
	if ('' == 'true')
	{
		VSTestTask(VSTestBlameHangDumpType: "", VSTestSetting: "", VSTestSessionCorrelationId: "", VSTestArtifactsProcessingMode: "", VSTestCollect: "", VSTestListTests: "", VSTestFramework: ".NETCoreApp,Version=v8.0", VSTestConsolePath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\vstest.console.dll", VSTestNoLogo: "", VSTestPlatform: "", VSTestCLIRunSettings: "", VSTestBlameHang: "", VSTestBlameCrash: "", VSTestResultsDirectory: "", VSTestBlame: "", TestFileFullPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.dll", VSTestBlameHangTimeout: "", VSTestTestAdapterPath: "", VSTestTestCaseFilter: "", VSTestDiag: "", VSTestBlameCrashDumpType: "", VSTestBlameCrashCollectAlways: "", VSTestTraceDataCollectorDirectoryPath: "", VSTestLogger: "", VSTestVerbosity: "");
	}

	_VSTestConsoleRun = true;
}

void ShowInfoMessageIfProjectHasNoIsTestProjectProperty()
{
	// if ('$(IsTestProject)' == '')
	if ('' == '') { ShowInfoMessageIfProjectHasNoIsTestProjectPropertyRun = true; return; }

	/*VSTestLogsTask(LogType: "NoIsTestProjectProperty", ProjectFilePath: "$(MSBuildProjectFullPath)");*/
	VSTestLogsTask(LogType: "NoIsTestProjectProperty", ProjectFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj");

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

	/*CheckForTargetInAssetsFile(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", RuntimeIdentifier: "$(RuntimeIdentifier)");*/
	/* if ( '$(DesignTimeBuild)' != 'true')*/
	if ( '' != 'true')
	{
		CheckForTargetInAssetsFile(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", RuntimeIdentifier: "");
	}
	/*ResolvePackageDependencies(TargetFramework: "$(TargetFramework)", ProjectAssetsFile: "$(ProjectAssetsFile)", ProjectPath: "$(MSBuildProjectFullPath)", ProjectLanguage: "$(Language)");*/
	/* if ('$(EmitLegacyAssetsFileItems)' == 'true')*/
	if ('false' == 'true')
	{
		ResolvePackageDependencies(TargetFramework: "net8.0", ProjectAssetsFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", ProjectLanguage: "C#");
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

	/*ResolvePackageAssets(ExpectedPlatformPackages: "@(ExpectedPlatformPackages)", TargetFramework: "$(TargetFramework)", ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", EnsureRuntimePackageDependencies: "$(EnsureRuntimePackageDependencies)", ProjectAssetsFile: "$(ProjectAssetsFile)", PackageReferences: "@(PackageReference)", CopyLocalRuntimeTargetAssets: "$(CopyLocalRuntimeTargetAssets)", ProjectPath: "$(MSBuildProjectFullPath)", IsSelfContained: "$(SelfContained)", ProjectAssetsCacheFile: "$(ProjectAssetsCacheFile)", DisableTransitiveProjectReferences: "$(DisableTransitiveProjectReferences)", CompilerApiVersion: "$(CompilerApiVersion)", ProjectLanguage: "$(Language)", VerifyMatchingImplicitPackageVersion: "$(VerifyMatchingImplicitPackageVersion)", RuntimeIdentifier: "$(RuntimeIdentifier)", DisableFrameworkAssemblies: "$(DisableLockFileFrameworks)", MarkPackageReferencesAsExternallyResolved: "$(MarkPackageReferencesAsExternallyResolved)", DesignTimeBuild: "$(DesignTimeBuild)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", EmitAssetsLogMessages: "$(EmitAssetsLogMessages)", DisableTransitiveFrameworkReferences: "$(DisableTransitiveFrameworkReferences)", RuntimeFrameworks: "@(RuntimeFramework)", SatelliteResourceLanguages: "$(SatelliteResourceLanguages)", DotNetAppHostExecutableNameWithoutExtension: "$(_DotNetAppHostExecutableNameWithoutExtension)", DisablePackageAssetsCache: "$(DisablePackageAssetsCache)", DefaultImplicitPackages: "$(DefaultImplicitPackages)");*/
	ResolvePackageAssets(ExpectedPlatformPackages: "", TargetFramework: "net8.0", ShimRuntimeIdentifiers: "", EnsureRuntimePackageDependencies: "", ProjectAssetsFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", PackageReferences: "", CopyLocalRuntimeTargetAssets: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", IsSelfContained: "false", ProjectAssetsCacheFile: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.assets.cache", DisableTransitiveProjectReferences: "", CompilerApiVersion: "roslyn4.9", ProjectLanguage: "C#", VerifyMatchingImplicitPackageVersion: "true", RuntimeIdentifier: "", DisableFrameworkAssemblies: "", MarkPackageReferencesAsExternallyResolved: "true", DesignTimeBuild: "", PlatformLibraryName: "", EmitAssetsLogMessages: "true", DisableTransitiveFrameworkReferences: "", RuntimeFrameworks: "", SatelliteResourceLanguages: "", DotNetAppHostExecutableNameWithoutExtension: "apphost", DisablePackageAssetsCache: "", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library");

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

	/*CollectSDKReferencesDesignTime(PackageReferences: "@(PackageReference)", SdkReferences: "@(SdkReference)", DefaultImplicitPackages: "$(DefaultImplicitPackages)");*/
	CollectSDKReferencesDesignTime(PackageReferences: "", SdkReferences: "", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library");

	CollectSDKReferencesDesignTimeRun = true;
}

void CollectResolvedSDKReferencesDesignTime()
{
	// DependsOnTargets;
	if (!ResolveSDKReferencesDesignTimeRun) ResolveSDKReferencesDesignTime();
	if (!CollectPackageReferencesRun) CollectPackageReferences();

	/*CollectSDKReferencesDesignTime(PackageReferences: "@(PackageReference)", SdkReferences: "@(ResolvedSdkReference)", DefaultImplicitPackages: "$(DefaultImplicitPackages)");*/
	CollectSDKReferencesDesignTime(PackageReferences: "", SdkReferences: "", DefaultImplicitPackages: "Microsoft.NETCore.App;NETStandard.Library");

	CollectResolvedSDKReferencesDesignTimeRun = true;
}

void RunProduceContentAssets()
{
	// if ('@(_ContentFilesToPreprocess)' != '' and '$(_CleaningWithoutRebuilding)' != 'true')
	if ('' != '' and '' != 'true') { RunProduceContentAssetsRun = true; return; }
	// DependsOnTargets;
	if (!ResolvePackageAssetsRun) ResolvePackageAssets();

	/*ProduceContentAssets(ContentPreprocessorValues: "@(PreprocessorValue)", ProjectLanguage: "$(Language)", ContentPreprocessorOutputDirectory: "$(ContentPreprocessorOutputDirectory)", ProduceOnlyPreprocessorFiles: "true", ContentFileDependencies: "@(_ContentFilesToPreprocess)");*/
	ProduceContentAssets(ContentPreprocessorValues: "rootnamespace;assemblyname;fullpath;outputfilename;filename", ProjectLanguage: "C#", ContentPreprocessorOutputDirectory: "obj\\Debug\\net8.0\\NuGet\\", ProduceOnlyPreprocessorFiles: "true", ContentFileDependencies: "");
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

	/*JoinItems(LeftMetadata: "*", RightKey: "", Left: "@(ResolvedCompileFileDefinitions)", LeftKey: "FileName", Right: "@(Reference)", RightMetadata: "*");*/
	JoinItems(LeftMetadata: "*", RightKey: "", Left: "", LeftKey: "FileName", Right: "", RightMetadata: "*");

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

	/*CheckIfPackageReferenceShouldBeFrameworkReference(PackageReferences: "@(PackageReference)", FrameworkReferences: "@(FrameworkReference)", PackageReferenceToReplace: "Microsoft.AspNetCore.All", FrameworkReferenceToUse: "Microsoft.AspNetCore.App");*/
	CheckIfPackageReferenceShouldBeFrameworkReference(PackageReferences: "", FrameworkReferences: "Microsoft.NETCore.App", PackageReferenceToReplace: "Microsoft.AspNetCore.All", FrameworkReferenceToUse: "Microsoft.AspNetCore.App");
	/* if ('$(_ShouldRemoveAspNetCoreAll)' == 'true')*/
	if ('' == 'true')
	{
		NETSdkError(ResourceName: "AspNetCoreAllNotSupported");
	}
	/*CheckIfPackageReferenceShouldBeFrameworkReference(PackageReferences: "@(PackageReference)", FrameworkReferences: "@(FrameworkReference)", PackageReferenceToReplace: "Microsoft.AspNetCore.App", FrameworkReferenceToUse: "Microsoft.AspNetCore.App");*/
	CheckIfPackageReferenceShouldBeFrameworkReference(PackageReferences: "", FrameworkReferences: "Microsoft.NETCore.App", PackageReferenceToReplace: "Microsoft.AspNetCore.App", FrameworkReferenceToUse: "Microsoft.AspNetCore.App");
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

	/*ApplyImplicitVersions(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", PackageReferences: "@(PackageReference)", TargetLatestRuntimePatch: "$(TargetLatestRuntimePatch)", ImplicitPackageReferenceVersions: "@(ImplicitPackageReferenceVersion)");*/
	ApplyImplicitVersions(TargetFrameworkVersion: "8.0", PackageReferences: "", TargetLatestRuntimePatch: "false", ImplicitPackageReferenceVersions: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.AspNetCore.App;Microsoft.AspNetCore.All;Microsoft.AspNetCore.App;Microsoft.AspNetCore.All");

	ApplyImplicitVersionsRun = true;
}

void CheckForImplicitPackageReferenceOverrides()
{
	// BeforeTargets;
	if (!IncludeTargetingPackReferenceRun) IncludeTargetingPackReference();

	/*CheckForImplicitPackageReferenceOverrides(MoreInformationLink: "$(ImplicitPackageReferenceInformationLink)", PackageReferenceItems: "@(PackageReference)");*/
	CheckForImplicitPackageReferenceOverrides(MoreInformationLink: "", PackageReferenceItems: "");

	CheckForImplicitPackageReferenceOverridesRun = true;
}

void CheckForDuplicateItems()
{

	/*CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultCompileItems", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultCompileItems)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", DefaultItemsEnabled: "$(EnableDefaultItems)", Items: "@(Compile)", ItemName: "Compile");*/
	CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultCompileItems", DefaultItemsOfThisTypeEnabled: "true", MoreInformationLink: "", DefaultItemsEnabled: "true", Items: "Program.cs", ItemName: "Compile");
	/*CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultEmbeddedResourceItems", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultEmbeddedResourceItems)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", DefaultItemsEnabled: "$(EnableDefaultItems)", Items: "@(EmbeddedResource)", ItemName: "EmbeddedResource");*/
	CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultEmbeddedResourceItems", DefaultItemsOfThisTypeEnabled: "true", MoreInformationLink: "", DefaultItemsEnabled: "true", Items: "", ItemName: "EmbeddedResource");
	/*CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultContentItems", DefaultItemsOfThisTypeEnabled: "$(EnableDefaultContentItems)", MoreInformationLink: "$(DefaultItemsMoreInformationLink)", DefaultItemsEnabled: "$(EnableDefaultItems)", Items: "@(Content)", ItemName: "Content");*/
	CheckForDuplicateItems(PropertyNameToDisableDefaultItems: "EnableDefaultContentItems", DefaultItemsOfThisTypeEnabled: "", MoreInformationLink: "", DefaultItemsEnabled: "true", Items: "", ItemName: "Content");

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

	/*NetSdkError(FormatArguments: "$(SdkResolverGlobalJsonPath)", ResourceName: "GlobalJsonSDKResolutionFailed");*/
	NetSdkError(FormatArguments: "", ResourceName: "GlobalJsonSDKResolutionFailed");

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

	/*NETSdkError(FormatArguments: "PackRelease;$(ProjectName)", ResourceName: "SolutionProjectConfigurationsConflict");*/
	/* if ('$(SolutionExt)' == '.sln' and
                            '$(_SolutionLevelPackRelease)' != '$(PackRelease)')*/
	if ('*Undefined*' == '.sln' and
                            '' != 'true')
	{
		NETSdkError(FormatArguments: "PackRelease;6 - targets", ResourceName: "SolutionProjectConfigurationsConflict");
	}

	_VerifyPackReleaseConfigurationsRun = true;
}

void AddWindowsSdkKnownFrameworkReferences()
{
	// if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp' And '$(TargetPlatformIdentifier)' == 'Windows')
	if ('.NETCoreApp' == '.NETCoreApp' And '' == 'Windows') { AddWindowsSdkKnownFrameworkReferencesRun = true; return; }

	/*CreateWindowsSdkKnownFrameworkReferences(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", WindowsSdkPackageVersion: "$(WindowsSdkPackageVersion)", TargetPlatformVersion: "$(TargetPlatformVersion)", WindowsSdkSupportedTargetPlatformVersions: "@(WindowsSdkSupportedTargetPlatformVersion)", UseWindowsSDKPreview: "$(UseWindowsSDKPreview)");*/
	CreateWindowsSdkKnownFrameworkReferences(TargetFrameworkVersion: "8.0", TargetPlatformIdentifier: "", TargetFrameworkIdentifier: ".NETCoreApp", WindowsSdkPackageVersion: "", TargetPlatformVersion: "", WindowsSdkSupportedTargetPlatformVersions: "10.0.22621.0;10.0.22000.0;10.0.20348.0;10.0.19041.0;10.0.18362.0;10.0.17763.0;10.0.22000.0;10.0.20348.0;10.0.19041.0;10.0.18362.0;10.0.17763.0;8.0;7.0", UseWindowsSDKPreview: "");

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

	/*CheckForDuplicateFrameworkReferences(MoreInformationLink: "https://aka.ms/sdkimplicitrefs", FrameworkReferences: "@(FrameworkReference)");*/
	CheckForDuplicateFrameworkReferences(MoreInformationLink: "https://aka.ms/sdkimplicitrefs", FrameworkReferences: "Microsoft.NETCore.App");
	/*ProcessFrameworkReferences(TargetLatestRuntimePatchIsDefault: "$(_TargetLatestRuntimePatchIsDefault)", EnableRuntimePackDownload: "$(EnableRuntimePackDownload)", UsingMicrosoftNETSdkWebAssembly: "$(UsingMicrosoftNETSdkWebAssembly)", TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", SilenceIsTrimmableUnsupportedWarning: "$(_SilenceIsTrimmableUnsupportedWarning)", KnownRuntimePacks: "@(KnownRuntimePack)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", SilenceEnableSingleFileAnalyzerUnsupportedWarning: "$(_SilenceEnableSingleFileAnalyzerUnsupportedWarning)", TargetingPackRoot: "$(NetCoreTargetingPackRoot)", MinNonEolTargetFrameworkForAot: "$(_MinNonEolTargetFrameworkForAot)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", KnownFrameworkReferences: "@(KnownFrameworkReference)", EnableWindowsTargeting: "$(EnableWindowsTargeting)", NETCoreSdkVersion: "$(NETCoreSdkVersion)", FrameworkReferences: "@(FrameworkReference)", IsTrimmable: "$(IsTrimmable)", KnownILLinkPacks: "@(KnownILLinkPack)", RuntimeIdentifier: "$(RuntimeIdentifier)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", PublishAot: "$(PublishAot)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", TargetPlatformVersion: "$(TargetPlatformVersion)", EnableTargetingPackDownload: "$(EnableTargetingPackDownload)", AotUseKnownRuntimePackForTarget: "$(PublishAotUsingRuntimePack)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", ReadyToRunEnabled: "$(PublishReadyToRun)", KnownILCompilerPacks: "@(KnownILCompilerPack)", SelfContained: "$(SelfContained)", KnownCrossgen2Packs: "@(KnownCrossgen2Pack)", RequiresILLinkPack: "$(_RequiresILLinkPack)", EnableTrimAnalyzer: "$(EnableTrimAnalyzer)", NetCoreRoot: "$(NetCoreRoot)", MinNonEolTargetFrameworkForTrimming: "$(_MinNonEolTargetFrameworkForTrimming)", SilenceIsAotCompatibleUnsupportedWarning: "$(_SilenceIsAotCompatibleUnsupportedWarning)", MinNonEolTargetFrameworkForSingleFile: "$(_MinNonEolTargetFrameworkForSingleFile)", KnownWebAssemblySdkPacks: "@(KnownWebAssemblySdkPack)", PublishTrimmed: "$(PublishTrimmed)", EnableSingleFileAnalyzer: "$(EnableSingleFileAnalyzer)", NETCoreSdkRuntimeIdentifier: "$(NETCoreSdkRuntimeIdentifier)", TargetLatestRuntimePatch: "$(TargetLatestRuntimePatch)", RuntimeIdentifiers: "$(RuntimeIdentifiers)", RuntimeFrameworkVersion: "$(RuntimeFrameworkVersion)", IsAotCompatible: "$(IsAotCompatible)", EnableAotAnalyzer: "$(EnableAotAnalyzer)");*/
	ProcessFrameworkReferences(TargetLatestRuntimePatchIsDefault: "true", EnableRuntimePackDownload: "", UsingMicrosoftNETSdkWebAssembly: "", TargetFrameworkVersion: "8.0", SilenceIsTrimmableUnsupportedWarning: "", KnownRuntimePacks: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App", TargetPlatformIdentifier: "", SilenceEnableSingleFileAnalyzerUnsupportedWarning: "", TargetingPackRoot: "C:\\Program Files\\dotnet\\packs", MinNonEolTargetFrameworkForAot: "", TargetFrameworkIdentifier: ".NETCoreApp", KnownFrameworkReferences: "Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.Windows.SDK.NET.Ref;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;Microsoft.NETCore.App;Microsoft.WindowsDesktop.App;Microsoft.WindowsDesktop.App.WPF;Microsoft.WindowsDesktop.App.WindowsForms;Microsoft.AspNetCore.App;NETStandard.Library", EnableWindowsTargeting: "", NETCoreSdkVersion: "8.0.200-preview.23624.5", FrameworkReferences: "Microsoft.NETCore.App", IsTrimmable: "", KnownILLinkPacks: "Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks;Microsoft.NET.ILLink.Tasks", RuntimeIdentifier: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", PublishAot: "", DisableTransitiveFrameworkReferenceDownloads: "", TargetPlatformVersion: "", EnableTargetingPackDownload: "", AotUseKnownRuntimePackForTarget: "", ReadyToRunUseCrossgen2: "true", ReadyToRunEnabled: "", KnownILCompilerPacks: "Microsoft.DotNet.ILCompiler;Microsoft.DotNet.ILCompiler", SelfContained: "false", KnownCrossgen2Packs: "Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2;Microsoft.NETCore.App.Crossgen2", RequiresILLinkPack: "", EnableTrimAnalyzer: "", NetCoreRoot: "C:\\Program Files\\dotnet\\", MinNonEolTargetFrameworkForTrimming: "", SilenceIsAotCompatibleUnsupportedWarning: "", MinNonEolTargetFrameworkForSingleFile: "", KnownWebAssemblySdkPacks: "Microsoft.NET.Sdk.WebAssembly.Pack;Microsoft.NET.Sdk.WebAssembly.Pack;Microsoft.NET.Sdk.WebAssembly.Pack", PublishTrimmed: "", EnableSingleFileAnalyzer: "", NETCoreSdkRuntimeIdentifier: "win-x64", TargetLatestRuntimePatch: "false", RuntimeIdentifiers: "", RuntimeFrameworkVersion: "", IsAotCompatible: "", EnableAotAnalyzer: "");
	/*ResolveAppHosts(DotNetComHostLibraryNameWithoutExtension: "$(_DotNetComHostLibraryNameWithoutExtension)", NetCoreTargetingPackRoot: "$(NetCoreTargetingPackRoot)", DotNetSingleFileHostExecutableNameWithoutExtension: "$(_DotNetSingleFileHostExecutableNameWithoutExtension)", TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", TargetingPackRoot: "$(NetCoreTargetingPackRoot)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", EnableAppHostPackDownload: "$(EnableAppHostPackDownload)", DotNetIjwHostLibraryNameWithoutExtension: "$(_DotNetIjwHostLibraryNameWithoutExtension)", AppHostRuntimeIdentifier: "$(AppHostRuntimeIdentifier)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", NuGetRestoreSupported: "$(_NuGetRestoreSupported)", PackAsToolShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", KnownAppHostPacks: "@(KnownAppHostPack)", DotNetAppHostExecutableNameWithoutExtension: "$(_DotNetAppHostExecutableNameWithoutExtension)", RuntimeFrameworkVersion: "$(RuntimeFrameworkVersion)", OtherRuntimeIdentifiers: "$(RuntimeIdentifiers)");*/
	ResolveAppHosts(DotNetComHostLibraryNameWithoutExtension: "comhost", NetCoreTargetingPackRoot: "C:\\Program Files\\dotnet\\packs", DotNetSingleFileHostExecutableNameWithoutExtension: "singlefilehost", TargetFrameworkVersion: "8.0", TargetingPackRoot: "C:\\Program Files\\dotnet\\packs", TargetFrameworkIdentifier: ".NETCoreApp", EnableAppHostPackDownload: "", DotNetIjwHostLibraryNameWithoutExtension: "Ijwhost", AppHostRuntimeIdentifier: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", NuGetRestoreSupported: "", PackAsToolShimRuntimeIdentifiers: "", KnownAppHostPacks: "Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App;Microsoft.NETCore.App", DotNetAppHostExecutableNameWithoutExtension: "apphost", RuntimeFrameworkVersion: "", OtherRuntimeIdentifiers: "");

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

	/*ResolveTargetingPackAssets(GenerateErrorForMissingTargetingPacks: "$(GenerateErrorForMissingTargetingPacks)", NetCoreTargetingPackRoot: "$(NetCoreTargetingPackRoot)", FrameworkReferences: "@(FrameworkReference)", ProjectLanguage: "$(Language)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", ResolvedTargetingPacks: "@(ResolvedTargetingPack)", NuGetRestoreSupported: "$(_NuGetRestoreSupported)", RuntimeFrameworks: "@(RuntimeFramework)");*/
	ResolveTargetingPackAssets(GenerateErrorForMissingTargetingPacks: "", NetCoreTargetingPackRoot: "C:\\Program Files\\dotnet\\packs", FrameworkReferences: "Microsoft.NETCore.App", ProjectLanguage: "C#", DisableTransitiveFrameworkReferenceDownloads: "", ResolvedTargetingPacks: "", NuGetRestoreSupported: "", RuntimeFrameworks: "");

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

	/*GetReferenceAssemblyPaths(BypassFrameworkInstallChecks: "true", SuppressNotFoundError: "true", RootPath: "$(TargetFrameworkRootPath)", TargetFrameworkFallbackSearchPaths: "$(TargetFrameworkFallbackSearchPaths)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	GetReferenceAssemblyPaths(BypassFrameworkInstallChecks: "true", SuppressNotFoundError: "true", RootPath: "", TargetFrameworkFallbackSearchPaths: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");

	IncludeTargetingPackReferenceRun = true;
}

void ResolveRuntimePackAssets()
{
	// if ('@(RuntimePack)' != '')
	if ('' != '') { ResolveRuntimePackAssetsRun = true; return; }
	// DependsOnTargets;
	if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();

	/*ResolveRuntimePackAssets(FrameworkReferences: "@(FrameworkReference)", UnavailableRuntimePacks: "@(UnavailableRuntimePack)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", ResolvedRuntimePacks: "@(ResolvedRuntimePack)", DesignTimeBuild: "$(DesignTimeBuild)", SatelliteResourceLanguages: "$(SatelliteResourceLanguages)");*/
	ResolveRuntimePackAssets(FrameworkReferences: "Microsoft.NETCore.App", UnavailableRuntimePacks: "", DisableTransitiveFrameworkReferenceDownloads: "", ResolvedRuntimePacks: "", DesignTimeBuild: "", SatelliteResourceLanguages: "");

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

	/*GenerateDepsFile(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", CompilerOptions: "@(DependencyFileCompilerOptions)", DepsFilePath: "$(ProjectDepsFilePath)", AssemblyExtension: "$(TargetExt)", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", ProjectPath: "$(MSBuildProjectFullPath)", IsSelfContained: "$(SelfContained)", ReferenceSatellitePaths: "@(ReferenceSatellitePaths)", RuntimePackAssets: "@(RuntimePackAsset)", AssemblyName: "$(AssemblyName)", AssemblyVersion: "$(Version)", ValidRuntimeIdentifierPlatformsForAssets: "@(_ValidRuntimeIdentifierPlatformsForAssets)", ReferenceDependencyPaths: "@(ReferenceDependencyPaths)", RuntimeIdentifier: "$(RuntimeIdentifier)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", IncludeMainProject: "$(IncludeMainProjectInDepsFile)", ResolvedNuGetFiles: "@(NativeCopyLocalItems);@(ResourceCopyLocalItems);@(RuntimeCopyLocalItems)", CompileReferences: "@(ResolvedCompileFileDefinitions)", UserRuntimeAssemblies: "@(UserRuntimeAssembly)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssemblySatelliteAssemblies: "@(IntermediateSatelliteAssembliesWithTargetPath)", RuntimeFrameworks: "@(RuntimeFramework)", ReferencePaths: "@(ReferencePath)", ReferenceAssemblies: "@(_ReferenceAssemblies)");*/
	GenerateDepsFile(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", CompilerOptions: "", DepsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.deps.json", AssemblyExtension: ".dll", ResolvedRuntimeTargetsFiles: "", IncludeProjectsNotInAssetsFile: "true", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", IsSelfContained: "false", ReferenceSatellitePaths: "", RuntimePackAssets: "", AssemblyName: "6 - targets", AssemblyVersion: "1.0.0", ValidRuntimeIdentifierPlatformsForAssets: "", ReferenceDependencyPaths: "", RuntimeIdentifier: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", IncludeRuntimeFileVersions: "true", IncludeMainProject: "true", ResolvedNuGetFiles: ";;", CompileReferences: "", UserRuntimeAssemblies: "", PlatformLibraryName: "", AssemblySatelliteAssemblies: "", RuntimeFrameworks: "", ReferencePaths: "", ReferenceAssemblies: "");

	GenerateBuildDependencyFileRun = true;
}

void _GenerateRuntimeConfigurationFilesInputCache()
{
	// DependsOnTargets;
	if (!_DefaultMicrosoftNETPlatformLibraryRun) _DefaultMicrosoftNETPlatformLibrary();

	/*Hash(ItemsToHash: "@(_GenerateRuntimeConfigurationPropertyInputsCacheToHash)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "$(_GenerateRuntimeConfigurationPropertyInputsCacheHash)", File: "$(_GenerateRuntimeConfigurationPropertyInputsCache)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genruntimeconfig.cache");

	_GenerateRuntimeConfigurationFilesInputCacheRun = true;
}

void GenerateBuildRuntimeConfigurationFiles()
{
	// if ( '$(GenerateRuntimeConfigurationFiles)' == 'true')
	if ( 'true' == 'true') { GenerateBuildRuntimeConfigurationFilesRun = true; return; }
	// DependsOnTargets;
	if (!_GenerateRuntimeConfigurationFilesInputCacheRun) _GenerateRuntimeConfigurationFilesInputCache();

	/* if ('$(RollForward)' != '' and '$(RollForward)' != 'Major' and '$(RollForward)' != 'LatestMajor' and '$(_IsRollForwardSupported)' != 'true')*/
	if ('' != '' and '' != 'Major' and '' != 'LatestMajor' and '' != 'true')
	{
		NETSdkError(ResourceName: "RollForwardRequiresVersion30");
	}
	/*GenerateRuntimeConfigurationFiles(TargetFramework: "$(TargetFramework)", WriteIncludedFrameworks: "$(_WriteIncludedFrameworks)", AssetsFilePath: "$(ProjectAssetsFile)", UserRuntimeConfig: "$(UserRuntimeConfig)", GenerateRuntimeConfigDevFile: "$(GenerateRuntimeConfigDevFile)", IsSelfContained: "$(SelfContained)", AlwaysIncludeCoreFramework: "$(AlwaysIncludeCoreFrameworkInRuntimeConfig)", RuntimeIdentifier: "$(RuntimeIdentifier)", AdditionalProbingPaths: "@(AdditionalProbingPath)", RuntimeConfigDevPath: "$(ProjectRuntimeConfigDevFilePath)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", RuntimeConfigPath: "$(ProjectRuntimeConfigFilePath)", RuntimeFrameworks: "@(RuntimeFramework)", RollForward: "$(RollForward)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", HostConfigurationOptions: "@(RuntimeHostConfigurationOption)");*/
	GenerateRuntimeConfigurationFiles(TargetFramework: "net8.0", WriteIncludedFrameworks: "", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", UserRuntimeConfig: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets/runtimeconfig.template.json", GenerateRuntimeConfigDevFile: "false", IsSelfContained: "false", AlwaysIncludeCoreFramework: "true", RuntimeIdentifier: "", AdditionalProbingPaths: "C:\\Users\\kant\\.dotnet\\store\\|arch|\\|tfm|", RuntimeConfigDevPath: "", PlatformLibraryName: "", RuntimeConfigPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\bin\\Debug\\net8.0\\6 - targets.runtimeconfig.json", RuntimeFrameworks: "", RollForward: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", HostConfigurationOptions: "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization");

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

	_SdkBeforeCleanRun = true;
}

void _SdkBeforeRebuild()
{
	// BeforeTargets;
	if (!_CheckForInvalidConfigurationAndPlatformRun) _CheckForInvalidConfigurationAndPlatform();

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

	/*CreateAppHost(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", AppBinaryName: "$(AssemblyName)$(TargetExt)", IntermediateAssembly: "@(IntermediateAssembly->'%(FullPath)')", AppHostDestinationPath: "$(AppHostIntermediatePath)", WindowsGraphicalUserInterface: "$(_UseWindowsGraphicalUserInterface)", EnableMacOSCodeSign: "$(_EnableMacOSCodeSign)", AppHostSourcePath: "$(AppHostSourcePath)");*/
	CreateAppHost(Retries: "", RetryDelayMilliseconds: "", AppBinaryName: "6 - targets.dll", IntermediateAssembly: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.dll", AppHostDestinationPath: "", WindowsGraphicalUserInterface: "", EnableMacOSCodeSign: "", AppHostSourcePath: "");

	_CreateAppHostRun = true;
}

void _ChooseAppHost()
{
	// if ('$(UseAppHost)' == 'true' and '$(_IsExecutable)' == 'true')
	if ('true' == 'true' and 'true' == 'true') { _ChooseAppHostRun = true; return; }
	// DependsOnTargets;
	if (!_GetAppHostPathsRun) _GetAppHostPaths();

	_ChooseAppHostRun = true;
}

void _GetAppHostPaths()
{
	// if ('$(UseAppHost)' == 'true' and '$(_IsExecutable)' == 'true')
	if ('true' == 'true' and 'true' == 'true') { _GetAppHostPathsRun = true; return; }
	// DependsOnTargets;
	if (!ResolvePackageAssetsRun) ResolvePackageAssets();
	if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();

	/*NETSdkError(FormatArguments: "$(_DotNetAppHostExecutableName)", ResourceName: "MultipleFilesResolved");*/
	/* if ('@(_NativeRestoredAppHostNETCore->Count())' > 1)*/
	if ('0' > 1)
	{
		NETSdkError(FormatArguments: "apphost.exe", ResourceName: "MultipleFilesResolved");
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

	/*CreateComHost(ComHostSourcePath: "$(ComHostSourcePath)", ComHostDestinationPath: "$(ComHostIntermediatePath)", TypeLibraries: "@(ComHostTypeLibrary)", ClsidMapPath: "@(ClsidMap)");*/
	CreateComHost(ComHostSourcePath: "", ComHostDestinationPath: "", TypeLibraries: "", ClsidMapPath: "obj\\Debug\\net8.0\\6 - targets.clsidmap");

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

	/*GenerateRegFreeComManifest(ComHostName: "$(ComHostFileName)", IntermediateAssembly: "@(IntermediateAssembly)", TypeLibraries: "@(ComHostTypeLibrary)", ComManifestPath: "@(RegFreeComManifest)", ClsidMapPath: "@(ClsidMap)");*/
	GenerateRegFreeComManifest(ComHostName: "", IntermediateAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", TypeLibraries: "", ComManifestPath: "obj\\Debug\\net8.0\\6 - targets.X.manifest", ClsidMapPath: "obj\\Debug\\net8.0\\6 - targets.clsidmap");

	_GenerateRegFreeComManifestRun = true;
}

void _GetComHostPaths()
{
	// if ('$(EnableComHosting)' == 'true' and '$(_IsExecutable)' != 'true')
	if ('' == 'true' and 'true' != 'true') { _GetComHostPathsRun = true; return; }
	// DependsOnTargets;
	if (!ResolvePackageAssetsRun) ResolvePackageAssets();
	if (!ResolveFrameworkReferencesRun) ResolveFrameworkReferences();

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

	/*MakeDir(Directories: "@(_SatelliteAssemblyResourceInputs->'$(IntermediateOutputPath)%(Culture)')");*/
	MakeDir(Directories: "");
	/*WriteCodeFragment(AssemblyAttributes: "@(SatelliteAssemblyAttribute)", Language: "C#", OutputFile: "$(_AssemblyInfoFile)");*/
	WriteCodeFragment(AssemblyAttributes: "", Language: "C#", OutputFile: "");
	/*Csc(OutputAssembly: "$(_OutputAssembly)", ToolPath: "$(CscToolPath)", NoConfig: "true", TargetType: "Library", KeyFile: "$(KeyOriginatorFile)", NoStandardLib: "$(NoCompilerStandardLib)", KeyContainer: "$(KeyContainerName)", DisabledWarnings: "$(DisabledWarnings)", Resources: "@(_SatelliteAssemblyResourceInputs)", ToolExe: "$(CscToolExe)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", Deterministic: "$(Deterministic)", Optimize: "$(Optimize)", DelaySign: "$(DelaySign)", PublicSign: "$(PublicSign)", NoLogo: "$(NoLogo)", WarningsAsErrors: "$(WarningsAsErrors)", UseSharedCompilation: "$(UseSharedCompilation)", WarningLevel: "$(WarningLevel)", Sources: "$(_AssemblyInfoFile)", References: "@(ReferencePath)");*/
	Csc(OutputAssembly: "", ToolPath: "", NoConfig: "true", TargetType: "Library", KeyFile: "", NoStandardLib: "true", KeyContainer: "", DisabledWarnings: "", Resources: "", ToolExe: "", WarningsNotAsErrors: "", Deterministic: "true", Optimize: "false", DelaySign: "", PublicSign: "", NoLogo: "", WarningsAsErrors: ";NU1605;SYSLIB0011", UseSharedCompilation: "", WarningLevel: "8", Sources: "", References: "");

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
	/*NETSdkError(FormatArguments: "$(TargetFrameworkMoniker)", ResourceName: "WinMDObjNotSupportedOnTargetFramework");*/
	/* if ('$(OutputType)' == 'winmdobj')*/
	if ('Exe' == 'winmdobj')
	{
		NETSdkError(FormatArguments: ".NETCoreApp,Version=v8.0", ResourceName: "WinMDObjNotSupportedOnTargetFramework");
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

	/*Microsoft.Build.Tasks.Git.LocateRepository(NoWarnOnMissingInfo: "$(PkgMicrosoft_Build_Tasks_Git.Equals(''))", Path: "$(MSBuildProjectDirectory)", RemoteName: "$(GitRepositoryRemoteName)", ConfigurationScope: "$(GitRepositoryConfigurationScope)");*/
	Microsoft.Build.Tasks.Git.LocateRepository(NoWarnOnMissingInfo: "True", Path: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", RemoteName: "", ConfigurationScope: "");

	InitializeSourceControlInformationFromSourceControlManagerRun = true;
}

void SetEmbeddedFilesFromSourceControlManagerUntrackedFiles()
{
	// DependsOnTargets;
	if (!InitializeSourceControlInformationFromSourceControlManagerRun) InitializeSourceControlInformationFromSourceControlManager();

	/*Microsoft.Build.Tasks.Git.GetUntrackedFiles(Files: "@(Compile)", RepositoryId: "$(_GitRepositoryId)", ProjectDirectory: "$(MSBuildProjectDirectory)", ConfigurationScope: "$(GitRepositoryConfigurationScope)");*/
	/* if ('$(_GitRepositoryId)' != '')*/
	if ('' != '')
	{
		Microsoft.Build.Tasks.Git.GetUntrackedFiles(Files: "Program.cs", RepositoryId: "", ProjectDirectory: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets", ConfigurationScope: "");
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

	SourceControlManagerPublishTranslatedUrlsRun = true;
}

void _SetSourceLinkFilePath()
{

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

	/*Microsoft.SourceLink.GitHub.GetSourceLinkUrl(RepositoryUrl: "$(PrivateRepositoryUrl)", Hosts: "@(SourceLinkGitHubHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoot: "@(SourceRoot)");*/
	Microsoft.SourceLink.GitHub.GetSourceLinkUrl(RepositoryUrl: "", Hosts: "github.com", IsSingleProvider: "", SourceRoot: "");

	_InitializeGitHubSourceLinkUrlRun = true;
}

void TranslateGitHubUrlsInSourceControlInformation()
{

	/*Microsoft.SourceLink.GitHub.TranslateRepositoryUrls(SourceRoots: "@(SourceRoot)", RepositoryUrl: "$(ScmRepositoryUrl)", Hosts: "@(SourceLinkGitHubHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
	Microsoft.SourceLink.GitHub.TranslateRepositoryUrls(SourceRoots: "", RepositoryUrl: "", Hosts: "github.com", IsSingleProvider: "");

	TranslateGitHubUrlsInSourceControlInformationRun = true;
}

void _InitializeGitLabSourceLinkUrl()
{

	/*Microsoft.SourceLink.GitLab.GetSourceLinkUrl(RepositoryUrl: "$(PrivateRepositoryUrl)", Hosts: "@(SourceLinkGitLabHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoot: "@(SourceRoot)");*/
	Microsoft.SourceLink.GitLab.GetSourceLinkUrl(RepositoryUrl: "", Hosts: "gitlab.com", IsSingleProvider: "", SourceRoot: "");

	_InitializeGitLabSourceLinkUrlRun = true;
}

void TranslateGitLabUrlsInSourceControlInformation()
{

	/*Microsoft.SourceLink.GitLab.TranslateRepositoryUrls(SourceRoots: "@(SourceRoot)", RepositoryUrl: "$(ScmRepositoryUrl)", Hosts: "@(SourceLinkGitLabHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
	Microsoft.SourceLink.GitLab.TranslateRepositoryUrls(SourceRoots: "", RepositoryUrl: "", Hosts: "gitlab.com", IsSingleProvider: "");

	TranslateGitLabUrlsInSourceControlInformationRun = true;
}

void _InitializeAzureReposGitSourceLinkUrl()
{

	/*Microsoft.SourceLink.AzureRepos.Git.GetSourceLinkUrl(RepositoryUrl: "$(PrivateRepositoryUrl)", Hosts: "@(SourceLinkAzureReposGitHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoot: "@(SourceRoot)");*/
	Microsoft.SourceLink.AzureRepos.Git.GetSourceLinkUrl(RepositoryUrl: "", Hosts: "visualstudio.com;vsts.me;dev.azure.com", IsSingleProvider: "", SourceRoot: "");

	_InitializeAzureReposGitSourceLinkUrlRun = true;
}

void TranslateAzureReposGitUrlsInSourceControlInformation()
{

	/*Microsoft.SourceLink.AzureRepos.Git.TranslateRepositoryUrls(SourceRoots: "@(SourceRoot)", RepositoryUrl: "$(ScmRepositoryUrl)", Hosts: "@(SourceLinkAzureReposGitHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
	Microsoft.SourceLink.AzureRepos.Git.TranslateRepositoryUrls(SourceRoots: "", RepositoryUrl: "", Hosts: "visualstudio.com;vsts.me;dev.azure.com", IsSingleProvider: "");

	TranslateAzureReposGitUrlsInSourceControlInformationRun = true;
}

void _InitializeBitbucketGitSourceLinkUrl()
{

	/*Microsoft.SourceLink.Bitbucket.Git.GetSourceLinkUrl(RepositoryUrl: "$(PrivateRepositoryUrl)", Hosts: "@(SourceLinkBitbucketGitHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)", SourceRoot: "@(SourceRoot)");*/
	Microsoft.SourceLink.Bitbucket.Git.GetSourceLinkUrl(RepositoryUrl: "", Hosts: "bitbucket.org", IsSingleProvider: "", SourceRoot: "");

	_InitializeBitbucketGitSourceLinkUrlRun = true;
}

void TranslateBitbucketGitUrlsInSourceControlInformation()
{

	/*Microsoft.SourceLink.Bitbucket.Git.TranslateRepositoryUrls(SourceRoots: "@(SourceRoot)", RepositoryUrl: "$(ScmRepositoryUrl)", Hosts: "@(SourceLinkBitbucketGitHost)", IsSingleProvider: "$(SourceLinkHasSingleProvider)");*/
	Microsoft.SourceLink.Bitbucket.Git.TranslateRepositoryUrls(SourceRoots: "", RepositoryUrl: "", Hosts: "bitbucket.org", IsSingleProvider: "");

	TranslateBitbucketGitUrlsInSourceControlInformationRun = true;
}

void _GenerateDesignerDepsFile()
{
	// if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp')
	if ('.NETCoreApp' == '.NETCoreApp') { _GenerateDesignerDepsFileRun = true; return; }

	/*GenerateDepsFile(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", DepsFilePath: "$(_DesignerDepsFilePath)", AssemblyExtension: "_", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", ProjectPath: "$(MSBuildProjectFullPath)", IsSelfContained: "false", AssemblyName: "_", AssemblyVersion: "_", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", IncludeMainProject: "false", ResolvedNuGetFiles: "@(NativeCopyLocalItems);@(ResourceCopyLocalItems);@(RuntimeCopyLocalItems)", CompileReferences: "@(ResolvedCompileFileDefinitions)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", RuntimeFrameworks: "@(RuntimeFramework)");*/
	GenerateDepsFile(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", DepsFilePath: "obj\\Debug\\net8.0\\6 - targets.designer.deps.json", AssemblyExtension: "_", ResolvedRuntimeTargetsFiles: "", IncludeProjectsNotInAssetsFile: "true", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", IsSelfContained: "false", AssemblyName: "_", AssemblyVersion: "_", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", IncludeRuntimeFileVersions: "true", IncludeMainProject: "false", ResolvedNuGetFiles: ";;", CompileReferences: "", PlatformLibraryName: "", RuntimeFrameworks: "");

	_GenerateDesignerDepsFileRun = true;
}

void _GenerateDesignerRuntimeConfigFile()
{
	// if ('$(TargetFrameworkIdentifier)' == '.NETCoreApp')
	if ('.NETCoreApp' == '.NETCoreApp') { _GenerateDesignerRuntimeConfigFileRun = true; return; }

	/*GenerateRuntimeConfigurationFiles(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", UserRuntimeConfig: "$(UserRuntimeConfig)", IsSelfContained: "false", AlwaysIncludeCoreFramework: "$(AlwaysIncludeCoreFrameworkInRuntimeConfig)", WriteAdditionalProbingPathsToMainConfig: "true", AdditionalProbingPaths: "@(AdditionalProbingPath)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", RuntimeConfigPath: "$(_DesignerRuntimeConfigFilePath)", RuntimeFrameworks: "@(RuntimeFramework)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", HostConfigurationOptions: "@(RuntimeHostConfigurationOption);@(_DesignerHostConfigurationOption)");*/
	GenerateRuntimeConfigurationFiles(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", UserRuntimeConfig: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets/runtimeconfig.template.json", IsSelfContained: "false", AlwaysIncludeCoreFramework: "true", WriteAdditionalProbingPathsToMainConfig: "true", AdditionalProbingPaths: "C:\\Users\\kant\\.dotnet\\store\\|arch|\\|tfm|", PlatformLibraryName: "", RuntimeConfigPath: "obj\\Debug\\net8.0\\6 - targets.designer.runtimeconfig.json", RuntimeFrameworks: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", HostConfigurationOptions: "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization;");

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

	/*Hash(ItemsToHash: "@(AssemblyAttribute->'%(Identity)%(_Parameter1)%(_Parameter2)%(_Parameter3)%(_Parameter4)%(_Parameter5)%(_Parameter6)%(_Parameter7)%(_Parameter8)')");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "$(_AssemblyAttributesHash)", File: "$(GeneratedAssemblyInfoInputsCacheFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "", File: "");

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
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "@(_GlobalUsingLines)", File: "$(GeneratedGlobalUsingsFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\6 - targets.GlobalUsings.g.cs");

	GenerateGlobalUsingsRun = true;
}

void GenerateSupportedRuntime()
{
	// if ('$(GenerateSupportedRuntime)' != 'false' and '$(TargetFrameworkIdentifier)' == '.NETFramework' and '$(HasRuntimeOutput)' == 'true')
	if ('' != 'false' and '.NETCoreApp' == '.NETFramework' and 'true' == 'true') { GenerateSupportedRuntimeRun = true; return; }
	// DependsOnTargets;
	if (!_WriteAppConfigWithSupportedRuntimeRun) _WriteAppConfigWithSupportedRuntime();

	/*SetGeneratedAppConfigMetadata(AppConfigFile: "@(AppConfigWithTargetPath)", GeneratedAppConfigFile: "$(_GenerateSupportedRuntimeIntermediateAppConfig)", TargetName: "$(TargetFileName).config");*/
	SetGeneratedAppConfigMetadata(AppConfigFile: "", GeneratedAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.withSupportedRuntime.config", TargetName: "6 - targets.dll.config");

	GenerateSupportedRuntimeRun = true;
}

void _WriteAppConfigWithSupportedRuntime()
{
	// DependsOnTargets;
	if (!PrepareForBuildRun) PrepareForBuild();

	/*WriteAppConfigWithSupportedRuntime(OutputAppConfigFile: "$(_GenerateSupportedRuntimeIntermediateAppConfig)", AppConfigFile: "@(AppConfigWithTargetPath)", TargetFrameworkVersion: "$(TargetFrameworkVersion)", TargetFrameworkIdentifier: "$(TargetFrameworkIdentifier)", TargetFrameworkProfile: "$(TargetFrameworkProfile)");*/
	WriteAppConfigWithSupportedRuntime(OutputAppConfigFile: "obj\\Debug\\net8.0\\6 - targets.dll.withSupportedRuntime.config", AppConfigFile: "", TargetFrameworkVersion: "v8.0", TargetFrameworkIdentifier: ".NETCoreApp", TargetFrameworkProfile: "");

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

	/*MSBuild(Projects: "%(_AllProjects.Identity)", Targets: "StoreWorkerMapper", BuildinParallel: "$(BuildinParallel)", Properties: """ComposeWorkingDir=$(ComposeWorkingDir);
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
	MSBuild(Projects: "%(_AllProjects.Identity)", Targets: "StoreWorkerMapper", BuildinParallel: "true", Properties: """ComposeWorkingDir=;
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

	/*MSBuild(Projects: "@(PackageReferencesToStore)", Targets: "RestoreForComposeStore", BuildInParallel: "$(BuildInParallel)");*/
	MSBuild(Projects: "", Targets: "RestoreForComposeStore", BuildInParallel: "true");
	/*MSBuild(Projects: "@(PackageReferencesToStore)", Targets: "StoreResolver", BuildInParallel: "$(BuildInParallel)", Properties: "SelfContained=false;UseAppHost=false;MSBuildProjectExtensionsPath=$(ComposeWorkingDir)\\%(PackageReferencesToStore.PackageName)_$([System.String]::Copy('%(PackageReferencesToStore.PackageVersion)').Replace('*','-'))\\;");*/
	MSBuild(Projects: "", Targets: "StoreResolver", BuildInParallel: "true", Properties: "SelfContained=false;UseAppHost=false;MSBuildProjectExtensionsPath=\\%(PackageReferencesToStore.PackageName)_%(PackageReferencesToStore.PackageVersion)\\;");

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

	/*RemoveDuplicatePackageReferences(InputPackageReferences: "@(AllResolvedPackagesPublished)");*/
	RemoveDuplicatePackageReferences(InputPackageReferences: "");
	/*WriteLinesToFile(Overwrite: "true", Lines: "$(_StoreArtifactContent)", File: "$(StoreArtifactXml)");*/
	WriteLinesToFile(Overwrite: "true", Lines: "", File: "");
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

	/*Copy(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(PublishDir)%(_OptimizedResolvedFileToPublish.RecursiveDir)", SourceFiles: "@(_OptimizedResolvedFileToPublish)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)");*/
	/* if ('@(_OptimizedResolvedFileToPublish)' != '')*/
	if ('' != '')
	{
		Copy(Retries: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\publish\\%(_OptimizedResolvedFileToPublish.RecursiveDir)", SourceFiles: "", SkipUnchangedFiles: "", OverwriteReadOnlyFiles: "false");
	}
	/*Copy(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(ProfilingSymbolsDir)%(_OptimizedSymbolFileToPublish.RecursiveDir)", SourceFiles: "@(_OptimizedSymbolFileToPublish)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)");*/
	/* if ('@(_OptimizedSymbolFileToPublish)' != '')*/
	if ('' != '')
	{
		Copy(Retries: "", RetryDelayMilliseconds: "", DestinationFolder: "%(_OptimizedSymbolFileToPublish.RecursiveDir)", SourceFiles: "", SkipUnchangedFiles: "", OverwriteReadOnlyFiles: "false");
	}

	_CopyResolvedOptimizedFilesRun = true;
}

void PrepareForComposeStore()
{

	/*NETSdkError(FormatArguments: "$(TargetFrameworkMoniker)", ResourceName: "UnuspportedFramework");*/
	/* if ('2.0' > '$(_TargetFrameworkVersionWithoutV)')*/
	if ('2.0' > '8.0')
	{
		NETSdkError(FormatArguments: ".NETCoreApp,Version=v8.0", ResourceName: "UnuspportedFramework");
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
	/*NETSdkError(FormatArguments: "$(ComposeWorkingDir)", ResourceName: "FolderAlreadyExists");*/
	/* if (Exists($(ComposeWorkingDir)))*/
	if (Exists())
	{
		NETSdkError(FormatArguments: "", ResourceName: "FolderAlreadyExists");
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
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "Restore", Properties: """RestoreGraphProjectInput=$(MSBuildProjectFullPath);
                             RestoreOutputPath=$(BaseIntermediateOutputPath);
                             StorePackageName=$(StorePackageName);
                             StorePackageVersion=$(StorePackageVersion);
                             RuntimeIdentifier=$(RuntimeIdentifier);
                             TargetFramework=$(TargetFramework);""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "Restore", Properties: """RestoreGraphProjectInput=D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;
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

	/*Copy(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "$(PublishDir)%(_UnOptimizedResolvedFileToPublish.DestinationSubPath)", SourceFiles: "@(_UnOptimizedResolvedFileToPublish)", SkipUnchangedFiles: "$(SkipUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)");*/
	Copy(Retries: "", RetryDelayMilliseconds: "", DestinationFiles: "bin\\Debug\\net8.0\\publish\\%(_UnOptimizedResolvedFileToPublish.DestinationSubPath)", SourceFiles: "", SkipUnchangedFiles: "", OverwriteReadOnlyFiles: "false");

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

	/*FilterResolvedFiles(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", IsSelfContained: "$(SelfContained)", PackagesToPrune: "$(PackagesToPrune)", RuntimeIdentifier: "$(RuntimeIdentifier)", ResolvedFiles: "@(_ResolvedCopyLocalPublishAssets)");*/
	FilterResolvedFiles(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", IsSelfContained: "false", PackagesToPrune: "", RuntimeIdentifier: "", ResolvedFiles: "");

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

	/* if ('@(_CoreclrResolvedPath->Count())' > 1)*/
	if ('0' > 1)
	{
		NETSdkError(FormatArguments: "coreclr", ResourceName: "MultipleFilesResolved");
	}
	/* if ('@(_CoreclrResolvedPath)'== '')*/
	if (''== '')
	{
		NETSdkError(FormatArguments: "coreclr", ResourceName: "UnableToFindResolvedPath");
	}
	/* if ('@(_JitResolvedPath->Count())' > 1)*/
	if ('0' > 1)
	{
		NETSdkError(FormatArguments: "jit", ResourceName: "MultipleFilesResolved");
	}
	/* if ('@(_JitResolvedPath)'== '')*/
	if (''== '')
	{
		NETSdkError(FormatArguments: "jit", ResourceName: "UnableToFindResolvedPath");
	}
	/*NETSdkError(FormatArguments: "$(Crossgen)", ResourceName: "UnableToFindResolvedPath");*/
	/* if (!Exists($(Crossgen)))*/
	if (!Exists())
	{
		NETSdkError(FormatArguments: "", ResourceName: "UnableToFindResolvedPath");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(_NetCoreRefDir)", SourceFiles: "$(Crossgen)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

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

	/*MSBuild(Projects: "@(AssembliestoCrossgen)", Targets: "RunCrossGen", BuildInParallel: "$(BuildInParallel)");*/
	/* if ('@(_ManagedResolvedFilesToOptimize)' != '')*/
	if ('' != '')
	{
		MSBuild(Projects: "", Targets: "RunCrossGen", BuildInParallel: "true");
	}

	_RunOptimizerRun = true;
}

void RunCrossGen()
{
	// DependsOnTargets;
	if (!_InitializeBasicPropsRun) _InitializeBasicProps();
	if (!Run) ();

	/*Message(Text: "CrossgenCommandline: $(CrossgenCommandline)");*/
	Message(Text: "CrossgenCommandline: ");
	/*Exec(IgnoreStandardErrorWarningFormat: "true", Command: "$(CrossgenCommandline)");*/
	/* if (!Exists($([System.IO.Path]::Combine($(PublishDir),$(CrossgenSubOutputPath)))))*/
	if (!Exists(bin\Debug\net8.0\publish\))
	{
		Exec(IgnoreStandardErrorWarningFormat: "true", Command: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "$(PublishDir)\\$(CrossgenSubOutputPath)", SourceFiles: "$(CrossgenOutputAssembly)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)");*/
	/* if (!Exists($([System.IO.Path]::Combine($(PublishDir),$(CrossgenSubOutputPath)))))*/
	if (!Exists(bin\Debug\net8.0\publish\))
	{
		Copy(Retries: "", RetryDelayMilliseconds: "", DestinationFiles: "bin\\Debug\\net8.0\\publish\\\\", SourceFiles: "", OverwriteReadOnlyFiles: "false");
	}
	/*MakeDir(Directories: "$(CrossgenProfilingSymbolsOutputDirectory)");*/
	/* if ('$(CreateProfilingSymbols)' == 'true' and Exists($(CrossgenOutputAssembly)))*/
	if ('' == 'true' and Exists())
	{
		MakeDir(Directories: "");
	}
	/*Exec(IgnoreStandardErrorWarningFormat: "true", Command: "$(CrossgenExe) -nologo -readytorun -platform_assemblies_paths $(CrossgenPlatformAssembliesPath) -$(CreateProfilingSymbolsOptionName) $(CrossgenProfilingSymbolsOutputDirectory) $(CrossgenOutputAssembly)");*/
	/* if ('$(CreateProfilingSymbols)' == 'true' and Exists($(CrossgenOutputAssembly)))*/
	if ('' == 'true' and Exists())
	{
		Exec(IgnoreStandardErrorWarningFormat: "true", Command: " -nologo -readytorun -platform_assemblies_paths  -  ");
	}
	/*Copy(Retries: "$(CopyRetryCount)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(CrossgenSymbolsStagingDirectory)", SourceFiles: "@(_ProfilingSymbols)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)");*/
	/* if ('$(CreateProfilingSymbols)' == 'true')*/
	if ('' == 'true')
	{
		Copy(Retries: "", RetryDelayMilliseconds: "", DestinationFolder: "", SourceFiles: "", OverwriteReadOnlyFiles: "false");
	}

	RunCrossGenRun = true;
}

void _InitializeBasicProps()
{

	_InitializeBasicPropsRun = true;
}

void _GetCrossgenProps()
{
	// if ($(SkipOptimization) != 'true' )
	if ( != 'true' ) { _GetCrossgenPropsRun = true; return; }

	/*MakeDir(Directories: "$(_CrossProjFileDir)");*/
	MakeDir(Directories: "");

	_GetCrossgenPropsRun = true;
}

void _SetupStageForCrossgen()
{
	// DependsOnTargets;
	if (!_GetCrossgenPropsRun) _GetCrossgenProps();
	if (!Run) ();

	/*MakeDir(Directories: "$(_RuntimeOptimizedDir)");*/
	MakeDir(Directories: "");
	/*MakeDir(Directories: "$(_RuntimeSymbolsDir)");*/
	/* if ('$(CreateProfilingSymbols)' == 'true')*/
	if ('' == 'true')
	{
		MakeDir(Directories: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(_RuntimeRefDir)", SourceFiles: "@(_ManagedResolvedFilesToOptimize)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "Restore", Properties: """RuntimeIdentifiers=$(RuntimeIdentifier);
                             RestoreGraphProjectInput=$(MSBuildProjectFullPath);
                             RestoreOutputPath=$(_CrossProjFileDir);
                             StorePackageName=$(MicrosoftNETPlatformLibrary);
                             StorePackageVersion=%(PackageReferenceForCrossGen.Version);""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "Restore", Properties: """RuntimeIdentifiers=;
                             RestoreGraphProjectInput=D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj;
                             RestoreOutputPath=;
                             StorePackageName=;
                             StorePackageVersion=%(PackageReferenceForCrossGen.Version);""");
	/*ResolveCopyLocalAssets(TargetFramework: "$(_TFM)", AssetsFilePath: "$(_CrossProjAssetsFile)", IsSelfContained: "$(SelfContained)", ExcludedPackageReferences: "@(_ExcludeFromPublishPackageReference)", RuntimeIdentifier: "$(RuntimeIdentifier)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", PreserveStoreLayout: "false", RuntimeFrameworks: "@(RuntimeFramework)");*/
	/* if ('$(_TargetFrameworkVersionWithoutV)' < '3.0')*/
	if ('8.0' < '3.0')
	{
		ResolveCopyLocalAssets(TargetFramework: "", AssetsFilePath: "", IsSelfContained: "false", ExcludedPackageReferences: "", RuntimeIdentifier: "", PlatformLibraryName: "", PreserveStoreLayout: "false", RuntimeFrameworks: "");
	}
	/*GetPackageDirectory(AssetsFileWithAdditionalPackageFolders: "$(_CrossProjAssetsFile)", Items: "@(RuntimePack)");*/
	/* if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0')*/
	if ('8.0' >= '3.0')
	{
		GetPackageDirectory(AssetsFileWithAdditionalPackageFolders: "", Items: "");
	}
	/*ResolveRuntimePackAssets(FrameworkReferences: "@(FrameworkReference)", DisableTransitiveFrameworkReferenceDownloads: "$(DisableTransitiveFrameworkReferenceDownloads)", ResolvedRuntimePacks: "@(_CrossgenRuntimePack)");*/
	/* if ('$(_TargetFrameworkVersionWithoutV)' >= '3.0')*/
	if ('8.0' >= '3.0')
	{
		ResolveRuntimePackAssets(FrameworkReferences: "Microsoft.NETCore.App", DisableTransitiveFrameworkReferenceDownloads: "", ResolvedRuntimePacks: "");
	}
	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(_NetCoreRefDir)", SourceFiles: "@(CrossgenResolvedAssembliesToPublish)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

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

	/*AllowEmptyTelemetry(EventName: "ReadyToRun", EventData: "@(R2RTelemetry)");*/
	AllowEmptyTelemetry(EventName: "ReadyToRun", EventData: "");
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

	/*MakeDir(Directories: "$(_ReadyToRunOutputPath)");*/
	MakeDir(Directories: "");
	/*ResolvePackageFileConflicts(ReferenceCopyLocalPaths: "@(_ReadyToRunImplementationAssemblies)");*/
	/* if ('$(SelfContained)' != 'true')*/
	if ('false' != 'true')
	{
		ResolvePackageFileConflicts(ReferenceCopyLocalPaths: "");
	}
	/*PrepareForReadyToRunCompilation(MainAssembly: "@(IntermediateAssembly)", CrossgenTool: "@(CrossgenTool)", OutputPath: "$(_ReadyToRunOutputPath)", IncludeSymbolsInSingleFile: "$(IncludeSymbolsInSingleFile)", Crossgen2Composite: "$(PublishReadyToRunComposite)", ExcludeList: "@(PublishReadyToRunExclude)", EmitSymbols: "$(PublishReadyToRunEmitSymbols)", Crossgen2Tool: "@(Crossgen2Tool)", Assemblies: "@(_ReadyToRunImplementationAssemblies)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", PublishReadyToRunCompositeExclusions: "@(PublishReadyToRunCompositeExclusions)");*/
	PrepareForReadyToRunCompilation(MainAssembly: "obj\\Debug\\net8.0\\6 - targets.dll", CrossgenTool: "", OutputPath: "", IncludeSymbolsInSingleFile: "false", Crossgen2Composite: "false", ExcludeList: "", EmitSymbols: "", Crossgen2Tool: "", Assemblies: "", ReadyToRunUseCrossgen2: "true", PublishReadyToRunCompositeExclusions: "");

	_PrepareForReadyToRunCompilationRun = true;
}

void ResolveReadyToRunCompilers()
{

	/*ResolveReadyToRunCompilers(Crossgen2Packs: "@(ResolvedCrossgen2Pack)", TargetingPacks: "@(ResolvedTargetingPack)", EmitSymbols: "$(PublishReadyToRunEmitSymbols)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", RuntimePacks: "@(ResolvedRuntimePack)", ReadyToRunUseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", PerfmapFormatVersion: "$(PublishReadyToRunPerfmapFormatVersion)", NETCoreSdkRuntimeIdentifier: "$(NETCoreSdkRuntimeIdentifier)");*/
	ResolveReadyToRunCompilers(Crossgen2Packs: "", TargetingPacks: "", EmitSymbols: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", RuntimePacks: "", ReadyToRunUseCrossgen2: "true", PerfmapFormatVersion: "1", NETCoreSdkRuntimeIdentifier: "win-x64");

	ResolveReadyToRunCompilersRun = true;
}

void _CreateR2RImages()
{

	/*RunReadyToRunCompiler(CrossgenTool: "@(CrossgenTool)", ReadyToRunCompositeBuildInput: "@(_ReadyToRunCompositeBuildInput)", Crossgen2ExtraCommandLineArgs: "$(PublishReadyToRunCrossgen2ExtraArgs)", ImplementationAssemblyReferences: "@(_ReadyToRunAssembliesToReference)", UseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", Crossgen2Tool: "@(Crossgen2Tool)", ShowCompilerWarnings: "$(PublishReadyToRunShowWarnings)", Crossgen2PgoFiles: "@(_ReadyToRunPgoFiles)", CompilationEntry: "@(_ReadyToRunCompileList)", ReadyToRunCompositeBuildReferences: "@(_ReadyToRunCompositeBuildReferences)");*/
	RunReadyToRunCompiler(CrossgenTool: "", ReadyToRunCompositeBuildInput: "", Crossgen2ExtraCommandLineArgs: "", ImplementationAssemblyReferences: "", UseCrossgen2: "true", Crossgen2Tool: "", ShowCompilerWarnings: "", Crossgen2PgoFiles: "", CompilationEntry: "", ReadyToRunCompositeBuildReferences: "");

	_CreateR2RImagesRun = true;
}

void _CreateR2RSymbols()
{
	// if ('$(PublishReadyToRunUseCrossgen2)' != 'true' or '@(Crossgen2Tool -> '%(IsVersion5)')' == 'true')
	if ('true' != 'true' or '' == 'true') { _CreateR2RSymbolsRun = true; return; }

	/*RunReadyToRunCompiler(CrossgenTool: "@(CrossgenTool)", Crossgen2ExtraCommandLineArgs: "$(PublishReadyToRunCrossgen2ExtraArgs)", ImplementationAssemblyReferences: "@(_ReadyToRunAssembliesToReference)", UseCrossgen2: "$(PublishReadyToRunUseCrossgen2)", Crossgen2Tool: "@(Crossgen2Tool)", ShowCompilerWarnings: "$(PublishReadyToRunShowWarnings)", CompilationEntry: "@(_ReadyToRunSymbolsCompileList)");*/
	RunReadyToRunCompiler(CrossgenTool: "", Crossgen2ExtraCommandLineArgs: "", ImplementationAssemblyReferences: "", UseCrossgen2: "true", Crossgen2Tool: "", ShowCompilerWarnings: "", CompilationEntry: "");

	_CreateR2RSymbolsRun = true;
}

void _CheckForObsoleteDotNetCliToolReferences()
{
	// if ( '$(SuppressObsoleteDotNetCliToolWarning)' != 'true' )
	if ( '' != 'true' ) { _CheckForObsoleteDotNetCliToolReferencesRun = true; return; }

	/* if ( '%(_ReferenceToObsoleteDotNetCliTool.Identity)' != '' )*/
	if ( '%(_ReferenceToObsoleteDotNetCliTool.Identity)' != '' )
	{
		NETSdkWarning(FormatArguments: "%(_ReferenceToObsoleteDotNetCliTool.Identity)", ResourceName: "ProjectContainsObsoleteDotNetCliTool");
	}

	_CheckForObsoleteDotNetCliToolReferencesRun = true;
}

void _ComputeToolPackInputsToProcessFrameworkReferences()
{

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

	_PreventProjectReferencesFromBuildingRun = true;
}

void PrepareForPublish()
{
	// BeforeTargets;
	if (!_CheckForLanguageAndPublishFeatureCombinationSupportRun) _CheckForLanguageAndPublishFeatureCombinationSupport();

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
	/*NETSdkWarning(FormatArguments: "$(PublishProfile)", ResourceName: "PublishProfileNotPresent");*/
	/* if ('$(PublishProfileImported)' != 'true' and '$(PublishProfile)' != '')*/
	if ('false' != 'true' and '' != '')
	{
		NETSdkWarning(FormatArguments: "", ResourceName: "PublishProfileNotPresent");
	}
	/*NETSdkError(FormatArguments: "PublishRelease;$(ProjectName)", ResourceName: "SolutionProjectConfigurationsConflict");*/
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
		NETSdkError(FormatArguments: "PublishRelease;6 - targets", ResourceName: "SolutionProjectConfigurationsConflict");
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

	/*Delete(Files: "@(_OrphanPublishFileWrites)", TreatErrorsAsWarnings: "true");*/
	Delete(Files: "", TreatErrorsAsWarnings: "true");
	/*WriteLinesToFile(Overwrite: "true", Lines: "@(_CurrentPublishFileWrites)", File: "$(IntermediateOutputPath)$(_PublishCleanFile)");*/
	WriteLinesToFile(Overwrite: "true", Lines: "", File: "obj\\Debug\\net8.0\\");

	_IncrementalCleanPublishDirectoryRun = true;
}

void _GetCurrentAndPriorPublishFileWrites()
{

	/*Hash(ItemstoHash: "$(_NormalizedPublishDir)");*/
	Hash(ItemstoHash: "");
	/*ReadLinesFromFile(File: "$(IntermediateOutputPath)$(_PublishCleanFile)");*/
	ReadLinesFromFile(File: "obj\\Debug\\net8.0\\");
	/*ConvertToAbsolutePath(Paths: "@(_UnfilteredPriorPublishFileWrites)");*/
	ConvertToAbsolutePath(Paths: "");
	/*FindUnderPath(Files: "@(_UnfilteredAbsolutePriorPublishFileWrites)", Path: "$(_NormalizedPublishDir)", UpdateToAbsolutePaths: "true");*/
	FindUnderPath(Files: "", Path: "", UpdateToAbsolutePaths: "true");
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

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_ResolvedFileToPublishPreserveNewest->'$(PublishDir)%(RelativePath)')", SourceFiles: "@(_ResolvedFileToPublishPreserveNewest)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

	_CopyResolvedFilesToPublishPreserveNewestRun = true;
}

void _CopyResolvedFilesToPublishAlways()
{
	// DependsOnTargets;
	if (!_ComputeResolvedFilesToPublishTypesRun) _ComputeResolvedFilesToPublishTypes();

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForPublishFilesIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFiles: "@(_ResolvedFileToPublishAlways->'$(PublishDir)%(RelativePath)')", SourceFiles: "@(_ResolvedFileToPublishAlways)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForPublishFilesIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFiles: "", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

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

	/*ResolveOverlappingItemGroupConflicts(ItemGroup2: "@(ResolvedFileToPublish->Distinct())", ItemGroup1: "@(_ResolvedCopyLocalPublishAssets->Distinct())", PreferredPackages: "$(PackageConflictPreferredPackages)");*/
	ResolveOverlappingItemGroupConflicts(ItemGroup2: "", ItemGroup1: "", PreferredPackages: "");

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

	/*ResolveCopyLocalAssets(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", ResolveRuntimeTargets: "$(CopyLocalRuntimeTargetAssets)", IsSelfContained: "$(SelfContained)", ExcludedPackageReferences: "@(_ExcludeFromPublishPackageReference)", RuntimeIdentifier: "$(RuntimeIdentifier)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", PreserveStoreLayout: "$(PreserveStoreLayout)", RuntimeFrameworks: "@(RuntimeFramework)", RuntimeStorePackages: "@(RuntimeStorePackages)");*/
	/* if ('$(PreserveStoreLayout)' == 'true' Or '@(RuntimeStorePackages)' != '')*/
	if ('' == 'true' Or '' != '')
	{
		ResolveCopyLocalAssets(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", ResolveRuntimeTargets: "", IsSelfContained: "false", ExcludedPackageReferences: "", RuntimeIdentifier: "", PlatformLibraryName: "", PreserveStoreLayout: "", RuntimeFrameworks: "", RuntimeStorePackages: "");
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

	/*JoinItems(LeftMetadata: "*", RightKey: "", ItemSpecToUse: "Left", Left: "@(_PublishSatelliteResources)", LeftKey: "Culture", Right: "$(SatelliteResourceLanguages)", RightMetadata: "");*/
	JoinItems(LeftMetadata: "*", RightKey: "", ItemSpecToUse: "Left", Left: "", LeftKey: "Culture", Right: "", RightMetadata: "");

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

	/*JoinItems(Left: "@(_ManagedRuntimeAssembly)", Right: "@(ResolvedFileToPublish)", RightMetadata: "*");*/
	JoinItems(Left: "", Right: "", RightMetadata: "*");

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

	_ComputeUseBuildDependencyFileRun = true;
}

void _ComputeFilesToBundle()
{
	// if ('$(PublishSingleFile)' == 'true')
	if ('' == 'true') { _ComputeFilesToBundleRun = true; return; }
	// DependsOnTargets;
	if (!_HandleFileConflictsForPublishRun) _HandleFileConflictsForPublish();

	_ComputeFilesToBundleRun = true;
}

void PrepareForBundle()
{
	// if ('$(PublishSingleFile)' == 'true')
	if ('' == 'true') { PrepareForBundleRun = true; return; }
	// DependsOnTargets;
	if (!_ComputeFilesToBundleRun) _ComputeFilesToBundle();

	PrepareForBundleRun = true;
}

void _GenerateSingleFileBundleInputCache()
{

	/*Hash(ItemsToHash: "@(_GenerateSingleFileBundlePropertyInputsCacheToHash)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "$(_GenerateSingleFileBundlePropertyInputsCacheHash)", File: "$(_GenerateSingleFileBundlePropertyInputsCache)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genbundle.cache");

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

	/* if ('$(IncludeAllContentForSelfExtract)' == 'true' And '$(IncludeNativeLibrariesForSelfExtract)' != 'true')*/
	if ('' == 'true' And '' != 'true')
	{
		NETSdkError(ResourceName: "CannotIncludeAllContentButNotNativeLibrariesInSingleFile");
	}
	/*GenerateBundle(FilesToBundle: "@(FilesToBundle)", TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV)", IncludeAllContent: "$(IncludeAllContentForSelfExtract)", ShowDiagnosticOutput: "$(TraceSingleFileBundler)", AppHostName: "$(PublishedSingleFileName)", RuntimeIdentifier: "$(RuntimeIdentifier)", IncludeNativeLibraries: "$(IncludeNativeLibrariesForSelfExtract)", IncludeSymbols: "$(IncludeSymbolsInSingleFile)", OutputDir: "$(PublishDir)", EnableCompressionInSingleFile: "$(EnableCompressionInSingleFile)");*/
	GenerateBundle(FilesToBundle: "", TargetFrameworkVersion: "8.0", IncludeAllContent: "", ShowDiagnosticOutput: "", AppHostName: "", RuntimeIdentifier: "", IncludeNativeLibraries: "", IncludeSymbols: "false", OutputDir: "bin\\Debug\\net8.0\\publish\\", EnableCompressionInSingleFile: "");

	GenerateSingleFileBundleRun = true;
}

void _ComputeIntermediateDepsFilePath()
{

	_ComputeIntermediateDepsFilePathRun = true;
}

void _GeneratePublishDependencyFileInputCache()
{
	// DependsOnTargets;
	if (!_ComputeIntermediateDepsFilePathRun) _ComputeIntermediateDepsFilePath();

	/*Hash(ItemsToHash: "@(_GeneratePublishDependencyFilePropertyInputsCacheToHash)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "$(_GeneratePublishDependencyFilePropertyInputsCacheHash)", File: "$(_GeneratePublishDependencyFilePropertyInputsCache)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.genpublishdeps.cache");

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

	/*GenerateDepsFile(TargetFramework: "$(TargetFramework)", AssetsFilePath: "$(ProjectAssetsFile)", CompilerOptions: "@(DependencyFileCompilerOptions)", IsSingleFile: "$(_IsSingleFilePublish)", DepsFilePath: "$(IntermediateDepsFilePath)", AssemblyExtension: "$(TargetExt)", ResolvedRuntimeTargetsFiles: "@(RuntimeTargetsCopyLocalItems)", IncludeProjectsNotInAssetsFile: "$(IncludeProjectsNotInAssetsFileInDepsFile)", ProjectPath: "$(MSBuildProjectFullPath)", IsSelfContained: "$(SelfContained)", ReferenceSatellitePaths: "@(ReferenceSatellitePaths)", RuntimePackAssets: "@(RuntimePackAsset)", AssemblyName: "$(AssemblyName)", AssemblyVersion: "$(Version)", ReferenceDependencyPaths: "@(ReferenceDependencyPaths)", RuntimeIdentifier: "$(RuntimeIdentifier)", RuntimeGraphPath: "$(RuntimeIdentifierGraphPath)", IncludeRuntimeFileVersions: "$(IncludeFileVersionsInDependencyFile)", IncludeMainProject: "$(IncludeMainProjectInDepsFile)", ResolvedNuGetFiles: "@(_ResolvedNuGetFilesForPublish)", CompileReferences: "@(ResolvedCompileFileDefinitions)", UserRuntimeAssemblies: "@(UserRuntimeAssembly)", PlatformLibraryName: "$(MicrosoftNETPlatformLibrary)", AssemblySatelliteAssemblies: "@(IntermediateSatelliteAssembliesWithTargetPath)", RuntimeFrameworks: "@(RuntimeFramework)", ReferencePaths: "@(ReferencePath)", ReferenceAssemblies: "@(_ReferenceAssemblies)", RuntimeStorePackages: "@(RuntimeStorePackages)");*/
	GenerateDepsFile(TargetFramework: "net8.0", AssetsFilePath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\project.assets.json", CompilerOptions: "", IsSingleFile: "", DepsFilePath: "", AssemblyExtension: ".dll", ResolvedRuntimeTargetsFiles: "", IncludeProjectsNotInAssetsFile: "true", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", IsSelfContained: "false", ReferenceSatellitePaths: "", RuntimePackAssets: "", AssemblyName: "6 - targets", AssemblyVersion: "1.0.0", ReferenceDependencyPaths: "", RuntimeIdentifier: "", RuntimeGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", IncludeRuntimeFileVersions: "true", IncludeMainProject: "true", ResolvedNuGetFiles: "", CompileReferences: "", UserRuntimeAssemblies: "", PlatformLibraryName: "", AssemblySatelliteAssemblies: "", RuntimeFrameworks: "", ReferencePaths: "", ReferenceAssemblies: "", RuntimeStorePackages: "");

	GeneratePublishDependencyFileRun = true;
}

void ComputeEmbeddedApphostPaths()
{

	/*GetEmbeddedApphostPaths(ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(TargetFramework)", ToolCommandName: "$(ToolCommandName)");*/
	GetEmbeddedApphostPaths(ShimRuntimeIdentifiers: "", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/net8.0", ToolCommandName: "6 - targets");

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

	/*GetPublishItemsOutputGroupOutputs(ResolvedFileToPublish: "@(ResolvedFileToPublish)", PublishDir: "$(PublishDir)");*/
	GetPublishItemsOutputGroupOutputs(ResolvedFileToPublish: "", PublishDir: "bin\\Debug\\net8.0\\publish\\");

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

	/*ResolveToolPackagePaths(TargetPlatformMoniker: "$(TargetPlatformMoniker)", ResolvedFileToPublish: "@(ResolvedFileToPublish)", AppHostIntermediatePath: "$(AppHostIntermediatePath)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)", PublishDir: "$(PublishDir)");*/
	ResolveToolPackagePaths(TargetPlatformMoniker: "", ResolvedFileToPublish: "", AppHostIntermediatePath: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0", PublishDir: "bin\\Debug\\net8.0\\publish\\");

	PackToolRun = true;
}

void _GenerateToolsSettingsFileInputCache()
{

	/*Hash(ItemsToHash: "@(_GenerateToolsSettingsFileInputCacheToHash)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "$(_GenerateToolsSettingsFileInputCacheHash)", File: "$(_GenerateToolsSettingsFileCacheFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "true", Overwrite: "true", Lines: "", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.toolssettingsinput.cache");

	_GenerateToolsSettingsFileInputCacheRun = true;
}

void GenerateToolsSettingsFileFromBuildProperty()
{
	// DependsOnTargets;
	if (!_GenerateToolsSettingsFileInputCacheRun) _GenerateToolsSettingsFileInputCache();

	/*GenerateToolsSettingsFile(ToolsSettingsFilePath: "$(_ToolsSettingsFilePath)", CommandName: "$(ToolCommandName)", EntryPointRelativePath: "$(ToolEntryPoint)");*/
	GenerateToolsSettingsFile(ToolsSettingsFilePath: "obj\\DotnetToolSettings.xml", CommandName: "6 - targets", EntryPointRelativePath: "6 - targets.dll");

	GenerateToolsSettingsFileFromBuildPropertyRun = true;
}

void _PackToolValidation()
{
	// if ( '$(PackAsTool)' == 'true' )
	if ( '' == 'true' ) { _PackToolValidationRun = true; return; }

	/*GetNuGetShortFolderName(TargetPlatformMoniker: "$(TargetPlatformMoniker)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	GetNuGetShortFolderName(TargetPlatformMoniker: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");
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

	/*GenerateShims(ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", OutputType: "$(OutputType)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(_NuGetShortFolderName)", ToolEntryPoint: "$(ToolEntryPoint)", ApphostsForShimRuntimeIdentifiers: "@(_ApphostsForShimRuntimeIdentifiers)", ToolCommandName: "$(ToolCommandName)", PackageVersion: "$(PackageVersion)", PackageId: "$(PackageId)", IntermediateAssembly: "@(IntermediateAssembly->'%(FullPath)')", TargetFrameworkMoniker: "$(NuGetTargetMoniker)");*/
	GenerateShims(ShimRuntimeIdentifiers: "", OutputType: "Exe", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/", ToolEntryPoint: "6 - targets.dll", ApphostsForShimRuntimeIdentifiers: "", ToolCommandName: "6 - targets", PackageVersion: "1.0.0", PackageId: "6 - targets", IntermediateAssembly: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.dll", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");
	/*WriteLinesToFile(Overwrite: "True", Lines: "This file's LastWriteTime is used in incremental build", File: "$(_ShimCreatedSentinelFile)");*/
	WriteLinesToFile(Overwrite: "True", Lines: "This file's LastWriteTime is used in incremental build", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shimcreated.sentinel");

	GenerateShimsAssetsRun = true;
}

void _ComputeExpectedEmbeddedApphostPaths()
{

	/*GetEmbeddedApphostPaths(ShimRuntimeIdentifiers: "@(_PackAsToolShimRuntimeIdentifiers)", PackagedShimOutputDirectory: "$(PackagedShimOutputRootDirectory)/shims/$(_NuGetShortFolderName)", ToolCommandName: "$(ToolCommandName)");*/
	GetEmbeddedApphostPaths(ShimRuntimeIdentifiers: "", PackagedShimOutputDirectory: "bin\\Debug\\net8.0\\/shims/", ToolCommandName: "6 - targets");

	_ComputeExpectedEmbeddedApphostPathsRun = true;
}

void _GenerateShimInputCache()
{
	// DependsOnTargets;
	if (!ResolveAssemblyReferencesRun) ResolveAssemblyReferences();

	/*Hash(ItemsToHash: "@(_GenerateShimsAssetsInputCacheToHash)");*/
	Hash(ItemsToHash: "");
	/*WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "$(_GenerateShimsAssetsInputCacheHash)", File: "$(_ShimInputCacheFile)");*/
	WriteLinesToFile(WriteOnlyWhenDifferent: "True", Overwrite: "True", Lines: "", File: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\obj\\Debug\\net8.0\\6 - targets.shiminput.cache");

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

	/*FindItemsFromPackages(Packages: "@(RuntimeStorePackages)", Items: "@(RuntimeCopyLocalItems)");*/
	FindItemsFromPackages(Packages: "", Items: "");

	ComputeRefAssembliesToPublishRun = true;
}

void _CopyReferenceOnlyAssembliesForBuild()
{
	// if ('$(PreserveCompilationReferences)' == 'true')
	if ('' == 'true') { _CopyReferenceOnlyAssembliesForBuildRun = true; return; }
	// DependsOnTargets;
	if (!_ComputeReferenceAssembliesRun) _ComputeReferenceAssemblies();

	/*Copy(Retries: "$(CopyRetryCount)", UseHardlinksIfPossible: "$(CreateHardLinksForCopyFilesToOutputDirectoryIfPossible)", RetryDelayMilliseconds: "$(CopyRetryDelayMilliseconds)", DestinationFolder: "$(OutDir)$(RefAssembliesFolderName)", SourceFiles: "@(_ReferenceOnlyAssemblies)", SkipUnchangedFiles: "$(SkipCopyUnchangedFiles)", OverwriteReadOnlyFiles: "$(OverwriteReadOnlyFiles)", UseSymboliclinksIfPossible: "$(CreateSymbolicLinksForCopyFilesToOutputDirectoryIfPossible)");*/
	Copy(Retries: "", UseHardlinksIfPossible: "", RetryDelayMilliseconds: "", DestinationFolder: "bin\\Debug\\net8.0\\refs", SourceFiles: "", SkipUnchangedFiles: "true", OverwriteReadOnlyFiles: "false", UseSymboliclinksIfPossible: "");

	_CopyReferenceOnlyAssembliesForBuildRun = true;
}

void _HandlePackageFileConflicts()
{
	// DependsOnTargets;
	if (!GetFrameworkPathsRun) GetFrameworkPaths();
	if (!GetReferenceAssemblyPathsRun) GetReferenceAssemblyPaths();
	if (!ResolveTargetingPackAssetsRun) ResolveTargetingPackAssets();

	/*ResolvePackageFileConflicts(TargetFrameworkDirectories: "$(TargetFrameworkDirectory)", PackageOverrides: "@(PackageConflictOverrides)", PlatformManifests: "@(PackageConflictPlatformManifests)", Analyzers: "@(Analyzer)", OtherRuntimeItems: "@(_RuntimeAssetsForConflictResolution)", PreferredPackages: "$(PackageConflictPreferredPackages)", ReferenceCopyLocalPaths: "@(ReferenceCopyLocalPaths)", References: "@(Reference)");*/
	ResolvePackageFileConflicts(TargetFrameworkDirectories: "", PackageOverrides: "NETStandard.Library", PlatformManifests: "", Analyzers: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll;C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Sdks\\Microsoft.NET.Sdk\\targets\\..\\analyzers\\Microsoft.CodeAnalysis.NetAnalyzers.dll", OtherRuntimeItems: "", PreferredPackages: "", ReferenceCopyLocalPaths: "", References: "");

	_HandlePackageFileConflictsRun = true;
}

void _HandlePackageFileConflictsForPublish()
{

	/*ResolvePackageFileConflicts(TargetFrameworkDirectories: "$(TargetFrameworkDirectory)", PlatformManifests: "@(PackageConflictPlatformManifests)", PreferredPackages: "$(PackageConflictPreferredPackages)", ReferenceCopyLocalPaths: "@(_ResolvedCopyLocalPublishAssets)");*/
	ResolvePackageFileConflicts(TargetFrameworkDirectories: "", PlatformManifests: "", PreferredPackages: "", ReferenceCopyLocalPaths: "");

	_HandlePackageFileConflictsForPublishRun = true;
}

void _HandleFileConflictsForPublish()
{
	// if ('$(ErrorOnDuplicatePublishOutputFiles)' != 'false')
	if ('' != 'false') { _HandleFileConflictsForPublishRun = true; return; }

	/*CheckForDuplicateItemMetadata(MetadataName: "RelativePath", Items: "@(ResolvedFileToPublish->Distinct())");*/
	CheckForDuplicateItemMetadata(MetadataName: "RelativePath", Items: "");
	/*NETSdkError(FormatArguments: "@(_ResolvedFileToPublishDuplicatedItems, ', ')", ResourceName: "DuplicatePublishOutputFiles");*/
	/* if ('$(_ResolvedFileToPublishContainsDuplicates)' == 'true')*/
	if ('' == 'true')
	{
		NETSdkError(FormatArguments: "", ResourceName: "DuplicatePublishOutputFiles");
	}

	_HandleFileConflictsForPublishRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzers()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true')
	if ('' != 'true') { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersRun = true; return; }

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

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDesignRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentation()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelDocumentation)' != '' or '$(AnalysisModeDocumentation)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersDocumentationRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalization()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelGlobalization)' != '' or '$(AnalysisModeGlobalization)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersGlobalizationRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperability()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelInteroperability)' != '' or '$(AnalysisModeInteroperability)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersInteroperabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainability()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelMaintainability)' != '' or '$(AnalysisModeMaintainability)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersMaintainabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNaming()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelNaming)' != '' or '$(AnalysisModeNaming)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersNamingRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformance()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelPerformance)' != '' or '$(AnalysisModePerformance)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersPerformanceRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliability()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelReliability)' != '' or '$(AnalysisModeReliability)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersReliabilityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurity()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelSecurity)' != '' or '$(AnalysisModeSecurity)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersSecurityRun = true;
}

void AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsage()
{
	// if ('$(SkipGlobalAnalyzerConfigForPackage)' != 'true' and ('$(AnalysisLevelUsage)' != '' or '$(AnalysisModeUsage)' != ''))
	if ('' != 'true' and ('' != '' or '' != '')) { AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun = true; return; }

	AddGlobalAnalyzerConfigForPackage_MicrosoftCodeAnalysisNetAnalyzersUsageRun = true;
}

void _CodeAnalysisTreatWarningsAsErrors()
{
	// if ('$(DesignTimeBuild)' == 'true' OR '$(BuildingProject)' != 'true')
	if ('' == 'true' OR 'false' != 'true') { _CodeAnalysisTreatWarningsAsErrorsRun = true; return; }

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

	/*Microsoft.DotNet.ApiCompat.Task.ValidatePackageTask(RunApiCompat: "$(RunApiCompat)", PackageAssemblyReferences: "@(PackageValidationReferencePath)", GenerateSuppressionFile: "$(ApiCompatGenerateSuppressionFile)", EnableRuleAttributesMustMatch: "$(ApiCompatEnableRuleAttributesMustMatch)", RuntimeGraph: "$(RuntimeIdentifierGraphPath)", RoslynAssembliesPath: "$(RoslynAssembliesPath)", ExcludeAttributesFiles: "@(ApiCompatExcludeAttributesFile)", EnableRuleCannotChangeParameterName: "$(ApiCompatEnableRuleCannotChangeParameterName)", PermitUnnecessarySuppressions: "$(ApiCompatPermitUnnecessarySuppressions)", PackageTargetPath: "@(_PackageTargetPath)", EnableStrictModeForBaselineValidation: "$(EnableStrictModeForBaselineValidation)", PreserveUnnecessarySuppressions: "$(ApiCompatPreserveUnnecessarySuppressions)", SuppressionOutputFile: "$(ApiCompatSuppressionOutputFile)", EnableStrictModeForCompatibleFrameworksInPackage: "$(EnableStrictModeForCompatibleFrameworksInPackage)", RespectInternals: "$(ApiCompatRespectInternals)", NoWarn: "$(NoWarn)", EnableStrictModeForCompatibleTfms: "$(EnableStrictModeForCompatibleTfms)", BaselinePackageTargetPath: "$(_packageValidationBaselinePath)", SuppressionFiles: "@(ApiCompatSuppressionFile)");*/
	Microsoft.DotNet.ApiCompat.Task.ValidatePackageTask(RunApiCompat: "", PackageAssemblyReferences: "", GenerateSuppressionFile: "", EnableRuleAttributesMustMatch: "", RuntimeGraph: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", RoslynAssembliesPath: "", ExcludeAttributesFiles: "", EnableRuleCannotChangeParameterName: "", PermitUnnecessarySuppressions: "", PackageTargetPath: "", EnableStrictModeForBaselineValidation: "", PreserveUnnecessarySuppressions: "", SuppressionOutputFile: "", EnableStrictModeForCompatibleFrameworksInPackage: "", RespectInternals: "", NoWarn: "1701;1702", EnableStrictModeForCompatibleTfms: "", BaselinePackageTargetPath: "", SuppressionFiles: "");
	/*MakeDir(Directories: "$([System.IO.Path]::GetDirectoryName('$(ApiCompatValidatePackageSemaphoreFile)'))");*/
	MakeDir(Directories: "obj\\Debug\\net8.0");
	/*Touch(Files: "$(ApiCompatValidatePackageSemaphoreFile)", AlwaysCreate: "true");*/
	Touch(Files: "obj\\Debug\\net8.0\\Microsoft.NET.ApiCompat.ValidatePackage.semaphore", AlwaysCreate: "true");

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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "GetReferencesForApiCompatValidatePackage", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                         BuildProjectReferences=false""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "GetReferencesForApiCompatValidatePackage", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
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

	/*GetPackOutputItemsTask(IncludeSource: "$(IncludeSource)", PackageVersion: "$(PackageVersion)", PackageId: "$(PackageId)", SymbolPackageFormat: "$(SymbolPackageFormat)", NuspecOutputPath: "$(NuspecOutputAbsolutePath)", IncludeSymbols: "$(IncludeSymbols)", PackageOutputPath: "$(PackageOutputAbsolutePath)");*/
	GetPackOutputItemsTask(IncludeSource: "", PackageVersion: "1.0.0", PackageId: "6 - targets", SymbolPackageFormat: "symbols.nupkg", NuspecOutputPath: "", IncludeSymbols: "", PackageOutputPath: "");

	_GetOutputItemsFromPackRun = true;
}

void _GetTargetFrameworksOutput()
{

	/*GetProjectTargetFrameworksTask(TargetFramework: "$(TargetFramework)", TargetFrameworks: "$(TargetFrameworks)", TargetPlatformIdentifier: "$(TargetPlatformIdentifier)", ProjectPath: "$(MSBuildProjectFullPath)", TargetPlatformMinVersion: "$(TargetPlatformMinVersion)", TargetPlatformVersion: "$(TargetPlatformVersion)", TargetFrameworkMoniker: "$(TargetFrameworkMoniker)");*/
	GetProjectTargetFrameworksTask(TargetFramework: "net8.0", TargetFrameworks: "", TargetPlatformIdentifier: "", ProjectPath: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", TargetPlatformMinVersion: "", TargetPlatformVersion: "", TargetFrameworkMoniker: ".NETCoreApp,Version=v8.0");

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
	/*PackTask(MinClientVersion: "$(MinClientVersion)", RepositoryType: "$(RepositoryType)", NuspecBasePath: "$(NuspecBasePath)", TargetPathsToSymbols: "@(_TargetPathsToSymbols)", DevelopmentDependency: "$(DevelopmentDependency)", Readme: "$(PackageReadmeFile)", ReleaseNotes: "$(PackageReleaseNotes)", RestoreOutputPath: "$(RestoreOutputAbsolutePath)", FrameworkAssemblyReferences: "@(_FrameworkAssemblyReferences)", RepositoryCommit: "$(RepositoryCommit)", NuspecProperties: "$(NuspecProperties)", TargetFrameworks: "@(_TargetFrameworks)", PackageLicenseExpressionVersion: "$(PackageLicenseExpressionVersion)", RepositoryBranch: "$(RepositoryBranch)", IncludeSource: "$(IncludeSource)", AllowedOutputExtensionsInPackageBuildOutputFolder: "$(AllowedOutputExtensionsInPackageBuildOutputFolder)", LicenseUrl: "$(PackageLicenseUrl)", ContentTargetFolders: "$(ContentTargetFolders)", PackageLicenseExpression: "$(PackageLicenseExpression)", BuildOutputFolders: "$(BuildOutputTargetFolder)", FrameworksWithSuppressedDependencies: "@(_FrameworksWithSuppressedDependencies)", IsTool: "$(IsTool)", RepositoryUrl: "$(RepositoryUrl)", PackageVersion: "$(PackageVersion)", SourceFiles: "@(_SourceFiles->Distinct())", PackageId: "$(PackageId)", SymbolPackageFormat: "$(SymbolPackageFormat)", ProjectUrl: "$(PackageProjectUrl)", Description: "$(PackageDescription)", AssemblyName: "$(AssemblyName)", NuspecFile: "$(NuspecFileAbsolutePath)", IconUrl: "$(PackageIconUrl)", ProjectReferencesWithVersions: "@(_ProjectReferencesWithVersions)", WarningsNotAsErrors: "$(WarningsNotAsErrors)", OutputFileNamesWithoutVersion: "$(OutputFileNamesWithoutVersion)", Deterministic: "$(Deterministic)", NoWarn: "$(NoWarn)", Tags: "$(PackageTags)", Serviceable: "$(Serviceable)", PackageFiles: "@(_PackageFiles)", AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder: "$(AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder)", PackageFilesToExclude: "@(_PackageFilesToExclude)", Authors: "$(Authors)", NuspecOutputPath: "$(NuspecOutputAbsolutePath)", IncludeSymbols: "$(IncludeSymbols)", Copyright: "$(Copyright)", NoDefaultExcludes: "$(NoDefaultExcludes)", ContinuePackingAfterGeneratingNuspec: "$(ContinuePackingAfterGeneratingNuspec)", WarningsAsErrors: "$(WarningsAsErrors)", InstallPackageToOutputPath: "$(InstallPackageToOutputPath)", TreatWarningsAsErrors: "$(TreatWarningsAsErrors)", PackageTypes: "$(PackageType)", PackageOutputPath: "$(PackageOutputAbsolutePath)", IncludeBuildOutput: "$(IncludeBuildOutput)", PackItem: "$(PackProjectInputFile)", BuildOutputInPackage: "@(_BuildOutputInPackage)", PackageIcon: "$(PackageIcon)", PackageLicenseFile: "$(PackageLicenseFile)", Title: "$(Title)", RequireLicenseAcceptance: "$(PackageRequireLicenseAcceptance)", NoPackageAnalysis: "$(NoPackageAnalysis)");*/
	PackTask(MinClientVersion: "", RepositoryType: "", NuspecBasePath: "", TargetPathsToSymbols: "", DevelopmentDependency: "", Readme: "", ReleaseNotes: "", RestoreOutputPath: "", FrameworkAssemblyReferences: "", RepositoryCommit: "", NuspecProperties: "", TargetFrameworks: "", PackageLicenseExpressionVersion: "", RepositoryBranch: "", IncludeSource: "", AllowedOutputExtensionsInPackageBuildOutputFolder: ".dll; .exe; .winmd; .json; .pri; .xml ;", LicenseUrl: "", ContentTargetFolders: "content;contentFiles", PackageLicenseExpression: "", BuildOutputFolders: "lib", FrameworksWithSuppressedDependencies: "", IsTool: "", RepositoryUrl: "", PackageVersion: "1.0.0", SourceFiles: "", PackageId: "6 - targets", SymbolPackageFormat: "symbols.nupkg", ProjectUrl: "", Description: "Package Description", AssemblyName: "6 - targets", NuspecFile: "", IconUrl: "", ProjectReferencesWithVersions: "", WarningsNotAsErrors: "", OutputFileNamesWithoutVersion: "", Deterministic: "true", NoWarn: "1701;1702", Tags: "", Serviceable: "", PackageFiles: "", AllowedOutputExtensionsInSymbolsPackageBuildOutputFolder: ".pdb; .mdb; .dll; .exe; .winmd; .json; .pri; .xml ;; ", PackageFilesToExclude: "", Authors: "6 - targets", NuspecOutputPath: "", IncludeSymbols: "", Copyright: "", NoDefaultExcludes: "", ContinuePackingAfterGeneratingNuspec: "", WarningsAsErrors: ";NU1605;SYSLIB0011", InstallPackageToOutputPath: "", TreatWarningsAsErrors: "false", PackageTypes: "", PackageOutputPath: "", IncludeBuildOutput: "true", PackItem: "", BuildOutputInPackage: "", PackageIcon: "", PackageLicenseFile: "", Title: "", RequireLicenseAcceptance: "false", NoPackageAnalysis: "");

	GenerateNuspecRun = true;
}

void _InitializeNuspecRepositoryInformationProperties()
{
	// if ('$(SourceControlInformationFeatureSupported)' == 'true')
	if ('true' == 'true') { _InitializeNuspecRepositoryInformationPropertiesRun = true; return; }
	// DependsOnTargets;
	if (!InitializeSourceControlInformationRun) InitializeSourceControlInformation();

	_InitializeNuspecRepositoryInformationPropertiesRun = true;
}

void _LoadPackInputItems()
{

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
	/*GetProjectReferencesFromAssetsFileTask(ProjectAssetsFileAbsolutePath: "$(ProjectAssetsFileAbsolutePath)", RestoreOutputAbsolutePath: "$(RestoreOutputAbsolutePath)");*/
	GetProjectReferencesFromAssetsFileTask(ProjectAssetsFileAbsolutePath: "", RestoreOutputAbsolutePath: "");
	/*MSBuild(Projects: "@(_ProjectReferencesFromAssetsFile)", Targets: "_GetProjectVersion", SkipNonexistentTargets: "true", SkipNonexistentProjects: "true", Properties: "BuildProjectReferences=false;");*/
	MSBuild(Projects: "", Targets: "_GetProjectVersion", SkipNonexistentTargets: "true", SkipNonexistentProjects: "true", Properties: "BuildProjectReferences=false;");

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

	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetBuildOutputFilesWithTfm", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
	/* if ('$(IncludeBuildOutput)' == 'true')*/
	if ('true' == 'true')
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetBuildOutputFilesWithTfm", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
	}
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetTfmSpecificContentForPackage", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
	/* if ('$(TargetsForTfmSpecificContentInPackage)' != '')*/
	if (';PackTool;_PackProjectToolValidation' != '')
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetTfmSpecificContentForPackage", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
	}
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetDebugSymbolsWithTfm", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");*/
	/* if ('$(IncludeBuildOutput)' == 'true')*/
	if ('true' == 'true')
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetDebugSymbolsWithTfm", Properties: "TargetFramework=%(_TargetFrameworks.Identity);");
	}
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "SourceFilesProjectOutputGroup", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
	/* if ('$(IncludeSource)' == 'true')*/
	if ('' == 'true')
	{
		MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "SourceFilesProjectOutputGroup", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");
	}
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetFrameworkAssemblyReferences", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetFrameworkAssemblyReferences", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");
	/*MSBuild(Projects: "$(MSBuildProjectFullPath)", Targets: "_GetFrameworksWithSuppressedDependencies", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
                  BuildProjectReferences=false;""");*/
	MSBuild(Projects: "D:\\d\\kant\\GitHub\\msbuild-as-programming-language\\6 - targets\\6 - targets.csproj", Targets: "_GetFrameworksWithSuppressedDependencies", Properties: """TargetFramework=%(_TargetFrameworks.Identity);
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

	/*ComputeDotnetBaseImageAndTag(TargetFrameworkVersion: "$(_TargetFrameworkVersionWithoutV).0", IsSelfContained: "$(_ContainerIsSelfContained)", UsesInvariantGlobalization: "$(InvariantGlobalization)", IsAotPublished: "$(PublishAot)", ContainerFamily: "$(ContainerFamily)", FrameworkReferences: "@(FrameworkReference)", SdkVersion: "$(NetCoreSdkVersion)", TargetRuntimeIdentifier: "$(ContainerRuntimeIdentifier)");*/
	/* if ($(_ContainerIsUsingMicrosoftDefaultImages))*/
	if ()
	{
		ComputeDotnetBaseImageAndTag(TargetFrameworkVersion: "8.0.0", IsSelfContained: "false", UsesInvariantGlobalization: "", IsAotPublished: "", ContainerFamily: "", FrameworkReferences: "Microsoft.NETCore.App", SdkVersion: "8.0.200-preview.23624.5", TargetRuntimeIdentifier: "");
	}

	ComputeContainerBaseImageRun = true;
}

void ComputeContainerConfig()
{
	// DependsOnTargets;
	if (!ComputeContainerBaseImageRun) ComputeContainerBaseImage();

	/* if ('$(ContainerImageName)' != '')*/
	if ('' != '')
	{
		Warning(Text: "The property 'ContainerImageName' was set but is obsolete - please use 'ContainerRepository' instead.", Code: "CONTAINER003");
	}
	/*ParseContainerProperties(ContainerRepository: "$(ContainerRepository)", FullyQualifiedBaseImageName: "$(ContainerBaseImage)", ContainerRegistry: "$(ContainerRegistry)", ContainerImageTag: "$(ContainerImageTag)", ContainerImageTags: "$(ContainerImageTags)", ContainerEnvironmentVariables: "@(ContainerEnvironmentVariable)");*/
	ParseContainerProperties(ContainerRepository: "", FullyQualifiedBaseImageName: "", ContainerRegistry: "", ContainerImageTag: "", ContainerImageTags: "", ContainerEnvironmentVariables: "");

	ComputeContainerConfigRun = true;
}

void _CheckContainersPackage()
{

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

	/*CreateNewImage(ContainerUser: "$(ContainerUser)", DefaultArgs: "@(ContainerDefaultArgs)", ToolPath: "$(DotNetHostDirectory)", ContainerRuntimeIdentifier: "$(ContainerRuntimeIdentifier)", EntrypointArgs: "@(ContainerEntrypointArgs)", LocalRegistry: "$(LocalRegistry)", ContainerizeDirectory: "$(ContainerizeFolder)", ImageTags: "@(ContainerImageTags)", Labels: "@(ContainerLabel)", PublishDirectory: "$(PublishDir)", Repository: "$(ContainerRepository)", BaseImageName: "$(ContainerBaseName)", AppCommandInstruction: "$(ContainerAppCommandInstruction)", ToolExe: "$(DotNetHostFileName)", BaseRegistry: "$(ContainerBaseRegistry)", RuntimeIdentifierGraphPath: "$(RuntimeIdentifierGraphPath)", AppCommandArgs: "@(ContainerAppCommandArgs)", Entrypoint: "@(ContainerEntrypoint)", WorkingDirectory: "$(ContainerWorkingDirectory)", BaseImageTag: "$(ContainerBaseTag)", ArchiveOutputPath: "$(ContainerArchiveOutputPath)", OutputRegistry: "$(ContainerRegistry)", ExposedPorts: "@(ContainerPort)", AppCommand: "@(ContainerAppCommand)", ContainerEnvironmentVariables: "@(ContainerEnvironmentVariables)");*/
	CreateNewImage(ContainerUser: "", DefaultArgs: "", ToolPath: "", ContainerRuntimeIdentifier: "", EntrypointArgs: "", LocalRegistry: "", ContainerizeDirectory: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5\\Containers\\build\\..\\containerize\\", ImageTags: "", Labels: "", PublishDirectory: "bin\\Debug\\net8.0\\publish\\", Repository: "", BaseImageName: "", AppCommandInstruction: "", ToolExe: "", BaseRegistry: "", RuntimeIdentifierGraphPath: "C:\\Program Files\\dotnet\\sdk\\8.0.200-preview.23624.5/PortableRuntimeIdentifierGraph.json", AppCommandArgs: "", Entrypoint: "", WorkingDirectory: "", BaseImageTag: "", ArchiveOutputPath: "", OutputRegistry: "", ExposedPorts: "", AppCommand: "", ContainerEnvironmentVariables: "");

	PublishContainerRun = true;
}

Build();
