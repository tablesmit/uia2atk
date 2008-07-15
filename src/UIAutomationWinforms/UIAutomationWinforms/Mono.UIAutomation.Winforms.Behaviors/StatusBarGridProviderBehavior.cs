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
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com) 
// 
// Authors: 
// 	Neville Gao <nevillegao@gmail.com>
// 

using System;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Forms;
using Mono.UIAutomation.Winforms;
using Mono.UIAutomation.Winforms.Events;

namespace Mono.UIAutomation.Winforms.Behaviors
{
	internal class StatusBarGridProviderBehavior 
		: ProviderBehavior, IGridProvider
	{
		
#region Constructors

		public StatusBarGridProviderBehavior (StatusBarProvider provider)
			: base (provider)
		{
			statusBarProvider = provider;
		}
		
#endregion

#region IProviderBehavior Interface		
		
		public override AutomationPattern ProviderPattern { 
			get { return GridPatternIdentifiers.Pattern; }
		}

		public override void Connect (Control control)
		{
			Provider.SetEvent (ProviderEventType.GridPatternRowCountProperty,
					new GridPatternRowCountPropertyEvent (Provider));
			Provider.SetEvent (ProviderEventType.GridPatternColumnCountProperty,
					new GridPatternColumnCountPropertyEvent (Provider));
		}
		
		public override void Disconnect (Control control)
		{
			Provider.SetEvent (ProviderEventType.GridPatternRowCountProperty,
			                null);
			Provider.SetEvent (ProviderEventType.GridPatternColumnCountProperty,
			                null);
		}

        	public override object GetPropertyValue (int propertyId)
        	{
			if (propertyId == AutomationElementIdentifiers.ControlTypeProperty.Id)
				return ControlType.StatusBar.Id;
			else if (propertyId == AutomationElementIdentifiers.LocalizedControlTypeProperty.Id)
				return "status bar";
			else if (propertyId == GridPatternIdentifiers.RowCountProperty.Id)
				return RowCount;
			else if (propertyId == GridPatternIdentifiers.ColumnCountProperty.Id)
				return ColumnCount;
			else
				return base.GetPropertyValue (propertyId);
        	}

#endregion
		
#region IGridProvider Members

        	public int RowCount {
			// TODO: Return value.
            		get { return 1; }
        	}

        	public int ColumnCount {
			// TODO: Return value.
			get { return 1; }
        	}
		
		public IRawElementProviderSimple GetItem (int row, int column)
                {
			// TODO: Return value.
                        if (column > RowCount || row > ColumnCount)
                                throw new ArgumentOutOfRangeException ();
                        if (row < 0 || column < 0)
                                throw new ArgumentOutOfRangeException ();
                        return null;
                }

#endregion

#region Private Fields

		private StatusBarProvider statusBarProvider;
		
#endregion
	}
}
