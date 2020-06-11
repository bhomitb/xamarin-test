using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.unity3d.player']/class[@name='NativeLoader']"
	[global::Android.Runtime.Register ("com/unity3d/player/NativeLoader", DoNotGenerateAcw=true)]
	public partial class NativeLoader : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/unity3d/player/NativeLoader", typeof (NativeLoader));
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

		protected NativeLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
