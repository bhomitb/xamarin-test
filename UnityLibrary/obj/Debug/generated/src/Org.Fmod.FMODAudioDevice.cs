using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Fmod {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']"
	[global::Android.Runtime.Register ("org/fmod/FMODAudioDevice", DoNotGenerateAcw=true)]
	public partial class FMODAudioDevice : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/fmod/FMODAudioDevice", typeof (FMODAudioDevice));
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

		protected FMODAudioDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/constructor[@name='FMODAudioDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FMODAudioDevice ()
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

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startAudioRecord_III;
#pragma warning disable 0169
		static Delegate GetStartAudioRecord_IIIHandler ()
		{
			if (cb_startAudioRecord_III == null)
				cb_startAudioRecord_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int>) n_StartAudioRecord_III);
			return cb_startAudioRecord_III;
		}

		static int n_StartAudioRecord_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAudioRecord (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='startAudioRecord' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startAudioRecord", "(III)I", "GetStartAudioRecord_IIIHandler")]
		public virtual unsafe int StartAudioRecord (int p0, int p1, int p2)
		{
			const string __id = "startAudioRecord.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopAudioRecord;
#pragma warning disable 0169
		static Delegate GetStopAudioRecordHandler ()
		{
			if (cb_stopAudioRecord == null)
				cb_stopAudioRecord = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAudioRecord);
			return cb_stopAudioRecord;
		}

		static void n_StopAudioRecord (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Fmod.FMODAudioDevice __this = global::Java.Lang.Object.GetObject<global::Org.Fmod.FMODAudioDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAudioRecord ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.fmod']/class[@name='FMODAudioDevice']/method[@name='stopAudioRecord' and count(parameter)=0]"
		[Register ("stopAudioRecord", "()V", "GetStopAudioRecordHandler")]
		public virtual unsafe void StopAudioRecord ()
		{
			const string __id = "stopAudioRecord.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
