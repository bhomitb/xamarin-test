using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleARCoreApi']"
	[global::Android.Runtime.Register ("com/unity3d/player/GoogleARCoreApi", DoNotGenerateAcw=true)]
	public partial class GoogleARCoreApi : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/GoogleARCoreApi", typeof (GoogleARCoreApi));
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

		protected GoogleARCoreApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleARCoreApi']/constructor[@name='GoogleARCoreApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GoogleARCoreApi ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleARCoreApi']/method[@name='initializeARCore' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("initializeARCore", "(Landroid/app/Activity;)V", "")]
		public unsafe void InitializeARCore (global::Android.App.Activity p0)
		{
			const string __id = "initializeARCore.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleARCoreApi']/method[@name='pauseARCore' and count(parameter)=0]"
		[Register ("pauseARCore", "()V", "")]
		public unsafe void PauseARCore ()
		{
			const string __id = "pauseARCore.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleARCoreApi']/method[@name='resumeARCore' and count(parameter)=0]"
		[Register ("resumeARCore", "()V", "")]
		public unsafe void ResumeARCore ()
		{
			const string __id = "resumeARCore.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
