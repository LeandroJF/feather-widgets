﻿using System;
using System.Linq;

namespace Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.FlatTaxonomy
{
    public class FlatTaxonomyModel : TaxonomyModel, IFlatTaxonomyModel
    {
        #region Properties
        /// <summary>
        /// Determines what taxa will be displayed by the widget.
        /// </summary>
        /// <value>The taxa to display.</value>
        public FlatTaxaToDisplay TaxaToDisplay { get; set; }

    

        #endregion

        #region Overriden methods
        /// <summary>
        /// Creates the view model.
        /// </summary>
        /// <returns></returns>
        public override TaxonomyViewModel CreateViewModel()
        {
            var viewModel = new TaxonomyViewModel();
            
            if (this.ContentId != Guid.Empty)
            {
                viewModel.Taxa = this.GetTaxaByContentItem();
                return viewModel;
            }

            switch (this.TaxaToDisplay)
            {
                case FlatTaxaToDisplay.Selected:
                    viewModel.Taxa = this.GetSpecificTaxa();
                    break;

                case FlatTaxaToDisplay.UsedByContentType:
                    //viewModel.Taxa = this.GetTaxaByContentType();
                    viewModel.Taxa = this.GetTaxaByContentItem();
                    break;

                default:
                    break;
                    //return this.GetAllTaxa();
            }
            return null;
        }
        #endregion
    }
}