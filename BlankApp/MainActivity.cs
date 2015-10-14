using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BlankApp {
    [Activity(Label = "BlankApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            
            //タイトルを非表示にする
            RequestWindowFeature(WindowFeatures.NoTitle);

            //作成したMyViewをビューとしてセットする
            SetContentView(new MyView(this));

            //テンプレートで生成されたコードをコメントアウトする
            //SetContentView(Resource.Layout.Main);
            //Button button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

