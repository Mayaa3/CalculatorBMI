// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CalculatorBMI
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightTextfield { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightTextField { get; set; }

        [Action ("UIButton390_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton390_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (bmiLabel != null) {
                bmiLabel.Dispose ();
                bmiLabel = null;
            }

            if (calculateButton != null) {
                calculateButton.Dispose ();
                calculateButton = null;
            }

            if (heightTextfield != null) {
                heightTextfield.Dispose ();
                heightTextfield = null;
            }

            if (weightTextField != null) {
                weightTextField.Dispose ();
                weightTextField = null;
            }
        }
    }
}