using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']"
	[global::Android.Runtime.Register ("com/unity3d/player/UnityPlayer", DoNotGenerateAcw=true)]
	public partial class UnityPlayer : global::Android.Widget.FrameLayout, global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/field[@name='currentActivity']"
		[Register ("currentActivity")]
		public static global::Android.App.Activity CurrentActivity {
			get {
				const string __id = "currentActivity.Landroid/app/Activity;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "currentActivity.Landroid/app/Activity;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/UnityPlayer", typeof (UnityPlayer));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected UnityPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/constructor[@name='UnityPlayer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe UnityPlayer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/constructor[@name='UnityPlayer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.unity3d.player.IUnityPlayerLifecycleEvents']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/unity3d/player/IUnityPlayerLifecycleEvents;)V", "")]
		public unsafe UnityPlayer (global::Android.Content.Context p0, global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/unity3d/player/IUnityPlayerLifecycleEvents;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getClipboardText;
#pragma warning disable 0169
		static Delegate GetGetClipboardTextHandler ()
		{
			if (cb_getClipboardText == null)
				cb_getClipboardText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClipboardText);
			return cb_getClipboardText;
		}

		static IntPtr n_GetClipboardText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClipboardText);
		}
#pragma warning restore 0169

		static Delegate cb_setClipboardText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClipboardText_Ljava_lang_String_Handler ()
		{
			if (cb_setClipboardText_Ljava_lang_String_ == null)
				cb_setClipboardText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClipboardText_Ljava_lang_String_);
			return cb_setClipboardText_Ljava_lang_String_;
		}

		static void n_SetClipboardText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClipboardText = p0;
		}
#pragma warning restore 0169

		protected virtual unsafe string ClipboardText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getClipboardText' and count(parameter)=0]"
			[Register ("getClipboardText", "()Ljava/lang/String;", "GetGetClipboardTextHandler")]
			get {
				const string __id = "getClipboardText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='setClipboardText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClipboardText", "(Ljava/lang/String;)V", "GetSetClipboardText_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClipboardText.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isFinishing;
#pragma warning disable 0169
		static Delegate GetIsFinishingHandler ()
		{
			if (cb_isFinishing == null)
				cb_isFinishing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFinishing);
			return cb_isFinishing;
		}

		static bool n_IsFinishing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFinishing;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsFinishing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='isFinishing' and count(parameter)=0]"
			[Register ("isFinishing", "()Z", "GetIsFinishingHandler")]
			get {
				const string __id = "isFinishing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKeyboardLayout;
#pragma warning disable 0169
		static Delegate GetGetKeyboardLayoutHandler ()
		{
			if (cb_getKeyboardLayout == null)
				cb_getKeyboardLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyboardLayout);
			return cb_getKeyboardLayout;
		}

		static IntPtr n_GetKeyboardLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyboardLayout);
		}
#pragma warning restore 0169

		protected virtual unsafe string KeyboardLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getKeyboardLayout' and count(parameter)=0]"
			[Register ("getKeyboardLayout", "()Ljava/lang/String;", "GetGetKeyboardLayoutHandler")]
			get {
				const string __id = "getKeyboardLayout.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLaunchURL;
#pragma warning disable 0169
		static Delegate GetGetLaunchURLHandler ()
		{
			if (cb_getLaunchURL == null)
				cb_getLaunchURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLaunchURL);
			return cb_getLaunchURL;
		}

		static IntPtr n_GetLaunchURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LaunchURL);
		}
#pragma warning restore 0169

		protected virtual unsafe string LaunchURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getLaunchURL' and count(parameter)=0]"
			[Register ("getLaunchURL", "()Ljava/lang/String;", "GetGetLaunchURLHandler")]
			get {
				const string __id = "getLaunchURL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkConnectivity;
#pragma warning disable 0169
		static Delegate GetGetNetworkConnectivityHandler ()
		{
			if (cb_getNetworkConnectivity == null)
				cb_getNetworkConnectivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNetworkConnectivity);
			return cb_getNetworkConnectivity;
		}

		static int n_GetNetworkConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkConnectivity;
		}
#pragma warning restore 0169

		protected virtual unsafe int NetworkConnectivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getNetworkConnectivity' and count(parameter)=0]"
			[Register ("getNetworkConnectivity", "()I", "GetGetNetworkConnectivityHandler")]
			get {
				const string __id = "getNetworkConnectivity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSettings;
#pragma warning disable 0169
		static Delegate GetGetSettingsHandler ()
		{
			if (cb_getSettings == null)
				cb_getSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSettings);
			return cb_getSettings;
		}

		static IntPtr n_GetSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle Settings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getSettings' and count(parameter)=0]"
			[Register ("getSettings", "()Landroid/os/Bundle;", "GetGetSettingsHandler")]
			get {
				const string __id = "getSettings.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSplashMode;
#pragma warning disable 0169
		static Delegate GetGetSplashModeHandler ()
		{
			if (cb_getSplashMode == null)
				cb_getSplashMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSplashMode);
			return cb_getSplashMode;
		}

		static int n_GetSplashMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SplashMode;
		}
#pragma warning restore 0169

		protected virtual unsafe int SplashMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getSplashMode' and count(parameter)=0]"
			[Register ("getSplashMode", "()I", "GetGetSplashModeHandler")]
			get {
				const string __id = "getSplashMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='UnitySendMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("UnitySendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void UnitySendMessage (string p0, string p1, string p2)
		{
			const string __id = "UnitySendMessage.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addPhoneCallListener;
#pragma warning disable 0169
		static Delegate GetAddPhoneCallListenerHandler ()
		{
			if (cb_addPhoneCallListener == null)
				cb_addPhoneCallListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddPhoneCallListener);
			return cb_addPhoneCallListener;
		}

		static void n_AddPhoneCallListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPhoneCallListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='addPhoneCallListener' and count(parameter)=0]"
		[Register ("addPhoneCallListener", "()V", "GetAddPhoneCallListenerHandler")]
		protected virtual unsafe void AddPhoneCallListener ()
		{
			const string __id = "addPhoneCallListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_addViewToPlayer_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetAddViewToPlayer_Landroid_view_View_ZHandler ()
		{
			if (cb_addViewToPlayer_Landroid_view_View_Z == null)
				cb_addViewToPlayer_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_AddViewToPlayer_Landroid_view_View_Z);
			return cb_addViewToPlayer_Landroid_view_View_Z;
		}

		static bool n_AddViewToPlayer_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddViewToPlayer (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='addViewToPlayer' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("addViewToPlayer", "(Landroid/view/View;Z)Z", "GetAddViewToPlayer_Landroid_view_View_ZHandler")]
		public virtual unsafe bool AddViewToPlayer (global::Android.Views.View p0, bool p1)
		{
			const string __id = "addViewToPlayer.(Landroid/view/View;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_configurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_configurationChanged_Landroid_content_res_Configuration_ == null)
				cb_configurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_configurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_ConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfigurationChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='configurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("configurationChanged", "(Landroid/content/res/Configuration;)V", "GetConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void ConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			const string __id = "configurationChanged.(Landroid/content/res/Configuration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableLogger;
#pragma warning disable 0169
		static Delegate GetDisableLoggerHandler ()
		{
			if (cb_disableLogger == null)
				cb_disableLogger = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableLogger);
			return cb_disableLogger;
		}

		static void n_DisableLogger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableLogger ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='disableLogger' and count(parameter)=0]"
		[Register ("disableLogger", "()V", "GetDisableLoggerHandler")]
		protected virtual unsafe void DisableLogger ()
		{
			const string __id = "disableLogger.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_displayChanged_ILandroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetDisplayChanged_ILandroid_view_Surface_Handler ()
		{
			if (cb_displayChanged_ILandroid_view_Surface_ == null)
				cb_displayChanged_ILandroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_DisplayChanged_ILandroid_view_Surface_);
			return cb_displayChanged_ILandroid_view_Surface_;
		}

		static bool n_DisplayChanged_ILandroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p1 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DisplayChanged (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='displayChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Surface']]"
		[Register ("displayChanged", "(ILandroid/view/Surface;)Z", "GetDisplayChanged_ILandroid_view_Surface_Handler")]
		public virtual unsafe bool DisplayChanged (int p0, global::Android.Views.Surface p1)
		{
			const string __id = "displayChanged.(ILandroid/view/Surface;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_executeGLThreadJobs;
#pragma warning disable 0169
		static Delegate GetExecuteGLThreadJobsHandler ()
		{
			if (cb_executeGLThreadJobs == null)
				cb_executeGLThreadJobs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ExecuteGLThreadJobs);
			return cb_executeGLThreadJobs;
		}

		static void n_ExecuteGLThreadJobs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteGLThreadJobs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='executeGLThreadJobs' and count(parameter)=0]"
		[Register ("executeGLThreadJobs", "()V", "GetExecuteGLThreadJobsHandler")]
		protected virtual unsafe void ExecuteGLThreadJobs ()
		{
			const string __id = "executeGLThreadJobs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getNetworkProxySettings_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNetworkProxySettings_Ljava_lang_String_Handler ()
		{
			if (cb_getNetworkProxySettings_Ljava_lang_String_ == null)
				cb_getNetworkProxySettings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNetworkProxySettings_Ljava_lang_String_);
			return cb_getNetworkProxySettings_Ljava_lang_String_;
		}

		static IntPtr n_GetNetworkProxySettings_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetNetworkProxySettings (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='getNetworkProxySettings' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNetworkProxySettings", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetNetworkProxySettings_Ljava_lang_String_Handler")]
		public virtual unsafe string GetNetworkProxySettings (string p0)
		{
			const string __id = "getNetworkProxySettings.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hideSoftInput;
#pragma warning disable 0169
		static Delegate GetHideSoftInputHandler ()
		{
			if (cb_hideSoftInput == null)
				cb_hideSoftInput = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideSoftInput);
			return cb_hideSoftInput;
		}

		static void n_HideSoftInput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideSoftInput ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='hideSoftInput' and count(parameter)=0]"
		[Register ("hideSoftInput", "()V", "GetHideSoftInputHandler")]
		protected virtual unsafe void HideSoftInput ()
		{
			const string __id = "hideSoftInput.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_IZ;
#pragma warning disable 0169
		static Delegate GetInit_IZHandler ()
		{
			if (cb_init_IZ == null)
				cb_init_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Init_IZ);
			return cb_init_IZ;
		}

		static void n_Init_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("init", "(IZ)V", "GetInit_IZHandler")]
		public virtual unsafe void Init (int p0, bool p1)
		{
			const string __id = "init.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initializeGoogleAr;
#pragma warning disable 0169
		static Delegate GetInitializeGoogleArHandler ()
		{
			if (cb_initializeGoogleAr == null)
				cb_initializeGoogleAr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InitializeGoogleAr);
			return cb_initializeGoogleAr;
		}

		static bool n_InitializeGoogleAr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitializeGoogleAr ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='initializeGoogleAr' and count(parameter)=0]"
		[Register ("initializeGoogleAr", "()Z", "GetInitializeGoogleArHandler")]
		protected virtual unsafe bool InitializeGoogleAr ()
		{
			const string __id = "initializeGoogleAr.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initializeGoogleVr;
#pragma warning disable 0169
		static Delegate GetInitializeGoogleVrHandler ()
		{
			if (cb_initializeGoogleVr == null)
				cb_initializeGoogleVr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InitializeGoogleVr);
			return cb_initializeGoogleVr;
		}

		static bool n_InitializeGoogleVr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitializeGoogleVr ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='initializeGoogleVr' and count(parameter)=0]"
		[Register ("initializeGoogleVr", "()Z", "GetInitializeGoogleVrHandler")]
		protected virtual unsafe bool InitializeGoogleVr ()
		{
			const string __id = "initializeGoogleVr.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_injectEvent_Landroid_view_InputEvent_;
#pragma warning disable 0169
		static Delegate GetInjectEvent_Landroid_view_InputEvent_Handler ()
		{
			if (cb_injectEvent_Landroid_view_InputEvent_ == null)
				cb_injectEvent_Landroid_view_InputEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InjectEvent_Landroid_view_InputEvent_);
			return cb_injectEvent_Landroid_view_InputEvent_;
		}

		static bool n_InjectEvent_Landroid_view_InputEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.InputEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.InputEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InjectEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='injectEvent' and count(parameter)=1 and parameter[1][@type='android.view.InputEvent']]"
		[Register ("injectEvent", "(Landroid/view/InputEvent;)Z", "GetInjectEvent_Landroid_view_InputEvent_Handler")]
		public virtual unsafe bool InjectEvent (global::Android.Views.InputEvent p0)
		{
			const string __id = "injectEvent.(Landroid/view/InputEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_kill;
#pragma warning disable 0169
		static Delegate GetKillHandler ()
		{
			if (cb_kill == null)
				cb_kill = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Kill);
			return cb_kill;
		}

		static void n_Kill (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Kill ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='kill' and count(parameter)=0]"
		[Register ("kill", "()V", "GetKillHandler")]
		protected virtual unsafe void Kill ()
		{
			const string __id = "kill.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_loadLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_loadLibrary_Ljava_lang_String_ == null)
				cb_loadLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadLibrary_Ljava_lang_String_);
			return cb_loadLibrary_Ljava_lang_String_;
		}

		static bool n_LoadLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadLibrary (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='loadLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibrary", "(Ljava/lang/String;)Z", "GetLoadLibrary_Ljava_lang_String_Handler")]
		protected virtual unsafe bool LoadLibrary (string p0)
		{
			const string __id = "loadLibrary.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='loadLibraryStatic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadLibraryStatic", "(Ljava/lang/String;)Z", "")]
		protected static unsafe bool LoadLibraryStatic (string p0)
		{
			const string __id = "loadLibraryStatic.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_lowMemory;
#pragma warning disable 0169
		static Delegate GetLowMemoryHandler ()
		{
			if (cb_lowMemory == null)
				cb_lowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LowMemory);
			return cb_lowMemory;
		}

		static void n_LowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LowMemory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='lowMemory' and count(parameter)=0]"
		[Register ("lowMemory", "()V", "GetLowMemoryHandler")]
		public virtual unsafe void LowMemory ()
		{
			const string __id = "lowMemory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_newIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetNewIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_newIntent_Landroid_content_Intent_ == null)
				cb_newIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NewIntent_Landroid_content_Intent_);
			return cb_newIntent_Landroid_content_Intent_;
		}

		static void n_NewIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewIntent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='newIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("newIntent", "(Landroid/content/Intent;)V", "GetNewIntent_Landroid_content_Intent_Handler")]
		public virtual unsafe void NewIntent (global::Android.Content.Intent p0)
		{
			const string __id = "newIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyOnUnityPlayerUnloaded;
#pragma warning disable 0169
		static Delegate GetNotifyOnUnityPlayerUnloadedHandler ()
		{
			if (cb_notifyOnUnityPlayerUnloaded == null)
				cb_notifyOnUnityPlayerUnloaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyOnUnityPlayerUnloaded);
			return cb_notifyOnUnityPlayerUnloaded;
		}

		static void n_NotifyOnUnityPlayerUnloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyOnUnityPlayerUnloaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='notifyOnUnityPlayerUnloaded' and count(parameter)=0]"
		[Register ("notifyOnUnityPlayerUnloaded", "()V", "GetNotifyOnUnityPlayerUnloadedHandler")]
		protected virtual unsafe void NotifyOnUnityPlayerUnloaded ()
		{
			const string __id = "notifyOnUnityPlayerUnloaded.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onUnityPlayerQuitted;
#pragma warning disable 0169
		static Delegate GetOnUnityPlayerQuittedHandler ()
		{
			if (cb_onUnityPlayerQuitted == null)
				cb_onUnityPlayerQuitted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnityPlayerQuitted);
			return cb_onUnityPlayerQuitted;
		}

		static void n_OnUnityPlayerQuitted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerQuitted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='onUnityPlayerQuitted' and count(parameter)=0]"
		[Register ("onUnityPlayerQuitted", "()V", "GetOnUnityPlayerQuittedHandler")]
		public virtual unsafe void OnUnityPlayerQuitted ()
		{
			const string __id = "onUnityPlayerQuitted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onUnityPlayerUnloaded;
#pragma warning disable 0169
		static Delegate GetOnUnityPlayerUnloadedHandler ()
		{
			if (cb_onUnityPlayerUnloaded == null)
				cb_onUnityPlayerUnloaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnityPlayerUnloaded);
			return cb_onUnityPlayerUnloaded;
		}

		static void n_OnUnityPlayerUnloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerUnloaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='onUnityPlayerUnloaded' and count(parameter)=0]"
		[Register ("onUnityPlayerUnloaded", "()V", "GetOnUnityPlayerUnloadedHandler")]
		public virtual unsafe void OnUnityPlayerUnloaded ()
		{
			const string __id = "onUnityPlayerUnloaded.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler ()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quit);
			return cb_quit;
		}

		static void n_Quit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='quit' and count(parameter)=0]"
		[Register ("quit", "()V", "GetQuitHandler")]
		public virtual unsafe void Quit ()
		{
			const string __id = "quit.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeViewFromPlayer_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRemoveViewFromPlayer_Landroid_view_View_Handler ()
		{
			if (cb_removeViewFromPlayer_Landroid_view_View_ == null)
				cb_removeViewFromPlayer_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveViewFromPlayer_Landroid_view_View_);
			return cb_removeViewFromPlayer_Landroid_view_View_;
		}

		static void n_RemoveViewFromPlayer_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveViewFromPlayer (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='removeViewFromPlayer' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("removeViewFromPlayer", "(Landroid/view/View;)V", "GetRemoveViewFromPlayer_Landroid_view_View_Handler")]
		public virtual unsafe void RemoveViewFromPlayer (global::Android.Views.View p0)
		{
			const string __id = "removeViewFromPlayer.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reportError_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportError_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reportError_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reportError_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportError_Ljava_lang_String_Ljava_lang_String_);
			return cb_reportError_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReportError_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportError (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='reportError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportError", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReportError_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ReportError (string p0, string p1)
		{
			const string __id = "reportError.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reportSoftInputArea_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetReportSoftInputArea_Landroid_graphics_Rect_Handler ()
		{
			if (cb_reportSoftInputArea_Landroid_graphics_Rect_ == null)
				cb_reportSoftInputArea_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportSoftInputArea_Landroid_graphics_Rect_);
			return cb_reportSoftInputArea_Landroid_graphics_Rect_;
		}

		static void n_ReportSoftInputArea_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportSoftInputArea (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='reportSoftInputArea' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("reportSoftInputArea", "(Landroid/graphics/Rect;)V", "GetReportSoftInputArea_Landroid_graphics_Rect_Handler")]
		protected virtual unsafe void ReportSoftInputArea (global::Android.Graphics.Rect p0)
		{
			const string __id = "reportSoftInputArea.(Landroid/graphics/Rect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reportSoftInputIsVisible_Z;
#pragma warning disable 0169
		static Delegate GetReportSoftInputIsVisible_ZHandler ()
		{
			if (cb_reportSoftInputIsVisible_Z == null)
				cb_reportSoftInputIsVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReportSoftInputIsVisible_Z);
			return cb_reportSoftInputIsVisible_Z;
		}

		static void n_ReportSoftInputIsVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportSoftInputIsVisible (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='reportSoftInputIsVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reportSoftInputIsVisible", "(Z)V", "GetReportSoftInputIsVisible_ZHandler")]
		protected virtual unsafe void ReportSoftInputIsVisible (bool p0)
		{
			const string __id = "reportSoftInputIsVisible.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reportSoftInputSelection_II;
#pragma warning disable 0169
		static Delegate GetReportSoftInputSelection_IIHandler ()
		{
			if (cb_reportSoftInputSelection_II == null)
				cb_reportSoftInputSelection_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReportSoftInputSelection_II);
			return cb_reportSoftInputSelection_II;
		}

		static void n_ReportSoftInputSelection_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportSoftInputSelection (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='reportSoftInputSelection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reportSoftInputSelection", "(II)V", "GetReportSoftInputSelection_IIHandler")]
		protected virtual unsafe void ReportSoftInputSelection (int p0, int p1)
		{
			const string __id = "reportSoftInputSelection.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reportSoftInputStr_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetReportSoftInputStr_Ljava_lang_String_IZHandler ()
		{
			if (cb_reportSoftInputStr_Ljava_lang_String_IZ == null)
				cb_reportSoftInputStr_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_ReportSoftInputStr_Ljava_lang_String_IZ);
			return cb_reportSoftInputStr_Ljava_lang_String_IZ;
		}

		static void n_ReportSoftInputStr_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportSoftInputStr (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='reportSoftInputStr' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("reportSoftInputStr", "(Ljava/lang/String;IZ)V", "GetReportSoftInputStr_Ljava_lang_String_IZHandler")]
		protected virtual unsafe void ReportSoftInputStr (string p0, int p1, bool p2)
		{
			const string __id = "reportSoftInputStr.(Ljava/lang/String;IZ)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_requestUserAuthorization_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestUserAuthorization_Ljava_lang_String_Handler ()
		{
			if (cb_requestUserAuthorization_Ljava_lang_String_ == null)
				cb_requestUserAuthorization_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestUserAuthorization_Ljava_lang_String_);
			return cb_requestUserAuthorization_Ljava_lang_String_;
		}

		static void n_RequestUserAuthorization_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestUserAuthorization (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='requestUserAuthorization' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestUserAuthorization", "(Ljava/lang/String;)V", "GetRequestUserAuthorization_Ljava_lang_String_Handler")]
		protected virtual unsafe void RequestUserAuthorization (string p0)
		{
			const string __id = "requestUserAuthorization.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCharacterLimit_I;
#pragma warning disable 0169
		static Delegate GetSetCharacterLimit_IHandler ()
		{
			if (cb_setCharacterLimit_I == null)
				cb_setCharacterLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCharacterLimit_I);
			return cb_setCharacterLimit_I;
		}

		static void n_SetCharacterLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacterLimit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='setCharacterLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCharacterLimit", "(I)V", "GetSetCharacterLimit_IHandler")]
		protected virtual unsafe void SetCharacterLimit (int p0)
		{
			const string __id = "setCharacterLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHideInputField_Z;
#pragma warning disable 0169
		static Delegate GetSetHideInputField_ZHandler ()
		{
			if (cb_setHideInputField_Z == null)
				cb_setHideInputField_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideInputField_Z);
			return cb_setHideInputField_Z;
		}

		static void n_SetHideInputField_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHideInputField (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='setHideInputField' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideInputField", "(Z)V", "GetSetHideInputField_ZHandler")]
		protected virtual unsafe void SetHideInputField (bool p0)
		{
			const string __id = "setHideInputField.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_II;
#pragma warning disable 0169
		static Delegate GetSetSelection_IIHandler ()
		{
			if (cb_setSelection_II == null)
				cb_setSelection_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSelection_II);
			return cb_setSelection_II;
		}

		static void n_SetSelection_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='setSelection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSelection", "(II)V", "GetSetSelection_IIHandler")]
		protected virtual unsafe void SetSelection (int p0, int p1)
		{
			const string __id = "setSelection.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSoftInputStr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSoftInputStr_Ljava_lang_String_Handler ()
		{
			if (cb_setSoftInputStr_Ljava_lang_String_ == null)
				cb_setSoftInputStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSoftInputStr_Ljava_lang_String_);
			return cb_setSoftInputStr_Ljava_lang_String_;
		}

		static void n_SetSoftInputStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSoftInputStr (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='setSoftInputStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSoftInputStr", "(Ljava/lang/String;)V", "GetSetSoftInputStr_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetSoftInputStr (string p0)
		{
			const string __id = "setSoftInputStr.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_showSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetShowSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZHandler ()
		{
			if (cb_showSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ == null)
				cb_showSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool, bool, bool, bool, IntPtr, int, bool>) n_ShowSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ);
			return cb_showSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ;
		}

		static void n_ShowSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2, bool p3, bool p4, bool p5, IntPtr native_p6, int p7, bool p8)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.ShowSoftInput (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='showSoftInput' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int'] and parameter[9][@type='boolean']]"
		[Register ("showSoftInput", "(Ljava/lang/String;IZZZZLjava/lang/String;IZ)V", "GetShowSoftInput_Ljava_lang_String_IZZZZLjava_lang_String_IZHandler")]
		protected virtual unsafe void ShowSoftInput (string p0, int p1, bool p2, bool p3, bool p4, bool p5, string p6, int p7, bool p8)
		{
			const string __id = "showSoftInput.(Ljava/lang/String;IZZZZLjava/lang/String;IZ)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_showVideoPlayer_Ljava_lang_String_IIIZII;
#pragma warning disable 0169
		static Delegate GetShowVideoPlayer_Ljava_lang_String_IIIZIIHandler ()
		{
			if (cb_showVideoPlayer_Ljava_lang_String_IIIZII == null)
				cb_showVideoPlayer_Ljava_lang_String_IIIZII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, bool, int, int, bool>) n_ShowVideoPlayer_Ljava_lang_String_IIIZII);
			return cb_showVideoPlayer_Ljava_lang_String_IIIZII;
		}

		static bool n_ShowVideoPlayer_Ljava_lang_String_IIIZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, bool p4, int p5, int p6)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowVideoPlayer (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='showVideoPlayer' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("showVideoPlayer", "(Ljava/lang/String;IIIZII)Z", "GetShowVideoPlayer_Ljava_lang_String_IIIZIIHandler")]
		protected virtual unsafe bool ShowVideoPlayer (string p0, int p1, int p2, int p3, bool p4, int p5, int p6)
		{
			const string __id = "showVideoPlayer.(Ljava/lang/String;IIIZII)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_skipPermissionsDialog;
#pragma warning disable 0169
		static Delegate GetSkipPermissionsDialogHandler ()
		{
			if (cb_skipPermissionsDialog == null)
				cb_skipPermissionsDialog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SkipPermissionsDialog);
			return cb_skipPermissionsDialog;
		}

		static bool n_SkipPermissionsDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipPermissionsDialog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='skipPermissionsDialog' and count(parameter)=0]"
		[Register ("skipPermissionsDialog", "()Z", "GetSkipPermissionsDialogHandler")]
		protected virtual unsafe bool SkipPermissionsDialog ()
		{
			const string __id = "skipPermissionsDialog.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startOrientationListener_I;
#pragma warning disable 0169
		static Delegate GetStartOrientationListener_IHandler ()
		{
			if (cb_startOrientationListener_I == null)
				cb_startOrientationListener_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_StartOrientationListener_I);
			return cb_startOrientationListener_I;
		}

		static bool n_StartOrientationListener_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartOrientationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='startOrientationListener' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("startOrientationListener", "(I)Z", "GetStartOrientationListener_IHandler")]
		public virtual unsafe bool StartOrientationListener (int p0)
		{
			const string __id = "startOrientationListener.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopOrientationListener;
#pragma warning disable 0169
		static Delegate GetStopOrientationListenerHandler ()
		{
			if (cb_stopOrientationListener == null)
				cb_stopOrientationListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopOrientationListener);
			return cb_stopOrientationListener;
		}

		static bool n_StopOrientationListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopOrientationListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='stopOrientationListener' and count(parameter)=0]"
		[Register ("stopOrientationListener", "()Z", "GetStopOrientationListenerHandler")]
		public virtual unsafe bool StopOrientationListener ()
		{
			const string __id = "stopOrientationListener.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toggleGyroscopeSensor_Z;
#pragma warning disable 0169
		static Delegate GetToggleGyroscopeSensor_ZHandler ()
		{
			if (cb_toggleGyroscopeSensor_Z == null)
				cb_toggleGyroscopeSensor_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ToggleGyroscopeSensor_Z);
			return cb_toggleGyroscopeSensor_Z;
		}

		static void n_ToggleGyroscopeSensor_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleGyroscopeSensor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='toggleGyroscopeSensor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toggleGyroscopeSensor", "(Z)V", "GetToggleGyroscopeSensor_ZHandler")]
		protected virtual unsafe void ToggleGyroscopeSensor (bool p0)
		{
			const string __id = "toggleGyroscopeSensor.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unload;
#pragma warning disable 0169
		static Delegate GetUnloadHandler ()
		{
			if (cb_unload == null)
				cb_unload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unload);
			return cb_unload;
		}

		static void n_Unload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='unload' and count(parameter)=0]"
		[Register ("unload", "()V", "GetUnloadHandler")]
		public virtual unsafe void Unload ()
		{
			const string __id = "unload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_windowFocusChanged_Z;
#pragma warning disable 0169
		static Delegate GetWindowFocusChanged_ZHandler ()
		{
			if (cb_windowFocusChanged_Z == null)
				cb_windowFocusChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_WindowFocusChanged_Z);
			return cb_windowFocusChanged_Z;
		}

		static void n_WindowFocusChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Unity3d.Player.UnityPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WindowFocusChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayer']/method[@name='windowFocusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("windowFocusChanged", "(Z)V", "GetWindowFocusChanged_ZHandler")]
		public virtual unsafe void WindowFocusChanged (bool p0)
		{
			const string __id = "windowFocusChanged.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
