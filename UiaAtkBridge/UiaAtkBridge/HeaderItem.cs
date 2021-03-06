// Permission is hereby granted, free of charge, to any person obtaining 
// a copy of this software and associated documentation files (the 
// "Software"), to deal in the Software without restriction, including 
// without limitation the rights to use, copy, modify, merge, publish, 
// distribute, sublicense, and/or sell copies of the Software, and to 
// permit persons to whom the Software is furnished to do so, subject to 
// the following conditions: 
//  
// The above copyright notice and this permission notice shall be 
// included in all copies or substantial portions of the Software. 
//  
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE 
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION 
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
// 
// Copyright (c) 2009 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
//	Mario Carrion <mcarrion@novell.com>
// 
using System;
using System.Windows.Automation;
using Mono.UIAutomation.Services;
using System.Windows.Automation.Provider;

namespace UiaAtkBridge
{

	public class HeaderItem : TextLabel, Atk.IActionImplementor, Atk.IImageImplementor
	{

		#region Constructor
		
		public HeaderItem (IRawElementProviderSimple provider) : base (provider)
		{
			Role = Atk.Role.TableColumnHeader;

			invokeProvider = (IInvokeProvider) provider.GetPatternProvider (InvokePatternIdentifiers.Pattern.Id);		
			imageExpert = new ImageImplementorHelper (this); 

			actionExpert = new ActionImplementorHelper ();
			if (invokeProvider != null)
				actionExpert.Add ("click", "click", null, DoClick);
		}

		#endregion
		
		#region ActionImplementor implementation 
		
		public bool DoAction (int i)
		{
			return actionExpert.DoAction (i);
		}
		
		public string GetDescription (int i)
		{
			return actionExpert.GetDescription (i);
		}
		
		public string GetName (int i)
		{
			return actionExpert.GetName (i);
		}
		
		public string GetKeybinding (int i)
		{
			return null;
		}
		
		public bool SetDescription (int i, string desc)
		{
			return actionExpert.SetDescription (i, desc);
		}
		
		public string GetLocalizedName (int i)
		{
			return actionExpert.GetLocalizedName (i);
		}
		
		public int NActions {
			get { return actionExpert.NActions; }
		}

		#endregion

		#region ImageImplementor implementation 
		
		public void GetImagePosition (out int x, out int y, Atk.CoordType coordType)
		{
			imageExpert.GetImagePosition (out x, out y, coordType);
		}
		
		public void GetImageSize (out int width, out int height)
		{
			imageExpert.GetImageSize (out width, out height);
		}
		
		public bool SetImageDescription (string description)
		{
			return imageExpert.SetImageDescription (description);
		}
		
		public string ImageDescription {
			get { return imageExpert.ImageDescription; }
		}
		
		public string ImageLocale {
			get { return imageExpert.ImageLocale; }
		}
		
		#endregion

		public override void RaiseAutomationEvent (AutomationEvent eventId, AutomationEventArgs args)
		{
			if (eventId == InvokePatternIdentifiers.InvokedEvent) {
				DataGrid datagrid = Parent as DataGrid;
				if (datagrid != null)
					datagrid.EmitRowReorderingSignal ();
			} else 
				base.RaiseAutomationEvent (eventId, args);
		}

		#region Private Methods

		private bool DoClick ()
		{
			NotifyStateChange (Atk.StateType.Armed, true);
			try {
				invokeProvider.Invoke ();
			} catch (ElementNotEnabledException e) {
				Log.Debug (e);
				return false;
			}
			NotifyStateChange (Atk.StateType.Armed, false);

			return true;
		}

		#endregion

		#region Private Fields

		private ImageImplementorHelper imageExpert;
		private ActionImplementorHelper actionExpert;
		private IInvokeProvider invokeProvider;

		#endregion
	}
}
