﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;



/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class UpdateDataStrings {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal UpdateDataStrings() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UpdateDataStrings", typeof(UpdateDataStrings).GetTypeInfo().Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot update the format data with a FormatTable instance..
    /// </summary>
    internal static string CannotUpdateFormatWithFormatTable {
        get {
            return ResourceManager.GetString("CannotUpdateFormatWithFormatTable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot update a member with type &quot;{0}&quot;. Specify a different type for the MemberType parameter..
    /// </summary>
    internal static string CannotUpdateMemberType {
        get {
            return ResourceManager.GetString("CannotUpdateMemberType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot update the type data with a TypeTable instance..
    /// </summary>
    internal static string CannotUpdateTypeWithTypeTable {
        get {
            return ResourceManager.GetString("CannotUpdateTypeWithTypeTable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Updating format data is not allowed in this runspace. The &apos;DisableFormatUpdates&apos; property is set to True when creating the runspace..
    /// </summary>
    internal static string FormatUpdatesDisabled {
        get {
            return ResourceManager.GetString("FormatUpdatesDisabled", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The MemberName, Value, and SecondValue parameters cannot be specified without the MemberType parameter..
    /// </summary>
    internal static string MemberTypeIsMissing {
        get {
            return ResourceManager.GetString("MemberTypeIsMissing", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Remove TypeData.
    /// </summary>
    internal static string RemoveTypeDataAction {
        get {
            return ResourceManager.GetString("RemoveTypeDataAction", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Name of the type that will be removed: {0}.
    /// </summary>
    internal static string RemoveTypeDataTarget {
        get {
            return ResourceManager.GetString("RemoveTypeDataTarget", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Remove type file.
    /// </summary>
    internal static string RemoveTypeFileAction {
        get {
            return ResourceManager.GetString("RemoveTypeFileAction", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The value of the SerializationDepth property should not be negative..
    /// </summary>
    internal static string SerializationDepthNegative {
        get {
            return ResourceManager.GetString("SerializationDepthNegative", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0} parameter is required for the type &quot;{1}&quot;. Please specify the {0} parameter..
    /// </summary>
    internal static string ShouldBeSpecified {
        get {
            return ResourceManager.GetString("ShouldBeSpecified", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0} parameter should not be null or an empty string for a member of type &quot;{1}&quot;. Specify a non-null value for the {0} parameter when updating this member type..
    /// </summary>
    internal static string ShouldNotBeNull {
        get {
            return ResourceManager.GetString("ShouldNotBeNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0} parameter is not necessary for a member of type &quot;{1}&quot;, and should not be specified. Do not specify the {0} parameter when updating this member type..
    /// </summary>
    internal static string ShouldNotBeSpecified {
        get {
            return ResourceManager.GetString("ShouldNotBeSpecified", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The target type name should not be null, empty, or contain only white spaces..
    /// </summary>
    internal static string TargetTypeNameEmpty {
        get {
            return ResourceManager.GetString("TargetTypeNameEmpty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No member is specified for the update on type &quot;{0}&quot;..
    /// </summary>
    internal static string TypeDataEmpty {
        get {
            return ResourceManager.GetString("TypeDataEmpty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The file {0} is not imported into the current session..
    /// </summary>
    internal static string TypeFileNotExistsInCurrentSession {
        get {
            return ResourceManager.GetString("TypeFileNotExistsInCurrentSession", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot read the file &quot;{0}&quot;  because it does not have the file name extension &quot;{1}&quot;..
    /// </summary>
    internal static string UpdateData_WrongExtension {
        get {
            return ResourceManager.GetString("UpdateData_WrongExtension", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot open the file because the current provider is &quot;{0}&quot;, and this command requires a file..
    /// </summary>
    internal static string UpdateData_WrongProviderError {
        get {
            return ResourceManager.GetString("UpdateData_WrongProviderError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Update FormatData.
    /// </summary>
    internal static string UpdateFormatDataAction {
        get {
            return ResourceManager.GetString("UpdateFormatDataAction", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to FileName: {0}.
    /// </summary>
    internal static string UpdateTarget {
        get {
            return ResourceManager.GetString("UpdateTarget", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Update TypeData.
    /// </summary>
    internal static string UpdateTypeDataAction {
        get {
            return ResourceManager.GetString("UpdateTypeDataAction", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Type to update: {0}.
    /// </summary>
    internal static string UpdateTypeDataTarget {
        get {
            return ResourceManager.GetString("UpdateTypeDataTarget", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The Value and SecondValue parameters should not both be null for a member of type &quot;{0}&quot;. Specify a non-null value for one of the two parameters..
    /// </summary>
    internal static string Value1AndValue2AreNotBothNull {
        get {
            return ResourceManager.GetString("Value1AndValue2AreNotBothNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Only one member type can be specified. The member types specified are: &quot;{0}&quot;. Update the type with only one member type..
    /// </summary>
    internal static string WrongMemberCount {
        get {
            return ResourceManager.GetString("WrongMemberCount", resourceCulture);
        }
    }
}