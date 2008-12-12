

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG"
ASSEMBLY = ../../build/Debug/PasteBox.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../../build/Debug/Synapse.UI.dll \
	../../build/Debug/Synapse.Services.dll \
	../../build/Debug/Synapse.Core.dll
BUILD_DIR = ../../build/Debug

SYNAPSE_SERVICES_DLL_SOURCE=../../build/Debug/Synapse.Services.dll
SYNAPSE_SERVICES_DLL=$(BUILD_DIR)/Synapse.Services.dll
SYNAPSE_DLL=
QTWEBKIT_DLL_CONFIG_SOURCE=../../../../../../usr/lib/cli/kdebindings-2.2/qtwebkit.dll.config
PASTEBOX_DLL_MDB_SOURCE=../../build/Debug/PasteBox.dll.mdb
PASTEBOX_DLL_MDB=$(BUILD_DIR)/PasteBox.dll.mdb
DRAGON_CORE_DLL=
SYNAPSE_CORE_DLL_SOURCE=../../build/Debug/Synapse.Core.dll
SYNAPSE_CORE_DLL=$(BUILD_DIR)/Synapse.Core.dll
SYNAPSE_UI_DLL_SOURCE=../../build/Debug/Synapse.UI.dll
SYNAPSE_UI_DLL=$(BUILD_DIR)/Synapse.UI.dll
SYNAPSE_CORE_DLL_MDB_SOURCE=../../build/Debug/Synapse.Core.dll.mdb
SYNAPSE_CORE_DLL_MDB=$(BUILD_DIR)/Synapse.Core.dll.mdb
JABBER_NET_DLL_MDB_SOURCE=../../contrib/jabber-net.dll.mdb
SYNAPSE_UI_DLL_MDB_SOURCE=../../build/Debug/Synapse.UI.dll.mdb
SYNAPSE_UI_DLL_MDB=$(BUILD_DIR)/Synapse.UI.dll.mdb
HYENA_DLL_MDB_SOURCE=../../contrib/Hyena.dll.mdb
SYNAPSE_XMPP_DLL_MDB_SOURCE=../../build/Debug/Synapse.Xmpp.dll.mdb
SYNAPSE_XMPP_DLL_MDB=$(BUILD_DIR)/Synapse.Xmpp.dll.mdb
DRAGON_SERVICES_DLL=
SYNAPSE_SERVICES_DLL_MDB_SOURCE=../../build/Debug/Synapse.Services.dll.mdb
SYNAPSE_SERVICES_DLL_MDB=$(BUILD_DIR)/Synapse.Services.dll.mdb
HYENA_DLL_SOURCE=../../contrib/Hyena.dll
DRAGON_CORE_XMPP_DLL=
QTWEBKIT_DLL_SOURCE=../../../../../../usr/lib/cli/kdebindings-2.2/qtwebkit.dll
SYNAPSE_XMPP_DLL_SOURCE=../../build/Debug/Synapse.Xmpp.dll
SYNAPSE_XMPP_DLL=$(BUILD_DIR)/Synapse.Xmpp.dll
JABBER_NET_DLL_SOURCE=../../contrib/jabber-net.dll

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize-
ASSEMBLY = bin/Release/PasteBox.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../../src/Synapse.UI/bin/Release/Synapse.dll \
	../../build/Release/Dragon.Services.dll \
	../../build/Release/Dragon.Core.dll
BUILD_DIR = bin/Release

SYNAPSE_SERVICES_DLL=
SYNAPSE_DLL_SOURCE=../../src/Synapse.UI/bin/Release/Synapse.dll
SYNAPSE_DLL=$(BUILD_DIR)/Synapse.dll
QTWEBKIT_DLL_CONFIG_SOURCE=../../../../../../usr/lib/cli/kdebindings-2.2/qtwebkit.dll.config
PASTEBOX_DLL_MDB=
DRAGON_CORE_DLL_SOURCE=../../build/Release/Dragon.Core.dll
DRAGON_CORE_DLL=$(BUILD_DIR)/Dragon.Core.dll
SYNAPSE_CORE_DLL=
SYNAPSE_UI_DLL=
SYNAPSE_CORE_DLL_MDB=
JABBER_NET_DLL_MDB_SOURCE=../../contrib/jabber-net.dll.mdb
SYNAPSE_UI_DLL_MDB=
HYENA_DLL_MDB_SOURCE=../../contrib/Hyena.dll.mdb
SYNAPSE_XMPP_DLL_MDB=
DRAGON_SERVICES_DLL_SOURCE=../../build/Release/Dragon.Services.dll
DRAGON_SERVICES_DLL=$(BUILD_DIR)/Dragon.Services.dll
SYNAPSE_SERVICES_DLL_MDB=
HYENA_DLL_SOURCE=../../contrib/Hyena.dll
DRAGON_CORE_XMPP_DLL_SOURCE=../../src/Synapse.Xmpp/bin/Release/Dragon.Core.Xmpp.dll
DRAGON_CORE_XMPP_DLL=$(BUILD_DIR)/Dragon.Core.Xmpp.dll
QTWEBKIT_DLL_SOURCE=../../../../../../usr/lib/cli/kdebindings-2.2/qtwebkit.dll
SYNAPSE_XMPP_DLL=
JABBER_NET_DLL_SOURCE=../../contrib/jabber-net.dll

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(SYNAPSE_SERVICES_DLL) \
	$(SYNAPSE_DLL) \
	$(QTWEBKIT_DLL_CONFIG) \
	$(PASTEBOX_DLL_MDB) \
	$(DRAGON_CORE_DLL) \
	$(SYNAPSE_CORE_DLL) \
	$(SYNAPSE_UI_DLL) \
	$(SYNAPSE_CORE_DLL_MDB) \
	$(JABBER_NET_DLL_MDB) \
	$(SYNAPSE_UI_DLL_MDB) \
	$(HYENA_DLL_MDB) \
	$(SYNAPSE_XMPP_DLL_MDB) \
	$(DRAGON_SERVICES_DLL) \
	$(SYNAPSE_SERVICES_DLL_MDB) \
	$(HYENA_DLL) \
	$(DRAGON_CORE_XMPP_DLL) \
	$(QTWEBKIT_DLL) \
	$(SYNAPSE_XMPP_DLL) \
	$(JABBER_NET_DLL)  

LINUX_PKGCONFIG = \
	$(PASTEBOX_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES = \
	ActionHandler.cs \
	PasteBoxDialog.cs \
	qt-gui/PasteBoxDialog.cs \
	CodePasteFormatter.cs \
	IPasteFormatter.cs 

DATA_FILES = 

RESOURCES = \
	PasteBox.addin.xml \
	SyntaxHighlighter.css \
	SyntaxHighlighter.js 

EXTRAS = \
	pastebox.pc.in 

REFERENCES =  \
	$(QYOTO_LIBS)

DLL_REFERENCES =  \
	../../../../../../usr/lib/cli/kdebindings-2.2/qtwebkit.dll

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

QTWEBKIT_DLL_CONFIG = $(BUILD_DIR)/qtwebkit.dll.config
JABBER_NET_DLL_MDB = $(BUILD_DIR)/jabber-net.dll.mdb
HYENA_DLL_MDB = $(BUILD_DIR)/Hyena.dll.mdb
PASTEBOX_PC = $(BUILD_DIR)/pastebox.pc
HYENA_DLL = $(BUILD_DIR)/Hyena.dll
QTWEBKIT_DLL = $(BUILD_DIR)/qtwebkit.dll
JABBER_NET_DLL = $(BUILD_DIR)/jabber-net.dll

$(eval $(call emit-deploy-target,SYNAPSE_DLL))
$(eval $(call emit-deploy-target,QTWEBKIT_DLL_CONFIG))
$(eval $(call emit-deploy-target,DRAGON_CORE_DLL))
$(eval $(call emit-deploy-target,JABBER_NET_DLL_MDB))
$(eval $(call emit-deploy-target,HYENA_DLL_MDB))
$(eval $(call emit-deploy-target,DRAGON_SERVICES_DLL))
$(eval $(call emit-deploy-wrapper,PASTEBOX_PC,pastebox.pc))
$(eval $(call emit-deploy-target,HYENA_DLL))
$(eval $(call emit-deploy-target,DRAGON_CORE_XMPP_DLL))
$(eval $(call emit-deploy-target,QTWEBKIT_DLL))
$(eval $(call emit-deploy-target,JABBER_NET_DLL))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY) $(ASSEMBLY_MDB): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
