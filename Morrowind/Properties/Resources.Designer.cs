﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nexus.Client.Games.Morrowind.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nexus.Client.Games.Morrowind.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;categoryManager fileVersion=&quot;0.1.0.0&quot;&gt;
        ///  &lt;categoryList&gt;
        ///    &lt;category path=&quot;Buildings&quot; ID=&quot;2&quot;&gt;
        ///      &lt;name&gt;Buildings&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Dungeons and Locations&quot; ID=&quot;3&quot;&gt;
        ///      &lt;name&gt;Dungeons and Locations&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Gameplay Effects and Changes&quot; ID=&quot;4&quot;&gt;
        ///      &lt;name&gt;Gameplay Effects and Changes&lt;/name&gt;
        ///    &lt;/category&gt;
        ///    &lt;category path=&quot;Guilds and Factions&quot; ID=&quot;5&quot;&gt;
        ///      &lt;name&gt;Guilds and Factions&lt;/name&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Categories {
            get {
                return ResourceManager.GetString("Categories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon morrowind_logo {
            get {
                object obj = ResourceManager.GetObject("morrowind_logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
