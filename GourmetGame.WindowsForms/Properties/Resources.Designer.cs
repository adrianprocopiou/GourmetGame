﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GourmetGame.WindowsForms.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GourmetGame.WindowsForms.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} é ________ mas {1} não.
        /// </summary>
        internal static string CategoryUserInputCaption {
            get {
                return ResourceManager.GetString("CategoryUserInputCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O prato que você pensou é {0} ?.
        /// </summary>
        internal static string CategoryUserMessage {
            get {
                return ResourceManager.GetString("CategoryUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Qual prato você pensou?.
        /// </summary>
        internal static string DishUserInputCaption {
            get {
                return ResourceManager.GetString("DishUserInputCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Acertei de novo!.
        /// </summary>
        internal static string SuccessUserMessage {
            get {
                return ResourceManager.GetString("SuccessUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jogo Gourmet.
        /// </summary>
        internal static string TitleMessageBox {
            get {
                return ResourceManager.GetString("TitleMessageBox", resourceCulture);
            }
        }
    }
}
