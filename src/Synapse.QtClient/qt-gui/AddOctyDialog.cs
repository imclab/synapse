// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Synapse.QtClient.Windows {
    using System;
    using Qyoto;
    
    
    public partial class AddOctyDialog : QDialog {
        
        protected QWebView webView;
        
        protected void SetupUi() {
            base.ObjectName = "AddOctyDialog";
            this.Geometry = new QRect(0, 0, 597, 409);
            this.WindowTitle = "Synapse is ready to go!";
            QHBoxLayout horizontalLayout;
            horizontalLayout = new QHBoxLayout(this);
            horizontalLayout.Spacing = 0;
            horizontalLayout.Margin = 0;
            this.webView = new QWebView(this);
            this.webView.ObjectName = "webView";
            this.webView.Url = new QUrl("about:blank");
            horizontalLayout.AddWidget(this.webView);
            QMetaObject.ConnectSlotsByName(this);
        }
    }
}