﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DiaSymReader.Tools {
    using System;
    
    
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DiaSymReader.Tools.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Can&apos;t specify both /extract and /pdb options..
        /// </summary>
        internal static string CantSpecifyBothExtractAndPdbOptions {
            get {
                return ResourceManager.GetString("CantSpecifyBothExtractAndPdbOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t specify both /extract and /sourcelink options..
        /// </summary>
        internal static string CantSpecifyBothExtractAndSourcelinkOptions {
            get {
                return ResourceManager.GetString("CantSpecifyBothExtractAndSourcelinkOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; doesn&apos;t contain an embedded PDB..
        /// </summary>
        internal static string FileDoesntContainEmbeddedPdb {
            get {
                return ResourceManager.GetString("FileDoesntContainEmbeddedPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found: &apos;{0}&apos;.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; not found or doesn&apos;t match &apos;{1}&apos;..
        /// </summary>
        internal static string MatchingPdbNotFound {
            get {
                return ResourceManager.GetString("MatchingPdbNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing dll/exe path..
        /// </summary>
        internal static string MissingDllExePath {
            get {
                return ResourceManager.GetString("MissingDllExePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing value for option &apos;{0}&apos;.
        /// </summary>
        internal static string MissingValueForOption {
            get {
                return ResourceManager.GetString("MissingValueForOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; is neither associated with PDB nor does it embed PDB..
        /// </summary>
        internal static string NoAssociatedOrEmbeddedPdb {
            get {
                return ResourceManager.GetString("NoAssociatedOrEmbeddedPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one dll/exe can be specified.
        /// </summary>
        internal static string OnlyOneDllExeCanBeSpecified {
            get {
                return ResourceManager.GetString("OnlyOneDllExeCanBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: Pdb2Pdb &lt;dll/exe path&gt; [/pdb:&lt;path&gt;] [/out:&lt;path&gt;] [/extract]
        ///
        ////pdb:&lt;path&gt;    Path to the PDB to convert. If not specified explicitly, the PDB referenced by or embedded in the DLL/EXE is used.
        ////out:&lt;path&gt;    Output PDB path.
        ////extract       Extract PDB embedded in the DLL/EXE. 
        ////sourcelink    Preserve Source Link when converting from Portable PDB to Windows PDB, instead of converting to srcsrv format.
        ////varbose       Print detailed diagnostics.
        ///
        ////extract and /pdb are mutually exclusive.
        ///.
        /// </summary>
        internal static string Pdb2PdbUsage {
            get {
                return ResourceManager.GetString("Pdb2PdbUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized option: &apos;{0}&apos;.
        /// </summary>
        internal static string UnrecognizedOption {
            get {
                return ResourceManager.GetString("UnrecognizedOption", resourceCulture);
            }
        }
    }
}
