﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using FeatherWidgets.TestUtilities.CommonOperations;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.TestArrangementService.Attributes;
using Telerik.Sitefinity.TestUI.Arrangements.Framework;
using Telerik.Sitefinity.TestUI.Arrangements.Framework.Server;
using Telerik.Sitefinity.TestUtilities.CommonOperations;

namespace FeatherWidgets.TestUI.Arrangements
{
    /// <summary>
    /// Select All Published Images With Limits Option arrangement class.
    /// </summary>
    public class SelectAllPublishedImagesWithLimitOption : TestArrangementBase
    {
        /// <summary>
        /// Server side set up.
        /// </summary>
        [ServerSetUp]
        public void SetUp()
        {
            ServerOperations.Pages().CreatePage(PageName);

            ServerSideUpload.CreateAlbum(ImageLibraryTitle);
            ServerSideUpload.UploadImage(ImageLibraryTitle, ImageTitle + 1, ImageResource1);

            ServerSideUpload.UploadImage(ImageLibraryTitle, ImageTitle + 2, ImageResource2);

            ServerSideUpload.UploadImage(ImageLibraryTitle, ImageTitle + 3, ImageResource3);
        }

        /// <summary>
        /// Gets the current libraries provider Url name.
        /// </summary>
        [ServerArrangement]
        public void GetCurrentProviderUrlName()
        {
            // string urlName = ServerOperations.Libraries().GetCurrentProviderUrlName;

            // ServerArrangementContext.GetCurrent().Values.Add("CurrentProviderUrlName", urlName);
        }

        /// <summary>
        /// Tears down.
        /// </summary>
        [ServerTearDown]
        public void TearDown()
        {
            ServerOperations.Pages().DeleteAllPages();
            ServerOperations.Libraries().DeleteLibraries(false, "Image");
        }

        private const string PageName = "PageWithImage";
        private const string ImageLibraryTitle = "TestImageLibrary";
        private const string ImageTitle = "Image";
        private const string ImageResource1 = "Telerik.Sitefinity.TestUtilities.Data.Images.1.jpg";
        private const string ImageResource2 = "Telerik.Sitefinity.TestUtilities.Data.Images.2.jpg";
        private const string ImageResource3 = "Telerik.Sitefinity.TestUtilities.Data.Images.3.jpg";
    }
}