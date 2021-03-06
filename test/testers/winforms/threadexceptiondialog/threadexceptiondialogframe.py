# vim: set tabstop=4 shiftwidth=4 expandtab
##############################################################################
# Written by:  Ray Wang <rawang@novell.com>
# Date:        02/10/2009
# Description: Application wrapper for threadexceptiondialog.py
#              be called by ../threadexceptiondialog_basic_ops.py
##############################################################################

"""Application wrapper for threadexceptiondialog.py"""

from strongwind import *

class ThreadExceptionDialogFrame(accessibles.Frame):
    """the profile of the threadexceptiondialog sample"""

    def __init__(self, accessible):
        super(ThreadExceptionDialogFrame, self).__init__(accessible)
        self.raise_button = self.findPushButton("Raise an Exception")

    def showDialog(self, accessible):
        '''
        Click on the "Raise an Exception" button and find all the accessibles
        on the ThreadExceptionDialog that opens.
        '''
        procedurelogger.action("click %s" % accessible)
        accessible.click()

        # start to find children
        self.dialog = self.app.findDialog(None)
    
        # assign controls
        DESCRIPTION = re.compile("^An unhandled exception has occurred in you application.")
        ERROR_TYPE = "Division by zero"
        self.description_label = self.dialog.findLabel(DESCRIPTION)
        self.errortype_label = self.dialog.findLabel(ERROR_TYPE)

        self.detail_button = self.dialog.findPushButton("Show Details")
        self.ignore_button = self.dialog.findPushButton("Ignore")
        self.abort_button = self.dialog.findPushButton("Abort")

    def showTextBox(self, accessible):
        """click detail_button in order to show its textbox"""
        procedurelogger.action("click %s" % accessible)
        accessible.click()
        sleep(config.SHORT_DELAY)

        if accessible is self.detail_button:
            ERROR_TITLE = "Exception details"
            self.textbox = self.dialog.findText(None)
            self.errortitle_label = self.dialog.findLabel(ERROR_TITLE)

            self.scrollbars = self.dialog.findAllScrollBars(None)
            self.scrollbar_hor = self.scrollbars[0]
            self.scrollbar_ver = self.scrollbars[1]

    def hideTextBox(self, accessible):
        """
        click detail_button in order to hide its textbox and then ensure that
        the details accessibles cannot be found
        """
        procedurelogger.action("click %s" % accessible)
        accessible.click()
        sleep(config.SHORT_DELAY)
        ERROR_TITLE = "Exception details"

        try:
            self.textbox = self.dialog.findText(None)
        except SearchError:
            return # expected
        else:
            assert False, 'Details text accessible should not be found'
        try:
            self.errortitle_label = self.dialog.findLabel(ERROR_TITLE)
        except SearchError:
            return # expected
        else:
            assert False, '"%s" label should not be found' % ERROR_TITLE

    def assignText(self, accessible, text):
        procedurelogger.action('set %s text to "%s"' % (accessible, text))
        try:
            accessible.text = text
        except NotImplementedError:
            pass

    def assertText(self, accessible, expected_text):
        """assert the accessible's text is equal to the expected text"""

        procedurelogger.action('Check the text of: %s' % accessible)
        actual_text = accessible.text
        procedurelogger.expectedResult('Text is "%s"' % actual_text)
        assert actual_text == expected_text, 'Text was "%s", expected "%s"' % \
                                                (actual_text, expected_text)

    def quit(self):
        self.altF4()
