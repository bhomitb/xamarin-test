using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Androidgamesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']"
	[global::Android.Runtime.Register ("com/google/androidgamesdk/ChoreographerCallback", DoNotGenerateAcw=true)]
	public partial class ChoreographerCallback : global::Java.Lang.Object, global::Android.Views.Choreographer.IFrameCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/androidgamesdk/ChoreographerCallback", typeof (ChoreographerCallback));
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

		protected ChoreographerCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/constructor[@name='ChoreographerCallback' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe ChoreographerCallback (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_doFrame_J;
#pragma warning disable 0169
		static Delegate GetDoFrame_JHandler ()
		{
			if (cb_doFrame_J == null)
				cb_doFrame_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DoFrame_J);
			return cb_doFrame_J;
		}

		static void n_DoFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Androidgamesdk.ChoreographerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.ChoreographerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoFrame (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/method[@name='doFrame' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("doFrame", "(J)V", "GetDoFrame_JHandler")]
		public virtual unsafe void DoFrame (long p0)
		{
			const string __id = "doFrame.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_nOnChoreographer_JJ;
#pragma warning disable 0169
		static Delegate GetNOnChoreographer_JJHandler ()
		{
			if (cb_nOnChoreographer_JJ == null)
				cb_nOnChoreographer_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_NOnChoreographer_JJ);
			return cb_nOnChoreographer_JJ;
		}

		static void n_NOnChoreographer_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Google.Androidgamesdk.ChoreographerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.ChoreographerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NOnChoreographer (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/method[@name='nOnChoreographer' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("nOnChoreographer", "(JJ)V", "GetNOnChoreographer_JJHandler")]
		public virtual unsafe void NOnChoreographer (long p0, long p1)
		{
			const string __id = "nOnChoreographer.(JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postFrameCallback;
#pragma warning disable 0169
		static Delegate GetPostFrameCallbackHandler ()
		{
			if (cb_postFrameCallback == null)
				cb_postFrameCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostFrameCallback);
			return cb_postFrameCallback;
		}

		static void n_PostFrameCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Androidgamesdk.ChoreographerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.ChoreographerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostFrameCallback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/method[@name='postFrameCallback' and count(parameter)=0]"
		[Register ("postFrameCallback", "()V", "GetPostFrameCallbackHandler")]
		public virtual unsafe void PostFrameCallback ()
		{
			const string __id = "postFrameCallback.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postFrameCallbackDelayed_J;
#pragma warning disable 0169
		static Delegate GetPostFrameCallbackDelayed_JHandler ()
		{
			if (cb_postFrameCallbackDelayed_J == null)
				cb_postFrameCallbackDelayed_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_PostFrameCallbackDelayed_J);
			return cb_postFrameCallbackDelayed_J;
		}

		static void n_PostFrameCallbackDelayed_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Androidgamesdk.ChoreographerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.ChoreographerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostFrameCallbackDelayed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/method[@name='postFrameCallbackDelayed' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("postFrameCallbackDelayed", "(J)V", "GetPostFrameCallbackDelayed_JHandler")]
		public virtual unsafe void PostFrameCallbackDelayed (long p0)
		{
			const string __id = "postFrameCallbackDelayed.(J)V";
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
			global::Com.Google.Androidgamesdk.ChoreographerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Androidgamesdk.ChoreographerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Terminate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.androidgamesdk']/class[@name='ChoreographerCallback']/method[@name='terminate' and count(parameter)=0]"
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
