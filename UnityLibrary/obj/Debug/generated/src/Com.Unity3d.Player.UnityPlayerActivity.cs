using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']"
	[global::Android.Runtime.Register ("com/unity3d/player/UnityPlayerActivity", DoNotGenerateAcw=true)]
	public partial class UnityPlayerActivity : global::Android.App.Activity, global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']/field[@name='mUnityPlayer']"
		[Register ("mUnityPlayer")]
		protected global::Com.Unity3d.Player.UnityPlayer MUnityPlayer {
			get {
				const string __id = "mUnityPlayer.Lcom/unity3d/player/UnityPlayer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUnityPlayer.Lcom/unity3d/player/UnityPlayer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/UnityPlayerActivity", typeof (UnityPlayerActivity));
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

		protected UnityPlayerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']/constructor[@name='UnityPlayerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnityPlayerActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
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
			global::Com.Unity3d.Player.UnityPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerQuitted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']/method[@name='onUnityPlayerQuitted' and count(parameter)=0]"
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
			global::Com.Unity3d.Player.UnityPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerUnloaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']/method[@name='onUnityPlayerUnloaded' and count(parameter)=0]"
		[Register ("onUnityPlayerUnloaded", "()V", "GetOnUnityPlayerUnloadedHandler")]
		public virtual unsafe void OnUnityPlayerUnloaded ()
		{
			const string __id = "onUnityPlayerUnloaded.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateUnityCommandLineArguments_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateUnityCommandLineArguments_Ljava_lang_String_Handler ()
		{
			if (cb_updateUnityCommandLineArguments_Ljava_lang_String_ == null)
				cb_updateUnityCommandLineArguments_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateUnityCommandLineArguments_Ljava_lang_String_);
			return cb_updateUnityCommandLineArguments_Ljava_lang_String_;
		}

		static IntPtr n_UpdateUnityCommandLineArguments_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cmdLine)
		{
			global::Com.Unity3d.Player.UnityPlayerActivity __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.UnityPlayerActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cmdLine = JNIEnv.GetString (native_cmdLine, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdateUnityCommandLineArguments (cmdLine));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='UnityPlayerActivity']/method[@name='updateUnityCommandLineArguments' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateUnityCommandLineArguments", "(Ljava/lang/String;)Ljava/lang/String;", "GetUpdateUnityCommandLineArguments_Ljava_lang_String_Handler")]
		protected virtual unsafe string UpdateUnityCommandLineArguments (string cmdLine)
		{
			const string __id = "updateUnityCommandLineArguments.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_cmdLine = JNIEnv.NewString (cmdLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cmdLine);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cmdLine);
			}
		}

	}
}
