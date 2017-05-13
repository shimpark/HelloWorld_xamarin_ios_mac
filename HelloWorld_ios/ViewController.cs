using System;

using UIKit;

namespace HelloWorld_ios
{
    public partial class ViewController : UIViewController
    {
        

        partial void BtnSubmit_TouchUpInside(UIButton sender)
        {
            var name = txtName.Text;
            var phone = txtPhone.Text;

            var msg = string.Format("name : {0} , phone : {1}", name, phone);
			//Create Alert
            var okAlertController = UIAlertController.Create("정보", msg, UIAlertControllerStyle.Alert);

			//Add Action
			okAlertController.AddAction(UIAlertAction.Create("닫기", UIAlertActionStyle.Default, null));

			// present alert
			PresentViewController(okAlertController, true, null);
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
