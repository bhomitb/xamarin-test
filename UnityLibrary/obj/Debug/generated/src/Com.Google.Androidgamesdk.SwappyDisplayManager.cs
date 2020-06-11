using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Androidgamesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']"
	[global::Android.Runtime.Register ("com/google/androidgamesdk/SwappyDisplayManager", DoNotGenerateAcw=true)]
	public partial class SwappyDisplayManager : global::Java.Lang.Object, global::Android.Hardware.Display.DisplayManager.IDisplayListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/androidgamesdk/SwappyDisplayManager", typeof (SwappyDisplayManager));
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

		protected SwappyDisplayManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/constructor[@name='SwappyDisplayManager' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(JLandroid/app/Activity;)V", "")]
		public unsafe SwappyDisplayManager (long p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLandroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onDisplayAdded_I;
#pragma warning disable 0169
		static Delegate GetOnDisplayAdded_IHandler ()
		{
			if (cb_onDisplayAdded_I == null)
				cb_onDisplayAdded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayAdded_I);
			return cb_onDisplayAdded_I;
		}

		static void n_OnDisplayAdded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Androidgamesdk.SwappyDisplayManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.SwappyDisplayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayAdded (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/method[@name='onDisplayAdded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDisplayAdded", "(I)V", "GetOnDisplayAdded_IHandler")]
		public virtual unsafe void OnDisplayAdded (int p0)
		{
			const string __id = "onDisplayAdded.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onDisplayChanged_I;
#pragma warning disable 0169
		static Delegate GetOnDisplayChanged_IHandler ()
		{
			if (cb_onDisplayChanged_I == null)
				cb_onDisplayChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayChanged_I);
			return cb_onDisplayChanged_I;
		}

		static void n_OnDisplayChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Androidgamesdk.SwappyDisplayManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.SwappyDisplayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/method[@name='onDisplayChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDisplayChanged", "(I)V", "GetOnDisplayChanged_IHandler")]
		public virtual unsafe void OnDisplayChanged (int p0)
		{
			const string __id = "onDisplayChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onDisplayRemoved_I;
#pragma warning disable 0169
		static Delegate GetOnDisplayRemoved_IHandler ()
		{
			if (cb_onDisplayRemoved_I == null)
				cb_onDisplayRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDisplayRemoved_I);
			return cb_onDisplayRemoved_I;
		}

		static void n_OnDisplayRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Androidgamesdk.SwappyDisplayManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.SwappyDisplayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayRemoved (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/method[@name='onDisplayRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDisplayRemoved", "(I)V", "GetOnDisplayRemoved_IHandler")]
		public virtual unsafe void OnDisplayRemoved (int p0)
		{
			const string __id = "onDisplayRemoved.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPreferredRefreshRate_I;
#pragma warning disable 0169
		static Delegate GetSetPreferredRefreshRate_IHandler ()
		{
			if (cb_setPreferredRefreshRate_I == null)
				cb_setPreferredRefreshRate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreferredRefreshRate_I);
			return cb_setPreferredRefreshRate_I;
		}

		static void n_SetPreferredRefreshRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Androidgamesdk.SwappyDisplayManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.SwappyDisplayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferredRefreshRate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/method[@name='setPreferredRefreshRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPreferredRefreshRate", "(I)V", "GetSetPreferredRefreshRate_IHandler")]
		public virtual unsafe void SetPreferredRefreshRate (int p0)
		{
			const string __id = "setPreferredRefreshRate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_terminate;
#pragma warning disable 0169
		static Delegate GetTerminateHandler ()
		{
			if (cb_terminate == null)
				cb_terminate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Terminate);
			return cb_terminate;
		}

		static void n_Terminate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Androidgamesdk.SwappyDisplayManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.SwappyDisplayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Terminate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='SwappyDisplayManager']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()V", "GetTerminateHandler")]
		public virtual unsafe void Terminate ()
		{
			const string __id = "terminate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
