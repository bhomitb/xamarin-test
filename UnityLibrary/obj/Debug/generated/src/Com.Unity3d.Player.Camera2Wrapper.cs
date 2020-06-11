using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']"
	[global::Android.Runtime.Register ("com/unity3d/player/Camera2Wrapper", DoNotGenerateAcw=true)]
	public partial class Camera2Wrapper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/Camera2Wrapper", typeof (Camera2Wrapper));
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

		protected Camera2Wrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/constructor[@name='Camera2Wrapper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Camera2Wrapper (global::Android.Content.Context p0)
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

		static Delegate cb_getCamera2Count;
#pragma warning disable 0169
		static Delegate GetGetCamera2CountHandler ()
		{
			if (cb_getCamera2Count == null)
				cb_getCamera2Count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCamera2Count);
			return cb_getCamera2Count;
		}

		static int n_GetCamera2Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Camera2Count;
		}
#pragma warning restore 0169

		protected virtual unsafe int Camera2Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='getCamera2Count' and count(parameter)=0]"
			[Register ("getCamera2Count", "()I", "GetGetCamera2CountHandler")]
			get {
				const string __id = "getCamera2Count.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFrameSizeCamera2;
#pragma warning disable 0169
		static Delegate GetGetFrameSizeCamera2Handler ()
		{
			if (cb_getFrameSizeCamera2 == null)
				cb_getFrameSizeCamera2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameSizeCamera2);
			return cb_getFrameSizeCamera2;
		}

		static IntPtr n_GetFrameSizeCamera2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FrameSizeCamera2);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Graphics.Rect FrameSizeCamera2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='getFrameSizeCamera2' and count(parameter)=0]"
			[Register ("getFrameSizeCamera2", "()Landroid/graphics/Rect;", "GetGetFrameSizeCamera2Handler")]
			get {
				const string __id = "getFrameSizeCamera2.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("a", "(Ljava/lang/Object;)V", "")]
		public unsafe void A (global::Java.Lang.Object p0)
		{
			const string __id = "a.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='a' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;III)V", "")]
		public unsafe void A (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2, int p3, int p4, int p5)
		{
			const string __id = "a.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_closeCamera2;
#pragma warning disable 0169
		static Delegate GetCloseCamera2Handler ()
		{
			if (cb_closeCamera2 == null)
				cb_closeCamera2 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseCamera2);
			return cb_closeCamera2;
		}

		static void n_CloseCamera2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseCamera2 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='closeCamera2' and count(parameter)=0]"
		[Register ("closeCamera2", "()V", "GetCloseCamera2Handler")]
		protected virtual unsafe void CloseCamera2 ()
		{
			const string __id = "closeCamera2.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCamera2Resolutions_I;
#pragma warning disable 0169
		static Delegate GetGetCamera2Resolutions_IHandler ()
		{
			if (cb_getCamera2Resolutions_I == null)
				cb_getCamera2Resolutions_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetCamera2Resolutions_I);
			return cb_getCamera2Resolutions_I;
		}

		static IntPtr n_GetCamera2Resolutions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCamera2Resolutions (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='getCamera2Resolutions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCamera2Resolutions", "(I)[I", "GetGetCamera2Resolutions_IHandler")]
		protected virtual unsafe int[] GetCamera2Resolutions (int p0)
		{
			const string __id = "getCamera2Resolutions.(I)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getCamera2SensorOrientation_I;
#pragma warning disable 0169
		static Delegate GetGetCamera2SensorOrientation_IHandler ()
		{
			if (cb_getCamera2SensorOrientation_I == null)
				cb_getCamera2SensorOrientation_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetCamera2SensorOrientation_I);
			return cb_getCamera2SensorOrientation_I;
		}

		static int n_GetCamera2SensorOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCamera2SensorOrientation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='getCamera2SensorOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCamera2SensorOrientation", "(I)I", "GetGetCamera2SensorOrientation_IHandler")]
		protected virtual unsafe int GetCamera2SensorOrientation (int p0)
		{
			const string __id = "getCamera2SensorOrientation.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getCameraFocusArea_FF;
#pragma warning disable 0169
		static Delegate GetGetCameraFocusArea_FFHandler ()
		{
			if (cb_getCameraFocusArea_FF == null)
				cb_getCameraFocusArea_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetCameraFocusArea_FF);
			return cb_getCameraFocusArea_FF;
		}

		static IntPtr n_GetCameraFocusArea_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraFocusArea (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='getCameraFocusArea' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getCameraFocusArea", "(FF)Ljava/lang/Object;", "GetGetCameraFocusArea_FFHandler")]
		protected virtual unsafe global::Java.Lang.Object GetCameraFocusArea (float p0, float p1)
		{
			const string __id = "getCameraFocusArea.(FF)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initializeCamera2_IIIII;
#pragma warning disable 0169
		static Delegate GetInitializeCamera2_IIIIIHandler ()
		{
			if (cb_initializeCamera2_IIIII == null)
				cb_initializeCamera2_IIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, bool>) n_InitializeCamera2_IIIII);
			return cb_initializeCamera2_IIIII;
		}

		static bool n_InitializeCamera2_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitializeCamera2 (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='initializeCamera2' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("initializeCamera2", "(IIIII)Z", "GetInitializeCamera2_IIIIIHandler")]
		protected virtual unsafe bool InitializeCamera2 (int p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "initializeCamera2.(IIIII)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isCamera2AutoFocusPointSupported_I;
#pragma warning disable 0169
		static Delegate GetIsCamera2AutoFocusPointSupported_IHandler ()
		{
			if (cb_isCamera2AutoFocusPointSupported_I == null)
				cb_isCamera2AutoFocusPointSupported_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsCamera2AutoFocusPointSupported_I);
			return cb_isCamera2AutoFocusPointSupported_I;
		}

		static bool n_IsCamera2AutoFocusPointSupported_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCamera2AutoFocusPointSupported (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='isCamera2AutoFocusPointSupported' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isCamera2AutoFocusPointSupported", "(I)Z", "GetIsCamera2AutoFocusPointSupported_IHandler")]
		protected virtual unsafe bool IsCamera2AutoFocusPointSupported (int p0)
		{
			const string __id = "isCamera2AutoFocusPointSupported.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isCamera2FrontFacing_I;
#pragma warning disable 0169
		static Delegate GetIsCamera2FrontFacing_IHandler ()
		{
			if (cb_isCamera2FrontFacing_I == null)
				cb_isCamera2FrontFacing_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsCamera2FrontFacing_I);
			return cb_isCamera2FrontFacing_I;
		}

		static bool n_IsCamera2FrontFacing_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCamera2FrontFacing (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='isCamera2FrontFacing' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isCamera2FrontFacing", "(I)Z", "GetIsCamera2FrontFacing_IHandler")]
		protected virtual unsafe bool IsCamera2FrontFacing (int p0)
		{
			const string __id = "isCamera2FrontFacing.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pauseCamera2;
#pragma warning disable 0169
		static Delegate GetPauseCamera2Handler ()
		{
			if (cb_pauseCamera2 == null)
				cb_pauseCamera2 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseCamera2);
			return cb_pauseCamera2;
		}

		static void n_PauseCamera2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseCamera2 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='pauseCamera2' and count(parameter)=0]"
		[Register ("pauseCamera2", "()V", "GetPauseCamera2Handler")]
		protected virtual unsafe void PauseCamera2 ()
		{
			const string __id = "pauseCamera2.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAutoFocusPoint_FF;
#pragma warning disable 0169
		static Delegate GetSetAutoFocusPoint_FFHandler ()
		{
			if (cb_setAutoFocusPoint_FF == null)
				cb_setAutoFocusPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_SetAutoFocusPoint_FF);
			return cb_setAutoFocusPoint_FF;
		}

		static bool n_SetAutoFocusPoint_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetAutoFocusPoint (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='setAutoFocusPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAutoFocusPoint", "(FF)Z", "GetSetAutoFocusPoint_FFHandler")]
		protected virtual unsafe bool SetAutoFocusPoint (float p0, float p1)
		{
			const string __id = "setAutoFocusPoint.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_startCamera2;
#pragma warning disable 0169
		static Delegate GetStartCamera2Handler ()
		{
			if (cb_startCamera2 == null)
				cb_startCamera2 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartCamera2);
			return cb_startCamera2;
		}

		static void n_StartCamera2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCamera2 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='startCamera2' and count(parameter)=0]"
		[Register ("startCamera2", "()V", "GetStartCamera2Handler")]
		protected virtual unsafe void StartCamera2 ()
		{
			const string __id = "startCamera2.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopCamera2;
#pragma warning disable 0169
		static Delegate GetStopCamera2Handler ()
		{
			if (cb_stopCamera2 == null)
				cb_stopCamera2 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopCamera2);
			return cb_stopCamera2;
		}

		static void n_StopCamera2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.Camera2Wrapper __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.Camera2Wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopCamera2 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='Camera2Wrapper']/method[@name='stopCamera2' and count(parameter)=0]"
		[Register ("stopCamera2", "()V", "GetStopCamera2Handler")]
		protected virtual unsafe void StopCamera2 ()
		{
			const string __id = "stopCamera2.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
