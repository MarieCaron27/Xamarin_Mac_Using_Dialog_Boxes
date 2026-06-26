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
	[Register ("EditorPrefsController")]
	partial class EditorPrefsController
	{
		[Outlet]
		AppKit.NSColorWell BackgroundColorColorWell { get; set; }

		[Outlet]
		AppKit.NSTextField BackgroundColorTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField BehaviorTxtFiled { get; set; }

		[Outlet]
		AppKit.NSTextField EditorBackgroundColorTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField InterfaceTxtField { get; set; }

		[Action ("AllowGraphicsBtn:")]
		partial void AllowGraphicsBtn (Foundation.NSObject sender);

		[Action ("AutoCloseBtn:")]
		partial void AutoCloseBtn (Foundation.NSObject sender);

		[Action ("CanChangeBackgroundColorBtn:")]
		partial void CanChangeBackgroundColorBtn (Foundation.NSObject sender);

		[Action ("CanEditImageBtn:")]
		partial void CanEditImageBtn (Foundation.NSObject sender);

		[Action ("NonContiniousLayoutBtn:")]
		partial void NonContiniousLayoutBtn (Foundation.NSObject sender);

		[Action ("RomanCharactersOnlyBtn:")]
		partial void RomanCharactersOnlyBtn (Foundation.NSObject sender);

		[Action ("SelectWrapAfterBtn:")]
		partial void SelectWrapAfterBtn (Foundation.NSObject sender);

		[Action ("UseFrontPanelBtn:")]
		partial void UseFrontPanelBtn (Foundation.NSObject sender);

		[Action ("UseInspectorBarBtn:")]
		partial void UseInspectorBarBtn (Foundation.NSObject sender);

		[Action ("UseRichTextBtn:")]
		partial void UseRichTextBtn (Foundation.NSObject sender);

		[Action ("UseRulerBtn:")]
		partial void UseRulerBtn (Foundation.NSObject sender);

		[Action ("WrapSelectionBtn:")]
		partial void WrapSelectionBtn (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (BehaviorTxtFiled != null) {
				BehaviorTxtFiled.Dispose ();
				BehaviorTxtFiled = null;
			}

			if (EditorBackgroundColorTxtField != null) {
				EditorBackgroundColorTxtField.Dispose ();
				EditorBackgroundColorTxtField = null;
			}

			if (BackgroundColorTxtField != null) {
				BackgroundColorTxtField.Dispose ();
				BackgroundColorTxtField = null;
			}

			if (BackgroundColorColorWell != null) {
				BackgroundColorColorWell.Dispose ();
				BackgroundColorColorWell = null;
			}

			if (InterfaceTxtField != null) {
				InterfaceTxtField.Dispose ();
				InterfaceTxtField = null;
			}

		}
	}
}
