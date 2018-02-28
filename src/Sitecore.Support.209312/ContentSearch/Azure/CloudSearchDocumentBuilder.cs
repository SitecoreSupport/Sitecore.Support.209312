namespace Sitecore.Support.ContentSearch.Azure
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using Sitecore.ContentSearch;
    using Sitecore.ContentSearch.Azure.Config;
    using Sitecore.ContentSearch.Azure.Schema;
    using Sitecore.ContentSearch.Azure.Utils;
    using Sitecore.ContentSearch.ComputedFields;
    using Sitecore.ContentSearch.Diagnostics;
    using System.Globalization;

    public class CloudSearchDocumentBuilder : Sitecore.ContentSearch.Azure.CloudSearchDocumentBuilder
    {
        public CloudSearchDocumentBuilder(IIndexable indexable, IProviderUpdateContext context) : base(indexable, context)
        {
        }

        protected override void AddComputedIndexField(IComputedIndexField computedIndexField, object fieldValue)
        {
            //Sitecore.Support.209312
            //if (fieldValue is IEnumerable && fieldValue.GetType().IsGenericType)
            //{
            //    foreach (var field in fieldValue as IEnumerable)
            //    {
            //        this.AddField(computedIndexField.FieldName, field);
            //    }
            //}
            //else
            //{
            this.AddField(computedIndexField.FieldName, fieldValue);
            //}
        }
    }
}
