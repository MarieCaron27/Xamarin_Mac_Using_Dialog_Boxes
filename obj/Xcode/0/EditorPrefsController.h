// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface EditorPrefsController : NSViewController {
	NSColorWell *_BackgroundColorColorWell;
	NSTextField *_BackgroundColorTxtField;
	NSTextField *_BehaviorTxtFiled;
	NSTextField *_EditorBackgroundColorTxtField;
	NSTextField *_InterfaceTxtField;
}

@property (nonatomic, retain) IBOutlet NSColorWell *BackgroundColorColorWell;

@property (nonatomic, retain) IBOutlet NSTextField *BackgroundColorTxtField;

@property (nonatomic, retain) IBOutlet NSTextField *BehaviorTxtFiled;

@property (nonatomic, retain) IBOutlet NSTextField *EditorBackgroundColorTxtField;

@property (nonatomic, retain) IBOutlet NSTextField *InterfaceTxtField;

- (IBAction)AllowGraphicsBtn:(id)sender;

- (IBAction)AutoCloseBtn:(id)sender;

- (IBAction)CanChangeBackgroundColorBtn:(id)sender;

- (IBAction)CanEditImageBtn:(id)sender;

- (IBAction)NonContiniousLayoutBtn:(id)sender;

- (IBAction)RomanCharactersOnlyBtn:(id)sender;

- (IBAction)SelectWrapAfterBtn:(id)sender;

- (IBAction)UseFrontPanelBtn:(id)sender;

- (IBAction)UseInspectorBarBtn:(id)sender;

- (IBAction)UseRichTextBtn:(id)sender;

- (IBAction)UseRulerBtn:(id)sender;

- (IBAction)WrapSelectionBtn:(id)sender;

@end
