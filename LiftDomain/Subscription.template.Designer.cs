﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiftDomain {
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
    internal class Subscription_template {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Subscription_template() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LiftDomain.Subscription.template", typeof(Subscription_template).Assembly);
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
        ///   Looks up a localized string similar to select u.email from subscriptions s, users u
        ///where s.user_id=u.id
        ///and s.request_id=${request_id}.
        /// </summary>
        internal static string get_subscribers {
            get {
                return ResourceManager.GetString("get_subscribers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT r.id AS request_id, r.title AS request_title, r.total_comments AS request_total_comments, r.last_action AS request_last_action
        ///FROM subscriptions s, requests r 
        ///WHERE s.request_id = r.id 
        ///AND s.user_id = ${user_id} 
        ///ORDER BY r.post_date DESC.
        /// </summary>
        internal static string get_subscription_by_user {
            get {
                return ResourceManager.GetString("get_subscription_by_user", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to delete from subscriptions where request_id=${request_id} and user_id=${user_id}.
        /// </summary>
        internal static string unsubscribe {
            get {
                return ResourceManager.GetString("unsubscribe", resourceCulture);
            }
        }
    }
}
