﻿namespace Merchello.Core.Configuration.Sections
{
    /// <summary>
    /// Represents a configuration section for configurations related to Merchello "views" and partial "views" locations. 
    /// </summary>
    public interface IViewsSection : IMerchelloConfigurationSection
    {
        /// <summary>
        /// Gets the base path for views generated by Merchello.
        /// </summary>
        /// REFACTOR-name change this the MerchelloViewsBasePath
        string MerchelloTemplatesBasePath { get; }

        /// <summary>
        /// Gets the notification template base path.
        /// </summary>
        /// REFACTOR-name change this the NotificationViewsBasePath
        string NotificationTemplateBasePath { get; }
    }
}