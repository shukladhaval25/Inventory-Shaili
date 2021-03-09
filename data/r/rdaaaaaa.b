<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5264F7C3-3378-4761-9102-A19C5ED07580}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>Sub Main</StartupObject>
    <RootNamespace>Inventory_Shaili</RootNamespace>
    <AssemblyName>Inventory Shaili</AssemblyName>
    <MyType>WindowsFormsWithCustomSubMain</MyType>
    <ApplicationIcon>CDROM01.ICO</ApplicationIcon>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <OldToolsVersion>3.5</OldToolsVersion>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <SccProjectName>"%24/Invetory Shaili/Inventory Shaili", CAAAAAAA</SccProjectName>
    <SccLocalPath>..\..\..</SccLocalPath>
    <SccAuxPath />
    <SccProvider>MSSCCI:Microsoft Visual SourceSafe</SccProvider>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>Inventory Shaili.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
    <PlatformTarget>x86</PlatformTarget>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>Inventory Shaili.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022,42353,42354,42355</NoWarn>
    <CodeAnalysisRuleSet>AllRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="DevExpress.Data.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.Data.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.Utils.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.Utils.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraBars.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraBars.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraEditors.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraEditors.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraGrid.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraGrid.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraGrid.v6.1.Design, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraGrid.v6.1.Design.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraPrinting.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraPrinting.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraReports.v6.1, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraReports.v6.1.dll</HintPath>
    </Reference>
    <Reference Include="DevExpress.XtraReports.v6.1.Design, Version=6.1.10.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4, processorArchitecture=MSIL">
      <HintPath>..\..\..\Program Files\Inventory Shaili\DevExpress.XtraReports.v6.1.Design.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.ServiceProcess" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="frmBalCF.Designer.vb">
      <DependentUpon>frmBalCF.vb</DependentUpon>
    </Compile>
    <Compile Include="frmBalCF.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmbatch.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmBatchGenerator.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmChallan.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmChangePass.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmCompany.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmCompChart.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="FrmCustomer.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmDayBook.Designer.vb">
      <DependentUpon>frmDayBook.vb</DependentUpon>
    </Compile>
    <Compile Include="frmDayBook.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmDispose_Staus.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmExperiment.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmfgmaster.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmFG_OpeningStock.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmFindSupplier.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmFinishGoodQC.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmGoodsReturn.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmGroup.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmInvoice.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmitem.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmJobWorkIssue.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmJWReturn.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmLogin.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="FrmMain.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmMat_Issue.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmMDI.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmNonConProduct.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmPara.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmPara1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmpop.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmPurchaseOrder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmQC.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmRecallReg.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmrejection.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmReport.Designer.vb">
      <DependentUpon>frmReport.vb</DependentUpon>
    </Compile>
    <Compile Include="frmReport.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmRM_Opening_Stock.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmSemiFGbatch.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmSemiFGmaster.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="FrmSupplier.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmTradingItemInward.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="FrmUnit.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmUnitConversion.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmunitmas.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="FrmUser.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Inventory_ShailiDataSet.Designer.vb" />
    <Compile Include="modMain.vb" />
    <Compile Include="Module1.vb" />
    <Compile Include="Module2.vb" />
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="rptBatchRecall.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptBatchReg.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptBOM.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptChallan.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptChallanRecall.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptCompReg.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptCustomer.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptCWPWSales.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptCW_BW_Sales.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptDayBook.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptDemoIssue.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptDemoRet.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptDemoSales.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptDispostion.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptFGQC.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptFinalProduct.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptGoodsRet.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptInwardTriplicate.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptMatIndentSlip.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptMinMaxQty.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptMIS.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptMISRecall.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptNonConProuduct.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptOrder.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPendingMIS.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPendingOrders.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPendingRMVI.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPendingSterilization.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPendingVI.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPO.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptPurchaseReg.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptRecallReg.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptRMITEMLIST.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptRMQC.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptRMStock.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptSalesReg.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptSubBatchStock.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptSupplier.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="rptTI.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="XtraReport1.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="XtraReport2.vb">
      <SubType>Component</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="frmBalCF.resx">
      <DependentUpon>frmBalCF.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmbatch.resx">
      <DependentUpon>frmbatch.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmBatchGenerator.resx">
      <DependentUpon>frmBatchGenerator.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmChallan.resx">
      <DependentUpon>frmChallan.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmChangePass.resx">
      <DependentUpon>frmChangePass.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmCompany.resx">
      <DependentUpon>frmCompany.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmCompChart.resx">
      <DependentUpon>frmCompChart.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="FrmCustomer.resx">
      <DependentUpon>FrmCustomer.vb</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmDayBook.resx">
      <SubType>Designer</SubType>
      <DependentUpon>frmDayBook.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="frmDispose_Staus.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmExperiment.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmfgmaster.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmFG_OpeningStock.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmFindSupplier.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmFinishGoodQC.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmGoodsReturn.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmGroup.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmInvoice.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmitem.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmJobWorkIssue.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmJWReturn.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmLogin.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="FrmMain.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmMat_Issue.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmMDI.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmNonConProduct.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmPara.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmPara1.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmpop.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmPurchaseOrder.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmQC.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmRecallReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmrejection.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmReport.resx">
      <DependentUpon>frmReport.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="frmRM_Opening_Stock.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmSemiFGbatch.resx">
      <DependentUpon>frmSemiFGbatch.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="frmSemiFGmaster.resx">
      <DependentUpon>frmSemiFGmaster.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="FrmSupplier.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmTradingItemInward.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="FrmUnit.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmUnitConversion.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="frmunitmas.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="FrmUser.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="licenses.licx" />
    <EmbeddedResource Include="My Project\licenses.licx" />
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptBatchRecall.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptBatchReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptBOM.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptChallan.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptChallanRecall.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptCompReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptCustomer.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptCWPWSales.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptCW_BW_Sales.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDayBook.resx">
      <SubType>Designer</SubType>
      <DependentUpon>rptDayBook.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDemoIssue.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDemoRet.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDemoSales.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDisposition.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptDispostion.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptFGQC.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptFinalProduct.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptGoodsRet.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptInwardTriplicate.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptMatIndentSlip.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptMinMaxQty.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptMIS.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptMISRecall.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptNonConProuduct.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptOrder.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPendingMIS.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPendingOrders.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPendingRMVI.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPendingSterilization.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPendingVI.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPO.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptPurchaseReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptRecallReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptRMITEMLIST.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptRMQC.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptRMStock.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptSalesReg.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptSubBatchStock.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptSupplier.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="rptTI.resx">
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="ClassDiagram1.cd" />
    <None Include="Inventory_ShailiDataSet.xsd">
      <SubType>Designer</SubType>
    </None>
    <None Include="Inventory_ShailiDataSet.xss">
      <DependentUpon>Inventory_ShailiDataSet.xsd</DependentUpon>
    </None>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Content Include="CDROM01.ICO" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>