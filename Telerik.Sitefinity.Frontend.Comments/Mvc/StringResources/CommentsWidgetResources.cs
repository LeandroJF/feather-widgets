﻿using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace Telerik.Sitefinity.Frontend.Comments.Mvc.StringResources
{
    /// <summary>
    /// Localizable strings for the Comments widget
    /// </summary>
    [ObjectInfo(typeof(CommentsWidgetResources), ResourceClassId = "CommentsResources", Title = "CommentsResourcesTitle", Description = "CommentsResourcesDescription")]
    public class CommentsWidgetResources : Resource
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsWidgetResources"/> class. 
        /// Initializes new instance of <see cref="CommentsWidgetResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public CommentsWidgetResources()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsWidgetResources"/> class.
        /// </summary>
        /// <param name="dataProvider">The data provider.</param>
        public CommentsWidgetResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }

        #endregion

        #region Meta resources

        /// <summary>
        /// Gets Comments widget resources title.
        /// </summary>
        [ResourceEntry("CommentsResourcesTitle",
            Value = "Comments widget resources",
            Description = "Title for the comments widget resources class.",
            LastModified = "2015/04/29")]
        public string CommentsResourcesTitle
        {
            get
            {
                return this["CommentsResourcesTitle"];
            }
        }

        /// <summary>
        /// Gets Comments widget resources description.
        /// </summary>
        [ResourceEntry("CommentsResourcesDescription",
            Value = "Localizable strings for the Comments widget.",
            Description = "Description for the comments widget resources class.",
            LastModified = "2015/04/29")]
        public string CommentsResourcesDescription
        {
            get
            {
                return this["CommentsResourcesDescription"];
            }
        }

        #endregion

        #region Frontend resources

        /// <summary>
        /// Gets phrase : Read full comment
        /// </summary>
        [ResourceEntry("ReadFullComment",
            Value = "Read full comment",
            Description = "phrase : Read full comment",
            LastModified = "2015/05/05")]
        public string ReadFullComment
        {
            get
            {
                return this["ReadFullComment"];
            }
        }

        /// <summary>
        /// Gets word : comments
        /// </summary>
        [ResourceEntry("CommentsPlural",
            Value = "comments",
            Description = "word : comments",
            LastModified = "2015/05/05")]
        public string CommentsPlural
        {
            get
            {
                return this["CommentsPlural"];
            }
        }

        /// <summary>
        /// Gets phrase : Leave a comment
        /// </summary>
        [ResourceEntry("LeaveComment",
            Value = "Leave a comment",
            Description = "phrase : Leave a comment",
            LastModified = "2015/05/05")]
        public string LeaveComment
        {
            get
            {
                return this["LeaveComment"];
            }
        }

        /// <summary>
        /// Gets phrase : Newest on top
        /// </summary>
        [ResourceEntry("NewestOnTop",
            Value = "Newest on top",
            Description = "phrase : Newest on top",
            LastModified = "2015/05/05")]
        public string NewestOnTop
        {
            get
            {
                return this["NewestOnTop"];
            }
        }

        /// <summary>
        /// Gets phrase : Oldest on top
        /// </summary>
        [ResourceEntry("OldestOnTop",
            Value = "Oldest on top",
            Description = "phrase : Oldest on top",
            LastModified = "2015/05/05")]
        public string OldestOnTop
        {
            get
            {
                return this["OldestOnTop"];
            }
        }

        /// <summary>
        /// Gets phrase : Load more comments
        /// </summary>
        [ResourceEntry("LoadMoreComments",
            Value = "Load more comments",
            Description = "phrase : Load more comments",
            LastModified = "2015/05/05")]
        public string LoadMoreComments
        {
            get
            {
                return this["LoadMoreComments"];
            }
        }

        /// <summary>
        /// Gets word : Submit
        /// </summary>
        [ResourceEntry("Submit",
            Value = "Submit",
            Description = "word : Submit",
            LastModified = "2015/05/05")]
        public string Submit
        {
            get
            {
                return this["Submit"];
            }
        }

        /// <summary>
        /// Gets phrase : Your name
        /// </summary>
        [ResourceEntry("YourName",
            Value = "Your name",
            Description = "phrase: Your name",
            LastModified = "2015/05/05")]
        public string YourName
        {
            get
            {
                return this["YourName"];
            }
        }

        /// <summary>
        /// Gets phrase : Email (optional)
        /// </summary>
        [ResourceEntry("EmailOptional",
            Value = "Email (optional)",
            Description = "phrase: Email (optional)",
            LastModified = "2015/05/05")]
        public string EmailOptional
        {
            get
            {
                return this["EmailOptional"];
            }
        }

        /// <summary>
        /// Gets phrase : Web site (optional)
        /// </summary>
        [ResourceEntry("WebSiteOptional",
            Value = "Web site (optional)",
            Description = "phrase: Web site (optional)",
            LastModified = "2015/05/05")]
        public string WebSiteOptional
        {
            get
            {
                return this["WebSiteOptional"];
            }
        }

        /// <summary>
        /// Gets phrase : Subscribe me to new comments via email
        /// </summary>
        [ResourceEntry("SubscribeToNewComments",
            Value = "Subscribe me to new comments via email",
            Description = "phrase: Subscribe me to new comments via email",
            LastModified = "2015/05/05")]
        public string SubscribeToNewComments
        {
            get
            {
                return this["SubscribeToNewComments"];
            }
        }

        #endregion

        #region Designer resources

        /// <summary>
        /// Gets phrase : More options
        /// </summary>
        [ResourceEntry("MoreOptions",
            Value = "More options",
            Description = "phrase : More options",
            LastModified = "2015/05/04")]
        public string MoreOptions
        {
            get
            {
                return this["MoreOptions"];
            }
        }

        /// <summary>
        /// Gets phrase : CSS classes
        /// </summary>
        [ResourceEntry("CssClasses",
            Value = "CSS classes",
            Description = "phrase : CSS classes",
            LastModified = "2015/05/04")]
        public string CssClasses
        {
            get
            {
                return this["CssClasses"];
            }
        }

        /// <summary>
        /// Gets phrase: Template
        /// </summary>
        [ResourceEntry("Template",
            Value = "Template",
            Description = "phrase : Template",
            LastModified = "2015/05/04")]
        public string Template
        {
            get
            {
                return this["Template"];
            }
        }

        #endregion
    }
}