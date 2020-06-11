using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleVrApi']"
	[global::Android.Runtime.Register ("com/unity3d/player/GoogleVrApi", DoNotGenerateAcw=true)]
	public partial class GoogleVrApi : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/GoogleVrApi", typeof (GoogleVrApi));
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

		protected GoogleVrApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Unity3d.Player.IGoogleVrVideo GoogleVrVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.unity3d.player']/class[@name='GoogleVrApi']/method[@name='getGoogleVrVideo' and count(parameter)=0]"
			[Register ("getGoogleVrVideo", "()Lcom/unity3d/player/GoogleVrVideo;", "")]
			get {
				const string __id = "getGoogleVrVideo.()Lcom/unity3d/player/GoogleVrVideo;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Unity3d.Player.IGoogleVrVideo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
