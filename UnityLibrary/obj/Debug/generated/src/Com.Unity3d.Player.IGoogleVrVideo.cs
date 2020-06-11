using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo.GoogleVrVideoCallbacks']"
	[Register ("com/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks", "", "Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacksInvoker")]
	public partial interface IGoogleVrVideoGoogleVrVideoCallbacks : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo.GoogleVrVideoCallbacks']/method[@name='onFrameAvailable' and count(parameter)=0]"
		[Register ("onFrameAvailable", "()V", "GetOnFrameAvailableHandler:Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacksInvoker, UnityLibrary")]
		void OnFrameAvailable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo.GoogleVrVideoCallbacks']/method[@name='onSurfaceAvailable' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("onSurfaceAvailable", "(Landroid/view/Surface;)V", "GetOnSurfaceAvailable_Landroid_view_Surface_Handler:Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacksInvoker, UnityLibrary")]
		void OnSurfaceAvailable (global::Android.Views.Surface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo.GoogleVrVideoCallbacks']/method[@name='onSurfaceUnavailable' and count(parameter)=0]"
		[Register ("onSurfaceUnavailable", "()V", "GetOnSurfaceUnavailableHandler:Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacksInvoker, UnityLibrary")]
		void OnSurfaceUnavailable ();

	}

	[global::Android.Runtime.Register ("com/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks", DoNotGenerateAcw=true)]
	internal partial class IGoogleVrVideoGoogleVrVideoCallbacksInvoker : global::Java.Lang.Object, IGoogleVrVideoGoogleVrVideoCallbacks {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks", typeof (IGoogleVrVideoGoogleVrVideoCallbacksInvoker));

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

		public static IGoogleVrVideoGoogleVrVideoCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGoogleVrVideoGoogleVrVideoCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.unity3d.player.GoogleVrVideo.GoogleVrVideoCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGoogleVrVideoGoogleVrVideoCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFrameAvailable;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailableHandler ()
		{
			if (cb_onFrameAvailable == null)
				cb_onFrameAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFrameAvailable);
			return cb_onFrameAvailable;
		}

		static void n_OnFrameAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable ();
		}
#pragma warning restore 0169

		IntPtr id_onFrameAvailable;
		public unsafe void OnFrameAvailable ()
		{
			if (id_onFrameAvailable == IntPtr.Zero)
				id_onFrameAvailable = JNIEnv.GetMethodID (class_ref, "onFrameAvailable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameAvailable);
		}

		static Delegate cb_onSurfaceAvailable_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceAvailable_Landroid_view_Surface_Handler ()
		{
			if (cb_onSurfaceAvailable_Landroid_view_Surface_ == null)
				cb_onSurfaceAvailable_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceAvailable_Landroid_view_Surface_);
			return cb_onSurfaceAvailable_Landroid_view_Surface_;
		}

		static void n_OnSurfaceAvailable_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSurfaceAvailable_Landroid_view_Surface_;
		public unsafe void OnSurfaceAvailable (global::Android.Views.Surface p0)
		{
			if (id_onSurfaceAvailable_Landroid_view_Surface_ == IntPtr.Zero)
				id_onSurfaceAvailable_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "onSurfaceAvailable", "(Landroid/view/Surface;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceAvailable_Landroid_view_Surface_, __args);
		}

		static Delegate cb_onSurfaceUnavailable;
#pragma warning disable 0169
		static Delegate GetOnSurfaceUnavailableHandler ()
		{
			if (cb_onSurfaceUnavailable == null)
				cb_onSurfaceUnavailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSurfaceUnavailable);
			return cb_onSurfaceUnavailable;
		}

		static void n_OnSurfaceUnavailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceUnavailable ();
		}
#pragma warning restore 0169

		IntPtr id_onSurfaceUnavailable;
		public unsafe void OnSurfaceUnavailable ()
		{
			if (id_onSurfaceUnavailable == IntPtr.Zero)
				id_onSurfaceUnavailable = JNIEnv.GetMethodID (class_ref, "onSurfaceUnavailable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceUnavailable);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo']"
	[Register ("com/unity3d/player/GoogleVrVideo", "", "Com.Unity3d.Player.IGoogleVrVideoInvoker")]
	public partial interface IGoogleVrVideo : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo']/method[@name='deregisterGoogleVrVideoListener' and count(parameter)=1 and parameter[1][@type='com.unity3d.player.GoogleVrVideo.GoogleVrVideoCallbacks']]"
		[Register ("deregisterGoogleVrVideoListener", "(Lcom/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks;)V", "GetDeregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_Handler:Com.Unity3d.Player.IGoogleVrVideoInvoker, UnityLibrary")]
		void DeregisterGoogleVrVideoListener (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo']/method[@name='registerGoogleVrVideoListener' and count(parameter)=1 and parameter[1][@type='com.unity3d.player.GoogleVrVideo.GoogleVrVideoCallbacks']]"
		[Register ("registerGoogleVrVideoListener", "(Lcom/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks;)V", "GetRegisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_Handler:Com.Unity3d.Player.IGoogleVrVideoInvoker, UnityLibrary")]
		void RegisterGoogleVrVideoListener (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/interface[@name='GoogleVrVideo']/method[@name='setVideoLocationTransform' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setVideoLocationTransform", "([F)V", "GetSetVideoLocationTransform_arrayFHandler:Com.Unity3d.Player.IGoogleVrVideoInvoker, UnityLibrary")]
		void SetVideoLocationTransform (float[] p0);

	}

	[global::Android.Runtime.Register ("com/unity3d/player/GoogleVrVideo", DoNotGenerateAcw=true)]
	internal partial class IGoogleVrVideoInvoker : global::Java.Lang.Object, IGoogleVrVideo {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/GoogleVrVideo", typeof (IGoogleVrVideoInvoker));

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

		public static IGoogleVrVideo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGoogleVrVideo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.unity3d.player.GoogleVrVideo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGoogleVrVideoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
#pragma warning disable 0169
		static Delegate GetDeregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_Handler ()
		{
			if (cb_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ == null)
				cb_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_);
			return cb_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
		}

		static void n_DeregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.IGoogleVrVideo __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0 = (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks)global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeregisterGoogleVrVideoListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
		public unsafe void DeregisterGoogleVrVideoListener (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0)
		{
			if (id_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ == IntPtr.Zero)
				id_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ = JNIEnv.GetMethodID (class_ref, "deregisterGoogleVrVideoListener", "(Lcom/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deregisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_, __args);
		}

		static Delegate cb_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
#pragma warning disable 0169
		static Delegate GetRegisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_Handler ()
		{
			if (cb_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ == null)
				cb_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_);
			return cb_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
		}

		static void n_RegisterGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.IGoogleVrVideo __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0 = (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks)global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterGoogleVrVideoListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_;
		public unsafe void RegisterGoogleVrVideoListener (global::Com.Unity3d.Player.IGoogleVrVideoGoogleVrVideoCallbacks p0)
		{
			if (id_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ == IntPtr.Zero)
				id_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_ = JNIEnv.GetMethodID (class_ref, "registerGoogleVrVideoListener", "(Lcom/unity3d/player/GoogleVrVideo$GoogleVrVideoCallbacks;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerGoogleVrVideoListener_Lcom_unity3d_player_GoogleVrVideo_GoogleVrVideoCallbacks_, __args);
		}

		static Delegate cb_setVideoLocationTransform_arrayF;
#pragma warning disable 0169
		static Delegate GetSetVideoLocationTransform_arrayFHandler ()
		{
			if (cb_setVideoLocationTransform_arrayF == null)
				cb_setVideoLocationTransform_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoLocationTransform_arrayF);
			return cb_setVideoLocationTransform_arrayF;
		}

		static void n_SetVideoLocationTransform_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Unity3d.Player.IGoogleVrVideo __this = global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetVideoLocationTransform (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideoLocationTransform_arrayF;
		public unsafe void SetVideoLocationTransform (float[] p0)
		{
			if (id_setVideoLocationTransform_arrayF == IntPtr.Zero)
				id_setVideoLocationTransform_arrayF = JNIEnv.GetMethodID (class_ref, "setVideoLocationTransform", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoLocationTransform_arrayF, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
