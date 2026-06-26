namespace boites_de_dialogues;

[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    public AppPreferences Preferences { get; set; }

    public override void DidFinishLaunching(NSNotification notification)
    {
        Preferences = new AppPreferences();
    }
    
    public override void WillTerminate(NSNotification notification)
    {
        // Insert code here to tear down your application
    }
}