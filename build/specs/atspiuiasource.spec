#
# spec file for package AtspiUiaSource
#
# Copyright (c) 2010 SUSE LINUX Products GmbH, Nuernberg, Germany.
# This file and all modifications and additions to the pristine
# package are under the same license as the package itself.
# 
# Please submit bugfixes or comments via http://bugs.opensuse.org/ 
# 
# norootforbuild 
# 


Name:           atspiuiasource
Version:        2.0.2
Release:        1
License:        MIT
Group:          System/Libraries
URL:		http://www.mono-project.com/Accessibility
Source0:        %{name}-%{version}.tar.bz2
BuildRoot:      %{_tmppath}/%{name}-%{version}-build
Summary:        At-spi uia source
BuildRequires:	at-spi-sharp-devel >= 1.0
BuildRequires:	glib-sharp2 >= 2.12.8
BuildRequires:	mono-devel >= 2.4
BuildRequires:	mono-uia-devel >= 2.0.2
BuildRequires:	pkg-config

%description
At-spi uia source client side

%prep
%setup -q

%build
%configure --disable-tests
#make %{?_smp_mflags}
make

%install
%makeinstall

%clean
rm -rf %{buildroot}

%files
%defattr(-,root,root)
%dir %{_prefix}/lib/mono/gac/AtspiUiaSource
%{_prefix}/lib/mono/gac/AtspiUiaSource/*
%dir %{_libdir}/atspiuiasource
%{_libdir}/atspiuiasource/*

%changelog
