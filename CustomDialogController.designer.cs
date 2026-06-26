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
	[Register ("CustomDialogController")]
	partial class CustomDialogController
	{
		[Outlet]
		AppKit.NSTextField DescriptionTextFiled { get; set; }

		[Outlet]
		AppKit.NSImageView MyImage { get; set; }

		[Outlet]
		AppKit.NSTextField TitleTxtField { get; set; }

		[Action ("BtnCANCEL:")]
		partial void BtnCANCEL (Foundation.NSObject sender);

		[Action ("BtnOK:")]
		partial void BtnOK (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (DescriptionTextFiled != null) {
				DescriptionTextFiled.Dispose ();
				DescriptionTextFiled = null;
			}

			if (MyImage != null) {
				MyImage.Dispose ();
				MyImage = null;
			}

			if (TitleTxtField != null) {
				TitleTxtField.Dispose ();
				TitleTxtField = null;
			}

		}
	}
}
