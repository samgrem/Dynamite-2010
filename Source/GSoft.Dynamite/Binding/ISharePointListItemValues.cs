﻿using Microsoft.SharePoint;

namespace GSoft.Dynamite.Binding
{
    /// <summary>
    /// Values that are loaded from a SharePoint list.
    /// </summary>
    public interface ISharePointListItemValues
    {
        /// <summary>
        /// Gets the list item.
        /// </summary>
        SPListItem ListItem { get; }
    }
}
