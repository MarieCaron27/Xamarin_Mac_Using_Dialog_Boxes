// WARNING
// This file has been generated automatically by Rider IDE to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface SheetViewController : NSViewController {
	NSTextField *_PasswordTxtField;
	NSTextField *_UsernameTxtFiled;
}

@property (nonatomic, retain) IBOutlet NSTextField *PasswordTxtField;

@property (nonatomic, retain) IBOutlet NSTextField *UsernameTxtFiled;

- (IBAction)BtnCANCEL:(id)sender;

- (IBAction)BtnOK:(id)sender;

@end
