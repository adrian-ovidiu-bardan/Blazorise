﻿#region Using directives
using System;
#endregion

namespace Blazorise.Components;

/// <summary>
/// Attribute that sets the Router Tabs Page attributes
/// </summary>
public class RouterTabsPageAttribute : Attribute
{
    /// <summary>
    /// Sets the name of the router tab.
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// Sets the css class of the router tab.
    /// </summary>
    public readonly string TabClass;

    /// <summary>
    /// Sets the css class of the router tab panel.
    /// </summary>
    public readonly string TabPanelClass;

    /// <summary>
    /// Whether the router tab is closeable.
    /// </summary>
    public readonly bool Closeable;

    /// <summary>
    /// Localization key for retrieving name of the tab
    /// </summary>
    public readonly string NameLocalizationKey;
    
    public RouterTabsPageAttribute( string Name, string TabClass = "", string TabPanelClass = "", bool Closeable = true )
    {
        this.Name = Name;
        this.TabClass = TabClass;
        this.TabPanelClass = TabPanelClass;
        this.Closeable = Closeable;
    }
    
    public RouterTabsPageAttribute( string NameLocalizationKey, bool Closeable = true, string TabClass = "", string TabPanelClass = "" )
    {
        this.NameLocalizationKey = NameLocalizationKey;
        this.TabClass = TabClass;
        this.TabPanelClass = TabPanelClass;
        this.Closeable = Closeable;
    }
  
}