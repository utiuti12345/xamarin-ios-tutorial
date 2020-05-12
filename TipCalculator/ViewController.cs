using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {
        public ViewController()
        {
        }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Yellow;
        }

        partial void CalcButton_TouchUpInside(UIButton sender)
        {
            totalAmount.ResignFirstResponder();
            calcButton.SetTitle("押されたよ", UIControlState.Highlighted);
            calcButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            calcButton.BackgroundColor = UIColor.Red;
            //calcButton.Layer.CornerRadius = 10;
            double value = 0;
            if (Double.TryParse(totalAmount.Text, out value))
            {
                tipsResult.Text = String.Format("合計は{0}", GetTip(value, 20));
            }
            else
            {
                tipsResult.Text = "エラー";
            }
        }

        public double GetTip(double amount,double percentage)
        {
            return amount * percentage / 100.0;
        }
    }
}