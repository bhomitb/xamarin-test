using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='HFPStatus']"
	[global::Android.Runtime.Register ("com/unity3d/player/HFPStatus", DoNotGenerateAcw=true)]
	public partial class HFPStatus : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/HFPStatus", typeof (HFPStatus));
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

		protected HFPStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='HFPStatus']/constructor[@name='HFPStatus' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HFPStatus (global::Android.Content.Context p0)
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

		static Delegate cb_getHFPStat;
#pragma warning disable 0169
		static Delegate GetGetHFPStatHandler ()
		{
			if (cb_getHFPStat == null)
				cb_getHFPStat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHFPStat);
			return cb_getHFPStat;
		}

		static bool n_GetHFPStat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.HFPStatus __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.HFPStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HFPStat;
		}
#pragma warning restore 0169

		protected virtual unsafe bool HFPStat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='HFPStatus']/method[@name='getHFPStat' and count(parameter)=0]"
			[Register ("getHFPStat", "()Z", "GetGetHFPStatHandler")]
			get {
				const string __id = "getHFPStat.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='HFPStatus']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_requestHFPStat;
#pragma warning disable 0169
		static Delegate GetRequestHFPStatHandler ()
		{
			if (cb_requestHFPStat == null)
				cb_requestHFPStat = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestHFPStat);
			return cb_requestHFPStat;
		}

		static void n_RequestHFPStat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.HFPStatus __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.HFPStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestHFPStat ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='HFPStatus']/method[@name='requestHFPStat' and count(parameter)=0]"
		[Register ("requestHFPStat", "()V", "GetRequestHFPStatHandler")]
		protected virtual unsafe void RequestHFPStat ()
		{
			const string __id = "requestHFPStat.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
