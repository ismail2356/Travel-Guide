using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;

namespace GeziRehberiWEB1
{
    public partial class Kurumsal : System.Web.UI.Page
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Logger.Info("Kurumsal sayfası yüklendi.");
            }
        }

        protected void SomeEventHandler(object sender, EventArgs e)
        {
            try
            {
                // Some code that could potentially throw an exception.
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Bir hata oluştu.");
            }
        }
    }
}