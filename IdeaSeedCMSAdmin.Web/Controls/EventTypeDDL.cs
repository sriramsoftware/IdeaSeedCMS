﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeedCMS.Core.Domain;
using IdeaSeedCMS.Services;
using Telerik.Web.UI;
using IdeaSeed.Web.UI;
namespace IdeaSeedCMSAdmin.Web.Controls
{
    public class EventTypeDDL : DropDownList
    {
        public EventTypeDDL()
        {
            this.Items.Clear();
            this.EmptyMessage = "-- Select --";
            this.Items.Add(new RadComboBoxItem("", ""));
            this.Skin = "Metro";
            foreach (var s in new ScheduleEventTypeServices().GetAll())
            {
                this.Items.Add(new RadComboBoxItem(s.Name, s.ID.ToString()));
            }
        }
    }
}
