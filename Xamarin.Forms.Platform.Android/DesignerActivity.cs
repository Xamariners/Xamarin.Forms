using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Xamarin.Forms.Platform.Android
{
	public class DesignerActivity : AppCompatActivity
	{
		public DesignerActivity()
		{
		}

		protected DesignerActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
			
		}
	}
}