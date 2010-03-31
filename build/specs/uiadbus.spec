#
# spec file for package UiaDbus
#
# Copyright (c) 2010 SUSE LINUX Products GmbH, Nuernberg, Germany.
# This file and all modifications and additions to the pristine
# package are under the same license as the package itself.
# 
# Please submit bugfixes or comments via http://bugs.opensuse.org/ 
# 
# norootforbuild 
# 

Name:           uiadbus
Version:        2.0.2
Release:        1
License:        MIT
Group:          System/Libraries
URL:		http://www.mono-project.com/Accessibility
Source0:        %{name}-%{version}.tar.bz2
BuildRoot:      %{_tmppath}/%{name}-%{version}-build
Summary:        UiaDbus components of UIA on Linux
BuildRequires:	glib-sharp2
BuildRequires:	mono-devel >= 2.4
BuildRequires:	mono-uia-devel >= 2.0.2
BuildRequires:	ndesk-dbus

%description
UiaDbus is another communication channel for UIA on Linux between the client and provider

%package devel
License:        MIT
Summary:        Devel package for UiaDbus
Group:          Development/Libraries/Mono
Requires:       uiadbus == %{version}-%{release}

%description devel
UiaDbus is another communication channel for UIA on Linux between the client and provider

%prep
%setup -q

%build
%configure --disable-tests
make

%install
%makeinstall


%clean
rm -rf %{buildroot}

%files
%defattr(-,root,root)
%dir %{_prefix}/lib/mono/gac/UiaDbus
%{_prefix}/lib/mono/gac/UiaDbus/*
%dir %{_prefix}/lib/mono/gac/UiaDbusBridge
%{_prefix}/lib/mono/gac/UiaDbusBridge/*
%dir %{_prefix}/lib/mono/gac/UiaDbusSource
%{_prefix}/lib/mono/gac/UiaDbusSource/*
%{_prefix}/lib/mono/accessibility/UiaDbus.dll
%dir %{_libdir}/uiadbus
%{_libdir}/uiadbus/UiaDbus.dll*
%{_libdir}/uiadbus/UiaDbusBridge.dll*
%{_libdir}/uiadbus/UiaDbusSource.dll*

%files devel
%defattr(-,root,root)
%{_libdir}/pkgconfig/mono-uia-dbus.pc

%changelog
