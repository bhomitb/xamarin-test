using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='AudioVolumeHandler']"
	[global::Android.Runtime.Register ("com/unity3d/player/AudioVolumeHandler", DoNotGenerateAcw=true)]
	public partial class AudioVolumeHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/AudioVolumeHandler", typeof (AudioVolumeHandler));
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

		protected AudioVolumeHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='AudioVolumeHandler']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='AudioVolumeHandler']/method[@name='onAudioVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAudioVolumeChanged", "(I)V", "")]
		public unsafe void OnAudioVolumeChanged (int p0)
		{
			const string __id = "onAudioVolumeChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
