using System;
using Microsoft.Maui.Controls.Handlers.Items2;
using UIKit;

namespace CollectionViewHandler2_IOS15_Sample.Platforms.iOS.Controllers;

public class CustomCollectionViewController2 : ReorderableItemsViewController2<ReorderableItemsView>
{
    public CustomCollectionViewController2(ReorderableItemsView reorderableItemsView, UICollectionViewLayout layout) : base(reorderableItemsView, layout)
    {
    }

    /// <summary>
    /// Suggested fix for original issue
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
