using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.player']/interface[@name='IUnityPlayerLifecycleEvents']"
	[Register ("com/unity3d/player/IUnityPlayerLifecycleEvents", "", "Com.Unity3d.Player.IUnityPlayerLifecycleEventsInvoker")]
	public partial interface IUnityPlayerLifecycleEvents : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='IUnityPlayerLifecycleEvents']/method[@name='onUnityPlayerQuitted' and count(parameter)=0]"
		[Register ("onUnityPlayerQuitted", "()V", "GetOnUnityPlayerQuittedHandler:Com.Unity3d.Player.IUnityPlayerLifecycleEventsInvoker, UnityLibrary")]
		void OnUnityPlayerQuitted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='IUnityPlayerLifecycleEvents']/method[@name='onUnityPlayerUnloaded' and count(parameter)=0]"
		[Register ("onUnityPlayerUnloaded", "()V", "GetOnUnityPlayerUnloadedHandler:Com.Unity3d.Player.IUnityPlayerLifecycleEventsInvoker, UnityLibrary")]
		void OnUnityPlayerUnloaded ();

	}

	[global::Android.Runtime.Register ("com/unity3d/player/IUnityPlayerLifecycleEvents", DoNotGenerateAcw=true)]
	internal partial class IUnityPlayerLifecycleEventsInvoker : global::Java.Lang.Object, IUnityPlayerLifecycleEvents {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/IUnityPlayerLifecycleEvents", typeof (IUnityPlayerLifecycleEventsInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IUnityPlayerLifecycleEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnityPlayerLifecycleEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.unity3d.player.IUnityPlayerLifecycleEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnityPlayerLifecycleEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerQuitted ();
		}
#pragma warning restore 0169

		IntPtr id_onUnityPlayerQuitted;
		public unsafe void OnUnityPlayerQuitted ()
		{
			if (id_onUnityPlayerQuitted == IntPtr.Zero)
				id_onUnityPlayerQuitted = JNIEnv.GetMethodID (class_ref, "onUnityPlayerQuitted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnityPlayerQuitted);
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
			global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IUnityPlayerLifecycleEvents> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnityPlayerUnloaded ();
		}
#pragma warning restore 0169

		IntPtr id_onUnityPlayerUnloaded;
		public unsafe void OnUnityPlayerUnloaded ()
		{
			if (id_onUnityPlayerUnloaded == IntPtr.Zero)
				id_onUnityPlayerUnloaded = JNIEnv.GetMethodID (class_ref, "onUnityPlayerUnloaded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnityPlayerUnloaded);
		}

	}

}
