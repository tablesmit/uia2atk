
##############################################################################
# Written by:  Cachen Chen <cachen@novell.com>
# Date:        07/22/2008
# Description: button.py wrapper script
#              Used by the button-*.py tests
##############################################################################$

import sys
import os
import actions
import states

from strongwind import *
from button import *


# class to represent the main window.
class ButtonFrame(accessibles.Frame):

    # constants
    # the available widgets on the window
    BUTTON_ONE = "button1"
    BUTTON_TWO = "button2"
    BUTTON_TREE = "button3"

    def __init__(self, accessible):
        super(ButtonFrame, self).__init__(accessible)
        self.button1 = self.findPushButton(self.BUTTON_ONE)
        self.button2 = self.findPushButton(self.BUTTON_TWO)
        self.button3 = self.findPushButton(self.BUTTON_TREE)

    #diff Button's inital actions list with expectant list in actions.py
    def actionsCheck(self, accessible):
        procedurelogger.action('Check %s\'s actions' % accessible)

        # get list of expected actions 
        expected_actions = actions.Button.actions

        # get list of actual actions of the accessible
        qa = accessible._accessible.queryAction()
        actual_actions = [qa.getName(i) for i in range(qa.nActions)]

        procedurelogger.expectedResult('Actions: %s' % actual_actions)

        # get a list of actual states that are missing or extraneous
        missing_actions = set(expected_actions).difference(set(actual_actions))
        extra_actions = set(actual_actions).difference(set(expected_actions))

        # if missing_actions and extra_actions are empty, the test case passes
        # otherwise, throw an exception
        is_same = len(missing_actions) == 0 and len(extra_actions) == 0
        assert is_same, "\n  %s: %s\n  %s: %s" %\
                                             ("Missing actual actions: ",
                                               missing_actions,
                                              "Extraneous actual actions: ",
                                               extra_actions) 

    #check Button's all expectant states
    def statesCheck(self, accessible, control,
                                invalid_states=[], add_states=[]):
        """Check the states of an accessible using the default states
        of the accessible (specified by control class in states.py) as
        the default expected states.
       
        Keyword arguments:
        accessible -- the accessible whose states will be checked
        control -- the class name of the control whose states we want to check
        invalid_states -- a list of states that should be removed from the
        list of default expected states
        add_states -- a list of states that should be added to the list of
        default expected states

        """
        procedurelogger.action('Check %s\'s states' % accessible)
        # create a list of all states for button except "sensitive"
        states_list = states.__getattribute__(control).states
        expected_states = \
                  [s for s in states_list if s not in invalid_states]
        expected_states = set(expected_states).union(set(add_states))

        procedurelogger.expectedResult('States:  %s' % expected_states)

        # get a list of all actual states for accessible
        actual_states = accessible._accessible.getState().getStates()
        # need to convert the numbers retrieved above into their associated
        # strings
        actual_states = [pyatspi.stateToString(s) for s in actual_states]

        # assert there are no elements in expected_states that are not
        # in actual_states
        missing_states = set(expected_states).difference(set(actual_states))

        # assert there are no elements in actual_states that are not
        # in expected_states
        extra_states = set(actual_states).difference(set(expected_states))

        is_same = len(missing_states) == 0 and len(extra_states) == 0
        assert is_same, "\n  %s: %s\n  %s: %s" %\
                                             ("Missing actual states: ",
                                               missing_states,
                                              "Extraneous actual states: ",
                                               extra_states) 
        
    #give 'click' action
    def click(self,button):
        button.click()

    #check the Label text after click button2
    def assertLabel(self, labelText):
        procedurelogger.expectedResult('Label text has been changed to \"%s\"' % labelText)
        self.findLabel(labelText)

    #rise message frame window after click button1
    def assertMessage(self):
        self.message = self.app.findFrame('message')

        self.message.findPushButton('OK').click()
    
    #close application main window after running test
    def quit(self):
        self.altF4()