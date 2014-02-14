﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Web;
using IdeaSeed.Core;
using IdeaSeedCMS.Core.Domain;

namespace IdeaSeedCMS.Web.Utils
{
    public class HttpPageHelper
    {

        public static bool IsValidRequest
        {
            get { return HttpContextHelper.Get<bool>("SQ_IS_VALID_REQUEST"); }
            set { HttpContextHelper.Set("SQ_IS_VALID_REQUEST", value); }
        }

        public static IBaseItem CurrentItem
        {
            get { return HttpContextHelper.Get<IBaseItem>("SQ_CURRENTITEM"); }
            set { HttpContextHelper.Set("SQ_CURRENTITEM", value); }
        }

        public static Page CurrentPage
        {
            get { return HttpContextHelper.Get<Page>("SQ_CURRENTPAGE"); }
            set { HttpContextHelper.Set("SQ_CURRENTPAGE", value); }
        }

        public static User CurrentUser
        {
            get { return HttpContextHelper.Get<User>("SQ_CURRENTUSER"); }
            set { HttpContextHelper.Set("SQ_CURRENTUSER", value); }
        }

        public static BlogPostType CurrentBlogPostType
        {
            get { return HttpContextHelper.Get<BlogPostType>("SQ_CURRENTBLOGPOSTTYPE"); }
            set { HttpContextHelper.Set("SQ_CURRENTBLOGPOSTTYPE", value); }
        }

        public static Blog CurrentBlog
        {
            get { return HttpContextHelper.Get<Blog >("SQ_CURRENTBLOG"); }
            set { HttpContextHelper.Set("SQ_CURRENTBLOG", value); }
        }
    }
}
