namespace boites_de_dialogues;

[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    #region Computed Properties
    public int NewWindowNumber { get; set;} = -1;

    public AppPreferences Preferences { get; set; } = new AppPreferences();
    #endregion
    
    #region Application Access
    public static AppDelegate App {
        get { return (AppDelegate)NSApplication.SharedApplication.Delegate; }
    }
    #endregion

    #region Constructors
    public AppDelegate ()
    {
    }
    #endregion

    public override void DidFinishLaunching(NSNotification notification)
    {
        Preferences = new AppPreferences();
    }
    
    public override void WillTerminate(NSNotification notification)
    {
        // Insert code here to tear down your application
    }
    
    public void UpdateWindowPreferences() 
    {

        // Process all open windows
        for(int n=0; n<NSApplication.SharedApplication.Windows.Length; ++n) {
            var content = NSApplication.SharedApplication.Windows[n].ContentViewController as ViewController;
            if (content != null ) {
                // Reformat all text
                content.ConfigureEditor ();
            }
        }

    }
}