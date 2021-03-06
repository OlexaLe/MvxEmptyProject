using System;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;

namespace EmptyProject.Touch
{
	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
			: base (appDelegate, presenter)
		{
		}

		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp ()
		{
			return new EmptyProject.Core.App ();
		}
	}
}

