// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace boites_de_dialogues
{
	[Register ("SheetViewController")]
	partial class SheetViewController
	{
		[Outlet]
		AppKit.NSTextField PasswordTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField UsernameTxtFiled { get; set; }

		[Action ("BtnCANCEL:")]
		partial void BtnCANCEL (Foundation.NSObject sender);

		[Action ("BtnOK:")]
		partial void BtnOK (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (UsernameTxtFiled != null) {
				UsernameTxtFiled.Dispose ();
				UsernameTxtFiled = null;
			}

			if (PasswordTxtField != null) {
				PasswordTxtField.Dispose ();
				PasswordTxtField = null;
			}

		}
	}
}
