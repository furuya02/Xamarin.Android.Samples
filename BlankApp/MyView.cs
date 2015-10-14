using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BlankApp {
    class MyView:View {
        public MyView(Context context) : base(context) {

        }
        public override void Draw(Canvas canvas) {
            base.Draw(canvas);
            var paint = new Paint {
                Color = Color.White,
                TextSize = 40,
                AntiAlias = true
            };
            canvas.DrawText("Developers.IO", 100, 60, paint);
        }
    }
}