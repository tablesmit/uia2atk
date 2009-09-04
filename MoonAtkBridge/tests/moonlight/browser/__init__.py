# Permission is hereby granted, free of charge, to any person obtaining
# a copy of this software and associated documentation files (the
# "Software"), to deal in the Software without restriction, including
# without limitation the rights to use, copy, modify, merge, publish,
# distribute, sublicense, and/or sell copies of the Software, and to
# permit persons to whom the Software is furnished to do so, subject to
# the following conditions:
#
# The above copyright notice and this permission notice shall be
# included in all copies or substantial portions of the Software.
#
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
# EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
# MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
# NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
# LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
# OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
# WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#
# Copyright (c) 2009 Novell, Inc. (http://www.novell.com)
#
# Authors:
#      Brad Taylor <brad@getcoded.net>
#

import os
import signal

from strongwind import *

def launchAddress(uri, browser='firefox', profile='dev', name='Namoroka'):
    """
    Launch a browser with the selected uri and return a Browser object.
    """
    if os.environ.has_key('MOON_A11Y_BROWSER'):
        browser = os.environ['MOON_A11Y_BROWSER']
    else:
        print "** MOON_A11Y_BROWSER environment variable not found.  Defaulting to '%s'." % browser

    if os.environ.has_key('MOON_A11Y_BROWSER_PROFILE'):
        profile = os.environ['MOON_A11Y_BROWSER_PROFILE']
    else:
        print "** MOON_A11Y_BROWSER_PROFILE environment variable not found.  Defaulting to '%s'." % profile

    if os.environ.has_key('MOON_A11Y_BROWSER_NAME'):
        name = os.environ['MOON_A11Y_BROWSER_NAME']
    else:
        print "** MOON_A11Y_BROWSER_NAME environment variable not found.  Defaulting to '%s'." % name

    cwd = os.path.dirname(browser)
    if cwd == '':
        cwd = None

    args = [browser, '-no-remote', '-P', profile, uri]

    logString = 'Launch %s.' % name

    (app, proc) = cache.launchApplication(args=args, name=name, cwd=cwd,
                                          find=re.compile('^%s$' % name),
                                          wait=config.LONG_DELAY, cache=True,
                                          logString=logString, setpgid=True)
    browser = FirefoxBrowser(name, app, proc)
    cache.addApplication(browser)
    return browser


class FirefoxBrowser(accessibles.Application):
    logName = 'Mozilla Firefox'
    appNameRegex = '^(.*) - %s$'

    def __init__(self, name, accessible, subproc):
        """
        Get a refrence to the main browser window.
        """
        super(FirefoxBrowser, self).__init__(accessible, subproc)

        self.proc = subproc

        self.findFrame(re.compile(self.appNameRegex % name), logName='Main')
        self.slControl = self.mainFrame.findFiller('Silverlight Control')

    def kill(self):
        try:
            os.killpg(self.proc.pid, signal.SIGKILL)
        except:
            print "Unable to send pid %d SIGKILL..." % self.proc.pid