#!/usr/bin/env python

##############################################################################
# Written by:  Brian G. Merrell <bgmerrell@novell.com>
# Date:        01/26/2009
# Description: Test accessibility of splitter widget 
#              Use the splitterframe.py wrapper script
#              Test the samples/splitter.py script
##############################################################################

# The docstring below  is used in the generated log file
"""
Test accessibility of splitter widget
"""

# LOTS of splitter bugs, going to need to get some fixed before I can figure
# out how to test this well.  Here's the list of bugs:
# BUG471757
# BUG471749
# BUG471215
# BUG471067
# BUG470831
# BUG469569

# imports
import sys
import os

import states
from strongwind import *
from splitter_horizontal import *
from helpers import *
from sys import argv
from os import path

app_path = None 
try:
  app_path = argv[1]
except IndexError:
  pass #expected

# open the splitter sample application
try:
  app = launchSplitter(app_path)
except IOError, msg:
  print "ERROR:  %s" % msg
  exit(2)

sleep(config.SHORT_DELAY)

# make sure we got the app back
if app is None:
  exit(4)

# just an alias to make things shorter
sFrame = app.splitterFrame

#BUG471215
statesCheck(sFrame.split_pane, "Splitter", add_states=[states.VERTICAL])

sFrame.quit()
