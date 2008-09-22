#!/usr/bin/env python
# -*- coding: utf-8 -*-

##############################################################################
# Written by:  Brian G. Merrell <bgmerrell@novell.com>
# Date:        May 23 2008
# Description: Test accessibility of gtk checkbutton widget 
#              Use the gtkcheckbuttonframe.py wrapper script
#              Test the samples/gtkcheckbutton.py script
##############################################################################

# The docstring below  is used in the generated log file
"""
Test accessibility of checkbutton widget
"""

# imports
from strongwind import *
from gtkcheckbutton import *
from sys import argv
from os import path

app_path = None 
try:
  app_path = argv[1]
except IndexError:
  pass #expected

# open the checkbutton sample application
try:
  app = launchCheckButton(app_path)
except IOError, msg:
  print "ERROR:  %s" % msg
  exit(2)

# make sure we got the app back
if app is None:
  exit(4)

# just an alias to make things shorter
cbFrame = app.gtkCheckButtonFrame

#check checkbox1 states with the keyboard focus
cbFrame.statesCheck(cbFrame.checkbox1, "CheckBox", 
                    add_states=["focused"])

#check checkbox2 states
cbFrame.statesCheck(cbFrame.checkbox2, "CheckBox")

#click action to check box1 and add 3 states
cbFrame.checkbox1.click()
sleep(config.SHORT_DELAY)
cbFrame.assertChecked(cbFrame.checkbox1)
cbFrame.statesCheck(cbFrame.checkbox1, "CheckBox", 
                    add_states=["armed","focused","checked"])

#click action to uncheck box1 and delete 2 states but still focus
cbFrame.checkbox1.click()
sleep(config.SHORT_DELAY)
cbFrame.assertUnchecked(cbFrame.checkbox1)
cbFrame.statesCheck(cbFrame.checkbox1, "CheckBox", 
                    add_states=["focused"])

#mouseClick move focus and check to checkbox2,rise 'focused' 'checked' state
cbFrame.checkbox2.mouseClick()
sleep(config.SHORT_DELAY)
cbFrame.assertChecked(cbFrame.checkbox2)
cbFrame.statesCheck(cbFrame.checkbox2, "CheckBox", 
                    add_states=["focused","checked"])

#uncheck checkbox2, delete 'checked' state but still focus
cbFrame.checkbox2.mouseClick()
sleep(config.SHORT_DELAY)
cbFrame.assertUnchecked(cbFrame.checkbox2)
cbFrame.statesCheck(cbFrame.checkbox2, "CheckBox", 
                    add_states=["focused"])

#click action doesn't move focus
cbFrame.checkbox1.click()
sleep(config.SHORT_DELAY)
cbFrame.statesCheck(cbFrame.checkbox1, "CheckBox", 
                    add_states=["armed","checked"])

cbFrame.quit()

print "INFO:  Log written to: %s" % config.OUTPUT_DIR
