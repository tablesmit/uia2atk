##############################################################################
# Written by:  Mario Carrion <mcarrion@novell.com>
# Date:        02/23/2009
# Description: datagridviewframe.py wrapper script
#              Used by the datagridview-*.py tests
##############################################################################$

import sys
import os
import actions
import states

from strongwind import *
from datagridview import *

# class to represent the main window.
class DataGridViewFrame(accessibles.Frame):

	# constants
	# the available widgets on the frame
	COLUMN_CHECKBOX = "COLUMN_CHECKBOX"
	COLUMN_TEXTBOX = "COLUMN_TEXTBOX"

	def __init__(self, accessible):
		super(DataGridViewFrame, self).__init__(accessible)
		self.treetable = self.findTreeTable(None)
		self.checkbox_column = self.findTableColumnHeader(self.COLUMN_CHECKBOX, checkShowing=False)
		self.textbox_column = self.findTableColumnHeader(self.COLUMN_TEXTBOX, checkShowing=False)
		
		self.columns = [self.checkbox_column, self.textbox_column]
		
		self.tablecells = self.findAllTableCells(None)

		self.edits = self.findAllTableCells(re.compile("Item*"))
		self.checkboxes = self.findAllCheckBoxes(None)

	#assert Edits' Text implementation for ListView Items
	def assertEditsText(self, accessible):
		procedurelogger.action("check DataGridView Items Text Value")
		
		index = 0
		for item in accessible:
			actual_states = item._accessible.getState().getStates()
			actual_states = [pyatspi.stateToString(s) for s in actual_states]

			new_value = 'Item%s' % (index + 10)
			old_value = item.text
			
			item.text = new_value
			sleep(config.SHORT_DELAY) # We need this because sometimes the assert fails

			if "editable" in actual_states:
				procedurelogger.expectedResult('editable: current %s new %s' % (item.text,new_value))
				assert item.text == new_value
			else:
				procedurelogger.expectedResult('not-editable: current %s new %s' % (item.text,old_value))
				assert item.text == old_value
				
			index += 1

	#assert Selection implementation
	def assertSelectionChild(self, accessible, childIndex):
		procedurelogger.action('selected childIndex %s in "%s"' % (childIndex, accessible))
		accessible.selectChild(childIndex)

	def assertClearSelection(self, accessible):
		procedurelogger.action('clear selection in "%s"' % (accessible))
		accessible.clearSelection()

	def assertTable(self, accessible, row=0, col=0):
		procedurelogger.action('check "%s" Table implemetation' % accessible)
		itable = accessible._accessible.queryTable()

		procedurelogger.expectedResult('"%s" have %s Rows and %s Columns' % (accessible, row, col))
		assert itable.nRows == row and itable.nColumns == col, "Not match Rows %s and Columns %s" % (itable.nRows, itable.nColumns)
 
	#close application main window after running test
	def quit(self):
		self.altF4()

