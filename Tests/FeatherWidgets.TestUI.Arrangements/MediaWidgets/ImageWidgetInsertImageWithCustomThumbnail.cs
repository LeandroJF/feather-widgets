﻿using System;
using System.Collections.Generic;
using FeatherWidgets.TestUtilities.CommonOperations;
using Telerik.Sitefinity.TestArrangementService.Attributes;
using Telerik.Sitefinity.TestUI.Arrangements.Framework;
using Telerik.Sitefinity.TestUI.Arrangements.Framework.Server;
using Telerik.Sitefinity.TestUtilities.CommonOperations;

namespace FeatherWidgets.TestUI.Arrangements
{
    /// <summary>
    /// ImageWidgetInsertImageWithCustomThumbnail arrangement class.
    /// </summary>
    public class ImageWidgetInsertImageWithCustomThumbnail : TestArrangementBase
    {
        /// <summary>
        /// Server side set up.
        /// </summary>
        [ServerSetUp]
        public void SetUp()
        {
            ServerOperations.Pages().CreatePage(PageName);
            ServerSideUpload.CreateAlbum(ImageLibraryTitle);
            ServerSideUpload.UploadImage(ImageLibraryTitle, ImageTitle + 1, ImageResource);

            ServerSideUpload.UploadImage(ImageLibraryTitle, ImageTitle + 2, ImageResourceChild);
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

        /// <summary>
        /// Gets the current libraries provider Url name.
        /// </summary>
        [ServerArrangement]
        public void GetCurrentProviderUrlName()
        {
            // string urlName = ServerOperations.Libraries().GetCurrentProviderUrlName;

            // ServerArrangementContext.GetCurrent().Values.Add("CurrentProviderUrlName", urlName);
        }

        private const string PageName = "PageWithImage";
        private const string ImageLibraryTitle = "TestImageLibrary";
        private const string ImageTitle = "Image";
        private const string ImageResource = "Telerik.Sitefinity.TestUtilities.Data.Images.1.jpg";
        private const string ImageResourceChild = "Telerik.Sitefinity.TestUtilities.Data.Images.2.jpg";
    }
}