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
using System.ComponentModel;
using System.Windows.Automation;
using SWF = System.Windows.Forms;
using Mono.UIAutomation.Winforms;
using Mono.UIAutomation.Winforms.Events;

namespace Mono.UIAutomation.Winforms.Events.DataGridView
{
	
	internal class DataItemComboBoxSelectionPatternSelectionEvent
		: BaseAutomationPropertyEvent
	{
		
		#region Constructors

		public DataItemComboBoxSelectionPatternSelectionEvent (DataGridViewProvider.DataGridViewDataItemComboBoxProvider provider)
			: base (provider, 
			        SelectionPatternIdentifiers.SelectionProperty)
		{
			this.provider = provider;
		}
		
		#endregion
		
		#region ProviderEvent Methods

		public override void Connect ()
		{
			provider.ComboBoxCell.DataGridView.CellValueChanged += OnCellValueChanged;
		}

		public override void Disconnect ()
		{
			provider.ComboBoxCell.DataGridView.CellValueChanged -= OnCellValueChanged;
		}
		
		#endregion 

		
		#region Private Methods

		private void OnCellValueChanged (object sender, SWF.DataGridViewCellEventArgs args)
		{
			if (args.ColumnIndex == provider.ComboBoxCell.ColumnIndex
			    && args.RowIndex == provider.ComboBoxCell.RowIndex)
				RaiseAutomationPropertyChangedEvent ();
		}
		
		#endregion

		#region Private Fields

		private DataGridViewProvider.DataGridViewDataItemComboBoxProvider provider;

		#endregion
	}
}
