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
using Mono.UIAutomation.Winforms;
using Mono.UIAutomation.Winforms.Behaviors.Generic;
using Mono.UIAutomation.Winforms.Events;
using Mono.UIAutomation.Winforms.Events.DataGrid;

namespace Mono.UIAutomation.Winforms.Behaviors.DataGrid
{
	internal class DataItemEditSelectionItemProviderBehavior
		: SelectionItemProviderBehavior<DataGridProvider.DataGridDataItemEditProvider>
	{
		
		#region Constructors

		public DataItemEditSelectionItemProviderBehavior (DataGridProvider.DataGridDataItemEditProvider provider)
			: base (provider)
		{
		}
		
		#endregion

		#region ProviderBehavior Specialization

		public override void Connect ()
		{
			// NOTE: SelectionItem.SelectionContainer never changes.
			// SWF.DataGrid doesn't support selecting/unselecting cell-by-cell
			// so: ElementSelectedEvent, ElementAddedEvent and ElementRemovedEvent
			// are meaningless, because selecting the cell 0,1 will select all row 0			
			Provider.SetEvent (ProviderEventType.SelectionItemPatternIsSelectedProperty, 
			                   new DataItemEditSelectionItemPatternIsSelectedEvent (ItemProvider));
		}

		#endregion
		
	}
}
