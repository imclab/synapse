// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using Qyoto;


public partial class RosterWidget : QWidget {
    
    protected QWidget m_AccountsContainer;
    
    protected Synapse.QtClient.Widgets.NotificationsWidget notificationsWidget;
    
    protected QSplitter splitter;
    
    protected QWidget widget;
    
    protected QTabWidget tabWidget;
    
    protected QWidget friendsTab;
    
    protected QFrame gridHeader;
    
    protected QLabel statsLabel;
    
    protected QPushButton rosterSearchButton;
    
    protected QPushButton rosterViewButton;
    
    protected QPushButton addFriendButton;
    
    protected QWidget friendSearchContainer;
    
    protected QLineEdit friendSearchLineEdit;
    
    protected Synapse.QtClient.Widgets.AvatarGrid<Synapse.UI.RosterItem> rosterGrid;
    
    protected QWidget chatroomsTab;
    
    protected QPushButton m_ShoutButton_2;
    
    protected QPushButton m_PostLinkButton_2;
    
    protected QWidget quickJoinMucContainer;
    
    protected QLabel label;
    
    protected QLineEdit m_ChatNameEdit;
    
    protected QPushButton m_JoinChatButton;
    
    protected QSplitter splitter_2;
    
    protected QWidget widget_3;
    
    protected QLabel label_4;
    
    protected QWebView friendMucListWebView;
    
    protected QWidget widget_2;
    
    protected QLabel label_3;
    
    protected QTreeView mucTree;
    
    protected QWidget activityTab;
    
    protected QPushButton m_ShoutButton;
    
    protected QPushButton m_PostLinkButton;
    
    protected QPushButton m_PostFileButton;
    
    protected QWidget shoutContainer;
    
    protected QLineEdit shoutLineEdit;
    
    protected QLabel shoutCharsLabel;
    
    protected QWebView m_ActivityWebView;
    
    protected void SetupUi() {
        base.ObjectName = "RosterWidget";
        this.Geometry = new QRect(0, 0, 345, 494);
        this.WindowTitle = "RosterWidget";
        this.StyleSheet = "";
        QVBoxLayout verticalLayout_6;
        verticalLayout_6 = new QVBoxLayout(this);
        verticalLayout_6.Spacing = 0;
        verticalLayout_6.Margin = 0;
        this.m_AccountsContainer = new QWidget(this);
        this.m_AccountsContainer.ObjectName = "m_AccountsContainer";
        QSizePolicy m_AccountsContainer_sizePolicy;
        m_AccountsContainer_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Preferred, QSizePolicy.Policy.Preferred);
        m_AccountsContainer_sizePolicy.SetVerticalStretch(0);
        m_AccountsContainer_sizePolicy.SetHorizontalStretch(0);
        m_AccountsContainer_sizePolicy.SetHeightForWidth(this.m_AccountsContainer.SizePolicy.HasHeightForWidth());
        this.m_AccountsContainer.SizePolicy = m_AccountsContainer_sizePolicy;
        verticalLayout_6.AddWidget(this.m_AccountsContainer);
        this.notificationsWidget = new Synapse.QtClient.Widgets.NotificationsWidget(this);
        this.notificationsWidget.ObjectName = "notificationsWidget";
        this.notificationsWidget.FrameShape = QFrame.Shape.NoFrame;
        this.notificationsWidget.FrameShadow = QFrame.Shadow.Raised;
        verticalLayout_6.AddWidget(this.notificationsWidget);
        this.splitter = new QSplitter(this);
        this.splitter.ObjectName = "splitter";
        this.splitter.Orientation = Qt.Orientation.Vertical;
        verticalLayout_6.AddWidget(this.splitter);
        this.widget = new QWidget(this.splitter);
        this.widget.ObjectName = "widget";
        QVBoxLayout verticalLayout_2;
        verticalLayout_2 = new QVBoxLayout(this.widget);
        verticalLayout_2.Margin = 0;
        this.tabWidget = new QTabWidget(this.widget);
        this.tabWidget.ObjectName = "tabWidget";
        this.tabWidget.tabPosition = QTabWidget.TabPosition.South;
        this.tabWidget.tabShape = QTabWidget.TabShape.Rounded;
        this.tabWidget.CurrentIndex = 0;
        this.tabWidget.UsesScrollButtons = true;
        verticalLayout_2.AddWidget(this.tabWidget);
        this.friendsTab = new QWidget(this.tabWidget);
        this.friendsTab.ObjectName = "friendsTab";
        QVBoxLayout verticalLayout_4;
        verticalLayout_4 = new QVBoxLayout(this.friendsTab);
        verticalLayout_4.Spacing = 0;
        verticalLayout_4.Margin = 0;
        this.gridHeader = new QFrame(this.friendsTab);
        this.gridHeader.ObjectName = "gridHeader";
        this.gridHeader.AutoFillBackground = true;
        this.gridHeader.FrameShape = QFrame.Shape.NoFrame;
        this.gridHeader.FrameShadow = QFrame.Shadow.Raised;
        QHBoxLayout horizontalLayout_6;
        horizontalLayout_6 = new QHBoxLayout(this.gridHeader);
        horizontalLayout_6.Spacing = 3;
        horizontalLayout_6.Margin = 3;
        this.statsLabel = new QLabel(this.gridHeader);
        this.statsLabel.ObjectName = "statsLabel";
        QSizePolicy statsLabel_sizePolicy;
        statsLabel_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Preferred);
        statsLabel_sizePolicy.SetVerticalStretch(0);
        statsLabel_sizePolicy.SetHorizontalStretch(0);
        statsLabel_sizePolicy.SetHeightForWidth(this.statsLabel.SizePolicy.HasHeightForWidth());
        this.statsLabel.SizePolicy = statsLabel_sizePolicy;
        this.statsLabel.Text = "";
        horizontalLayout_6.AddWidget(this.statsLabel);
        this.rosterSearchButton = new QPushButton(this.gridHeader);
        this.rosterSearchButton.ObjectName = "rosterSearchButton";
        this.rosterSearchButton.FocusPolicy = Qt.FocusPolicy.TabFocus;
        this.rosterSearchButton.ToolTip = "Search friends";
        this.rosterSearchButton.Text = "";
        this.rosterSearchButton.Checkable = true;
        this.rosterSearchButton.Checked = false;
        this.rosterSearchButton.Flat = true;
        horizontalLayout_6.AddWidget(this.rosterSearchButton);
        this.rosterViewButton = new QPushButton(this.gridHeader);
        this.rosterViewButton.ObjectName = "rosterViewButton";
        this.rosterViewButton.FocusPolicy = Qt.FocusPolicy.TabFocus;
        this.rosterViewButton.ToolTip = "Change view options";
        this.rosterViewButton.Text = "";
        this.rosterViewButton.Flat = true;
        horizontalLayout_6.AddWidget(this.rosterViewButton);
        this.addFriendButton = new QPushButton(this.gridHeader);
        this.addFriendButton.ObjectName = "addFriendButton";
        this.addFriendButton.FocusPolicy = Qt.FocusPolicy.TabFocus;
        this.addFriendButton.ToolTip = "Add & Invite new friends";
        this.addFriendButton.Text = "";
        this.addFriendButton.Flat = true;
        horizontalLayout_6.AddWidget(this.addFriendButton);
        verticalLayout_4.AddWidget(this.gridHeader);
        this.friendSearchContainer = new QWidget(this.friendsTab);
        this.friendSearchContainer.ObjectName = "friendSearchContainer";
        QHBoxLayout horizontalLayout;
        horizontalLayout = new QHBoxLayout(this.friendSearchContainer);
        horizontalLayout.Spacing = 0;
        horizontalLayout.Margin = 3;
        this.friendSearchLineEdit = new QLineEdit(this.friendSearchContainer);
        this.friendSearchLineEdit.ObjectName = "friendSearchLineEdit";
        horizontalLayout.AddWidget(this.friendSearchLineEdit);
        verticalLayout_4.AddWidget(this.friendSearchContainer);
        this.rosterGrid = new Synapse.QtClient.Widgets.AvatarGrid<Synapse.UI.RosterItem>(this.friendsTab);
        this.rosterGrid.ObjectName = "rosterGrid";
        this.rosterGrid.FocusPolicy = Qt.FocusPolicy.StrongFocus;
        this.rosterGrid.FrameShape = QFrame.Shape.NoFrame;
        this.rosterGrid.Alignment = ((global::Qyoto.Qyoto.GetCPPEnumValue("Qt", "AlignLeading") | global::Qyoto.Qyoto.GetCPPEnumValue("Qt", "AlignLeft")) | global::Qyoto.Qyoto.GetCPPEnumValue("Qt", "AlignTop"));
        verticalLayout_4.AddWidget(this.rosterGrid);
        this.tabWidget.AddTab(this.friendsTab, "Friends");
        this.chatroomsTab = new QWidget(this.tabWidget);
        this.chatroomsTab.ObjectName = "chatroomsTab";
        QVBoxLayout verticalLayout_3;
        verticalLayout_3 = new QVBoxLayout(this.chatroomsTab);
        verticalLayout_3.Spacing = 0;
        verticalLayout_3.Margin = 0;
        QHBoxLayout horizontalLayout_5;
        horizontalLayout_5 = new QHBoxLayout();
        verticalLayout_3.AddLayout(horizontalLayout_5);
        horizontalLayout_5.Spacing = 12;
        horizontalLayout_5.Margin = 6;
        QSpacerItem horizontalSpacer1;
        horizontalSpacer1 = new QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
        horizontalLayout_5.AddItem(horizontalSpacer1);
        this.m_ShoutButton_2 = new QPushButton(this.chatroomsTab);
        this.m_ShoutButton_2.ObjectName = "m_ShoutButton_2";
        this.m_ShoutButton_2.StyleSheet = "";
        this.m_ShoutButton_2.Text = "Quick Join";
        this.m_ShoutButton_2.icon = new QIcon("../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-text.png../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-text.png");
        this.m_ShoutButton_2.Checkable = true;
        this.m_ShoutButton_2.AutoExclusive = false;
        this.m_ShoutButton_2.Flat = true;
        horizontalLayout_5.AddWidget(this.m_ShoutButton_2);
        this.m_PostLinkButton_2 = new QPushButton(this.chatroomsTab);
        this.m_PostLinkButton_2.ObjectName = "m_PostLinkButton_2";
        this.m_PostLinkButton_2.Text = "Browse";
        this.m_PostLinkButton_2.icon = new QIcon("../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-link.png../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-link.png");
        this.m_PostLinkButton_2.Checkable = true;
        this.m_PostLinkButton_2.AutoExclusive = false;
        this.m_PostLinkButton_2.Flat = true;
        horizontalLayout_5.AddWidget(this.m_PostLinkButton_2);
        QSpacerItem horizontalSpacer_21;
        horizontalSpacer_21 = new QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
        horizontalLayout_5.AddItem(horizontalSpacer_21);
        this.quickJoinMucContainer = new QWidget(this.chatroomsTab);
        this.quickJoinMucContainer.ObjectName = "quickJoinMucContainer";
        QGridLayout gridLayout_2;
        gridLayout_2 = new QGridLayout(this.quickJoinMucContainer);
        gridLayout_2.HorizontalSpacing = 6;
        gridLayout_2.VerticalSpacing = 0;
        gridLayout_2.SetContentsMargins(6, 0, 6, 6);
        this.label = new QLabel(this.quickJoinMucContainer);
        this.label.ObjectName = "label";
        this.label.Text = "Join Conference Room:";
        gridLayout_2.AddWidget(this.label, 0, 0, 1, 1);
        this.m_ChatNameEdit = new QLineEdit(this.quickJoinMucContainer);
        this.m_ChatNameEdit.ObjectName = "m_ChatNameEdit";
        this.m_ChatNameEdit.MaxLength = 150;
        gridLayout_2.AddWidget(this.m_ChatNameEdit, 1, 0, 1, 1);
        this.m_JoinChatButton = new QPushButton(this.quickJoinMucContainer);
        this.m_JoinChatButton.ObjectName = "m_JoinChatButton";
        this.m_JoinChatButton.Text = "Join";
        gridLayout_2.AddWidget(this.m_JoinChatButton, 1, 1, 1, 1);
        verticalLayout_3.AddWidget(this.quickJoinMucContainer);
        this.splitter_2 = new QSplitter(this.chatroomsTab);
        this.splitter_2.ObjectName = "splitter_2";
        this.splitter_2.Orientation = Qt.Orientation.Vertical;
        verticalLayout_3.AddWidget(this.splitter_2);
        this.widget_3 = new QWidget(this.splitter_2);
        this.widget_3.ObjectName = "widget_3";
        QVBoxLayout verticalLayout_7;
        verticalLayout_7 = new QVBoxLayout(this.widget_3);
        verticalLayout_7.Spacing = 6;
        verticalLayout_7.Margin = 0;
        this.label_4 = new QLabel(this.widget_3);
        this.label_4.ObjectName = "label_4";
        this.label_4.Text = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\np, li { white-space: pre-wrap; }\n</style></head><body style=\" font-family:'DejaVu Sans'; font-size:9pt; font-weight:400; font-style:normal;\">\n<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><span style=\" font-weight:600;\">Friends</span></p></body></html>";
        verticalLayout_7.AddWidget(this.label_4);
        this.friendMucListWebView = new QWebView(this.widget_3);
        this.friendMucListWebView.ObjectName = "friendMucListWebView";
        this.friendMucListWebView.Url = new QUrl("about:blank");
        verticalLayout_7.AddWidget(this.friendMucListWebView);
        this.splitter_2.AddWidget(this.widget_3);
        this.widget_2 = new QWidget(this.splitter_2);
        this.widget_2.ObjectName = "widget_2";
        QVBoxLayout verticalLayout_5;
        verticalLayout_5 = new QVBoxLayout(this.widget_2);
        verticalLayout_5.Spacing = 6;
        verticalLayout_5.SetContentsMargins(0, 6, 0, 0);
        this.label_3 = new QLabel(this.widget_2);
        this.label_3.ObjectName = "label_3";
        this.label_3.Text = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\np, li { white-space: pre-wrap; }\n</style></head><body style=\" font-family:'DejaVu Sans'; font-size:9pt; font-weight:400; font-style:normal;\">\n<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><span style=\" font-weight:600;\">Bookmarks</span></p></body></html>";
        verticalLayout_5.AddWidget(this.label_3);
        this.mucTree = new QTreeView(this.widget_2);
        this.mucTree.ObjectName = "mucTree";
        this.mucTree.FrameShape = QFrame.Shape.NoFrame;
        this.mucTree.Animated = true;
        this.mucTree.HeaderHidden = true;
        verticalLayout_5.AddWidget(this.mucTree);
        this.splitter_2.AddWidget(this.widget_2);
        this.tabWidget.AddTab(this.chatroomsTab, "Conferences");
        this.activityTab = new QWidget(this.tabWidget);
        this.activityTab.ObjectName = "activityTab";
        QVBoxLayout verticalLayout;
        verticalLayout = new QVBoxLayout(this.activityTab);
        verticalLayout.Spacing = 0;
        verticalLayout.sizeConstraint = QLayout.SizeConstraint.SetDefaultConstraint;
        verticalLayout.Margin = 0;
        QHBoxLayout horizontalLayout_2;
        horizontalLayout_2 = new QHBoxLayout();
        verticalLayout.AddLayout(horizontalLayout_2);
        horizontalLayout_2.Spacing = 12;
        horizontalLayout_2.Margin = 6;
        QSpacerItem horizontalSpacer;
        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
        horizontalLayout_2.AddItem(horizontalSpacer);
        this.m_ShoutButton = new QPushButton(this.activityTab);
        this.m_ShoutButton.ObjectName = "m_ShoutButton";
        this.m_ShoutButton.StyleSheet = "";
        this.m_ShoutButton.Text = "Shout!";
        this.m_ShoutButton.icon = new QIcon("../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-text.png../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-text.png");
        this.m_ShoutButton.Checkable = true;
        this.m_ShoutButton.AutoExclusive = false;
        this.m_ShoutButton.Flat = true;
        horizontalLayout_2.AddWidget(this.m_ShoutButton);
        this.m_PostLinkButton = new QPushButton(this.activityTab);
        this.m_PostLinkButton.ObjectName = "m_PostLinkButton";
        this.m_PostLinkButton.Text = "Post Link";
        this.m_PostLinkButton.icon = new QIcon("../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-link.png../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-link.png");
        this.m_PostLinkButton.Checkable = true;
        this.m_PostLinkButton.AutoExclusive = false;
        this.m_PostLinkButton.Flat = true;
        horizontalLayout_2.AddWidget(this.m_PostLinkButton);
        this.m_PostFileButton = new QPushButton(this.activityTab);
        this.m_PostFileButton.ObjectName = "m_PostFileButton";
        this.m_PostFileButton.Text = "Post File";
        this.m_PostFileButton.icon = new QIcon("../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-image.png../../../../../../../../usr/share/icons/gnome/16x16/actions/insert-image.png");
        this.m_PostFileButton.Checkable = true;
        this.m_PostFileButton.AutoExclusive = false;
        this.m_PostFileButton.Flat = true;
        horizontalLayout_2.AddWidget(this.m_PostFileButton);
        QSpacerItem horizontalSpacer_2;
        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
        horizontalLayout_2.AddItem(horizontalSpacer_2);
        this.shoutContainer = new QWidget(this.activityTab);
        this.shoutContainer.ObjectName = "shoutContainer";
        QHBoxLayout horizontalLayout_3;
        horizontalLayout_3 = new QHBoxLayout(this.shoutContainer);
        horizontalLayout_3.Spacing = 6;
        horizontalLayout_3.SetContentsMargins(6, 0, 6, 6);
        this.shoutLineEdit = new QLineEdit(this.shoutContainer);
        this.shoutLineEdit.ObjectName = "shoutLineEdit";
        this.shoutLineEdit.MaxLength = 140;
        horizontalLayout_3.AddWidget(this.shoutLineEdit);
        this.shoutCharsLabel = new QLabel(this.shoutContainer);
        this.shoutCharsLabel.ObjectName = "shoutCharsLabel";
        this.shoutCharsLabel.Text = "140";
        horizontalLayout_3.AddWidget(this.shoutCharsLabel);
        verticalLayout.AddWidget(this.shoutContainer);
        this.m_ActivityWebView = new QWebView(this.activityTab);
        this.m_ActivityWebView.ObjectName = "m_ActivityWebView";
        this.m_ActivityWebView.Url = new QUrl("about:blank");
        verticalLayout.AddWidget(this.m_ActivityWebView);
        this.tabWidget.AddTab(this.activityTab, "Activity");
        this.splitter.AddWidget(this.widget);
        QObject.Connect(m_ShoutButton, Qt.SIGNAL("toggled(bool)"), shoutContainer, Qt.SLOT("setShown(bool)"));
        QObject.Connect(m_ShoutButton_2, Qt.SIGNAL("toggled(bool)"), quickJoinMucContainer, Qt.SLOT("setShown(bool)"));
        QMetaObject.ConnectSlotsByName(this);
    }
}
