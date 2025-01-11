using System;
using Microsoft.Maui.Controls.Handlers.Items2;
using UIKit;

namespace CollectionViewHandler2_IOS15_Sample.Platforms.iOS.Controllers;

public class CustomCarouselViewController2 : CarouselViewController2
{
    public CustomCarouselViewController2(CarouselView itemsView, UICollectionViewLayout layout) : base(itemsView, layout)
    {
    }
    
    /// <summary>
    /// Apply the same fix for CarouselView
    /// </summary>
    /// <param name="collectionView"></param>
    /// <returns></returns>
    public override nint NumberOfSections(UICollectionView collectionView)
    {
        if (ItemsSource == null)
        {
            return 0;
        }

        return base.NumberOfSections(collectionView);
    }
}
